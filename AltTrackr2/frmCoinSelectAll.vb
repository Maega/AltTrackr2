Imports System.ComponentModel
Imports System.Net
Imports MaterialSkin
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmCoinSelectAll

    Public Shared coinArray() As String = {String.Empty, String.Empty, String.Empty, String.Empty}
    Public Shared coinNameArray() As String = {String.Empty, String.Empty, String.Empty, String.Empty}

    Private Sub frmCoinSelectAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK

        If Not coinArray(0) = String.Empty Then chkC1.Text = "Slot 1: " + coinArray(0) : chkC1.Checked = True
        If Not coinArray(1) = String.Empty Then chkC2.Text = "Slot 2: " + coinArray(1) : chkC2.Checked = True
        If Not coinArray(2) = String.Empty Then chkC3.Text = "Slot 3: " + coinArray(2) : chkC3.Checked = True
        If Not coinArray(3) = String.Empty Then chkC4.Text = "Slot 4: " + coinArray(3) : chkC4.Checked = True
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

    Private Sub LvModule_MouseClick(sender As Object, e As MouseEventArgs) Handles LvModule.MouseClick
        If e.Button = MouseButtons.Right Then
            If LvModule.FocusedItem.Bounds.Contains(e.Location) = True Then
                tsiCoinName.Text = LvModule.FocusedItem.Text
                selectedCoin(0) = LvModule.FocusedItem.Text
                selectedCoin(1) = LvModule.FocusedItem.SubItems(1).Text
                cxtItem.Show(Cursor.Position)
            End If
        End If
    End Sub

    Dim selectedCoin() As String = {String.Empty, String.Empty} '0 = Crypto Code, 1 = Crypto Name
    Private Sub tsiAddC1_Click(sender As Object, e As EventArgs) Handles tsiAddC1.Click
        coinArray(0) = selectedCoin(0)
        coinNameArray(0) = selectedCoin(1)
        chkC1.Text = "Slot 1: " + selectedCoin(0)
        chkC1.Checked = True
    End Sub

    Private Sub tsiAddC2_Click(sender As Object, e As EventArgs) Handles tsiAddC2.Click
        coinArray(1) = selectedCoin(0)
        coinNameArray(1) = selectedCoin(1)
        chkC2.Text = "Slot 2: " + selectedCoin(0)
        chkC2.Checked = True
    End Sub

    Private Sub tsiAddC3_Click(sender As Object, e As EventArgs) Handles tsiAddC3.Click
        coinArray(2) = selectedCoin(0)
        coinNameArray(2) = selectedCoin(1)
        chkC3.Text = "Slot 3: " + selectedCoin(0)
        chkC3.Checked = True
    End Sub

    Private Sub tsiAddC4_Click(sender As Object, e As EventArgs) Handles tsiAddC4.Click
        coinArray(3) = selectedCoin(0)
        coinNameArray(3) = selectedCoin(1)
        chkC4.Text = "Slot 4: " + selectedCoin(0)
        chkC4.Checked = True
    End Sub

    Private Sub MaterialRaisedButton1_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        If chkC1.Checked And chkC2.Checked And chkC3.Checked And chkC4.Checked Then
            'Ready to continue
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppCoins", String.Join(",", coinArray).ToUpper)
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppCoinNames", String.Join(",", coinNameArray))
            Me.Text = "Coin Manager"
            cTiming.transitionForms(Me, frmFiatSelect)
        Else
            MsgBox("Sorry, for now you need to assign all four coins a value. This will be optimised in future builds.", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class