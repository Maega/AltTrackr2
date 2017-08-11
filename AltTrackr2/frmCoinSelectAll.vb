Imports System.ComponentModel
Imports System.Net
Imports MaterialSkin
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmCoinSelectAll
    Private Sub frmCoinSelectAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT

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

    Private Async Sub frmCoinSelectAll_ShownAsync(sender As Object, e As EventArgs) Handles Me.Shown
        'Initialize Progress Wheel
        prgLoading.NumberSpoke = 120
        prgLoading.SpokeThickness = 5
        prgLoading.InnerCircleRadius = 30
        prgLoading.OuterCircleRadius = 35
        prgLoading.RotationSpeed = 20
        prgLoading.Active = True
        prgLoading.Visible = True
        prgLoading.Show()

        Dim allVersions = New List(Of Version)
        Using wc = New WebClient() With {.Proxy = Nothing}
            Dim JSON = Await wc.DownloadStringTaskAsync("https://www.cryptocompare.com/api/data/coinlist/") 'Downloads the JSON file
            Dim values = JsonConvert.DeserializeObject(Of JObject)(JSON) 'Converts it to JObject
            results = values
            'values = values.SelectToken("Data")
            For Each i In values("Data").Children().Children() 'Gets the versions
                Dim lvItem As New ListViewItem(i.ToObject(Of Version).Name)
                lvItem.SubItems.Add(i.ToObject(Of Version).CoinName)
                lvItem.SubItems.Add(i.ToObject(Of Version).Algorithm)
                LvModule.Items.Add(lvItem)
                'LvModule.Items.Add(i.ToObject(Of Version).Name).SubItems.Add(i.ToObject(Of Version).CoinName)
            Next
        End Using
        prgLoading.Hide()
    End Sub

    Public Structure Version
        Public Url As String
        Public ImageUrl As String
        Public Name As String
        Public CoinName As String
        Public Algorithm As String
    End Structure

    Dim results As Object
    Dim imageurl As String
    Dim imageBytes() As Byte

    Private Sub LvModule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvModule.SelectedIndexChanged
        prgLoading.Show()

        If LvModule.SelectedItems.Count > 0 Then
            Try
                If bkgGetData.IsBusy Then bkgGetData.CancelAsync()

                'Get base image URL from request
                Dim baseimageurl As String = results("BaseImageUrl").ToString
                Dim baselinkurl As String = results("BaseLinkUrl").ToString

                imageurl = baseimageurl + results("Data")(LvModule.SelectedItems(0).Text)("ImageUrl").ToString

                bkgGetData.RunWorkerAsync()
            Catch ex As Exception
                picCoinLogo.Image = Nothing
            End Try
        End If

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs)
        Dim item1 As ListViewItem = LvModule.FindItemWithText(txtSearch.Text)
        If item1 IsNot Nothing Then
            'MsgBox("Item: " + item1.Text)
            LvModule.FocusedItem = item1
            LvModule.Focus()
            item1.Selected = True
            item1.Focused = True
            item1.EnsureVisible()
        End If
    End Sub

    Dim textChangedFire As Boolean = True
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If textChangedFire Then
            Dim item1 As ListViewItem = LvModule.FindItemWithText(txtSearch.Text)
            If item1 IsNot Nothing Then
                'MsgBox("Item: " + item1.Text)
                LvModule.FocusedItem = item1
                'LvModule.Focus()
                item1.Selected = True
                'item1.Focused = True
                item1.EnsureVisible()

                txtSearch.Focus()
            End If
        End If
        textChangedFire = True
    End Sub

    Private Sub bkgGetData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bkgGetData.DoWork
        'New WebClient to download image data
        Dim imageDownloadClient As New System.Net.WebClient
        'Store image data in byte array
        imageBytes = imageDownloadClient.DownloadData(imageurl)
    End Sub

    Private Sub bkgGetData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bkgGetData.RunWorkerCompleted
        'Create a new MemoryStream using the byte array
        Dim imageStream As New IO.MemoryStream(imageBytes)
        'Create a bitmap using the MemoryStream
        picCoinLogo.Image = New Bitmap(imageStream)
        prgLoading.Hide()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        If txtSearch.Text = "Search by Coin Code" Then textChangedFire = False : txtSearch.Text = String.Empty
    End Sub
End Class