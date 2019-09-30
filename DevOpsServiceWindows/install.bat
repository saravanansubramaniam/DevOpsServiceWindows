@ECHO OFF

REM The following directory is for .NET 4.0
set DOTNETFX4=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%DOTNETFX4%

echo Installing DevOpsServiceWindows.exe...
echo ---------------------------------------------------
InstallUtil /i F:\dotnet-project\DevOpsServiceWindows\DevOpsServiceWindows\bin\Release\DevOpsServiceWindows.exe
echo ---------------------------------------------------
echo Done.
pause
