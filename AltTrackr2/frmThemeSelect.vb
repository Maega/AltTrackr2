Imports MaterialSkin

Public Class frmThemeSelect
    Private Sub frmThemeSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        lblThemeChoose.Font = New Font("Roboto Light", 30)
        lblLightHead.Font = New Font("Roboto Light", 10)
        lblDarkHead.Font = New Font("Roboto Light", 10)
    End Sub

    Dim lightPending As Boolean = False
    Dim darkPending As Boolean = False
    Private Sub btnLight_Click(sender As Object, e As EventArgs) Handles btnLight.Click
        If btnLight.Text = "Use this theme?" Then
            saveTheme("LIGHT")
        Else
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            lblThemeChoose.ForeColor = Color.FromArgb(222, 0, 0, 0)
            lblLightHead.ForeColor = Color.FromArgb(222, 0, 0, 0)
            lblDarkHead.ForeColor = Color.FromArgb(222, 0, 0, 0)
            btnDark.Text = "Dark Mode"
            lblDarkHead.Text = "Preview"
            btnLight.Text = "Use this theme?"
            lblLightHead.Text = "Confirm"
        End If
    End Sub

    Private Sub btnDark_Click(sender As Object, e As EventArgs) Handles btnDark.Click
        If btnDark.Text = "Use this theme?" Then
            saveTheme("DARK")
        Else
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            lblThemeChoose.ForeColor = Color.White
            lblLightHead.ForeColor = Color.White
            lblDarkHead.ForeColor = Color.White
            btnLight.Text = "Light Mode"
            lblLightHead.Text = "Preview"
            btnDark.Text = "Use this theme?"
            lblDarkHead.Text = "Confirm"
        End If
    End Sub

    Private Sub saveTheme(theme As String)
        If theme.ToUpper = "LIGHT" Then
            'If LIGHT comes through, save light theme
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "Theme", "LIGHT")
        Else
            'If DARK (or any other string comes through - to prevent issues), save dark theme.
            My.Computer.Registry.SetValue(My.Settings.RegLocation, "Theme", "DARK")
        End If
        cTiming.transitionForms(Me, frmHome)
    End Sub
End Class