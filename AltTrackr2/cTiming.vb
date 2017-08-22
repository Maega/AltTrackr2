Public Class cTiming

    Public Const appVer As Decimal = UpdateAPI.CurrentVer
    Public Shared CredentialArray() As String

    Public Shared Sub transitionForms(fromForm As Form, toForm As Form, Optional synclocation As Boolean = True, Optional hideOnly As Boolean = False)
        Dim opacityStepping As Double = 0.1
        toForm.Opacity = 1
        fromForm.Opacity = 1
        toForm.Show()
        If synclocation Then toForm.Location = fromForm.Location
        Dim originalTopMost As Boolean = fromForm.TopMost
        fromForm.TopMost = True
        pause(20)
        Do Until fromForm.Opacity <= 0
            fromForm.Opacity -= opacityStepping
            pause(1)
        Loop
        fromForm.TopMost = originalTopMost
        If hideOnly Then fromForm.Hide() Else fromForm.Close()
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

    Public Shared _colour As Color
    Public Shared Sub ShowAlert(coinname As String, frequency As String, priceup As Boolean, changepercent As String, holdingsvalue As String, coinprice As String)
        Select Case frequency.ToUpper
            Case "D"
                frequency = "Daily"
            Case "W"
                frequency = "Weekly"
            Case "M"
                frequency = "Monthly"
        End Select

        Dim friendlyAlert As String
        Dim img As Image
        If priceup Then
            friendlyAlert = "Good news! " + coinname + " is up " + changepercent + "% in the last 24 hours."
            img = frmHomeMulti.ilsImg.Images.Item(4)
        Else
            friendlyAlert = "Bad news! " + coinname + " is down " + changepercent + "% in the last 24 hours."
            img = frmHomeMulti.ilsImg.Images.Item(1)
        End If

        Dim notif As New Notification(img, coinname + " " + frequency + " Price Update", friendlyAlert + vbNewLine + "Holdings Value: " + holdingsvalue + vbNewLine + "Coin Price: " + coinprice, _colour)
        notif.Seconds = 10
        notif.Show()
    End Sub

    Public Shared Sub ShowNotif(body As String, title As String, Optional duration As Integer = 10)

        Dim img As Image = frmHomeMulti.ilsImg.Images.Item(4)

        Dim notif As New Notification(img, title, body, _colour)
        notif.Seconds = duration
        notif.Show()
    End Sub
End Class
