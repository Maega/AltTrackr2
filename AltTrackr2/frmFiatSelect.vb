Imports MaterialSkin

Public Class frmFiatSelect
    Private Sub frmFiatSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim AppMainFiat As String = Nothing
        If radMUSD.Enabled = False Then 'If USD radio button is disabled, assume the rest of the rads are too
            AppMainFiat = txtMOther.Text.Replace(" ", String.Empty)
        Else
            For Each ctrl As RadioButton In pnlMainFiat.Controls
                If ctrl.Checked Then AppMainFiat = ctrl.Text
            Next
        End If
        If AppMainFiat = Nothing Then
            MsgBox("Please select a main fiat to use with AltTrackr and try again.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim altFiatList As New List(Of String)
        For Each ctrl As CheckBox In pnlAltFiat.Controls
            If ctrl.Checked Then altFiatList.Add(ctrl.Text)
        Next
        If Not txtAOther.Text = String.Empty Then
            For Each altFiat In txtAOther.Text.Replace(" ", String.Empty).Split
                altFiatList.Add(altFiat)
            Next
        End If
        If Not altFiatList.Contains(My.Computer.Registry.GetValue(My.Settings.RegLocation, "AppMainFiat", Nothing)) Then altFiatList.Insert(0, AppMainFiat)

        My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppAltFiats", String.Join(",", altFiatList))
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppMainFiat", AppMainFiat)

        'Set default registry values for settings that aren't user-configurable in setup
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "RefreshInterval", "60000") 'Default Coin Check Update Interval: 1 minute, 60000ms
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "ColourScheme", "-13354941,-13354941,6323595,4244735,16777215") 'Default Colour Scheme
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "InitialInvestment", "0,0,0,0")
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppHoldings", "0,0,0,0")
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppGoals", "0,0,0,0")
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "InvestDate", "10/10/2010,10/10/2010,10/10/2010,10/10/2010")
        My.Computer.Registry.SetValue(My.Settings.RegLocation, "AppConfigured", "1")

        cTiming.transitionForms(Me, frmHomeMulti)
    End Sub
    Private Sub txtMOther_TextChanged(sender As Object, e As EventArgs) Handles txtMOther.TextChanged
        If txtMOther.Text = String.Empty Then
            radMUSD.Enabled = True
            radMAUD.Enabled = True
            radMEUR.Enabled = True
            radMGBP.Enabled = True
        Else
            radMUSD.Enabled = False
            radMAUD.Enabled = False
            radMEUR.Enabled = False
            radMGBP.Enabled = False
        End If
    End Sub
End Class