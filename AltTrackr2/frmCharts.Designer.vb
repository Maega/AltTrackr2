<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharts
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
        Me.cartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.AetherButton1 = New AltTrackr2.AetherButton()
        Me.AetherButton2 = New AltTrackr2.AetherButton()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cartesianChart1
        '
        Me.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cartesianChart1.Location = New System.Drawing.Point(0, 0)
        Me.cartesianChart1.Name = "cartesianChart1"
        Me.cartesianChart1.Size = New System.Drawing.Size(896, 545)
        Me.cartesianChart1.TabIndex = 1
        Me.cartesianChart1.Text = "cartesianChart1"
        '
        'AetherButton1
        '
        Me.AetherButton1.EnabledCalc = True
        Me.AetherButton1.Location = New System.Drawing.Point(577, 10)
        Me.AetherButton1.Name = "AetherButton1"
        Me.AetherButton1.Size = New System.Drawing.Size(148, 20)
        Me.AetherButton1.TabIndex = 2
        Me.AetherButton1.Text = "Add Rand Point at End"
        '
        'AetherButton2
        '
        Me.AetherButton2.EnabledCalc = True
        Me.AetherButton2.Location = New System.Drawing.Point(731, 10)
        Me.AetherButton2.Name = "AetherButton2"
        Me.AetherButton2.Size = New System.Drawing.Size(97, 20)
        Me.AetherButton2.TabIndex = 3
        Me.AetherButton2.Text = "Remove Point 0"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(109, 11)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(68, 20)
        Me.NumericUpDown1.TabIndex = 4
        Me.NumericUpDown1.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Maximum Points"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(813, 10)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(53, 20)
        Me.NumericUpDown2.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Location = New System.Drawing.Point(383, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 36)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'frmCharts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 545)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.AetherButton2)
        Me.Controls.Add(Me.AetherButton1)
        Me.Controls.Add(Me.cartesianChart1)
        Me.Name = "frmCharts"
        Me.Text = "Charting Engine - Debugger"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents cartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents AetherButton1 As AetherButton
    Friend WithEvents AetherButton2 As AetherButton
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
End Class
