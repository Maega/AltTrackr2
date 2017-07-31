<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.bkgGetPrices = New System.ComponentModel.BackgroundWorker()
        Me.lblAltPrices = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton7 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton6 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton5 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblFriendlyPrice = New MaterialSkin.Controls.MaterialLabel()
        Me.lblAltHoldings = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.prgLoading = New MRG.Controls.UI.LoadingCircle()
        Me.lblLoading = New MaterialSkin.Controls.MaterialLabel()
        Me.ntfTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cxtTray = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.tsCoinPrice = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsHoldingsValue = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabContent = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabDailyBrief = New System.Windows.Forms.TabPage()
        Me.tabDetails = New System.Windows.Forms.TabPage()
        Me.lblComingSoon = New MaterialSkin.Controls.MaterialLabel()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.btnSColourCustom = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.radSColourRed = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radSColourGreen = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radSColourIndigo = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radSColourBlueGrey = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnSCheckForUpdates = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.cxtBtnCheckForUpdates = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.tsiVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetAltTrackrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSVersion = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSYourInvestment = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSUpdates = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSFiatCode = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtSInvestDate = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtSInitialInvestment = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSCoinCode = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.txtSHoldings = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblLastPriceUpdate = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtRefreshMins = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbsContent = New MaterialSkin.Controls.MaterialTabSelector()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.btnFeedback = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlApplySettings = New System.Windows.Forms.Panel()
        Me.btnCancelChanges = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnApplyChanges = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblPipe = New MaterialSkin.Controls.MaterialLabel()
        Me.lblUnsaved = New MaterialSkin.Controls.MaterialLabel()
        Me.bkgCheckForUpdates = New System.ComponentModel.BackgroundWorker()
        Me.cxtTray.SuspendLayout()
        Me.tabContent.SuspendLayout()
        Me.tabDailyBrief.SuspendLayout()
        Me.tabDetails.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.cxtBtnCheckForUpdates.SuspendLayout()
        Me.pnlApplySettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialRaisedButton3.AutoSize = True
        Me.MaterialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Icon = Nothing
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(48, 219)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(164, 36)
        Me.MaterialRaisedButton3.TabIndex = 10
        Me.MaterialRaisedButton3.Text = "Refresh Prices Now"
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'bkgGetPrices
        '
        Me.bkgGetPrices.WorkerReportsProgress = True
        Me.bkgGetPrices.WorkerSupportsCancellation = True
        '
        'lblAltPrices
        '
        Me.lblAltPrices.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAltPrices.BackColor = System.Drawing.Color.Transparent
        Me.lblAltPrices.Depth = 0
        Me.lblAltPrices.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAltPrices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAltPrices.Location = New System.Drawing.Point(7, 108)
        Me.lblAltPrices.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAltPrices.Name = "lblAltPrices"
        Me.lblAltPrices.Size = New System.Drawing.Size(872, 28)
        Me.lblAltPrices.TabIndex = 11
        Me.lblAltPrices.Text = "XMR Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblAltPrices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialRaisedButton7
        '
        Me.MaterialRaisedButton7.AutoSize = True
        Me.MaterialRaisedButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton7.Depth = 0
        Me.MaterialRaisedButton7.Icon = Nothing
        Me.MaterialRaisedButton7.Location = New System.Drawing.Point(692, 80)
        Me.MaterialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton7.Name = "MaterialRaisedButton7"
        Me.MaterialRaisedButton7.Primary = True
        Me.MaterialRaisedButton7.Size = New System.Drawing.Size(110, 36)
        Me.MaterialRaisedButton7.TabIndex = 17
        Me.MaterialRaisedButton7.Text = "View Charts"
        Me.MaterialRaisedButton7.UseVisualStyleBackColor = True
        Me.MaterialRaisedButton7.Visible = False
        '
        'MaterialRaisedButton6
        '
        Me.MaterialRaisedButton6.AutoSize = True
        Me.MaterialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton6.Depth = 0
        Me.MaterialRaisedButton6.Icon = Nothing
        Me.MaterialRaisedButton6.Location = New System.Drawing.Point(554, 80)
        Me.MaterialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton6.Name = "MaterialRaisedButton6"
        Me.MaterialRaisedButton6.Primary = True
        Me.MaterialRaisedButton6.Size = New System.Drawing.Size(85, 36)
        Me.MaterialRaisedButton6.TabIndex = 16
        Me.MaterialRaisedButton6.Text = "Sell XMR"
        Me.MaterialRaisedButton6.UseVisualStyleBackColor = True
        Me.MaterialRaisedButton6.Visible = False
        '
        'MaterialRaisedButton5
        '
        Me.MaterialRaisedButton5.AutoSize = True
        Me.MaterialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton5.Depth = 0
        Me.MaterialRaisedButton5.Icon = Nothing
        Me.MaterialRaisedButton5.Location = New System.Drawing.Point(416, 80)
        Me.MaterialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton5.Name = "MaterialRaisedButton5"
        Me.MaterialRaisedButton5.Primary = True
        Me.MaterialRaisedButton5.Size = New System.Drawing.Size(80, 36)
        Me.MaterialRaisedButton5.TabIndex = 15
        Me.MaterialRaisedButton5.Text = "Buy XMR"
        Me.MaterialRaisedButton5.UseVisualStyleBackColor = True
        Me.MaterialRaisedButton5.Visible = False
        '
        'lblFriendlyPrice
        '
        Me.lblFriendlyPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFriendlyPrice.Depth = 0
        Me.lblFriendlyPrice.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFriendlyPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFriendlyPrice.Location = New System.Drawing.Point(4, 202)
        Me.lblFriendlyPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFriendlyPrice.Name = "lblFriendlyPrice"
        Me.lblFriendlyPrice.Size = New System.Drawing.Size(876, 90)
        Me.lblFriendlyPrice.TabIndex = 14
        Me.lblFriendlyPrice.Text = "Today, you hold 00.00 XMR which is valued at 00.00 AUD at a coin price of 00.00 A" &
    "UD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your initial investment was 00.00 AUD and has matured over 0 months, yieldin" &
    "g profits of 00.00 AUD so far"
        Me.lblFriendlyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAltHoldings
        '
        Me.lblAltHoldings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAltHoldings.BackColor = System.Drawing.Color.Transparent
        Me.lblAltHoldings.Depth = 0
        Me.lblAltHoldings.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAltHoldings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAltHoldings.Location = New System.Drawing.Point(7, 142)
        Me.lblAltHoldings.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAltHoldings.Name = "lblAltHoldings"
        Me.lblAltHoldings.Size = New System.Drawing.Size(872, 28)
        Me.lblAltHoldings.TabIndex = 13
        Me.lblAltHoldings.Text = "XMR Holdings - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblAltHoldings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialRaisedButton4
        '
        Me.MaterialRaisedButton4.AutoSize = True
        Me.MaterialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton4.Depth = 0
        Me.MaterialRaisedButton4.Icon = Nothing
        Me.MaterialRaisedButton4.Location = New System.Drawing.Point(111, 80)
        Me.MaterialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton4.Name = "MaterialRaisedButton4"
        Me.MaterialRaisedButton4.Primary = True
        Me.MaterialRaisedButton4.Size = New System.Drawing.Size(188, 36)
        Me.MaterialRaisedButton4.TabIndex = 12
        Me.MaterialRaisedButton4.Text = "Send Test Notification"
        Me.MaterialRaisedButton4.UseVisualStyleBackColor = True
        Me.MaterialRaisedButton4.Visible = False
        '
        'prgLoading
        '
        Me.prgLoading.Active = False
        Me.prgLoading.Color = System.Drawing.Color.DarkGray
        Me.prgLoading.InnerCircleRadius = 8
        Me.prgLoading.Location = New System.Drawing.Point(4, 172)
        Me.prgLoading.Name = "prgLoading"
        Me.prgLoading.NumberSpoke = 24
        Me.prgLoading.OuterCircleRadius = 9
        Me.prgLoading.RotationSpeed = 100
        Me.prgLoading.Size = New System.Drawing.Size(893, 131)
        Me.prgLoading.SpokeThickness = 4
        Me.prgLoading.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7
        Me.prgLoading.TabIndex = 12
        Me.prgLoading.Text = "LoadingCircle1"
        '
        'lblLoading
        '
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.Depth = 0
        Me.lblLoading.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLoading.Location = New System.Drawing.Point(4, 299)
        Me.lblLoading.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(893, 59)
        Me.lblLoading.TabIndex = 13
        Me.lblLoading.Text = "Talking with the servers, please wait"
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ntfTray
        '
        Me.ntfTray.ContextMenuStrip = Me.cxtTray
        Me.ntfTray.Text = "Maega AltTrackr"
        Me.ntfTray.Visible = True
        '
        'cxtTray
        '
        Me.cxtTray.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cxtTray.Depth = 0
        Me.cxtTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCoinPrice, Me.tsHoldingsValue, Me.ToolStripSeparator1, Me.tsExit})
        Me.cxtTray.MouseState = MaterialSkin.MouseState.HOVER
        Me.cxtTray.Name = "cxtTray"
        Me.cxtTray.Size = New System.Drawing.Size(151, 76)
        '
        'tsCoinPrice
        '
        Me.tsCoinPrice.Enabled = False
        Me.tsCoinPrice.Name = "tsCoinPrice"
        Me.tsCoinPrice.Size = New System.Drawing.Size(150, 22)
        Me.tsCoinPrice.Text = "CoinPrice"
        '
        'tsHoldingsValue
        '
        Me.tsHoldingsValue.Enabled = False
        Me.tsHoldingsValue.Name = "tsHoldingsValue"
        Me.tsHoldingsValue.Size = New System.Drawing.Size(150, 22)
        Me.tsHoldingsValue.Text = "HoldingsValue"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'tsExit
        '
        Me.tsExit.Name = "tsExit"
        Me.tsExit.Size = New System.Drawing.Size(150, 22)
        Me.tsExit.Text = "Quit AltTrackr"
        '
        'tabContent
        '
        Me.tabContent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabContent.Controls.Add(Me.tabDailyBrief)
        Me.tabContent.Controls.Add(Me.tabDetails)
        Me.tabContent.Controls.Add(Me.tabSettings)
        Me.tabContent.Depth = 0
        Me.tabContent.Location = New System.Drawing.Point(4, 66)
        Me.tabContent.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabContent.Name = "tabContent"
        Me.tabContent.SelectedIndex = 0
        Me.tabContent.Size = New System.Drawing.Size(893, 395)
        Me.tabContent.TabIndex = 18
        '
        'tabDailyBrief
        '
        Me.tabDailyBrief.Controls.Add(Me.lblAltPrices)
        Me.tabDailyBrief.Controls.Add(Me.lblFriendlyPrice)
        Me.tabDailyBrief.Controls.Add(Me.lblAltHoldings)
        Me.tabDailyBrief.Location = New System.Drawing.Point(4, 22)
        Me.tabDailyBrief.Name = "tabDailyBrief"
        Me.tabDailyBrief.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDailyBrief.Size = New System.Drawing.Size(885, 369)
        Me.tabDailyBrief.TabIndex = 0
        Me.tabDailyBrief.Text = "Daily Brief"
        Me.tabDailyBrief.UseVisualStyleBackColor = True
        '
        'tabDetails
        '
        Me.tabDetails.Controls.Add(Me.lblComingSoon)
        Me.tabDetails.Controls.Add(Me.MaterialRaisedButton7)
        Me.tabDetails.Controls.Add(Me.MaterialRaisedButton4)
        Me.tabDetails.Controls.Add(Me.MaterialRaisedButton6)
        Me.tabDetails.Controls.Add(Me.MaterialRaisedButton5)
        Me.tabDetails.Location = New System.Drawing.Point(4, 22)
        Me.tabDetails.Name = "tabDetails"
        Me.tabDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetails.Size = New System.Drawing.Size(885, 369)
        Me.tabDetails.TabIndex = 1
        Me.tabDetails.Text = "Details"
        Me.tabDetails.UseVisualStyleBackColor = True
        '
        'lblComingSoon
        '
        Me.lblComingSoon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblComingSoon.BackColor = System.Drawing.Color.Transparent
        Me.lblComingSoon.Depth = 0
        Me.lblComingSoon.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblComingSoon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblComingSoon.Location = New System.Drawing.Point(6, 170)
        Me.lblComingSoon.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblComingSoon.Name = "lblComingSoon"
        Me.lblComingSoon.Size = New System.Drawing.Size(872, 51)
        Me.lblComingSoon.TabIndex = 18
        Me.lblComingSoon.Text = "Under Active Development" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The 'Details' tab will be included in an update soon"
        Me.lblComingSoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabSettings
        '
        Me.tabSettings.BackColor = System.Drawing.SystemColors.Control
        Me.tabSettings.Controls.Add(Me.btnSColourCustom)
        Me.tabSettings.Controls.Add(Me.radSColourRed)
        Me.tabSettings.Controls.Add(Me.radSColourGreen)
        Me.tabSettings.Controls.Add(Me.radSColourIndigo)
        Me.tabSettings.Controls.Add(Me.radSColourBlueGrey)
        Me.tabSettings.Controls.Add(Me.btnSCheckForUpdates)
        Me.tabSettings.Controls.Add(Me.lblSVersion)
        Me.tabSettings.Controls.Add(Me.lblSYourInvestment)
        Me.tabSettings.Controls.Add(Me.lblSUpdates)
        Me.tabSettings.Controls.Add(Me.lblSFiatCode)
        Me.tabSettings.Controls.Add(Me.MaterialLabel5)
        Me.tabSettings.Controls.Add(Me.txtSInvestDate)
        Me.tabSettings.Controls.Add(Me.MaterialLabel4)
        Me.tabSettings.Controls.Add(Me.txtSInitialInvestment)
        Me.tabSettings.Controls.Add(Me.MaterialLabel1)
        Me.tabSettings.Controls.Add(Me.lblSCoinCode)
        Me.tabSettings.Controls.Add(Me.MaterialDivider1)
        Me.tabSettings.Controls.Add(Me.txtSHoldings)
        Me.tabSettings.Controls.Add(Me.lblLastPriceUpdate)
        Me.tabSettings.Controls.Add(Me.MaterialLabel3)
        Me.tabSettings.Controls.Add(Me.txtRefreshMins)
        Me.tabSettings.Controls.Add(Me.MaterialLabel2)
        Me.tabSettings.Controls.Add(Me.MaterialRaisedButton3)
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Size = New System.Drawing.Size(885, 369)
        Me.tabSettings.TabIndex = 2
        Me.tabSettings.Text = "Settings"
        '
        'btnSColourCustom
        '
        Me.btnSColourCustom.AutoSize = True
        Me.btnSColourCustom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSColourCustom.Depth = 0
        Me.btnSColourCustom.Icon = Nothing
        Me.btnSColourCustom.Location = New System.Drawing.Point(544, 322)
        Me.btnSColourCustom.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSColourCustom.Name = "btnSColourCustom"
        Me.btnSColourCustom.Primary = True
        Me.btnSColourCustom.Size = New System.Drawing.Size(88, 36)
        Me.btnSColourCustom.TabIndex = 33
        Me.btnSColourCustom.Text = "Custom..."
        Me.btnSColourCustom.UseVisualStyleBackColor = True
        '
        'radSColourRed
        '
        Me.radSColourRed.AutoSize = True
        Me.radSColourRed.Depth = 0
        Me.radSColourRed.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radSColourRed.Location = New System.Drawing.Point(481, 319)
        Me.radSColourRed.Margin = New System.Windows.Forms.Padding(0)
        Me.radSColourRed.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radSColourRed.MouseState = MaterialSkin.MouseState.HOVER
        Me.radSColourRed.Name = "radSColourRed"
        Me.radSColourRed.Ripple = True
        Me.radSColourRed.Size = New System.Drawing.Size(53, 30)
        Me.radSColourRed.TabIndex = 32
        Me.radSColourRed.TabStop = True
        Me.radSColourRed.Text = "Red"
        Me.radSColourRed.UseVisualStyleBackColor = True
        '
        'radSColourGreen
        '
        Me.radSColourGreen.AutoSize = True
        Me.radSColourGreen.Depth = 0
        Me.radSColourGreen.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radSColourGreen.Location = New System.Drawing.Point(415, 319)
        Me.radSColourGreen.Margin = New System.Windows.Forms.Padding(0)
        Me.radSColourGreen.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radSColourGreen.MouseState = MaterialSkin.MouseState.HOVER
        Me.radSColourGreen.Name = "radSColourGreen"
        Me.radSColourGreen.Ripple = True
        Me.radSColourGreen.Size = New System.Drawing.Size(66, 30)
        Me.radSColourGreen.TabIndex = 31
        Me.radSColourGreen.TabStop = True
        Me.radSColourGreen.Text = "Green"
        Me.radSColourGreen.UseVisualStyleBackColor = True
        '
        'radSColourIndigo
        '
        Me.radSColourIndigo.AutoSize = True
        Me.radSColourIndigo.Depth = 0
        Me.radSColourIndigo.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radSColourIndigo.Location = New System.Drawing.Point(348, 319)
        Me.radSColourIndigo.Margin = New System.Windows.Forms.Padding(0)
        Me.radSColourIndigo.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radSColourIndigo.MouseState = MaterialSkin.MouseState.HOVER
        Me.radSColourIndigo.Name = "radSColourIndigo"
        Me.radSColourIndigo.Ripple = True
        Me.radSColourIndigo.Size = New System.Drawing.Size(67, 30)
        Me.radSColourIndigo.TabIndex = 30
        Me.radSColourIndigo.TabStop = True
        Me.radSColourIndigo.Text = "Indigo"
        Me.radSColourIndigo.UseVisualStyleBackColor = True
        '
        'radSColourBlueGrey
        '
        Me.radSColourBlueGrey.AutoSize = True
        Me.radSColourBlueGrey.Depth = 0
        Me.radSColourBlueGrey.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radSColourBlueGrey.Location = New System.Drawing.Point(259, 319)
        Me.radSColourBlueGrey.Margin = New System.Windows.Forms.Padding(0)
        Me.radSColourBlueGrey.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radSColourBlueGrey.MouseState = MaterialSkin.MouseState.HOVER
        Me.radSColourBlueGrey.Name = "radSColourBlueGrey"
        Me.radSColourBlueGrey.Ripple = True
        Me.radSColourBlueGrey.Size = New System.Drawing.Size(88, 30)
        Me.radSColourBlueGrey.TabIndex = 29
        Me.radSColourBlueGrey.TabStop = True
        Me.radSColourBlueGrey.Text = "Blue Grey"
        Me.radSColourBlueGrey.UseVisualStyleBackColor = True
        '
        'btnSCheckForUpdates
        '
        Me.btnSCheckForUpdates.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSCheckForUpdates.AutoSize = True
        Me.btnSCheckForUpdates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSCheckForUpdates.ContextMenuStrip = Me.cxtBtnCheckForUpdates
        Me.btnSCheckForUpdates.Depth = 0
        Me.btnSCheckForUpdates.Icon = Nothing
        Me.btnSCheckForUpdates.Location = New System.Drawing.Point(215, 219)
        Me.btnSCheckForUpdates.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSCheckForUpdates.Name = "btnSCheckForUpdates"
        Me.btnSCheckForUpdates.Primary = True
        Me.btnSCheckForUpdates.Size = New System.Drawing.Size(158, 36)
        Me.btnSCheckForUpdates.TabIndex = 28
        Me.btnSCheckForUpdates.Text = "Check for Updates"
        Me.btnSCheckForUpdates.UseVisualStyleBackColor = True
        '
        'cxtBtnCheckForUpdates
        '
        Me.cxtBtnCheckForUpdates.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cxtBtnCheckForUpdates.Depth = 0
        Me.cxtBtnCheckForUpdates.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiVersion, Me.ToolStripSeparator2, Me.ResetAltTrackrToolStripMenuItem})
        Me.cxtBtnCheckForUpdates.MouseState = MaterialSkin.MouseState.HOVER
        Me.cxtBtnCheckForUpdates.Name = "cxtBtnCheckForUpdates"
        Me.cxtBtnCheckForUpdates.Size = New System.Drawing.Size(167, 54)
        '
        'tsiVersion
        '
        Me.tsiVersion.Name = "tsiVersion"
        Me.tsiVersion.Size = New System.Drawing.Size(166, 22)
        Me.tsiVersion.Text = "Version Unknown"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(163, 6)
        '
        'ResetAltTrackrToolStripMenuItem
        '
        Me.ResetAltTrackrToolStripMenuItem.Name = "ResetAltTrackrToolStripMenuItem"
        Me.ResetAltTrackrToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ResetAltTrackrToolStripMenuItem.Text = "Reset AltTrackr"
        '
        'lblSVersion
        '
        Me.lblSVersion.Depth = 0
        Me.lblSVersion.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSVersion.Location = New System.Drawing.Point(339, 363)
        Me.lblSVersion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSVersion.Name = "lblSVersion"
        Me.lblSVersion.Size = New System.Drawing.Size(195, 18)
        Me.lblSVersion.TabIndex = 27
        Me.lblSVersion.Text = "Software Version: 0.00"
        Me.lblSVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSVersion.Visible = False
        '
        'lblSYourInvestment
        '
        Me.lblSYourInvestment.Depth = 0
        Me.lblSYourInvestment.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSYourInvestment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSYourInvestment.Location = New System.Drawing.Point(438, 68)
        Me.lblSYourInvestment.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSYourInvestment.Name = "lblSYourInvestment"
        Me.lblSYourInvestment.Size = New System.Drawing.Size(442, 33)
        Me.lblSYourInvestment.TabIndex = 26
        Me.lblSYourInvestment.Text = "Your Investment"
        Me.lblSYourInvestment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSUpdates
        '
        Me.lblSUpdates.Depth = 0
        Me.lblSUpdates.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSUpdates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSUpdates.Location = New System.Drawing.Point(4, 68)
        Me.lblSUpdates.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSUpdates.Name = "lblSUpdates"
        Me.lblSUpdates.Size = New System.Drawing.Size(421, 33)
        Me.lblSUpdates.TabIndex = 25
        Me.lblSUpdates.Text = "Updates"
        Me.lblSUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSFiatCode
        '
        Me.lblSFiatCode.Depth = 0
        Me.lblSFiatCode.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSFiatCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSFiatCode.Location = New System.Drawing.Point(802, 178)
        Me.lblSFiatCode.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSFiatCode.Name = "lblSFiatCode"
        Me.lblSFiatCode.Size = New System.Drawing.Size(78, 20)
        Me.lblSFiatCode.TabIndex = 24
        Me.lblSFiatCode.Text = "CODE"
        Me.lblSFiatCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(471, 219)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(117, 23)
        Me.MaterialLabel5.TabIndex = 23
        Me.MaterialLabel5.Text = "Invest Date:"
        Me.MaterialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSInvestDate
        '
        Me.txtSInvestDate.Depth = 0
        Me.txtSInvestDate.Hint = ""
        Me.txtSInvestDate.Location = New System.Drawing.Point(595, 219)
        Me.txtSInvestDate.MaxLength = 32767
        Me.txtSInvestDate.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSInvestDate.Name = "txtSInvestDate"
        Me.txtSInvestDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSInvestDate.SelectedText = ""
        Me.txtSInvestDate.SelectionLength = 0
        Me.txtSInvestDate.SelectionStart = 0
        Me.txtSInvestDate.Size = New System.Drawing.Size(201, 23)
        Me.txtSInvestDate.TabIndex = 22
        Me.txtSInvestDate.TabStop = False
        Me.txtSInvestDate.Text = "00/00/0000"
        Me.txtSInvestDate.UseSystemPasswordChar = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(453, 177)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(135, 23)
        Me.MaterialLabel4.TabIndex = 21
        Me.MaterialLabel4.Text = "Initial Investment:"
        Me.MaterialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSInitialInvestment
        '
        Me.txtSInitialInvestment.Depth = 0
        Me.txtSInitialInvestment.Hint = ""
        Me.txtSInitialInvestment.Location = New System.Drawing.Point(595, 177)
        Me.txtSInitialInvestment.MaxLength = 32767
        Me.txtSInitialInvestment.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSInitialInvestment.Name = "txtSInitialInvestment"
        Me.txtSInitialInvestment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSInitialInvestment.SelectedText = ""
        Me.txtSInitialInvestment.SelectionLength = 0
        Me.txtSInitialInvestment.SelectionStart = 0
        Me.txtSInitialInvestment.Size = New System.Drawing.Size(201, 23)
        Me.txtSInitialInvestment.TabIndex = 19
        Me.txtSInitialInvestment.TabStop = False
        Me.txtSInitialInvestment.Text = "00.00"
        Me.txtSInitialInvestment.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(471, 136)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(117, 23)
        Me.MaterialLabel1.TabIndex = 18
        Me.MaterialLabel1.Text = "Total Holdings:"
        Me.MaterialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSCoinCode
        '
        Me.lblSCoinCode.Depth = 0
        Me.lblSCoinCode.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSCoinCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSCoinCode.Location = New System.Drawing.Point(802, 137)
        Me.lblSCoinCode.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSCoinCode.Name = "lblSCoinCode"
        Me.lblSCoinCode.Size = New System.Drawing.Size(78, 20)
        Me.lblSCoinCode.TabIndex = 17
        Me.lblSCoinCode.Text = "CODE"
        Me.lblSCoinCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(431, 103)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(1, 179)
        Me.MaterialDivider1.TabIndex = 16
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'txtSHoldings
        '
        Me.txtSHoldings.Depth = 0
        Me.txtSHoldings.Hint = ""
        Me.txtSHoldings.Location = New System.Drawing.Point(595, 136)
        Me.txtSHoldings.MaxLength = 32767
        Me.txtSHoldings.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSHoldings.Name = "txtSHoldings"
        Me.txtSHoldings.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSHoldings.SelectedText = ""
        Me.txtSHoldings.SelectionLength = 0
        Me.txtSHoldings.SelectionStart = 0
        Me.txtSHoldings.Size = New System.Drawing.Size(201, 23)
        Me.txtSHoldings.TabIndex = 15
        Me.txtSHoldings.TabStop = False
        Me.txtSHoldings.Text = "00.00"
        Me.txtSHoldings.UseSystemPasswordChar = False
        '
        'lblLastPriceUpdate
        '
        Me.lblLastPriceUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLastPriceUpdate.Depth = 0
        Me.lblLastPriceUpdate.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblLastPriceUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLastPriceUpdate.Location = New System.Drawing.Point(40, 177)
        Me.lblLastPriceUpdate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLastPriceUpdate.Name = "lblLastPriceUpdate"
        Me.lblLastPriceUpdate.Size = New System.Drawing.Size(343, 25)
        Me.lblLastPriceUpdate.TabIndex = 14
        Me.lblLastPriceUpdate.Text = "Last Updated:"
        Me.lblLastPriceUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(44, 138)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(177, 19)
        Me.MaterialLabel3.TabIndex = 13
        Me.MaterialLabel3.Text = "Refresh coin prices every"
        '
        'txtRefreshMins
        '
        Me.txtRefreshMins.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRefreshMins.Depth = 0
        Me.txtRefreshMins.Hint = ""
        Me.txtRefreshMins.Location = New System.Drawing.Point(227, 138)
        Me.txtRefreshMins.MaxLength = 32767
        Me.txtRefreshMins.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtRefreshMins.Name = "txtRefreshMins"
        Me.txtRefreshMins.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRefreshMins.SelectedText = ""
        Me.txtRefreshMins.SelectionLength = 0
        Me.txtRefreshMins.SelectionStart = 0
        Me.txtRefreshMins.Size = New System.Drawing.Size(82, 23)
        Me.txtRefreshMins.TabIndex = 11
        Me.txtRefreshMins.TabStop = False
        Me.txtRefreshMins.Text = "1"
        Me.txtRefreshMins.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(315, 138)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MaterialLabel2.TabIndex = 12
        Me.MaterialLabel2.Text = "minutes"
        '
        'tbsContent
        '
        Me.tbsContent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbsContent.BaseTabControl = Me.tabContent
        Me.tbsContent.Depth = 0
        Me.tbsContent.Location = New System.Drawing.Point(554, 26)
        Me.tbsContent.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbsContent.Name = "tbsContent"
        Me.tbsContent.Size = New System.Drawing.Size(343, 34)
        Me.tbsContent.TabIndex = 18
        Me.tbsContent.Text = "MaterialTabSelector1"
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Enabled = True
        Me.tmrRefresh.Interval = 10000
        '
        'btnFeedback
        '
        Me.btnFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFeedback.AutoSize = True
        Me.btnFeedback.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFeedback.Depth = 0
        Me.btnFeedback.Icon = Nothing
        Me.btnFeedback.Location = New System.Drawing.Point(566, 3)
        Me.btnFeedback.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Primary = True
        Me.btnFeedback.Size = New System.Drawing.Size(176, 36)
        Me.btnFeedback.TabIndex = 20
        Me.btnFeedback.Text = "Feedback/Bug Report"
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'pnlApplySettings
        '
        Me.pnlApplySettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlApplySettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.pnlApplySettings.Controls.Add(Me.btnCancelChanges)
        Me.pnlApplySettings.Controls.Add(Me.btnApplyChanges)
        Me.pnlApplySettings.Controls.Add(Me.lblPipe)
        Me.pnlApplySettings.Controls.Add(Me.lblUnsaved)
        Me.pnlApplySettings.Location = New System.Drawing.Point(0, 361)
        Me.pnlApplySettings.Name = "pnlApplySettings"
        Me.pnlApplySettings.Size = New System.Drawing.Size(900, 100)
        Me.pnlApplySettings.TabIndex = 21
        Me.pnlApplySettings.Visible = False
        '
        'btnCancelChanges
        '
        Me.btnCancelChanges.AutoSize = True
        Me.btnCancelChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelChanges.Depth = 0
        Me.btnCancelChanges.Icon = Nothing
        Me.btnCancelChanges.Location = New System.Drawing.Point(487, 52)
        Me.btnCancelChanges.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelChanges.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelChanges.Name = "btnCancelChanges"
        Me.btnCancelChanges.Primary = False
        Me.btnCancelChanges.Size = New System.Drawing.Size(73, 36)
        Me.btnCancelChanges.TabIndex = 20
        Me.btnCancelChanges.Text = "Cancel"
        Me.btnCancelChanges.UseVisualStyleBackColor = True
        '
        'btnApplyChanges
        '
        Me.btnApplyChanges.AutoSize = True
        Me.btnApplyChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnApplyChanges.Depth = 0
        Me.btnApplyChanges.Icon = Nothing
        Me.btnApplyChanges.Location = New System.Drawing.Point(341, 52)
        Me.btnApplyChanges.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnApplyChanges.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnApplyChanges.Name = "btnApplyChanges"
        Me.btnApplyChanges.Primary = False
        Me.btnApplyChanges.Size = New System.Drawing.Size(130, 36)
        Me.btnApplyChanges.TabIndex = 19
        Me.btnApplyChanges.Text = "Apply Changes"
        Me.btnApplyChanges.UseVisualStyleBackColor = True
        '
        'lblPipe
        '
        Me.lblPipe.AutoSize = True
        Me.lblPipe.Depth = 0
        Me.lblPipe.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPipe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPipe.Location = New System.Drawing.Point(467, 60)
        Me.lblPipe.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPipe.Name = "lblPipe"
        Me.lblPipe.Size = New System.Drawing.Size(13, 19)
        Me.lblPipe.TabIndex = 18
        Me.lblPipe.Text = "|"
        '
        'lblUnsaved
        '
        Me.lblUnsaved.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUnsaved.Depth = 0
        Me.lblUnsaved.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblUnsaved.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUnsaved.Location = New System.Drawing.Point(313, 16)
        Me.lblUnsaved.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblUnsaved.Name = "lblUnsaved"
        Me.lblUnsaved.Size = New System.Drawing.Size(274, 30)
        Me.lblUnsaved.TabIndex = 17
        Me.lblUnsaved.Text = "You have unsaved changes"
        Me.lblUnsaved.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bkgCheckForUpdates
        '
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.btnFeedback)
        Me.Controls.Add(Me.tbsContent)
        Me.Controls.Add(Me.tabContent)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.prgLoading)
        Me.Controls.Add(Me.pnlApplySettings)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maega AltTrackr"
        Me.cxtTray.ResumeLayout(False)
        Me.tabContent.ResumeLayout(False)
        Me.tabDailyBrief.ResumeLayout(False)
        Me.tabDetails.ResumeLayout(False)
        Me.tabDetails.PerformLayout()
        Me.tabSettings.ResumeLayout(False)
        Me.tabSettings.PerformLayout()
        Me.cxtBtnCheckForUpdates.ResumeLayout(False)
        Me.pnlApplySettings.ResumeLayout(False)
        Me.pnlApplySettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents bkgGetPrices As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblAltPrices As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents prgLoading As MRG.Controls.UI.LoadingCircle
    Friend WithEvents lblLoading As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ntfTray As NotifyIcon
    Friend WithEvents MaterialRaisedButton4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents cxtTray As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents tsCoinPrice As ToolStripMenuItem
    Friend WithEvents tsHoldingsValue As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsExit As ToolStripMenuItem
    Friend WithEvents lblAltHoldings As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblFriendlyPrice As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton5 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton7 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton6 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents tabContent As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabDailyBrief As TabPage
    Friend WithEvents tabDetails As TabPage
    Friend WithEvents tbsContent As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents tabSettings As TabPage
    Friend WithEvents tmrRefresh As Timer
    Friend WithEvents lblLastPriceUpdate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtRefreshMins As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnFeedback As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents pnlApplySettings As Panel
    Friend WithEvents lblUnsaved As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPipe As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblComingSoon As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents txtSHoldings As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblSCoinCode As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSFiatCode As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtSInvestDate As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtSInitialInvestment As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSYourInvestment As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSUpdates As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSVersion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnSCheckForUpdates As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents bkgCheckForUpdates As System.ComponentModel.BackgroundWorker
    Friend WithEvents cxtBtnCheckForUpdates As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents tsiVersion As ToolStripMenuItem
    Friend WithEvents btnApplyChanges As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnCancelChanges As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents radSColourRed As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radSColourGreen As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radSColourIndigo As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radSColourBlueGrey As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnSColourCustom As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ResetAltTrackrToolStripMenuItem As ToolStripMenuItem
End Class
