Imports MaterialSkin

Public Class frmCoinSelect
    Dim animationSpeed As Integer = 40
    Dim coinArray() As String = {"xmr,Monero,logoXMR", "btc,Bitcoin,logoBTC", "eth,Ethereum,logoETH", "doge,Dogecoin,logoDOGE", "ltc,Litecoin,logoLTC"}
    Dim coinArrayPosition As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        updateSelection()
    End Sub

    Private Sub updateSelection()
        lblCoinName.Text = coinArray(coinArrayPosition).Split(",")(1) & " (" & coinArray(coinArrayPosition).Split(",")(0).ToUpper & ")"
        picLogo.Image = My.Resources.ResourceManager.GetObject(coinArray(coinArrayPosition).Split(",")(2))
    End Sub

    Public Sub leftLeaveForm(control As Control)
        Do Until control.Left <= 0 - control.Width
            control.Left -= animationSpeed
            pause(1)
        Loop
        teleportLeft(control)
    End Sub

    Public Sub rightLeaveForm(control As Control)
        Do Until control.Left >= Me.Width
            control.Left += animationSpeed
            pause(1)
        Loop
        teleportRight(control)
    End Sub

    Public Sub locationOriginal(control As Control)
        Dim centerPosition As Integer = (Me.Width / 2) - (control.Width / 2)
        Do Until control.Left >= centerPosition - animationSpeed And control.Left <= centerPosition + animationSpeed
            If control.Left > centerPosition Then
                control.Left -= animationSpeed
            ElseIf control.Left < centerPosition Then
                control.Left += animationSpeed
            Else
                Exit Do
            End If
            pause(1)
        Loop
        control.Left = centerPosition
    End Sub

    Public Sub teleportLeft(control As Control)
        control.Left = 0 - control.Width
    End Sub

    Public Sub teleportRight(control As Control)
        control.Left = Me.Width
    End Sub

    Declare Function GetTickCount Lib "kernel32" Alias "GetTickCount" () As Long

    Private Sub pause(milliseconds As Long)
        Dim i As Long
        i = GetTickCount + milliseconds
        Do While GetTickCount < i
            Application.DoEvents()
        Loop
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        leftLeaveForm(picLogo)

        coinArrayPosition -= 1
        If coinArrayPosition < 0 Then coinArrayPosition = coinArray.Length - 1
        updateSelection()

        teleportRight(picLogo)
        locationOriginal(picLogo)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        rightLeaveForm(picLogo)

        coinArrayPosition += 1
        If coinArrayPosition >= coinArray.Length Then coinArrayPosition = 0
        updateSelection()

        teleportLeft(picLogo)
        locationOriginal(picLogo)
    End Sub

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click
        frmCoinSelectAll.coinArray(0) = coinArray(coinArrayPosition).Split(",")(0).ToUpper
        frmCoinSelectAll.coinNameArray(0) = coinArray(coinArrayPosition).Split(",")(1)
        frmCoinSelectAll.Text = "Select Your Other Coins"
        cTiming.transitionForms(Me, frmCoinSelectAll)
    End Sub

    Private Sub btnBack_MouseHover(sender As Object, e As EventArgs) Handles btnBack.MouseHover
        Do Until btnBack.Height = 76
            btnBack.Height += 1
            btnBack.Top -= 1
            btnBack.Left -= 1
            btnBack.Width += 1
            pause(50)
        Loop
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        Do Until btnBack.Height = 73
            btnBack.Height -= 1
            btnBack.Top += 1
            btnBack.Left += 1
            btnBack.Width -= 1
            pause(50)
        Loop
    End Sub

    Private Sub btnNext_MouseHover(sender As Object, e As EventArgs) Handles btnNext.MouseHover
        Do Until btnNext.Height = 76
            btnNext.Height += 1
            btnNext.Top -= 1
            btnNext.Left -= 1
            btnNext.Width += 1
            pause(50)
        Loop
    End Sub

    Private Sub btnNext_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        Do Until btnNext.Height = 73
            btnNext.Height -= 1
            btnNext.Top += 1
            btnNext.Left += 1
            btnNext.Width -= 1
            pause(50)
        Loop
    End Sub

    Private Sub btnOtherCoin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnOtherCoin.LinkClicked
        cTiming.transitionForms(Me, frmCoinSelectAll)
    End Sub
End Class
