rem @echo off
setlocal

set BUILD_ROOT=%~dp0
set PATH=%PATH%;%BUILD_ROOT%tools;

pushd IronScheme.Console\bin\Release\

mkdir merged >nul 2>&1

ILMerge /keyfile:DEVELOPMENT.snk /out:merged\IronScheme.dll IronScheme.dll IronScheme.Closures.dll IronScheme.Scripting.dll Oyster.IntX.dll ironscheme.boot.dll 


popd