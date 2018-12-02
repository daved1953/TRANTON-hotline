Module oldcode
    'Private Sub Playresponse_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DPlayGreetingEvents_EnterEvent) Handles Playresponse.EnterEvent
    ''''Dim DigitEntered As Integer
    ''''DigitEntered = Msurvey.Digits(e.channel)
    ''''Select Case DigitEntered
    ''''    Case 1
    ''''        e.greeting.RemoveAll()
    ''''    Case 2
    ''''        'inserts some different system phrases
    ''''        'plays the number of files in c:\
    ''''        e.greeting.InsertSysPhrase(0, VBVoiceLib.vbvSysPhraseConstants.vbvNumFiles, "c:\*.*", "")
    ''''        'plays a phrase from a .vap file, based on the script
    ''''        e.greeting.InsertSysPhrase(1, VBVoiceLib.vbvSysPhraseConstants.vbvVAPPhrase, "vbvoice30.vap", "fifteen")
    ''''        'plays a phrase from a .vap file, based on the indexed position
    ''''        e.greeting.InsertSysPhrase(2, VBVoiceLib.vbvSysPhraseConstants.vbvVAPPhraseIndex, "record.vap", 3)
    ''''        'plays the current time
    ''''        e.greeting.InsertSysPhrase(3, VBVoiceLib.vbvSysPhraseConstants.vbvTimeNow, "", "")
    ''''    Case 3
    ''''        'modifies the existing (single) phrase to be
    ''''        'a differnt kind - sys phrase, money which will
    ''''        'play $12.35
    ''''        Dim phrs As New VBVoiceLib.Phrase()
    ''''        phrs = e.greeting.Phrase(0)
    ''''        phrs.PhrsType = VBVoiceLib.vbvPhraseTypeConstants.vbvSYSPHRASE
    ''''        phrs.Type = VBVoiceLib.vbvSysPhraseConstants.vbvMoney
    ''''        phrs.PhraseData1 = "1235"
    ''''    Case 4
    ''''        'inserts files/phrases
    ''''        'inserts .wav file, could also do .vox file
    ''''        e.greeting.InsertFile(0, "C:\PROGRA~1\Pronexus\VBVoice\music.wav")
    ''''        'inserts phrase from .vap file, similar to the
    ''''        'second phrase in case 2
    ''''        e.greeting.InsertNamedPhrase(1, "C:\PROGRA~1\Pronexus\VBVoice\vbvoice30.vap", "five")
    ''''    Case 5
    ''''        'creates a new phrase object
    ''''        'fills in the data (phrase type, type of sys phrase, data)
    ''''        'replaces existing phrase with the new one (could insert
    ''''        'instead of replacing
    ''''        Dim NewPhrase As Object
    ''''        NewPhrase = New VBVoiceLib.Phrase()   'CreateObject("vbv.phrase")
    ''''        NewPhrase.PhrsType = VBVoiceLib.vbvPhraseTypeConstants.vbvSYSPHRASE
    ''''        NewPhrase.Type = VBVoiceLib.vbvSysPhraseConstants.vbvSayNumber
    ''''        NewPhrase.PhraseData1 = "1000"
    ''''        e.greeting.InsertPhrase(0, NewPhrase)
    ''''        'could use:
    ''''        'e.greeting.InsertPhrase 0, NewPhrase
    ''''        'instead
    ''''    Case 6
    ''''        'same as case 5, execept for the check phrase
    ''''        On Error GoTo check_err
    ''''        Dim NewPhrase2 As Object
    ''''        NewPhrase2 = New VBVoiceLib.Phrase()   'CreateObject("vbv.phrase")
    ''''        NewPhrase2.PhrsType = VBVoiceLib.vbvPhraseTypeConstants.vbvSYSPHRASE
    ''''        NewPhrase2.Type = VBVoiceLib.vbvSysPhraseConstants.vbvSayNumber
    ''''        NewPhrase2.PhraseData1 = "1000"
    ''''        NewPhrase2.CheckPhrase() '<----
    ''''        e.greeting.InsertPhrase(0, NewPhrase2)
    ''''    Case 7
    ''''        'do nothing, so exit
    ''''        Exit Sub
    ''''    Case Else
    ''''        'on invalid digit goto the onhook ctrl
    ''''        OnHook1.TakeCall(e.channel)
    ''''End Select


    'UPDATE ReportData INNER JOIN Respdata ON ReportData.Confirmation = Respdata.Confirmation SET ReportData.Confirmation = "1111112", Respdata.Confirmation = "1111112"
    'WHERE (((ReportData.Confirmation)="NC11229202"));



    '        Exit Sub

    'error_handle:
    '        OnHook1.TakeCall(e.channel)
    '        Exit Sub

    'check_err:
    '        OnHook1.TakeCall(e.channel)
    '        Debug.WriteLine("check phrase error")
    '        'here you would take steps to find out the
    '        'cause of the error and possibly fix it

    '    End Sub


End Module
