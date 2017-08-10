Imports System.Net
Imports MaterialSkin
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmCoinSelectAll
    Dim results As Object
    Private Sub frmCoinSelectAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK

        ' MsgBox(results.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'Get base image URL from request
        Dim baseimageurl As String = results("BaseImageUrl").ToString
        Dim baselinkurl As String = results("BaseLinkUrl").ToString

        Dim imageurl As String '= baseimageurl + results("Data")(TextBox1.Text)("ImageUrl").ToString

        'New WebClient to download image data
        Dim imageDownloadClient As New System.Net.WebClient
        'Store image data in byte array
        Dim imageBytes() As Byte = imageDownloadClient.DownloadData(imageurl)
        'Create a new MemoryStream using the byte array
        Dim imageStream As New IO.MemoryStream(imageBytes)
        'Create a bitmap using the MemoryStream
        picCoinLogo.Image = New Bitmap(imageStream)

        'Dim coinName As String = results("Data")(TextBox1.Text)("CoinName")
        'lblCoinName.Text = coinName

        'Dim coindata = results("Data")("SUB")
        'MsgBox(coindata.ToString)
        'MsgBox(results.ToString)


    End Sub

    Private Sub frmCoinSelectAll_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Dim client As WebClient = New WebClient()
        'Dim jsonstring As String = client.DownloadString("https://www.cryptocompare.com/api/data/coinlist/")
        'results = JObject.Parse(jsonstring)

        'Dim responseStatus As String = results("Response")
        ' If Not responseStatus = "Success" Then
        'MsgBox("There was a problem fetching coin data. Please report this issue.", MsgBoxStyle.Critical)
        'End If
    End Sub

    Public Structure Version
        Public Url As String
        Public ImageUrl As String
        Public Name As String
        Public CoinName As String
        Public Algorithm As String
    End Structure

    Private Async Sub Button2_ClickAsync(sender As Object, e As EventArgs) Handles Button2.Click
        Dim allVersions = New List(Of Version)
        Using wc = New WebClient() With {.Proxy = Nothing}
            Dim JSON = Await wc.DownloadStringTaskAsync("https://www.cryptocompare.com/api/data/coinlist/") 'Downloads the JSON file
            Dim values = JsonConvert.DeserializeObject(Of JObject)(JSON) 'Converts it to JObject

            'values = values.SelectToken("Data")
            For Each i In values("Data").Children().Children() 'Gets the versions
                Dim lvItem As New ListViewItem(i.ToObject(Of Version).Name)
                lvItem.SubItems.Add(i.ToObject(Of Version).CoinName)
                lvItem.SubItems.Add(i.ToObject(Of Version).Algorithm)
                LvModule.Items.Add(lvItem)
                'LvModule.Items.Add(i.ToObject(Of Version).Name).SubItems.Add(i.ToObject(Of Version).CoinName)
            Next

            MsgBox("SUCCESSFULLY PARSED NESTED JSON DATA!", MsgBoxStyle.Information, "Holy Fuck!")
        End Using
    End Sub
End Class