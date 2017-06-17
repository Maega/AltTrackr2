Imports MaterialSkin

Public Class frmWelcome

    Private Sub frmWelcome_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        frmWelcomeControls.Location = Me.Location
        frmWelcomeControls.Size = Me.Size
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppConfigured", Nothing) Then
            If My.Computer.Registry.GetValue(My.Settings.RegLocation, "Theme", Nothing) = "LIGHT" Then
                SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            Else
                SkinManager.Theme = MaterialSkinManager.Themes.DARK
            End If
            frmWelcomeControls.tmrTransition.Stop()
            frmHome.Show()
            Me.Close()
        Else
            frmWelcomeControls.Show()
            frmWelcomeControls.TopMost = True
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
        End If
    End Sub
End Class