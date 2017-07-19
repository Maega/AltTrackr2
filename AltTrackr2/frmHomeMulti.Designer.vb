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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
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
        Me.tabContent = New AltTrackr2.AetherTabControl()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.btnLLogout = New AltTrackr2.AetherButton()
        Me.btnLChangeDetails = New AltTrackr2.AetherButton()
        Me.txtLUsername = New AltTrackr2.AetherTextbox()
        Me.txtLPassword = New AltTrackr2.AetherTextbox()
        Me.btnLForgot = New AltTrackr2.AetherButton()
        Me.btnLSignup = New AltTrackr2.AetherButton()
        Me.btnLLogin = New AltTrackr2.AetherButton()
        Me.pnlLIncorrect = New System.Windows.Forms.Panel()
        Me.tagIncorrect2 = New AltTrackr2.AetherTag()
        Me.tagIncorrect1 = New AltTrackr2.AetherTag()
        Me.tpHome = New System.Windows.Forms.TabPage()
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
        Me.tpHistory = New System.Windows.Forms.TabPage()
        Me.lblLastPriceUpdate = New MaterialSkin.Controls.MaterialLabel()
        Me.tpSpacer1 = New System.Windows.Forms.TabPage()
        Me.tpBitcoin = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AetherGroupBox3 = New AltTrackr2.AetherGroupBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.tpEthereum = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AetherGroupBox4 = New AltTrackr2.AetherGroupBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.tpMonero = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.AetherGroupBox5 = New AltTrackr2.AetherGroupBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.tpSiacoin = New System.Windows.Forms.TabPage()
        Me.tpSpacer2 = New System.Windows.Forms.TabPage()
        Me.tpPrefs = New System.Windows.Forms.TabPage()
        Me.AetherGroupBox2 = New AltTrackr2.AetherGroupBox()
        Me.AetherButton2 = New AltTrackr2.AetherButton()
        Me.radStyle1 = New AltTrackr2.AetherRadioButton()
        Me.radStyle3 = New AltTrackr2.AetherRadioButton()
        Me.radStyle2 = New AltTrackr2.AetherRadioButton()
        Me.AetherButton3 = New AltTrackr2.AetherButton()
        Me.tpSupport = New System.Windows.Forms.TabPage()
        Me.tpFeedback = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlUnsaved.SuspendLayout()
        Me.pnlLoadingMain.SuspendLayout()
        Me.tabContent.SuspendLayout()
        Me.tpLogin.SuspendLayout()
        Me.pnlLIncorrect.SuspendLayout()
        Me.tpHome.SuspendLayout()
        Me.AetherGroupBox1.SuspendLayout()
        Me.tpHistory.SuspendLayout()
        Me.tpBitcoin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AetherGroupBox3.SuspendLayout()
        Me.tpEthereum.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AetherGroupBox4.SuspendLayout()
        Me.tpMonero.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AetherGroupBox5.SuspendLayout()
        Me.tpPrefs.SuspendLayout()
        Me.AetherGroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ImageList1.Images.SetKeyName(24, "")
        Me.ImageList1.Images.SetKeyName(25, "")
        Me.ImageList1.Images.SetKeyName(26, "")
        Me.ImageList1.Images.SetKeyName(27, "")
        Me.ImageList1.Images.SetKeyName(28, "")
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
        Me.btnConfirmCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnConfirmCancel.Depth = 0
        Me.btnConfirmCancel.Location = New System.Drawing.Point(99, 247)
        Me.btnConfirmCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConfirmCancel.Name = "btnConfirmCancel"
        Me.btnConfirmCancel.Primary = True
        Me.btnConfirmCancel.Size = New System.Drawing.Size(84, 23)
        Me.btnConfirmCancel.TabIndex = 18
        Me.btnConfirmCancel.Text = "No, Cancel"
        Me.btnConfirmCancel.UseVisualStyleBackColor = False
        '
        'btnConfirmSave
        '
        Me.btnConfirmSave.Depth = 0
        Me.btnConfirmSave.Location = New System.Drawing.Point(9, 247)
        Me.btnConfirmSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConfirmSave.Name = "btnConfirmSave"
        Me.btnConfirmSave.Primary = True
        Me.btnConfirmSave.Size = New System.Drawing.Size(84, 23)
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
        Me.ilsImg.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ilsImg.ImageSize = New System.Drawing.Size(256, 256)
        Me.ilsImg.TransparentColor = System.Drawing.Color.Transparent
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
        Me.tabContent.Controls.Add(Me.tpBitcoin)
        Me.tabContent.Controls.Add(Me.tpEthereum)
        Me.tabContent.Controls.Add(Me.tpMonero)
        Me.tabContent.Controls.Add(Me.tpSiacoin)
        Me.tabContent.Controls.Add(Me.tpSpacer2)
        Me.tabContent.Controls.Add(Me.tpPrefs)
        Me.tabContent.Controls.Add(Me.tpSupport)
        Me.tabContent.Controls.Add(Me.tpFeedback)
        Me.tabContent.ImageList = Me.ImageList1
        Me.tabContent.ItemSize = New System.Drawing.Size(40, 190)
        Me.tabContent.Location = New System.Drawing.Point(0, 64)
        Me.tabContent.Multiline = True
        Me.tabContent.Name = "tabContent"
        Me.tabContent.SelectedIndex = 0
        Me.tabContent.Size = New System.Drawing.Size(1022, 490)
        Me.tabContent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabContent.TabIndex = 0
        Me.tabContent.UpperText = True
        '
        'tpLogin
        '
        Me.tpLogin.BackColor = System.Drawing.Color.White
        Me.tpLogin.Controls.Add(Me.Label9)
        Me.tpLogin.Controls.Add(Me.btnLLogout)
        Me.tpLogin.Controls.Add(Me.btnLChangeDetails)
        Me.tpLogin.Controls.Add(Me.txtLUsername)
        Me.tpLogin.Controls.Add(Me.txtLPassword)
        Me.tpLogin.Controls.Add(Me.btnLForgot)
        Me.tpLogin.Controls.Add(Me.btnLSignup)
        Me.tpLogin.Controls.Add(Me.btnLLogin)
        Me.tpLogin.Controls.Add(Me.pnlLIncorrect)
        Me.tpLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpLogin.ImageIndex = 25
        Me.tpLogin.Location = New System.Drawing.Point(194, 4)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Size = New System.Drawing.Size(824, 482)
        Me.tpLogin.TabIndex = 11
        Me.tpLogin.Text = "Login"
        '
        'btnLLogout
        '
        Me.btnLLogout.EnabledCalc = True
        Me.btnLLogout.Location = New System.Drawing.Point(334, 432)
        Me.btnLLogout.Name = "btnLLogout"
        Me.btnLLogout.Size = New System.Drawing.Size(157, 23)
        Me.btnLLogout.TabIndex = 9
        Me.btnLLogout.Text = "Logout"
        '
        'btnLChangeDetails
        '
        Me.btnLChangeDetails.EnabledCalc = True
        Me.btnLChangeDetails.Location = New System.Drawing.Point(334, 402)
        Me.btnLChangeDetails.Name = "btnLChangeDetails"
        Me.btnLChangeDetails.Size = New System.Drawing.Size(157, 23)
        Me.btnLChangeDetails.TabIndex = 8
        Me.btnLChangeDetails.Text = "Change Account Details"
        '
        'txtLUsername
        '
        Me.txtLUsername.EnabledCalc = True
        Me.txtLUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtLUsername.Location = New System.Drawing.Point(334, 180)
        Me.txtLUsername.MaxLength = 32767
        Me.txtLUsername.MultiLine = False
        Me.txtLUsername.Name = "txtLUsername"
        Me.txtLUsername.ReadOnly = False
        Me.txtLUsername.Size = New System.Drawing.Size(157, 29)
        Me.txtLUsername.TabIndex = 4
        Me.txtLUsername.Text = "Username"
        Me.txtLUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLUsername.UseSystemPasswordChar = False
        '
        'txtLPassword
        '
        Me.txtLPassword.EnabledCalc = True
        Me.txtLPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtLPassword.Location = New System.Drawing.Point(334, 215)
        Me.txtLPassword.MaxLength = 32767
        Me.txtLPassword.MultiLine = False
        Me.txtLPassword.Name = "txtLPassword"
        Me.txtLPassword.ReadOnly = False
        Me.txtLPassword.Size = New System.Drawing.Size(157, 29)
        Me.txtLPassword.TabIndex = 3
        Me.txtLPassword.Text = "Password"
        Me.txtLPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLPassword.UseSystemPasswordChar = True
        '
        'btnLForgot
        '
        Me.btnLForgot.EnabledCalc = True
        Me.btnLForgot.Location = New System.Drawing.Point(334, 280)
        Me.btnLForgot.Name = "btnLForgot"
        Me.btnLForgot.Size = New System.Drawing.Size(157, 23)
        Me.btnLForgot.TabIndex = 2
        Me.btnLForgot.Text = "Problems signing in?"
        '
        'btnLSignup
        '
        Me.btnLSignup.EnabledCalc = True
        Me.btnLSignup.Location = New System.Drawing.Point(416, 249)
        Me.btnLSignup.Name = "btnLSignup"
        Me.btnLSignup.Size = New System.Drawing.Size(75, 23)
        Me.btnLSignup.TabIndex = 1
        Me.btnLSignup.Text = "Signup"
        '
        'btnLLogin
        '
        Me.btnLLogin.EnabledCalc = True
        Me.btnLLogin.Location = New System.Drawing.Point(334, 250)
        Me.btnLLogin.Name = "btnLLogin"
        Me.btnLLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLLogin.TabIndex = 0
        Me.btnLLogin.Text = "Login"
        '
        'pnlLIncorrect
        '
        Me.pnlLIncorrect.Controls.Add(Me.tagIncorrect2)
        Me.pnlLIncorrect.Controls.Add(Me.tagIncorrect1)
        Me.pnlLIncorrect.Location = New System.Drawing.Point(487, 180)
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
        'tpHome
        '
        Me.tpHome.BackColor = System.Drawing.Color.White
        Me.tpHome.Controls.Add(Me.AetherCircular2)
        Me.tpHome.Controls.Add(Me.AetherCheckBox1)
        Me.tpHome.Controls.Add(Me.AetherButton1)
        Me.tpHome.Controls.Add(Me.AetherRadioButton2)
        Me.tpHome.Controls.Add(Me.AetherRadioButton1)
        Me.tpHome.Controls.Add(Me.AetherTextbox1)
        Me.tpHome.Controls.Add(Me.AetherTag1)
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
        'tpBitcoin
        '
        Me.tpBitcoin.BackColor = System.Drawing.Color.White
        Me.tpBitcoin.Controls.Add(Me.Label3)
        Me.tpBitcoin.Controls.Add(Me.Label6)
        Me.tpBitcoin.Controls.Add(Me.PictureBox1)
        Me.tpBitcoin.Controls.Add(Me.AetherGroupBox3)
        Me.tpBitcoin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpBitcoin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpBitcoin.ImageIndex = 11
        Me.tpBitcoin.Location = New System.Drawing.Point(194, 4)
        Me.tpBitcoin.Name = "tpBitcoin"
        Me.tpBitcoin.Size = New System.Drawing.Size(824, 482)
        Me.tpBitcoin.TabIndex = 2
        Me.tpBitcoin.Tag = "$2587"
        Me.tpBitcoin.Text = "Bitcoin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!)
        Me.Label3.Location = New System.Drawing.Point(415, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 54)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "BITCOIN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(421, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "$2587"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AltTrackr2.My.Resources.Resources.logoBTC
        Me.PictureBox1.Location = New System.Drawing.Point(234, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'AetherGroupBox3
        '
        Me.AetherGroupBox3.Controls.Add(Me.MaterialLabel1)
        Me.AetherGroupBox3.Controls.Add(Me.MaterialLabel2)
        Me.AetherGroupBox3.Controls.Add(Me.MaterialLabel3)
        Me.AetherGroupBox3.Footer = False
        Me.AetherGroupBox3.FooterText = Nothing
        Me.AetherGroupBox3.Location = New System.Drawing.Point(6, 294)
        Me.AetherGroupBox3.Name = "AetherGroupBox3"
        Me.AetherGroupBox3.Size = New System.Drawing.Size(810, 181)
        Me.AetherGroupBox3.TabIndex = 2
        Me.AetherGroupBox3.Text = "Holdings Summary"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(3, 46)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(804, 28)
        Me.MaterialLabel1.TabIndex = 15
        Me.MaterialLabel1.Text = "BTC Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.MaterialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(3, 107)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(804, 71)
        Me.MaterialLabel2.TabIndex = 17
        Me.MaterialLabel2.Text = "Today, you hold 00.00 BTC which is valued at 00.00 AUD at a coin price of 00.00 A" &
    "UD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your initial investment was 00.00 AUD and has matured over 0 months, yieldin" &
    "g profits of 00.00 AUD so far"
        Me.MaterialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(3, 74)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(804, 28)
        Me.MaterialLabel3.TabIndex = 16
        Me.MaterialLabel3.Text = "BTC Holdings - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.MaterialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpEthereum
        '
        Me.tpEthereum.BackColor = System.Drawing.Color.White
        Me.tpEthereum.Controls.Add(Me.Label4)
        Me.tpEthereum.Controls.Add(Me.Label7)
        Me.tpEthereum.Controls.Add(Me.PictureBox2)
        Me.tpEthereum.Controls.Add(Me.AetherGroupBox4)
        Me.tpEthereum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpEthereum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpEthereum.ImageIndex = 23
        Me.tpEthereum.Location = New System.Drawing.Point(194, 4)
        Me.tpEthereum.Name = "tpEthereum"
        Me.tpEthereum.Size = New System.Drawing.Size(824, 482)
        Me.tpEthereum.TabIndex = 3
        Me.tpEthereum.Tag = "$192"
        Me.tpEthereum.Text = "Ethereum"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!)
        Me.Label4.Location = New System.Drawing.Point(386, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 54)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ETHEREUM"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(392, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 30)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "$192"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AltTrackr2.My.Resources.Resources.logoETH
        Me.PictureBox2.Location = New System.Drawing.Point(212, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(163, 163)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'AetherGroupBox4
        '
        Me.AetherGroupBox4.Controls.Add(Me.MaterialLabel4)
        Me.AetherGroupBox4.Controls.Add(Me.MaterialLabel5)
        Me.AetherGroupBox4.Controls.Add(Me.MaterialLabel6)
        Me.AetherGroupBox4.Footer = False
        Me.AetherGroupBox4.FooterText = Nothing
        Me.AetherGroupBox4.Location = New System.Drawing.Point(6, 294)
        Me.AetherGroupBox4.Name = "AetherGroupBox4"
        Me.AetherGroupBox4.Size = New System.Drawing.Size(810, 181)
        Me.AetherGroupBox4.TabIndex = 3
        Me.AetherGroupBox4.Text = "Holdings Summary"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(3, 46)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(804, 28)
        Me.MaterialLabel4.TabIndex = 15
        Me.MaterialLabel4.Text = "ETH Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.MaterialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(3, 107)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(804, 71)
        Me.MaterialLabel5.TabIndex = 17
        Me.MaterialLabel5.Text = "Today, you hold 00.00 ETH which is valued at 00.00 AUD at a coin price of 00.00 A" &
    "UD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your initial investment was 00.00 AUD and has matured over 0 months, yieldin" &
    "g profits of 00.00 AUD so far"
        Me.MaterialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(3, 74)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(804, 28)
        Me.MaterialLabel6.TabIndex = 16
        Me.MaterialLabel6.Text = "ETH Holdings - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.MaterialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpMonero
        '
        Me.tpMonero.BackColor = System.Drawing.Color.White
        Me.tpMonero.Controls.Add(Me.Label8)
        Me.tpMonero.Controls.Add(Me.Label5)
        Me.tpMonero.Controls.Add(Me.PictureBox3)
        Me.tpMonero.Controls.Add(Me.AetherGroupBox5)
        Me.tpMonero.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpMonero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpMonero.ImageIndex = 22
        Me.tpMonero.Location = New System.Drawing.Point(194, 4)
        Me.tpMonero.Name = "tpMonero"
        Me.tpMonero.Size = New System.Drawing.Size(824, 482)
        Me.tpMonero.TabIndex = 4
        Me.tpMonero.Tag = "$47"
        Me.tpMonero.Text = "Monero"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(410, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(211, 30)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "$47"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!)
        Me.Label5.Location = New System.Drawing.Point(404, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 54)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "MONERO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AltTrackr2.My.Resources.Resources.logoXMR
        Me.PictureBox3.Location = New System.Drawing.Point(224, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(169, 163)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'AetherGroupBox5
        '
        Me.AetherGroupBox5.Controls.Add(Me.MaterialLabel7)
        Me.AetherGroupBox5.Controls.Add(Me.MaterialLabel8)
        Me.AetherGroupBox5.Controls.Add(Me.MaterialLabel9)
        Me.AetherGroupBox5.Footer = False
        Me.AetherGroupBox5.FooterText = Nothing
        Me.AetherGroupBox5.Location = New System.Drawing.Point(6, 294)
        Me.AetherGroupBox5.Name = "AetherGroupBox5"
        Me.AetherGroupBox5.Size = New System.Drawing.Size(810, 181)
        Me.AetherGroupBox5.TabIndex = 3
        Me.AetherGroupBox5.Text = "Holdings Summary"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(3, 46)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(804, 28)
        Me.MaterialLabel7.TabIndex = 15
        Me.MaterialLabel7.Text = "XMR Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.MaterialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(3, 107)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(804, 71)
        Me.MaterialLabel8.TabIndex = 17
        Me.MaterialLabel8.Text = "Today, you hold 00.00 XMR which is valued at 00.00 AUD at a coin price of 00.00 A" &
    "UD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your initial investment was 00.00 AUD and has matured over 0 months, yieldin" &
    "g profits of 00.00 AUD so far"
        Me.MaterialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(3, 74)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(804, 28)
        Me.MaterialLabel9.TabIndex = 16
        Me.MaterialLabel9.Text = "XMR Holdings - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.MaterialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpSiacoin
        '
        Me.tpSiacoin.BackColor = System.Drawing.Color.White
        Me.tpSiacoin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpSiacoin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpSiacoin.ImageIndex = 9
        Me.tpSiacoin.Location = New System.Drawing.Point(194, 4)
        Me.tpSiacoin.Name = "tpSiacoin"
        Me.tpSiacoin.Size = New System.Drawing.Size(824, 482)
        Me.tpSiacoin.TabIndex = 10
        Me.tpSiacoin.Text = "Siacoin"
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
        Me.tpPrefs.Controls.Add(Me.AetherGroupBox2)
        Me.tpPrefs.Controls.Add(Me.AetherButton3)
        Me.tpPrefs.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpPrefs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpPrefs.ImageIndex = 14
        Me.tpPrefs.Location = New System.Drawing.Point(194, 4)
        Me.tpPrefs.Name = "tpPrefs"
        Me.tpPrefs.Size = New System.Drawing.Size(824, 482)
        Me.tpPrefs.TabIndex = 7
        Me.tpPrefs.Text = "User Preferences"
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
        Me.AetherGroupBox2.Size = New System.Drawing.Size(810, 156)
        Me.AetherGroupBox2.TabIndex = 5
        Me.AetherGroupBox2.Text = "User Interface"
        '
        'AetherButton2
        '
        Me.AetherButton2.EnabledCalc = True
        Me.AetherButton2.Location = New System.Drawing.Point(30, 94)
        Me.AetherButton2.Name = "AetherButton2"
        Me.AetherButton2.Size = New System.Drawing.Size(330, 23)
        Me.AetherButton2.TabIndex = 1
        Me.AetherButton2.Text = "Create Custom Colour Scheme..."
        '
        'radStyle1
        '
        Me.radStyle1.Checked = False
        Me.radStyle1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radStyle1.EnabledCalc = True
        Me.radStyle1.HatchBrush = False
        Me.radStyle1.Location = New System.Drawing.Point(30, 69)
        Me.radStyle1.Name = "radStyle1"
        Me.radStyle1.Size = New System.Drawing.Size(106, 19)
        Me.radStyle1.TabIndex = 1
        Me.radStyle1.Text = "UI Variant #1"
        '
        'radStyle3
        '
        Me.radStyle3.Checked = False
        Me.radStyle3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radStyle3.EnabledCalc = True
        Me.radStyle3.HatchBrush = False
        Me.radStyle3.Location = New System.Drawing.Point(254, 69)
        Me.radStyle3.Name = "radStyle3"
        Me.radStyle3.Size = New System.Drawing.Size(106, 19)
        Me.radStyle3.TabIndex = 3
        Me.radStyle3.Text = "UI Variant #3"
        '
        'radStyle2
        '
        Me.radStyle2.Checked = False
        Me.radStyle2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radStyle2.EnabledCalc = True
        Me.radStyle2.HatchBrush = False
        Me.radStyle2.Location = New System.Drawing.Point(142, 69)
        Me.radStyle2.Name = "radStyle2"
        Me.radStyle2.Size = New System.Drawing.Size(106, 19)
        Me.radStyle2.TabIndex = 2
        Me.radStyle2.Text = "UI Variant #2"
        '
        'AetherButton3
        '
        Me.AetherButton3.EnabledCalc = True
        Me.AetherButton3.Location = New System.Drawing.Point(300, 294)
        Me.AetherButton3.Name = "AetherButton3"
        Me.AetherButton3.Size = New System.Drawing.Size(330, 23)
        Me.AetherButton3.TabIndex = 4
        Me.AetherButton3.Text = "Check Prices"
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
        Me.tpFeedback.Tag = "Beta 1"
        Me.tpFeedback.Text = "Feedback"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.Label9.Location = New System.Drawing.Point(301, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(222, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "LOGIN WITH MYMAEGA"
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
        Me.pnlLoadingMain.ResumeLayout(False)
        Me.tabContent.ResumeLayout(False)
        Me.tpLogin.ResumeLayout(False)
        Me.tpLogin.PerformLayout()
        Me.pnlLIncorrect.ResumeLayout(False)
        Me.tpHome.ResumeLayout(False)
        Me.AetherGroupBox1.ResumeLayout(False)
        Me.tpHistory.ResumeLayout(False)
        Me.tpBitcoin.ResumeLayout(False)
        Me.tpBitcoin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AetherGroupBox3.ResumeLayout(False)
        Me.tpEthereum.ResumeLayout(False)
        Me.tpEthereum.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AetherGroupBox4.ResumeLayout(False)
        Me.tpMonero.ResumeLayout(False)
        Me.tpMonero.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AetherGroupBox5.ResumeLayout(False)
        Me.tpPrefs.ResumeLayout(False)
        Me.AetherGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabContent As AetherTabControl
    Friend WithEvents tpHome As TabPage
    Friend WithEvents AetherRadioButton2 As AetherRadioButton
    Friend WithEvents AetherRadioButton1 As AetherRadioButton
    Friend WithEvents AetherTextbox1 As AetherTextbox
    Friend WithEvents AetherTag1 As AetherTag
    Friend WithEvents AetherGroupBox1 As AetherGroupBox
    Friend WithEvents tpHistory As TabPage
    Friend WithEvents AetherCheckBox1 As AetherCheckBox
    Friend WithEvents AetherButton1 As AetherButton
    Friend WithEvents tpSpacer1 As TabPage
    Friend WithEvents tpBitcoin As TabPage
    Friend WithEvents tpEthereum As TabPage
    Friend WithEvents tpMonero As TabPage
    Friend WithEvents tpSpacer2 As TabPage
    Friend WithEvents tpPrefs As TabPage
    Friend WithEvents tpSupport As TabPage
    Friend WithEvents tpFeedback As TabPage
    Friend WithEvents AetherCircular2 As AetherCircular
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents tpSiacoin As TabPage
    Friend WithEvents AetherButton2 As AetherButton
    Friend WithEvents radStyle3 As AetherRadioButton
    Friend WithEvents radStyle2 As AetherRadioButton
    Friend WithEvents radStyle1 As AetherRadioButton
    Friend WithEvents bkgGetPrices As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblAltPrices As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblFriendlyPrice As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAltHoldings As MaterialSkin.Controls.MaterialLabel
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
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AetherGroupBox4 As AetherGroupBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AetherGroupBox5 As AetherGroupBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
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
End Class
