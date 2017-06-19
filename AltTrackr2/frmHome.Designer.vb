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
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
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
        Me.lblLastPriceUpdate = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtRefreshMins = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbsContent = New MaterialSkin.Controls.MaterialTabSelector()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.btnApplyChanges = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnBugReport = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnFeedback = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlApplySettings = New System.Windows.Forms.Panel()
        Me.lblPipe = New MaterialSkin.Controls.MaterialLabel()
        Me.lblUnsaved = New MaterialSkin.Controls.MaterialLabel()
        Me.btnCancelChanges = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.cxtTray.SuspendLayout()
        Me.tabContent.SuspendLayout()
        Me.tabDailyBrief.SuspendLayout()
        Me.tabDetails.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.pnlApplySettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialRaisedButton1.BackColor = System.Drawing.SystemColors.Control
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(275, 102)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(160, 23)
        Me.MaterialRaisedButton1.TabIndex = 5
        Me.MaterialRaisedButton1.Text = "Add Holdings"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = False
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialRaisedButton2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(454, 102)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(160, 23)
        Me.MaterialRaisedButton2.TabIndex = 6
        Me.MaterialRaisedButton2.Text = "Edit Holdings"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = False
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(344, 233)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(196, 23)
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
        Me.MaterialRaisedButton7.Depth = 0
        Me.MaterialRaisedButton7.Location = New System.Drawing.Point(692, 80)
        Me.MaterialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton7.Name = "MaterialRaisedButton7"
        Me.MaterialRaisedButton7.Primary = True
        Me.MaterialRaisedButton7.Size = New System.Drawing.Size(132, 23)
        Me.MaterialRaisedButton7.TabIndex = 17
        Me.MaterialRaisedButton7.Text = "View Charts"
        Me.MaterialRaisedButton7.UseVisualStyleBackColor = True
        Me.MaterialRaisedButton7.Visible = False
        '
        'MaterialRaisedButton6
        '
        Me.MaterialRaisedButton6.Depth = 0
        Me.MaterialRaisedButton6.Location = New System.Drawing.Point(554, 80)
        Me.MaterialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton6.Name = "MaterialRaisedButton6"
        Me.MaterialRaisedButton6.Primary = True
        Me.MaterialRaisedButton6.Size = New System.Drawing.Size(132, 23)
        Me.MaterialRaisedButton6.TabIndex = 16
        Me.MaterialRaisedButton6.Text = "Sell XMR"
        Me.MaterialRaisedButton6.UseVisualStyleBackColor = True
        Me.MaterialRaisedButton6.Visible = False
        '
        'MaterialRaisedButton5
        '
        Me.MaterialRaisedButton5.Depth = 0
        Me.MaterialRaisedButton5.Location = New System.Drawing.Point(416, 80)
        Me.MaterialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton5.Name = "MaterialRaisedButton5"
        Me.MaterialRaisedButton5.Primary = True
        Me.MaterialRaisedButton5.Size = New System.Drawing.Size(132, 23)
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
        Me.MaterialRaisedButton4.Depth = 0
        Me.MaterialRaisedButton4.Location = New System.Drawing.Point(111, 80)
        Me.MaterialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton4.Name = "MaterialRaisedButton4"
        Me.MaterialRaisedButton4.Primary = True
        Me.MaterialRaisedButton4.Size = New System.Drawing.Size(259, 23)
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
        Me.tabContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.lblComingSoon.Size = New System.Drawing.Size(872, 28)
        Me.lblComingSoon.TabIndex = 18
        Me.lblComingSoon.Text = "XMR Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblComingSoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabSettings
        '
        Me.tabSettings.BackColor = System.Drawing.SystemColors.Control
        Me.tabSettings.Controls.Add(Me.lblLastPriceUpdate)
        Me.tabSettings.Controls.Add(Me.MaterialLabel3)
        Me.tabSettings.Controls.Add(Me.txtRefreshMins)
        Me.tabSettings.Controls.Add(Me.MaterialLabel2)
        Me.tabSettings.Controls.Add(Me.MaterialRaisedButton1)
        Me.tabSettings.Controls.Add(Me.MaterialRaisedButton2)
        Me.tabSettings.Controls.Add(Me.MaterialRaisedButton3)
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Size = New System.Drawing.Size(885, 369)
        Me.tabSettings.TabIndex = 2
        Me.tabSettings.Text = "Settings"
        '
        'lblLastPriceUpdate
        '
        Me.lblLastPriceUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLastPriceUpdate.Depth = 0
        Me.lblLastPriceUpdate.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblLastPriceUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLastPriceUpdate.Location = New System.Drawing.Point(271, 197)
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
        Me.MaterialLabel3.Location = New System.Drawing.Point(277, 158)
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
        Me.txtRefreshMins.Location = New System.Drawing.Point(460, 158)
        Me.txtRefreshMins.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtRefreshMins.Name = "txtRefreshMins"
        Me.txtRefreshMins.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRefreshMins.SelectedText = ""
        Me.txtRefreshMins.SelectionLength = 0
        Me.txtRefreshMins.SelectionStart = 0
        Me.txtRefreshMins.Size = New System.Drawing.Size(82, 23)
        Me.txtRefreshMins.TabIndex = 11
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
        Me.MaterialLabel2.Location = New System.Drawing.Point(548, 158)
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
        'btnApplyChanges
        '
        Me.btnApplyChanges.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnApplyChanges.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnApplyChanges.Depth = 0
        Me.btnApplyChanges.Location = New System.Drawing.Point(340, 61)
        Me.btnApplyChanges.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnApplyChanges.Name = "btnApplyChanges"
        Me.btnApplyChanges.Primary = True
        Me.btnApplyChanges.Size = New System.Drawing.Size(122, 18)
        Me.btnApplyChanges.TabIndex = 15
        Me.btnApplyChanges.Text = "Apply Changes"
        Me.btnApplyChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnApplyChanges.UseVisualStyleBackColor = False
        '
        'btnBugReport
        '
        Me.btnBugReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBugReport.Depth = 0
        Me.btnBugReport.Location = New System.Drawing.Point(692, 3)
        Me.btnBugReport.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBugReport.Name = "btnBugReport"
        Me.btnBugReport.Primary = True
        Me.btnBugReport.Size = New System.Drawing.Size(123, 18)
        Me.btnBugReport.TabIndex = 19
        Me.btnBugReport.Text = "Bug Report"
        Me.btnBugReport.UseVisualStyleBackColor = True
        '
        'btnFeedback
        '
        Me.btnFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFeedback.Depth = 0
        Me.btnFeedback.Location = New System.Drawing.Point(566, 3)
        Me.btnFeedback.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Primary = True
        Me.btnFeedback.Size = New System.Drawing.Size(123, 18)
        Me.btnFeedback.TabIndex = 20
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'pnlApplySettings
        '
        Me.pnlApplySettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlApplySettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.pnlApplySettings.Controls.Add(Me.lblPipe)
        Me.pnlApplySettings.Controls.Add(Me.lblUnsaved)
        Me.pnlApplySettings.Controls.Add(Me.btnCancelChanges)
        Me.pnlApplySettings.Controls.Add(Me.btnApplyChanges)
        Me.pnlApplySettings.Location = New System.Drawing.Point(0, 361)
        Me.pnlApplySettings.Name = "pnlApplySettings"
        Me.pnlApplySettings.Size = New System.Drawing.Size(900, 100)
        Me.pnlApplySettings.TabIndex = 21
        Me.pnlApplySettings.Visible = False
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
        'btnCancelChanges
        '
        Me.btnCancelChanges.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelChanges.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnCancelChanges.Depth = 0
        Me.btnCancelChanges.Location = New System.Drawing.Point(487, 61)
        Me.btnCancelChanges.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelChanges.Name = "btnCancelChanges"
        Me.btnCancelChanges.Primary = True
        Me.btnCancelChanges.Size = New System.Drawing.Size(64, 18)
        Me.btnCancelChanges.TabIndex = 16
        Me.btnCancelChanges.Text = "Cancel"
        Me.btnCancelChanges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelChanges.UseVisualStyleBackColor = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.btnFeedback)
        Me.Controls.Add(Me.btnBugReport)
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
        Me.tabSettings.ResumeLayout(False)
        Me.tabSettings.PerformLayout()
        Me.pnlApplySettings.ResumeLayout(False)
        Me.pnlApplySettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
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
    Friend WithEvents btnApplyChanges As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnBugReport As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnFeedback As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents pnlApplySettings As Panel
    Friend WithEvents btnCancelChanges As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblUnsaved As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPipe As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblComingSoon As MaterialSkin.Controls.MaterialLabel
End Class
