Imports MaterialSkin
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmHome
    Dim serverResponse As JObject
    Dim totalHoldings As Decimal = CDec(My.Computer.Registry.GetValue(My.Settings.RegLocation, "TotalHoldings", Nothing))
    Dim coinCodes As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppCoins", Nothing)
    Dim fiatCodes As String = My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppFiats", Nothing)
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        lblPrice.Font = New Font("Roboto Light", 25)
        lblHoldingsFiat.Font = New Font("Roboto Light", 25)
        lblHoldingsCoin.Font = New Font("Roboto Light", 30)
    End Sub

    Private Function ParseJSON(APIURL As String)
        Dim client As WebClient = New WebClient()
        Dim reply As String = client.DownloadString(APIURL)
        Return JObject.Parse(reply)
    End Function

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        serverResponse = ParseJSON("https://min-api.cryptocompare.com/data/price?fsym=" + My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppCoins", Nothing) + "&tsyms=" + My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppFiats", Nothing))
        'lblPrice.Text = "$" + CDec(serverResponse.SelectToken("USD")).ToString("n2")
        lblPrice.Text = String.Empty
        Dim fiatArray() As String = fiatCodes.Split(",")
        For Each fiatCode As String In fiatArray
            lblPrice.Text += "$" + CDec(serverResponse.SelectToken(fiatCode)).ToString("n2") + "/"
        Next
        lblPrice.Text = lblPrice.Text.TrimEnd("/")

        lblHoldingsCoin.Text = totalHoldings.ToString + " " + coinCodes
        lblHoldingsFiat.Text = "$" + (totalHoldings * CDec(serverResponse.SelectToken("USD"))).ToString("n2") + "/$" + (totalHoldings * CDec(serverResponse.SelectToken("AUD"))).ToString("n2")
    End Sub
End Class