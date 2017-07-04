#include "ulauncher.h"

#include <windows.h>

void getname(char* buffer, DWORD bufsize)
{
	HKEY hKey;
	if (RegOpenKeyEx(HKEY_CURRENT_USER, "Software\\SAMP", 0, KEY_READ, &hKey) != ERROR_SUCCESS) {
		return;
	}
	if (RegQueryValueEx(hKey, "PlayerName", NULL, NULL, (LPBYTE)buffer, &bufsize) != ERROR_SUCCESS)
	{
		MessageBoxA(NULL, "Could not get the location of your GTA:SA installation. Is SA-MP installed correctly?", "SA:MP Launcher", MB_ICONERROR);
	}
	RegCloseKey(hKey);
}

void launch()
{
	printf("launching\n");

	// Get the module handle to kernal32.dll
	HMODULE hMod = GetModuleHandle("kernel32.dll");

	if (!hMod)
	{
		MessageBoxA(NULL, "Could not find kernel32.dll", "SA:MP Launcher", MB_ICONERROR);
		return;
	}
	
	// Create address variable to hold the address of the LoadLibrary function.
	void* addr = (void*)GetProcAddress(hMod, "LoadLibraryA");

	if (addr == NULL)
	{
		MessageBoxA(NULL, "Could not find the address of LoadLibraryA", "SA:MP Launcher", MB_ICONERROR);
		return;
	}

	// Prepare to create a new process.
	PROCESS_INFORMATION ProcessInfo;
	STARTUPINFO StartupInfo;

	memset(&ProcessInfo, 0, sizeof(PROCESS_INFORMATION));
	memset(&StartupInfo, 0, sizeof(STARTUPINFO));

	// Get the IP.
	char ip[24] = "127.0.0.1";
	int port = 7775;

	// Get the user's gta_sa location
	char exeLocation[256], name[24];
	DWORD buffer = sizeof(exeLocation);

	// Open registry key
	HKEY hKey;
	long lError = RegOpenKeyEx(HKEY_CURRENT_USER,
		"Software\\SAMP",
		0,
		KEY_READ,
		&hKey);

	// Get value
	DWORD dwRet = RegQueryValueEx(hKey, "gta_sa_exe", NULL, NULL, (LPBYTE)&exeLocation, &buffer);

	// Make sure we got a good value for the gta_sa path
	if (dwRet != ERROR_SUCCESS)
	{
		MessageBoxA(NULL, "Could not get the location of your GTA:SA installation. Is SA-MP installed correctly?", "SA:MP Launcher", MB_ICONERROR);
		return;
	}

	// remove \gta_sa.exe in a new variable (leaving just the directory path)
	char path[256];
	strcpy_s(path, sizeof(path), exeLocation);
	path[strlen(path) - 11] = '\0';

	// Get the player name
	buffer = sizeof(name);
	dwRet = RegQueryValueEx(hKey, "PlayerName", NULL, NULL, (LPBYTE)&name, &buffer);

	// Close registry
	RegCloseKey(hKey);

	if (dwRet != ERROR_SUCCESS)
	{
		MessageBoxA(NULL, "could not get player name", "SA:MP Launcher", MB_ICONERROR);
		return;
	}

	// Construct it all in one command line string.
	char commandLine[128];
	sprintf_s(commandLine, sizeof(commandLine), "-c -h %s -p %d -n %s", ip, port, name);
	printf("name %s", name);

	// Create a new process, but don't let it run yet, it's suspended.
	if (!CreateProcess(exeLocation, commandLine, NULL, NULL, FALSE, DETACHED_PROCESS | CREATE_SUSPENDED, NULL, path, &StartupInfo, &ProcessInfo))
	{
		MessageBoxA(NULL, "could not make process", "SA:MP Launcher", MB_ICONERROR);
		return;
	}

	// Create a new string that will hold the path to the file samp.dll
	char szWithSampdll[256] = "";
	sprintf_s(szWithSampdll, sizeof(szWithSampdll), "%s\\samp.dll", path);

	// Allocate memory in the new process we just created to store the string of the samp.dll file path.
	void* arg = (void*)VirtualAllocEx(ProcessInfo.hProcess, NULL, strlen(szWithSampdll), MEM_RESERVE | MEM_COMMIT, PAGE_READWRITE);
	
	if (arg == NULL)
	{
		MessageBoxA(NULL, "Memory could not be allocated to inject samp.dll. If you run the game as admin, you should run this launcher as admin too", "SA:MP Launcher", MB_ICONERROR);
		return;
	}

	// Write to the memory we just allocated the file path to samp.dll including directory.
	WriteProcessMemory(ProcessInfo.hProcess, arg, szWithSampdll, strlen(szWithSampdll), NULL);

	// Create a remote thread that calls LoadLibrary, and as the parameter, the memory location we just wrote the samp.dll path to.
	// also don't execute this thread, but just create.
	HANDLE id = CreateRemoteThread(ProcessInfo.hProcess, NULL, 0, (LPTHREAD_START_ROUTINE)addr, arg, CREATE_SUSPENDED, NULL);

	if (!id)
	{
		MessageBoxA(NULL, "the ID returned from CreateRemoteThread was invalid.", "SA:MP Launcher", MB_ICONERROR);
		return;
	}

	// Resume the remote thread.
	ResumeThread(id);
	// Wait for the remote thread to finish executing.
	WaitForSingleObject(id, INFINITE);

	// Free the memory we just allocated that stores the samp.dll file path since LoadLibrary has been called and it's not needed anymore.
	VirtualFreeEx(ProcessInfo.hProcess, arg, 0, MEM_RELEASE);

	// Resume the process (It was suspended, remember?)
	ResumeThread(ProcessInfo.hThread);

	// Close the handle to the process we created.
	CloseHandle(ProcessInfo.hProcess);

}
