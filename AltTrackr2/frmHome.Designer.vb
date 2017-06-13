<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Me.lblPrice = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblHoldingsFiat = New MaterialSkin.Controls.MaterialLabel()
        Me.lblHoldingsFiatCodes = New MaterialSkin.Controls.MaterialLabel()
        Me.lblHoldingsCoin = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Depth = 0
        Me.lblPrice.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(477, 240)
        Me.lblPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(411, 45)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "$00.00"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(575, 211)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(223, 29)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Price"
        Me.MaterialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.BackColor = System.Drawing.SystemColors.Control
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(106, 325)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(120, 23)
        Me.MaterialRaisedButton1.TabIndex = 5
        Me.MaterialRaisedButton1.Text = "Add Holdings"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = False
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(245, 325)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(120, 23)
        Me.MaterialRaisedButton2.TabIndex = 6
        Me.MaterialRaisedButton2.Text = "Edit Holdings"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = False
        '
        'lblHoldingsFiat
        '
        Me.lblHoldingsFiat.BackColor = System.Drawing.Color.Transparent
        Me.lblHoldingsFiat.Depth = 0
        Me.lblHoldingsFiat.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblHoldingsFiat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHoldingsFiat.Location = New System.Drawing.Point(12, 240)
        Me.lblHoldingsFiat.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblHoldingsFiat.Name = "lblHoldingsFiat"
        Me.lblHoldingsFiat.Size = New System.Drawing.Size(435, 45)
        Me.lblHoldingsFiat.TabIndex = 7
        Me.lblHoldingsFiat.Text = "$00.00/$00.00"
        Me.lblHoldingsFiat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHoldingsFiatCodes
        '
        Me.lblHoldingsFiatCodes.AutoSize = True
        Me.lblHoldingsFiatCodes.BackColor = System.Drawing.Color.Transparent
        Me.lblHoldingsFiatCodes.Depth = 0
        Me.lblHoldingsFiatCodes.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblHoldingsFiatCodes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHoldingsFiatCodes.Location = New System.Drawing.Point(190, 288)
        Me.lblHoldingsFiatCodes.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblHoldingsFiatCodes.Name = "lblHoldingsFiatCodes"
        Me.lblHoldingsFiatCodes.Size = New System.Drawing.Size(74, 19)
        Me.lblHoldingsFiatCodes.TabIndex = 8
        Me.lblHoldingsFiatCodes.Text = "USD/AUD"
        '
        'lblHoldingsCoin
        '
        Me.lblHoldingsCoin.BackColor = System.Drawing.Color.Transparent
        Me.lblHoldingsCoin.Depth = 0
        Me.lblHoldingsCoin.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblHoldingsCoin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHoldingsCoin.Location = New System.Drawing.Point(12, 187)
        Me.lblHoldingsCoin.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblHoldingsCoin.Name = "lblHoldingsCoin"
        Me.lblHoldingsCoin.Size = New System.Drawing.Size(435, 45)
        Me.lblHoldingsCoin.TabIndex = 9
        Me.lblHoldingsCoin.Text = "0XMR"
        Me.lblHoldingsCoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(631, 325)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(112, 23)
        Me.MaterialRaisedButton3.TabIndex = 10
        Me.MaterialRaisedButton3.Text = "Get Prices"
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.MaterialRaisedButton3)
        Me.Controls.Add(Me.lblHoldingsCoin)
        Me.Controls.Add(Me.lblHoldingsFiatCodes)
        Me.Controls.Add(Me.lblHoldingsFiat)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.lblPrice)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maega AltTrackr 2 - Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrice As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblHoldingsFiat As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblHoldingsFiatCodes As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblHoldingsCoin As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
End Class
