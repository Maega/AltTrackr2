Imports System.Text.RegularExpressions
Imports System.Management

Module AccountsAPI

    'Software: Maega Innovation Hub
    'Module: UpdateAPI.vb
    'Description: Accounts Backend for Maega Products
    'Organisation: Maega

    'This code uses wildly insecure methods of handling login. It'll be fine for the early betas, but by production we'll be sending POST requests to the server with a unique ID bound to the user's IP address instead of a B64'd password.
    'Currently we're using similar local password storage methods to FileZilla.

    Dim rlicense As String, appindex As Integer
    Dim apiserver As String = "https://api.maeganetwork.com/accounts.php?api=v2" 'This should point to the API backend on the accounts server
    Dim WebLoginPath As String = "https://my.maega.com.au/autologin" 'This should point to the autologin script on the accounts server

    Dim resStatus As Integer = Nothing
    Dim resApprovedHWID As String = String.Empty
    Dim resLicenses As String = String.Empty

    Dim sessionHWID As String = String.Empty
    Dim sessionUser As String = String.Empty
    Dim sessionToken As String = String.Empty

    Function PerformCheck(uname As String, upass As String, Optional b64 As Boolean = True)
        Console.WriteLine(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + " - " + "Info: Performing Login Check")

        'Create query and submit
        If b64 Then
            Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(upass)
            upass = Convert.ToBase64String(byt)
        End If
        Dim apiquery As String = "&uname=" + uname + "&upass=" + upass + "&hwid=" + GetHWID.ToString + "&pcname=" + Environment.MachineName
        Try
            Dim apiresponse As String = New System.Net.WebClient().DownloadString(apiserver + apiquery)
            'Check API response for errors
            If apiresponse.Contains("MISSINGPARAMETER") Then
                'This should never happen - it means the API query is missing the ?app value
                MsgBox("A parameter code is missing. Something has gone very wrong. Please contact support.", MsgBoxStyle.Critical)
                Return 2
            End If

            'Set variables according to the API response - removes the response headers and sets variables to the corresponding responses.
            'appindex = apiresponse.IndexOf("USRLICENSES=")
            'MsgBox(appindex.ToString)
            'rlicense = apiresponse.Substring(appindex + 12, apiresponse.IndexOf("=", appindex + 1) - appindex - 12)

            MsgBox(apiresponse.ToString)

            Try
                resStatus = apiresponse.Split(";")(0)
                sessionHWID = apiresponse.Split(";")(1)
                resApprovedHWID = apiresponse.Split(";")(2)
                sessionToken = apiresponse.Split(";")(3)
                resLicenses = apiresponse.Split(";")(4)

            Catch ex As Exception
                'Reached end of array
                cTiming.WriteDebug("The apiresponse array ended prematurely. This is normal behaviour.")
            End Try

            If sessionHWID = GetHWID.ToString Then
                Select Case resStatus
                    Case 0 'resStatus 0 means Incorrect Login.
                        Return 0 'Return 0 for Incorrect Login.
                    Case 1 'resStatus 1 means Authenticated.
                        Return 1 'Return 1 for OK - Login successful, all variables have been set.
                    Case Else
                        Return 2 'Return 2 for Error - Something went wrong with the request.
                End Select
            Else
                MsgBox("There was an issue authenticating the server request." + vbNewLine + vbNewLine + "Please try again later. If the problem persists, please contact support.", MsgBoxStyle.Critical)
                Return 2
            End If
        Catch ex As Exception
            MsgBox("We weren't able to connect to the authentication servers. Please check your connection and try again later." + vbNewLine + ex.ToString, MsgBoxStyle.Critical)
            Return 2
        End Try
    End Function

    Function GetHWID()
        Dim HWID As String = String.Empty
        Dim mcl As New ManagementClass("win32_processor")
        Dim MOBC As ManagementObjectCollection = mcl.GetInstances()

        For Each mob As ManagementObject In MOBC
            If HWID = "" Then
                HWID = mob.Properties("processorID").Value.ToString()
                Exit For
            End If
        Next
        Return HWID
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

    Function ReturnCredentialArray(uname As String, upass As String)
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(upass)
        upass = Convert.ToBase64String(byt)
        Return {uname, upass}
    End Function

    Sub WebLogin(uname As String, upass As String)
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(upass)
        upass = Convert.ToBase64String(byt)
        Process.Start(WebLoginPath + "?uname=" + uname + "&upass=" + upass)
    End Sub
End Module
