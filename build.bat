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

echo.
echo resource files
resgen.exe Icons.resx Icons.resources
echo.
echo cpp
cl.exe /Zi /MD /c ulauncher.cpp
cl.exe /Zi /clr /c mlauncher.cpp
echo.
echo icons
csc /target:module %~2 Icons.Designer.cs
echo structs
csc /target:module %~2 ServerInfo.cs
csc /target:module %~2 /addmodule:ServerInfo.netmodule ServerRow.cs
echo uistuff
csc /target:module %~2 CustomListView.cs
echo serverquery
csc /target:module %~2 /addmodule:ServerInfo.netmodule ServerQuery.cs
echo serverproviders
csc /target:module %~2 /addmodule:ServerInfo.netmodule serverproviders/IServerProvider.cs
csc /target:module %~2 /addmodule:ServerInfo.netmodule /addmodule:IServerProvider.netmodule serverproviders/TestServerProvider.cs
csc /target:module %~2 /addmodule:ServerInfo.netmodule /addmodule:IServerProvider.netmodule serverproviders/GameStateServerProvider.cs
echo frmmain
csc /target:module %~2 /addmodule:Icons.Designer.netmodule /addmodule:ServerInfo.netmodule /addmodule:ServerRow.netmodule /addmodule:IServerProvider.netmodule /addmodule:ServerQuery.netmodule /addmodule:CustomListView.netmodule FrmMain.cs FrmMain.Designer.cs
echo loader
csc /target:module %~2 /addmodule:FrmMain.netmodule /addmodule:IServerProvider.netmodule /addmodule:TestServerProvider.netmodule /addmodule:GameStateServerProvider.netmodule /addmodule:mlauncher.obj /define:WITHLAUNCHER Loader.cs
echo.
echo - linking
link Advapi32.lib user32.lib mlauncher.obj ulauncher.obj Icons.Designer.netmodule ServerInfo.netmodule ServerRow.netmodule IServerProvider.netmodule TestServerProvider.netmodule GameStateServerProvider.netmodule ServerQuery.netmodule CustomListView.netmodule frmMain.netmodule Loader.netmodule /entry:yugecin.sampbrowser.Loader.Main /subsystem:%subsystem% /out:sampbrowser.exe /ltcg /assemblyresource:Icons.resources,yugecin.sampbrowser.Icons.resources

pause
