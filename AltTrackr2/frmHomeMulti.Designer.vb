<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHomeMulti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomeMulti))
        Me.tabContent = New AltTrackr2.AetherTabControl()
        Me.tpgHome = New System.Windows.Forms.TabPage()
        Me.AetherCircular2 = New AltTrackr2.AetherCircular()
        Me.AetherCheckBox1 = New AltTrackr2.AetherCheckBox()
        Me.AetherButton1 = New AltTrackr2.AetherButton()
        Me.AetherRadioButton2 = New AltTrackr2.AetherRadioButton()
        Me.AetherRadioButton1 = New AltTrackr2.AetherRadioButton()
        Me.AetherTextbox1 = New AltTrackr2.AetherTextbox()
        Me.AetherTag1 = New AltTrackr2.AetherTag()
        Me.AetherGroupBox1 = New AltTrackr2.AetherGroupBox()
        Me.lblAltPrices = New MaterialSkin.Controls.MaterialLabel()
        Me.lblFriendlyPrice = New MaterialSkin.Controls.MaterialLabel()
        Me.lblAltHoldings = New MaterialSkin.Controls.MaterialLabel()
        Me.tpgHistory = New System.Windows.Forms.TabPage()
        Me.lblLastPriceUpdate = New MaterialSkin.Controls.MaterialLabel()
        Me.tpgSpacer1 = New System.Windows.Forms.TabPage()
        Me.tpgBitcoin = New System.Windows.Forms.TabPage()
        Me.tpgEthereum = New System.Windows.Forms.TabPage()
        Me.tpgMonero = New System.Windows.Forms.TabPage()
        Me.tpgSiacoin = New System.Windows.Forms.TabPage()
        Me.tpgSpacer2 = New System.Windows.Forms.TabPage()
        Me.tpgPrefs = New System.Windows.Forms.TabPage()
        Me.AetherButton3 = New AltTrackr2.AetherButton()
        Me.radStyle3 = New AltTrackr2.AetherRadioButton()
        Me.radStyle2 = New AltTrackr2.AetherRadioButton()
        Me.AetherButton2 = New AltTrackr2.AetherButton()
        Me.radStyle1 = New AltTrackr2.AetherRadioButton()
        Me.tpgSupport = New System.Windows.Forms.TabPage()
        Me.tpgFeedback = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bkgGetPrices = New System.ComponentModel.BackgroundWorker()
        Me.prgLoading = New MRG.Controls.UI.LoadingCircle()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.pnlLoading = New System.Windows.Forms.Panel()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.pnlLoadingMain = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prgTitleLoad = New MRG.Controls.UI.LoadingCircle()
        Me.tpgLogin = New System.Windows.Forms.TabPage()
        Me.txtLUsername = New AltTrackr2.AetherTextbox()
        Me.txtLPassword = New AltTrackr2.AetherTextbox()
        Me.btnLLogin = New AltTrackr2.AetherButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLLogout = New AltTrackr2.AetherButton()
        Me.btnLChangeDetails = New AltTrackr2.AetherButton()
        Me.btnLForgot = New AltTrackr2.AetherButton()
        Me.btnLSignup = New AltTrackr2.AetherButton()
        Me.tagIncorrect1 = New AltTrackr2.AetherTag()
        Me.tagIncorrect2 = New AltTrackr2.AetherTag()
        Me.pnlLIncorrect = New System.Windows.Forms.Panel()
        Me.pnlLLogin = New System.Windows.Forms.Panel()
        Me.tabContent.SuspendLayout()
        Me.tpgHome.SuspendLayout()
        Me.AetherGroupBox1.SuspendLayout()
        Me.tpgHistory.SuspendLayout()
        Me.tpgPrefs.SuspendLayout()
        Me.pnlLoading.SuspendLayout()
        Me.pnlLoadingMain.SuspendLayout()
        Me.tpgLogin.SuspendLayout()
        Me.pnlLIncorrect.SuspendLayout()
        Me.pnlLLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabContent
        '
        Me.tabContent.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tabContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabContent.Controls.Add(Me.tpgLogin)
        Me.tabContent.Controls.Add(Me.tpgHome)
        Me.tabContent.Controls.Add(Me.tpgHistory)
        Me.tabContent.Controls.Add(Me.tpgSpacer1)
        Me.tabContent.Controls.Add(Me.tpgBitcoin)
        Me.tabContent.Controls.Add(Me.tpgEthereum)
        Me.tabContent.Controls.Add(Me.tpgMonero)
        Me.tabContent.Controls.Add(Me.tpgSiacoin)
        Me.tabContent.Controls.Add(Me.tpgSpacer2)
        Me.tabContent.Controls.Add(Me.tpgPrefs)
        Me.tabContent.Controls.Add(Me.tpgSupport)
        Me.tabContent.Controls.Add(Me.tpgFeedback)
        Me.tabContent.ImageList = Me.ImageList1
        Me.tabContent.ItemSize = New System.Drawing.Size(40, 190)
        Me.tabContent.Location = New System.Drawing.Point(0, 64)
        Me.tabContent.Multiline = True
        Me.tabContent.Name = "tabContent"
        Me.tabContent.SelectedIndex = 0
        Me.tabContent.Size = New System.Drawing.Size(1060, 508)
        Me.tabContent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabContent.TabIndex = 0
        Me.tabContent.UpperText = True
        '
        'tpgHome
        '
        Me.tpgHome.BackColor = System.Drawing.Color.White
        Me.tpgHome.Controls.Add(Me.AetherCircular2)
        Me.tpgHome.Controls.Add(Me.AetherCheckBox1)
        Me.tpgHome.Controls.Add(Me.AetherButton1)
        Me.tpgHome.Controls.Add(Me.AetherRadioButton2)
        Me.tpgHome.Controls.Add(Me.AetherRadioButton1)
        Me.tpgHome.Controls.Add(Me.AetherTextbox1)
        Me.tpgHome.Controls.Add(Me.AetherTag1)
        Me.tpgHome.Controls.Add(Me.AetherGroupBox1)
        Me.tpgHome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgHome.ImageIndex = 0
        Me.tpgHome.Location = New System.Drawing.Point(194, 4)
        Me.tpgHome.Name = "tpgHome"
        Me.tpgHome.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgHome.Size = New System.Drawing.Size(862, 500)
        Me.tpgHome.TabIndex = 0
        Me.tpgHome.Text = "Home"
        '
        'AetherCircular2
        '
        Me.AetherCircular2.Border = System.Drawing.Color.LightGray
        Me.AetherCircular2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AetherCircular2.HatchBrush = False
        Me.AetherCircular2.HatchPrimary = System.Drawing.Color.DodgerBlue
        Me.AetherCircular2.HatchSecondary = System.Drawing.Color.Red
        Me.AetherCircular2.Location = New System.Drawing.Point(640, 290)
        Me.AetherCircular2.Max = 100.0!
        Me.AetherCircular2.Min = 0!
        Me.AetherCircular2.Name = "AetherCircular2"
        Me.AetherCircular2.Percent = False
        Me.AetherCircular2.PostText = "%"
        Me.AetherCircular2.Progress = 65.0!
        Me.AetherCircular2.ShowMax = False
        Me.AetherCircular2.Size = New System.Drawing.Size(128, 128)
        Me.AetherCircular2.TabIndex = 0
        Me.AetherCircular2.Text = "Monero (XMR)"
        '
        'AetherCheckBox1
        '
        Me.AetherCheckBox1.Checked = False
        Me.AetherCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AetherCheckBox1.EnabledCalc = True
        Me.AetherCheckBox1.HatchBrush = False
        Me.AetherCheckBox1.Location = New System.Drawing.Point(69, 341)
        Me.AetherCheckBox1.Name = "AetherCheckBox1"
        Me.AetherCheckBox1.Size = New System.Drawing.Size(125, 19)
        Me.AetherCheckBox1.TabIndex = 1
        Me.AetherCheckBox1.Text = "AetherCheckBox1"
        '
        'AetherButton1
        '
        Me.AetherButton1.EnabledCalc = True
        Me.AetherButton1.Location = New System.Drawing.Point(74, 303)
        Me.AetherButton1.Name = "AetherButton1"
        Me.AetherButton1.Size = New System.Drawing.Size(114, 23)
        Me.AetherButton1.TabIndex = 0
        Me.AetherButton1.Text = "AetherButton1"
        '
        'AetherRadioButton2
        '
        Me.AetherRadioButton2.Checked = False
        Me.AetherRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AetherRadioButton2.EnabledCalc = True
        Me.AetherRadioButton2.HatchBrush = False
        Me.AetherRadioButton2.Location = New System.Drawing.Point(344, 385)
        Me.AetherRadioButton2.Name = "AetherRadioButton2"
        Me.AetherRadioButton2.Size = New System.Drawing.Size(149, 19)
        Me.AetherRadioButton2.TabIndex = 1
        Me.AetherRadioButton2.Text = "AetherRadioButton2"
        '
        'AetherRadioButton1
        '
        Me.AetherRadioButton1.Checked = False
        Me.AetherRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AetherRadioButton1.EnabledCalc = True
        Me.AetherRadioButton1.HatchBrush = False
        Me.AetherRadioButton1.Location = New System.Drawing.Point(344, 360)
        Me.AetherRadioButton1.Name = "AetherRadioButton1"
        Me.AetherRadioButton1.Size = New System.Drawing.Size(149, 19)
        Me.AetherRadioButton1.TabIndex = 6
        Me.AetherRadioButton1.Text = "AetherRadioButton1"
        '
        'AetherTextbox1
        '
        Me.AetherTextbox1.EnabledCalc = True
        Me.AetherTextbox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AetherTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.AetherTextbox1.Location = New System.Drawing.Point(347, 303)
        Me.AetherTextbox1.MaxLength = 32767
        Me.AetherTextbox1.MultiLine = False
        Me.AetherTextbox1.Name = "AetherTextbox1"
        Me.AetherTextbox1.ReadOnly = False
        Me.AetherTextbox1.Size = New System.Drawing.Size(130, 29)
        Me.AetherTextbox1.TabIndex = 4
        Me.AetherTextbox1.Text = "AetherTextbox1"
        Me.AetherTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AetherTextbox1.UseSystemPasswordChar = False
        '
        'AetherTag1
        '
        Me.AetherTag1.Background = System.Drawing.Color.Red
        Me.AetherTag1.Border = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AetherTag1.Location = New System.Drawing.Point(371, 270)
        Me.AetherTag1.Name = "AetherTag1"
        Me.AetherTag1.Size = New System.Drawing.Size(83, 15)
        Me.AetherTag1.TabIndex = 4
        Me.AetherTag1.Text = "RECOMMENDED"
        Me.AetherTag1.TextColor = System.Drawing.Color.White
        '
        'AetherGroupBox1
        '
        Me.AetherGroupBox1.Controls.Add(Me.lblAltPrices)
        Me.AetherGroupBox1.Controls.Add(Me.lblFriendlyPrice)
        Me.AetherGroupBox1.Controls.Add(Me.lblAltHoldings)
        Me.AetherGroupBox1.Footer = False
        Me.AetherGroupBox1.FooterText = Nothing
        Me.AetherGroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.AetherGroupBox1.Name = "AetherGroupBox1"
        Me.AetherGroupBox1.Size = New System.Drawing.Size(810, 223)
        Me.AetherGroupBox1.TabIndex = 1
        Me.AetherGroupBox1.Text = "GroupBox1"
        '
        'lblAltPrices
        '
        Me.lblAltPrices.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAltPrices.BackColor = System.Drawing.Color.Transparent
        Me.lblAltPrices.Depth = 0
        Me.lblAltPrices.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAltPrices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAltPrices.Location = New System.Drawing.Point(3, 44)
        Me.lblAltPrices.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAltPrices.Name = "lblAltPrices"
        Me.lblAltPrices.Size = New System.Drawing.Size(804, 28)
        Me.lblAltPrices.TabIndex = 15
        Me.lblAltPrices.Text = "XMR Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblAltPrices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFriendlyPrice
        '
        Me.lblFriendlyPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFriendlyPrice.Depth = 0
        Me.lblFriendlyPrice.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFriendlyPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFriendlyPrice.Location = New System.Drawing.Point(3, 121)
        Me.lblFriendlyPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFriendlyPrice.Name = "lblFriendlyPrice"
        Me.lblFriendlyPrice.Size = New System.Drawing.Size(804, 90)
        Me.lblFriendlyPrice.TabIndex = 17
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
        Me.lblAltHoldings.Location = New System.Drawing.Point(3, 72)
        Me.lblAltHoldings.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAltHoldings.Name = "lblAltHoldings"
        Me.lblAltHoldings.Size = New System.Drawing.Size(804, 28)
        Me.lblAltHoldings.TabIndex = 16
        Me.lblAltHoldings.Text = "XMR Holdings - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblAltHoldings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpgHistory
        '
        Me.tpgHistory.BackColor = System.Drawing.Color.White
        Me.tpgHistory.Controls.Add(Me.lblLastPriceUpdate)
        Me.tpgHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgHistory.ImageIndex = 10
        Me.tpgHistory.Location = New System.Drawing.Point(194, 4)
        Me.tpgHistory.Name = "tpgHistory"
        Me.tpgHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgHistory.Size = New System.Drawing.Size(862, 500)
        Me.tpgHistory.TabIndex = 1
        Me.tpgHistory.Text = "History"
        '
        'lblLastPriceUpdate
        '
        Me.lblLastPriceUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLastPriceUpdate.Depth = 0
        Me.lblLastPriceUpdate.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblLastPriceUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLastPriceUpdate.Location = New System.Drawing.Point(260, 238)
        Me.lblLastPriceUpdate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLastPriceUpdate.Name = "lblLastPriceUpdate"
        Me.lblLastPriceUpdate.Size = New System.Drawing.Size(343, 25)
        Me.lblLastPriceUpdate.TabIndex = 15
        Me.lblLastPriceUpdate.Text = "Last Updated:"
        Me.lblLastPriceUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpgSpacer1
        '
        Me.tpgSpacer1.BackColor = System.Drawing.Color.White
        Me.tpgSpacer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgSpacer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgSpacer1.Location = New System.Drawing.Point(194, 4)
        Me.tpgSpacer1.Name = "tpgSpacer1"
        Me.tpgSpacer1.Size = New System.Drawing.Size(862, 500)
        Me.tpgSpacer1.TabIndex = 5
        '
        'tpgBitcoin
        '
        Me.tpgBitcoin.BackColor = System.Drawing.Color.White
        Me.tpgBitcoin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgBitcoin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgBitcoin.ImageIndex = 11
        Me.tpgBitcoin.Location = New System.Drawing.Point(194, 4)
        Me.tpgBitcoin.Name = "tpgBitcoin"
        Me.tpgBitcoin.Size = New System.Drawing.Size(862, 500)
        Me.tpgBitcoin.TabIndex = 2
        Me.tpgBitcoin.Tag = "$2587"
        Me.tpgBitcoin.Text = "Bitcoin"
        '
        'tpgEthereum
        '
        Me.tpgEthereum.BackColor = System.Drawing.Color.White
        Me.tpgEthereum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgEthereum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgEthereum.ImageIndex = 23
        Me.tpgEthereum.Location = New System.Drawing.Point(194, 4)
        Me.tpgEthereum.Name = "tpgEthereum"
        Me.tpgEthereum.Size = New System.Drawing.Size(862, 500)
        Me.tpgEthereum.TabIndex = 3
        Me.tpgEthereum.Tag = "$192"
        Me.tpgEthereum.Text = "Ethereum"
        '
        'tpgMonero
        '
        Me.tpgMonero.BackColor = System.Drawing.Color.White
        Me.tpgMonero.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgMonero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgMonero.ImageIndex = 22
        Me.tpgMonero.Location = New System.Drawing.Point(194, 4)
        Me.tpgMonero.Name = "tpgMonero"
        Me.tpgMonero.Size = New System.Drawing.Size(862, 500)
        Me.tpgMonero.TabIndex = 4
        Me.tpgMonero.Tag = "$47"
        Me.tpgMonero.Text = "Monero"
        '
        'tpgSiacoin
        '
        Me.tpgSiacoin.BackColor = System.Drawing.Color.White
        Me.tpgSiacoin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgSiacoin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgSiacoin.ImageIndex = 9
        Me.tpgSiacoin.Location = New System.Drawing.Point(194, 4)
        Me.tpgSiacoin.Name = "tpgSiacoin"
        Me.tpgSiacoin.Size = New System.Drawing.Size(862, 500)
        Me.tpgSiacoin.TabIndex = 10
        Me.tpgSiacoin.Text = "Siacoin"
        '
        'tpgSpacer2
        '
        Me.tpgSpacer2.BackColor = System.Drawing.Color.White
        Me.tpgSpacer2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgSpacer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgSpacer2.Location = New System.Drawing.Point(194, 4)
        Me.tpgSpacer2.Name = "tpgSpacer2"
        Me.tpgSpacer2.Size = New System.Drawing.Size(862, 500)
        Me.tpgSpacer2.TabIndex = 6
        '
        'tpgPrefs
        '
        Me.tpgPrefs.BackColor = System.Drawing.Color.White
        Me.tpgPrefs.Controls.Add(Me.AetherButton3)
        Me.tpgPrefs.Controls.Add(Me.radStyle3)
        Me.tpgPrefs.Controls.Add(Me.radStyle2)
        Me.tpgPrefs.Controls.Add(Me.AetherButton2)
        Me.tpgPrefs.Controls.Add(Me.radStyle1)
        Me.tpgPrefs.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgPrefs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgPrefs.ImageIndex = 14
        Me.tpgPrefs.Location = New System.Drawing.Point(194, 4)
        Me.tpgPrefs.Name = "tpgPrefs"
        Me.tpgPrefs.Size = New System.Drawing.Size(862, 500)
        Me.tpgPrefs.TabIndex = 7
        Me.tpgPrefs.Text = "User Preferences"
        '
        'AetherButton3
        '
        Me.AetherButton3.EnabledCalc = True
        Me.AetherButton3.Location = New System.Drawing.Point(392, 302)
        Me.AetherButton3.Name = "AetherButton3"
        Me.AetherButton3.Size = New System.Drawing.Size(126, 23)
        Me.AetherButton3.TabIndex = 4
        Me.AetherButton3.Text = "Check Prices"
        '
        'radStyle3
        '
        Me.radStyle3.Checked = False
        Me.radStyle3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radStyle3.EnabledCalc = True
        Me.radStyle3.HatchBrush = False
        Me.radStyle3.Location = New System.Drawing.Point(184, 356)
        Me.radStyle3.Name = "radStyle3"
        Me.radStyle3.Size = New System.Drawing.Size(154, 19)
        Me.radStyle3.TabIndex = 3
        Me.radStyle3.Text = "UI Style #2"
        '
        'radStyle2
        '
        Me.radStyle2.Checked = False
        Me.radStyle2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radStyle2.EnabledCalc = True
        Me.radStyle2.HatchBrush = False
        Me.radStyle2.Location = New System.Drawing.Point(184, 331)
        Me.radStyle2.Name = "radStyle2"
        Me.radStyle2.Size = New System.Drawing.Size(154, 19)
        Me.radStyle2.TabIndex = 2
        Me.radStyle2.Text = "UI Style #2"
        '
        'AetherButton2
        '
        Me.AetherButton2.EnabledCalc = True
        Me.AetherButton2.Location = New System.Drawing.Point(170, 194)
        Me.AetherButton2.Name = "AetherButton2"
        Me.AetherButton2.Size = New System.Drawing.Size(117, 23)
        Me.AetherButton2.TabIndex = 1
        Me.AetherButton2.Text = "AetherButton2"
        '
        'radStyle1
        '
        Me.radStyle1.Checked = False
        Me.radStyle1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radStyle1.EnabledCalc = True
        Me.radStyle1.HatchBrush = False
        Me.radStyle1.Location = New System.Drawing.Point(184, 306)
        Me.radStyle1.Name = "radStyle1"
        Me.radStyle1.Size = New System.Drawing.Size(154, 19)
        Me.radStyle1.TabIndex = 1
        Me.radStyle1.Text = "UI Style #1"
        '
        'tpgSupport
        '
        Me.tpgSupport.BackColor = System.Drawing.Color.White
        Me.tpgSupport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgSupport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgSupport.ImageIndex = 8
        Me.tpgSupport.Location = New System.Drawing.Point(194, 4)
        Me.tpgSupport.Name = "tpgSupport"
        Me.tpgSupport.Size = New System.Drawing.Size(862, 500)
        Me.tpgSupport.TabIndex = 8
        Me.tpgSupport.Text = "Help & Support"
        '
        'tpgFeedback
        '
        Me.tpgFeedback.BackColor = System.Drawing.Color.White
        Me.tpgFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgFeedback.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgFeedback.ImageIndex = 6
        Me.tpgFeedback.Location = New System.Drawing.Point(194, 4)
        Me.tpgFeedback.Name = "tpgFeedback"
        Me.tpgFeedback.Size = New System.Drawing.Size(862, 500)
        Me.tpgFeedback.TabIndex = 9
        Me.tpgFeedback.Tag = "Beta 1"
        Me.tpgFeedback.Text = "Feedback"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "home_icon.png")
        Me.ImageList1.Images.SetKeyName(1, "logoETH.png")
        Me.ImageList1.Images.SetKeyName(2, "logoBTC.png")
        Me.ImageList1.Images.SetKeyName(3, "logoDoge.png")
        Me.ImageList1.Images.SetKeyName(4, "logoLTC.png")
        Me.ImageList1.Images.SetKeyName(5, "logoXMR.png")
        Me.ImageList1.Images.SetKeyName(6, "001-report.png")
        Me.ImageList1.Images.SetKeyName(7, "002-male-telemarketer.png")
        Me.ImageList1.Images.SetKeyName(8, "003-lifesaver.png")
        Me.ImageList1.Images.SetKeyName(9, "004-money.png")
        Me.ImageList1.Images.SetKeyName(10, "005-statistics.png")
        Me.ImageList1.Images.SetKeyName(11, "007-bitcoin.png")
        Me.ImageList1.Images.SetKeyName(12, "008-coin.png")
        Me.ImageList1.Images.SetKeyName(13, "014-communications.png")
        Me.ImageList1.Images.SetKeyName(14, "017-monitor-1.png")
        Me.ImageList1.Images.SetKeyName(15, "018-dashboard.png")
        Me.ImageList1.Images.SetKeyName(16, "019-gear.png")
        Me.ImageList1.Images.SetKeyName(17, "020-clockwise.png")
        Me.ImageList1.Images.SetKeyName(18, "021-anti-clockwise.png")
        Me.ImageList1.Images.SetKeyName(19, "022-alarm-1.png")
        Me.ImageList1.Images.SetKeyName(20, "023-alarm.png")
        Me.ImageList1.Images.SetKeyName(21, "025-home.png")
        Me.ImageList1.Images.SetKeyName(22, "027-monero.png")
        Me.ImageList1.Images.SetKeyName(23, "028-ethereum.png")
        Me.ImageList1.Images.SetKeyName(24, "001-account.png")
        Me.ImageList1.Images.SetKeyName(25, "002-arrows.png")
        Me.ImageList1.Images.SetKeyName(26, "003-multimedia.png")
        Me.ImageList1.Images.SetKeyName(27, "006-businessman-1.png")
        Me.ImageList1.Images.SetKeyName(28, "026-businessman.png")
        '
        'bkgGetPrices
        '
        Me.bkgGetPrices.WorkerReportsProgress = True
        Me.bkgGetPrices.WorkerSupportsCancellation = True
        '
        'prgLoading
        '
        Me.prgLoading.Active = False
        Me.prgLoading.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.prgLoading.Color = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prgLoading.InnerCircleRadius = 8
        Me.prgLoading.Location = New System.Drawing.Point(33, 182)
        Me.prgLoading.Name = "prgLoading"
        Me.prgLoading.NumberSpoke = 24
        Me.prgLoading.OuterCircleRadius = 9
        Me.prgLoading.RotationSpeed = 100
        Me.prgLoading.Size = New System.Drawing.Size(129, 131)
        Me.prgLoading.SpokeThickness = 4
        Me.prgLoading.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7
        Me.prgLoading.TabIndex = 14
        Me.prgLoading.Text = "LoadingCircle1"
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Enabled = True
        Me.tmrRefresh.Interval = 10000
        '
        'pnlLoading
        '
        Me.pnlLoading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.pnlLoading.Controls.Add(Me.lblLoading)
        Me.pnlLoading.Controls.Add(Me.prgLoading)
        Me.pnlLoading.Location = New System.Drawing.Point(0, 64)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(194, 508)
        Me.pnlLoading.TabIndex = 18
        Me.pnlLoading.Visible = False
        '
        'lblLoading
        '
        Me.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLoading.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!)
        Me.lblLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblLoading.Location = New System.Drawing.Point(5, 293)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(185, 33)
        Me.lblLoading.TabIndex = 15
        Me.lblLoading.Text = "LOADING DATA"
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLoadingMain
        '
        Me.pnlLoadingMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlLoadingMain.Controls.Add(Me.Panel2)
        Me.pnlLoadingMain.Controls.Add(Me.Label2)
        Me.pnlLoadingMain.Controls.Add(Me.Label1)
        Me.pnlLoadingMain.Location = New System.Drawing.Point(0, 68)
        Me.pnlLoadingMain.Name = "pnlLoadingMain"
        Me.pnlLoadingMain.Size = New System.Drawing.Size(1070, 532)
        Me.pnlLoadingMain.TabIndex = 19
        Me.pnlLoadingMain.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(211, 272)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(613, 3)
        Me.Panel2.TabIndex = 2
        Me.Panel2.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(211, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "EARLY ACCESS - BUILD 190717b1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 55.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(193, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 99)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALTTRACKR"
        Me.Label1.Visible = False
        '
        'prgTitleLoad
        '
        Me.prgTitleLoad.Active = False
        Me.prgTitleLoad.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.prgTitleLoad.BackColor = System.Drawing.Color.Transparent
        Me.prgTitleLoad.Color = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prgTitleLoad.InnerCircleRadius = 8
        Me.prgTitleLoad.Location = New System.Drawing.Point(116, 29)
        Me.prgTitleLoad.Name = "prgTitleLoad"
        Me.prgTitleLoad.NumberSpoke = 24
        Me.prgTitleLoad.OuterCircleRadius = 9
        Me.prgTitleLoad.RotationSpeed = 100
        Me.prgTitleLoad.Size = New System.Drawing.Size(32, 33)
        Me.prgTitleLoad.SpokeThickness = 4
        Me.prgTitleLoad.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7
        Me.prgTitleLoad.TabIndex = 20
        Me.prgTitleLoad.Text = "LoadingCircle1"
        '
        'tpgLogin
        '
        Me.tpgLogin.BackColor = System.Drawing.Color.White
        Me.tpgLogin.Controls.Add(Me.pnlLLogin)
        Me.tpgLogin.Controls.Add(Me.btnLChangeDetails)
        Me.tpgLogin.Controls.Add(Me.btnLLogout)
        Me.tpgLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpgLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpgLogin.ImageIndex = 25
        Me.tpgLogin.Location = New System.Drawing.Point(194, 4)
        Me.tpgLogin.Name = "tpgLogin"
        Me.tpgLogin.Size = New System.Drawing.Size(862, 500)
        Me.tpgLogin.TabIndex = 11
        Me.tpgLogin.Text = "Login"
        '
        'txtLUsername
        '
        Me.txtLUsername.EnabledCalc = True
        Me.txtLUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtLUsername.Location = New System.Drawing.Point(25, 43)
        Me.txtLUsername.MaxLength = 32767
        Me.txtLUsername.MultiLine = False
        Me.txtLUsername.Name = "txtLUsername"
        Me.txtLUsername.ReadOnly = False
        Me.txtLUsername.Size = New System.Drawing.Size(178, 29)
        Me.txtLUsername.TabIndex = 0
        Me.txtLUsername.Text = "Username"
        Me.txtLUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLUsername.UseSystemPasswordChar = False
        '
        'txtLPassword
        '
        Me.txtLPassword.EnabledCalc = True
        Me.txtLPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtLPassword.Location = New System.Drawing.Point(25, 78)
        Me.txtLPassword.MaxLength = 32767
        Me.txtLPassword.MultiLine = False
        Me.txtLPassword.Name = "txtLPassword"
        Me.txtLPassword.ReadOnly = False
        Me.txtLPassword.Size = New System.Drawing.Size(178, 29)
        Me.txtLPassword.TabIndex = 1
        Me.txtLPassword.Text = "Password"
        Me.txtLPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLPassword.UseSystemPasswordChar = True
        '
        'btnLLogin
        '
        Me.btnLLogin.EnabledCalc = True
        Me.btnLLogin.Location = New System.Drawing.Point(25, 113)
        Me.btnLLogin.Name = "btnLLogin"
        Me.btnLLogin.Size = New System.Drawing.Size(88, 23)
        Me.btnLLogin.TabIndex = 2
        Me.btnLLogin.Text = "Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "LOGIN WITH MYMAEGA"
        '
        'btnLLogout
        '
        Me.btnLLogout.EnabledCalc = True
        Me.btnLLogout.Location = New System.Drawing.Point(342, 429)
        Me.btnLLogout.Name = "btnLLogout"
        Me.btnLLogout.Size = New System.Drawing.Size(178, 23)
        Me.btnLLogout.TabIndex = 4
        Me.btnLLogout.Text = "Logout"
        '
        'btnLChangeDetails
        '
        Me.btnLChangeDetails.EnabledCalc = True
        Me.btnLChangeDetails.Location = New System.Drawing.Point(342, 400)
        Me.btnLChangeDetails.Name = "btnLChangeDetails"
        Me.btnLChangeDetails.Size = New System.Drawing.Size(178, 23)
        Me.btnLChangeDetails.TabIndex = 5
        Me.btnLChangeDetails.Text = "Change Account Details"
        '
        'btnLForgot
        '
        Me.btnLForgot.EnabledCalc = True
        Me.btnLForgot.Location = New System.Drawing.Point(25, 142)
        Me.btnLForgot.Name = "btnLForgot"
        Me.btnLForgot.Size = New System.Drawing.Size(178, 23)
        Me.btnLForgot.TabIndex = 6
        Me.btnLForgot.Text = "Problems Signing In?"
        '
        'btnLSignup
        '
        Me.btnLSignup.EnabledCalc = True
        Me.btnLSignup.Location = New System.Drawing.Point(115, 113)
        Me.btnLSignup.Name = "btnLSignup"
        Me.btnLSignup.Size = New System.Drawing.Size(88, 23)
        Me.btnLSignup.TabIndex = 7
        Me.btnLSignup.Text = "Signup"
        '
        'tagIncorrect1
        '
        Me.tagIncorrect1.Background = System.Drawing.Color.Red
        Me.tagIncorrect1.Border = System.Drawing.Color.Black
        Me.tagIncorrect1.ForeColor = System.Drawing.Color.White
        Me.tagIncorrect1.Location = New System.Drawing.Point(-86, 8)
        Me.tagIncorrect1.Name = "tagIncorrect1"
        Me.tagIncorrect1.Size = New System.Drawing.Size(93, 15)
        Me.tagIncorrect1.TabIndex = 8
        Me.tagIncorrect1.Text = "Incorrect Login"
        Me.tagIncorrect1.TextColor = System.Drawing.Color.White
        '
        'tagIncorrect2
        '
        Me.tagIncorrect2.Background = System.Drawing.Color.Red
        Me.tagIncorrect2.Border = System.Drawing.Color.Black
        Me.tagIncorrect2.ForeColor = System.Drawing.Color.White
        Me.tagIncorrect2.Location = New System.Drawing.Point(-86, 44)
        Me.tagIncorrect2.Name = "tagIncorrect2"
        Me.tagIncorrect2.Size = New System.Drawing.Size(93, 15)
        Me.tagIncorrect2.TabIndex = 9
        Me.tagIncorrect2.Text = "Incorrect Login"
        Me.tagIncorrect2.TextColor = System.Drawing.Color.White
        '
        'pnlLIncorrect
        '
        Me.pnlLIncorrect.Controls.Add(Me.tagIncorrect1)
        Me.pnlLIncorrect.Controls.Add(Me.tagIncorrect2)
        Me.pnlLIncorrect.Location = New System.Drawing.Point(198, 42)
        Me.pnlLIncorrect.Name = "pnlLIncorrect"
        Me.pnlLIncorrect.Size = New System.Drawing.Size(111, 65)
        Me.pnlLIncorrect.TabIndex = 10
        Me.pnlLIncorrect.Visible = False
        '
        'pnlLLogin
        '
        Me.pnlLLogin.Controls.Add(Me.txtLUsername)
        Me.pnlLLogin.Controls.Add(Me.Label3)
        Me.pnlLLogin.Controls.Add(Me.txtLPassword)
        Me.pnlLLogin.Controls.Add(Me.pnlLIncorrect)
        Me.pnlLLogin.Controls.Add(Me.btnLLogin)
        Me.pnlLLogin.Controls.Add(Me.btnLSignup)
        Me.pnlLLogin.Controls.Add(Me.btnLForgot)
        Me.pnlLLogin.Location = New System.Drawing.Point(317, 159)
        Me.pnlLLogin.Name = "pnlLLogin"
        Me.pnlLLogin.Size = New System.Drawing.Size(313, 183)
        Me.pnlLLogin.TabIndex = 11
        '
        'frmHomeMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 572)
        Me.Controls.Add(Me.prgTitleLoad)
        Me.Controls.Add(Me.tabContent)
        Me.Controls.Add(Me.pnlLoadingMain)
        Me.Controls.Add(Me.pnlLoading)
        Me.Name = "frmHomeMulti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading Data"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabContent.ResumeLayout(False)
        Me.tpgHome.ResumeLayout(False)
        Me.AetherGroupBox1.ResumeLayout(False)
        Me.tpgHistory.ResumeLayout(False)
        Me.tpgPrefs.ResumeLayout(False)
        Me.pnlLoading.ResumeLayout(False)
        Me.pnlLoadingMain.ResumeLayout(False)
        Me.tpgLogin.ResumeLayout(False)
        Me.pnlLIncorrect.ResumeLayout(False)
        Me.pnlLLogin.ResumeLayout(False)
        Me.pnlLLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabContent As AetherTabControl
    Friend WithEvents tpgHome As TabPage
    Friend WithEvents AetherRadioButton2 As AetherRadioButton
    Friend WithEvents AetherRadioButton1 As AetherRadioButton
    Friend WithEvents AetherTextbox1 As AetherTextbox
    Friend WithEvents AetherTag1 As AetherTag
    Friend WithEvents AetherGroupBox1 As AetherGroupBox
    Friend WithEvents tpgHistory As TabPage
    Friend WithEvents AetherCheckBox1 As AetherCheckBox
    Friend WithEvents AetherButton1 As AetherButton
    Friend WithEvents tpgSpacer1 As TabPage
    Friend WithEvents tpgBitcoin As TabPage
    Friend WithEvents tpgEthereum As TabPage
    Friend WithEvents tpgMonero As TabPage
    Friend WithEvents tpgSpacer2 As TabPage
    Friend WithEvents tpgPrefs As TabPage
    Friend WithEvents tpgSupport As TabPage
    Friend WithEvents tpgFeedback As TabPage
    Friend WithEvents AetherCircular2 As AetherCircular
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents tpgSiacoin As TabPage
    Friend WithEvents AetherButton2 As AetherButton
    Friend WithEvents radStyle3 As AetherRadioButton
    Friend WithEvents radStyle2 As AetherRadioButton
    Friend WithEvents radStyle1 As AetherRadioButton
    Friend WithEvents bkgGetPrices As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblAltPrices As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblFriendlyPrice As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAltHoldings As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents prgLoading As MRG.Controls.UI.LoadingCircle
    Friend WithEvents lblLastPriceUpdate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tmrRefresh As Timer
    Friend WithEvents pnlLoading As Panel
    Friend WithEvents lblLoading As Label
    Friend WithEvents AetherButton3 As AetherButton
    Friend WithEvents pnlLoadingMain As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents prgTitleLoad As MRG.Controls.UI.LoadingCircle
    Friend WithEvents tpgLogin As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLLogin As AetherButton
    Friend WithEvents txtLPassword As AetherTextbox
    Friend WithEvents txtLUsername As AetherTextbox
    Friend WithEvents btnLChangeDetails As AetherButton
    Friend WithEvents btnLLogout As AetherButton
    Friend WithEvents btnLSignup As AetherButton
    Friend WithEvents btnLForgot As AetherButton
    Friend WithEvents pnlLIncorrect As Panel
    Friend WithEvents tagIncorrect1 As AetherTag
    Friend WithEvents tagIncorrect2 As AetherTag
    Friend WithEvents pnlLLogin As Panel
End Class
