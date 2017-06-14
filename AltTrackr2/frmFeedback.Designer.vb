<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFeedback
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
        Me.btnPositive = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnNegative = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.picKhaledDislike = New System.Windows.Forms.PictureBox()
        Me.picKhaledLike = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblFeedbackType = New MaterialSkin.Controls.MaterialLabel()
        Me.btnSubmit = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.picKhaledDislike, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKhaledLike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPositive
        '
        Me.btnPositive.Depth = 0
        Me.btnPositive.Location = New System.Drawing.Point(85, 395)
        Me.btnPositive.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPositive.Name = "btnPositive"
        Me.btnPositive.Primary = True
        Me.btnPositive.Size = New System.Drawing.Size(232, 33)
        Me.btnPositive.TabIndex = 0
        Me.btnPositive.Text = "Positive"
        Me.btnPositive.UseVisualStyleBackColor = True
        '
        'btnNegative
        '
        Me.btnNegative.Depth = 0
        Me.btnNegative.Location = New System.Drawing.Point(379, 395)
        Me.btnNegative.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNegative.Name = "btnNegative"
        Me.btnNegative.Primary = True
        Me.btnNegative.Size = New System.Drawing.Size(232, 33)
        Me.btnNegative.TabIndex = 1
        Me.btnNegative.Text = "Negative/Bug Report"
        Me.btnNegative.UseVisualStyleBackColor = True
        '
        'picKhaledDislike
        '
        Me.picKhaledDislike.BackColor = System.Drawing.Color.Transparent
        Me.picKhaledDislike.Image = Global.AltTrackr2.My.Resources.Resources.DJ_Khaled_Snapchat
        Me.picKhaledDislike.Location = New System.Drawing.Point(379, 264)
        Me.picKhaledDislike.Name = "picKhaledDislike"
        Me.picKhaledDislike.Size = New System.Drawing.Size(232, 134)
        Me.picKhaledDislike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKhaledDislike.TabIndex = 3
        Me.picKhaledDislike.TabStop = False
        Me.picKhaledDislike.Visible = False
        '
        'picKhaledLike
        '
        Me.picKhaledLike.BackColor = System.Drawing.Color.Transparent
        Me.picKhaledLike.Image = Global.AltTrackr2.My.Resources.Resources._1392850906_dj_khaled_27
        Me.picKhaledLike.Location = New System.Drawing.Point(154, 231)
        Me.picKhaledLike.Name = "picKhaledLike"
        Me.picKhaledLike.Size = New System.Drawing.Size(162, 167)
        Me.picKhaledLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKhaledLike.TabIndex = 2
        Me.picKhaledLike.TabStop = False
        Me.picKhaledLike.Visible = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 137)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(685, 47)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Hey there! Looks like you want to leave some feedback." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "We just need to know whet" &
    "her the feedback is positive or negative."
        Me.MaterialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFeedbackType
        '
        Me.lblFeedbackType.BackColor = System.Drawing.Color.Transparent
        Me.lblFeedbackType.Depth = 0
        Me.lblFeedbackType.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFeedbackType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFeedbackType.Location = New System.Drawing.Point(12, 487)
        Me.lblFeedbackType.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFeedbackType.Name = "lblFeedbackType"
        Me.lblFeedbackType.Size = New System.Drawing.Size(685, 47)
        Me.lblFeedbackType.TabIndex = 5
        Me.lblFeedbackType.Text = "Please select a type of feedback"
        Me.lblFeedbackType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.Depth = 0
        Me.btnSubmit.Location = New System.Drawing.Point(266, 574)
        Me.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Primary = True
        Me.btnSubmit.Size = New System.Drawing.Size(174, 29)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit Feedback"
        Me.btnSubmit.UseVisualStyleBackColor = True
        Me.btnSubmit.Visible = False
        '
        'frmFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 615)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblFeedbackType)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.btnNegative)
        Me.Controls.Add(Me.picKhaledDislike)
        Me.Controls.Add(Me.btnPositive)
        Me.Controls.Add(Me.picKhaledLike)
        Me.Name = "frmFeedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltTrackr Feedback"
        CType(Me.picKhaledDislike, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKhaledLike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPositive As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnNegative As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents picKhaledLike As PictureBox
    Friend WithEvents picKhaledDislike As PictureBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblFeedbackType As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnSubmit As MaterialSkin.Controls.MaterialRaisedButton
End Class
