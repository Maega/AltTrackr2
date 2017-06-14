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

End Class