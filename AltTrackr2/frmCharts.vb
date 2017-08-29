Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.WinForms
Imports LiveCharts.Defaults

Public Class frmCharts
    Dim maxPoints As Integer = 6
    Private Sub frmCharts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Values = New ChartValues(Of Double)() From {3, 4, 6, 3, 2, 6}

        Values = New ChartValues(Of ObservableValue)() From {}
        'New ObservableValue(3),
        'New ObservableValue(4),
        'New ObservableValue(6),
        'New ObservableValue(3),
        'New ObservableValue(2),
        'New ObservableValue(6)
        '}

        Dim lineSeries1 As New LineSeries()
        With lineSeries1
            .Values = Values
            .StrokeThickness = 4
            '.StrokeDashArray = New System.Windows.Media.DoubleCollection(New Double() {2})
            '.Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 69))
            '.Fill = System.Windows.Media.Brushes.Transparent
            .LineSmoothness = 0
            .PointGeometrySize = 18
            .Title = "XMR - High"
        End With

        Dim AxisX As New Axis
        Dim SeparatorX As New Separator
        Dim AxisY As New Axis
        Dim SeparatorY As New Separator

        With SeparatorX
            '.Step = TimeSpan.FromSeconds(1).Ticks
            .StrokeThickness = 1
            .Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
        End With

        With SeparatorY
            .StrokeThickness = 1
            '.StrokeDashArray = New System.Windows.Media.DoubleCollection(New Double() {4})
            .Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
        End With

        AxisX.DisableAnimations = True
        AxisX.IsMerged = True
        AxisX.LabelFormatter = Function(value) New System.DateTime(CLng(value)).ToString("mm:ss")
        AxisX.Separator = SeparatorX

        AxisY.IsMerged = True
        AxisY.Separator = SeparatorY

        'cartesianChart1.AxisX.Add(New Axis() With {
        '.DisableAnimations = True,
        '.LabelFormatter = Function(value) New System.DateTime(CLng(value)).ToString("mm:ss"),
        '.Separator = New Separator() With {.Step = TimeSpan.FromSeconds(1).Ticks}
        '})

        With cartesianChart1
            .Series.Add(lineSeries1)
            '.Series.Add(lineSeries2)
            '.Background = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            .AxisX.Add(AxisX)
            .AxisY.Add(AxisY)
        End With
    End Sub

    Public Property Values() As ChartValues(Of ObservableValue)
        Get
            Return m_Values
        End Get
        Set
            m_Values = Value
        End Set
    End Property
    Private m_Values As ChartValues(Of ObservableValue)

    Private Sub AetherButton1_Click(sender As Object, e As EventArgs) Handles AetherButton1.Click
        Dim r As New Random

        Values.Add(New ObservableValue(r.Next(0, 10))) 'Add new point
        If Values.Count > maxPoints Then Values.RemoveAt(0) 'Remove earliest point if there are more than six
    End Sub

    Private Sub AetherButton2_Click(sender As Object, e As EventArgs) Handles AetherButton2.Click
        Values.RemoveAt(NumericUpDown2.Value)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        maxPoints = NumericUpDown1.Value
        NumericUpDown2.Maximum = maxPoints
    End Sub
End Class