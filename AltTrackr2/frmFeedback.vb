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
        Dim apiquery As String = "?uname=" + uname + "&upass=" + upass

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
                Return "IncorrectLogin"
            ElseIf apiresponse.Contains("SubmitFAILED") Then
                Return "FAIL"
            ElseIf apiresponse.Contains("NotImplemented") Then

            ElseIf apiresponse.Contains("SubmitSUCCESS") Then
                Return "Success"
            Else
                Return "FAILUNKNOWN"
            End If
        Catch ex As Exception
            MsgBox("We weren't able to connect to the feedback servers. Please check your connection and try again later.", MsgBoxStyle.Critical)
            Return "FAIL"
        End Try
    End Sub

End Class