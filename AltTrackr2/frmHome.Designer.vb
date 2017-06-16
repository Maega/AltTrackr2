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
        Me.bkgGetPrices = New System.ComponentModel.BackgroundWorker()
        Me.lblAltPrices = New MaterialSkin.Controls.MaterialLabel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.prgLoading = New MRG.Controls.UI.LoadingCircle()
        Me.lblLoading = New MaterialSkin.Controls.MaterialLabel()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Depth = 0
        Me.lblPrice.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(478, 176)
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
        Me.MaterialLabel1.Location = New System.Drawing.Point(576, 147)
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
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(107, 261)
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
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(246, 261)
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
        Me.lblHoldingsFiat.Location = New System.Drawing.Point(13, 176)
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
        Me.lblHoldingsFiatCodes.Location = New System.Drawing.Point(191, 224)
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
        Me.lblHoldingsCoin.Location = New System.Drawing.Point(13, 123)
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
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(634, 261)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(112, 23)
        Me.MaterialRaisedButton3.TabIndex = 10
        Me.MaterialRaisedButton3.Text = "Get Prices"
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'bkgGetPrices
        '
        Me.bkgGetPrices.WorkerReportsProgress = True
        Me.bkgGetPrices.WorkerSupportsCancellation = True
        '
        'lblAltPrices
        '
        Me.lblAltPrices.BackColor = System.Drawing.Color.Transparent
        Me.lblAltPrices.Depth = 0
        Me.lblAltPrices.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAltPrices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAltPrices.Location = New System.Drawing.Point(1, 0)
        Me.lblAltPrices.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAltPrices.Name = "lblAltPrices"
        Me.lblAltPrices.Size = New System.Drawing.Size(900, 28)
        Me.lblAltPrices.TabIndex = 11
        Me.lblAltPrices.Text = "Alternative Fiat Prices"
        Me.lblAltPrices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.MaterialRaisedButton3)
        Me.pnlContent.Controls.Add(Me.lblAltPrices)
        Me.pnlContent.Controls.Add(Me.lblPrice)
        Me.pnlContent.Controls.Add(Me.MaterialLabel1)
        Me.pnlContent.Controls.Add(Me.lblHoldingsCoin)
        Me.pnlContent.Controls.Add(Me.MaterialRaisedButton1)
        Me.pnlContent.Controls.Add(Me.lblHoldingsFiatCodes)
        Me.pnlContent.Controls.Add(Me.MaterialRaisedButton2)
        Me.pnlContent.Controls.Add(Me.lblHoldingsFiat)
        Me.pnlContent.Location = New System.Drawing.Point(0, 64)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(901, 398)
        Me.pnlContent.TabIndex = 12
        '
        'prgLoading
        '
        Me.prgLoading.Active = False
        Me.prgLoading.Color = System.Drawing.Color.DarkGray
        Me.prgLoading.InnerCircleRadius = 8
        Me.prgLoading.Location = New System.Drawing.Point(0, 172)
        Me.prgLoading.Name = "prgLoading"
        Me.prgLoading.NumberSpoke = 24
        Me.prgLoading.OuterCircleRadius = 9
        Me.prgLoading.RotationSpeed = 100
        Me.prgLoading.Size = New System.Drawing.Size(901, 131)
        Me.prgLoading.SpokeThickness = 4
        Me.prgLoading.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7
        Me.prgLoading.TabIndex = 12
        Me.prgLoading.Text = "LoadingCircle1"
        '
        'lblLoading
        '
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.Depth = 0
        Me.lblLoading.Font = New System.Drawing.Font("Roboto Light", 20.0!)
        Me.lblLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLoading.Location = New System.Drawing.Point(0, 299)
        Me.lblLoading.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(901, 59)
        Me.lblLoading.TabIndex = 13
        Me.lblLoading.Text = "Fetching Latest Data..."
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 462)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.prgLoading)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maega AltTrackr 2 - Home"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPrice As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblHoldingsFiat As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblHoldingsFiatCodes As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblHoldingsCoin As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents bkgGetPrices As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblAltPrices As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents prgLoading As MRG.Controls.UI.LoadingCircle
    Friend WithEvents lblLoading As MaterialSkin.Controls.MaterialLabel
End Class
