@echo off
if not "%1" == "" if not "%2" == "" goto :argsexists
echo usage: base64decode input-file output-file
goto :eof
:argsexists
certutil -decode "%1" "%2"
