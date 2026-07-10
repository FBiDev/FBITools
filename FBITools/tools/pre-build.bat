@echo off
setlocal EnableDelayedExpansion EnableExtensions

set "EventType=Pre-build"
set "EventName=Clean lib"

set "ProjectName=%1"
set "TargetDir=%2"

echo ===============================================================================
echo    Project      ::     %ProjectName%
echo    Event        ::     Begin %EventType% -^> %EventName%
echo ===============================================================================

rd /s /q "%TargetDir%lib\"

echo ===============================================================================
echo    Project      ::     %ProjectName%
echo    Event        ::     End %EventType% -^> %EventName%
echo    Result       ::     ExitCode: %errorlevel%
echo ===============================================================================
echo:

if %errorlevel% leq 4 (
	exit 0
) else (
	exit %errorlevel%
)