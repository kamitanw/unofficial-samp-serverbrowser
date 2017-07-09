@echo off

#define OREXIT ||(pause & exit)
#define EC(X) (X)OREXIT
#define M(X) /addmodule:X
#define NM(X) M(X).netmodule
#define NM2(X,Y) NM(X) NM(Y)
#define NM3(X,Y,Z) NM2(X,Y) NM(Z)
#define NM4(X,Y,Z,A) NM3(X,Y,Z) NM(A)
#define NM5(X,Y,Z,A,B) NM4(X,Y,Z,A) NM(B)
#define NM6(X,Y,Z,A,B,C) NM5(X,Y,Z,A,B) NM(C)
#define NM7(X,Y,Z,A,B,C,D) NM6(X,Y,Z,A,B,C) NM(D)
#define CSC(X) EC(csc /target:module %~2 X)
#define COMMA ,

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
EC(resgen.exe Icons.resx Icons.resources)
echo.
echo cpp
EC(cl.exe /Zi /MD /c ulauncher.cpp)
EC(cl.exe /Zi /clr /c mlauncher.cpp)
echo.
echo icons
CSC(Icons.Designer.cs)
echo structs
CSC(ServerInfo.cs)
CSC(NM(ServerInfo) ServerRow.cs)
echo uistuff
CSC(CustomListView.cs)
CSC(CustomSplitter.cs)
echo serverquery
CSC(NM(ServerInfo) ServerQuery.cs)
echo serverproviders
CSC(NM(ServerInfo) serverproviders/IServerProvider.cs)
CSC(NM2(ServerInfo,IServerProvider) serverproviders/TestServerProvider.cs)
CSC(NM2(ServerInfo,IServerProvider) serverproviders/GameStateServerProvider.cs)
echo frmmain
CSC(NM7(Icons.Designer,ServerInfo,ServerRow,IServerProvider,ServerQuery,CustomListView,CustomSplitter) M(mlauncher.obj) /define:WITHLAUNCHER FrmMain.cs FrmMain.Designer.cs)
echo loader
CSC(NM4(FrmMain,IServerProvider,TestServerProvider,GameStateServerProvider) Loader.cs)
echo.
echo - linking
link Advapi32.lib user32.lib mlauncher.obj ulauncher.obj Icons.Designer.netmodule ServerInfo.netmodule ServerRow.netmodule IServerProvider.netmodule TestServerProvider.netmodule GameStateServerProvider.netmodule ServerQuery.netmodule CustomListView.netmodule CustomSplitter.netmodule frmMain.netmodule Loader.netmodule /entry:yugecin.sampbrowser.Loader.Main /subsystem:%subsystem% /out:sampbrowser.exe /ltcg /assemblyresource:Icons.resources,yugecin.sampbrowser.Icons.resources OREXIT

pause
