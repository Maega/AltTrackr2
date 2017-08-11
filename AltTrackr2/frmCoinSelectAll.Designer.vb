<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCoinSelectAll
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
        Me.picCoinLogo = New System.Windows.Forms.PictureBox()
        Me.LvModule = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cxtItem = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.AddToSlot1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToSlot2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToSlot3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToSlot4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReloadAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.prgLoading = New MRG.Controls.UI.LoadingCircle()
        Me.bkgGetData = New System.ComponentModel.BackgroundWorker()
        Me.chkC1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.chkC2 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.chkC3 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.chkC4 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.picCoinLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cxtItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCoinLogo
        '
        Me.picCoinLogo.Location = New System.Drawing.Point(37, 86)
        Me.picCoinLogo.Name = "picCoinLogo"
        Me.picCoinLogo.Size = New System.Drawing.Size(180, 180)
        Me.picCoinLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCoinLogo.TabIndex = 12
        Me.picCoinLogo.TabStop = False
        '
        'LvModule
        '
        Me.LvModule.BackColor = System.Drawing.SystemColors.Window
        Me.LvModule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LvModule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LvModule.ContextMenuStrip = Me.cxtItem
        Me.LvModule.Depth = 0
        Me.LvModule.Font = New System.Drawing.Font("Roboto", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.LvModule.FullRowSelect = True
        Me.LvModule.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvModule.Location = New System.Drawing.Point(270, 68)
        Me.LvModule.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.LvModule.MouseState = MaterialSkin.MouseState.OUT
        Me.LvModule.MultiSelect = False
        Me.LvModule.Name = "LvModule"
        Me.LvModule.OwnerDraw = True
        Me.LvModule.Size = New System.Drawing.Size(653, 390)
        Me.LvModule.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LvModule.TabIndex = 13
        Me.LvModule.UseCompatibleStateImageBehavior = False
        Me.LvModule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Code"
        Me.ColumnHeader5.Width = 140
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 290
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Algorithm"
        Me.ColumnHeader7.Width = 200
        '
        'cxtItem
        '
        Me.cxtItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cxtItem.Depth = 0
        Me.cxtItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToSlot1ToolStripMenuItem, Me.AddToSlot2ToolStripMenuItem, Me.AddToSlot3ToolStripMenuItem, Me.AddToSlot4ToolStripMenuItem, Me.ToolStripSeparator1, Me.ViewInfoToolStripMenuItem, Me.ToolStripSeparator2, Me.ReloadAllToolStripMenuItem})
        Me.cxtItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.cxtItem.Name = "cxtItem"
        Me.cxtItem.Size = New System.Drawing.Size(143, 148)
        '
        'AddToSlot1ToolStripMenuItem
        '
        Me.AddToSlot1ToolStripMenuItem.Name = "AddToSlot1ToolStripMenuItem"
        Me.AddToSlot1ToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AddToSlot1ToolStripMenuItem.Text = "Add to Slot 1"
        '
        'AddToSlot2ToolStripMenuItem
        '
        Me.AddToSlot2ToolStripMenuItem.Name = "AddToSlot2ToolStripMenuItem"
        Me.AddToSlot2ToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AddToSlot2ToolStripMenuItem.Text = "Add to Slot 2"
        '
        'AddToSlot3ToolStripMenuItem
        '
        Me.AddToSlot3ToolStripMenuItem.Name = "AddToSlot3ToolStripMenuItem"
        Me.AddToSlot3ToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AddToSlot3ToolStripMenuItem.Text = "Add to Slot 3"
        '
        'AddToSlot4ToolStripMenuItem
        '
        Me.AddToSlot4ToolStripMenuItem.Name = "AddToSlot4ToolStripMenuItem"
        Me.AddToSlot4ToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AddToSlot4ToolStripMenuItem.Text = "Add to Slot 4"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(139, 6)
        '
        'ViewInfoToolStripMenuItem
        '
        Me.ViewInfoToolStripMenuItem.Name = "ViewInfoToolStripMenuItem"
        Me.ViewInfoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ViewInfoToolStripMenuItem.Text = "View Info"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(139, 6)
        '
        'ReloadAllToolStripMenuItem
        '
        Me.ReloadAllToolStripMenuItem.Name = "ReloadAllToolStripMenuItem"
        Me.ReloadAllToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ReloadAllToolStripMenuItem.Text = "Reload All"
        '
        'txtSearch
        '
        Me.txtSearch.Depth = 0
        Me.txtSearch.Hint = ""
        Me.txtSearch.Location = New System.Drawing.Point(37, 285)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.Size = New System.Drawing.Size(180, 23)
        Me.txtSearch.TabIndex = 15
        Me.txtSearch.TabStop = False
        Me.txtSearch.Text = "Search by Coin Code"
        Me.txtSearch.UseSystemPasswordChar = False
        '
        'prgLoading
        '
        Me.prgLoading.Active = False
        Me.prgLoading.Color = System.Drawing.Color.DarkGray
        Me.prgLoading.InnerCircleRadius = 8
        Me.prgLoading.Location = New System.Drawing.Point(37, 86)
        Me.prgLoading.Name = "prgLoading"
        Me.prgLoading.NumberSpoke = 24
        Me.prgLoading.OuterCircleRadius = 9
        Me.prgLoading.RotationSpeed = 100
        Me.prgLoading.Size = New System.Drawing.Size(180, 180)
        Me.prgLoading.SpokeThickness = 4
        Me.prgLoading.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7
        Me.prgLoading.TabIndex = 18
        Me.prgLoading.Visible = False
        '
        'bkgGetData
        '
        Me.bkgGetData.WorkerSupportsCancellation = True
        '
        'chkC1
        '
        Me.chkC1.AutoCheck = False
        Me.chkC1.BackColor = System.Drawing.Color.Transparent
        Me.chkC1.Depth = 0
        Me.chkC1.Enabled = False
        Me.chkC1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkC1.Location = New System.Drawing.Point(37, 322)
        Me.chkC1.Margin = New System.Windows.Forms.Padding(0)
        Me.chkC1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkC1.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkC1.Name = "chkC1"
        Me.chkC1.Ripple = True
        Me.chkC1.Size = New System.Drawing.Size(180, 30)
        Me.chkC1.TabIndex = 21
        Me.chkC1.Text = "Slot 1: BTC"
        Me.chkC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkC1.UseVisualStyleBackColor = False
        '
        'chkC2
        '
        Me.chkC2.AutoCheck = False
        Me.chkC2.BackColor = System.Drawing.Color.Transparent
        Me.chkC2.Depth = 0
        Me.chkC2.Enabled = False
        Me.chkC2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkC2.Location = New System.Drawing.Point(37, 352)
        Me.chkC2.Margin = New System.Windows.Forms.Padding(0)
        Me.chkC2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkC2.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkC2.Name = "chkC2"
        Me.chkC2.Ripple = True
        Me.chkC2.Size = New System.Drawing.Size(180, 30)
        Me.chkC2.TabIndex = 22
        Me.chkC2.Text = "Slot 2: Unassigned"
        Me.chkC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkC2.UseVisualStyleBackColor = False
        '
        'chkC3
        '
        Me.chkC3.AutoCheck = False
        Me.chkC3.BackColor = System.Drawing.Color.Transparent
        Me.chkC3.Depth = 0
        Me.chkC3.Enabled = False
        Me.chkC3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkC3.Location = New System.Drawing.Point(37, 382)
        Me.chkC3.Margin = New System.Windows.Forms.Padding(0)
        Me.chkC3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkC3.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkC3.Name = "chkC3"
        Me.chkC3.Ripple = True
        Me.chkC3.Size = New System.Drawing.Size(180, 30)
        Me.chkC3.TabIndex = 23
        Me.chkC3.Text = "Slot 3: Unassigned"
        Me.chkC3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkC3.UseVisualStyleBackColor = False
        '
        'chkC4
        '
        Me.chkC4.AutoCheck = False
        Me.chkC4.BackColor = System.Drawing.Color.Transparent
        Me.chkC4.Depth = 0
        Me.chkC4.Enabled = False
        Me.chkC4.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkC4.Location = New System.Drawing.Point(37, 412)
        Me.chkC4.Margin = New System.Windows.Forms.Padding(0)
        Me.chkC4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkC4.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkC4.Name = "chkC4"
        Me.chkC4.Ripple = True
        Me.chkC4.Size = New System.Drawing.Size(180, 30)
        Me.chkC4.TabIndex = 24
        Me.chkC4.Text = "Slot 4: Unassigned"
        Me.chkC4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkC4.UseVisualStyleBackColor = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(811, 26)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(88, 36)
        Me.MaterialRaisedButton1.TabIndex = 26
        Me.MaterialRaisedButton1.Text = "Continue"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'frmCoinSelectAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.chkC4)
        Me.Controls.Add(Me.chkC3)
        Me.Controls.Add(Me.chkC2)
        Me.Controls.Add(Me.chkC1)
        Me.Controls.Add(Me.prgLoading)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.LvModule)
        Me.Controls.Add(Me.picCoinLogo)
        Me.Name = "frmCoinSelectAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coin Manager"
        CType(Me.picCoinLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cxtItem.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCoinLogo As PictureBox
    Friend WithEvents LvModule As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents txtSearch As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents prgLoading As MRG.Controls.UI.LoadingCircle
    Friend WithEvents bkgGetData As System.ComponentModel.BackgroundWorker
    Friend WithEvents chkC1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents chkC2 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents chkC3 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents chkC4 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents cxtItem As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents AddToSlot1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToSlot2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToSlot3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToSlot4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ViewInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ReloadAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
End Class
