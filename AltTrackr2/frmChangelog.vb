Imports MaterialSkin

Public Class frmChangelog
    Private Sub frmChangelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.ColorScheme = New ColorScheme(-13354941, -13354941, 6323595, 4244735, 16777215) 'Third and Fourth need to be updated to current theme.
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
    End Sub

    Dim closeReady As Boolean = False
    Private Sub frmChangelog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If closeReady = False Then
            e.Cancel = True
            closeReady = True
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "JustUpdated", "0")
            cTiming.transitionForms(Me, frmHomeMulti)
        End If
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Me.Close()
    End Sub

    Private Sub frmChangelog_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        frmWelcome.Hide()
    End Sub
End Class