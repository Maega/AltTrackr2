Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.WinForms
Imports LiveCharts.Defaults

Public Class frmCharts
    Private Sub frmCharts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Values = New ChartValues(Of Double)() From {3, 4, 6, 3, 2, 6}

        Values = New ChartValues(Of ObservableValue)() From {
        New ObservableValue(3),
        New ObservableValue(4),
        New ObservableValue(6),
        New ObservableValue(3),
        New ObservableValue(2),
        New ObservableValue(6)
        }

        Dim lineSeries1 As New LineSeries()
        With lineSeries1
            .Values = New ChartValues(Of Double)() From {5, 3, 5, 7, 3, 9}
            .StrokeThickness = 4
            .StrokeDashArray = New System.Windows.Media.DoubleCollection(New Double() {2})
            .Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 69))
            .Fill = System.Windows.Media.Brushes.Transparent
            .LineSmoothness = 0
            .PointGeometrySize = 0
        End With

        Dim lineSeries2 As New LineSeries()
        With lineSeries2
            .Values = Values
            .StrokeThickness = 2
            .Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(28, 142, 196))
            .Fill = System.Windows.Media.Brushes.Transparent
            .LineSmoothness = 0
            .PointGeometrySize = 15
            .PointForeground = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
        End With

        Dim AxisX As New Axis
        Dim SeparatorX As New Separator

        With SeparatorX
            .StrokeThickness = 1
            .StrokeDashArray = New System.Windows.Media.DoubleCollection(New Double() {2})
            .Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
        End With

        AxisX.IsMerged = True
        AxisX.Separator = SeparatorX

        Dim AxisY As New Axis
        Dim SeparatorY As New Separator

        With SeparatorY
            .StrokeThickness = 1.5
            .StrokeDashArray = New System.Windows.Media.DoubleCollection(New Double() {4})
            .Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
        End With

        AxisY.IsMerged = True
        AxisY.Separator = SeparatorY

        With cartesianChart1
            .Series.Add(lineSeries1)
            .Series.Add(lineSeries2)
            .Background = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
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
        Values.RemoveAt(0) 'Remove earliest point
    End Sub
End Class