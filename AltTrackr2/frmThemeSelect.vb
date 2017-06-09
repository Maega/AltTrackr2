Imports MaterialSkin

Public Class frmThemeSelect
    Private Sub frmThemeSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        btnNext.AutoSize = False
        btnNext.Size = New Point(124, 41)
        btnNext.Location = New Point(378, 292)
    End Sub

    Private Sub btnLight_Click(sender As Object, e As EventArgs) Handles btnLight.Click
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
    End Sub

    Private Sub btnDark_Click(sender As Object, e As EventArgs) Handles btnDark.Click
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
    End Sub
End Class