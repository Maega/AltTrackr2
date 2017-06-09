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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.lblCoinName = New MaterialSkin.Controls.MaterialLabel()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LinkLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(403, 417)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(92, 19)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Other Coin..."
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
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
        Me.btnNext.Image = Global.AltTrackr2.My.Resources.Resources.arrowRight
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
        Me.btnBack.Image = Global.AltTrackr2.My.Resources.Resources.arrowLeft
        Me.btnBack.Location = New System.Drawing.Point(52, 223)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(32, 73)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBack.TabIndex = 1
        Me.btnBack.TabStop = False
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
        'frmCoinSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.lblCoinName)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmCoinSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Your Coin"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnBack As PictureBox
    Friend WithEvents btnNext As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblCoinName As MaterialSkin.Controls.MaterialLabel
End Class
