Imports MaterialSkin

Public Class frmFeedback
    Dim referringForm As String
    Public Sub New(ByVal refForm As Form)
        InitializeComponent()
        referringForm = refForm.Name.ToString
    End Sub

    Private Sub frmFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
    End Sub

    Private Sub MaterialRaisedButton1_MouseEnter(sender As Object, e As EventArgs) Handles btnPositive.MouseEnter
        picKhaledLike.Show()
        btnPositive.Text = "I like that"
        lblFeedbackType.Text = "Feature suggestions, compliments and puppies belong here"
    End Sub

    Private Sub MaterialRaisedButton1_MouseLeave(sender As Object, e As EventArgs) Handles btnPositive.MouseLeave
        picKhaledLike.Hide()
        btnPositive.Text = "Positive"
        lblFeedbackType.Text = "Please select a type of feedback"
    End Sub

    Private Sub MaterialRaisedButton2_MouseEnter(sender As Object, e As EventArgs) Handles btnNegative.MouseEnter
        picKhaledDislike.Show()
        lblFeedbackType.Text = "Bugs, annoyances, crashes and complaints belong here"
    End Sub

    Private Sub MaterialRaisedButton2_MouseLeave(sender As Object, e As EventArgs) Handles btnNegative.MouseLeave
        picKhaledDislike.Hide()
        lblFeedbackType.Text = "Please select a type of feedback"
    End Sub

    Dim apiserver As String = "https://api.maeganetwork.com/feedback.php" 'This should point to the API backend on the feedback server
    Private Sub SubmitFeedback()
        Dim apiquery As String '= "?uname=" + uname + "&upass=" + upass + "&message=" fmessage

        Try
            Dim apiresponse As String = New System.Net.WebClient().DownloadString(apiserver + apiquery)
            'Check API response for errors
            If apiresponse.Contains("MISSINGPARAMETER") Then
                'This should never happen - it means the API query is missing the ?app value
                MsgBox("There was a problem checking for updates. Please try again later or contact support if this issue persists.", MsgBoxStyle.Critical)
            End If

            'Set variables according to the API response - removes the response headers and sets variables to the corresponding responses.
            'appindex = apiresponse.IndexOf("USRLICENSES=")
            'MsgBox(appindex.ToString)
            'rlicense = apiresponse.Substring(appindex + 12, apiresponse.IndexOf("=", appindex + 1) - appindex - 12)
            If apiresponse.Contains("LoginFAILED") Then
                MsgBox("The login request sent alongside your feedback failed." + vbNewLine + "We authenticate every feedback submission to prevent abuse, please restart AltTrackr and try again." + vbNewLine + "If the issue does not correct itself, please report it along with your feedback to support@maeganetwork.com")
            ElseIf apiresponse.Contains("SubmitFAILED") Then
                MsgBox("The server is reporting that submitting your feedback failed." + vbNewLine + "This is likely a server issue and requires no action on your part to correct." + vbNewLine + "Please report this issue, along with your feedback to support@maeganetwork.com", MsgBoxStyle.Critical)
            ElseIf apiresponse.Contains("NotImplemented") Then
                MsgBox("AltTrackr tried submitting your feedback, but the server reports that the backend feedback system isn't ready yet." + vbNewLine + "Until it's ready, please directly send this feedback to tristan@maeganetwork.com or by chat." + vbNewLine + vbNewLine + "Feedback will be switched on automatically when it's ready, no need for an update.", MsgBoxStyle.Exclamation)
            ElseIf apiresponse.Contains("SubmitSUCCESS") Then
                MsgBox("Thanks for your feedback! Submission was successful.", MsgBoxStyle.Information)
            Else
                MsgBox("The server replied with a response AltTrackr doesn't understand." + vbNewLine + "Please ensure that AltTrackr is up to date. If it is, this is likely a server issue and requires no action on your part to correct." + vbNewLine + "Please report the issue, along with your feedback to support@maeganetwork.com")
            End If
        Catch ex As Exception
            MsgBox("We weren't able to connect to the feedback servers. Please check your connection and try again later.", MsgBoxStyle.Critical)
        End Try
    End Sub

End Class