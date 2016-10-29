@echo off

set subsystem=windows
if [%~1] NEQ [] set subsystem=%~1

del *.obj
del *.netmodule

set p="S:\broftware\Microsoft Visual Studio 14.0\VC\bin\vcvars32.bat"

if not exist %p% (
	echo "Please edit build.bat and change the path to the directory which contains vcvars32.bat and cl.exe"
	pause
	exit
)

call %p%

echo cpp
cl.exe /Zi /MD /c ulauncher.cpp
cl.exe /Zi /clr /c mlauncher.cpp
csc /target:module ServerInfo.cs
echo serverquery
csc /target:module %~2 /addmodule:ServerInfo.netmodule ServerQuery.cs
echo serverproviders
csc /target:module %~2 /addmodule:ServerInfo.netmodule serverproviders/IServerProvider.cs
csc /target:module %~2 /addmodule:ServerInfo.netmodule /addmodule:IserverProvider.netmodule serverproviders/TestServerProvider.cs
csc /target:module %~2 /addmodule:ServerInfo.netmodule /addmodule:IserverProvider.netmodule serverproviders/GameStateServerProvider.cs
echo frmmain
csc /target:module %~2 /addmodule:ServerInfo.netmodule /addmodule:IServerProvider.netmodule /addmodule:TestServerProvider.netmodule /addmodule:ServerQuery.netmodule frmMain.cs frmMain.Designer.cs
echo loader
csc /target:module %~2 /addmodule:frmMain.netmodule /addmodule:IServerProvider.netmodule /addmodule:TestServerProvider.netmodule /addmodule:GameStateServerProvider.netmodule /addmodule:mlauncher.obj /define:WITHLAUNCHER Loader.cs
echo.
echo - linking
link Advapi32.lib user32.lib mlauncher.obj ulauncher.obj ServerInfo.netmodule IServerProvider.netmodule TestServerProvider.netmodule GameStateServerProvider.netmodule ServerQuery.netmodule frmMain.netmodule Loader.netmodule /entry:yugecin.sampbrowser.Loader.Main /subsystem:%subsystem% /out:sampbrowser.exe /ltcg

pause
