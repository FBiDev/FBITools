echo -------------------------------------------------------------------------------
echo    Post-buid    ::     Move Plugins

robocopy "..\..\..\..\App\Assembly\data " ".\ " SQLite.Interop.dll /XO

set SolutionName=%1
robocopy ".\ " "Plugins\ " /XF *.exe *.config *.json *.manifest %SolutionName%.pdb /XD Plugins /IS /MOV

if %errorlevel% leq 4 echo Post-buid ExitCode: %errorlevel%&echo:& exit 0 else exit %errorlevel%