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
        Me.btnNext = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'btnLight
        '
        Me.btnLight.Depth = 0
        Me.btnLight.Location = New System.Drawing.Point(148, 292)
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
        Me.btnDark.Location = New System.Drawing.Point(533, 292)
        Me.btnDark.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDark.Name = "btnDark"
        Me.btnDark.Primary = True
        Me.btnDark.Size = New System.Drawing.Size(200, 41)
        Me.btnDark.TabIndex = 1
        Me.btnDark.Text = "Dark Mode"
        Me.btnDark.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNext.Depth = 0
        Me.btnNext.Location = New System.Drawing.Point(378, 292)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNext.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Primary = False
        Me.btnNext.Size = New System.Drawing.Size(62, 36)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Like it?"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmThemeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnDark)
        Me.Controls.Add(Me.btnLight)
        Me.Name = "frmThemeSelect"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select a Theme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLight As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnDark As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnNext As MaterialSkin.Controls.MaterialFlatButton
End Class
