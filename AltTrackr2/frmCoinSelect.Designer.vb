<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCoinSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCoinSelect))
        Me.btnOtherCoin = New System.Windows.Forms.LinkLabel()
        Me.lblCoinName = New MaterialSkin.Controls.MaterialLabel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.txtOtherCoin = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnOtherContinue = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblOtherCoin = New MaterialSkin.Controls.MaterialLabel()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOtherCoin
        '
        Me.btnOtherCoin.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOtherCoin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOtherCoin.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.btnOtherCoin.LinkColor = System.Drawing.Color.White
        Me.btnOtherCoin.Location = New System.Drawing.Point(403, 417)
        Me.btnOtherCoin.Name = "btnOtherCoin"
        Me.btnOtherCoin.Size = New System.Drawing.Size(92, 19)
        Me.btnOtherCoin.TabIndex = 3
        Me.btnOtherCoin.TabStop = True
        Me.btnOtherCoin.Text = "Other Coin..."
        Me.btnOtherCoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnOtherCoin.VisitedLinkColor = System.Drawing.Color.White
        '
        'lblCoinName
        '
        Me.lblCoinName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCoinName.Depth = 0
        Me.lblCoinName.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCoinName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCoinName.Location = New System.Drawing.Point(328, 77)
        Me.lblCoinName.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCoinName.Name = "lblCoinName"
        Me.lblCoinName.Size = New System.Drawing.Size(245, 30)
        Me.lblCoinName.TabIndex = 4
        Me.lblCoinName.Text = "Monero"
        Me.lblCoinName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogo
        '
        Me.picLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(328, 132)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(245, 239)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(807, 223)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(32, 73)
        Me.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnNext.TabIndex = 2
        Me.btnNext.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(52, 223)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(32, 73)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBack.TabIndex = 1
        Me.btnBack.TabStop = False
        '
        'txtOtherCoin
        '
        Me.txtOtherCoin.Depth = 0
        Me.txtOtherCoin.Hint = ""
        Me.txtOtherCoin.Location = New System.Drawing.Point(328, 426)
        Me.txtOtherCoin.MaxLength = 32767
        Me.txtOtherCoin.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtOtherCoin.Name = "txtOtherCoin"
        Me.txtOtherCoin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOtherCoin.SelectedText = ""
        Me.txtOtherCoin.SelectionLength = 0
        Me.txtOtherCoin.SelectionStart = 0
        Me.txtOtherCoin.Size = New System.Drawing.Size(109, 23)
        Me.txtOtherCoin.TabIndex = 5
        Me.txtOtherCoin.TabStop = False
        Me.txtOtherCoin.UseSystemPasswordChar = False
        Me.txtOtherCoin.Visible = False
        '
        'btnOtherContinue
        '
        Me.btnOtherContinue.AutoSize = True
        Me.btnOtherContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOtherContinue.Depth = 0
        Me.btnOtherContinue.Icon = Nothing
        Me.btnOtherContinue.Location = New System.Drawing.Point(461, 418)
        Me.btnOtherContinue.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnOtherContinue.Name = "btnOtherContinue"
        Me.btnOtherContinue.Primary = True
        Me.btnOtherContinue.Size = New System.Drawing.Size(88, 36)
        Me.btnOtherContinue.TabIndex = 6
        Me.btnOtherContinue.Text = "Continue"
        Me.btnOtherContinue.UseVisualStyleBackColor = True
        Me.btnOtherContinue.Visible = False
        '
        'lblOtherCoin
        '
        Me.lblOtherCoin.AutoSize = True
        Me.lblOtherCoin.Depth = 0
        Me.lblOtherCoin.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblOtherCoin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblOtherCoin.Location = New System.Drawing.Point(316, 396)
        Me.lblOtherCoin.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblOtherCoin.Name = "lblOtherCoin"
        Me.lblOtherCoin.Size = New System.Drawing.Size(265, 19)
        Me.lblOtherCoin.TabIndex = 7
        Me.lblOtherCoin.Text = "Enter a valid coin code (eg: BTC, XMR)"
        Me.lblOtherCoin.Visible = False
        '
        'frmCoinSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.lblOtherCoin)
        Me.Controls.Add(Me.btnOtherContinue)
        Me.Controls.Add(Me.txtOtherCoin)
        Me.Controls.Add(Me.lblCoinName)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnOtherCoin)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmCoinSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Your Coin"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnBack As PictureBox
    Friend WithEvents btnNext As PictureBox
    Friend WithEvents btnOtherCoin As LinkLabel
    Friend WithEvents lblCoinName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtOtherCoin As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnOtherContinue As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblOtherCoin As MaterialSkin.Controls.MaterialLabel
End Class
