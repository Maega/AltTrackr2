Imports System.IO
Imports MaterialSkin

Public Class frmWelcome
    Public args As String() = Environment.GetCommandLineArgs()
    Public launchSilent As Boolean = False

    Private Sub frmWelcome_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        frmWelcomeControls.Location = Me.Location
        frmWelcomeControls.Size = Me.Size
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case True
            Case args.Contains("silent")
                launchSilent = True
        End Select

        If My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppConfigured", Nothing) Then
            If My.Computer.Registry.GetValue(My.Settings.RegLocation, "Theme", Nothing) = "LIGHT" Then
                SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            Else
                SkinManager.Theme = MaterialSkinManager.Themes.DARK
            End If
            frmWelcomeControls.tmrTransition.Stop()
            If My.Computer.Registry.GetValue(My.Settings.RegLocation, "JustUpdated", Nothing) = "1" Then frmChangelog.Show() Else frmHomeMulti.Show()
            Me.Hide()
        Else
            'Set some initial registry values to prevent crash at launch for unset variables
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "InitialInvestment", "0,0,0,0")
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppHoldings", "0,0,0,0")
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppGoals", "0,0,0,0")
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "InvestDate", "10/10/2010,10/10/2010,10/10/2010,10/10/2010")

            frmWelcomeControls.Show()
            frmWelcomeControls.TopMost = True
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
        End If
    End Sub
End Class