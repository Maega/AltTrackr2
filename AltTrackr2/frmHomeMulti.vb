Imports System.ComponentModel
Imports MaterialSkin
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Notification
Imports LiveCharts.Wpf
Imports LiveCharts
Imports LiveCharts.WinForms
Imports LiveCharts.Defaults

Public Class frmHomeMulti
    Dim serverResponse As JObject
    Dim coinData As JObject
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
        Me.Text = tabContent.SelectedTab.Text + " | " + UpdateAPI.AppShortName
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
        bkgGetOnlineMeta.RunWorkerAsync()
        Me.CenterToParent()
        tagCurrentVer.Text = "v" + UpdateAPI.CurrentVer.ToString("0.00")

        If Not My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue(Application.ProductName) = Nothing Then chkLaunchStartup.Checked = True

        txtC1Goal.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppGoals", Nothing).Split(",")(0)
        txtC2Goal.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppGoals", Nothing).Split(",")(1)
        txtC3Goal.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppGoals", Nothing).Split(",")(2)
        txtC4Goal.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppGoals", Nothing).Split(",")(3)

        txtC1Holdings.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppHoldings", Nothing).Split(",")(0)
        txtC2Holdings.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppHoldings", Nothing).Split(",")(1)
        txtC3Holdings.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppHoldings", Nothing).Split(",")(2)
        txtC4Holdings.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppHoldings", Nothing).Split(",")(3)

        txtC1Initial.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "InitialInvestment", Nothing).Split(",")(0)
        txtC2Initial.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "InitialInvestment", Nothing).Split(",")(1)
        txtC3Initial.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "InitialInvestment", Nothing).Split(",")(2)
        txtC4Initial.Text = My.Computer.Registry.GetValue(My.Settings.RegLocation, "InitialInvestment", Nothing).Split(",")(3)

        'The following CartesianChart initialisation is temporary. It will be cleaned and moved to the new ChartingEngine soon.
        For Each cachart As LiveCharts.WinForms.CartesianChart In {CartesianChart1, CartesianChart2, CartesianChart3}
            With cachart
                .BackColor = Color.FromKnownColor(KnownColor.White)
                .ForeColor = Color.FromKnownColor(KnownColor.ControlText)
                .Font = New Drawing.Font("Microsoft Sans Serif", 8.25)

                Values = New ChartValues(Of ObservableValue)() From {New ObservableValue(134), New ObservableValue(142), New ObservableValue(147), New ObservableValue(137), New ObservableValue(135), New ObservableValue(154)}

                Dim lineSeries1 As New LineSeries()
                With lineSeries1
                    .Values = Values
                    .StrokeThickness = 4
                    '.StrokeDashArray = New System.Windows.Media.DoubleCollection(New Double() {2})
                    '.Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 69))
                    '.Fill = System.Windows.Media.Brushes.Transparent
                    .LineSmoothness = 0
                    .PointGeometrySize = 18
                    .Title = "XMR - High"
                End With

                Dim AxisX As New Axis
                Dim SeparatorX As New Separator
                Dim AxisY As New Axis
                Dim SeparatorY As New Separator

                With SeparatorX
                    '.Step = TimeSpan.FromSeconds(1).Ticks
                    .StrokeThickness = 0
                    .Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                End With

                With SeparatorY
                    .StrokeThickness = 0
                    '.StrokeDashArray = New System.Windows.Media.DoubleCollection(New Double() {4})
                    .Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                End With

                AxisX.DisableAnimations = True
                'AxisX.IsMerged = True
                AxisX.LabelFormatter = Function(value) New System.DateTime(CLng(value)).ToString("mm:ss")
                AxisX.Separator = SeparatorX

                'AxisY.IsMerged = True
                AxisY.Separator = SeparatorY

                .Series.Add(lineSeries1)
                '.Series.Add(lineSeries2)
                '.Background = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
                .AxisX.Add(AxisX)
                .AxisY.Add(AxisY)
            End With
        Next

        tpHistory.Invalidate()
    End Sub

    Public Property Values() As ChartValues(Of ObservableValue)
        Get
            Return m_Values
        End Get
        Set
            m_Values = Value
        End Set
    End Property
    Private m_Values As ChartValues(Of ObservableValue)

    Private Sub AetherButton5_Click_1(sender As Object, e As EventArgs) Handles AetherButton5.Click
        Dim r As New Random

        ICticker = 0
        tmrInvalidateCharts.Start()
        Values.Add(New ObservableValue(r.Next(130, 170))) 'Add new point
        If Values.Count > 6 Then Values.RemoveAt(0) 'Remove earliest point if there are more than six
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
        ShowChangeAlert()
    End Sub

    Private Sub ShowChangeAlert()
        pnlUnsaved.Show()
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
        Do Until pnlLoading.Height <= 0
            pnlLoading.Height -= 15
            cTiming.pause(10)
        Loop
        pnlLoading.Hide()
        'pnlLoading.Top = 68
        pnlLoading.Height = 485
        pnlLoading.Location = New Point(0, 66)
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

    Dim C1imageBytes() As Byte, C2imageBytes() As Byte, C3imageBytes() As Byte, C4imageBytes() As Byte
    Private Sub bkgGetOnlineMeta_DoWork(sender As Object, e As DoWorkEventArgs) Handles bkgGetOnlineMeta.DoWork
        Try
            coinData = ParseJSON("https://www.cryptocompare.com/api/data/coinlist/")
            Dim imageDownloadClient As New System.Net.WebClient

            Dim C1imageurl As String = coinData.SelectToken("BaseImageUrl").ToString + coinData.SelectToken("Data").SelectToken(coinCodeArray(0)).SelectToken("ImageUrl").ToString
            C1imageBytes = imageDownloadClient.DownloadData(C1imageurl)

            Dim C2imageurl As String = coinData.SelectToken("BaseImageUrl").ToString + coinData.SelectToken("Data").SelectToken(coinCodeArray(1)).SelectToken("ImageUrl").ToString
            C2imageBytes = imageDownloadClient.DownloadData(C2imageurl)

            Dim C3imageurl As String = coinData.SelectToken("BaseImageUrl").ToString + coinData.SelectToken("Data").SelectToken(coinCodeArray(2)).SelectToken("ImageUrl").ToString
            C3imageBytes = imageDownloadClient.DownloadData(C3imageurl)

            Dim C4imageurl As String = coinData.SelectToken("BaseImageUrl").ToString + coinData.SelectToken("Data").SelectToken(coinCodeArray(3)).SelectToken("ImageUrl").ToString
            C4imageBytes = imageDownloadClient.DownloadData(C4imageurl)

            'Download Latest Update Engine (about 42kb)
            Dim UpdateEngineURL As String = "https://update.maeganetwork.com/engine/win/UpdEngine.exe"
            Try
                My.Computer.Network.DownloadFile(UpdateEngineURL, AppDomain.CurrentDomain.BaseDirectory + "UpdEngine.exe", "", "", False, 10000, True)
            Catch ex As Exception
                MsgBox("Failed to download latest update engine :(" + vbNewLine + vbNewLine + "If updates aren't working, please manually download the Update Engine from the URL below and place it in your AltTrackr install directory." + vbNewLine + vbNewLine + UpdateEngineURL, MsgBoxStyle.Exclamation)
            End Try

        Catch ex As Exception
            bkgGetOnlineMeta.CancelAsync()
        End Try
    End Sub

    Private Sub bkgGetOnlineMeta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bkgGetOnlineMeta.RunWorkerCompleted
        Dim C1imageStream As New IO.MemoryStream(C1imageBytes)
        picC1Logo.Image = New Bitmap(C1imageStream)

        Dim C2imageStream As New IO.MemoryStream(C2imageBytes)
        picC2Logo.Image = New Bitmap(C2imageStream)

        Dim C3imageStream As New IO.MemoryStream(C3imageBytes)
        picC3Logo.Image = New Bitmap(C3imageStream)

        Dim C4imageStream As New IO.MemoryStream(C4imageBytes)
        picC4Logo.Image = New Bitmap(C4imageStream)
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
                        lblAltPrices.Text += fiatCode + ": " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCode).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n2") + " | "

                        'MsgBox(Array.IndexOf(coinCodeArray, coinCode))
                        lblAltHoldings.Text += fiatCode + ": " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCode)) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCode).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n2") + " | "
                    Else 'If the price is less than one fiat, round to four decimal places for less valuable coins
                        lblAltPrices.Text += fiatCode + ": " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCode).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n4") + " | "
                        lblAltHoldings.Text += fiatCode + ": " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCode)) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCode).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n4") + " | "
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

            'Plans to use System.Reflection in future to dramatically slim down all this code and make unlimited coin slots a possibility are in place.

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

            'Set "prefs" coin group box names
            grpC1Pref.Text = coinNameArray(0) + " (" + coinCodeArray(0) + ")"
            grpC2Pref.Text = coinNameArray(1) + " (" + coinCodeArray(1) + ")"
            grpC3Pref.Text = coinNameArray(2) + " (" + coinCodeArray(2) + ")"
            grpC4Pref.Text = coinNameArray(3) + " (" + coinCodeArray(3) + ")"

            'Set "prefs" goal descriptors
            lblC1Goal.Text = "Goal (" + fiatMain + ")"
            lblC2Goal.Text = "Goal (" + fiatMain + ")"
            lblC3Goal.Text = "Goal (" + fiatMain + ")"
            lblC4Goal.Text = "Goal (" + fiatMain + ")"

            'Set "prefs" initial investment descriptors
            lblC1Initial.Text = "Initial Invest (" + fiatMain + ")"
            lblC2Initial.Text = "Initial Invest (" + fiatMain + ")"
            lblC3Initial.Text = "Initial Invest (" + fiatMain + ")"
            lblC4Initial.Text = "Initial Invest (" + fiatMain + ")"

            'Set "prefs" holdings descriptors
            lblPrefC1Holdings.Text = "Holdings (" + coinCodeArray(0) + ")"
            lblPrefC2Holdings.Text = "Holdings (" + coinCodeArray(1) + ")"
            lblPrefC3Holdings.Text = "Holdings (" + coinCodeArray(2) + ")"
            lblPrefC4Holdings.Text = "Holdings (" + coinCodeArray(3) + ")"

            'Set "prefs" coin rads
            radC1Edit.Text = coinNameArray(0) + " (" + coinCodeArray(0) + ")"
            radC2Edit.Text = coinNameArray(1) + " (" + coinCodeArray(1) + ")"
            radC3Edit.Text = coinNameArray(2) + " (" + coinCodeArray(2) + ")"
            radC4Edit.Text = coinNameArray(3) + " (" + coinCodeArray(3) + ")"

            'Set Coin 1 Price & Holdings Stats
            lblC1PricesDetailed.Text = coinCodeArray(0) + " Prices - "
            lblC1HoldingsDetailed.Text = coinCodeArray(0) + " Holdings - "
            For Each fiatCode As String In fiatArray
                If CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatCode).SelectToken("PRICE")) >= 1.0 Then 'If the price is more than one fiat in value, round to two decimal places
                    lblC1PricesDetailed.Text += fiatCode + ": " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n2") + " | "
                    lblC1HoldingsDetailed.Text += fiatCode + ": " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCodeArray(0))) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n2") + " | "
                Else 'If the price is less than one fiat, round to four decimal places for less valuable coins
                    lblC1PricesDetailed.Text += fiatCode + ": " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n4") + " | "
                    lblC1HoldingsDetailed.Text += fiatCode + ": " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCodeArray(0))) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n4") + " | "
                End If
            Next
            lblC1PricesDetailed.Text = lblC1PricesDetailed.Text.TrimEnd(" ")
            lblC1PricesDetailed.Text = lblC1PricesDetailed.Text.TrimEnd("|")
            lblC1HoldingsDetailed.Text = lblC1HoldingsDetailed.Text.TrimEnd(" ")
            lblC1HoldingsDetailed.Text = lblC1HoldingsDetailed.Text.TrimEnd("|")

            'Set Coin 2 Price & Holdings Stats
            lblC2PricesDetailed.Text = coinCodeArray(1) + " Prices - "
            lblC2HoldingsDetailed.Text = coinCodeArray(1) + " Holdings - "
            For Each fiatCode As String In fiatArray
                If CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatCode).SelectToken("PRICE")) >= 1.0 Then 'If the price is more than one fiat in value, round to two decimal places
                    lblC2PricesDetailed.Text += fiatCode + ": " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n2") + " | "
                    lblC2HoldingsDetailed.Text += fiatCode + ": " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCodeArray(1))) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n2") + " | "
                Else 'If the price is less than one fiat, round to four decimal places for less valuable coins
                    lblC2PricesDetailed.Text += fiatCode + ": " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n4") + " | "
                    lblC2HoldingsDetailed.Text += fiatCode + ": " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCodeArray(1))) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n4") + " | "
                End If
            Next
            lblC2PricesDetailed.Text = lblC2PricesDetailed.Text.TrimEnd(" ")
            lblC2PricesDetailed.Text = lblC2PricesDetailed.Text.TrimEnd("|")
            lblC2HoldingsDetailed.Text = lblC2HoldingsDetailed.Text.TrimEnd(" ")
            lblC2HoldingsDetailed.Text = lblC2HoldingsDetailed.Text.TrimEnd("|")

            'Set Coin 3 Price & Holdings Stats
            lblC3PricesDetailed.Text = coinCodeArray(2) + " Prices - "
            lblC3HoldingsDetailed.Text = coinCodeArray(2) + " Holdings - "
            For Each fiatCode As String In fiatArray
                If CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatCode).SelectToken("PRICE")) >= 1.0 Then 'If the price is more than one fiat in value, round to two decimal places
                    lblC3PricesDetailed.Text += fiatCode + ": " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n2") + " | "
                    lblC3HoldingsDetailed.Text += fiatCode + ": " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCodeArray(2))) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n2") + " | "
                Else 'If the price is less than one fiat, round to four decimal places for less valuable coins
                    lblC3PricesDetailed.Text += fiatCode + ": " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n4") + " | "
                    lblC3HoldingsDetailed.Text += fiatCode + ": " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCodeArray(2))) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n4") + " | "
                End If
            Next
            lblC3PricesDetailed.Text = lblC3PricesDetailed.Text.TrimEnd(" ")
            lblC3PricesDetailed.Text = lblC3PricesDetailed.Text.TrimEnd("|")
            lblC3HoldingsDetailed.Text = lblC3HoldingsDetailed.Text.TrimEnd(" ")
            lblC3HoldingsDetailed.Text = lblC3HoldingsDetailed.Text.TrimEnd("|")

            'Set Coin 4 Price & Holdings Stats
            lblC4PricesDetailed.Text = coinCodeArray(3) + " Prices - "
            lblC4HoldingsDetailed.Text = coinCodeArray(3) + " Holdings - "
            For Each fiatCode As String In fiatArray
                If CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatCode).SelectToken("PRICE")) >= 1.0 Then 'If the price is more than one fiat in value, round to two decimal places
                    lblC4PricesDetailed.Text += fiatCode + ": " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n2") + " | "
                    lblC4HoldingsDetailed.Text += fiatCode + ": " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCodeArray(3))) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n2") + " | "
                Else 'If the price is less than one fiat, round to four decimal places for less valuable coins
                    lblC4PricesDetailed.Text += fiatCode + ": " + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatCode).SelectToken("PRICE")).ToString("n4") + " | "
                    lblC4HoldingsDetailed.Text += fiatCode + ": " + (totalHoldings(Array.IndexOf(coinCodeArray, coinCodeArray(3))) * CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatCode).SelectToken("PRICE"))).ToString("n4") + " | "
                End If
            Next
            lblC4PricesDetailed.Text = lblC4PricesDetailed.Text.TrimEnd(" ")
            lblC4PricesDetailed.Text = lblC4PricesDetailed.Text.TrimEnd("|")
            lblC4HoldingsDetailed.Text = lblC4HoldingsDetailed.Text.TrimEnd(" ")
            lblC4HoldingsDetailed.Text = lblC4HoldingsDetailed.Text.TrimEnd("|")

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
            Dim arrayPlaces() As Integer = {0, 1, 2, 3}
            For Each arrayPlace In arrayPlaces
                Dim currentCoinTag As Control
                Dim currentCoinLabel As Control
                Select Case arrayPlace
                    Case 0
                        currentCoinTag = tpCoin1
                        currentCoinLabel = lblC1Price
                    Case 1
                        currentCoinTag = tpCoin2
                        currentCoinLabel = lblC2Price
                    Case 2
                        currentCoinTag = tpCoin3
                        currentCoinLabel = lblC3Price
                    Case 3
                        currentCoinTag = tpCoin4
                        currentCoinLabel = lblC4Price
                End Select
                If CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(arrayPlace)).SelectToken(fiatMain).SelectToken("PRICE")) < 0.1 Then
                    'MsgBox("Condition 1 - " + coinCodeArray(arrayPlace) + " Less Than 0.1" + vbNewLine + "Editing: " + currentCoinTag.ToString + " - " + currentCoinLabel.ToString)
                    If coinCodeArray.Count - arrayPlace > 0 Then currentCoinTag.Tag = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(arrayPlace)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.0000") : currentCoinLabel.Text = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(arrayPlace)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.0000")
                Else
                    'MsgBox("Condition 2 - " + coinCodeArray(arrayPlace) + " Greater Than 0.1" + vbNewLine + "Editing: " + currentCoinTag.ToString + " - " + currentCoinLabel.ToString)
                    If coinCodeArray.Count - arrayPlace > 0 Then currentCoinTag.Tag = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(arrayPlace)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00") : currentCoinLabel.Text = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(arrayPlace)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00")
                End If
                Invalidate()
            Next


            'If coinCodeArray.Count - 1 > 0 Then tpCoin2.Tag = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00").ToString : lblC2Price.Text = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(1)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00")
            'If coinCodeArray.Count - 2 > 0 Then tpCoin3.Tag = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00").ToString : lblC3Price.Text = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(2)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00")
            'If coinCodeArray.Count - 3 > 0 Then tpCoin4.Tag = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00").ToString : lblC4Price.Text = "$" + CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(3)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("0.00")

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
            Me.Text = tabContent.SelectedTab.Text + " | " + UpdateAPI.AppShortName
            Invalidate()
            HideLoadingPanel()
            'Dim d1 As DateTime = DateTime.Today
            'Dim d2 As DateTime = Convert.ToDateTime(My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing))
            'Dim months As String = CStr(DateDiff(DateInterval.Month, d2, d1))
            'lblFriendlyPrice.Text = "Today, you hold " + totalHoldings.ToString + " " + coinCodes + " which is valued at " + (totalHoldings * CDec(serverResponse.SelectToken("RAW").SelectToken(fiatMain).SelectToken("PRICE"))).ToString("n2") + " " + fiatMain + " at a coin price Of " + CDec(serverResponse.SelectToken("RAW").SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2") + " " + fiatMain + vbNewLine + "Your initial investment was " + initialInvestment + " " + fiatMain + " And has matured over " + months + " months, yielding profits Of " + ((totalHoldings * CDec(serverResponse.SelectToken("RAW").SelectToken(fiatMain).SelectToken("PRICE"))) - CDec(initialInvestment)).ToString("n2") + " " + fiatMain + " so far"
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
                    Me.Text = "Loading Data | " + UpdateAPI.AppShortName
                Else
                    Select Case GetRandom(0, 5)
                        Case 0
                            Me.Text = "Discussing " + coinNameArray(GetRandom(0, 4)) + " by the water cooler"
                        Case 1
                            Me.Text = "Calculating how rich you've become"
                        Case 2
                            Me.Text = "Loading Tip: Remember, every bug report helps"
                        Case 3
                            Me.Text = "Sending " + coinNameArray(GetRandom(0, 4)) + " to the moon"
                        Case 4
                            Me.Text = "HODL, HODL, HODL, HODL"
                    End Select
                    Me.Text = Me.Text + " | " + UpdateAPI.AppShortName
                End If
                'tabContent.Hide()

                'Old Loading Animation (now disabled)
                'pnlLoadingMain.Show()
                'pnlLoadingMain.BringToFront()

                'Full Load Progress Wheel
                prgFullLoad.NumberSpoke = 170 '120
                prgFullLoad.SpokeThickness = 4
                prgFullLoad.InnerCircleRadius = 70 '30
                prgFullLoad.OuterCircleRadius = 75 '35
                prgFullLoad.RotationSpeed = 20
                prgFullLoad.Active = True

                pnlLoading.Show()
                pnlLoading.BringToFront()
                pnlLoading.Location = New Point(0, 66)

                'pnlLoading.Show()
                'pnlLoading.BringToFront()
            Else
                'Title Load Progress Wheel
                'Me.Text = "Loading Data"
                Invalidate()
                prgTitleLoad.NumberSpoke = 120
                prgTitleLoad.SpokeThickness = 4
                prgTitleLoad.InnerCircleRadius = 8
                prgTitleLoad.OuterCircleRadius = 9
                prgTitleLoad.RotationSpeed = 20
                prgTitleLoad.Active = True
                prgTitleLoad.Visible = True
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
        bkgLogin.RunWorkerAsync(False)
    End Sub

    Private Sub PostAuthentication(status As Integer)
        Select Case status
            Case 1
                tagIncorrect1.Left = -86
                tagIncorrect2.Left = -86
                pnlLIncorrect.Hide()
                pnlLLogin.Hide()
                pnlLAccount.Show()
                sessionUser = txtLUsername.Text
                tpLogin.Text = txtLUsername.Text
                tpLogin.ImageIndex = 28
                lblLUser.Text = sessionUser
                Me.Text = sessionUser + " | " + UpdateAPI.AppShortName
                Invalidate()
            Case 0
                pnlLIncorrect.Show()
                Do Until tagIncorrect1.Left >= 3
                    tagIncorrect1.Left += 8
                    tagIncorrect2.Left += 8
                    cTiming.pause(10)
                Loop
                tagIncorrect1.Left = 3
                tagIncorrect2.Left = 3
            Case Else
                cTiming.WriteDebug("Incorrect status passed to PostAuthentication")
        End Select
    End Sub

    Private Sub btnLLogout_Click(sender As Object, e As EventArgs) Handles btnLLogout.Click
        pnlLLogin.Show()
        pnlLAccount.Hide()
        sessionUser = String.Empty
        tpLogin.Text = "Login"
        tpLogin.ImageIndex = 25
        Me.Text = "Login | " + UpdateAPI.AppShortName
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
        Dim notifFiat As String = String.Empty

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

        'Make this a choice. Add some rads like are present for the other options above.
        notifFiat = fiatMain

        'Add a check to ensure no fields have a semicolon, since that's the string delimiter for array subitems
        notifArray.Add(notifName + ";" + notifType + ";" + notifTime + ";" + notifCoin + ";" + notifFiat + ";")
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppNotifs", String.Join(",", notifArray.ToArray()))

        'Sample alert using notifArray item 0
        MsgBox(notifArray(0))
        Dim isUp As Boolean
        If lblC1DChange.Text.Contains("+") Then isUp = True Else isUp = False
        Dim strippedChangePercent As String = lblC1DChange.Text
        strippedChangePercent = strippedChangePercent.Replace("+", String.Empty)
        strippedChangePercent = strippedChangePercent.Replace("-", String.Empty)
        strippedChangePercent = strippedChangePercent.Replace("%", String.Empty)
        Dim coinPrice As String = CDec(serverResponse.SelectToken("RAW").SelectToken(coinCodeArray(0)).SelectToken(fiatMain).SelectToken("PRICE")).ToString("n2")
        cTiming.ShowAlert(notifArray(0).Split(";")(0), notifArray(0).Split(";")(1), isUp, lblC1DChange.Text, "$" + (CDec(totalHoldings(0)) * CDec(coinPrice)).ToString("n2"), "$" + coinPrice)
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

    Private Sub radEdit_CheckedChanged(sender As Object, e As EventArgs) Handles radC1Edit.CheckedChanged, radC2Edit.CheckedChanged, radC3Edit.CheckedChanged, radC4Edit.CheckedChanged
        grpC1Pref.Hide()
        grpC2Pref.Hide()
        grpC3Pref.Hide()
        grpC4Pref.Hide()
        If radC1Edit.Checked Then
            grpC1Pref.Show()
        ElseIf radC2Edit.Checked Then
            grpC2Pref.Show()
        ElseIf radC3Edit.Checked Then
            grpC3Pref.Show()
        ElseIf radC4Edit.Checked Then
            grpC4Pref.Show()
        End If
    End Sub

    Private Sub Ambiance_Button_21_Click(sender As Object, e As EventArgs) Handles Ambiance_Button_21.Click
        ShowChangeAlert()
    End Sub

    Private Sub AetherButton5_Click(sender As Object, e As EventArgs) Handles btnEditPrices.Click
        frmCoinSelectAll.coinArray = {coinCodeArray(0), coinCodeArray(1), coinCodeArray(2), coinCodeArray(3)}
        frmCoinSelectAll.coinNameArray = {coinNameArray(0), coinNameArray(1), coinNameArray(2), coinNameArray(3)}
        frmCoinSelectAll.Show()
        Me.Close()
    End Sub

    Private Sub ShowHideAltTrackr_Click(sender As Object, e As EventArgs) Handles ShowHideAltTrackrToolStripMenuItem.Click, ntfTray.MouseDoubleClick
        If Me.Visible Then Me.Hide() Else Me.Show()
    End Sub

    Private Sub chkLaunchStartup_CheckedChanged(sender As Object, e As EventArgs) Handles chkLaunchStartup.CheckedChanged
        If chkLaunchStartup.Checked = False Then
            Dim result As Integer = MessageBox.Show("Preventing AltTrackr from launching on system startup will hinder your ability to receive price notifications." + vbNewLine + vbNewLine + "Are you sure that you would like to prevent AltTrackr from starting with Windows?", "Whoa There!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.No Then
                chkLaunchStartup.Checked = True
            End If
        End If
    End Sub

    Private Sub btnViewChangelog_Click(sender As Object, e As EventArgs) Handles btnViewChangelog.Click
        cTiming.transitionForms(Me, frmChangelog, True, True)
    End Sub

    Private Sub btnFeedbackFacebook_Click(sender As Object, e As EventArgs) Handles btnFeedbackFacebook.Click
        Process.Start("https://m.me/maeganetwork")
    End Sub

    Private Sub tmrAlerts_Tick(sender As Object, e As EventArgs) Handles tmrAlerts.Tick
        'Check for pending alerts
        'Check for updates every n runthroughs
        'cTiming.ShowNotif("An update is available for AltTrackr. You can update to version 1.04 from your account page.", "AltTrackr Update Available") 'Sample notification
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub

    Private Sub AetherButton4_Click_1(sender As Object, e As EventArgs) Handles AetherButton4.Click
        frmCharts.Show()
    End Sub

    Dim ICticker As Integer = 0
    Private Sub tmrInvalidate_Tick(sender As Object, e As EventArgs) Handles tmrInvalidateCharts.Tick
        ICticker += 1
        If ICticker < 100 Then
            tpHistory.Invalidate()
        Else
            ICticker = 0
            tmrInvalidateCharts.Stop()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEditHoldings.Click, btnEditGoals.Click
        tabContent.SelectedTab = tpPrefs
    End Sub

    Private Sub btnConfirmSave_Click(sender As Object, e As EventArgs) Handles btnConfirmSave.Click
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppGoals", txtC1Goal.Text + "," + txtC2Goal.Text + "," + txtC3Goal.Text + "," + txtC4Goal.Text)
        coinGoals = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppGoals", Nothing).Split(",")

        My.Computer.Registry.SetValue(My.Settings.RegLocation, "InitialInvestment", txtC1Initial.Text + "," + txtC2Initial.Text + "," + txtC3Initial.Text + "," + txtC4Initial.Text)
        initialInvestment = My.Computer.Registry.GetValue(My.Settings.RegLocation, "InitialInvestment", Nothing).Split(",")

        My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppHoldings", txtC1Holdings.Text + "," + txtC2Holdings.Text + "," + txtC3Holdings.Text + "," + txtC4Holdings.Text)
        totalHoldings = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppHoldings", Nothing).Split(",")

        If chkLaunchStartup.Checked Then
            'Add to Startup
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, """" + Application.ExecutablePath + """ silent")
        Else
            'Remove from Startup
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        End If

        HideChangeAlert()
        GetPrices()
    End Sub

    Dim loginResponse As Integer
    Private Sub bkgLogin_DoWork(sender As Object, e As DoWorkEventArgs) Handles bkgLogin.DoWork
        Dim isTokenAuth As Boolean = CBool(e.Argument)
        If isTokenAuth Then
            If AccountsAPI.TokenAuth Then loginResponse = 1 Else loginResponse = 0
        Else
            loginResponse = AccountsAPI.PerformCheck(txtLUsername.Text, txtLPassword.Text)
        End If
    End Sub

    Private Sub bkgLogin_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bkgLogin.RunWorkerCompleted
        If loginResponse = 1 Then 'Authenticated
            PostAuthentication(1)
        ElseIf loginResponse = 0 Then 'Incorrect Credentials
            PostAuthentication(0)
        ElseIf loginResponse = 2 Then 'Error
            'Do Nothing, user has already been notified of the failed login attempt
        Else
            MsgBox("An error has occurred. The server response is invalid." + vbNewLine + vbNewLine + "Please check for product updates and try again. If the problem persists, please submit a report or get in touch with support.", MsgBoxStyle.Critical)
        End If
        loginResponse = Nothing
    End Sub

    Private Sub frmHomeMulti_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        frmWelcome.Close()
    End Sub

    Private Sub pnlLastUpdated_MouseEnter(sender As Object, e As EventArgs) Handles pnlLastUpdated.MouseEnter
        lblLastPriceUpdate.Show()
    End Sub

    Private Sub pnlLastUpdated_MouseLeave(sender As Object, e As EventArgs) Handles pnlLastUpdated.MouseLeave
        lblLastPriceUpdate.Hide()
    End Sub
End Class