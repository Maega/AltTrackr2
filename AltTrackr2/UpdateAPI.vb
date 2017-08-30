Module UpdateAPI

    'Software: Maega cobWEB
    'Module: UpdateAPI.vb
    'Description: Super-Primitive Update Backend for Maega Products (works well though)
    'Developer: Tristan Gauci
    'Organisation: Maega

    Public Const AppID As String = "6"
    Public Const CurrentVer As Decimal = 1.04
    Public Const AppName As String = "Maega AltTrackr"
    Public AppShortName As String = "AltTrackr (Private Beta)"

    Public Const RegLoc As String = "HKEY_CURRENT_USER\Software\Maega\" + AppID + "\"
    Public Const MIHLoc As String = "HKEY_CURRENT_USER\Software\Maega\2\" '2 is the ID of MIH
    Public Const GlobalLoc As String = "HKEY_CURRENT_USER\Software\Maega\GlobalPrefs\"
    Dim rapp As String, rupdate As String, rforce As String, rverify As Decimal, appindex As Integer, rcalc As Decimal, rmessage As String = Nothing, rlver As Decimal, rfname As String, regverval As String
    Dim verified As Boolean = False
    Dim vericode As String
    Dim verifyfactor As Decimal = 7.38
    Dim apiserver As String = "https://api.maeganetwork.com/update.php" 'This should point to the API backend on the update server
    Function LatestVer()
        PerformCheck(AppID)
        If verified = True Then
            Return CDec(rlver)
        Else
            MsgBox("Server verification failed. The connection to the update server may have been tampered with.", MsgBoxStyle.Critical)
            Exit Function
        End If
    End Function

    Sub PerformCheck(appid As String)
        Console.WriteLine(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + " - " + "Info: Performing Update Check")
        'Generate a 7 digit validation code.
        vericode = String.Empty
        Dim AllowedChars() As String = {"0123456789"}
        Dim rnd = New Random()
        While vericode.Length < 8
            Dim rndSet As Integer = rnd.Next(0, AllowedChars.Length)
            vericode &= AllowedChars(rndSet).Substring(rnd.Next(0, AllowedChars(rndSet).Length), 1)
        End While

        'Create query and submit
        Dim apiquery As String = "?app=" + appid.ToLower + "&verify=" + vericode

        Try
            Dim apiresponse As String = New System.Net.WebClient().DownloadString(apiserver + apiquery)
            'Check API response for errors
            Dim ErrorResponses() As String = {"MISSINGAPPCODE", "MISSINGVERCODE", "MISSINGVERIFYCODE", "INVALIDAPPCODE"}
            If ErrorResponses.Any(Function(b) apiresponse.Contains(b)) Then
                'This should never happen - it means the API query is missing a value
                MsgBox("There was a problem checking for updates. Please try again later or contact support if this issue persists.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            'Set variables according to the API response - removes the response headers and sets variables to the corresponding responses.
            appindex = apiresponse.IndexOf("APP=")
            rapp = apiresponse.Substring(appindex + 4, apiresponse.IndexOf(";", appindex + 1) - appindex - 4)
            appindex = apiresponse.IndexOf("LVER=")
            rlver = apiresponse.Substring(appindex + 5, apiresponse.IndexOf(";", appindex + 1) - appindex - 5)
            appindex = apiresponse.IndexOf("FNAME=")
            rfname = apiresponse.Substring(appindex + 6, apiresponse.IndexOf(";", appindex + 1) - appindex - 6)
            If apiresponse.Contains("MESSAGE=") Then
                appindex = apiresponse.IndexOf("MESSAGE=")
                rmessage = apiresponse.Substring(appindex + 8, apiresponse.IndexOf(";", appindex + 1) - appindex - 8)
            End If
            appindex = apiresponse.IndexOf("VERIFY=")
            'Convert the verification code to decimal and truncate to zero decimal places
            rverify = Math.Truncate(CDec(apiresponse.Substring(appindex + 7, apiresponse.IndexOf(";", appindex + 1) - appindex - 7)))
            'Perform arithmetic verification operation
            rcalc = Math.Truncate(CDec(vericode) / verifyfactor)
            'Check if the arithmetic operation performed on the server matches the one performed locally, if it does, set the 'verified' boolean to True
            If rcalc = rverify Then verified = True
            If Not rmessage = Nothing And rupdate = 1 Then
                'This is where we would output the message pulled from the server.
                'Main.News.Text = rmessage
                'Main.News.Text = Main.News.Text.Replace("/\", vbNewLine)
            End If
            'Set rmessage back to nothing in case the next query doesn't contain a message; if it doesn't, and this wasn't here, the application would output "Message: ". Likewise do the same for the 'verified' boolean
            'rmessage = Nothing
            'verified = False
        Catch ex As Exception
            MsgBox("We weren't able to connect to the update servers. Please check your connection and try again later.", MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub

    Sub CheckForUpdates()
        If LatestVer() > CurrentVer Then
            Dim result As Integer = MessageBox.Show("An update is available for " + AppName + ", would you like to update now?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                My.Computer.Registry.SetValue(MIHLoc, "TargetFriendlyName", AppName.Replace("Maega ", String.Empty))
                My.Computer.Registry.SetValue(MIHLoc, "TargetDBID", AppID)
                My.Computer.Registry.SetValue(MIHLoc, "TargetLatestVersion", LatestVer)
                My.Computer.Registry.SetValue(MIHLoc, "updlocalpath", My.Computer.Registry.GetValue(RegLoc, "AppExe", Nothing))
                My.Computer.Registry.SetValue(MIHLoc, "updnow", "1")
                Try
                    Dim p() As Process
                    p = Process.GetProcessesByName("InnovationHub")
                    If Not p.Count > 0 Then Process.Start(My.Computer.Registry.GetValue(MIHLoc, "AppExe", Nothing))
                    End
                Catch ex As Exception
                    MsgBox("Failed to launch MIH", MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub

    Function UpdateAvailable()
        If LatestVer() > CurrentVer Then
            Return True
        Else
            Return False
        End If
    End Function
End Module