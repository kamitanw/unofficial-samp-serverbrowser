# 1 "build.src.bat"
# 1 "<built-in>"
# 1 "<command-line>"
# 1 "build.src.bat"
@echo off
# 16 "build.src.bat"
cls
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
(resgen.exe Icons.resx Icons.resources)||(pause & exit)
echo.
echo cpp
(cl.exe /Zi /MD /c ulauncher.cpp)||(pause & exit)
(cl.exe /Zi /clr /c mlauncher.cpp)||(pause & exit)
echo.
echo icons
(csc /target:module %~2 Icons.Designer.cs)||(pause & exit)
echo structs
(csc /target:module %~2 ServerInfo.cs)||(pause & exit)
(csc /target:module %~2 /addmodule:ServerInfo.netmodule ServerRow.cs)||(pause & exit)
echo uistuff
(csc /target:module %~2 CustomListView.cs)||(pause & exit)
(csc /target:module %~2 CustomSplitter.cs)||(pause & exit)
echo serverquery
(csc /target:module %~2 /addmodule:ServerInfo.netmodule ServerQuery.cs)||(pause & exit)
echo serverproviders
(csc /target:module %~2 /addmodule:ServerInfo.netmodule serverproviders/IServerProvider.cs)||(pause & exit)
(csc /target:module %~2 /addmodule:ServerInfo.netmodule /addmodule:IServerProvider.netmodule serverproviders/TestServerProvider.cs)||(pause & exit)
(csc /target:module %~2 /addmodule:ServerInfo.netmodule /addmodule:IServerProvider.netmodule serverproviders/GameStateServerProvider.cs)||(pause & exit)
echo frmmain
(csc /target:module %~2 /addmodule:Icons.Designer.netmodule /addmodule:ServerInfo.netmodule /addmodule:ServerRow.netmodule /addmodule:IServerProvider.netmodule /addmodule:ServerQuery.netmodule /addmodule:CustomListView.netmodule /addmodule:CustomSplitter.netmodule /addmodule:mlauncher.obj /define:WITHLAUNCHER FrmMain.cs FrmMain.Designer.cs)||(pause & exit)
echo loader
(csc /target:module %~2 /addmodule:FrmMain.netmodule /addmodule:IServerProvider.netmodule /addmodule:TestServerProvider.netmodule /addmodule:GameStateServerProvider.netmodule Loader.cs)||(pause & exit)
echo.
echo - linking
link Advapi32.lib user32.lib mlauncher.obj ulauncher.obj Icons.Designer.netmodule ServerInfo.netmodule ServerRow.netmodule IServerProvider.netmodule TestServerProvider.netmodule GameStateServerProvider.netmodule ServerQuery.netmodule CustomListView.netmodule CustomSplitter.netmodule frmMain.netmodule Loader.netmodule /entry:yugecin.sampbrowser.Loader.Main /subsystem:%subsystem% /out:sampbrowser.exe /ltcg /assemblyresource:Icons.resources,yugecin.sampbrowser.Icons.resources ||(pause & exit)

pause
