echo -------------------------------------------------------------------------------
echo    Post-buid    ::     Move Plugins
set SolutionName=%1
robocopy "..\..\..\..\App\Assembly\data " ".\ " SQLite.Interop.dll /XO
robocopy ".\ " "Plugins\ " /XF *.exe *.config *.json *.manifest %SolutionName%.pdb /XD Plugins /IS /MOV
if %errorlevel% leq 4 echo Post-buid ExitCode: %errorlevel%&echo:& exit 0 else exit %errorlevel%