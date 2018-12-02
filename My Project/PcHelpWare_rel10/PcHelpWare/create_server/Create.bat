@ECHO OFF
mkdir server
copy upx.exe server\upx.exe
copy replaceicon.exe server\replaceicon.exe
copy 7z.exe server\7z.exe
copy config.txt server\config.txt
copy PcHelpWare.sfx server\PcHelpWare.sfx

copy PcHelpWare.exe server\PcHelpWare.exe
copy SCHook.dll server\SCHook.dll
copy 1SCDLL.dll server\1SCDLL.dll
copy 1CHATDLL.dll server\1CHATDLL.dll

copy custom\icon1.ico server\icon1.ico
copy custom\background.bmp server\background.bmp
copy custom\helpdesk.txt server\helpdesk.txt

cd server
replaceicon.exe PcHelpWare.sfx icon1.ico
upx --best --crp-ms=999999 --nrv2b PcHelpWare.sfx
7z a -mx=9 -t7z PcHelpWare.7z PcHelpWare.exe SCHook.dll background.bmp helpdesk.txt 1SCDLL.dll 1CHATDLL.dll icon1.ico
copy /b PcHelpWare.sfx + config.txt + PcHelpWare.7z PcHelpWare_server.exe
mkdir ..\..\myservers\%1
copy PcHelpWare_server.exe ..\..\myservers\%1\PcHelpWare_server.exe

