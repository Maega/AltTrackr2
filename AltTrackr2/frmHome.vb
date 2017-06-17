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

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        lblPrice.Font = New Font("Roboto Light", 25)
        lblHoldingsFiat.Font = New Font("Roboto Light", 25)
        lblHoldingsCoin.Font = New Font("Roboto Light", 30)
        lblLoading.Font = New Font("Roboto Light", 20)
        lblAltPrices.Font = New Font("Roboto Light", 15)
        lblAltHoldings.Font = New Font("Roboto Light", 15)
        lblFriendlyPrice.Font = New Font("Roboto Light", 12)
        GetPrices()
    End Sub

    Private Function ParseJSON(APIURL As String)
        Dim client As WebClient = New WebClient()
        Dim reply As String = client.DownloadString(APIURL)
        Return JObject.Parse(reply)
    End Function

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        GetPrices()
    End Sub

    Private Sub GetPrices()
        If Not bkgGetPrices.IsBusy Then
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
            bkgGetPrices.RunWorkerAsync()
        Else
            cTiming.WriteDebug("Attempted to fetch prices, but I'm already working on it.")
        End If
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub bkgGetPrices_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bkgGetPrices.DoWork
        serverResponse = ParseJSON("https://min-api.cryptocompare.com/data/price?fsym=" + My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppCoins", Nothing) + "&tsyms=" + My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppAltFiats", Nothing))
    End Sub

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
        lblPrice.Text = fiatMain + ": " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2")
        lblHoldingsCoin.Text = totalHoldings.ToString + " " + coinCodes
        tsCoinPrice.Text = coinCodes + " Price: " + fiatMain + " " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2")
        tsHoldingsValue.Text = coinCodes + " Holdings Value: " + fiatMain + " " + (totalHoldings * CDec(serverResponse.SelectToken(fiatMain))).ToString("n2")
        prgLoading.Hide()
        lblLoading.Hide()
        tabContent.Show()
        tbsContent.Show()
        lblHoldingsFiat.Text = fiatMain + ": " + (totalHoldings * CDec(serverResponse.SelectToken(fiatMain))).ToString("n2")

        Dim d1 As DateTime = DateTime.Today
        Dim d2 As DateTime = Convert.ToDateTime(My.Computer.Registry.GetValue(My.Settings.RegLocation, "InvestDate", Nothing))
        Dim months As String = CStr(DateDiff(DateInterval.Month, d2, d1))

        lblFriendlyPrice.Text = "Today, you hold " + totalHoldings.ToString + " " + coinCodes + " which is valued at " + (totalHoldings * CDec(serverResponse.SelectToken(fiatMain))).ToString("n2") + " " + fiatMain + " at a coin price of " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2") + " " + fiatMain + vbNewLine + "Your initial investment was " + initialInvestment + " " + fiatMain + " and has matured over " + months + " months, yielding profits of " + ((totalHoldings * CDec(serverResponse.SelectToken(fiatMain))) - CDec(initialInvestment)).ToString("n2") + " " + fiatMain + " so far"
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        ntfTray.Icon = SystemIcons.Information
        ntfTray.BalloonTipTitle = "Today's " + coinCodes + " price: " + fiatMain + " " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2")
        'ntfTray.BalloonTipText = "Today's " + coinCodes + " price: " + fiatMain + " " + CDec(serverResponse.SelectToken(fiatMain)).ToString("n2")
        ntfTray.BalloonTipText = vbNewLine + "Your holdings are worth: " + fiatMain + " " + (totalHoldings * CDec(serverResponse.SelectToken(fiatMain))).ToString("n2")
        ntfTray.BalloonTipIcon = ToolTipIcon.Info
        ntfTray.ShowBalloonTip(30000)
    End Sub
End Class