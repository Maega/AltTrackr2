<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnContinue = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblWelcome = New MaterialSkin.Controls.MaterialLabel()
        Me.btnSignIn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.bkgLogin = New System.ComponentModel.BackgroundWorker()
        Me.txtUsername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblOr = New MaterialSkin.Controls.MaterialLabel()
        Me.divLogin = New MaterialSkin.Controls.MaterialDivider()
        Me.prgLoading = New MRG.Controls.UI.LoadingCircle()
        Me.SuspendLayout()
        '
        'btnContinue
        '
        Me.btnContinue.Depth = 0
        Me.btnContinue.Location = New System.Drawing.Point(230, 192)
        Me.btnContinue.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Primary = True
        Me.btnContinue.Size = New System.Drawing.Size(239, 23)
        Me.btnContinue.TabIndex = 0
        Me.btnContinue.Text = "Sign in as USER"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.Depth = 0
        Me.lblWelcome.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 101)
        Me.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(689, 62)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome to AltTrackr, USER"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSignIn
        '
        Me.btnSignIn.Depth = 0
        Me.btnSignIn.Location = New System.Drawing.Point(445, 293)
        Me.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Primary = True
        Me.btnSignIn.Size = New System.Drawing.Size(239, 23)
        Me.btnSignIn.TabIndex = 2
        Me.btnSignIn.Text = "Sign in as a different user"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'bkgLogin
        '
        '
        'txtUsername
        '
        Me.txtUsername.Depth = 0
        Me.txtUsername.Hint = ""
        Me.txtUsername.Location = New System.Drawing.Point(29, 293)
        Me.txtUsername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(197, 23)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.Text = "Username"
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'txtPassword
        '
        Me.txtPassword.Depth = 0
        Me.txtPassword.Hint = ""
        Me.txtPassword.Location = New System.Drawing.Point(232, 293)
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(197, 23)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.Text = "Password"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.Depth = 0
        Me.lblOr.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblOr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblOr.Location = New System.Drawing.Point(338, 248)
        Me.lblOr.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(23, 19)
        Me.lblOr.TabIndex = 5
        Me.lblOr.Text = "or"
        '
        'divLogin
        '
        Me.divLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.divLogin.Depth = 0
        Me.divLogin.Location = New System.Drawing.Point(12, 258)
        Me.divLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.divLogin.Name = "divLogin"
        Me.divLogin.Size = New System.Drawing.Size(689, 1)
        Me.divLogin.TabIndex = 6
        Me.divLogin.Text = "MaterialDivider1"
        '
        'prgLoading
        '
        Me.prgLoading.Active = False
        Me.prgLoading.Color = System.Drawing.Color.DarkGray
        Me.prgLoading.InnerCircleRadius = 8
        Me.prgLoading.Location = New System.Drawing.Point(12, 196)
        Me.prgLoading.Name = "prgLoading"
        Me.prgLoading.NumberSpoke = 24
        Me.prgLoading.OuterCircleRadius = 9
        Me.prgLoading.RotationSpeed = 100
        Me.prgLoading.Size = New System.Drawing.Size(689, 120)
        Me.prgLoading.SpokeThickness = 4
        Me.prgLoading.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7
        Me.prgLoading.TabIndex = 13
        Me.prgLoading.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 341)
        Me.Controls.Add(Me.lblOr)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.divLogin)
        Me.Controls.Add(Me.prgLoading)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login to myMaega"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnContinue As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblWelcome As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnSignIn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents bkgLogin As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblOr As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents divLogin As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents prgLoading As MRG.Controls.UI.LoadingCircle
End Class
