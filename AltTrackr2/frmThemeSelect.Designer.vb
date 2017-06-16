<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemeSelect
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
        Me.btnLight = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnDark = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblThemeChoose = New MaterialSkin.Controls.MaterialLabel()
        Me.lblLightHead = New MaterialSkin.Controls.MaterialLabel()
        Me.lblDarkHead = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'btnLight
        '
        Me.btnLight.Depth = 0
        Me.btnLight.Location = New System.Drawing.Point(208, 311)
        Me.btnLight.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLight.Name = "btnLight"
        Me.btnLight.Primary = True
        Me.btnLight.Size = New System.Drawing.Size(200, 41)
        Me.btnLight.TabIndex = 0
        Me.btnLight.Text = "Light Mode"
        Me.btnLight.UseVisualStyleBackColor = True
        '
        'btnDark
        '
        Me.btnDark.Depth = 0
        Me.btnDark.Location = New System.Drawing.Point(481, 311)
        Me.btnDark.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDark.Name = "btnDark"
        Me.btnDark.Primary = True
        Me.btnDark.Size = New System.Drawing.Size(200, 41)
        Me.btnDark.TabIndex = 1
        Me.btnDark.Text = "Dark Mode"
        Me.btnDark.UseVisualStyleBackColor = True
        '
        'lblThemeChoose
        '
        Me.lblThemeChoose.BackColor = System.Drawing.Color.Transparent
        Me.lblThemeChoose.Depth = 0
        Me.lblThemeChoose.Font = New System.Drawing.Font("Roboto Light", 30.0!)
        Me.lblThemeChoose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblThemeChoose.Location = New System.Drawing.Point(12, 155)
        Me.lblThemeChoose.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblThemeChoose.Name = "lblThemeChoose"
        Me.lblThemeChoose.Size = New System.Drawing.Size(876, 55)
        Me.lblThemeChoose.TabIndex = 3
        Me.lblThemeChoose.Text = "Which theme do you prefer?"
        Me.lblThemeChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLightHead
        '
        Me.lblLightHead.BackColor = System.Drawing.Color.Transparent
        Me.lblLightHead.Depth = 0
        Me.lblLightHead.Font = New System.Drawing.Font("Roboto Thin", 10.0!)
        Me.lblLightHead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLightHead.Location = New System.Drawing.Point(208, 294)
        Me.lblLightHead.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLightHead.Name = "lblLightHead"
        Me.lblLightHead.Size = New System.Drawing.Size(200, 17)
        Me.lblLightHead.TabIndex = 4
        Me.lblLightHead.Text = "Preview"
        Me.lblLightHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDarkHead
        '
        Me.lblDarkHead.BackColor = System.Drawing.Color.Transparent
        Me.lblDarkHead.Depth = 0
        Me.lblDarkHead.Font = New System.Drawing.Font("Roboto Thin", 10.0!)
        Me.lblDarkHead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDarkHead.Location = New System.Drawing.Point(481, 294)
        Me.lblDarkHead.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDarkHead.Name = "lblDarkHead"
        Me.lblDarkHead.Size = New System.Drawing.Size(200, 17)
        Me.lblDarkHead.TabIndex = 5
        Me.lblDarkHead.Text = "Preview"
        Me.lblDarkHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmThemeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.lblDarkHead)
        Me.Controls.Add(Me.btnLight)
        Me.Controls.Add(Me.lblLightHead)
        Me.Controls.Add(Me.lblThemeChoose)
        Me.Controls.Add(Me.btnDark)
        Me.Name = "frmThemeSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select a Theme"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLight As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnDark As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblThemeChoose As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblLightHead As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblDarkHead As MaterialSkin.Controls.MaterialLabel
End Class
