<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoinSelectAll
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picCoinLogo = New System.Windows.Forms.PictureBox()
        Me.LvModule = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.picCoinLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCoinLogo
        '
        Me.picCoinLogo.Location = New System.Drawing.Point(636, 85)
        Me.picCoinLogo.Name = "picCoinLogo"
        Me.picCoinLogo.Size = New System.Drawing.Size(200, 200)
        Me.picCoinLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCoinLogo.TabIndex = 12
        Me.picCoinLogo.TabStop = False
        '
        'LvModule
        '
        Me.LvModule.BackColor = System.Drawing.SystemColors.Window
        Me.LvModule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LvModule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LvModule.Depth = 0
        Me.LvModule.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LvModule.FullRowSelect = True
        Me.LvModule.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvModule.Location = New System.Drawing.Point(12, 85)
        Me.LvModule.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.LvModule.MouseState = MaterialSkin.MouseState.OUT
        Me.LvModule.MultiSelect = False
        Me.LvModule.Name = "LvModule"
        Me.LvModule.OwnerDraw = True
        Me.LvModule.Size = New System.Drawing.Size(604, 311)
        Me.LvModule.TabIndex = 13
        Me.LvModule.UseCompatibleStateImageBehavior = False
        Me.LvModule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Code"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 250
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Algorithm"
        Me.ColumnHeader7.Width = 200
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(813, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmCoinSelectAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LvModule)
        Me.Controls.Add(Me.picCoinLogo)
        Me.Name = "frmCoinSelectAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Your Coins"
        CType(Me.picCoinLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCoinLogo As PictureBox
    Friend WithEvents LvModule As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Button2 As Button
End Class
