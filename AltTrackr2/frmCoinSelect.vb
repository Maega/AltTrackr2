Imports MaterialSkin

Public Class frmCoinSelect
    Dim animationSpeed As Integer = 14
    Dim coinArray() As String = {"xmr,Monero,logoXMR", "btc,Bitcoin,logoBTC", "eth,Ethereum,logoETH", "doge,Dogecoin,logoDOGE", "ltc,Litecoin,logoLTC"}
    Dim coinArrayPosition As Integer = 0
    Public Const AppID As String = "6"
    Public Const RegLocation As String = "HKEY_CURRENT_USER\Software\Maega\" + AppID + "\"

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
        My.Computer.Registry.SetValue(RegLocation, "AppCoins", coinArray(coinArrayPosition).Split(",")(0).ToUpper)
        cTiming.transitionForms(Me, frmThemeSelect)
    End Sub
End Class
