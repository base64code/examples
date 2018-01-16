@echo off
if not "%1" == "" if not "%2" == "" goto :argsexists
echo usage: base64encode input-file output-file
goto :eof
:argsexists
certutil -encode "%1" "%2"
