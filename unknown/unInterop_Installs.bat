rem remove the old Pronexus.VBVoice
cd C:\hotline\

C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u VBVoiceLib
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u DYNRESOURCELib
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u VBVRINGLib
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u WAPOCXLib
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u VBVCALLQLib
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u D42OCXLib
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u LINESTATUSLib
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u CONVERSATIONOCXLib
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u VBVoiceSupportLib
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u CONVERSATIONSERVERLib
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u VBFAX32COMLib
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\gacutil /u VBVoiceDotnetInterface

cd C:\hotline

C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete VBVoiceLib.dll
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete DYNRESOURCELib.dll
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete VBVRINGLib.dll
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete WAPOCXLib.dll
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete VBVCALLQLib.dll
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete D42OCXLib.dll
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete LINESTATUSLib.dll
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete CONVERSATIONOCXLib.dll
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete VBVoiceSupportLib.dll
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete CONVERSATIONSERVERLib.dll
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete VBFAX32COMLib.dll
C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\ngen /delete VBVoiceDotnetInterface.dll
