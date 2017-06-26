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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblFeedbackType = New MaterialSkin.Controls.MaterialLabel()
        Me.btnSubmit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.picKhaledDislike = New System.Windows.Forms.PictureBox()
        Me.picKhaledLike = New System.Windows.Forms.PictureBox()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        CType(Me.picKhaledDislike, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKhaledLike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPositive
        '
        Me.btnPositive.Depth = 0
        Me.btnPositive.Location = New System.Drawing.Point(78, 154)
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
        Me.btnNegative.Location = New System.Drawing.Point(372, 154)
        Me.btnNegative.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNegative.Name = "btnNegative"
        Me.btnNegative.Primary = True
        Me.btnNegative.Size = New System.Drawing.Size(232, 33)
        Me.btnNegative.TabIndex = 1
        Me.btnNegative.Text = "Negative/Bug Report"
        Me.btnNegative.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 90)
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
        Me.lblFeedbackType.Location = New System.Drawing.Point(12, 499)
        Me.lblFeedbackType.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFeedbackType.Name = "lblFeedbackType"
        Me.lblFeedbackType.Size = New System.Drawing.Size(459, 29)
        Me.lblFeedbackType.TabIndex = 5
        Me.lblFeedbackType.Text = "Please select a type of feedback"
        Me.lblFeedbackType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSubmit
        '
        Me.btnSubmit.Depth = 0
        Me.btnSubmit.Location = New System.Drawing.Point(254, 417)
        Me.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Primary = True
        Me.btnSubmit.Size = New System.Drawing.Size(174, 29)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit Feedback"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'picKhaledDislike
        '
        Me.picKhaledDislike.BackColor = System.Drawing.Color.Transparent
        Me.picKhaledDislike.Image = Global.AltTrackr2.My.Resources.Resources.DJ_Khaled_Snapchat
        Me.picKhaledDislike.Location = New System.Drawing.Point(477, 409)
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
        Me.picKhaledLike.Location = New System.Drawing.Point(547, 376)
        Me.picKhaledLike.Name = "picKhaledLike"
        Me.picKhaledLike.Size = New System.Drawing.Size(162, 167)
        Me.picKhaledLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKhaledLike.TabIndex = 2
        Me.picKhaledLike.TabStop = False
        Me.picKhaledLike.Visible = False
        '
        'txtFeedback
        '
        Me.txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFeedback.Enabled = False
        Me.txtFeedback.Location = New System.Drawing.Point(78, 259)
        Me.txtFeedback.Multiline = True
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(526, 152)
        Me.txtFeedback.TabIndex = 7
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(78, 228)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(526, 25)
        Me.MaterialLabel2.TabIndex = 8
        Me.MaterialLabel2.Text = "Your Feedback (Feedback will be associated with your myMaega account)"
        Me.MaterialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 540)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.btnNegative)
        Me.Controls.Add(Me.picKhaledDislike)
        Me.Controls.Add(Me.btnPositive)
        Me.Controls.Add(Me.picKhaledLike)
        Me.Controls.Add(Me.lblFeedbackType)
        Me.Name = "frmFeedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltTrackr Feedback"
        CType(Me.picKhaledDislike, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKhaledLike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPositive As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnNegative As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents picKhaledLike As PictureBox
    Friend WithEvents picKhaledDislike As PictureBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblFeedbackType As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnSubmit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtFeedback As TextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
End Class
