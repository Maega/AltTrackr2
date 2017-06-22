Imports System.ComponentModel
Imports MaterialSkin

Public Class frmLogin
    Dim AuthLocation As String = "HKEY_CURRENT_USER\Software\Maega\Auth"
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        lblWelcome.Font = New Font("Roboto Light", 30)
        If My.Computer.Registry.GetValue(My.Settings.RegLocation, "AutoLogin", Nothing) = 1 Then
            autologin = True
            ShowSpinner()
            bkgLogin.RunWorkerAsync()
        ElseIf Not My.Computer.Registry.GetValue(AuthLocation, "AccUser", Nothing) Is Nothing And Not My.Computer.Registry.GetValue(AuthLocation, "AccPass", Nothing) Is Nothing Then
            lblWelcome.Text = "Welcome to AltTrackr, " + My.Computer.Registry.GetValue(AuthLocation, "AccUser", Nothing)
            btnContinue.Text = "Sign in as " + My.Computer.Registry.GetValue(AuthLocation, "AccUser", Nothing)
        Else
            lblWelcome.Top += 30
            lblWelcome.Text = "Please sign in to myMaega"
            btnContinue.Visible = False
            btnSignIn.Text = "Let's go!"
            'divLogin.Visible = False
            lblOr.Visible = False
        End If
    End Sub

    Dim autologin As Boolean
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        autologin = True
        ShowSpinner()
        bkgLogin.RunWorkerAsync()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        autologin = False
        ShowSpinner()
        bkgLogin.RunWorkerAsync()
    End Sub

    Private Sub ShowSpinner()
        btnContinue.Visible = False
        btnSignIn.Visible = False
        lblOr.Visible = False
        lblWelcome.Text = "Signing you in..."
        divLogin.Visible = False
        txtUsername.Visible = False
        txtPassword.Visible = False

        prgLoading.NumberSpoke = 120
        prgLoading.SpokeThickness = 5
        prgLoading.InnerCircleRadius = 30
        prgLoading.OuterCircleRadius = 35
        prgLoading.RotationSpeed = 20
        prgLoading.Active = True
        prgLoading.Visible = True
    End Sub

    Private Sub HideSpinner()
        prgLoading.Active = False
        prgLoading.Visible = False

        If autologin Then
            btnContinue.Visible = True
            lblOr.Visible = True
            lblWelcome.Text = "Automatic Login Failed"
            If Not btnContinue.Text = "Try Again" Then btnContinue.Text = "Try Again" Else btnContinue.Visible = False
        Else
            lblWelcome.Text = "Incorrect Login Details"
        End If

        btnSignIn.Visible = True
        divLogin.Visible = True
        txtUsername.Visible = True
        txtPassword.Visible = True
    End Sub

    Dim loginval As String
    Private Sub bkgLogin_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bkgLogin.DoWork
        If autologin Then
            loginval = AccountsAPI.PerformCheck(My.Computer.Registry.GetValue(AuthLocation, "AccUser", Nothing), My.Computer.Registry.GetValue(AuthLocation, "AccPass", Nothing), False)
        Else
            loginval = AccountsAPI.PerformCheck(txtUsername.Text, txtPassword.Text)
        End If
    End Sub

    Private Sub bkgLogin_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bkgLogin.RunWorkerCompleted
        If loginval = "IncorrectLogin" Then
            loginval = String.Empty
            HideSpinner()
        ElseIf loginval.Contains("LOGINOK-/-") Then
            cTiming.transitionForms(Me, frmWelcome, False)
        End If
    End Sub
End Class