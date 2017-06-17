<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcomeControls
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.lblWelcome = New MaterialSkin.Controls.MaterialLabel()
        Me.tmrTransition = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Depth = 0
        Me.lblWelcome.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(0, 67)
        Me.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(900, 354)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to AltTrackr"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTransition
        '
        Me.tmrTransition.Enabled = True
        Me.tmrTransition.Interval = 2000
        '
        'frmWelcomeControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblWelcome)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWelcomeControls"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmWelcomeBack"
        Me.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWelcome As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tmrTransition As Timer
End Class
