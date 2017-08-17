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
        Me.ilsIcon = New System.Windows.Forms.ImageList(Me.components)
        Me.bkgGetPrices = New System.ComponentModel.BackgroundWorker()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.pnlUnsaved = New System.Windows.Forms.Panel()
        Me.pnlPipe = New System.Windows.Forms.Panel()
        Me.AetherTag2 = New AltTrackr2.AetherTag()
        Me.btnConfirmCancel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnConfirmSave = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblUnsaved = New System.Windows.Forms.Label()
        Me.pnlLoadingMain = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prgTitleLoad = New MRG.Controls.UI.LoadingCircle()
        Me.ilsImg = New System.Windows.Forms.ImageList(Me.components)
        Me.bkgGetOnlineMeta = New System.ComponentModel.BackgroundWorker()
        Me.tabContent = New AltTrackr2.AetherTabControl()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.pnlLAccount = New System.Windows.Forms.Panel()
        Me.AetherGroupBox16 = New AltTrackr2.AetherGroupBox()
        Me.btnLLogout = New AltTrackr2.AetherButton()
        Me.btnLChangeDetails = New AltTrackr2.AetherButton()
        Me.AetherGroupBox15 = New AltTrackr2.AetherGroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkLAutoUpdate = New AltTrackr2.AetherCheckBox()
        Me.btnLCheckUpdates = New AltTrackr2.AetherButton()
        Me.chkLUpdateNotifier = New AltTrackr2.AetherCheckBox()
        Me.btnLUpdateNow = New AltTrackr2.AetherButton()
        Me.tagCurrentVer = New AltTrackr2.AetherTag()
        Me.tagLatestVer = New AltTrackr2.AetherTag()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.prgUpdate = New AltTrackr2.Ambiance.Ambiance_ProgressBar()
        Me.lblLUpdateStatus = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLUser = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAuthRequest = New System.Windows.Forms.Label()
        Me.pnlLLogin = New System.Windows.Forms.Panel()
        Me.txtLUsername = New AltTrackr2.AetherTextbox()
        Me.txtLPassword = New AltTrackr2.AetherTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlLIncorrect = New System.Windows.Forms.Panel()
        Me.tagIncorrect2 = New AltTrackr2.AetherTag()
        Me.tagIncorrect1 = New AltTrackr2.AetherTag()
        Me.btnLLogin = New AltTrackr2.AetherButton()
        Me.btnLSignup = New AltTrackr2.AetherButton()
        Me.btnLForgot = New AltTrackr2.AetherButton()
        Me.tpHome = New System.Windows.Forms.TabPage()
        Me.grpC2Change = New AltTrackr2.AetherGroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblC2DChange = New System.Windows.Forms.Label()
        Me.grpC3Change = New AltTrackr2.AetherGroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblC3DChange = New System.Windows.Forms.Label()
        Me.grpC4Change = New AltTrackr2.AetherGroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblC4DChange = New System.Windows.Forms.Label()
        Me.grpC1Change = New AltTrackr2.AetherGroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblC1DChange = New System.Windows.Forms.Label()
        Me.AetherGroupBox7 = New AltTrackr2.AetherGroupBox()
        Me.btnEditHoldings = New AltTrackr2.AetherButton()
        Me.lblAltHoldings = New System.Windows.Forms.Label()
        Me.AetherGroupBox6 = New AltTrackr2.AetherGroupBox()
        Me.lblGoalC4 = New System.Windows.Forms.Label()
        Me.lblGoalC3 = New System.Windows.Forms.Label()
        Me.lblGoalC2 = New System.Windows.Forms.Label()
        Me.lblGoalC1 = New System.Windows.Forms.Label()
        Me.btnEditGoals = New AltTrackr2.AetherButton()
        Me.prgC4 = New AltTrackr2.AetherCircular()
        Me.prgC3 = New AltTrackr2.AetherCircular()
        Me.prgC2 = New AltTrackr2.AetherCircular()
        Me.prgC1 = New AltTrackr2.AetherCircular()
        Me.AetherGroupBox1 = New AltTrackr2.AetherGroupBox()
        Me.btnEditPrices = New AltTrackr2.AetherButton()
        Me.lblAltPrices = New System.Windows.Forms.Label()
        Me.tpHistory = New System.Windows.Forms.TabPage()
        Me.lblLastPriceUpdate = New MaterialSkin.Controls.MaterialLabel()
        Me.tpSpacer1 = New System.Windows.Forms.TabPage()
        Me.tpCoin1 = New System.Windows.Forms.TabPage()
        Me.lblC1Name = New System.Windows.Forms.Label()
        Me.lblC1Price = New System.Windows.Forms.Label()
        Me.picC1Logo = New System.Windows.Forms.PictureBox()
        Me.AetherGroupBox3 = New AltTrackr2.AetherGroupBox()
        Me.lblC1PricesDetailed = New MaterialSkin.Controls.MaterialLabel()
        Me.lblC1Friendly = New MaterialSkin.Controls.MaterialLabel()
        Me.lblC1HoldingsDetailed = New MaterialSkin.Controls.MaterialLabel()
        Me.tpCoin2 = New System.Windows.Forms.TabPage()
        Me.lblC2Name = New System.Windows.Forms.Label()
        Me.lblC2Price = New System.Windows.Forms.Label()
        Me.picC2Logo = New System.Windows.Forms.PictureBox()
        Me.AetherGroupBox4 = New AltTrackr2.AetherGroupBox()
        Me.lblC2PricesDetailed = New MaterialSkin.Controls.MaterialLabel()
        Me.lblC2Friendly = New MaterialSkin.Controls.MaterialLabel()
        Me.lblC2HoldingsDetailed = New MaterialSkin.Controls.MaterialLabel()
        Me.tpCoin3 = New System.Windows.Forms.TabPage()
        Me.lblC3Price = New System.Windows.Forms.Label()
        Me.lblC3Name = New System.Windows.Forms.Label()
        Me.picC3Logo = New System.Windows.Forms.PictureBox()
        Me.AetherGroupBox5 = New AltTrackr2.AetherGroupBox()
        Me.lblC3PricesDetailed = New MaterialSkin.Controls.MaterialLabel()
        Me.lblC3Friendly = New MaterialSkin.Controls.MaterialLabel()
        Me.lblC3HoldingsDetailed = New MaterialSkin.Controls.MaterialLabel()
        Me.tpCoin4 = New System.Windows.Forms.TabPage()
        Me.lblC4Price = New System.Windows.Forms.Label()
        Me.lblC4Name = New System.Windows.Forms.Label()
        Me.picC4Logo = New System.Windows.Forms.PictureBox()
        Me.AetherGroupBox14 = New AltTrackr2.AetherGroupBox()
        Me.lblC4PricesDetailed = New MaterialSkin.Controls.MaterialLabel()
        Me.lblC4Friendly = New MaterialSkin.Controls.MaterialLabel()
        Me.lblC4HoldingsDetailed = New MaterialSkin.Controls.MaterialLabel()
        Me.tpSpacer2 = New System.Windows.Forms.TabPage()
        Me.tpPrefs = New System.Windows.Forms.TabPage()
        Me.Ambiance_Button_21 = New AltTrackr2.Ambiance.Ambiance_Button_2()
        Me.AetherButton3 = New AltTrackr2.AetherButton()
        Me.radC4Edit = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radC3Edit = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radC2Edit = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radC1Edit = New MaterialSkin.Controls.MaterialRadioButton()
        Me.grpC1Pref = New AltTrackr2.AetherGroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Ambiance_NumericUpDown3 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.Ambiance_NumericUpDown2 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.Ambiance_NumericUpDown1 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.txtC1Initial = New AltTrackr2.AetherTextbox()
        Me.txtC1Holdings = New AltTrackr2.AetherTextbox()
        Me.txtC1Goal = New AltTrackr2.AetherTextbox()
        Me.lblC1Goal = New System.Windows.Forms.Label()
        Me.lblC1Initial = New System.Windows.Forms.Label()
        Me.lblPrefC1Holdings = New System.Windows.Forms.Label()
        Me.AetherGroupBox13 = New AltTrackr2.AetherGroupBox()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radNotifC3 = New AltTrackr2.AetherRadioButton()
        Me.radNotifC2 = New AltTrackr2.AetherRadioButton()
        Me.radNotifC4 = New AltTrackr2.AetherRadioButton()
        Me.radNotifC1 = New AltTrackr2.AetherRadioButton()
        Me.radNotifFM = New AltTrackr2.AetherRadioButton()
        Me.radNotifFW = New AltTrackr2.AetherRadioButton()
        Me.radNotifFD = New AltTrackr2.AetherRadioButton()
        Me.txtNotifTime = New AltTrackr2.AetherTextbox()
        Me.txtNotifName = New AltTrackr2.AetherTextbox()
        Me.btnNotifAdd = New AltTrackr2.AetherButton()
        Me.AetherGroupBox12 = New AltTrackr2.AetherGroupBox()
        Me.LvModule = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AetherGroupBox2 = New AltTrackr2.AetherGroupBox()
        Me.AetherButton2 = New AltTrackr2.AetherButton()
        Me.radStyle1 = New AltTrackr2.AetherRadioButton()
        Me.radStyle3 = New AltTrackr2.AetherRadioButton()
        Me.radStyle2 = New AltTrackr2.AetherRadioButton()
        Me.grpC4Pref = New AltTrackr2.AetherGroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Ambiance_NumericUpDown10 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Ambiance_NumericUpDown11 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.Ambiance_NumericUpDown12 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.txtC4Goal = New AltTrackr2.AetherTextbox()
        Me.txtC4Initial = New AltTrackr2.AetherTextbox()
        Me.lblC4Goal = New System.Windows.Forms.Label()
        Me.txtC4Holdings = New AltTrackr2.AetherTextbox()
        Me.lblPrefC4Holdings = New System.Windows.Forms.Label()
        Me.lblC4Initial = New System.Windows.Forms.Label()
        Me.grpC3Pref = New AltTrackr2.AetherGroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Ambiance_NumericUpDown7 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Ambiance_NumericUpDown8 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.Ambiance_NumericUpDown9 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.txtC3Goal = New AltTrackr2.AetherTextbox()
        Me.txtC3Holdings = New AltTrackr2.AetherTextbox()
        Me.txtC3Initial = New AltTrackr2.AetherTextbox()
        Me.lblC3Initial = New System.Windows.Forms.Label()
        Me.lblC3Goal = New System.Windows.Forms.Label()
        Me.lblPrefC3Holdings = New System.Windows.Forms.Label()
        Me.grpC2Pref = New AltTrackr2.AetherGroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Ambiance_NumericUpDown4 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.Ambiance_NumericUpDown5 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.Ambiance_NumericUpDown6 = New AltTrackr2.Ambiance.Ambiance_NumericUpDown()
        Me.txtC2Initial = New AltTrackr2.AetherTextbox()
        Me.txtC2Goal = New AltTrackr2.AetherTextbox()
        Me.txtC2Holdings = New AltTrackr2.AetherTextbox()
        Me.lblC2Goal = New System.Windows.Forms.Label()
        Me.lblC2Initial = New System.Windows.Forms.Label()
        Me.lblPrefC2Holdings = New System.Windows.Forms.Label()
        Me.tpSupport = New System.Windows.Forms.TabPage()
        Me.tpFeedback = New System.Windows.Forms.TabPage()
        Me.pnlUnsaved.SuspendLayout()
        Me.pnlLoadingMain.SuspendLayout()
        Me.tabContent.SuspendLayout()
        Me.tpLogin.SuspendLayout()
        Me.pnlLAccount.SuspendLayout()
        Me.AetherGroupBox16.SuspendLayout()
        Me.AetherGroupBox15.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLLogin.SuspendLayout()
        Me.pnlLIncorrect.SuspendLayout()
        Me.tpHome.SuspendLayout()
        Me.grpC2Change.SuspendLayout()
        Me.grpC3Change.SuspendLayout()
        Me.grpC4Change.SuspendLayout()
        Me.grpC1Change.SuspendLayout()
        Me.AetherGroupBox7.SuspendLayout()
        Me.AetherGroupBox6.SuspendLayout()
        Me.AetherGroupBox1.SuspendLayout()
        Me.tpHistory.SuspendLayout()
        Me.tpCoin1.SuspendLayout()
        CType(Me.picC1Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AetherGroupBox3.SuspendLayout()
        Me.tpCoin2.SuspendLayout()
        CType(Me.picC2Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AetherGroupBox4.SuspendLayout()
        Me.tpCoin3.SuspendLayout()
        CType(Me.picC3Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AetherGroupBox5.SuspendLayout()
        Me.tpCoin4.SuspendLayout()
        CType(Me.picC4Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AetherGroupBox14.SuspendLayout()
        Me.tpPrefs.SuspendLayout()
        Me.grpC1Pref.SuspendLayout()
        Me.AetherGroupBox13.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.AetherGroupBox12.SuspendLayout()
        Me.AetherGroupBox2.SuspendLayout()
        Me.grpC4Pref.SuspendLayout()
        Me.grpC3Pref.SuspendLayout()
        Me.grpC2Pref.SuspendLayout()
        Me.SuspendLayout()
        '
        'ilsIcon
        '
        Me.ilsIcon.ImageStream = CType(resources.GetObject("ilsIcon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsIcon.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsIcon.Images.SetKeyName(0, "home_icon.png")
        Me.ilsIcon.Images.SetKeyName(1, "logoETH.png")
        Me.ilsIcon.Images.SetKeyName(2, "logoBTC.png")
        Me.ilsIcon.Images.SetKeyName(3, "logoDoge.png")
        Me.ilsIcon.Images.SetKeyName(4, "logoLTC.png")
        Me.ilsIcon.Images.SetKeyName(5, "logoXMR.png")
        Me.ilsIcon.Images.SetKeyName(6, "001-report.png")
        Me.ilsIcon.Images.SetKeyName(7, "002-male-telemarketer.png")
        Me.ilsIcon.Images.SetKeyName(8, "003-lifesaver.png")
        Me.ilsIcon.Images.SetKeyName(9, "004-money.png")
        Me.ilsIcon.Images.SetKeyName(10, "005-statistics.png")
        Me.ilsIcon.Images.SetKeyName(11, "007-bitcoin.png")
        Me.ilsIcon.Images.SetKeyName(12, "008-coin.png")
        Me.ilsIcon.Images.SetKeyName(13, "014-communications.png")
        Me.ilsIcon.Images.SetKeyName(14, "017-monitor-1.png")
        Me.ilsIcon.Images.SetKeyName(15, "018-dashboard.png")
        Me.ilsIcon.Images.SetKeyName(16, "019-gear.png")
        Me.ilsIcon.Images.SetKeyName(17, "020-clockwise.png")
        Me.ilsIcon.Images.SetKeyName(18, "021-anti-clockwise.png")
        Me.ilsIcon.Images.SetKeyName(19, "022-alarm-1.png")
        Me.ilsIcon.Images.SetKeyName(20, "023-alarm.png")
        Me.ilsIcon.Images.SetKeyName(21, "025-home.png")
        Me.ilsIcon.Images.SetKeyName(22, "027-monero.png")
        Me.ilsIcon.Images.SetKeyName(23, "028-ethereum.png")
        Me.ilsIcon.Images.SetKeyName(24, "")
        Me.ilsIcon.Images.SetKeyName(25, "")
        Me.ilsIcon.Images.SetKeyName(26, "")
        Me.ilsIcon.Images.SetKeyName(27, "")
        Me.ilsIcon.Images.SetKeyName(28, "")
        '
        'bkgGetPrices
        '
        Me.bkgGetPrices.WorkerReportsProgress = True
        Me.bkgGetPrices.WorkerSupportsCancellation = True
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Enabled = True
        Me.tmrRefresh.Interval = 10000
        '
        'pnlUnsaved
        '
        Me.pnlUnsaved.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlUnsaved.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.pnlUnsaved.Controls.Add(Me.pnlPipe)
        Me.pnlUnsaved.Controls.Add(Me.AetherTag2)
        Me.pnlUnsaved.Controls.Add(Me.btnConfirmCancel)
        Me.pnlUnsaved.Controls.Add(Me.btnConfirmSave)
        Me.pnlUnsaved.Controls.Add(Me.lblUnsaved)
        Me.pnlUnsaved.Location = New System.Drawing.Point(-189, 64)
        Me.pnlUnsaved.Name = "pnlUnsaved"
        Me.pnlUnsaved.Size = New System.Drawing.Size(194, 490)
        Me.pnlUnsaved.TabIndex = 18
        Me.pnlUnsaved.Visible = False
        '
        'pnlPipe
        '
        Me.pnlPipe.BackColor = System.Drawing.Color.White
        Me.pnlPipe.Location = New System.Drawing.Point(94, 251)
        Me.pnlPipe.Name = "pnlPipe"
        Me.pnlPipe.Size = New System.Drawing.Size(1, 15)
        Me.pnlPipe.TabIndex = 20
        '
        'AetherTag2
        '
        Me.AetherTag2.Background = System.Drawing.Color.Red
        Me.AetherTag2.Border = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AetherTag2.Location = New System.Drawing.Point(23, 189)
        Me.AetherTag2.Name = "AetherTag2"
        Me.AetherTag2.Size = New System.Drawing.Size(148, 15)
        Me.AetherTag2.TabIndex = 19
        Me.AetherTag2.Text = "You have unsaved changes"
        Me.AetherTag2.TextColor = System.Drawing.Color.White
        '
        'btnConfirmCancel
        '
        Me.btnConfirmCancel.AutoSize = True
        Me.btnConfirmCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnConfirmCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnConfirmCancel.Depth = 0
        Me.btnConfirmCancel.Icon = Nothing
        Me.btnConfirmCancel.Location = New System.Drawing.Point(99, 247)
        Me.btnConfirmCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConfirmCancel.Name = "btnConfirmCancel"
        Me.btnConfirmCancel.Primary = True
        Me.btnConfirmCancel.Size = New System.Drawing.Size(99, 36)
        Me.btnConfirmCancel.TabIndex = 18
        Me.btnConfirmCancel.Text = "No, Cancel"
        Me.btnConfirmCancel.UseVisualStyleBackColor = False
        '
        'btnConfirmSave
        '
        Me.btnConfirmSave.AutoSize = True
        Me.btnConfirmSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnConfirmSave.Depth = 0
        Me.btnConfirmSave.Icon = Nothing
        Me.btnConfirmSave.Location = New System.Drawing.Point(9, 247)
        Me.btnConfirmSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConfirmSave.Name = "btnConfirmSave"
        Me.btnConfirmSave.Primary = True
        Me.btnConfirmSave.Size = New System.Drawing.Size(86, 36)
        Me.btnConfirmSave.TabIndex = 17
        Me.btnConfirmSave.Text = "YES, SAVE"
        Me.btnConfirmSave.UseVisualStyleBackColor = True
        '
        'lblUnsaved
        '
        Me.lblUnsaved.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblUnsaved.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.lblUnsaved.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblUnsaved.Location = New System.Drawing.Point(5, 201)
        Me.lblUnsaved.Name = "lblUnsaved"
        Me.lblUnsaved.Size = New System.Drawing.Size(185, 43)
        Me.lblUnsaved.TabIndex = 15
        Me.lblUnsaved.Text = "SAVE CHANGES?"
        Me.lblUnsaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLoadingMain
        '
        Me.pnlLoadingMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlLoadingMain.Controls.Add(Me.Panel2)
        Me.pnlLoadingMain.Controls.Add(Me.Label2)
        Me.pnlLoadingMain.Controls.Add(Me.Label1)
        Me.pnlLoadingMain.Location = New System.Drawing.Point(0, 68)
        Me.pnlLoadingMain.Name = "pnlLoadingMain"
        Me.pnlLoadingMain.Size = New System.Drawing.Size(1022, 486)
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
        Me.prgTitleLoad.Location = New System.Drawing.Point(119, 28)
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
        'ilsImg
        '
        Me.ilsImg.ImageStream = CType(resources.GetObject("ilsImg.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsImg.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsImg.Images.SetKeyName(0, "Box-Incoming.png")
        Me.ilsImg.Images.SetKeyName(1, "Minus.png")
        Me.ilsImg.Images.SetKeyName(2, "OK.png")
        Me.ilsImg.Images.SetKeyName(3, "On.png")
        Me.ilsImg.Images.SetKeyName(4, "Plus.png")
        Me.ilsImg.Images.SetKeyName(5, "Remove.png")
        '
        'bkgGetOnlineMeta
        '
        Me.bkgGetOnlineMeta.WorkerReportsProgress = True
        Me.bkgGetOnlineMeta.WorkerSupportsCancellation = True
        '
        'tabContent
        '
        Me.tabContent.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tabContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabContent.Controls.Add(Me.tpLogin)
        Me.tabContent.Controls.Add(Me.tpHome)
        Me.tabContent.Controls.Add(Me.tpHistory)
        Me.tabContent.Controls.Add(Me.tpSpacer1)
        Me.tabContent.Controls.Add(Me.tpCoin1)
        Me.tabContent.Controls.Add(Me.tpCoin2)
        Me.tabContent.Controls.Add(Me.tpCoin3)
        Me.tabContent.Controls.Add(Me.tpCoin4)
        Me.tabContent.Controls.Add(Me.tpSpacer2)
        Me.tabContent.Controls.Add(Me.tpPrefs)
        Me.tabContent.Controls.Add(Me.tpSupport)
        Me.tabContent.Controls.Add(Me.tpFeedback)
        Me.tabContent.ImageList = Me.ilsIcon
        Me.tabContent.ItemSize = New System.Drawing.Size(40, 190)
        Me.tabContent.Location = New System.Drawing.Point(0, 64)
        Me.tabContent.Multiline = True
        Me.tabContent.Name = "tabContent"
        Me.tabContent.SelectedIndex = 0
        Me.tabContent.Size = New System.Drawing.Size(1022, 490)
        Me.tabContent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabContent.TabIndex = 0
        Me.tabContent.Tag = "$0.017"
        Me.tabContent.UpperText = True
        '
        'tpLogin
        '
        Me.tpLogin.BackColor = System.Drawing.Color.White
        Me.tpLogin.Controls.Add(Me.pnlLAccount)
        Me.tpLogin.Controls.Add(Me.pnlLLogin)
        Me.tpLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpLogin.ImageIndex = 25
        Me.tpLogin.Location = New System.Drawing.Point(194, 4)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Size = New System.Drawing.Size(824, 482)
        Me.tpLogin.TabIndex = 11
        Me.tpLogin.Text = "Login"
        '
        'pnlLAccount
        '
        Me.pnlLAccount.Controls.Add(Me.AetherGroupBox16)
        Me.pnlLAccount.Controls.Add(Me.AetherGroupBox15)
        Me.pnlLAccount.Controls.Add(Me.Label7)
        Me.pnlLAccount.Controls.Add(Me.lblLUser)
        Me.pnlLAccount.Controls.Add(Me.PictureBox1)
        Me.pnlLAccount.Controls.Add(Me.lblAuthRequest)
        Me.pnlLAccount.Location = New System.Drawing.Point(6, 3)
        Me.pnlLAccount.Name = "pnlLAccount"
        Me.pnlLAccount.Size = New System.Drawing.Size(813, 471)
        Me.pnlLAccount.TabIndex = 12
        Me.pnlLAccount.Visible = False
        '
        'AetherGroupBox16
        '
        Me.AetherGroupBox16.Controls.Add(Me.btnLLogout)
        Me.AetherGroupBox16.Controls.Add(Me.btnLChangeDetails)
        Me.AetherGroupBox16.Footer = False
        Me.AetherGroupBox16.FooterText = Nothing
        Me.AetherGroupBox16.Location = New System.Drawing.Point(3, 318)
        Me.AetherGroupBox16.Name = "AetherGroupBox16"
        Me.AetherGroupBox16.Size = New System.Drawing.Size(348, 150)
        Me.AetherGroupBox16.TabIndex = 24
        Me.AetherGroupBox16.Text = "Account Preferences"
        '
        'btnLLogout
        '
        Me.btnLLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLLogout.EnabledCalc = True
        Me.btnLLogout.Location = New System.Drawing.Point(66, 95)
        Me.btnLLogout.Name = "btnLLogout"
        Me.btnLLogout.Size = New System.Drawing.Size(217, 23)
        Me.btnLLogout.TabIndex = 9
        Me.btnLLogout.Text = "Logout"
        '
        'btnLChangeDetails
        '
        Me.btnLChangeDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLChangeDetails.EnabledCalc = True
        Me.btnLChangeDetails.Location = New System.Drawing.Point(66, 65)
        Me.btnLChangeDetails.Name = "btnLChangeDetails"
        Me.btnLChangeDetails.Size = New System.Drawing.Size(217, 23)
        Me.btnLChangeDetails.TabIndex = 8
        Me.btnLChangeDetails.Text = "Change Account Details"
        '
        'AetherGroupBox15
        '
        Me.AetherGroupBox15.Controls.Add(Me.Label4)
        Me.AetherGroupBox15.Controls.Add(Me.chkLAutoUpdate)
        Me.AetherGroupBox15.Controls.Add(Me.btnLCheckUpdates)
        Me.AetherGroupBox15.Controls.Add(Me.chkLUpdateNotifier)
        Me.AetherGroupBox15.Controls.Add(Me.btnLUpdateNow)
        Me.AetherGroupBox15.Controls.Add(Me.tagCurrentVer)
        Me.AetherGroupBox15.Controls.Add(Me.tagLatestVer)
        Me.AetherGroupBox15.Controls.Add(Me.Label5)
        Me.AetherGroupBox15.Controls.Add(Me.prgUpdate)
        Me.AetherGroupBox15.Controls.Add(Me.lblLUpdateStatus)
        Me.AetherGroupBox15.Footer = False
        Me.AetherGroupBox15.FooterText = Nothing
        Me.AetherGroupBox15.Location = New System.Drawing.Point(357, 318)
        Me.AetherGroupBox15.Name = "AetherGroupBox15"
        Me.AetherGroupBox15.Size = New System.Drawing.Size(453, 150)
        Me.AetherGroupBox15.TabIndex = 23
        Me.AetherGroupBox15.Text = "Software Updates"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(155, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Current Version:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkLAutoUpdate
        '
        Me.chkLAutoUpdate.Checked = False
        Me.chkLAutoUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLAutoUpdate.EnabledCalc = False
        Me.chkLAutoUpdate.HatchBrush = False
        Me.chkLAutoUpdate.Location = New System.Drawing.Point(267, 105)
        Me.chkLAutoUpdate.Name = "chkLAutoUpdate"
        Me.chkLAutoUpdate.Size = New System.Drawing.Size(152, 19)
        Me.chkLAutoUpdate.TabIndex = 22
        Me.chkLAutoUpdate.Text = "Update automatically"
        '
        'btnLCheckUpdates
        '
        Me.btnLCheckUpdates.EnabledCalc = True
        Me.btnLCheckUpdates.Location = New System.Drawing.Point(85, 61)
        Me.btnLCheckUpdates.Name = "btnLCheckUpdates"
        Me.btnLCheckUpdates.Size = New System.Drawing.Size(156, 23)
        Me.btnLCheckUpdates.TabIndex = 10
        Me.btnLCheckUpdates.Text = "Check for Updates"
        '
        'chkLUpdateNotifier
        '
        Me.chkLUpdateNotifier.Checked = False
        Me.chkLUpdateNotifier.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLUpdateNotifier.EnabledCalc = False
        Me.chkLUpdateNotifier.HatchBrush = False
        Me.chkLUpdateNotifier.Location = New System.Drawing.Point(34, 105)
        Me.chkLUpdateNotifier.Name = "chkLUpdateNotifier"
        Me.chkLUpdateNotifier.Size = New System.Drawing.Size(233, 19)
        Me.chkLUpdateNotifier.TabIndex = 21
        Me.chkLUpdateNotifier.Text = "Notify me when updates are available"
        '
        'btnLUpdateNow
        '
        Me.btnLUpdateNow.Enabled = False
        Me.btnLUpdateNow.EnabledCalc = False
        Me.btnLUpdateNow.Location = New System.Drawing.Point(247, 61)
        Me.btnLUpdateNow.Name = "btnLUpdateNow"
        Me.btnLUpdateNow.Size = New System.Drawing.Size(123, 23)
        Me.btnLUpdateNow.TabIndex = 11
        Me.btnLUpdateNow.Text = "Update Now"
        '
        'tagCurrentVer
        '
        Me.tagCurrentVer.Background = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tagCurrentVer.Border = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.tagCurrentVer.ForeColor = System.Drawing.Color.White
        Me.tagCurrentVer.Location = New System.Drawing.Point(257, 11)
        Me.tagCurrentVer.Name = "tagCurrentVer"
        Me.tagCurrentVer.Size = New System.Drawing.Size(44, 15)
        Me.tagCurrentVer.TabIndex = 14
        Me.tagCurrentVer.Text = "v1.0.0"
        Me.tagCurrentVer.TextColor = System.Drawing.Color.LightGray
        '
        'tagLatestVer
        '
        Me.tagLatestVer.Background = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tagLatestVer.Border = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.tagLatestVer.ForeColor = System.Drawing.Color.White
        Me.tagLatestVer.Location = New System.Drawing.Point(399, 10)
        Me.tagLatestVer.Name = "tagLatestVer"
        Me.tagLatestVer.Size = New System.Drawing.Size(44, 15)
        Me.tagLatestVer.TabIndex = 15
        Me.tagLatestVer.Text = "n/a"
        Me.tagLatestVer.TextColor = System.Drawing.Color.LightGray
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(307, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Latest Version:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'prgUpdate
        '
        Me.prgUpdate.BackColor = System.Drawing.Color.Transparent
        Me.prgUpdate.DrawHatch = True
        Me.prgUpdate.Location = New System.Drawing.Point(85, 62)
        Me.prgUpdate.Maximum = 100
        Me.prgUpdate.Minimum = 0
        Me.prgUpdate.MinimumSize = New System.Drawing.Size(58, 20)
        Me.prgUpdate.Name = "prgUpdate"
        Me.prgUpdate.ShowPercentage = True
        Me.prgUpdate.Size = New System.Drawing.Size(285, 20)
        Me.prgUpdate.TabIndex = 25
        Me.prgUpdate.Value = 0
        Me.prgUpdate.ValueAlignment = AltTrackr2.Ambiance.Ambiance_ProgressBar.Alignment.Right
        Me.prgUpdate.Visible = False
        '
        'lblLUpdateStatus
        '
        Me.lblLUpdateStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblLUpdateStatus.Location = New System.Drawing.Point(3, 105)
        Me.lblLUpdateStatus.Name = "lblLUpdateStatus"
        Me.lblLUpdateStatus.Size = New System.Drawing.Size(447, 23)
        Me.lblLUpdateStatus.TabIndex = 26
        Me.lblLUpdateStatus.Text = "Talking with the update servers..."
        Me.lblLUpdateStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLUpdateStatus.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(414, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 30)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Early Access User"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLUser
        '
        Me.lblLUser.AutoSize = True
        Me.lblLUser.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!)
        Me.lblLUser.Location = New System.Drawing.Point(408, 21)
        Me.lblLUser.Name = "lblLUser"
        Me.lblLUser.Size = New System.Drawing.Size(136, 54)
        Me.lblLUser.TabIndex = 19
        Me.lblLUser.Text = "admin"
        Me.lblLUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AltTrackr2.My.Resources.Resources._001_account
        Me.PictureBox1.Location = New System.Drawing.Point(228, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'lblAuthRequest
        '
        Me.lblAuthRequest.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblAuthRequest.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblAuthRequest.Location = New System.Drawing.Point(3, 217)
        Me.lblAuthRequest.Name = "lblAuthRequest"
        Me.lblAuthRequest.Size = New System.Drawing.Size(807, 63)
        Me.lblAuthRequest.TabIndex = 13
        Me.lblAuthRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLLogin
        '
        Me.pnlLLogin.Controls.Add(Me.txtLUsername)
        Me.pnlLLogin.Controls.Add(Me.txtLPassword)
        Me.pnlLLogin.Controls.Add(Me.Label9)
        Me.pnlLLogin.Controls.Add(Me.pnlLIncorrect)
        Me.pnlLLogin.Controls.Add(Me.btnLLogin)
        Me.pnlLLogin.Controls.Add(Me.btnLSignup)
        Me.pnlLLogin.Controls.Add(Me.btnLForgot)
        Me.pnlLLogin.Location = New System.Drawing.Point(299, 157)
        Me.pnlLLogin.Name = "pnlLLogin"
        Me.pnlLLogin.Size = New System.Drawing.Size(328, 169)
        Me.pnlLLogin.TabIndex = 11
        '
        'txtLUsername
        '
        Me.txtLUsername.EnabledCalc = True
        Me.txtLUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtLUsername.Location = New System.Drawing.Point(5, 28)
        Me.txtLUsername.MaxLength = 32767
        Me.txtLUsername.MultiLine = False
        Me.txtLUsername.Name = "txtLUsername"
        Me.txtLUsername.ReadOnly = False
        Me.txtLUsername.Size = New System.Drawing.Size(217, 29)
        Me.txtLUsername.TabIndex = 3
        Me.txtLUsername.Text = "Username"
        Me.txtLUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLUsername.UseSystemPasswordChar = False
        '
        'txtLPassword
        '
        Me.txtLPassword.EnabledCalc = True
        Me.txtLPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtLPassword.Location = New System.Drawing.Point(5, 63)
        Me.txtLPassword.MaxLength = 32767
        Me.txtLPassword.MultiLine = False
        Me.txtLPassword.Name = "txtLPassword"
        Me.txtLPassword.ReadOnly = False
        Me.txtLPassword.Size = New System.Drawing.Size(217, 29)
        Me.txtLPassword.TabIndex = 4
        Me.txtLPassword.Text = "Password"
        Me.txtLPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLPassword.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(222, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "LOGIN WITH MYMAEGA"
        '
        'pnlLIncorrect
        '
        Me.pnlLIncorrect.Controls.Add(Me.tagIncorrect2)
        Me.pnlLIncorrect.Controls.Add(Me.tagIncorrect1)
        Me.pnlLIncorrect.Location = New System.Drawing.Point(218, 28)
        Me.pnlLIncorrect.Name = "pnlLIncorrect"
        Me.pnlLIncorrect.Size = New System.Drawing.Size(103, 65)
        Me.pnlLIncorrect.TabIndex = 7
        Me.pnlLIncorrect.Visible = False
        '
        'tagIncorrect2
        '
        Me.tagIncorrect2.Background = System.Drawing.Color.Red
        Me.tagIncorrect2.Border = System.Drawing.Color.Black
        Me.tagIncorrect2.Location = New System.Drawing.Point(-86, 41)
        Me.tagIncorrect2.Name = "tagIncorrect2"
        Me.tagIncorrect2.Size = New System.Drawing.Size(92, 15)
        Me.tagIncorrect2.TabIndex = 6
        Me.tagIncorrect2.Text = "INCORRECT LOGIN"
        Me.tagIncorrect2.TextColor = System.Drawing.Color.White
        '
        'tagIncorrect1
        '
        Me.tagIncorrect1.Background = System.Drawing.Color.Red
        Me.tagIncorrect1.Border = System.Drawing.Color.Black
        Me.tagIncorrect1.Location = New System.Drawing.Point(-86, 8)
        Me.tagIncorrect1.Name = "tagIncorrect1"
        Me.tagIncorrect1.Size = New System.Drawing.Size(92, 15)
        Me.tagIncorrect1.TabIndex = 5
        Me.tagIncorrect1.Text = "INCORRECT LOGIN"
        Me.tagIncorrect1.TextColor = System.Drawing.Color.White
        '
        'btnLLogin
        '
        Me.btnLLogin.EnabledCalc = True
        Me.btnLLogin.Location = New System.Drawing.Point(5, 98)
        Me.btnLLogin.Name = "btnLLogin"
        Me.btnLLogin.Size = New System.Drawing.Size(107, 23)
        Me.btnLLogin.TabIndex = 0
        Me.btnLLogin.Text = "Login"
        '
        'btnLSignup
        '
        Me.btnLSignup.EnabledCalc = True
        Me.btnLSignup.Location = New System.Drawing.Point(115, 98)
        Me.btnLSignup.Name = "btnLSignup"
        Me.btnLSignup.Size = New System.Drawing.Size(107, 23)
        Me.btnLSignup.TabIndex = 1
        Me.btnLSignup.Text = "Signup"
        '
        'btnLForgot
        '
        Me.btnLForgot.EnabledCalc = True
        Me.btnLForgot.Location = New System.Drawing.Point(5, 128)
        Me.btnLForgot.Name = "btnLForgot"
        Me.btnLForgot.Size = New System.Drawing.Size(217, 23)
        Me.btnLForgot.TabIndex = 2
        Me.btnLForgot.Text = "Problems signing in?"
        '
        'tpHome
        '
        Me.tpHome.BackColor = System.Drawing.Color.White
        Me.tpHome.Controls.Add(Me.grpC2Change)
        Me.tpHome.Controls.Add(Me.grpC3Change)
        Me.tpHome.Controls.Add(Me.grpC4Change)
        Me.tpHome.Controls.Add(Me.grpC1Change)
        Me.tpHome.Controls.Add(Me.AetherGroupBox7)
        Me.tpHome.Controls.Add(Me.AetherGroupBox6)
        Me.tpHome.Controls.Add(Me.AetherGroupBox1)
        Me.tpHome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpHome.ImageIndex = 0
        Me.tpHome.Location = New System.Drawing.Point(194, 4)
        Me.tpHome.Name = "tpHome"
        Me.tpHome.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHome.Size = New System.Drawing.Size(824, 482)
        Me.tpHome.TabIndex = 0
        Me.tpHome.Text = "Home"
        '
        'grpC2Change
        '
        Me.grpC2Change.Controls.Add(Me.Label15)
        Me.grpC2Change.Controls.Add(Me.lblC2DChange)
        Me.grpC2Change.Footer = False
        Me.grpC2Change.FooterText = Nothing
        Me.grpC2Change.Location = New System.Drawing.Point(212, 181)
        Me.grpC2Change.Name = "grpC2Change"
        Me.grpC2Change.Size = New System.Drawing.Size(196, 89)
        Me.grpC2Change.TabIndex = 19
        Me.grpC2Change.Text = "Ethereum - Day/Total"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(99, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 26)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "+n/a%"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC2DChange
        '
        Me.lblC2DChange.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblC2DChange.Location = New System.Drawing.Point(7, 48)
        Me.lblC2DChange.Name = "lblC2DChange"
        Me.lblC2DChange.Size = New System.Drawing.Size(90, 26)
        Me.lblC2DChange.TabIndex = 2
        Me.lblC2DChange.Text = "+6.73%"
        Me.lblC2DChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpC3Change
        '
        Me.grpC3Change.Controls.Add(Me.Label17)
        Me.grpC3Change.Controls.Add(Me.lblC3DChange)
        Me.grpC3Change.Footer = False
        Me.grpC3Change.FooterText = Nothing
        Me.grpC3Change.Location = New System.Drawing.Point(417, 181)
        Me.grpC3Change.Name = "grpC3Change"
        Me.grpC3Change.Size = New System.Drawing.Size(196, 89)
        Me.grpC3Change.TabIndex = 19
        Me.grpC3Change.Text = "Monero - Day/Total"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(99, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 26)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "+n/a%"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC3DChange
        '
        Me.lblC3DChange.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblC3DChange.Location = New System.Drawing.Point(7, 48)
        Me.lblC3DChange.Name = "lblC3DChange"
        Me.lblC3DChange.Size = New System.Drawing.Size(90, 26)
        Me.lblC3DChange.TabIndex = 4
        Me.lblC3DChange.Text = "+6.73%"
        Me.lblC3DChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpC4Change
        '
        Me.grpC4Change.Controls.Add(Me.Label18)
        Me.grpC4Change.Controls.Add(Me.lblC4DChange)
        Me.grpC4Change.Footer = False
        Me.grpC4Change.FooterText = Nothing
        Me.grpC4Change.Location = New System.Drawing.Point(622, 181)
        Me.grpC4Change.Name = "grpC4Change"
        Me.grpC4Change.Size = New System.Drawing.Size(196, 89)
        Me.grpC4Change.TabIndex = 19
        Me.grpC4Change.Text = "Siacoin - Day/Total"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(99, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 26)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "+n/a%"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC4DChange
        '
        Me.lblC4DChange.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblC4DChange.Location = New System.Drawing.Point(7, 48)
        Me.lblC4DChange.Name = "lblC4DChange"
        Me.lblC4DChange.Size = New System.Drawing.Size(90, 26)
        Me.lblC4DChange.TabIndex = 6
        Me.lblC4DChange.Text = "+6.73%"
        Me.lblC4DChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpC1Change
        '
        Me.grpC1Change.Controls.Add(Me.Label13)
        Me.grpC1Change.Controls.Add(Me.lblC1DChange)
        Me.grpC1Change.Footer = False
        Me.grpC1Change.FooterText = Nothing
        Me.grpC1Change.Location = New System.Drawing.Point(7, 181)
        Me.grpC1Change.Name = "grpC1Change"
        Me.grpC1Change.Size = New System.Drawing.Size(196, 89)
        Me.grpC1Change.TabIndex = 18
        Me.grpC1Change.Text = "Bitcoin - Day/Total"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(99, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 26)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "+n/a%"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC1DChange
        '
        Me.lblC1DChange.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblC1DChange.Location = New System.Drawing.Point(7, 48)
        Me.lblC1DChange.Name = "lblC1DChange"
        Me.lblC1DChange.Size = New System.Drawing.Size(90, 26)
        Me.lblC1DChange.TabIndex = 0
        Me.lblC1DChange.Text = "+6.73%"
        Me.lblC1DChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AetherGroupBox7
        '
        Me.AetherGroupBox7.Controls.Add(Me.btnEditHoldings)
        Me.AetherGroupBox7.Controls.Add(Me.lblAltHoldings)
        Me.AetherGroupBox7.Footer = False
        Me.AetherGroupBox7.FooterText = Nothing
        Me.AetherGroupBox7.Location = New System.Drawing.Point(416, 8)
        Me.AetherGroupBox7.Name = "AetherGroupBox7"
        Me.AetherGroupBox7.Size = New System.Drawing.Size(402, 167)
        Me.AetherGroupBox7.TabIndex = 17
        Me.AetherGroupBox7.Text = "Holdings"
        '
        'btnEditHoldings
        '
        Me.btnEditHoldings.EnabledCalc = True
        Me.btnEditHoldings.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.btnEditHoldings.Location = New System.Drawing.Point(344, 8)
        Me.btnEditHoldings.Name = "btnEditHoldings"
        Me.btnEditHoldings.Size = New System.Drawing.Size(52, 23)
        Me.btnEditHoldings.TabIndex = 5
        Me.btnEditHoldings.Text = "EDIT"
        '
        'lblAltHoldings
        '
        Me.lblAltHoldings.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblAltHoldings.Location = New System.Drawing.Point(3, 43)
        Me.lblAltHoldings.Name = "lblAltHoldings"
        Me.lblAltHoldings.Size = New System.Drawing.Size(396, 117)
        Me.lblAltHoldings.TabIndex = 7
        Me.lblAltHoldings.Text = resources.GetString("lblAltHoldings.Text")
        Me.lblAltHoldings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AetherGroupBox6
        '
        Me.AetherGroupBox6.Controls.Add(Me.lblGoalC4)
        Me.AetherGroupBox6.Controls.Add(Me.lblGoalC3)
        Me.AetherGroupBox6.Controls.Add(Me.lblGoalC2)
        Me.AetherGroupBox6.Controls.Add(Me.lblGoalC1)
        Me.AetherGroupBox6.Controls.Add(Me.btnEditGoals)
        Me.AetherGroupBox6.Controls.Add(Me.prgC4)
        Me.AetherGroupBox6.Controls.Add(Me.prgC3)
        Me.AetherGroupBox6.Controls.Add(Me.prgC2)
        Me.AetherGroupBox6.Controls.Add(Me.prgC1)
        Me.AetherGroupBox6.Footer = False
        Me.AetherGroupBox6.FooterText = Nothing
        Me.AetherGroupBox6.Location = New System.Drawing.Point(6, 276)
        Me.AetherGroupBox6.Name = "AetherGroupBox6"
        Me.AetherGroupBox6.Size = New System.Drawing.Size(810, 198)
        Me.AetherGroupBox6.TabIndex = 2
        Me.AetherGroupBox6.Text = "Goals"
        '
        'lblGoalC4
        '
        Me.lblGoalC4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblGoalC4.Location = New System.Drawing.Point(651, 94)
        Me.lblGoalC4.Name = "lblGoalC4"
        Me.lblGoalC4.Size = New System.Drawing.Size(90, 21)
        Me.lblGoalC4.TabIndex = 7
        Me.lblGoalC4.Text = "Coin #4"
        Me.lblGoalC4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblGoalC3
        '
        Me.lblGoalC3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblGoalC3.Location = New System.Drawing.Point(457, 94)
        Me.lblGoalC3.Name = "lblGoalC3"
        Me.lblGoalC3.Size = New System.Drawing.Size(90, 21)
        Me.lblGoalC3.TabIndex = 6
        Me.lblGoalC3.Text = "Coin #3"
        Me.lblGoalC3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblGoalC2
        '
        Me.lblGoalC2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblGoalC2.Location = New System.Drawing.Point(263, 94)
        Me.lblGoalC2.Name = "lblGoalC2"
        Me.lblGoalC2.Size = New System.Drawing.Size(90, 21)
        Me.lblGoalC2.TabIndex = 5
        Me.lblGoalC2.Text = "Coin #2"
        Me.lblGoalC2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblGoalC1
        '
        Me.lblGoalC1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblGoalC1.Location = New System.Drawing.Point(69, 94)
        Me.lblGoalC1.Name = "lblGoalC1"
        Me.lblGoalC1.Size = New System.Drawing.Size(90, 21)
        Me.lblGoalC1.TabIndex = 2
        Me.lblGoalC1.Text = "Coin #1"
        Me.lblGoalC1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnEditGoals
        '
        Me.btnEditGoals.EnabledCalc = True
        Me.btnEditGoals.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.btnEditGoals.Location = New System.Drawing.Point(752, 8)
        Me.btnEditGoals.Name = "btnEditGoals"
        Me.btnEditGoals.Size = New System.Drawing.Size(52, 23)
        Me.btnEditGoals.TabIndex = 4
        Me.btnEditGoals.Text = "EDIT"
        '
        'prgC4
        '
        Me.prgC4.Border = System.Drawing.Color.LightGray
        Me.prgC4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.prgC4.HatchBrush = False
        Me.prgC4.HatchPrimary = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prgC4.HatchSecondary = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prgC4.Location = New System.Drawing.Point(632, 58)
        Me.prgC4.Max = 0.2!
        Me.prgC4.Min = 0!
        Me.prgC4.Name = "prgC4"
        Me.prgC4.Percent = True
        Me.prgC4.PostText = " AUD"
        Me.prgC4.Progress = 0.0067!
        Me.prgC4.ShowMax = False
        Me.prgC4.Size = New System.Drawing.Size(128, 128)
        Me.prgC4.TabIndex = 3
        Me.prgC4.Text = "Goal: 0 AUD"
        '
        'prgC3
        '
        Me.prgC3.Border = System.Drawing.Color.LightGray
        Me.prgC3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.prgC3.HatchBrush = False
        Me.prgC3.HatchPrimary = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prgC3.HatchSecondary = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prgC3.Location = New System.Drawing.Point(438, 58)
        Me.prgC3.Max = 70.0!
        Me.prgC3.Min = 0!
        Me.prgC3.Name = "prgC3"
        Me.prgC3.Percent = True
        Me.prgC3.PostText = " AUD"
        Me.prgC3.Progress = 36.27!
        Me.prgC3.ShowMax = False
        Me.prgC3.Size = New System.Drawing.Size(128, 128)
        Me.prgC3.TabIndex = 2
        Me.prgC3.Text = "Goal: 0 AUD"
        '
        'prgC2
        '
        Me.prgC2.Border = System.Drawing.Color.LightGray
        Me.prgC2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.prgC2.HatchBrush = False
        Me.prgC2.HatchPrimary = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prgC2.HatchSecondary = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prgC2.Location = New System.Drawing.Point(244, 58)
        Me.prgC2.Max = 350.0!
        Me.prgC2.Min = 0!
        Me.prgC2.Name = "prgC2"
        Me.prgC2.Percent = True
        Me.prgC2.PostText = " AUD"
        Me.prgC2.Progress = 293.46!
        Me.prgC2.ShowMax = False
        Me.prgC2.Size = New System.Drawing.Size(128, 128)
        Me.prgC2.TabIndex = 1
        Me.prgC2.Text = "Goal: 0 AUD"
        '
        'prgC1
        '
        Me.prgC1.Border = System.Drawing.Color.LightGray
        Me.prgC1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.prgC1.HatchBrush = False
        Me.prgC1.HatchPrimary = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prgC1.HatchSecondary = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prgC1.Location = New System.Drawing.Point(50, 58)
        Me.prgC1.Max = 3500.0!
        Me.prgC1.Min = 0!
        Me.prgC1.Name = "prgC1"
        Me.prgC1.Percent = True
        Me.prgC1.PostText = " AUD"
        Me.prgC1.Progress = 2987.21!
        Me.prgC1.ShowMax = False
        Me.prgC1.Size = New System.Drawing.Size(128, 128)
        Me.prgC1.TabIndex = 0
        Me.prgC1.Text = "Goal: 0 AUD"
        '
        'AetherGroupBox1
        '
        Me.AetherGroupBox1.Controls.Add(Me.btnEditPrices)
        Me.AetherGroupBox1.Controls.Add(Me.lblAltPrices)
        Me.AetherGroupBox1.Footer = False
        Me.AetherGroupBox1.FooterText = Nothing
        Me.AetherGroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.AetherGroupBox1.Name = "AetherGroupBox1"
        Me.AetherGroupBox1.Size = New System.Drawing.Size(402, 167)
        Me.AetherGroupBox1.TabIndex = 1
        Me.AetherGroupBox1.Text = "Prices"
        '
        'btnEditPrices
        '
        Me.btnEditPrices.EnabledCalc = True
        Me.btnEditPrices.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.btnEditPrices.Location = New System.Drawing.Point(343, 8)
        Me.btnEditPrices.Name = "btnEditPrices"
        Me.btnEditPrices.Size = New System.Drawing.Size(52, 23)
        Me.btnEditPrices.TabIndex = 5
        Me.btnEditPrices.Text = "EDIT"
        '
        'lblAltPrices
        '
        Me.lblAltPrices.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblAltPrices.Location = New System.Drawing.Point(3, 43)
        Me.lblAltPrices.Name = "lblAltPrices"
        Me.lblAltPrices.Size = New System.Drawing.Size(396, 117)
        Me.lblAltPrices.TabIndex = 16
        Me.lblAltPrices.Text = resources.GetString("lblAltPrices.Text")
        Me.lblAltPrices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpHistory
        '
        Me.tpHistory.BackColor = System.Drawing.Color.White
        Me.tpHistory.Controls.Add(Me.lblLastPriceUpdate)
        Me.tpHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpHistory.ImageIndex = 10
        Me.tpHistory.Location = New System.Drawing.Point(194, 4)
        Me.tpHistory.Name = "tpHistory"
        Me.tpHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHistory.Size = New System.Drawing.Size(824, 482)
        Me.tpHistory.TabIndex = 1
        Me.tpHistory.Text = "History"
        '
        'lblLastPriceUpdate
        '
        Me.lblLastPriceUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLastPriceUpdate.Depth = 0
        Me.lblLastPriceUpdate.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblLastPriceUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLastPriceUpdate.Location = New System.Drawing.Point(241, 229)
        Me.lblLastPriceUpdate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLastPriceUpdate.Name = "lblLastPriceUpdate"
        Me.lblLastPriceUpdate.Size = New System.Drawing.Size(343, 25)
        Me.lblLastPriceUpdate.TabIndex = 15
        Me.lblLastPriceUpdate.Text = "Last Updated:"
        Me.lblLastPriceUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpSpacer1
        '
        Me.tpSpacer1.BackColor = System.Drawing.Color.White
        Me.tpSpacer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpSpacer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpSpacer1.Location = New System.Drawing.Point(194, 4)
        Me.tpSpacer1.Name = "tpSpacer1"
        Me.tpSpacer1.Size = New System.Drawing.Size(824, 482)
        Me.tpSpacer1.TabIndex = 5
        '
        'tpCoin1
        '
        Me.tpCoin1.BackColor = System.Drawing.Color.White
        Me.tpCoin1.Controls.Add(Me.lblC1Name)
        Me.tpCoin1.Controls.Add(Me.lblC1Price)
        Me.tpCoin1.Controls.Add(Me.picC1Logo)
        Me.tpCoin1.Controls.Add(Me.AetherGroupBox3)
        Me.tpCoin1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpCoin1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpCoin1.ImageIndex = 9
        Me.tpCoin1.Location = New System.Drawing.Point(194, 4)
        Me.tpCoin1.Name = "tpCoin1"
        Me.tpCoin1.Size = New System.Drawing.Size(824, 482)
        Me.tpCoin1.TabIndex = 2
        Me.tpCoin1.Tag = "$2587.86"
        Me.tpCoin1.Text = "Coin One"
        '
        'lblC1Name
        '
        Me.lblC1Name.AutoSize = True
        Me.lblC1Name.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!)
        Me.lblC1Name.Location = New System.Drawing.Point(391, 26)
        Me.lblC1Name.Name = "lblC1Name"
        Me.lblC1Name.Size = New System.Drawing.Size(147, 54)
        Me.lblC1Name.TabIndex = 4
        Me.lblC1Name.Text = "COIN 1"
        Me.lblC1Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblC1Price
        '
        Me.lblC1Price.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblC1Price.Location = New System.Drawing.Point(397, 73)
        Me.lblC1Price.Name = "lblC1Price"
        Me.lblC1Price.Size = New System.Drawing.Size(176, 30)
        Me.lblC1Price.TabIndex = 5
        Me.lblC1Price.Text = "$n/a"
        Me.lblC1Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picC1Logo
        '
        Me.picC1Logo.Image = Global.AltTrackr2.My.Resources.Resources._004_money
        Me.picC1Logo.Location = New System.Drawing.Point(217, 26)
        Me.picC1Logo.Name = "picC1Logo"
        Me.picC1Logo.Size = New System.Drawing.Size(163, 163)
        Me.picC1Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picC1Logo.TabIndex = 3
        Me.picC1Logo.TabStop = False
        '
        'AetherGroupBox3
        '
        Me.AetherGroupBox3.Controls.Add(Me.lblC1PricesDetailed)
        Me.AetherGroupBox3.Controls.Add(Me.lblC1Friendly)
        Me.AetherGroupBox3.Controls.Add(Me.lblC1HoldingsDetailed)
        Me.AetherGroupBox3.Footer = False
        Me.AetherGroupBox3.FooterText = Nothing
        Me.AetherGroupBox3.Location = New System.Drawing.Point(6, 294)
        Me.AetherGroupBox3.Name = "AetherGroupBox3"
        Me.AetherGroupBox3.Size = New System.Drawing.Size(810, 181)
        Me.AetherGroupBox3.TabIndex = 2
        Me.AetherGroupBox3.Text = "Holdings Summary"
        '
        'lblC1PricesDetailed
        '
        Me.lblC1PricesDetailed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC1PricesDetailed.BackColor = System.Drawing.Color.Transparent
        Me.lblC1PricesDetailed.Depth = 0
        Me.lblC1PricesDetailed.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC1PricesDetailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC1PricesDetailed.Location = New System.Drawing.Point(3, 46)
        Me.lblC1PricesDetailed.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC1PricesDetailed.Name = "lblC1PricesDetailed"
        Me.lblC1PricesDetailed.Size = New System.Drawing.Size(804, 28)
        Me.lblC1PricesDetailed.TabIndex = 15
        Me.lblC1PricesDetailed.Text = "BTC Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblC1PricesDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC1Friendly
        '
        Me.lblC1Friendly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC1Friendly.Depth = 0
        Me.lblC1Friendly.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC1Friendly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC1Friendly.Location = New System.Drawing.Point(3, 107)
        Me.lblC1Friendly.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC1Friendly.Name = "lblC1Friendly"
        Me.lblC1Friendly.Size = New System.Drawing.Size(804, 71)
        Me.lblC1Friendly.TabIndex = 17
        Me.lblC1Friendly.Text = "Today, you hold 00.00 BTC which is valued at 00.00 AUD at a coin price of 00.00 A" &
    "UD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your initial investment was 00.00 AUD and has matured over 0 months, yieldin" &
    "g profits of 00.00 AUD so far"
        Me.lblC1Friendly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC1HoldingsDetailed
        '
        Me.lblC1HoldingsDetailed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC1HoldingsDetailed.BackColor = System.Drawing.Color.Transparent
        Me.lblC1HoldingsDetailed.Depth = 0
        Me.lblC1HoldingsDetailed.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC1HoldingsDetailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC1HoldingsDetailed.Location = New System.Drawing.Point(3, 74)
        Me.lblC1HoldingsDetailed.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC1HoldingsDetailed.Name = "lblC1HoldingsDetailed"
        Me.lblC1HoldingsDetailed.Size = New System.Drawing.Size(804, 28)
        Me.lblC1HoldingsDetailed.TabIndex = 16
        Me.lblC1HoldingsDetailed.Text = "BTC Holdings - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblC1HoldingsDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpCoin2
        '
        Me.tpCoin2.BackColor = System.Drawing.Color.White
        Me.tpCoin2.Controls.Add(Me.lblC2Name)
        Me.tpCoin2.Controls.Add(Me.lblC2Price)
        Me.tpCoin2.Controls.Add(Me.picC2Logo)
        Me.tpCoin2.Controls.Add(Me.AetherGroupBox4)
        Me.tpCoin2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpCoin2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpCoin2.ImageIndex = 9
        Me.tpCoin2.Location = New System.Drawing.Point(194, 4)
        Me.tpCoin2.Name = "tpCoin2"
        Me.tpCoin2.Size = New System.Drawing.Size(824, 482)
        Me.tpCoin2.TabIndex = 3
        Me.tpCoin2.Tag = "$192.12"
        Me.tpCoin2.Text = "Coin Two"
        '
        'lblC2Name
        '
        Me.lblC2Name.AutoSize = True
        Me.lblC2Name.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!)
        Me.lblC2Name.Location = New System.Drawing.Point(391, 26)
        Me.lblC2Name.Name = "lblC2Name"
        Me.lblC2Name.Size = New System.Drawing.Size(153, 54)
        Me.lblC2Name.TabIndex = 6
        Me.lblC2Name.Text = "COIN 2"
        Me.lblC2Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblC2Price
        '
        Me.lblC2Price.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblC2Price.Location = New System.Drawing.Point(397, 73)
        Me.lblC2Price.Name = "lblC2Price"
        Me.lblC2Price.Size = New System.Drawing.Size(211, 30)
        Me.lblC2Price.TabIndex = 7
        Me.lblC2Price.Text = "$n/a"
        Me.lblC2Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picC2Logo
        '
        Me.picC2Logo.Image = Global.AltTrackr2.My.Resources.Resources._004_money
        Me.picC2Logo.Location = New System.Drawing.Point(217, 26)
        Me.picC2Logo.Name = "picC2Logo"
        Me.picC2Logo.Size = New System.Drawing.Size(163, 163)
        Me.picC2Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picC2Logo.TabIndex = 5
        Me.picC2Logo.TabStop = False
        '
        'AetherGroupBox4
        '
        Me.AetherGroupBox4.Controls.Add(Me.lblC2PricesDetailed)
        Me.AetherGroupBox4.Controls.Add(Me.lblC2Friendly)
        Me.AetherGroupBox4.Controls.Add(Me.lblC2HoldingsDetailed)
        Me.AetherGroupBox4.Footer = False
        Me.AetherGroupBox4.FooterText = Nothing
        Me.AetherGroupBox4.Location = New System.Drawing.Point(6, 294)
        Me.AetherGroupBox4.Name = "AetherGroupBox4"
        Me.AetherGroupBox4.Size = New System.Drawing.Size(810, 181)
        Me.AetherGroupBox4.TabIndex = 3
        Me.AetherGroupBox4.Text = "Holdings Summary"
        '
        'lblC2PricesDetailed
        '
        Me.lblC2PricesDetailed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC2PricesDetailed.BackColor = System.Drawing.Color.Transparent
        Me.lblC2PricesDetailed.Depth = 0
        Me.lblC2PricesDetailed.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC2PricesDetailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC2PricesDetailed.Location = New System.Drawing.Point(3, 46)
        Me.lblC2PricesDetailed.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC2PricesDetailed.Name = "lblC2PricesDetailed"
        Me.lblC2PricesDetailed.Size = New System.Drawing.Size(804, 28)
        Me.lblC2PricesDetailed.TabIndex = 15
        Me.lblC2PricesDetailed.Text = "ETH Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblC2PricesDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC2Friendly
        '
        Me.lblC2Friendly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC2Friendly.Depth = 0
        Me.lblC2Friendly.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC2Friendly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC2Friendly.Location = New System.Drawing.Point(3, 107)
        Me.lblC2Friendly.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC2Friendly.Name = "lblC2Friendly"
        Me.lblC2Friendly.Size = New System.Drawing.Size(804, 71)
        Me.lblC2Friendly.TabIndex = 17
        Me.lblC2Friendly.Text = "Today, you hold 00.00 ETH which is valued at 00.00 AUD at a coin price of 00.00 A" &
    "UD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your initial investment was 00.00 AUD and has matured over 0 months, yieldin" &
    "g profits of 00.00 AUD so far"
        Me.lblC2Friendly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC2HoldingsDetailed
        '
        Me.lblC2HoldingsDetailed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC2HoldingsDetailed.BackColor = System.Drawing.Color.Transparent
        Me.lblC2HoldingsDetailed.Depth = 0
        Me.lblC2HoldingsDetailed.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC2HoldingsDetailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC2HoldingsDetailed.Location = New System.Drawing.Point(3, 74)
        Me.lblC2HoldingsDetailed.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC2HoldingsDetailed.Name = "lblC2HoldingsDetailed"
        Me.lblC2HoldingsDetailed.Size = New System.Drawing.Size(804, 28)
        Me.lblC2HoldingsDetailed.TabIndex = 16
        Me.lblC2HoldingsDetailed.Text = "ETH Holdings - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblC2HoldingsDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpCoin3
        '
        Me.tpCoin3.BackColor = System.Drawing.Color.White
        Me.tpCoin3.Controls.Add(Me.lblC3Price)
        Me.tpCoin3.Controls.Add(Me.lblC3Name)
        Me.tpCoin3.Controls.Add(Me.picC3Logo)
        Me.tpCoin3.Controls.Add(Me.AetherGroupBox5)
        Me.tpCoin3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpCoin3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpCoin3.ImageIndex = 9
        Me.tpCoin3.Location = New System.Drawing.Point(194, 4)
        Me.tpCoin3.Name = "tpCoin3"
        Me.tpCoin3.Size = New System.Drawing.Size(824, 482)
        Me.tpCoin3.TabIndex = 4
        Me.tpCoin3.Tag = "$47.98"
        Me.tpCoin3.Text = "Coin Three"
        '
        'lblC3Price
        '
        Me.lblC3Price.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblC3Price.Location = New System.Drawing.Point(397, 73)
        Me.lblC3Price.Name = "lblC3Price"
        Me.lblC3Price.Size = New System.Drawing.Size(211, 30)
        Me.lblC3Price.TabIndex = 9
        Me.lblC3Price.Text = "$n/a"
        Me.lblC3Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblC3Name
        '
        Me.lblC3Name.AutoSize = True
        Me.lblC3Name.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!)
        Me.lblC3Name.Location = New System.Drawing.Point(391, 26)
        Me.lblC3Name.Name = "lblC3Name"
        Me.lblC3Name.Size = New System.Drawing.Size(153, 54)
        Me.lblC3Name.TabIndex = 8
        Me.lblC3Name.Text = "COIN 3"
        Me.lblC3Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picC3Logo
        '
        Me.picC3Logo.Image = Global.AltTrackr2.My.Resources.Resources._004_money
        Me.picC3Logo.Location = New System.Drawing.Point(214, 26)
        Me.picC3Logo.Name = "picC3Logo"
        Me.picC3Logo.Size = New System.Drawing.Size(169, 163)
        Me.picC3Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picC3Logo.TabIndex = 7
        Me.picC3Logo.TabStop = False
        '
        'AetherGroupBox5
        '
        Me.AetherGroupBox5.Controls.Add(Me.lblC3PricesDetailed)
        Me.AetherGroupBox5.Controls.Add(Me.lblC3Friendly)
        Me.AetherGroupBox5.Controls.Add(Me.lblC3HoldingsDetailed)
        Me.AetherGroupBox5.Footer = False
        Me.AetherGroupBox5.FooterText = Nothing
        Me.AetherGroupBox5.Location = New System.Drawing.Point(6, 294)
        Me.AetherGroupBox5.Name = "AetherGroupBox5"
        Me.AetherGroupBox5.Size = New System.Drawing.Size(810, 181)
        Me.AetherGroupBox5.TabIndex = 3
        Me.AetherGroupBox5.Text = "Holdings Summary"
        '
        'lblC3PricesDetailed
        '
        Me.lblC3PricesDetailed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC3PricesDetailed.BackColor = System.Drawing.Color.Transparent
        Me.lblC3PricesDetailed.Depth = 0
        Me.lblC3PricesDetailed.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC3PricesDetailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC3PricesDetailed.Location = New System.Drawing.Point(3, 46)
        Me.lblC3PricesDetailed.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC3PricesDetailed.Name = "lblC3PricesDetailed"
        Me.lblC3PricesDetailed.Size = New System.Drawing.Size(804, 28)
        Me.lblC3PricesDetailed.TabIndex = 15
        Me.lblC3PricesDetailed.Text = "XMR Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblC3PricesDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC3Friendly
        '
        Me.lblC3Friendly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC3Friendly.Depth = 0
        Me.lblC3Friendly.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC3Friendly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC3Friendly.Location = New System.Drawing.Point(3, 107)
        Me.lblC3Friendly.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC3Friendly.Name = "lblC3Friendly"
        Me.lblC3Friendly.Size = New System.Drawing.Size(804, 71)
        Me.lblC3Friendly.TabIndex = 17
        Me.lblC3Friendly.Text = "Today, you hold 00.00 XMR which is valued at 00.00 AUD at a coin price of 00.00 A" &
    "UD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your initial investment was 00.00 AUD and has matured over 0 months, yieldin" &
    "g profits of 00.00 AUD so far"
        Me.lblC3Friendly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC3HoldingsDetailed
        '
        Me.lblC3HoldingsDetailed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC3HoldingsDetailed.BackColor = System.Drawing.Color.Transparent
        Me.lblC3HoldingsDetailed.Depth = 0
        Me.lblC3HoldingsDetailed.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC3HoldingsDetailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC3HoldingsDetailed.Location = New System.Drawing.Point(3, 74)
        Me.lblC3HoldingsDetailed.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC3HoldingsDetailed.Name = "lblC3HoldingsDetailed"
        Me.lblC3HoldingsDetailed.Size = New System.Drawing.Size(804, 28)
        Me.lblC3HoldingsDetailed.TabIndex = 16
        Me.lblC3HoldingsDetailed.Text = "XMR Holdings - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblC3HoldingsDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpCoin4
        '
        Me.tpCoin4.BackColor = System.Drawing.Color.White
        Me.tpCoin4.Controls.Add(Me.lblC4Price)
        Me.tpCoin4.Controls.Add(Me.lblC4Name)
        Me.tpCoin4.Controls.Add(Me.picC4Logo)
        Me.tpCoin4.Controls.Add(Me.AetherGroupBox14)
        Me.tpCoin4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpCoin4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpCoin4.ImageIndex = 9
        Me.tpCoin4.Location = New System.Drawing.Point(194, 4)
        Me.tpCoin4.Name = "tpCoin4"
        Me.tpCoin4.Size = New System.Drawing.Size(824, 482)
        Me.tpCoin4.TabIndex = 10
        Me.tpCoin4.Tag = "$0.0045"
        Me.tpCoin4.Text = "Coin Four"
        '
        'lblC4Price
        '
        Me.lblC4Price.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblC4Price.Location = New System.Drawing.Point(397, 73)
        Me.lblC4Price.Name = "lblC4Price"
        Me.lblC4Price.Size = New System.Drawing.Size(211, 30)
        Me.lblC4Price.TabIndex = 13
        Me.lblC4Price.Text = "$n/a"
        Me.lblC4Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblC4Name
        '
        Me.lblC4Name.AutoSize = True
        Me.lblC4Name.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!)
        Me.lblC4Name.Location = New System.Drawing.Point(391, 26)
        Me.lblC4Name.Name = "lblC4Name"
        Me.lblC4Name.Size = New System.Drawing.Size(154, 54)
        Me.lblC4Name.TabIndex = 12
        Me.lblC4Name.Text = "COIN 4"
        Me.lblC4Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picC4Logo
        '
        Me.picC4Logo.Image = Global.AltTrackr2.My.Resources.Resources._004_money
        Me.picC4Logo.Location = New System.Drawing.Point(214, 26)
        Me.picC4Logo.Name = "picC4Logo"
        Me.picC4Logo.Size = New System.Drawing.Size(169, 163)
        Me.picC4Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picC4Logo.TabIndex = 11
        Me.picC4Logo.TabStop = False
        '
        'AetherGroupBox14
        '
        Me.AetherGroupBox14.Controls.Add(Me.lblC4PricesDetailed)
        Me.AetherGroupBox14.Controls.Add(Me.lblC4Friendly)
        Me.AetherGroupBox14.Controls.Add(Me.lblC4HoldingsDetailed)
        Me.AetherGroupBox14.Footer = False
        Me.AetherGroupBox14.FooterText = Nothing
        Me.AetherGroupBox14.Location = New System.Drawing.Point(6, 294)
        Me.AetherGroupBox14.Name = "AetherGroupBox14"
        Me.AetherGroupBox14.Size = New System.Drawing.Size(810, 181)
        Me.AetherGroupBox14.TabIndex = 10
        Me.AetherGroupBox14.Text = "Holdings Summary"
        '
        'lblC4PricesDetailed
        '
        Me.lblC4PricesDetailed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC4PricesDetailed.BackColor = System.Drawing.Color.Transparent
        Me.lblC4PricesDetailed.Depth = 0
        Me.lblC4PricesDetailed.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC4PricesDetailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC4PricesDetailed.Location = New System.Drawing.Point(3, 46)
        Me.lblC4PricesDetailed.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC4PricesDetailed.Name = "lblC4PricesDetailed"
        Me.lblC4PricesDetailed.Size = New System.Drawing.Size(804, 28)
        Me.lblC4PricesDetailed.TabIndex = 15
        Me.lblC4PricesDetailed.Text = "SC Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblC4PricesDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC4Friendly
        '
        Me.lblC4Friendly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC4Friendly.Depth = 0
        Me.lblC4Friendly.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC4Friendly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC4Friendly.Location = New System.Drawing.Point(3, 107)
        Me.lblC4Friendly.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC4Friendly.Name = "lblC4Friendly"
        Me.lblC4Friendly.Size = New System.Drawing.Size(804, 71)
        Me.lblC4Friendly.TabIndex = 17
        Me.lblC4Friendly.Text = "Today, you hold 00.00 XMR which is valued at 00.00 AUD at a coin price of 00.00 A" &
    "UD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your initial investment was 00.00 AUD and has matured over 0 months, yieldin" &
    "g profits of 00.00 AUD so far"
        Me.lblC4Friendly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC4HoldingsDetailed
        '
        Me.lblC4HoldingsDetailed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC4HoldingsDetailed.BackColor = System.Drawing.Color.Transparent
        Me.lblC4HoldingsDetailed.Depth = 0
        Me.lblC4HoldingsDetailed.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC4HoldingsDetailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC4HoldingsDetailed.Location = New System.Drawing.Point(3, 74)
        Me.lblC4HoldingsDetailed.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC4HoldingsDetailed.Name = "lblC4HoldingsDetailed"
        Me.lblC4HoldingsDetailed.Size = New System.Drawing.Size(804, 28)
        Me.lblC4HoldingsDetailed.TabIndex = 16
        Me.lblC4HoldingsDetailed.Text = "SC Holdings - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblC4HoldingsDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpSpacer2
        '
        Me.tpSpacer2.BackColor = System.Drawing.Color.White
        Me.tpSpacer2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpSpacer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpSpacer2.Location = New System.Drawing.Point(194, 4)
        Me.tpSpacer2.Name = "tpSpacer2"
        Me.tpSpacer2.Size = New System.Drawing.Size(824, 482)
        Me.tpSpacer2.TabIndex = 6
        '
        'tpPrefs
        '
        Me.tpPrefs.BackColor = System.Drawing.Color.White
        Me.tpPrefs.Controls.Add(Me.Ambiance_Button_21)
        Me.tpPrefs.Controls.Add(Me.AetherButton3)
        Me.tpPrefs.Controls.Add(Me.radC4Edit)
        Me.tpPrefs.Controls.Add(Me.radC3Edit)
        Me.tpPrefs.Controls.Add(Me.radC2Edit)
        Me.tpPrefs.Controls.Add(Me.radC1Edit)
        Me.tpPrefs.Controls.Add(Me.grpC1Pref)
        Me.tpPrefs.Controls.Add(Me.AetherGroupBox13)
        Me.tpPrefs.Controls.Add(Me.AetherGroupBox12)
        Me.tpPrefs.Controls.Add(Me.AetherGroupBox2)
        Me.tpPrefs.Controls.Add(Me.grpC4Pref)
        Me.tpPrefs.Controls.Add(Me.grpC3Pref)
        Me.tpPrefs.Controls.Add(Me.grpC2Pref)
        Me.tpPrefs.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpPrefs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpPrefs.ImageIndex = 14
        Me.tpPrefs.Location = New System.Drawing.Point(194, 4)
        Me.tpPrefs.Name = "tpPrefs"
        Me.tpPrefs.Size = New System.Drawing.Size(824, 482)
        Me.tpPrefs.TabIndex = 7
        Me.tpPrefs.Text = "User Preferences"
        '
        'Ambiance_Button_21
        '
        Me.Ambiance_Button_21.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_Button_21.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Ambiance_Button_21.Image = Nothing
        Me.Ambiance_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ambiance_Button_21.Location = New System.Drawing.Point(614, 138)
        Me.Ambiance_Button_21.Name = "Ambiance_Button_21"
        Me.Ambiance_Button_21.Size = New System.Drawing.Size(177, 30)
        Me.Ambiance_Button_21.TabIndex = 30
        Me.Ambiance_Button_21.Text = "Save Settings"
        Me.Ambiance_Button_21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'AetherButton3
        '
        Me.AetherButton3.EnabledCalc = True
        Me.AetherButton3.Location = New System.Drawing.Point(625, 174)
        Me.AetherButton3.Name = "AetherButton3"
        Me.AetherButton3.Size = New System.Drawing.Size(158, 23)
        Me.AetherButton3.TabIndex = 4
        Me.AetherButton3.Text = "Check Prices"
        '
        'radC4Edit
        '
        Me.radC4Edit.AutoSize = True
        Me.radC4Edit.Depth = 0
        Me.radC4Edit.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radC4Edit.Location = New System.Drawing.Point(409, 204)
        Me.radC4Edit.Margin = New System.Windows.Forms.Padding(0)
        Me.radC4Edit.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radC4Edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.radC4Edit.Name = "radC4Edit"
        Me.radC4Edit.Ripple = True
        Me.radC4Edit.Size = New System.Drawing.Size(68, 30)
        Me.radC4Edit.TabIndex = 29
        Me.radC4Edit.Text = "Coin 4"
        Me.radC4Edit.UseVisualStyleBackColor = True
        '
        'radC3Edit
        '
        Me.radC3Edit.AutoSize = True
        Me.radC3Edit.Depth = 0
        Me.radC3Edit.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radC3Edit.Location = New System.Drawing.Point(409, 174)
        Me.radC3Edit.Margin = New System.Windows.Forms.Padding(0)
        Me.radC3Edit.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radC3Edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.radC3Edit.Name = "radC3Edit"
        Me.radC3Edit.Ripple = True
        Me.radC3Edit.Size = New System.Drawing.Size(68, 30)
        Me.radC3Edit.TabIndex = 28
        Me.radC3Edit.Text = "Coin 3"
        Me.radC3Edit.UseVisualStyleBackColor = True
        '
        'radC2Edit
        '
        Me.radC2Edit.AutoSize = True
        Me.radC2Edit.Depth = 0
        Me.radC2Edit.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radC2Edit.Location = New System.Drawing.Point(409, 144)
        Me.radC2Edit.Margin = New System.Windows.Forms.Padding(0)
        Me.radC2Edit.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radC2Edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.radC2Edit.Name = "radC2Edit"
        Me.radC2Edit.Ripple = True
        Me.radC2Edit.Size = New System.Drawing.Size(68, 30)
        Me.radC2Edit.TabIndex = 27
        Me.radC2Edit.Text = "Coin 2"
        Me.radC2Edit.UseVisualStyleBackColor = True
        '
        'radC1Edit
        '
        Me.radC1Edit.AutoSize = True
        Me.radC1Edit.Checked = True
        Me.radC1Edit.Depth = 0
        Me.radC1Edit.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radC1Edit.Location = New System.Drawing.Point(409, 114)
        Me.radC1Edit.Margin = New System.Windows.Forms.Padding(0)
        Me.radC1Edit.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radC1Edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.radC1Edit.Name = "radC1Edit"
        Me.radC1Edit.Ripple = True
        Me.radC1Edit.Size = New System.Drawing.Size(68, 30)
        Me.radC1Edit.TabIndex = 26
        Me.radC1Edit.TabStop = True
        Me.radC1Edit.Text = "Coin 1"
        Me.radC1Edit.UseVisualStyleBackColor = True
        '
        'grpC1Pref
        '
        Me.grpC1Pref.Controls.Add(Me.Label25)
        Me.grpC1Pref.Controls.Add(Me.Label24)
        Me.grpC1Pref.Controls.Add(Me.Label23)
        Me.grpC1Pref.Controls.Add(Me.Ambiance_NumericUpDown3)
        Me.grpC1Pref.Controls.Add(Me.Ambiance_NumericUpDown2)
        Me.grpC1Pref.Controls.Add(Me.Ambiance_NumericUpDown1)
        Me.grpC1Pref.Controls.Add(Me.txtC1Initial)
        Me.grpC1Pref.Controls.Add(Me.txtC1Holdings)
        Me.grpC1Pref.Controls.Add(Me.txtC1Goal)
        Me.grpC1Pref.Controls.Add(Me.lblC1Goal)
        Me.grpC1Pref.Controls.Add(Me.lblC1Initial)
        Me.grpC1Pref.Controls.Add(Me.lblPrefC1Holdings)
        Me.grpC1Pref.Footer = False
        Me.grpC1Pref.FooterText = Nothing
        Me.grpC1Pref.Location = New System.Drawing.Point(6, 51)
        Me.grpC1Pref.Name = "grpC1Pref"
        Me.grpC1Pref.Size = New System.Drawing.Size(570, 208)
        Me.grpC1Pref.TabIndex = 21
        Me.grpC1Pref.Text = "Coin 1"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label25.Location = New System.Drawing.Point(101, 143)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 15)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "| Day"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label24.Location = New System.Drawing.Point(299, 143)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 15)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "| Year"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label23.Location = New System.Drawing.Point(200, 143)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 15)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "| Month"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Ambiance_NumericUpDown3
        '
        Me.Ambiance_NumericUpDown3.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown3.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown3.Location = New System.Drawing.Point(256, 161)
        Me.Ambiance_NumericUpDown3.Maximum = CType(3000, Long)
        Me.Ambiance_NumericUpDown3.Minimum = CType(2000, Long)
        Me.Ambiance_NumericUpDown3.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown3.Name = "Ambiance_NumericUpDown3"
        Me.Ambiance_NumericUpDown3.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown3.TabIndex = 13
        Me.Ambiance_NumericUpDown3.Text = "Ambiance_NumericUpDown3"
        Me.Ambiance_NumericUpDown3.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown3.Value = CType(2017, Long)
        '
        'Ambiance_NumericUpDown2
        '
        Me.Ambiance_NumericUpDown2.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown2.Location = New System.Drawing.Point(58, 161)
        Me.Ambiance_NumericUpDown2.Maximum = CType(31, Long)
        Me.Ambiance_NumericUpDown2.Minimum = CType(1, Long)
        Me.Ambiance_NumericUpDown2.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown2.Name = "Ambiance_NumericUpDown2"
        Me.Ambiance_NumericUpDown2.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown2.TabIndex = 12
        Me.Ambiance_NumericUpDown2.Text = "Ambiance_NumericUpDown2"
        Me.Ambiance_NumericUpDown2.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown2.Value = CType(31, Long)
        '
        'Ambiance_NumericUpDown1
        '
        Me.Ambiance_NumericUpDown1.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown1.Location = New System.Drawing.Point(157, 161)
        Me.Ambiance_NumericUpDown1.Maximum = CType(12, Long)
        Me.Ambiance_NumericUpDown1.Minimum = CType(1, Long)
        Me.Ambiance_NumericUpDown1.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown1.Name = "Ambiance_NumericUpDown1"
        Me.Ambiance_NumericUpDown1.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown1.TabIndex = 11
        Me.Ambiance_NumericUpDown1.Text = "Ambiance_NumericUpDown1"
        Me.Ambiance_NumericUpDown1.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown1.Value = CType(12, Long)
        '
        'txtC1Initial
        '
        Me.txtC1Initial.EnabledCalc = True
        Me.txtC1Initial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC1Initial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC1Initial.Location = New System.Drawing.Point(144, 66)
        Me.txtC1Initial.MaxLength = 32767
        Me.txtC1Initial.MultiLine = False
        Me.txtC1Initial.Name = "txtC1Initial"
        Me.txtC1Initial.ReadOnly = False
        Me.txtC1Initial.Size = New System.Drawing.Size(116, 29)
        Me.txtC1Initial.TabIndex = 6
        Me.txtC1Initial.Text = "0"
        Me.txtC1Initial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC1Initial.UseSystemPasswordChar = False
        '
        'txtC1Holdings
        '
        Me.txtC1Holdings.EnabledCalc = True
        Me.txtC1Holdings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC1Holdings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC1Holdings.Location = New System.Drawing.Point(266, 66)
        Me.txtC1Holdings.MaxLength = 32767
        Me.txtC1Holdings.MultiLine = False
        Me.txtC1Holdings.Name = "txtC1Holdings"
        Me.txtC1Holdings.ReadOnly = False
        Me.txtC1Holdings.Size = New System.Drawing.Size(116, 29)
        Me.txtC1Holdings.TabIndex = 6
        Me.txtC1Holdings.Text = "0"
        Me.txtC1Holdings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC1Holdings.UseSystemPasswordChar = False
        '
        'txtC1Goal
        '
        Me.txtC1Goal.EnabledCalc = True
        Me.txtC1Goal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC1Goal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC1Goal.Location = New System.Drawing.Point(22, 66)
        Me.txtC1Goal.MaxLength = 32767
        Me.txtC1Goal.MultiLine = False
        Me.txtC1Goal.Name = "txtC1Goal"
        Me.txtC1Goal.ReadOnly = False
        Me.txtC1Goal.Size = New System.Drawing.Size(116, 29)
        Me.txtC1Goal.TabIndex = 6
        Me.txtC1Goal.Text = "0"
        Me.txtC1Goal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC1Goal.UseSystemPasswordChar = False
        '
        'lblC1Goal
        '
        Me.lblC1Goal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblC1Goal.Location = New System.Drawing.Point(22, 48)
        Me.lblC1Goal.Name = "lblC1Goal"
        Me.lblC1Goal.Size = New System.Drawing.Size(116, 17)
        Me.lblC1Goal.TabIndex = 10
        Me.lblC1Goal.Text = "Goal (USD)"
        Me.lblC1Goal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblC1Initial
        '
        Me.lblC1Initial.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblC1Initial.Location = New System.Drawing.Point(144, 48)
        Me.lblC1Initial.Name = "lblC1Initial"
        Me.lblC1Initial.Size = New System.Drawing.Size(116, 17)
        Me.lblC1Initial.TabIndex = 10
        Me.lblC1Initial.Text = "Initial (USD)"
        Me.lblC1Initial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblPrefC1Holdings
        '
        Me.lblPrefC1Holdings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblPrefC1Holdings.Location = New System.Drawing.Point(266, 48)
        Me.lblPrefC1Holdings.Name = "lblPrefC1Holdings"
        Me.lblPrefC1Holdings.Size = New System.Drawing.Size(116, 17)
        Me.lblPrefC1Holdings.TabIndex = 10
        Me.lblPrefC1Holdings.Text = "Holding (XMR)"
        Me.lblPrefC1Holdings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'AetherGroupBox13
        '
        Me.AetherGroupBox13.Controls.Add(Me.MaterialDivider1)
        Me.AetherGroupBox13.Controls.Add(Me.Panel1)
        Me.AetherGroupBox13.Controls.Add(Me.radNotifFM)
        Me.AetherGroupBox13.Controls.Add(Me.radNotifFW)
        Me.AetherGroupBox13.Controls.Add(Me.radNotifFD)
        Me.AetherGroupBox13.Controls.Add(Me.txtNotifTime)
        Me.AetherGroupBox13.Controls.Add(Me.txtNotifName)
        Me.AetherGroupBox13.Controls.Add(Me.btnNotifAdd)
        Me.AetherGroupBox13.Footer = False
        Me.AetherGroupBox13.FooterText = Nothing
        Me.AetherGroupBox13.Location = New System.Drawing.Point(578, 265)
        Me.AetherGroupBox13.Name = "AetherGroupBox13"
        Me.AetherGroupBox13.Size = New System.Drawing.Size(238, 210)
        Me.AetherGroupBox13.TabIndex = 20
        Me.AetherGroupBox13.Text = "Create Alert"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MaterialDivider1.Location = New System.Drawing.Point(13, 111)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(208, 1)
        Me.MaterialDivider1.TabIndex = 33
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radNotifC3)
        Me.Panel1.Controls.Add(Me.radNotifC2)
        Me.Panel1.Controls.Add(Me.radNotifC4)
        Me.Panel1.Controls.Add(Me.radNotifC1)
        Me.Panel1.Location = New System.Drawing.Point(52, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(134, 48)
        Me.Panel1.TabIndex = 34
        '
        'radNotifC3
        '
        Me.radNotifC3.Checked = False
        Me.radNotifC3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radNotifC3.EnabledCalc = True
        Me.radNotifC3.HatchBrush = False
        Me.radNotifC3.Location = New System.Drawing.Point(0, 26)
        Me.radNotifC3.Name = "radNotifC3"
        Me.radNotifC3.Size = New System.Drawing.Size(64, 19)
        Me.radNotifC3.TabIndex = 17
        Me.radNotifC3.Text = "Coin 3"
        '
        'radNotifC2
        '
        Me.radNotifC2.Checked = False
        Me.radNotifC2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radNotifC2.EnabledCalc = True
        Me.radNotifC2.HatchBrush = False
        Me.radNotifC2.Location = New System.Drawing.Point(70, 0)
        Me.radNotifC2.Name = "radNotifC2"
        Me.radNotifC2.Size = New System.Drawing.Size(64, 19)
        Me.radNotifC2.TabIndex = 16
        Me.radNotifC2.Tag = ""
        Me.radNotifC2.Text = "Coin 2"
        '
        'radNotifC4
        '
        Me.radNotifC4.Checked = False
        Me.radNotifC4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radNotifC4.EnabledCalc = True
        Me.radNotifC4.HatchBrush = False
        Me.radNotifC4.Location = New System.Drawing.Point(70, 26)
        Me.radNotifC4.Name = "radNotifC4"
        Me.radNotifC4.Size = New System.Drawing.Size(64, 19)
        Me.radNotifC4.TabIndex = 18
        Me.radNotifC4.Text = "Coin 4"
        '
        'radNotifC1
        '
        Me.radNotifC1.Checked = False
        Me.radNotifC1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radNotifC1.EnabledCalc = True
        Me.radNotifC1.HatchBrush = False
        Me.radNotifC1.Location = New System.Drawing.Point(0, 0)
        Me.radNotifC1.Name = "radNotifC1"
        Me.radNotifC1.Size = New System.Drawing.Size(64, 19)
        Me.radNotifC1.TabIndex = 15
        Me.radNotifC1.Text = "Coin 1"
        '
        'radNotifFM
        '
        Me.radNotifFM.Checked = False
        Me.radNotifFM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radNotifFM.EnabledCalc = True
        Me.radNotifFM.HatchBrush = False
        Me.radNotifFM.Location = New System.Drawing.Point(146, 85)
        Me.radNotifFM.Name = "radNotifFM"
        Me.radNotifFM.Size = New System.Drawing.Size(75, 19)
        Me.radNotifFM.TabIndex = 32
        Me.radNotifFM.Text = "Monthly"
        '
        'radNotifFW
        '
        Me.radNotifFW.Checked = False
        Me.radNotifFW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radNotifFW.EnabledCalc = True
        Me.radNotifFW.HatchBrush = False
        Me.radNotifFW.Location = New System.Drawing.Point(74, 85)
        Me.radNotifFW.Name = "radNotifFW"
        Me.radNotifFW.Size = New System.Drawing.Size(66, 19)
        Me.radNotifFW.TabIndex = 31
        Me.radNotifFW.Text = "Weekly"
        '
        'radNotifFD
        '
        Me.radNotifFD.Checked = False
        Me.radNotifFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radNotifFD.EnabledCalc = True
        Me.radNotifFD.HatchBrush = False
        Me.radNotifFD.Location = New System.Drawing.Point(13, 85)
        Me.radNotifFD.Name = "radNotifFD"
        Me.radNotifFD.Size = New System.Drawing.Size(55, 19)
        Me.radNotifFD.TabIndex = 30
        Me.radNotifFD.Text = "Daily"
        '
        'txtNotifTime
        '
        Me.txtNotifTime.EnabledCalc = True
        Me.txtNotifTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNotifTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtNotifTime.Location = New System.Drawing.Point(137, 47)
        Me.txtNotifTime.MaxLength = 32767
        Me.txtNotifTime.MultiLine = False
        Me.txtNotifTime.Name = "txtNotifTime"
        Me.txtNotifTime.ReadOnly = False
        Me.txtNotifTime.Size = New System.Drawing.Size(97, 29)
        Me.txtNotifTime.TabIndex = 29
        Me.txtNotifTime.Text = "When? (Time)"
        Me.txtNotifTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNotifTime.UseSystemPasswordChar = False
        '
        'txtNotifName
        '
        Me.txtNotifName.EnabledCalc = True
        Me.txtNotifName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNotifName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtNotifName.Location = New System.Drawing.Point(5, 47)
        Me.txtNotifName.MaxLength = 32767
        Me.txtNotifName.MultiLine = False
        Me.txtNotifName.Name = "txtNotifName"
        Me.txtNotifName.ReadOnly = False
        Me.txtNotifName.Size = New System.Drawing.Size(130, 29)
        Me.txtNotifName.TabIndex = 28
        Me.txtNotifName.Text = "What? (Name)"
        Me.txtNotifName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNotifName.UseSystemPasswordChar = False
        '
        'btnNotifAdd
        '
        Me.btnNotifAdd.EnabledCalc = True
        Me.btnNotifAdd.Location = New System.Drawing.Point(52, 176)
        Me.btnNotifAdd.Name = "btnNotifAdd"
        Me.btnNotifAdd.Size = New System.Drawing.Size(134, 23)
        Me.btnNotifAdd.TabIndex = 27
        Me.btnNotifAdd.Text = "Add Alert"
        '
        'AetherGroupBox12
        '
        Me.AetherGroupBox12.Controls.Add(Me.LvModule)
        Me.AetherGroupBox12.Footer = False
        Me.AetherGroupBox12.FooterText = Nothing
        Me.AetherGroupBox12.Location = New System.Drawing.Point(6, 265)
        Me.AetherGroupBox12.Name = "AetherGroupBox12"
        Me.AetherGroupBox12.Size = New System.Drawing.Size(570, 210)
        Me.AetherGroupBox12.TabIndex = 19
        Me.AetherGroupBox12.Text = "Alerts"
        '
        'LvModule
        '
        Me.LvModule.BackColor = System.Drawing.SystemColors.Window
        Me.LvModule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LvModule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LvModule.Depth = 0
        Me.LvModule.Font = New System.Drawing.Font("Roboto", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.LvModule.FullRowSelect = True
        Me.LvModule.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvModule.Location = New System.Drawing.Point(3, 39)
        Me.LvModule.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.LvModule.MouseState = MaterialSkin.MouseState.OUT
        Me.LvModule.MultiSelect = False
        Me.LvModule.Name = "LvModule"
        Me.LvModule.OwnerDraw = True
        Me.LvModule.Size = New System.Drawing.Size(563, 164)
        Me.LvModule.TabIndex = 21
        Me.LvModule.UseCompatibleStateImageBehavior = False
        Me.LvModule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Name"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Time"
        Me.ColumnHeader6.Width = 130
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Type"
        Me.ColumnHeader7.Width = 120
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Coin"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fiat"
        Me.ColumnHeader2.Width = 80
        '
        'AetherGroupBox2
        '
        Me.AetherGroupBox2.Controls.Add(Me.AetherButton2)
        Me.AetherGroupBox2.Controls.Add(Me.radStyle1)
        Me.AetherGroupBox2.Controls.Add(Me.radStyle3)
        Me.AetherGroupBox2.Controls.Add(Me.radStyle2)
        Me.AetherGroupBox2.Footer = False
        Me.AetherGroupBox2.FooterText = Nothing
        Me.AetherGroupBox2.Location = New System.Drawing.Point(6, 8)
        Me.AetherGroupBox2.Name = "AetherGroupBox2"
        Me.AetherGroupBox2.Size = New System.Drawing.Size(810, 37)
        Me.AetherGroupBox2.TabIndex = 5
        Me.AetherGroupBox2.Text = "User Interface"
        '
        'AetherButton2
        '
        Me.AetherButton2.EnabledCalc = True
        Me.AetherButton2.Location = New System.Drawing.Point(584, 7)
        Me.AetherButton2.Name = "AetherButton2"
        Me.AetherButton2.Size = New System.Drawing.Size(221, 23)
        Me.AetherButton2.TabIndex = 1
        Me.AetherButton2.Text = "Create Custom Colour Scheme..."
        '
        'radStyle1
        '
        Me.radStyle1.Checked = False
        Me.radStyle1.Cursor = System.Windows.Forms.Cursors.Default
        Me.radStyle1.Enabled = False
        Me.radStyle1.EnabledCalc = False
        Me.radStyle1.HatchBrush = False
        Me.radStyle1.Location = New System.Drawing.Point(248, 10)
        Me.radStyle1.Name = "radStyle1"
        Me.radStyle1.Size = New System.Drawing.Size(106, 19)
        Me.radStyle1.TabIndex = 1
        Me.radStyle1.Text = "UI Variant #1"
        '
        'radStyle3
        '
        Me.radStyle3.Checked = False
        Me.radStyle3.Cursor = System.Windows.Forms.Cursors.Default
        Me.radStyle3.Enabled = False
        Me.radStyle3.EnabledCalc = False
        Me.radStyle3.HatchBrush = False
        Me.radStyle3.Location = New System.Drawing.Point(472, 10)
        Me.radStyle3.Name = "radStyle3"
        Me.radStyle3.Size = New System.Drawing.Size(106, 19)
        Me.radStyle3.TabIndex = 3
        Me.radStyle3.Text = "UI Variant #3"
        '
        'radStyle2
        '
        Me.radStyle2.Checked = False
        Me.radStyle2.Cursor = System.Windows.Forms.Cursors.Default
        Me.radStyle2.Enabled = False
        Me.radStyle2.EnabledCalc = False
        Me.radStyle2.HatchBrush = False
        Me.radStyle2.Location = New System.Drawing.Point(360, 10)
        Me.radStyle2.Name = "radStyle2"
        Me.radStyle2.Size = New System.Drawing.Size(106, 19)
        Me.radStyle2.TabIndex = 2
        Me.radStyle2.Text = "UI Variant #2"
        '
        'grpC4Pref
        '
        Me.grpC4Pref.Controls.Add(Me.Label14)
        Me.grpC4Pref.Controls.Add(Me.Label16)
        Me.grpC4Pref.Controls.Add(Me.Ambiance_NumericUpDown10)
        Me.grpC4Pref.Controls.Add(Me.Label19)
        Me.grpC4Pref.Controls.Add(Me.Ambiance_NumericUpDown11)
        Me.grpC4Pref.Controls.Add(Me.Ambiance_NumericUpDown12)
        Me.grpC4Pref.Controls.Add(Me.txtC4Goal)
        Me.grpC4Pref.Controls.Add(Me.txtC4Initial)
        Me.grpC4Pref.Controls.Add(Me.lblC4Goal)
        Me.grpC4Pref.Controls.Add(Me.txtC4Holdings)
        Me.grpC4Pref.Controls.Add(Me.lblPrefC4Holdings)
        Me.grpC4Pref.Controls.Add(Me.lblC4Initial)
        Me.grpC4Pref.Footer = False
        Me.grpC4Pref.FooterText = Nothing
        Me.grpC4Pref.Location = New System.Drawing.Point(6, 51)
        Me.grpC4Pref.Name = "grpC4Pref"
        Me.grpC4Pref.Size = New System.Drawing.Size(570, 208)
        Me.grpC4Pref.TabIndex = 25
        Me.grpC4Pref.Text = "Coin 4"
        Me.grpC4Pref.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(101, 143)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 15)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "| Day"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(299, 143)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 15)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "| Year"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Ambiance_NumericUpDown10
        '
        Me.Ambiance_NumericUpDown10.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown10.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown10.Location = New System.Drawing.Point(256, 161)
        Me.Ambiance_NumericUpDown10.Maximum = CType(3000, Long)
        Me.Ambiance_NumericUpDown10.Minimum = CType(2000, Long)
        Me.Ambiance_NumericUpDown10.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown10.Name = "Ambiance_NumericUpDown10"
        Me.Ambiance_NumericUpDown10.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown10.TabIndex = 19
        Me.Ambiance_NumericUpDown10.Text = "Ambiance_NumericUpDown10"
        Me.Ambiance_NumericUpDown10.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown10.Value = CType(2017, Long)
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(200, 143)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 15)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "| Month"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Ambiance_NumericUpDown11
        '
        Me.Ambiance_NumericUpDown11.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown11.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown11.Location = New System.Drawing.Point(58, 161)
        Me.Ambiance_NumericUpDown11.Maximum = CType(31, Long)
        Me.Ambiance_NumericUpDown11.Minimum = CType(1, Long)
        Me.Ambiance_NumericUpDown11.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown11.Name = "Ambiance_NumericUpDown11"
        Me.Ambiance_NumericUpDown11.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown11.TabIndex = 18
        Me.Ambiance_NumericUpDown11.Text = "Ambiance_NumericUpDown11"
        Me.Ambiance_NumericUpDown11.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown11.Value = CType(31, Long)
        '
        'Ambiance_NumericUpDown12
        '
        Me.Ambiance_NumericUpDown12.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown12.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown12.Location = New System.Drawing.Point(157, 161)
        Me.Ambiance_NumericUpDown12.Maximum = CType(12, Long)
        Me.Ambiance_NumericUpDown12.Minimum = CType(1, Long)
        Me.Ambiance_NumericUpDown12.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown12.Name = "Ambiance_NumericUpDown12"
        Me.Ambiance_NumericUpDown12.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown12.TabIndex = 17
        Me.Ambiance_NumericUpDown12.Text = "Ambiance_NumericUpDown12"
        Me.Ambiance_NumericUpDown12.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown12.Value = CType(12, Long)
        '
        'txtC4Goal
        '
        Me.txtC4Goal.EnabledCalc = True
        Me.txtC4Goal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC4Goal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC4Goal.Location = New System.Drawing.Point(22, 66)
        Me.txtC4Goal.MaxLength = 32767
        Me.txtC4Goal.MultiLine = False
        Me.txtC4Goal.Name = "txtC4Goal"
        Me.txtC4Goal.ReadOnly = False
        Me.txtC4Goal.Size = New System.Drawing.Size(116, 29)
        Me.txtC4Goal.TabIndex = 9
        Me.txtC4Goal.Text = "0"
        Me.txtC4Goal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC4Goal.UseSystemPasswordChar = False
        '
        'txtC4Initial
        '
        Me.txtC4Initial.EnabledCalc = True
        Me.txtC4Initial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC4Initial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC4Initial.Location = New System.Drawing.Point(144, 66)
        Me.txtC4Initial.MaxLength = 32767
        Me.txtC4Initial.MultiLine = False
        Me.txtC4Initial.Name = "txtC4Initial"
        Me.txtC4Initial.ReadOnly = False
        Me.txtC4Initial.Size = New System.Drawing.Size(116, 29)
        Me.txtC4Initial.TabIndex = 9
        Me.txtC4Initial.Text = "0"
        Me.txtC4Initial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC4Initial.UseSystemPasswordChar = False
        '
        'lblC4Goal
        '
        Me.lblC4Goal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblC4Goal.Location = New System.Drawing.Point(22, 48)
        Me.lblC4Goal.Name = "lblC4Goal"
        Me.lblC4Goal.Size = New System.Drawing.Size(116, 17)
        Me.lblC4Goal.TabIndex = 13
        Me.lblC4Goal.Text = "Goal (USD)"
        Me.lblC4Goal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtC4Holdings
        '
        Me.txtC4Holdings.EnabledCalc = True
        Me.txtC4Holdings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC4Holdings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC4Holdings.Location = New System.Drawing.Point(266, 66)
        Me.txtC4Holdings.MaxLength = 32767
        Me.txtC4Holdings.MultiLine = False
        Me.txtC4Holdings.Name = "txtC4Holdings"
        Me.txtC4Holdings.ReadOnly = False
        Me.txtC4Holdings.Size = New System.Drawing.Size(116, 29)
        Me.txtC4Holdings.TabIndex = 9
        Me.txtC4Holdings.Text = "0"
        Me.txtC4Holdings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC4Holdings.UseSystemPasswordChar = False
        '
        'lblPrefC4Holdings
        '
        Me.lblPrefC4Holdings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblPrefC4Holdings.Location = New System.Drawing.Point(267, 48)
        Me.lblPrefC4Holdings.Name = "lblPrefC4Holdings"
        Me.lblPrefC4Holdings.Size = New System.Drawing.Size(116, 17)
        Me.lblPrefC4Holdings.TabIndex = 13
        Me.lblPrefC4Holdings.Text = "Holding (XMR)"
        Me.lblPrefC4Holdings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblC4Initial
        '
        Me.lblC4Initial.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblC4Initial.Location = New System.Drawing.Point(144, 48)
        Me.lblC4Initial.Name = "lblC4Initial"
        Me.lblC4Initial.Size = New System.Drawing.Size(116, 17)
        Me.lblC4Initial.TabIndex = 13
        Me.lblC4Initial.Text = "Initial (USD)"
        Me.lblC4Initial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'grpC3Pref
        '
        Me.grpC3Pref.Controls.Add(Me.Label10)
        Me.grpC3Pref.Controls.Add(Me.Label11)
        Me.grpC3Pref.Controls.Add(Me.Ambiance_NumericUpDown7)
        Me.grpC3Pref.Controls.Add(Me.Label12)
        Me.grpC3Pref.Controls.Add(Me.Ambiance_NumericUpDown8)
        Me.grpC3Pref.Controls.Add(Me.Ambiance_NumericUpDown9)
        Me.grpC3Pref.Controls.Add(Me.txtC3Goal)
        Me.grpC3Pref.Controls.Add(Me.txtC3Holdings)
        Me.grpC3Pref.Controls.Add(Me.txtC3Initial)
        Me.grpC3Pref.Controls.Add(Me.lblC3Initial)
        Me.grpC3Pref.Controls.Add(Me.lblC3Goal)
        Me.grpC3Pref.Controls.Add(Me.lblPrefC3Holdings)
        Me.grpC3Pref.Footer = False
        Me.grpC3Pref.FooterText = Nothing
        Me.grpC3Pref.Location = New System.Drawing.Point(6, 51)
        Me.grpC3Pref.Name = "grpC3Pref"
        Me.grpC3Pref.Size = New System.Drawing.Size(570, 208)
        Me.grpC3Pref.TabIndex = 24
        Me.grpC3Pref.Text = "Coin 3"
        Me.grpC3Pref.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(101, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "| Day"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(299, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 15)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "| Year"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Ambiance_NumericUpDown7
        '
        Me.Ambiance_NumericUpDown7.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown7.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown7.Location = New System.Drawing.Point(256, 161)
        Me.Ambiance_NumericUpDown7.Maximum = CType(3000, Long)
        Me.Ambiance_NumericUpDown7.Minimum = CType(2000, Long)
        Me.Ambiance_NumericUpDown7.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown7.Name = "Ambiance_NumericUpDown7"
        Me.Ambiance_NumericUpDown7.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown7.TabIndex = 19
        Me.Ambiance_NumericUpDown7.Text = "Ambiance_NumericUpDown7"
        Me.Ambiance_NumericUpDown7.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown7.Value = CType(2017, Long)
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(200, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 15)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "| Month"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Ambiance_NumericUpDown8
        '
        Me.Ambiance_NumericUpDown8.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown8.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown8.Location = New System.Drawing.Point(58, 161)
        Me.Ambiance_NumericUpDown8.Maximum = CType(31, Long)
        Me.Ambiance_NumericUpDown8.Minimum = CType(1, Long)
        Me.Ambiance_NumericUpDown8.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown8.Name = "Ambiance_NumericUpDown8"
        Me.Ambiance_NumericUpDown8.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown8.TabIndex = 18
        Me.Ambiance_NumericUpDown8.Text = "Ambiance_NumericUpDown8"
        Me.Ambiance_NumericUpDown8.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown8.Value = CType(31, Long)
        '
        'Ambiance_NumericUpDown9
        '
        Me.Ambiance_NumericUpDown9.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown9.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown9.Location = New System.Drawing.Point(157, 161)
        Me.Ambiance_NumericUpDown9.Maximum = CType(12, Long)
        Me.Ambiance_NumericUpDown9.Minimum = CType(1, Long)
        Me.Ambiance_NumericUpDown9.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown9.Name = "Ambiance_NumericUpDown9"
        Me.Ambiance_NumericUpDown9.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown9.TabIndex = 17
        Me.Ambiance_NumericUpDown9.Text = "Ambiance_NumericUpDown9"
        Me.Ambiance_NumericUpDown9.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown9.Value = CType(12, Long)
        '
        'txtC3Goal
        '
        Me.txtC3Goal.EnabledCalc = True
        Me.txtC3Goal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC3Goal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC3Goal.Location = New System.Drawing.Point(22, 66)
        Me.txtC3Goal.MaxLength = 32767
        Me.txtC3Goal.MultiLine = False
        Me.txtC3Goal.Name = "txtC3Goal"
        Me.txtC3Goal.ReadOnly = False
        Me.txtC3Goal.Size = New System.Drawing.Size(116, 29)
        Me.txtC3Goal.TabIndex = 8
        Me.txtC3Goal.Text = "0"
        Me.txtC3Goal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC3Goal.UseSystemPasswordChar = False
        '
        'txtC3Holdings
        '
        Me.txtC3Holdings.EnabledCalc = True
        Me.txtC3Holdings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC3Holdings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC3Holdings.Location = New System.Drawing.Point(266, 66)
        Me.txtC3Holdings.MaxLength = 32767
        Me.txtC3Holdings.MultiLine = False
        Me.txtC3Holdings.Name = "txtC3Holdings"
        Me.txtC3Holdings.ReadOnly = False
        Me.txtC3Holdings.Size = New System.Drawing.Size(116, 29)
        Me.txtC3Holdings.TabIndex = 8
        Me.txtC3Holdings.Text = "0"
        Me.txtC3Holdings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC3Holdings.UseSystemPasswordChar = False
        '
        'txtC3Initial
        '
        Me.txtC3Initial.EnabledCalc = True
        Me.txtC3Initial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC3Initial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC3Initial.Location = New System.Drawing.Point(144, 66)
        Me.txtC3Initial.MaxLength = 32767
        Me.txtC3Initial.MultiLine = False
        Me.txtC3Initial.Name = "txtC3Initial"
        Me.txtC3Initial.ReadOnly = False
        Me.txtC3Initial.Size = New System.Drawing.Size(116, 29)
        Me.txtC3Initial.TabIndex = 8
        Me.txtC3Initial.Text = "0"
        Me.txtC3Initial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC3Initial.UseSystemPasswordChar = False
        '
        'lblC3Initial
        '
        Me.lblC3Initial.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblC3Initial.Location = New System.Drawing.Point(144, 48)
        Me.lblC3Initial.Name = "lblC3Initial"
        Me.lblC3Initial.Size = New System.Drawing.Size(116, 17)
        Me.lblC3Initial.TabIndex = 12
        Me.lblC3Initial.Text = "Initial (USD)"
        Me.lblC3Initial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblC3Goal
        '
        Me.lblC3Goal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblC3Goal.Location = New System.Drawing.Point(22, 48)
        Me.lblC3Goal.Name = "lblC3Goal"
        Me.lblC3Goal.Size = New System.Drawing.Size(116, 17)
        Me.lblC3Goal.TabIndex = 12
        Me.lblC3Goal.Text = "Goal (USD)"
        Me.lblC3Goal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblPrefC3Holdings
        '
        Me.lblPrefC3Holdings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblPrefC3Holdings.Location = New System.Drawing.Point(267, 48)
        Me.lblPrefC3Holdings.Name = "lblPrefC3Holdings"
        Me.lblPrefC3Holdings.Size = New System.Drawing.Size(116, 17)
        Me.lblPrefC3Holdings.TabIndex = 12
        Me.lblPrefC3Holdings.Text = "Holding (XMR)"
        Me.lblPrefC3Holdings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'grpC2Pref
        '
        Me.grpC2Pref.Controls.Add(Me.Label3)
        Me.grpC2Pref.Controls.Add(Me.Label6)
        Me.grpC2Pref.Controls.Add(Me.Label8)
        Me.grpC2Pref.Controls.Add(Me.Ambiance_NumericUpDown4)
        Me.grpC2Pref.Controls.Add(Me.Ambiance_NumericUpDown5)
        Me.grpC2Pref.Controls.Add(Me.Ambiance_NumericUpDown6)
        Me.grpC2Pref.Controls.Add(Me.txtC2Initial)
        Me.grpC2Pref.Controls.Add(Me.txtC2Goal)
        Me.grpC2Pref.Controls.Add(Me.txtC2Holdings)
        Me.grpC2Pref.Controls.Add(Me.lblC2Goal)
        Me.grpC2Pref.Controls.Add(Me.lblC2Initial)
        Me.grpC2Pref.Controls.Add(Me.lblPrefC2Holdings)
        Me.grpC2Pref.Footer = False
        Me.grpC2Pref.FooterText = Nothing
        Me.grpC2Pref.Location = New System.Drawing.Point(6, 51)
        Me.grpC2Pref.Name = "grpC2Pref"
        Me.grpC2Pref.Size = New System.Drawing.Size(570, 208)
        Me.grpC2Pref.TabIndex = 22
        Me.grpC2Pref.Text = "Coin 2"
        Me.grpC2Pref.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(101, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "| Day"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(299, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "| Year"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(200, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "| Month"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Ambiance_NumericUpDown4
        '
        Me.Ambiance_NumericUpDown4.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown4.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown4.Location = New System.Drawing.Point(256, 161)
        Me.Ambiance_NumericUpDown4.Maximum = CType(3000, Long)
        Me.Ambiance_NumericUpDown4.Minimum = CType(2000, Long)
        Me.Ambiance_NumericUpDown4.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown4.Name = "Ambiance_NumericUpDown4"
        Me.Ambiance_NumericUpDown4.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown4.TabIndex = 19
        Me.Ambiance_NumericUpDown4.Text = "Ambiance_NumericUpDown4"
        Me.Ambiance_NumericUpDown4.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown4.Value = CType(2017, Long)
        '
        'Ambiance_NumericUpDown5
        '
        Me.Ambiance_NumericUpDown5.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown5.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown5.Location = New System.Drawing.Point(58, 161)
        Me.Ambiance_NumericUpDown5.Maximum = CType(31, Long)
        Me.Ambiance_NumericUpDown5.Minimum = CType(1, Long)
        Me.Ambiance_NumericUpDown5.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown5.Name = "Ambiance_NumericUpDown5"
        Me.Ambiance_NumericUpDown5.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown5.TabIndex = 18
        Me.Ambiance_NumericUpDown5.Text = "Ambiance_NumericUpDown5"
        Me.Ambiance_NumericUpDown5.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown5.Value = CType(31, Long)
        '
        'Ambiance_NumericUpDown6
        '
        Me.Ambiance_NumericUpDown6.BackColor = System.Drawing.Color.Transparent
        Me.Ambiance_NumericUpDown6.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Ambiance_NumericUpDown6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Ambiance_NumericUpDown6.Location = New System.Drawing.Point(157, 161)
        Me.Ambiance_NumericUpDown6.Maximum = CType(12, Long)
        Me.Ambiance_NumericUpDown6.Minimum = CType(1, Long)
        Me.Ambiance_NumericUpDown6.MinimumSize = New System.Drawing.Size(62, 28)
        Me.Ambiance_NumericUpDown6.Name = "Ambiance_NumericUpDown6"
        Me.Ambiance_NumericUpDown6.Size = New System.Drawing.Size(93, 28)
        Me.Ambiance_NumericUpDown6.TabIndex = 17
        Me.Ambiance_NumericUpDown6.Text = "Ambiance_NumericUpDown6"
        Me.Ambiance_NumericUpDown6.TextAlignment = AltTrackr2.Ambiance.Ambiance_NumericUpDown._TextAlignment.Near
        Me.Ambiance_NumericUpDown6.Value = CType(12, Long)
        '
        'txtC2Initial
        '
        Me.txtC2Initial.EnabledCalc = True
        Me.txtC2Initial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC2Initial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC2Initial.Location = New System.Drawing.Point(144, 66)
        Me.txtC2Initial.MaxLength = 32767
        Me.txtC2Initial.MultiLine = False
        Me.txtC2Initial.Name = "txtC2Initial"
        Me.txtC2Initial.ReadOnly = False
        Me.txtC2Initial.Size = New System.Drawing.Size(116, 29)
        Me.txtC2Initial.TabIndex = 7
        Me.txtC2Initial.Text = "0"
        Me.txtC2Initial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC2Initial.UseSystemPasswordChar = False
        '
        'txtC2Goal
        '
        Me.txtC2Goal.EnabledCalc = True
        Me.txtC2Goal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC2Goal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC2Goal.Location = New System.Drawing.Point(22, 66)
        Me.txtC2Goal.MaxLength = 32767
        Me.txtC2Goal.MultiLine = False
        Me.txtC2Goal.Name = "txtC2Goal"
        Me.txtC2Goal.ReadOnly = False
        Me.txtC2Goal.Size = New System.Drawing.Size(116, 29)
        Me.txtC2Goal.TabIndex = 7
        Me.txtC2Goal.Text = "0"
        Me.txtC2Goal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC2Goal.UseSystemPasswordChar = False
        '
        'txtC2Holdings
        '
        Me.txtC2Holdings.EnabledCalc = True
        Me.txtC2Holdings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtC2Holdings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtC2Holdings.Location = New System.Drawing.Point(266, 66)
        Me.txtC2Holdings.MaxLength = 32767
        Me.txtC2Holdings.MultiLine = False
        Me.txtC2Holdings.Name = "txtC2Holdings"
        Me.txtC2Holdings.ReadOnly = False
        Me.txtC2Holdings.Size = New System.Drawing.Size(116, 29)
        Me.txtC2Holdings.TabIndex = 7
        Me.txtC2Holdings.Text = "0"
        Me.txtC2Holdings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtC2Holdings.UseSystemPasswordChar = False
        '
        'lblC2Goal
        '
        Me.lblC2Goal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblC2Goal.Location = New System.Drawing.Point(22, 48)
        Me.lblC2Goal.Name = "lblC2Goal"
        Me.lblC2Goal.Size = New System.Drawing.Size(116, 17)
        Me.lblC2Goal.TabIndex = 11
        Me.lblC2Goal.Text = "Goal (USD)"
        Me.lblC2Goal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblC2Initial
        '
        Me.lblC2Initial.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblC2Initial.Location = New System.Drawing.Point(144, 48)
        Me.lblC2Initial.Name = "lblC2Initial"
        Me.lblC2Initial.Size = New System.Drawing.Size(116, 17)
        Me.lblC2Initial.TabIndex = 11
        Me.lblC2Initial.Text = "Initial (USD)"
        Me.lblC2Initial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblPrefC2Holdings
        '
        Me.lblPrefC2Holdings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblPrefC2Holdings.Location = New System.Drawing.Point(267, 48)
        Me.lblPrefC2Holdings.Name = "lblPrefC2Holdings"
        Me.lblPrefC2Holdings.Size = New System.Drawing.Size(116, 17)
        Me.lblPrefC2Holdings.TabIndex = 11
        Me.lblPrefC2Holdings.Text = "Holding (XMR)"
        Me.lblPrefC2Holdings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tpSupport
        '
        Me.tpSupport.BackColor = System.Drawing.Color.White
        Me.tpSupport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpSupport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpSupport.ImageIndex = 8
        Me.tpSupport.Location = New System.Drawing.Point(194, 4)
        Me.tpSupport.Name = "tpSupport"
        Me.tpSupport.Size = New System.Drawing.Size(824, 482)
        Me.tpSupport.TabIndex = 8
        Me.tpSupport.Text = "Help & Support"
        '
        'tpFeedback
        '
        Me.tpFeedback.BackColor = System.Drawing.Color.White
        Me.tpFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpFeedback.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpFeedback.ImageIndex = 6
        Me.tpFeedback.Location = New System.Drawing.Point(194, 4)
        Me.tpFeedback.Name = "tpFeedback"
        Me.tpFeedback.Size = New System.Drawing.Size(824, 482)
        Me.tpFeedback.TabIndex = 9
        Me.tpFeedback.Tag = "150817"
        Me.tpFeedback.Text = "Feedback"
        '
        'frmHomeMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 554)
        Me.Controls.Add(Me.prgTitleLoad)
        Me.Controls.Add(Me.pnlUnsaved)
        Me.Controls.Add(Me.tabContent)
        Me.Controls.Add(Me.pnlLoadingMain)
        Me.Name = "frmHomeMulti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading Data"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlUnsaved.ResumeLayout(False)
        Me.pnlUnsaved.PerformLayout()
        Me.pnlLoadingMain.ResumeLayout(False)
        Me.tabContent.ResumeLayout(False)
        Me.tpLogin.ResumeLayout(False)
        Me.pnlLAccount.ResumeLayout(False)
        Me.pnlLAccount.PerformLayout()
        Me.AetherGroupBox16.ResumeLayout(False)
        Me.AetherGroupBox15.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLLogin.ResumeLayout(False)
        Me.pnlLLogin.PerformLayout()
        Me.pnlLIncorrect.ResumeLayout(False)
        Me.tpHome.ResumeLayout(False)
        Me.grpC2Change.ResumeLayout(False)
        Me.grpC3Change.ResumeLayout(False)
        Me.grpC4Change.ResumeLayout(False)
        Me.grpC1Change.ResumeLayout(False)
        Me.AetherGroupBox7.ResumeLayout(False)
        Me.AetherGroupBox6.ResumeLayout(False)
        Me.AetherGroupBox1.ResumeLayout(False)
        Me.tpHistory.ResumeLayout(False)
        Me.tpCoin1.ResumeLayout(False)
        Me.tpCoin1.PerformLayout()
        CType(Me.picC1Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AetherGroupBox3.ResumeLayout(False)
        Me.tpCoin2.ResumeLayout(False)
        Me.tpCoin2.PerformLayout()
        CType(Me.picC2Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AetherGroupBox4.ResumeLayout(False)
        Me.tpCoin3.ResumeLayout(False)
        Me.tpCoin3.PerformLayout()
        CType(Me.picC3Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AetherGroupBox5.ResumeLayout(False)
        Me.tpCoin4.ResumeLayout(False)
        Me.tpCoin4.PerformLayout()
        CType(Me.picC4Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AetherGroupBox14.ResumeLayout(False)
        Me.tpPrefs.ResumeLayout(False)
        Me.tpPrefs.PerformLayout()
        Me.grpC1Pref.ResumeLayout(False)
        Me.AetherGroupBox13.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.AetherGroupBox12.ResumeLayout(False)
        Me.AetherGroupBox2.ResumeLayout(False)
        Me.grpC4Pref.ResumeLayout(False)
        Me.grpC3Pref.ResumeLayout(False)
        Me.grpC2Pref.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabContent As AetherTabControl
    Friend WithEvents tpHome As TabPage
    Friend WithEvents AetherGroupBox1 As AetherGroupBox
    Friend WithEvents tpHistory As TabPage
    Friend WithEvents tpSpacer1 As TabPage
    Friend WithEvents tpCoin1 As TabPage
    Friend WithEvents tpCoin2 As TabPage
    Friend WithEvents tpCoin3 As TabPage
    Friend WithEvents tpSpacer2 As TabPage
    Friend WithEvents tpPrefs As TabPage
    Friend WithEvents tpSupport As TabPage
    Friend WithEvents tpFeedback As TabPage
    Friend WithEvents prgC1 As AetherCircular
    Friend WithEvents ilsIcon As ImageList
    Friend WithEvents tpCoin4 As TabPage
    Friend WithEvents AetherButton2 As AetherButton
    Friend WithEvents radStyle3 As AetherRadioButton
    Friend WithEvents radStyle2 As AetherRadioButton
    Friend WithEvents radStyle1 As AetherRadioButton
    Friend WithEvents bkgGetPrices As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblLastPriceUpdate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tmrRefresh As Timer
    Friend WithEvents pnlUnsaved As Panel
    Friend WithEvents lblUnsaved As Label
    Friend WithEvents AetherButton3 As AetherButton
    Friend WithEvents pnlLoadingMain As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents prgTitleLoad As MRG.Controls.UI.LoadingCircle
    Friend WithEvents ilsImg As ImageList
    Friend WithEvents AetherTag2 As AetherTag
    Friend WithEvents btnConfirmCancel As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnConfirmSave As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents pnlPipe As Panel
    Friend WithEvents AetherGroupBox2 As AetherGroupBox
    Friend WithEvents AetherGroupBox3 As AetherGroupBox
    Friend WithEvents lblC1Friendly As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblC1HoldingsDetailed As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AetherGroupBox4 As AetherGroupBox
    Friend WithEvents lblC2PricesDetailed As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblC2Friendly As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblC2HoldingsDetailed As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AetherGroupBox5 As AetherGroupBox
    Friend WithEvents lblC3PricesDetailed As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblC3Friendly As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblC3HoldingsDetailed As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents picC1Logo As PictureBox
    Friend WithEvents lblC1Name As Label
    Friend WithEvents lblC2Name As Label
    Friend WithEvents picC2Logo As PictureBox
    Friend WithEvents lblC3Name As Label
    Friend WithEvents picC3Logo As PictureBox
    Friend WithEvents lblC1Price As Label
    Friend WithEvents lblC2Price As Label
    Friend WithEvents lblC3Price As Label
    Friend WithEvents tpLogin As TabPage
    Friend WithEvents txtLUsername As AetherTextbox
    Friend WithEvents txtLPassword As AetherTextbox
    Friend WithEvents btnLForgot As AetherButton
    Friend WithEvents btnLSignup As AetherButton
    Friend WithEvents btnLLogin As AetherButton
    Friend WithEvents tagIncorrect2 As AetherTag
    Friend WithEvents tagIncorrect1 As AetherTag
    Friend WithEvents pnlLIncorrect As Panel
    Friend WithEvents btnLLogout As AetherButton
    Friend WithEvents btnLChangeDetails As AetherButton
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlLAccount As Panel
    Friend WithEvents pnlLLogin As Panel
    Friend WithEvents lblAltPrices As Label
    Friend WithEvents lblAltHoldings As Label
    Friend WithEvents AetherGroupBox6 As AetherGroupBox
    Friend WithEvents prgC4 As AetherCircular
    Friend WithEvents prgC3 As AetherCircular
    Friend WithEvents prgC2 As AetherCircular
    Friend WithEvents lblC4Goal As Label
    Friend WithEvents lblC3Goal As Label
    Friend WithEvents lblC2Goal As Label
    Friend WithEvents lblC1Goal As Label
    Friend WithEvents txtC4Goal As AetherTextbox
    Friend WithEvents txtC3Goal As AetherTextbox
    Friend WithEvents txtC2Goal As AetherTextbox
    Friend WithEvents txtC1Goal As AetherTextbox
    Friend WithEvents btnEditGoals As AetherButton
    Friend WithEvents btnEditPrices As AetherButton
    Friend WithEvents AetherGroupBox7 As AetherGroupBox
    Friend WithEvents btnEditHoldings As AetherButton
    Friend WithEvents grpC1Change As AetherGroupBox
    Friend WithEvents grpC2Change As AetherGroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblC2DChange As Label
    Friend WithEvents grpC3Change As AetherGroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblC3DChange As Label
    Friend WithEvents grpC4Change As AetherGroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lblC4DChange As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblC1DChange As Label
    Friend WithEvents lblGoalC4 As Label
    Friend WithEvents lblGoalC3 As Label
    Friend WithEvents lblGoalC2 As Label
    Friend WithEvents lblGoalC1 As Label
    Friend WithEvents lblAuthRequest As Label
    Friend WithEvents AetherGroupBox12 As AetherGroupBox
    Friend WithEvents LvModule As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents AetherGroupBox13 As AetherGroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents radNotifC3 As AetherRadioButton
    Friend WithEvents radNotifC2 As AetherRadioButton
    Friend WithEvents radNotifC4 As AetherRadioButton
    Friend WithEvents radNotifC1 As AetherRadioButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents radNotifFM As AetherRadioButton
    Friend WithEvents radNotifFW As AetherRadioButton
    Friend WithEvents radNotifFD As AetherRadioButton
    Friend WithEvents txtNotifTime As AetherTextbox
    Friend WithEvents txtNotifName As AetherTextbox
    Friend WithEvents btnNotifAdd As AetherButton
    Friend WithEvents lblC4Price As Label
    Friend WithEvents lblC4Name As Label
    Friend WithEvents picC4Logo As PictureBox
    Friend WithEvents AetherGroupBox14 As AetherGroupBox
    Friend WithEvents lblC4PricesDetailed As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblC4Friendly As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblC4HoldingsDetailed As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tagCurrentVer As AetherTag
    Friend WithEvents btnLUpdateNow As AetherButton
    Friend WithEvents btnLCheckUpdates As AetherButton
    Friend WithEvents Label7 As Label
    Friend WithEvents lblLUser As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tagLatestVer As AetherTag
    Friend WithEvents AetherGroupBox16 As AetherGroupBox
    Friend WithEvents AetherGroupBox15 As AetherGroupBox
    Friend WithEvents chkLAutoUpdate As AetherCheckBox
    Friend WithEvents chkLUpdateNotifier As AetherCheckBox
    Friend WithEvents prgUpdate As Ambiance.Ambiance_ProgressBar
    Friend WithEvents lblLUpdateStatus As Label
    Friend WithEvents lblC1PricesDetailed As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents grpC1Pref As AetherGroupBox
    Friend WithEvents grpC2Pref As AetherGroupBox
    Friend WithEvents txtC1Holdings As AetherTextbox
    Friend WithEvents txtC2Holdings As AetherTextbox
    Friend WithEvents txtC3Holdings As AetherTextbox
    Friend WithEvents txtC4Holdings As AetherTextbox
    Friend WithEvents lblPrefC1Holdings As Label
    Friend WithEvents lblPrefC4Holdings As Label
    Friend WithEvents lblPrefC2Holdings As Label
    Friend WithEvents lblPrefC3Holdings As Label
    Friend WithEvents grpC3Pref As AetherGroupBox
    Friend WithEvents txtC1Initial As AetherTextbox
    Friend WithEvents txtC2Initial As AetherTextbox
    Friend WithEvents txtC3Initial As AetherTextbox
    Friend WithEvents txtC4Initial As AetherTextbox
    Friend WithEvents lblC1Initial As Label
    Friend WithEvents lblC4Initial As Label
    Friend WithEvents lblC2Initial As Label
    Friend WithEvents lblC3Initial As Label
    Friend WithEvents grpC4Pref As AetherGroupBox
    Friend WithEvents Ambiance_NumericUpDown10 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Ambiance_NumericUpDown11 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Ambiance_NumericUpDown12 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Ambiance_NumericUpDown7 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Ambiance_NumericUpDown8 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Ambiance_NumericUpDown9 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Ambiance_NumericUpDown4 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Ambiance_NumericUpDown5 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Ambiance_NumericUpDown6 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Ambiance_NumericUpDown3 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Ambiance_NumericUpDown2 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Ambiance_NumericUpDown1 As Ambiance.Ambiance_NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents bkgGetOnlineMeta As System.ComponentModel.BackgroundWorker
    Friend WithEvents radC4Edit As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radC3Edit As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radC2Edit As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radC1Edit As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Ambiance_Button_21 As Ambiance.Ambiance_Button_2
End Class
