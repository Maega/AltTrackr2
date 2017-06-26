Public Class cTiming

    Public Const appVer As Decimal = UpdateAPI.CurrentVer
    Public Shared CredentialArray() As String

    Public Shared Sub transitionForms(fromForm As Form, toForm As Form, Optional synclocation As Boolean = True)
        Dim opacityStepping As Double = 0.1
        toForm.Opacity = 1
        fromForm.Opacity = 1
        toForm.Show()
        If synclocation Then toForm.Location = fromForm.Location
        fromForm.TopMost = True
        pause(20)
        Do Until fromForm.Opacity <= 0
            fromForm.Opacity -= opacityStepping
            pause(1)
        Loop
        fromForm.TopMost = False
        fromForm.Close()
    End Sub

    Declare Function GetTickCount Lib "kernel32" Alias "GetTickCount" () As Long

    Public Shared Sub pause(milliseconds As Long)
        Dim i As Long
        i = GetTickCount + milliseconds
        Do While GetTickCount < i
            Application.DoEvents()
        Loop
    End Sub

    Public Shared Sub WriteDebug(output As String)
        Console.WriteLine(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + " - " + output)
        'DebugLog.rtfAppLog.AppendText(output + vbNewLine)
        'DebugLog.rtfAppLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + " - " + output + vbNewLine) 'If My.Settings.DebugMode Then 
    End Sub
End Class
