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
        Me.lblPrice = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblHoldingsFiat = New MaterialSkin.Controls.MaterialLabel()
        Me.lblHoldingsCoin = New MaterialSkin.Controls.MaterialLabel()
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
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.tbsContent = New MaterialSkin.Controls.MaterialTabSelector()
        Me.cxtTray.SuspendLayout()
        Me.tabContent.SuspendLayout()
        Me.tabDailyBrief.SuspendLayout()
        Me.tabDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Depth = 0
        Me.lblPrice.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(473, 202)
        Me.lblPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(411, 45)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "$00.00"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(575, 159)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(223, 29)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Price"
        Me.MaterialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.BackColor = System.Drawing.SystemColors.Control
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(111, 44)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(120, 23)
        Me.MaterialRaisedButton1.TabIndex = 5
        Me.MaterialRaisedButton1.Text = "Add Holdings"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = False
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(250, 44)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(120, 23)
        Me.MaterialRaisedButton2.TabIndex = 6
        Me.MaterialRaisedButton2.Text = "Edit Holdings"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = False
        '
        'lblHoldingsFiat
        '
        Me.lblHoldingsFiat.BackColor = System.Drawing.Color.Transparent
        Me.lblHoldingsFiat.Depth = 0
        Me.lblHoldingsFiat.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblHoldingsFiat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHoldingsFiat.Location = New System.Drawing.Point(3, 222)
        Me.lblHoldingsFiat.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblHoldingsFiat.Name = "lblHoldingsFiat"
        Me.lblHoldingsFiat.Size = New System.Drawing.Size(435, 45)
        Me.lblHoldingsFiat.TabIndex = 7
        Me.lblHoldingsFiat.Text = "$00.00/$00.00"
        Me.lblHoldingsFiat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHoldingsCoin
        '
        Me.lblHoldingsCoin.BackColor = System.Drawing.Color.Transparent
        Me.lblHoldingsCoin.Depth = 0
        Me.lblHoldingsCoin.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblHoldingsCoin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHoldingsCoin.Location = New System.Drawing.Point(6, 165)
        Me.lblHoldingsCoin.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblHoldingsCoin.Name = "lblHoldingsCoin"
        Me.lblHoldingsCoin.Size = New System.Drawing.Size(435, 45)
        Me.lblHoldingsCoin.TabIndex = 9
        Me.lblHoldingsCoin.Text = "0XMR"
        Me.lblHoldingsCoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(554, 41)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(132, 23)
        Me.MaterialRaisedButton3.TabIndex = 10
        Me.MaterialRaisedButton3.Text = "Get Prices"
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
        Me.tabContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
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
        Me.tabDetails.Controls.Add(Me.MaterialRaisedButton7)
        Me.tabDetails.Controls.Add(Me.lblHoldingsCoin)
        Me.tabDetails.Controls.Add(Me.lblHoldingsFiat)
        Me.tabDetails.Controls.Add(Me.MaterialRaisedButton4)
        Me.tabDetails.Controls.Add(Me.MaterialRaisedButton6)
        Me.tabDetails.Controls.Add(Me.MaterialRaisedButton1)
        Me.tabDetails.Controls.Add(Me.MaterialRaisedButton3)
        Me.tabDetails.Controls.Add(Me.MaterialRaisedButton2)
        Me.tabDetails.Controls.Add(Me.MaterialRaisedButton5)
        Me.tabDetails.Controls.Add(Me.MaterialLabel1)
        Me.tabDetails.Controls.Add(Me.lblPrice)
        Me.tabDetails.Location = New System.Drawing.Point(4, 22)
        Me.tabDetails.Name = "tabDetails"
        Me.tabDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetails.Size = New System.Drawing.Size(893, 348)
        Me.tabDetails.TabIndex = 1
        Me.tabDetails.Text = "Details"
        Me.tabDetails.UseVisualStyleBackColor = True
        '
        'tabSettings
        '
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Size = New System.Drawing.Size(885, 369)
        Me.tabSettings.TabIndex = 2
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
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
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.tbsContent)
        Me.Controls.Add(Me.tabContent)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.prgLoading)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maega AltTrackr"
        Me.cxtTray.ResumeLayout(False)
        Me.tabContent.ResumeLayout(False)
        Me.tabDailyBrief.ResumeLayout(False)
        Me.tabDetails.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPrice As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblHoldingsFiat As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblHoldingsCoin As MaterialSkin.Controls.MaterialLabel
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
End Class
