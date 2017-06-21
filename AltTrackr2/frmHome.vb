Imports MaterialSkin
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.ComponentModel

Public Class frmHome
    Dim serverResponse As JObject
    Dim totalHoldings As Decimal = CDec(My.Computer.Registry.GetValue(My.Settings.RegLocation, "TotalHoldings", Nothing))
    Dim coinCodes As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppCoins", Nothing)
    Dim fiatMain As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppMainFiat", Nothing)
    Dim fiatCodes As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppAltFiats", Nothing)
    Dim initialInvestment As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "InitialInvestment", Nothing)
    Dim colourScheme() As String

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        Try
            colourScheme = My.Computer.Registry.GetValue(My.Settings.RegLocation, "ColourScheme", Nothing).Split(",")
            SkinManager.ColorScheme = New ColorScheme(colourScheme(0), colourScheme(1), colourScheme(2), colourScheme(3), colourScheme(4))
        Catch ex As Exception
            cTiming.WriteDebug("Invalid colour scheme, resetting to default")
            SkinManager.ColorScheme = New ColorScheme(3622735, 2503224, 6323595, 4244735, 16777215)
        End Try
        'Due to the nature of the MaterialSkin library (initialises fonts in the constructor), we have to manually specify custom fonts at runtime
        lblComingSoon.Font = New Font("Roboto Light", 15)
        lblLoading.Font = New Font("Roboto Light", 20)
        lblAltPrices.Font = New Font("Roboto Light", 15)
        lblAltHoldings.Font = New Font("Roboto Light", 15)
        lblFriendlyPrice.Font = New Font("Roboto Light", 12)
        tabContent.SelectedTab = tabDetails
        lblComingSoon.Font = New Font("Roboto Light", 30)
        tabContent.SelectedTab = tabSettings
        tsiVersion.Text = "Software Version v" + cTiming.appVer.ToString("n2")
        lblSVersion.Text = "Software Version v" + cTiming.appVer.ToString("n2")
        lblSYourInvestment.Font = New Font("Roboto Light", 17)
        lblSUpdates.Font = New Font("Roboto Light", 17)
        tabContent.SelectedTab = tabDailyBrief
        Me.Text = Me.Text + " v" + cTiming.appVer.ToString("n2")
        GetSettings()
        GetPrices()
    End Sub

    Private Sub frmHome_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Check for updates after form is shown to ensure messageboxes appear topmost
        bkgCheckForUpdates.RunWorkerAsync()
    End Sub

    Private Function ParseJSON(APIURL As String)
        Dim client As WebClient = New WebClient()
        Dim reply As String = client.DownloadString(APIURL)
        Return JObject.Parse(reply)
    End Function

    Private Sub GetSettings()
        totalHoldings = CDec(My.Computer.Registry.GetValue(My.Settings.RegLocation, "TotalHoldings", Nothing))
        coinCodes = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppCoins", Nothing)
        fiatMain = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppMainFiat", Nothing)
        fiatCodes = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppAltFiats", Nothing)
        initialInvestment = My.Computer.Registry.GetValue(My.Settings.RegLocation, "InitialInvestment", Nothing)

        txtRefreshMins.Text = (CInt(My.Computer.Registry.GetValue(My.Settings.RegLocation, "RefreshInterval", Nothing)) / 60000).ToString("n2")
        txtSHoldings.Text = totalHoldings.ToString
        txtSInitialInvestment.Text = initialInvestment
        txtSInvestDate.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing)
        lblSCoinCode.Text = coinCodes
        lblSFiatCode.Text = fiatMain

        If My.Computer.Registry.GetValue(My.Settings.RegLocation, "ColourScheme", Nothing) = "3622735,2503224,6323595,4244735,16777215" Then
            radSColourBlueGrey.Checked = True
        ElseIf My.Computer.Registry.GetValue(My.Settings.RegLocation, "ColourScheme", Nothing) = "4149685,3162015,12962537,4244735,16777215" Then
            radSColourIndigo.Checked = True
        ElseIf My.Computer.Registry.GetValue(My.Settings.RegLocation, "ColourScheme", Nothing) = "4431943,3706428,10868391,10868391,16777215" Then
            radSColourGreen.Checked = True
        ElseIf My.Computer.Registry.GetValue(My.Settings.RegLocation, "ColourScheme", Nothing) = "15684432,13840175,15702682,15702682,16777215" Then
            radSColourRed.Checked = True
        End If
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        GetPrices()
    End Sub

    Private Sub GetPrices(Optional silent As Boolean = False)
        If Not bkgGetPrices.IsBusy Then
            If Not silent Then
                cTiming.WriteDebug("Attempting to fetch latest price data...")
                Select Case GetRandom(0, 4)
                    Case 0
                        lblLoading.Text = "Chatting with the servers, just a minute..."
                    Case 1
                        lblLoading.Text = "Calculating how rich you've become..."
                    Case 2
                        lblLoading.Text = "Loading Tip | Remember, you can report bugs with Win+B"
                    Case 3
                        lblLoading.Text = "Flying to the moon with " + coinCodes + "..."
                    Case 4
                        lblLoading.Text = "Checking up on your crypto investment..."
                End Select
                btnBugReport.Hide()
                btnFeedback.Hide()
                tabContent.Hide()
                tbsContent.Hide()
                prgLoading.NumberSpoke = 120
                prgLoading.SpokeThickness = 5
                prgLoading.InnerCircleRadius = 30
                prgLoading.OuterCircleRadius = 35
                prgLoading.RotationSpeed = 20
                prgLoading.Active = True
                prgLoading.Visible = True
                lblLoading.Show()
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
        tsCoinPrice.Text = coinCodes + " Price: " + fiatMain + " " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2")
        tsHoldingsValue.Text = coinCodes + " Holdings Value: " + fiatMain + " " + (totalHoldings * CDec(serverResponse.SelectToken(fiatMain))).ToString("n2")
        prgLoading.Hide()
        lblLoading.Hide()
        btnBugReport.Show()
        btnFeedback.Show()
        tabContent.Show()
        tbsContent.Show()
        Dim d1 As DateTime = DateTime.Today
        Dim d2 As DateTime = Convert.ToDateTime(My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing))
        Dim months As String = CStr(DateDiff(DateInterval.Month, d2, d1))
        lblFriendlyPrice.Text = "Today, you hold " + totalHoldings.ToString + " " + coinCodes + " which is valued at " + (totalHoldings * CDec(serverResponse.SelectToken(fiatMain))).ToString("n2") + " " + fiatMain + " at a coin price of " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2") + " " + fiatMain + vbNewLine + "Your initial investment was " + initialInvestment + " " + fiatMain + " and has matured over " + months + " months, yielding profits of " + ((totalHoldings * CDec(serverResponse.SelectToken(fiatMain))) - CDec(initialInvestment)).ToString("n2") + " " + fiatMain + " so far"
        lblLastPriceUpdate.Text = "Last Updated: " + DateTime.Now
        tmrRefresh.Interval = My.Computer.Registry.GetValue(My.Settings.RegLocation, "RefreshInterval", Nothing)
    End Sub

    Private Sub bkgCheckForUpdates_DoWork(sender As Object, e As DoWorkEventArgs) Handles bkgCheckForUpdates.DoWork
        UpdateAPI.CheckForUpdates()
    End Sub

    Private Sub bkgCheckForUpdates_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bkgCheckForUpdates.RunWorkerCompleted
        btnSCheckForUpdates.Text = "Check for Updates"
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        ntfTray.Icon = SystemIcons.Information
        ntfTray.BalloonTipTitle = "Today's " + coinCodes + " price: " + fiatMain + " " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2")
        'ntfTray.BalloonTipText = "Today's " + coinCodes + " price: " + fiatMain + " " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2")
        ntfTray.BalloonTipText = vbNewLine + "Your holdings are worth: " + fiatMain + " " + (totalHoldings * CDec(serverResponse.SelectToken(fiatMain))).ToString("n2")
        ntfTray.BalloonTipIcon = ToolTipIcon.Info
        ntfTray.ShowBalloonTip(30000)
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        GetPrices(True)
    End Sub

    Private Sub btnApplyChanges_Click(sender As Object, e As EventArgs) Handles btnApplyChanges.Click
        Try
            Dim format() = {"dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy"}
            Dim InvestStrToDate As Date = Date.ParseExact(txtSInvestDate.Text, format, System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "InvestDate", InvestStrToDate.ToShortDateString)
        Catch ex As Exception
            MsgBox("You entered an invalid date or date format" + vbNewLine + vbNewLine + "Accepted formats are: dd/MM/yyyy, d/M/yyyy, dd-MM-yyyy" + vbNewLine + "(eg: 10/10/2016)" + vbNewLine + vbNewLine + "Please correct your entry to change settings, or cancel your changes.", MsgBoxStyle.Exclamation, "Incorrect Date Format")
            Exit Sub
        End Try
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "RefreshInterval", CInt((CDec(txtRefreshMins.Text) * 60000)).ToString)
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "TotalHoldings", txtSHoldings.Text)
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "InitialInvestment", txtSInitialInvestment.Text)
        tmrRefresh.Interval = txtRefreshMins.Text * 60000
        GetSettings()
        HideChangeAlert()
        GetPrices(True)
    End Sub

    Private Sub ShowChangeAlert()
        pnlApplySettings.Top = 462
        pnlApplySettings.Show()
        pnlApplySettings.BringToFront()
        lblUnsaved.Font = New Font("Roboto Light", 16)
        lblPipe.ForeColor = Color.White
        lblUnsaved.ForeColor = Color.White
        Do Until Me.Height >= 562
            Me.Height += 10
            pnlApplySettings.Top = 462
            cTiming.pause(10)
        Loop
        Me.Height = 562 'In case there was some math error and the height landed above target
    End Sub

    Private Sub HideChangeAlert()
        Do Until Me.Height <= 462
            Me.Height -= 10
            pnlApplySettings.Top = 462
            cTiming.pause(10)
        Loop
        pnlApplySettings.Hide()
        Me.Height = 462 'In case there was some math error and the height landed below target
    End Sub

    Private Sub btnCancelChanges_Click(sender As Object, e As EventArgs) Handles btnCancelChanges.Click
        GetSettings()
        HideChangeAlert()
    End Sub

    Private Sub txtRefreshMins_TextChanged(sender As Object, e As EventArgs) Handles txtRefreshMins.TextChanged
        If Not txtRefreshMins.Text = (CInt(My.Computer.Registry.GetValue(My.Settings.RegLocation, "RefreshInterval", Nothing)) / 60000).ToString("n2") Then ShowChangeAlert()
    End Sub

    Private Sub txtHoldingsAddEdit_TextChanged(sender As Object, e As EventArgs) Handles txtSHoldings.TextChanged
        If Not txtSHoldings.Text = totalHoldings.ToString Then ShowChangeAlert()
    End Sub

    Private Sub txtSInitialInvestment_TextChanged(sender As Object, e As EventArgs) Handles txtSInitialInvestment.TextChanged
        If Not txtSInitialInvestment.Text = initialInvestment Then ShowChangeAlert()
    End Sub

    Private Sub txtSInvestDate_TextChanged(sender As Object, e As EventArgs) Handles txtSInvestDate.TextChanged
        If Not txtSInvestDate.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing) Then ShowChangeAlert()
    End Sub

    Private Sub txtRefreshMins_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRefreshMins.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Not Asc(e.KeyChar) = 46 Then
                    e.Handled = True
                End If
            End If
        End If

    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click, btnBugReport.Click
        Dim frmFeedback As New frmFeedback(Me)
        frmFeedback.Show()
    End Sub

    Private Sub btnSCheckForUpdates_Click(sender As Object, e As EventArgs) Handles btnSCheckForUpdates.Click
        If Not bkgCheckForUpdates.IsBusy Then
            btnSCheckForUpdates.Text = "Checking..."
            bkgCheckForUpdates.RunWorkerAsync()
        End If
    End Sub

    Private Sub tsiVersion_Click(sender As Object, e As EventArgs) Handles tsiVersion.Click
        If lblSVersion.Visible Then
            lblSVersion.Visible = False
        Else
            lblSVersion.Visible = True
        End If
    End Sub

    Private Sub radSColour_CheckedChanged(sender As Object, e As EventArgs) Handles radSColourBlueGrey.CheckedChanged, radSColourGreen.CheckedChanged, radSColourIndigo.CheckedChanged, radSColourRed.CheckedChanged
        If radSColourBlueGrey.Checked Then
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "ColourScheme", "3622735,2503224,6323595,4244735,16777215")
            SkinManager.ColorScheme = New ColorScheme(3622735, 2503224, 6323595, 4244735, 16777215)
        ElseIf radSColourIndigo.Checked Then
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "ColourScheme", "4149685,3162015,12962537,4244735,16777215")
            SkinManager.ColorScheme = New ColorScheme(4149685, 3162015, 12962537, 4244735, 16777215)
        ElseIf radSColourGreen.Checked Then
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "ColourScheme", "4431943,3706428,10868391,10868391,16777215")
            SkinManager.ColorScheme = New ColorScheme(4431943, 3706428, 10868391, 10868391, 16777215)
        ElseIf radSColourRed.Checked Then
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "ColourScheme", "15684432,13840175,15702682,15702682,16777215")
            SkinManager.ColorScheme = New ColorScheme(15684432, 13840175, 15702682, 15702682, 16777215)
        End If
    End Sub
End Class