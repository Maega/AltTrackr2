<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiatSelect
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
        Me.radMUSD = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.radMAUD = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radMEUR = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radMGBP = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txtMOther = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.radAUSD = New MaterialSkin.Controls.MaterialCheckBox()
        Me.radAAUD = New MaterialSkin.Controls.MaterialCheckBox()
        Me.radAEUR = New MaterialSkin.Controls.MaterialCheckBox()
        Me.radAGBP = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtAOther = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnContinue = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlMainFiat = New System.Windows.Forms.Panel()
        Me.pnlAltFiat = New System.Windows.Forms.Panel()
        Me.pnlMainFiat.SuspendLayout()
        Me.pnlAltFiat.SuspendLayout()
        Me.SuspendLayout()
        '
        'radMUSD
        '
        Me.radMUSD.AutoSize = True
        Me.radMUSD.Checked = True
        Me.radMUSD.Depth = 0
        Me.radMUSD.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radMUSD.Location = New System.Drawing.Point(0, 0)
        Me.radMUSD.Margin = New System.Windows.Forms.Padding(0)
        Me.radMUSD.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radMUSD.MouseState = MaterialSkin.MouseState.HOVER
        Me.radMUSD.Name = "radMUSD"
        Me.radMUSD.Ripple = True
        Me.radMUSD.Size = New System.Drawing.Size(55, 30)
        Me.radMUSD.TabIndex = 0
        Me.radMUSD.TabStop = True
        Me.radMUSD.Text = "USD"
        Me.radMUSD.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(170, 159)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(71, 19)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "Main Fiat"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(131, 188)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(144, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "Your 'main' currency"
        '
        'radMAUD
        '
        Me.radMAUD.AutoSize = True
        Me.radMAUD.Depth = 0
        Me.radMAUD.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radMAUD.Location = New System.Drawing.Point(55, 0)
        Me.radMAUD.Margin = New System.Windows.Forms.Padding(0)
        Me.radMAUD.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radMAUD.MouseState = MaterialSkin.MouseState.HOVER
        Me.radMAUD.Name = "radMAUD"
        Me.radMAUD.Ripple = True
        Me.radMAUD.Size = New System.Drawing.Size(56, 30)
        Me.radMAUD.TabIndex = 3
        Me.radMAUD.TabStop = True
        Me.radMAUD.Text = "AUD"
        Me.radMAUD.UseVisualStyleBackColor = True
        '
        'radMEUR
        '
        Me.radMEUR.AutoSize = True
        Me.radMEUR.Depth = 0
        Me.radMEUR.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radMEUR.Location = New System.Drawing.Point(111, 0)
        Me.radMEUR.Margin = New System.Windows.Forms.Padding(0)
        Me.radMEUR.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radMEUR.MouseState = MaterialSkin.MouseState.HOVER
        Me.radMEUR.Name = "radMEUR"
        Me.radMEUR.Ripple = True
        Me.radMEUR.Size = New System.Drawing.Size(54, 30)
        Me.radMEUR.TabIndex = 4
        Me.radMEUR.TabStop = True
        Me.radMEUR.Text = "EUR"
        Me.radMEUR.UseVisualStyleBackColor = True
        '
        'radMGBP
        '
        Me.radMGBP.AutoSize = True
        Me.radMGBP.Depth = 0
        Me.radMGBP.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radMGBP.Location = New System.Drawing.Point(165, 0)
        Me.radMGBP.Margin = New System.Windows.Forms.Padding(0)
        Me.radMGBP.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radMGBP.MouseState = MaterialSkin.MouseState.HOVER
        Me.radMGBP.Name = "radMGBP"
        Me.radMGBP.Ripple = True
        Me.radMGBP.Size = New System.Drawing.Size(56, 30)
        Me.radMGBP.TabIndex = 5
        Me.radMGBP.TabStop = True
        Me.radMGBP.Text = "GBP"
        Me.radMGBP.UseVisualStyleBackColor = True
        '
        'txtMOther
        '
        Me.txtMOther.Depth = 0
        Me.txtMOther.Hint = ""
        Me.txtMOther.Location = New System.Drawing.Point(148, 267)
        Me.txtMOther.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMOther.Name = "txtMOther"
        Me.txtMOther.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMOther.SelectedText = ""
        Me.txtMOther.SelectionLength = 0
        Me.txtMOther.SelectionStart = 0
        Me.txtMOther.Size = New System.Drawing.Size(166, 23)
        Me.txtMOther.TabIndex = 6
        Me.txtMOther.UseSystemPasswordChar = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(93, 267)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(55, 23)
        Me.MaterialLabel3.TabIndex = 7
        Me.MaterialLabel3.Text = "Other:"
        '
        'radAUSD
        '
        Me.radAUSD.AutoSize = True
        Me.radAUSD.Depth = 0
        Me.radAUSD.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radAUSD.Location = New System.Drawing.Point(0, 0)
        Me.radAUSD.Margin = New System.Windows.Forms.Padding(0)
        Me.radAUSD.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radAUSD.MouseState = MaterialSkin.MouseState.HOVER
        Me.radAUSD.Name = "radAUSD"
        Me.radAUSD.Ripple = True
        Me.radAUSD.Size = New System.Drawing.Size(56, 30)
        Me.radAUSD.TabIndex = 8
        Me.radAUSD.Text = "USD"
        Me.radAUSD.UseVisualStyleBackColor = True
        '
        'radAAUD
        '
        Me.radAAUD.AutoSize = True
        Me.radAAUD.Depth = 0
        Me.radAAUD.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radAAUD.Location = New System.Drawing.Point(56, 0)
        Me.radAAUD.Margin = New System.Windows.Forms.Padding(0)
        Me.radAAUD.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radAAUD.MouseState = MaterialSkin.MouseState.HOVER
        Me.radAAUD.Name = "radAAUD"
        Me.radAAUD.Ripple = True
        Me.radAAUD.Size = New System.Drawing.Size(57, 30)
        Me.radAAUD.TabIndex = 9
        Me.radAAUD.Text = "AUD"
        Me.radAAUD.UseVisualStyleBackColor = True
        '
        'radAEUR
        '
        Me.radAEUR.AutoSize = True
        Me.radAEUR.Depth = 0
        Me.radAEUR.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radAEUR.Location = New System.Drawing.Point(113, 0)
        Me.radAEUR.Margin = New System.Windows.Forms.Padding(0)
        Me.radAEUR.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radAEUR.MouseState = MaterialSkin.MouseState.HOVER
        Me.radAEUR.Name = "radAEUR"
        Me.radAEUR.Ripple = True
        Me.radAEUR.Size = New System.Drawing.Size(55, 30)
        Me.radAEUR.TabIndex = 10
        Me.radAEUR.Text = "EUR"
        Me.radAEUR.UseVisualStyleBackColor = True
        '
        'radAGBP
        '
        Me.radAGBP.AutoSize = True
        Me.radAGBP.Depth = 0
        Me.radAGBP.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radAGBP.Location = New System.Drawing.Point(168, 0)
        Me.radAGBP.Margin = New System.Windows.Forms.Padding(0)
        Me.radAGBP.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radAGBP.MouseState = MaterialSkin.MouseState.HOVER
        Me.radAGBP.Name = "radAGBP"
        Me.radAGBP.Ripple = True
        Me.radAGBP.Size = New System.Drawing.Size(57, 30)
        Me.radAGBP.TabIndex = 11
        Me.radAGBP.Text = "GBP"
        Me.radAGBP.UseVisualStyleBackColor = True
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(547, 188)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(242, 19)
        Me.MaterialLabel4.TabIndex = 13
        Me.MaterialLabel4.Text = "Other currencies you'd like to track"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(638, 159)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(57, 19)
        Me.MaterialLabel5.TabIndex = 12
        Me.MaterialLabel5.Text = "Alt Fiat"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(555, 267)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(225, 23)
        Me.MaterialLabel6.TabIndex = 15
        Me.MaterialLabel6.Text = "Others (comma separated):"
        Me.MaterialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAOther
        '
        Me.txtAOther.Depth = 0
        Me.txtAOther.Hint = ""
        Me.txtAOther.Location = New System.Drawing.Point(555, 293)
        Me.txtAOther.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAOther.Name = "txtAOther"
        Me.txtAOther.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAOther.SelectedText = ""
        Me.txtAOther.SelectionLength = 0
        Me.txtAOther.SelectionStart = 0
        Me.txtAOther.Size = New System.Drawing.Size(225, 23)
        Me.txtAOther.TabIndex = 14
        Me.txtAOther.UseSystemPasswordChar = False
        '
        'btnContinue
        '
        Me.btnContinue.Depth = 0
        Me.btnContinue.Location = New System.Drawing.Point(379, 406)
        Me.btnContinue.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Primary = True
        Me.btnContinue.Size = New System.Drawing.Size(143, 23)
        Me.btnContinue.TabIndex = 16
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'pnlMainFiat
        '
        Me.pnlMainFiat.Controls.Add(Me.radMUSD)
        Me.pnlMainFiat.Controls.Add(Me.radMAUD)
        Me.pnlMainFiat.Controls.Add(Me.radMEUR)
        Me.pnlMainFiat.Controls.Add(Me.radMGBP)
        Me.pnlMainFiat.Location = New System.Drawing.Point(93, 224)
        Me.pnlMainFiat.Name = "pnlMainFiat"
        Me.pnlMainFiat.Size = New System.Drawing.Size(230, 33)
        Me.pnlMainFiat.TabIndex = 17
        '
        'pnlAltFiat
        '
        Me.pnlAltFiat.Controls.Add(Me.radAUSD)
        Me.pnlAltFiat.Controls.Add(Me.radAAUD)
        Me.pnlAltFiat.Controls.Add(Me.radAEUR)
        Me.pnlAltFiat.Controls.Add(Me.radAGBP)
        Me.pnlAltFiat.Location = New System.Drawing.Point(555, 224)
        Me.pnlAltFiat.Name = "pnlAltFiat"
        Me.pnlAltFiat.Size = New System.Drawing.Size(225, 33)
        Me.pnlAltFiat.TabIndex = 18
        '
        'frmFiatSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.pnlAltFiat)
        Me.Controls.Add(Me.pnlMainFiat)
        Me.Controls.Add(Me.txtMOther)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.txtAOther)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "frmFiatSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Your Fiat"
        Me.pnlMainFiat.ResumeLayout(False)
        Me.pnlMainFiat.PerformLayout()
        Me.pnlAltFiat.ResumeLayout(False)
        Me.pnlAltFiat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radMUSD As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents radMAUD As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radMEUR As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radMGBP As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txtMOther As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents radAUSD As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents radAAUD As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents radAEUR As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents radAGBP As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtAOther As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnContinue As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents pnlMainFiat As Panel
    Friend WithEvents pnlAltFiat As Panel
End Class
