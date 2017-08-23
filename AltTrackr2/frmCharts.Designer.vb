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
        Me.AetherButton1.Location = New System.Drawing.Point(698, 12)
        Me.AetherButton1.Name = "AetherButton1"
        Me.AetherButton1.Size = New System.Drawing.Size(104, 23)
        Me.AetherButton1.TabIndex = 2
        Me.AetherButton1.Text = "AetherButton1"
        '
        'frmCharts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 545)
        Me.Controls.Add(Me.AetherButton1)
        Me.Controls.Add(Me.cartesianChart1)
        Me.Name = "frmCharts"
        Me.Text = "frmCharts"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents cartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents AetherButton1 As AetherButton
End Class
