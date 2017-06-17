Imports MaterialSkin

Public Class frmWelcomeControls
    Private Sub frmWelcomeControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        'SkinManager.AddFormToManage(Me)
        Me.Location = frmWelcome.Location
        lblWelcome.Font = New Font("Roboto Light", 40)
        lblWelcome.ForeColor = Color.White
    End Sub

    Declare Function GetTickCount Lib "kernel32" Alias "GetTickCount" () As Long

    Private Sub pause(milliseconds As Long)
        Dim i As Long
        i = GetTickCount + milliseconds
        Do While GetTickCount < i
            Application.DoEvents()
        Loop
    End Sub

    Private Sub FadeNew(newtext As String, Optional fontsize As Integer = 40)
        Do Until Me.Opacity = 0
            Me.Opacity -= 0.1
            pause(10)
        Loop
        lblWelcome.Text = newtext
        lblWelcome.Font = New Font("Roboto Light", fontsize)
        Do Until Me.Opacity = 1
            Me.Opacity += 0.1
            pause(10)
        Loop
    End Sub

    Dim ticks As Integer = 0
    Private Sub tmrTransition_Tick(sender As Object, e As EventArgs) Handles tmrTransition.Tick
        Select Case ticks
            Case 0
                FadeNew("Remember, AltTrackr is in Alpha")
            Case 1
                FadeNew("Use Windows Key + B to report bugs", 35)
            Case 2
                FadeNew("Every bug report helps a ton")
            Case 3
                FadeNew("You can also leave feedback with Win+B", 33)
            Case 4
                FadeNew("We're ready to setup your experience", 35)
            Case 5
                FadeNew("On the next screen you'll select your coin", 33)
            Case 6
                FadeNew("Then you'll get to choose your theme and fiat", 30)
            Case 7
                FadeNew("We'll setup the rest from there")
            Case 8
                FadeNew("Welcome to AltTrackr")
                tmrTransition.Interval = 2500
            Case 9
                tmrTransition.Stop()
                ticks = 0
                frmCoinSelect.Opacity = 0
                frmCoinSelect.Show()
                frmWelcome.Text = String.Empty
                Do Until Me.Opacity = 0
                    Me.Opacity -= 0.1
                    pause(10)
                Loop
                Do Until frmCoinSelect.Opacity = 1
                    frmCoinSelect.Opacity += 0.01
                    pause(10)
                Loop
                frmWelcome.Close()
                Me.Close()
        End Select
        ticks += 1
    End Sub
End Class