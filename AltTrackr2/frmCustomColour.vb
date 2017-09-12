Option Strict On
Imports MaterialSkin

Public Class frmCustomColour
    Dim readyForLive As Boolean = False
    Private Sub txtCS_TextChanged(sender As Object, e As EventArgs) Handles txtCSPrimary.TextChanged, txtCSDarkPrimary.TextChanged, txtCSLightPrimary.TextChanged, txtCSAccent.TextChanged, txtCSTextShade.TextChanged
        If readyForLive Then
            Try
                SkinManager.ColorScheme = New ColorScheme(CType(txtCSPrimary.Text, Primary), CType(txtCSDarkPrimary.Text, Primary), CType(txtCSLightPrimary.Text, Primary), CType(txtCSAccent.Text, Accent), CType(txtCSTextShade.Text, TextShade))
                ConvertRGB(CType(txtCSPrimary.Text, Primary), CType(txtCSDarkPrimary.Text, Primary), CType(txtCSLightPrimary.Text, Primary), CType(txtCSAccent.Text, Accent), CType(txtCSTextShade.Text, TextShade))
                ' lblChanges.Text = "Success. If you think this would make a good combo, let us know!"
                lblChanges.Text = "RGB: " + PrimaryColor.R.ToString + " " + PrimaryColor.G.ToString + " " + PrimaryColor.B.ToString + " - ARGB: " + PrimaryColor.ToArgb.ToString
                Dim newcolour As Color = Color.FromArgb(255, 255, 255)
                lblChanges.Text = PrimaryColor.ToArgb.ToString + " " + newcolour.ToArgb.ToString
            Catch ex As Exception
                lblChanges.Text = "Sorry, couldn't make that change. Make sure all text fields are filled in."
            End Try
        End If
    End Sub

    Private Sub frmCustomColour_Load(sender As Object, e As EventArgs) Handles Me.Shown
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        Dim ColorRegVal As String = CType(My.Computer.Registry.GetValue(My.Settings.RegLocation, "ColourScheme", Nothing), String)
        Dim ColourArray() As String = ColorRegVal.Split(CType(",", Char()))
        txtCSPrimary.Text = ColourArray(0)
        txtCSDarkPrimary.Text = ColourArray(1)
        txtCSLightPrimary.Text = ColourArray(2)
        txtCSAccent.Text = ColourArray(3)
        txtCSTextShade.Text = ColourArray(4)
        readyForLive = True
    End Sub

    Public PrimaryColor As Color, DarkPrimaryColor As Color, LightPrimaryColor As Color, AccentColor As Color, TextColor As Color

    Private Sub btnCSPrimaryCint_Click(sender As Object, e As EventArgs) Handles btnCSPrimaryCint.Click
        Try
            Dim red As Integer = CInt(txtCSPrimaryR.Text.ToString)
            Dim green As Integer = CInt(txtCSPrimaryG.Text.ToString)
            Dim blue As Integer = CInt(txtCSPrimaryB.Text.ToString)
            Dim newcolour As Color = Color.FromArgb(red, green, blue)
            txtCSPrimary.Text = newcolour.ToArgb.ToString
        Catch ex As Exception
            lblChanges.Text = "Sorry, couldn't make that conversion. Make sure all 'Primary' RGB fields are between 0 and 255"
        End Try
    End Sub

    Private Sub btnCSAccentCint_Click(sender As Object, e As EventArgs) Handles btnCSAccentCint.Click
        Try
            Dim red As Integer = CInt(txtCSAccentR.Text.ToString)
            Dim green As Integer = CInt(txtCSAccentG.Text.ToString)
            Dim blue As Integer = CInt(txtCSAccentB.Text.ToString)
            Dim newcolour As Color = Color.FromArgb(red, green, blue)
            txtCSAccent.Text = newcolour.ToArgb.ToString
        Catch ex As Exception
            lblChanges.Text = "Sorry, couldn't make that conversion. Make sure all 'Accent' RGB fields are between 0 and 255"
        End Try
    End Sub

    Private Sub btnCSSave_Click(sender As Object, e As EventArgs) Handles btnCSSave.Click
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "ColourScheme", txtCSPrimary.Text + "," + txtCSDarkPrimary.Text + "," + txtCSLightPrimary.Text + "," + txtCSAccent.Text + "," + txtCSTextShade.Text)
        frmHome.GetSettings()
        lblChanges.Text = "Your changes have been saved. To revert this change, choose a standard colour scheme from settings."
    End Sub

    Private Sub btnCSSubmit_Click(sender As Object, e As EventArgs) Handles btnCSSubmit.Click
        MsgBox("Your proposed colour scheme will be sent with the feedback report. On the next screen, please choose 'positive' and add any additional information you feel might be necessary.", MsgBoxStyle.Information)
        Dim frmFeedback As New frmFeedback("Custom Colour Scheme Submission: " + txtCSPrimary.Text + "," + txtCSDarkPrimary.Text + "," + txtCSLightPrimary.Text + "," + txtCSAccent.Text + "," + txtCSTextShade.Text)
        frmFeedback.Show()
    End Sub

    Private Sub btnPicker_Click(sender As Object, e As EventArgs) Handles btnPicker.Click
        If pickerActive Then pickerActive = False : btnPicker.Text = "Toggle Picker: OFF" Else pickerActive = True : btnPicker.Text = "Toggle Picker: ON"
    End Sub

    Private Sub btnCSTextShadeCint_Click(sender As Object, e As EventArgs) Handles btnCSTextShadeCint.Click
        Try
            Dim red As Integer = CInt(txtCSTextShadeR.Text.ToString)
            Dim green As Integer = CInt(txtCSTextShadeG.Text.ToString)
            Dim blue As Integer = CInt(txtCSTextShadeB.Text.ToString)
            Dim newcolour As Color = Color.FromArgb(red, green, blue)
            txtCSTextShade.Text = newcolour.ToArgb.ToString
        Catch ex As Exception
            lblChanges.Text = "Sorry, couldn't make that conversion. Make sure all 'Text Shade' RGB fields are between 0 and 255"
        End Try
    End Sub

    Private Sub btnCSLightPrimaryCint_Click(sender As Object, e As EventArgs) Handles btnCSLightPrimaryCint.Click
        Try
            Dim red As Integer = CInt(txtCSLightPrimaryR.Text.ToString)
            Dim green As Integer = CInt(txtCSLightPrimaryG.Text.ToString)
            Dim blue As Integer = CInt(txtCSLightPrimaryB.Text.ToString)
            Dim newcolour As Color = Color.FromArgb(red, green, blue)
            txtCSLightPrimary.Text = newcolour.ToArgb.ToString
        Catch ex As Exception
            lblChanges.Text = "Sorry, couldn't make that conversion. Make sure all 'Light Primary' RGB fields are between 0 and 255"
        End Try
    End Sub

    Private Sub AetherButton1_Click(sender As Object, e As EventArgs) Handles AetherButton1.Click
        If AetherButton1.Text = "Preview" Then
            txtTabMain.Text = txtTabMain.Text.Replace("#", "")
            AetherTabControl.colorTabMain = "#" + txtTabMain.Text
            AetherTabControl.colorTabSelected = "#" + txtTabSelected.Text
            AetherTabControl.colorTabSeparator1 = "#" + txtTabSeparator1.Text
            AetherTabControl.colorTabSeperator2 = "#" + txtTabSeparator2.Text
            AetherTabControl.colorTabTagBorder = "#" + txtTabTagBorder.Text
            AetherTabControl.colorTabTagMain = "#" + txtTabTagMain.Text
            AetherTabControl.colorTabTagText = "#" + txtTabTagText.Text
            AetherTabControl.colorTabText = "#" + txtTabText.Text
            frmHomeMulti.tabContent.Invalidate()
        End If
    End Sub

    Private Sub btnCSDarkPrimaryCint_Click(sender As Object, e As EventArgs) Handles btnCSDarkPrimaryCint.Click
        Try
            Dim red As Integer = CInt(txtCSDarkPrimaryR.Text.ToString)
            Dim green As Integer = CInt(txtCSDarkPrimaryG.Text.ToString)
            Dim blue As Integer = CInt(txtCSDarkPrimaryB.Text.ToString)
            Dim newcolour As Color = Color.FromArgb(red, green, blue)
            txtCSDarkPrimary.Text = newcolour.ToArgb.ToString
        Catch ex As Exception
            lblChanges.Text = "Sorry, couldn't make that conversion. Make sure all 'Dark Primary' RGB fields are between 0 and 255"
        End Try
    End Sub

    Public Sub ConvertRGB(primary As Primary, darkPrimary As Primary, lightPrimary As Primary, accent As Accent, textShade As TextShade)
        'Color
        PrimaryColor = CInt(primary).ToColor()
        DarkPrimaryColor = CInt(darkPrimary).ToColor()
        LightPrimaryColor = CInt(lightPrimary).ToColor()
        AccentColor = CInt(accent).ToColor()
        TextColor = CInt(textShade).ToColor()
    End Sub

    Dim pickerActive As Boolean = True
    Private Sub txtTab_Enter(sender As Object, e As EventArgs) Handles txtTabMain.Enter, txtTabSelected.Enter, txtTabSeparator1.Enter, txtTabSeparator2.Enter, txtTabTagBorder.Enter, txtTabTagMain.Enter, txtTabTagText.Enter, txtTabText.Enter
        If pickerActive Then
            Dim cDialog As New ColorDialog()
            cDialog.AnyColor = True
            If (cDialog.ShowDialog() = DialogResult.OK) Then
                'MsgBox(cDialog.Color.ToArgb.ToString)
                'Dim strColorHex As String = Hex(Convert.ToInt32(cDialog.Color.ToArgb()))
                Dim strColorHex As String = String.Format("{0:X2}{1:X2}{2:X2}", cDialog.Color.R, cDialog.Color.G, cDialog.Color.B)
                Me.ActiveControl.Text = strColorHex
            End If
        End If
    End Sub
End Class
Public Class ColorExtension

    Public Shared Function ToColor(argb As Integer) As Color
        Return Color.FromArgb((argb And &HFF0000) >> 16, (argb And &HFF00) >> 8, argb And &HFF)
    End Function
End Class