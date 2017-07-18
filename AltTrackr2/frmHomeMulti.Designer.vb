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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblLastPriceUpdate = New MaterialSkin.Controls.MaterialLabel()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.AetherButton3 = New AltTrackr2.AetherButton()
        Me.radStyle3 = New AltTrackr2.AetherRadioButton()
        Me.radStyle2 = New AltTrackr2.AetherRadioButton()
        Me.AetherButton2 = New AltTrackr2.AetherButton()
        Me.radStyle1 = New AltTrackr2.AetherRadioButton()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
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
        Me.tabContent.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.AetherGroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.pnlLoading.SuspendLayout()
        Me.pnlLoadingMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabContent
        '
        Me.tabContent.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tabContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabContent.Controls.Add(Me.TabPage1)
        Me.tabContent.Controls.Add(Me.TabPage2)
        Me.tabContent.Controls.Add(Me.TabPage6)
        Me.tabContent.Controls.Add(Me.TabPage3)
        Me.tabContent.Controls.Add(Me.TabPage4)
        Me.tabContent.Controls.Add(Me.TabPage5)
        Me.tabContent.Controls.Add(Me.TabPage11)
        Me.tabContent.Controls.Add(Me.TabPage7)
        Me.tabContent.Controls.Add(Me.TabPage8)
        Me.tabContent.Controls.Add(Me.TabPage9)
        Me.tabContent.Controls.Add(Me.TabPage10)
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
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.AetherCircular2)
        Me.TabPage1.Controls.Add(Me.AetherCheckBox1)
        Me.TabPage1.Controls.Add(Me.AetherButton1)
        Me.TabPage1.Controls.Add(Me.AetherRadioButton2)
        Me.TabPage1.Controls.Add(Me.AetherRadioButton1)
        Me.TabPage1.Controls.Add(Me.AetherTextbox1)
        Me.TabPage1.Controls.Add(Me.AetherTag1)
        Me.TabPage1.Controls.Add(Me.AetherGroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(194, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(824, 482)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
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
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.lblLastPriceUpdate)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage2.ImageIndex = 10
        Me.TabPage2.Location = New System.Drawing.Point(194, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(824, 482)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "History"
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
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage6.Location = New System.Drawing.Point(194, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(824, 482)
        Me.TabPage6.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage3.ImageIndex = 11
        Me.TabPage3.Location = New System.Drawing.Point(194, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(824, 482)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Tag = "$2587"
        Me.TabPage3.Text = "Bitcoin"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage4.ImageIndex = 23
        Me.TabPage4.Location = New System.Drawing.Point(194, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(824, 482)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Tag = "$192"
        Me.TabPage4.Text = "Ethereum"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage5.ImageIndex = 22
        Me.TabPage5.Location = New System.Drawing.Point(194, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(824, 482)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Tag = "$47"
        Me.TabPage5.Text = "Monero"
        '
        'TabPage11
        '
        Me.TabPage11.BackColor = System.Drawing.Color.White
        Me.TabPage11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage11.ImageIndex = 9
        Me.TabPage11.Location = New System.Drawing.Point(194, 4)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(824, 482)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "Siacoin"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.White
        Me.TabPage7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage7.Location = New System.Drawing.Point(194, 4)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(824, 482)
        Me.TabPage7.TabIndex = 6
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.White
        Me.TabPage8.Controls.Add(Me.AetherButton3)
        Me.TabPage8.Controls.Add(Me.radStyle3)
        Me.TabPage8.Controls.Add(Me.radStyle2)
        Me.TabPage8.Controls.Add(Me.AetherButton2)
        Me.TabPage8.Controls.Add(Me.radStyle1)
        Me.TabPage8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage8.ImageIndex = 14
        Me.TabPage8.Location = New System.Drawing.Point(194, 4)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(824, 482)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "User Preferences"
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
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.White
        Me.TabPage9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage9.ImageIndex = 8
        Me.TabPage9.Location = New System.Drawing.Point(194, 4)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(824, 482)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Help & Support"
        '
        'TabPage10
        '
        Me.TabPage10.BackColor = System.Drawing.Color.White
        Me.TabPage10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage10.ImageIndex = 6
        Me.TabPage10.Location = New System.Drawing.Point(194, 4)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(824, 482)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Tag = "Beta 1"
        Me.TabPage10.Text = "Feedback"
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
        Me.prgLoading.Location = New System.Drawing.Point(33, 173)
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
        Me.pnlLoading.Size = New System.Drawing.Size(194, 490)
        Me.pnlLoading.TabIndex = 18
        Me.pnlLoading.Visible = False
        '
        'lblLoading
        '
        Me.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLoading.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!)
        Me.lblLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblLoading.Location = New System.Drawing.Point(5, 284)
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
        'frmHomeMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 554)
        Me.Controls.Add(Me.prgTitleLoad)
        Me.Controls.Add(Me.tabContent)
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.pnlLoadingMain)
        Me.Name = "frmHomeMulti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading Data"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabContent.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.AetherGroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.pnlLoading.ResumeLayout(False)
        Me.pnlLoadingMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabContent As AetherTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents AetherRadioButton2 As AetherRadioButton
    Friend WithEvents AetherRadioButton1 As AetherRadioButton
    Friend WithEvents AetherTextbox1 As AetherTextbox
    Friend WithEvents AetherTag1 As AetherTag
    Friend WithEvents AetherGroupBox1 As AetherGroupBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents AetherCheckBox1 As AetherCheckBox
    Friend WithEvents AetherButton1 As AetherButton
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents AetherCircular2 As AetherCircular
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TabPage11 As TabPage
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
End Class
