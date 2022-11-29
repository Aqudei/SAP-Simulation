@echo off
set  counter=0
mkdir "Welcome" 2>nul || goto :TryNext
:continue
REM rest of your code

goto :eof
:TryNext
set /a counter+=1
mkdir "Welcome (%counter%)" 2>nul || goto :TryNext
goto :continue