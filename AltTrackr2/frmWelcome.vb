Imports MaterialSkin

Public Class frmWelcome

    Private Sub frmWelcome_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        frmWelcomeControls.Location = Me.Location
        frmWelcomeControls.Size = Me.Size
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmWelcomeControls.Show()
        frmWelcomeControls.TopMost = True
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
    End Sub
End Class