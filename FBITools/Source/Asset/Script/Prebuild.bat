echo -------------------------------------------------------------------------------
echo    Pre-buid     ::     Clean/Copy Plugins

robocopy "..\..\Plugins\ " "Plugins\ " /PURGE /XF .gitkeep

if %errorlevel% leq 4 echo Pre-buid ExitCode: %errorlevel%&echo:& exit 0 else exit %errorlevel%