rem servername = servername

@echo off

set /p servername="Enter Server name: "

cd sql

sqlcmd -S %servername% -E -i Creator.sql

cd entity

sqlcmd -S %servername% -E -i Action.sql
sqlcmd -S %servername% -E -i Admin.sql
sqlcmd -S %servername% -E -i History.sql
sqlcmd -S %servername% -E -i Request.sql
sqlcmd -S %servername% -E -i Step.sql
sqlcmd -S %servername% -E -i Ticket.sql
sqlcmd -S %servername% -E -i Type.sql
sqlcmd -S %servername% -E -i User.sql

cd ..

sqlcmd -S %servername% -E -i setnocount.sql,Filler.sql

echo Database Installed
pause
