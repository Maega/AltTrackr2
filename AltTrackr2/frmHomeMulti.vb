Imports System.ComponentModel
Imports MaterialSkin
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Notification

Public Class frmHomeMulti
    Dim serverResponse As JObject
    Dim totalHoldings() As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppHoldings", Nothing).Split(",")
    Dim coinCodes As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppCoins", Nothing)
    Dim coinCodeArray() As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppCoins", Nothing).Split(",")
    Dim coinNameArray() As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppCoinNames", Nothing).Split(",")
    Dim fiatMain As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppMainFiat", Nothing)
    Dim fiatCodes As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppAltFiats", Nothing)
    Dim initialInvestment() As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "InitialInvestment", Nothing).Split(",")
    Dim coinGoals() As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppGoals", Nothing).Split(",")
    Dim colourScheme() As String

    Dim notifArray As New ArrayList

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
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        tabContent.Dock = DockStyle.None
        tabContent.Location = New Point(0, 64)
        tabContent.SelectedTab = tpHome
        'tabContent.Size = New Point(1022, 490)
        GetPrices()
        Me.CenterToParent()
        tagCurrentVer.Text = "v" + UpdateAPI.CurrentVer.ToString("0.0.0")

        txtC1Goal.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppGoals", Nothing).Split(",")(0)
        txtC2Goal.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppGoals", Nothing).Split(",")(1)
        txtC3Goal.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppGoals", Nothing).Split(",")(2)
        txtC4Goal.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppGoals", Nothing).Split(",")(3)
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
        Try
            serverResponse = ParseJSON("https://min-api.cryptocompare.com/data/pricemultifull?fsyms=" + My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppCoins", Nothing) + "&tsyms=" + My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppAltFiats", Nothing))
        Catch ex As Exception
            bkgGetPrices.CancelAsync()
        End Try
    End Sub

    Dim justLaunched As Boolean = True
    Private Sub bkgGetPrices_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bkgGetPrices.RunWorkerCompleted
        If bkgGetPrices.CancellationPending Then
            MsgBox("AltTrackr failed to fetch latest crypto prices. Please verify your internet connection and try again.", MsgBoxStyle.Exclamation)
        Else
            lblAltPrices.Text = String.Empty
            lblAltHoldings.Text = String.Empty
            Dim fiatArray() As String = fiatCodes.Split(",")
            'Dim coinArray() As String = coinCodes.Split(",")
            For Each coinCode As String In coinCodeArray
                lblAltPrices.Text += coinCode + " - "
                lblAltHoldings.Text += coinCode + " - "
                For Each fiatCode As String In fiatArray
                    If CDec(serverResponse.SelectToken("RAW").SelectToken(coinCode).SelectToken(fiatCode).SelectToken("PRICE")) >= 1.0 Then 'If the price is more than one fiat in value, round to two decimal places
                        lblAltPrices.Text += fiatCode + " " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCode).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n2") + " | "

                        'MsgBox(Array.IndexOf(coinCodeArray, coinCode))
                        lblAltHoldings.Text += fiatCode + " " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCode)) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCode).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n2") + " | "
                    Else 'If the price is less than one fiat, round to four decimal places for less valuable coins
                        lblAltPrices.Text += fiatCode + " " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCode).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n4") + " | "
                        lblAltHoldings.Text += fiatCode + " " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCode)) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCode).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n4") + " | "
                    End If
                Next
                lblAltPrices.Text = lblAltPrices.Text.TrimEnd(" ")
                lblAltPrices.Text = lblAltPrices.Text.TrimEnd("|")
                lblAltPrices.Text += vbNewLine
                lblAltHoldings.Text = lblAltHoldings.Text.TrimEnd(" ")
                lblAltHoldings.Text = lblAltHoldings.Text.TrimEnd("|")
                lblAltHoldings.Text += vbNewLine
            Next
            lblAltPrices.Text = lblAltPrices.Text.Remove(lblAltPrices.Text.LastIndexOf(Environment.NewLine))
            lblAltHoldings.Text = lblAltHoldings.Text.Remove(lblAltHoldings.Text.LastIndexOf(Environment.NewLine))

            'Set goal coin names
            lblGoalC1.Text = coinNameArray(0)
            lblGoalC2.Text = coinNameArray(1)
            lblGoalC3.Text = coinNameArray(2)
            lblGoalC4.Text = coinNameArray(3)

            'Set coin tab page names
            tpCoin1.Text = coinNameArray(0)
            tpCoin2.Text = coinNameArray(1)
            tpCoin3.Text = coinNameArray(2)
            tpCoin4.Text = coinNameArray(3)

            'Change percentage container name
            grpC1Change.Text = coinNameArray(0) + " - 24hr/Total"
            grpC2Change.Text = coinNameArray(1) + " - 24hr/Total"
            grpC3Change.Text = coinNameArray(2) + " - 24hr/Total"
            grpC4Change.Text = coinNameArray(3) + " - 24hr/Total"

            'Set change percentages
            lblC1DChange.Text = "+" + serverResponse.SelectToken("DISPLAY").SelectToken(coinCodeArray(0)).SelectToken(fiatMain).SelectToken("CHANGEPCT24HOUR").ToString + "%"
            lblC1DChange.Text = lblC1DChange.Text.Replace("+-", "-")
            lblC2DChange.Text = "+" + serverResponse.SelectToken("DISPLAY").SelectToken(coinCodeArray(1)).SelectToken(fiatMain).SelectToken("CHANGEPCT24HOUR").ToString + "%"
            lblC2DChange.Text = lblC2DChange.Text.Replace("+-", "-")
            lblC3DChange.Text = "+" + serverResponse.SelectToken("DISPLAY").SelectToken(coinCodeArray(2)).SelectToken(fiatMain).SelectToken("CHANGEPCT24HOUR").ToString + "%"
            lblC3DChange.Text = lblC3DChange.Text.Replace("+-", "-")
            lblC4DChange.Text = "+" + serverResponse.SelectToken("DISPLAY").SelectToken(coinCodeArray(3)).SelectToken(fiatMain).SelectToken("CHANGEPCT24HOUR").ToString + "%"
            lblC4DChange.Text = lblC4DChange.Text.Replace("+-", "-")

            'Set goal ring parameters
            If coinGoals.Count - 0 > 0 Then prgC1.Max = coinGoals(0) : prgC1.Text = "Goal: " + coinGoals(0) + " " + fiatMain Else prgC1.Max = 1
            If coinGoals.Count - 1 > 0 Then prgC2.Max = coinGoals(1) : prgC2.Text = "Goal: " + coinGoals(1) + " " + fiatMain Else prgC2.Max = 1
            If coinGoals.Count - 2 > 0 Then prgC3.Max = coinGoals(2) : prgC3.Text = "Goal: " + coinGoals(2) + " " + fiatMain Else prgC3.Max = 1
            If coinGoals.Count - 3 > 0 Then prgC4.Max = coinGoals(3) : prgC4.Text = "Goal: " + coinGoals(3) + " " + fiatMain Else prgC4.Max = 1

            If coinCodeArray.Count - 0 > 0 Then prgC1.Progress = CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2") : prgC1.PostText = " " + fiatMain Else prgC1.Progress = 0 : prgC1.PostText = " N/A" : prgC1.Text = "CONFIGURE"
            If coinCodeArray.Count - 1 > 0 Then prgC2.Progress = CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2") : prgC2.PostText = " " + fiatMain Else prgC2.Progress = 0 : prgC2.PostText = " N/A" : prgC2.Text = "CONFIGURE"
            If coinCodeArray.Count - 2 > 0 Then prgC3.Progress = CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2") : prgC3.PostText = " " + fiatMain Else prgC3.Progress = 0 : prgC3.PostText = " N/A" : prgC3.Text = "CONFIGURE"
            If coinCodeArray.Count - 3 > 0 Then prgC4.Progress = CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2") : prgC4.PostText = " " + fiatMain Else prgC4.Progress = 0 : prgC4.PostText = " N/A" : prgC4.Text = "CONFIGURE"

            'Unlike n(x), 0.(x) doesn't format with CultureInfo - meaning no commas
            If coinCodeArray.Count - 0 > 0 Then tpCoin1.Tag = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00").ToString : lblC1Price.Text = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00").ToString
            If coinCodeArray.Count - 1 > 0 Then tpCoin2.Tag = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00").ToString : lblC2Price.Text = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00").ToString
            If coinCodeArray.Count - 2 > 0 Then tpCoin3.Tag = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00").ToString : lblC3Price.Text = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00").ToString
            If coinCodeArray.Count - 3 > 0 Then tpCoin4.Tag = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00").ToString : lblC4Price.Text = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00").ToString

            'Set coin names according to array position
            lblC1Name.Text = coinNameArray(0).ToUpper
            lblC2Name.Text = coinNameArray(1).ToUpper
            lblC3Name.Text = coinNameArray(2).ToUpper
            lblC4Name.Text = coinNameArray(3).ToUpper

            'Redraw the tabcontrol in order to update tabpage tags
            tabContent.Invalidate()

            Dim d1 As DateTime = DateTime.Today
            'Dim d2 As DateTime = Convert.ToDateTime(My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing).Split(",")(0))
            Dim months As String

            Dim C1Holdings As String = (totalHoldings(0) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatMain).SelectToken("PRICE"))).ToString("n2")
            months = CStr(DateDiff(DateInterval.Month, Convert.ToDateTime(My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing).Split(",")(0)), d1))
            lblC1Friendly.Text = "Today, you hold " + totalHoldings(0) + " " + coinCodeArray(0) + " which is valued at " + C1Holdings + " " + fiatMain + " at a coin price of " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2") + " " + fiatMain + vbNewLine + "Your initial investment was " + initialInvestment(0) + " " + fiatMain + " and has matured over " + months + " months, yielding profits of " + ((CDec(totalHoldings(0)) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatMain).SelectToken("PRICE"))) - CDec(initialInvestment(0))).ToString("n2") + " " + fiatMain + " so far"

            Dim C2Holdings As String = (totalHoldings(1) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatMain).SelectToken("PRICE"))).ToString("n2")
            months = CStr(DateDiff(DateInterval.Month, Convert.ToDateTime(My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing).Split(",")(1)), d1))
            lblC2Friendly.Text = "Today, you hold " + totalHoldings(1) + " " + coinCodeArray(1) + " which is valued at " + C2Holdings + " " + fiatMain + " at a coin price of " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2") + " " + fiatMain + vbNewLine + "Your initial investment was " + initialInvestment(1) + " " + fiatMain + " and has matured over " + months + " months, yielding profits of " + ((CDec(totalHoldings(1)) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatMain).SelectToken("PRICE"))) - CDec(initialInvestment(1))).ToString("n2") + " " + fiatMain + " so far"

            Dim C3Holdings As String = (totalHoldings(2) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatMain).SelectToken("PRICE"))).ToString("n2")
            months = CStr(DateDiff(DateInterval.Month, Convert.ToDateTime(My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing).Split(",")(2)), d1))
            lblC3Friendly.Text = "Today, you hold " + totalHoldings(2) + " " + coinCodeArray(2) + " which is valued at " + C3Holdings + " " + fiatMain + " at a coin price of " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2") + " " + fiatMain + vbNewLine + "Your initial investment was " + initialInvestment(2) + " " + fiatMain + " and has matured over " + months + " months, yielding profits of " + ((CDec(totalHoldings(2)) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatMain).SelectToken("PRICE"))) - CDec(initialInvestment(2))).ToString("n2") + " " + fiatMain + " so far"

            Dim C4Holdings As String = (totalHoldings(3) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatMain).SelectToken("PRICE"))).ToString("n2")
            months = CStr(DateDiff(DateInterval.Month, Convert.ToDateTime(My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing).Split(",")(3)), d1))
            lblC4Friendly.Text = "Today, you hold " + totalHoldings(3) + " " + coinCodeArray(3) + " which is valued at " + C4Holdings + " " + fiatMain + " at a coin price of " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2") + " " + fiatMain + vbNewLine + "Your initial investment was " + initialInvestment(3) + " " + fiatMain + " and has matured over " + months + " months, yielding profits of " + ((CDec(totalHoldings(3)) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatMain).SelectToken("PRICE"))) - CDec(initialInvestment(3))).ToString("n2") + " " + fiatMain + " so far"


            'months = CStr(DateDiff(DateInterval.Month, Convert.ToDateTime(My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing).Split(",")(3)), d1))
            'lblC1Friendly.Text = "Today, you hold " + totalHoldings(3) + " " + coinCodeArray(3) + " which is valued at " + "? " + fiatMain + " at a coin price of " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2") + " " + fiatMain + vbNewLine + "Your initial investment was " + initialInvestment(3) + " " + fiatMain + " and has matured over " + months + " months, yielding profits of " + ((CDec(totalHoldings(3)) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatMain).SelectToken("PRICE"))) - CDec(initialInvestment(3))).ToString("n2") + " " + fiatMain + " so far"
            '(totalHoldings(0) * CDec(serverResponse.SelectToken("RAW").SelectToken(fiatMain).SelectToken("PRICE"))).ToString("n2") +

            'lblAltPrices.Text = lblAltPrices.Text.TrimEnd(vbNewLine)
            'lblAltPrices.Text = lblAltPrices.Text.TrimEnd(" ")
            'lblAltPrices.Text = lblAltPrices.Text.TrimEnd("|")
            'lblAltPrices.Text = "Coin Prices = " + lblAltPrices.Text
            'lblAltHoldings.Text = lblAltHoldings.Text.TrimEnd(vbNewLine)
            'lblAltHoldings.Text = lblAltHoldings.Text.TrimEnd(" ")
            'lblAltHoldings.Text = lblAltHoldings.Text.TrimEnd("|")
            'lblAltHoldings.Text = "Holdings - " + lblAltHoldings.Text
            'lblPrice.Text = fiatMain + ": " + CDec(serverResponse.SelectToken("RAW").SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2")
            'lblHoldingsCoin.Text = totalHoldings.ToString + " " + coinCodes
            'tsCoinPrice.Text = coinCodes + " Price: " + fiatMain + " " + CDec(serverResponse.SelectToken("RAW").SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2")
            'tsHoldingsValue.Text = coinCodes + " Holdings Value: " + fiatMain + " " + (totalHoldings * CDec(serverResponse.SelectToken("RAW").SelectToken(fiatMain).SelectToken("PRICE"))).ToString("n2")
            'tabContent.Show()
            prgTitleLoad.Hide()
            Me.Text = tabContent.SelectedTab.Text + " | AltTrackr"
            Invalidate()
            HideLoadingPanel()
            'Dim d1 As DateTime = DateTime.Today
            'Dim d2 As DateTime = Convert.ToDateTime(My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing))
            'Dim months As String = CStr(DateDiff(DateInterval.Month, d2, d1))
            'lblFriendlyPrice.Text = "Today, you hold " + totalHoldings.ToString + " " + coinCodes + " which is valued at " + (totalHoldings * CDec(serverResponse.SelectToken("RAW").SelectToken(fiatMain).SelectToken("PRICE"))).ToString("n2") + " " + fiatMain + " at a coin price of " + CDec(serverResponse.SelectToken("RAW").SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2") + " " + fiatMain + vbNewLine + "Your initial investment was " + initialInvestment + " " + fiatMain + " and has matured over " + months + " months, yielding profits of " + ((totalHoldings * CDec(serverResponse.SelectToken("RAW").SelectToken(fiatMain).SelectToken("PRICE"))) - CDec(initialInvestment)).ToString("n2") + " " + fiatMain + " so far"
            lblLastPriceUpdate.Text = "Last Updated: " + DateTime.Now
        End If
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

    Private Sub btnConfirmCancel_Click(sender As Object, e As EventArgs) Handles btnConfirmCancel.Click
        HideChangeAlert()
    End Sub

    Dim sessionUser As String = String.Empty
    Private Sub btnLLogin_Click(sender As Object, e As EventArgs) Handles btnLLogin.Click
        Dim loginResponse As String = AccountsAPI.PerformCheck(txtLUsername.Text, txtLPassword.Text)
        If loginResponse = 1 Then 'Authenticated
            tagIncorrect1.Left = -86
            tagIncorrect2.Left = -86
            pnlLIncorrect.Hide()
            pnlLLogin.Hide()
            pnlLAccount.Show()
            sessionUser = txtLUsername.Text
            tpLogin.Text = txtLUsername.Text
            tpLogin.ImageIndex = 28
            lblLUser.Text = sessionUser
            Me.Text = sessionUser + " | AltTrackr"
            Invalidate()
        ElseIf loginResponse = 0 Then 'Incorrect Credentials
            pnlLIncorrect.Show()
            Do Until tagIncorrect1.Left >= 3
                tagIncorrect1.Left += 8
                tagIncorrect2.Left += 8
                cTiming.pause(10)
            Loop
            tagIncorrect1.Left = 3
            tagIncorrect2.Left = 3
        ElseIf loginResponse = 2 Then 'Error
            'Do Nothing, user has already been notified of the failed login attempt
        Else
            MsgBox("An error has occurred. The server response is invalid." + vbNewLine + vbNewLine + "Please check for product updates and try again. If the problem persists, please submit a report or get in touch with support.", MsgBoxStyle.Critical)
        End If
        loginResponse = String.Empty
    End Sub

    Private Sub btnLLogout_Click(sender As Object, e As EventArgs) Handles btnLLogout.Click
        pnlLLogin.Show()
        pnlLAccount.Hide()
        sessionUser = String.Empty
        tpLogin.Text = "Login"
        tpLogin.ImageIndex = 25
        Me.Text = "Login | AltTrackr"
        Invalidate()
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

    Private Sub AetherButton1_Click(sender As Object, e As EventArgs) Handles AetherButton1.Click
        prgC1.PostText = " " + fiatMain
        prgC2.PostText = " " + fiatMain
        prgC3.PostText = " " + fiatMain
        prgC4.PostText = " " + fiatMain

        prgC1.Max = txtC1Goal.Text
        prgC2.Max = txtC2Goal.Text
        prgC3.Max = txtC3Goal.Text
        prgC4.Max = txtC4Goal.Text

        prgC1.Text = "Goal: " + txtC1Goal.Text + fiatMain
        prgC2.Text = "Goal: " + txtC2Goal.Text + fiatMain
        prgC3.Text = "Goal: " + txtC3Goal.Text + fiatMain
        prgC4.Text = "Goal: " + txtC4Goal.Text + fiatMain

        My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppGoals", txtC1Goal.Text + "," + txtC2Goal.Text + "," + txtC3Goal.Text + "," + txtC4Goal.Text)

        MsgBox("New goals have been set", MsgBoxStyle.Exclamation)
    End Sub

    Dim _colour As Color
    Private Sub AetherButton7_Click(sender As Object, e As EventArgs) Handles btnNotifAdd.Click
        Dim notifType As String = String.Empty
        If radNotifFD.Checked Then
            notifType = "D"
        ElseIf radNotifFW.Checked Then
            notifType = "W"
        ElseIf radNotifFM.Checked Then
            notifType = "M"
        End If

        Dim notifName As String = String.Empty
        Dim notifCoin As String = String.Empty
        Dim notifTime As String = String.Empty

        If radNotifC1.Checked Then
            notifCoin = coinCodeArray(0)
            notifName = coinNameArray(0)
        ElseIf radNotifC2.Checked Then
            notifCoin = coinCodeArray(1)
            notifName = coinNameArray(1)
        ElseIf radNotifC3.Checked Then
            notifCoin = coinCodeArray(2)
            notifName = coinNameArray(2)
        ElseIf radNotifC4.Checked Then
            notifCoin = coinCodeArray(3)
            notifName = coinNameArray(3)
        End If

        'Add a check to ensure no fields have a semicolon, since that's the string delimiter for array subitems
        notifArray.Add(notifName + ";" + notifType + ";" + notifTime + ";" + notifCoin + ";")
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppNotifs", String.Join(",", notifArray.ToArray()))

        'Sample Notification using notifArray item 0
        MsgBox(notifArray(0))
        ShowNotification(notifArray(0).Split(";")(0), notifArray(0).Split(";")(1), False, "14.55", "$5679", "$57.85")
    End Sub

    Private Sub ShowNotification(coinname As String, frequency As String, priceup As Boolean, changepercent As String, holdingsvalue As String, coinprice As String)
        Select Case frequency.ToUpper
            Case "D"
                frequency = "Daily"
            Case "W"
                frequency = "Weekly"
            Case "M"
                frequency = "Monthly"
        End Select

        Dim friendlyAlert As String
        Dim img As Image
        If priceup Then
            friendlyAlert = "Good news! " + coinname + " is up " + changepercent + "% in the last 24 hours."
            img = ilsImg.Images.Item(4)
        Else
            friendlyAlert = "Bad news! " + coinname + " is down " + changepercent + "% in the last 24 hours."
            img = ilsImg.Images.Item(1)
        End If

        Dim notif As New Notification(img, coinname + " " + frequency + " Price Update", friendlyAlert + vbNewLine + "Holdings Value: " + holdingsvalue + vbNewLine + "Coin Price: " + coinprice, _colour)
        notif.Seconds = 10
        notif.Show()
    End Sub

    Private Sub btnLCheckUpdates_Click(sender As Object, e As EventArgs) Handles btnLCheckUpdates.Click
        Dim LatestVer As Decimal = UpdateAPI.LatestVer()
        tagLatestVer.Text = "v" + LatestVer.ToString("0.0.0")
        tagLatestVer.Invalidate()

        If LatestVer > UpdateAPI.CurrentVer Then
            btnLUpdateNow.Enabled = True
            Dim result As Integer = MessageBox.Show("An update is available for AltTrackr!" + vbNewLine + "Would you like to update now?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                'Launch Update
                LaunchUpdate()
            End If
        End If
    End Sub

    Private Sub btnLUpdateNow_Click(sender As Object, e As EventArgs) Handles btnLUpdateNow.Click
        LaunchUpdate()
    End Sub

    Private Sub LaunchUpdate()
        btnLUpdateNow.Hide()
        btnLCheckUpdates.Hide()
        prgUpdate.Show()
        lblLUpdateStatus.Show()
        chkLAutoUpdate.Hide()
        chkLUpdateNotifier.Hide()
        UpdateEngine.UpdateNow(UpdateAPI.LatestVer.ToString)
    End Sub

    Private Sub AetherButton5_Click(sender As Object, e As EventArgs) Handles btnEditPrices.Click
        frmCoinSelectAll.coinArray = {coinCodeArray(0), coinCodeArray(1), coinCodeArray(2), coinCodeArray(3)}
        frmCoinSelectAll.coinNameArray = {coinNameArray(0), coinNameArray(1), coinNameArray(2), coinNameArray(3)}
        frmCoinSelectAll.Show()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEditHoldings.Click, btnEditGoals.Click
        tabContent.SelectedTab = tpPrefs
    End Sub
End Class