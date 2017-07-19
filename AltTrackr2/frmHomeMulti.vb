Imports System.ComponentModel
Imports MaterialSkin
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmHomeMulti

    Dim serverResponse As JObject
    Dim totalHoldings As Decimal = CDec(My.Computer.Registry.GetValue(My.Settings.RegLocation, "TotalHoldings", Nothing))
    Dim coinCodes As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppCoins", Nothing)
    Dim fiatMain As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppMainFiat", Nothing)
    Dim fiatCodes As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppAltFiats", Nothing)
    Dim initialInvestment As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "InitialInvestment", Nothing)
    Dim colourScheme() As String


    Private Sub tabContent_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tabContent.Selecting
        If e.TabPage.Text = String.Empty Then e.Cancel = True 'If TabPage text is nothing, make it unselectable (for use as a section divider)
    End Sub

    Private Sub tabContent_Selected(sender As Object, e As TabControlEventArgs) Handles tabContent.Selected
        Me.Text = tabContent.SelectedTab.Text + " | AltTrackr"
        Invalidate()
    End Sub

    Private Sub frmHomeMulti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.ColorScheme = New ColorScheme(-13354941, -13354941, 6323595, 4244735, 16777215) 'Third and Fourth need to be updated to current theme.
        tabContent.Dock = DockStyle.None
        tabContent.Location = New Point(0, 64)
        tabContent.SelectedTab = tpgHome
        'tabContent.Size = New Point(1022, 490)
        GetPrices()
        Me.CenterToParent()
    End Sub

    Private Sub AetherButton2_Click(sender As Object, e As EventArgs) Handles AetherButton2.Click
        frmCustomColour.Show()
    End Sub

    Private Sub radStyle_CheckedChanged(sender As Object, e As EventArgs) Handles radStyle1.CheckedChanged, radStyle2.CheckedChanged, radStyle3.CheckedChanged
        If radStyle1.Checked Then
            SkinManager.ColorScheme = New ColorScheme(-13354941, -13354941, 6323595, 4244735, 16777215) 'Third and Fourth need to be updated to current theme.
        ElseIf radStyle2.Checked Then
            SkinManager.ColorScheme = New ColorScheme(-12960183, -12960183, 6323595, 4244735, 16777215) 'Third and Fourth need to be updated to current theme.
        ElseIf radStyle3.Checked Then
            SkinManager.ColorScheme = New ColorScheme(-13354941, -12960183, 6323595, 4244735, 16777215) 'Third and Fourth need to be updated to current theme.
        End If
        pnlUnsaved.Show()
        ShowChangeAlert()
    End Sub

    Private Sub ShowChangeAlert()
        'pnlApplySettings.Top = 462
        'pnlApplySettings.Show()
        'pnlApplySettings.BringToFront()
        'lblUnsaved.Font = New Font("Roboto Light", 16)
        'lblPipe.ForeColor = Color.White
        'lblUnsaved.ForeColor = Color.White
        Do Until pnlUnsaved.Left >= 0
            pnlUnsaved.Left += 8
            'pnlApplySettings.Top = 462
            cTiming.pause(10)
        Loop
        pnlUnsaved.Left = 0 'In case there was some math error and the height landed above target
    End Sub

    Private Sub HideChangeAlert()
        Do Until pnlUnsaved.Left <= -194
            pnlUnsaved.Left -= 8
            'pnlApplySettings.Top = 462
            cTiming.pause(10)
        Loop
        pnlUnsaved.Left = -189 'In case there was some math error and the height landed above target
        pnlUnsaved.Visible = False
    End Sub

    Sub HideLoadingSidebar()
        Do Until pnlUnsaved.Left <= -194
            pnlUnsaved.Left -= 8
            cTiming.pause(10)
        Loop
        pnlUnsaved.Hide()
        pnlUnsaved.Left = 0
    End Sub

    Sub HideLoadingPanel()
        Do Until pnlLoadingMain.Top >= 554
            pnlLoadingMain.Top += 15
            cTiming.pause(10)
        Loop
        pnlLoadingMain.Hide()
        pnlLoadingMain.Top = 68
    End Sub

    Private Function ParseJSON(APIURL As String)
        Dim client As WebClient = New WebClient()
        Dim reply As String = client.DownloadString(APIURL)
        Return JObject.Parse(reply)
    End Function

    Private Sub bkgGetPrices_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bkgGetPrices.DoWork
        serverResponse = ParseJSON("https://min-api.cryptocompare.com/data/price?fsym=" + My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppCoins", Nothing) + "&tsyms=" + My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppAltFiats", Nothing))
    End Sub

    Dim justLaunched As Boolean = True
    Private Sub bkgGetPrices_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bkgGetPrices.RunWorkerCompleted
        lblAltPrices.Text = String.Empty
        lblAltHoldings.Text = String.Empty
        Dim fiatArray() As String = fiatCodes.Split(",")
        For Each fiatCode As String In fiatArray
            lblAltPrices.Text += fiatCode + ": " + CDec(serverResponse.SelectToken(fiatCode)).ToString("n2") + " | "
            lblAltHoldings.Text += fiatCode + ": " + (totalHoldings * CDec(serverResponse.SelectToken(fiatCode))).ToString("n2") + " | "
        Next
        lblAltPrices.Text = lblAltPrices.Text.TrimEnd(" ")
        lblAltPrices.Text = lblAltPrices.Text.TrimEnd("|")
        lblAltPrices.Text = coinCodes + " Prices - " + lblAltPrices.Text
        lblAltHoldings.Text = lblAltHoldings.Text.TrimEnd(" ")
        lblAltHoldings.Text = lblAltHoldings.Text.TrimEnd("|")
        lblAltHoldings.Text = coinCodes + " Holdings - " + lblAltHoldings.Text
        'lblPrice.Text = fiatMain + ": " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2")
        'lblHoldingsCoin.Text = totalHoldings.ToString + " " + coinCodes
        'tsCoinPrice.Text = coinCodes + " Price: " + fiatMain + " " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2")
        'tsHoldingsValue.Text = coinCodes + " Holdings Value: " + fiatMain + " " + (totalHoldings * CDec(serverResponse.SelectToken(fiatMain))).ToString("n2")
        'tabContent.Show()
        prgTitleLoad.Hide()
        Me.Text = tabContent.SelectedTab.Text + " | AltTrackr"
        Invalidate()
        HideLoadingPanel()
        Dim d1 As DateTime = DateTime.Today
        Dim d2 As DateTime = Convert.ToDateTime(My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing))
        Dim months As String = CStr(DateDiff(DateInterval.Month, d2, d1))
        lblFriendlyPrice.Text = "Today, you hold " + totalHoldings.ToString + " " + coinCodes + " which is valued at " + (totalHoldings * CDec(serverResponse.SelectToken(fiatMain))).ToString("n2") + " " + fiatMain + " at a coin price of " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2") + " " + fiatMain + vbNewLine + "Your initial investment was " + initialInvestment + " " + fiatMain + " and has matured over " + months + " months, yielding profits of " + ((totalHoldings * CDec(serverResponse.SelectToken(fiatMain))) - CDec(initialInvestment)).ToString("n2") + " " + fiatMain + " so far"
        lblLastPriceUpdate.Text = "Last Updated: " + DateTime.Now
        tmrRefresh.Interval = My.Computer.Registry.GetValue(My.Settings.RegLocation, "RefreshInterval", Nothing)
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        GetPrices(True)
    End Sub

    Private Sub GetPrices(Optional silent As Boolean = False)
        If Not bkgGetPrices.IsBusy Then
            If Not silent Then
                cTiming.WriteDebug("Attempting to fetch latest price data...")
                If My.Computer.Registry.GetValue(My.Settings.RegLocation, "NoMotivationalLoad", Nothing) = "1" Then
                    lblUnsaved.Text = "Loading Server Data..."
                Else
                    'Select Case GetRandom(0, 5)
                    'Case 0
                    'lblLoading.Text = "Discussing " + coinCodes + " by the water cooler..."
                    'Case 1
                    'lblLoading.Text = "Calculating how rich you've become..."
                    'Case 2
                    'lblLoading.Text = "Loading Tip | Remember, every bug report helps"
                    'Case 3
                    'lblLoading.Text = "Sending " + coinCodes + " to the moon..."
                    'Case 4
                    'lblLoading.Text = "HODL, HODL, HODL, HODL!"
                    'End Select
                End If
                'tabContent.Hide()
                pnlLoadingMain.Show()
                pnlLoadingMain.BringToFront()

                'prgLoading.NumberSpoke = 120
                'prgLoading.SpokeThickness = 4
                'prgLoading.InnerCircleRadius = 30
                'prgLoading.OuterCircleRadius = 35
                'prgLoading.RotationSpeed = 20
                'prgLoading.Active = True

                Me.Text = "Loading Data"
                Invalidate()
                prgTitleLoad.NumberSpoke = 120
                prgTitleLoad.SpokeThickness = 4
                prgTitleLoad.InnerCircleRadius = 8
                prgTitleLoad.OuterCircleRadius = 9
                prgTitleLoad.RotationSpeed = 20
                prgTitleLoad.Active = True
                prgTitleLoad.Visible = True

                'pnlLoading.Show()
                'pnlLoading.BringToFront()
            End If
            bkgGetPrices.RunWorkerAsync()
        Else
            If Not silent Then cTiming.WriteDebug("Attempted to fetch prices, but I'm already working on it.")
        End If
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub AetherButton3_Click(sender As Object, e As EventArgs) Handles AetherButton3.Click
        GetPrices()
    End Sub

    Private Sub btnConfirmSave_Click(sender As Object, e As EventArgs) Handles btnConfirmSave.Click

    End Sub

    Private Sub btnConfirmCancel_Click(sender As Object, e As EventArgs) Handles btnConfirmCancel.Click
        HideChangeAlert()
    End Sub

    Dim sessionUser As String = String.Empty
    Private Sub btnLLogin_Click(sender As Object, e As EventArgs) Handles btnLLogin.Click
        Dim loginResponse As String = AccountsAPI.PerformCheck(txtLUsername.Text, txtLPassword.Text)
        If loginResponse.Contains("LOGINOK-/-") Then
            tagIncorrect1.Left = -86
            tagIncorrect2.Left = -86
            pnlLIncorrect.Hide()
            sessionUser = txtLUsername.Text
            tpgLogin.Text = txtLUsername.Text
            tpgLogin.ImageIndex = 28
        ElseIf loginResponse.Contains("IncorrectLogin") Then
            pnlLIncorrect.Show()
            Do Until tagIncorrect1.Left >= 3
                tagIncorrect1.Left += 8
                tagIncorrect2.Left += 8
                cTiming.pause(10)
            Loop
            tagIncorrect1.Left = 3
            tagIncorrect2.Left = 3
        Else
            MsgBox("An error has occurred. The server response is invalid." + vbNewLine + vbNewLine + "Please check for product updates and try again. If the problem persists, please submit a report or get in touch with support.", MsgBoxStyle.Critical)
        End If
        loginResponse = String.Empty
    End Sub

    Private Sub btnLLogout_Click(sender As Object, e As EventArgs) Handles btnLLogout.Click
        sessionUser = String.Empty
        tpgLogin.Text = "Login"
        tpgLogin.ImageIndex = 25
    End Sub

    Private Sub btnLSignup_Click(sender As Object, e As EventArgs) Handles btnLSignup.Click
        Process.Start("https://my.maega.com.au/register")
    End Sub

    Private Sub btnLForgot_Click(sender As Object, e As EventArgs) Handles btnLForgot.Click
        Process.Start("https://my.maega.com.au/forgot")
    End Sub

    Private Sub btnLChangeDetails_Click(sender As Object, e As EventArgs) Handles btnLChangeDetails.Click
        Process.Start("https://my.maega.com.au/dashboard")
    End Sub
End Class