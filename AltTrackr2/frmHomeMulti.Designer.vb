﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.tabContent = New AltTrackr2.AetherTabControl()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.pnlLAccount = New System.Windows.Forms.Panel()
        Me.btnLChangeDetails = New AltTrackr2.AetherButton()
        Me.btnLLogout = New AltTrackr2.AetherButton()
        Me.pnlLLogin = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlLIncorrect = New System.Windows.Forms.Panel()
        Me.tagIncorrect2 = New AltTrackr2.AetherTag()
        Me.tagIncorrect1 = New AltTrackr2.AetherTag()
        Me.btnLLogin = New AltTrackr2.AetherButton()
        Me.btnLSignup = New AltTrackr2.AetherButton()
        Me.txtLUsername = New AltTrackr2.AetherTextbox()
        Me.btnLForgot = New AltTrackr2.AetherButton()
        Me.txtLPassword = New AltTrackr2.AetherTextbox()
        Me.tpHome = New System.Windows.Forms.TabPage()
        Me.AetherCircular2 = New AltTrackr2.AetherCircular()
        Me.AetherCheckBox1 = New AltTrackr2.AetherCheckBox()
        Me.AetherButton1 = New AltTrackr2.AetherButton()
        Me.AetherRadioButton2 = New AltTrackr2.AetherRadioButton()
        Me.AetherRadioButton1 = New AltTrackr2.AetherRadioButton()
        Me.AetherTextbox1 = New AltTrackr2.AetherTextbox()
        Me.AetherTag1 = New AltTrackr2.AetherTag()
        Me.AetherGroupBox1 = New AltTrackr2.AetherGroupBox()
        Me.tpHistory = New System.Windows.Forms.TabPage()
        Me.lblLastPriceUpdate = New MaterialSkin.Controls.MaterialLabel()
        Me.tpSpacer1 = New System.Windows.Forms.TabPage()
        Me.tpCoin1 = New System.Windows.Forms.TabPage()
        Me.lblC1Name = New System.Windows.Forms.Label()
        Me.lblC1Price = New System.Windows.Forms.Label()
        Me.picC1Logo = New System.Windows.Forms.PictureBox()
        Me.AetherGroupBox3 = New AltTrackr2.AetherGroupBox()
        Me.lblC1Prices = New MaterialSkin.Controls.MaterialLabel()
        Me.lblC1Friendly = New MaterialSkin.Controls.MaterialLabel()
        Me.lblC1Holdings = New MaterialSkin.Controls.MaterialLabel()
        Me.tpCoin2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AetherGroupBox4 = New AltTrackr2.AetherGroupBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.tpCoin3 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.AetherGroupBox5 = New AltTrackr2.AetherGroupBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.tpCoin4 = New System.Windows.Forms.TabPage()
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
        Me.lblAltHoldings = New System.Windows.Forms.Label()
        Me.lblAltPrices = New System.Windows.Forms.Label()
        Me.pnlUnsaved.SuspendLayout()
        Me.pnlLoadingMain.SuspendLayout()
        Me.tabContent.SuspendLayout()
        Me.tpLogin.SuspendLayout()
        Me.pnlLAccount.SuspendLayout()
        Me.pnlLLogin.SuspendLayout()
        Me.pnlLIncorrect.SuspendLayout()
        Me.tpHome.SuspendLayout()
        Me.AetherGroupBox1.SuspendLayout()
        Me.tpHistory.SuspendLayout()
        Me.tpCoin1.SuspendLayout()
        CType(Me.picC1Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AetherGroupBox3.SuspendLayout()
        Me.tpCoin2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AetherGroupBox4.SuspendLayout()
        Me.tpCoin3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AetherGroupBox5.SuspendLayout()
        Me.tpPrefs.SuspendLayout()
        Me.AetherGroupBox2.SuspendLayout()
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
        Me.pnlLAccount.Controls.Add(Me.btnLChangeDetails)
        Me.pnlLAccount.Controls.Add(Me.btnLLogout)
        Me.pnlLAccount.Location = New System.Drawing.Point(6, 395)
        Me.pnlLAccount.Name = "pnlLAccount"
        Me.pnlLAccount.Size = New System.Drawing.Size(813, 79)
        Me.pnlLAccount.TabIndex = 12
        Me.pnlLAccount.Visible = False
        '
        'btnLChangeDetails
        '
        Me.btnLChangeDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLChangeDetails.EnabledCalc = True
        Me.btnLChangeDetails.Location = New System.Drawing.Point(298, 4)
        Me.btnLChangeDetails.Name = "btnLChangeDetails"
        Me.btnLChangeDetails.Size = New System.Drawing.Size(217, 23)
        Me.btnLChangeDetails.TabIndex = 8
        Me.btnLChangeDetails.Text = "Change Account Details"
        '
        'btnLLogout
        '
        Me.btnLLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLLogout.EnabledCalc = True
        Me.btnLLogout.Location = New System.Drawing.Point(298, 34)
        Me.btnLLogout.Name = "btnLLogout"
        Me.btnLLogout.Size = New System.Drawing.Size(217, 23)
        Me.btnLLogout.TabIndex = 9
        Me.btnLLogout.Text = "Logout"
        '
        'pnlLLogin
        '
        Me.pnlLLogin.Controls.Add(Me.Label9)
        Me.pnlLLogin.Controls.Add(Me.pnlLIncorrect)
        Me.pnlLLogin.Controls.Add(Me.btnLLogin)
        Me.pnlLLogin.Controls.Add(Me.btnLSignup)
        Me.pnlLLogin.Controls.Add(Me.txtLUsername)
        Me.pnlLLogin.Controls.Add(Me.btnLForgot)
        Me.pnlLLogin.Controls.Add(Me.txtLPassword)
        Me.pnlLLogin.Location = New System.Drawing.Point(299, 157)
        Me.pnlLLogin.Name = "pnlLLogin"
        Me.pnlLLogin.Size = New System.Drawing.Size(328, 169)
        Me.pnlLLogin.TabIndex = 11
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
        Me.txtLUsername.TabIndex = 4
        Me.txtLUsername.Text = "Username"
        Me.txtLUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLUsername.UseSystemPasswordChar = False
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
        Me.txtLPassword.TabIndex = 3
        Me.txtLPassword.Text = "Password"
        Me.txtLPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLPassword.UseSystemPasswordChar = True
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
        Me.AetherGroupBox1.Controls.Add(Me.lblAltHoldings)
        Me.AetherGroupBox1.Footer = False
        Me.AetherGroupBox1.FooterText = Nothing
        Me.AetherGroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.AetherGroupBox1.Name = "AetherGroupBox1"
        Me.AetherGroupBox1.Size = New System.Drawing.Size(810, 262)
        Me.AetherGroupBox1.TabIndex = 1
        Me.AetherGroupBox1.Text = "Prices and Holdings"
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
        Me.tpCoin1.ImageIndex = 11
        Me.tpCoin1.Location = New System.Drawing.Point(194, 4)
        Me.tpCoin1.Name = "tpCoin1"
        Me.tpCoin1.Size = New System.Drawing.Size(824, 482)
        Me.tpCoin1.TabIndex = 2
        Me.tpCoin1.Tag = "$2587"
        Me.tpCoin1.Text = "Bitcoin"
        '
        'lblC1Name
        '
        Me.lblC1Name.AutoSize = True
        Me.lblC1Name.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!)
        Me.lblC1Name.Location = New System.Drawing.Point(415, 26)
        Me.lblC1Name.Name = "lblC1Name"
        Me.lblC1Name.Size = New System.Drawing.Size(176, 54)
        Me.lblC1Name.TabIndex = 4
        Me.lblC1Name.Text = "BITCOIN"
        Me.lblC1Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblC1Price
        '
        Me.lblC1Price.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblC1Price.Location = New System.Drawing.Point(421, 73)
        Me.lblC1Price.Name = "lblC1Price"
        Me.lblC1Price.Size = New System.Drawing.Size(176, 30)
        Me.lblC1Price.TabIndex = 5
        Me.lblC1Price.Text = "$2587"
        Me.lblC1Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picC1Logo
        '
        Me.picC1Logo.Image = Global.AltTrackr2.My.Resources.Resources.logoBTC
        Me.picC1Logo.Location = New System.Drawing.Point(234, 26)
        Me.picC1Logo.Name = "picC1Logo"
        Me.picC1Logo.Size = New System.Drawing.Size(170, 163)
        Me.picC1Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picC1Logo.TabIndex = 3
        Me.picC1Logo.TabStop = False
        '
        'AetherGroupBox3
        '
        Me.AetherGroupBox3.Controls.Add(Me.lblC1Prices)
        Me.AetherGroupBox3.Controls.Add(Me.lblC1Friendly)
        Me.AetherGroupBox3.Controls.Add(Me.lblC1Holdings)
        Me.AetherGroupBox3.Footer = False
        Me.AetherGroupBox3.FooterText = Nothing
        Me.AetherGroupBox3.Location = New System.Drawing.Point(6, 294)
        Me.AetherGroupBox3.Name = "AetherGroupBox3"
        Me.AetherGroupBox3.Size = New System.Drawing.Size(810, 181)
        Me.AetherGroupBox3.TabIndex = 2
        Me.AetherGroupBox3.Text = "Holdings Summary"
        '
        'lblC1Prices
        '
        Me.lblC1Prices.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC1Prices.BackColor = System.Drawing.Color.Transparent
        Me.lblC1Prices.Depth = 0
        Me.lblC1Prices.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC1Prices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC1Prices.Location = New System.Drawing.Point(3, 46)
        Me.lblC1Prices.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC1Prices.Name = "lblC1Prices"
        Me.lblC1Prices.Size = New System.Drawing.Size(804, 28)
        Me.lblC1Prices.TabIndex = 15
        Me.lblC1Prices.Text = "BTC Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblC1Prices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'lblC1Holdings
        '
        Me.lblC1Holdings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblC1Holdings.BackColor = System.Drawing.Color.Transparent
        Me.lblC1Holdings.Depth = 0
        Me.lblC1Holdings.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblC1Holdings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblC1Holdings.Location = New System.Drawing.Point(3, 74)
        Me.lblC1Holdings.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblC1Holdings.Name = "lblC1Holdings"
        Me.lblC1Holdings.Size = New System.Drawing.Size(804, 28)
        Me.lblC1Holdings.TabIndex = 16
        Me.lblC1Holdings.Text = "BTC Holdings - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblC1Holdings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpCoin2
        '
        Me.tpCoin2.BackColor = System.Drawing.Color.White
        Me.tpCoin2.Controls.Add(Me.Label4)
        Me.tpCoin2.Controls.Add(Me.Label7)
        Me.tpCoin2.Controls.Add(Me.PictureBox2)
        Me.tpCoin2.Controls.Add(Me.AetherGroupBox4)
        Me.tpCoin2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpCoin2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpCoin2.ImageIndex = 23
        Me.tpCoin2.Location = New System.Drawing.Point(194, 4)
        Me.tpCoin2.Name = "tpCoin2"
        Me.tpCoin2.Size = New System.Drawing.Size(824, 482)
        Me.tpCoin2.TabIndex = 3
        Me.tpCoin2.Tag = "$192"
        Me.tpCoin2.Text = "Ethereum"
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
        'tpCoin3
        '
        Me.tpCoin3.BackColor = System.Drawing.Color.White
        Me.tpCoin3.Controls.Add(Me.Label8)
        Me.tpCoin3.Controls.Add(Me.Label5)
        Me.tpCoin3.Controls.Add(Me.PictureBox3)
        Me.tpCoin3.Controls.Add(Me.AetherGroupBox5)
        Me.tpCoin3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpCoin3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpCoin3.ImageIndex = 22
        Me.tpCoin3.Location = New System.Drawing.Point(194, 4)
        Me.tpCoin3.Name = "tpCoin3"
        Me.tpCoin3.Size = New System.Drawing.Size(824, 482)
        Me.tpCoin3.TabIndex = 4
        Me.tpCoin3.Tag = "$47"
        Me.tpCoin3.Text = "Monero"
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
        'tpCoin4
        '
        Me.tpCoin4.BackColor = System.Drawing.Color.White
        Me.tpCoin4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpCoin4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.tpCoin4.ImageIndex = 9
        Me.tpCoin4.Location = New System.Drawing.Point(194, 4)
        Me.tpCoin4.Name = "tpCoin4"
        Me.tpCoin4.Size = New System.Drawing.Size(824, 482)
        Me.tpCoin4.TabIndex = 10
        Me.tpCoin4.Text = "Siacoin"
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
        'lblAltHoldings
        '
        Me.lblAltHoldings.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblAltHoldings.Location = New System.Drawing.Point(0, 158)
        Me.lblAltHoldings.Name = "lblAltHoldings"
        Me.lblAltHoldings.Size = New System.Drawing.Size(804, 96)
        Me.lblAltHoldings.TabIndex = 7
        Me.lblAltHoldings.Text = "XMR Holdings - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblAltHoldings.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAltPrices
        '
        Me.lblAltPrices.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblAltPrices.Location = New System.Drawing.Point(0, 44)
        Me.lblAltPrices.Name = "lblAltPrices"
        Me.lblAltPrices.Size = New System.Drawing.Size(804, 96)
        Me.lblAltPrices.TabIndex = 16
        Me.lblAltPrices.Text = "XMR Prices - USD: 00.00 | AUD: 00.00 | GBP: 00.00"
        Me.lblAltPrices.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.pnlLAccount.ResumeLayout(False)
        Me.pnlLLogin.ResumeLayout(False)
        Me.pnlLLogin.PerformLayout()
        Me.pnlLIncorrect.ResumeLayout(False)
        Me.tpHome.ResumeLayout(False)
        Me.AetherGroupBox1.ResumeLayout(False)
        Me.tpHistory.ResumeLayout(False)
        Me.tpCoin1.ResumeLayout(False)
        Me.tpCoin1.PerformLayout()
        CType(Me.picC1Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AetherGroupBox3.ResumeLayout(False)
        Me.tpCoin2.ResumeLayout(False)
        Me.tpCoin2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AetherGroupBox4.ResumeLayout(False)
        Me.tpCoin3.ResumeLayout(False)
        Me.tpCoin3.PerformLayout()
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
    Friend WithEvents tpCoin1 As TabPage
    Friend WithEvents tpCoin2 As TabPage
    Friend WithEvents tpCoin3 As TabPage
    Friend WithEvents tpSpacer2 As TabPage
    Friend WithEvents tpPrefs As TabPage
    Friend WithEvents tpSupport As TabPage
    Friend WithEvents tpFeedback As TabPage
    Friend WithEvents AetherCircular2 As AetherCircular
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
    Friend WithEvents lblC1Prices As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblC1Friendly As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblC1Holdings As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AetherGroupBox4 As AetherGroupBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AetherGroupBox5 As AetherGroupBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents picC1Logo As PictureBox
    Friend WithEvents lblC1Name As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblC1Price As Label
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
    Friend WithEvents pnlLAccount As Panel
    Friend WithEvents pnlLLogin As Panel
    Friend WithEvents lblAltPrices As Label
    Friend WithEvents lblAltHoldings As Label
End Class
