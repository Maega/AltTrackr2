Imports System.Text.RegularExpressions

Module AccountsAPI

    'Software: Maega Innovation Hub
    'Module: UpdateAPI.vb
    'Description: Accounts Backend for Maega Products
    'Organisation: Maega

    'This code uses wildly insecure methods of handling login. It'll be fine for the early betas, but by production we'll be sending POST requests to the server with a unique ID bound to the user's IP address instead of a B64'd password.
    'Currently we're using similar local password storage methods to FileZilla.

    Dim rlicense As String, appindex As Integer
    Dim apiserver As String = "https://api.maeganetwork.com/accounts.php" 'This should point to the API backend on the accounts server
    Dim WebLoginPath As String = "https://accounts.maeganetwork.com/autologin.php" 'This should point to the autologin script on the accounts server

    Function PerformCheck(uname As String, upass As String, Optional b64 As Boolean = True)
        Console.WriteLine(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + " - " + "Info: Performing Login Check")

        'Create query and submit
        If b64 Then
            Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(upass)
            upass = Convert.ToBase64String(byt)
        End If
        Dim apiquery As String = "?uname=" + uname + "&upass=" + upass

        Try
            Dim apiresponse As String = New System.Net.WebClient().DownloadString(apiserver + apiquery)
            'Check API response for errors
            If apiresponse.Contains("MISSINGPARAMETER") Then
                'This should never happen - it means the API query is missing the ?app value
                MsgBox("A parameter code is missing. Something has gone very wrong. Please contact support.", MsgBoxStyle.Critical)
                Return "FAIL"
            End If

            'Set variables according to the API response - removes the response headers and sets variables to the corresponding responses.
            'appindex = apiresponse.IndexOf("USRLICENSES=")
            'MsgBox(appindex.ToString)
            'rlicense = apiresponse.Substring(appindex + 12, apiresponse.IndexOf("=", appindex + 1) - appindex - 12)
            If apiresponse.Contains("LoginFAILED") Then
                Return "IncorrectLogin"
                Exit Function
            ElseIf apiresponse.Contains("LoginOK") Then
                rlicense = apiresponse.Split("USRLICENSES=")(1)
                rlicense = rlicense.Remove(0, 11)
                Return "LOGINOK-/-" + rlicense
            Else
                Return "FAIL"
            End If
        Catch ex As Exception
            MsgBox("We weren't able to connect to the authentication servers. Please check your connection and try again later.", MsgBoxStyle.Critical)
            Return "FAIL"
        End Try
    End Function

    Function Login(uname As String, upass As String)
        Console.WriteLine(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + " - " + "Info: Performing Login Check")

        'Create query and submit
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(upass)
        upass = Convert.ToBase64String(byt)
        Dim apiquery As String = "?uname=" + uname + "&upass=" + upass

        Try
            Dim apiresponse As String = New System.Net.WebClient().DownloadString(apiserver + apiquery)
            If apiresponse.Contains("LoginOK") Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("We weren't able to connect to the authentication servers. Please check your connection and try again later.", MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Sub WebLogin(uname As String, upass As String)
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(upass)
        upass = Convert.ToBase64String(byt)
        Process.Start(WebLoginPath + "?uname=" + uname + "&upass=" + upass)
    End Sub
End Module
