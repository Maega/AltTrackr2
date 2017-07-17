'' <summary>
'' Youtube Theme
'' Author : THE LORD
'' Release Date : Monday, June 19, 2017
'' Updated : Wednesday, June 21, 2017
'' HF Account : https://hackforums.net/member.php?action=profile&uid=3304362
'' PM Me for any bug.
'' </summary>

#Region " Namespaces "

Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Drawing.Text

#End Region

#Region " Helper "

Public Module Helpers

#Region " MouseStates "

    ''' <summary>
    ''' The helper enumerator to get mouse states.
    ''' </summary>
    Public Enum MouseMode As Byte
        Normal
        Hovered
        Pushed
        Disabled
    End Enum

#End Region

#Region " Draw Methods "

    ''' <summary>
    ''' The Method to draw the image from encoded base64 string.
    ''' </summary>
    ''' <param name="G">The Graphics to draw the image.</param>
    ''' <param name="Base64Image">The Encoded base64 image.</param>
    ''' <param name="Rect">The Rectangle area for the image.</param>
    Public Sub DrawImageFromBase64(ByVal G As Graphics, ByVal Base64Image As String, ByVal Rect As Rectangle)
        Dim IM As Image = Nothing
        With G
            Using ms As New System.IO.MemoryStream(Convert.FromBase64String(Base64Image))
                IM = Image.FromStream(ms) : ms.Close()
            End Using
            .DrawImage(IM, Rect)
        End With
    End Sub

    ''' <summary>
    ''' The Method to fill rounded rectangle.
    ''' </summary>
    ''' <param name="G">The Graphics to draw the image.</param>
    ''' <param name="C">The Color to the rectangle area.</param>
    ''' <param name="Rect">The Rectangle area to be filled.</param>
    ''' <param name="Curve">The Rounding border radius.</param>
    ''' <param name="TopLeft">Wether the top left of rectangle be round or not.</param>
    ''' <param name="TopRight">Wether the top right of rectangle be round or not.</param>
    ''' <param name="BottomLeft">Wether the bottom left of rectangle be round or not.</param>
    ''' <param name="BottomRight">Wether the bottom right of rectangle be round or not.</param>
    Public Sub FillRoundedPath(ByVal G As Graphics, ByVal C As Color, ByVal Rect As Rectangle, ByVal Curve As Integer,
                                 Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True,
                                 Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True)
        With G
            .FillPath(New SolidBrush(C), RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight))
        End With
    End Sub

    ''' <summary>
    ''' The Method to fill the rounded rectangle.
    ''' </summary>
    ''' <param name="G">The Graphics to fill the rectangle.</param>
    ''' <param name="B">The brush to the rectangle area.</param>
    ''' <param name="Rect">The Rectangle area to be filled.</param>
    ''' <param name="Curve">The Rounding border radius.</param>
    ''' <param name="TopLeft">Wether the top left of rectangle be round or not.</param>
    ''' <param name="TopRight">Wether the top right of rectangle be round or not.</param>
    ''' <param name="BottomLeft">Wether the bottom left of rectangle be round or not.</param>
    ''' <param name="BottomRight">Wether the bottom right of rectangle be round or not.</param>
    Public Sub FillRoundedPath(ByVal G As Graphics, ByVal B As Brush, ByVal Rect As Rectangle, ByVal Curve As Integer,
                                 Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True,
                                 Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True)
        With G
            .FillPath(B, RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight))
        End With
    End Sub

    ''' <summary>
    ''' The Method to fill the rectangle the base color and surrounding with another color(Rectangle with shadow).
    ''' </summary>
    ''' <param name="G">The Graphics to fill the rectangle.</param>
    ''' <param name="CenterColor">The Center color of the rectangle area.</param>
    ''' <param name="SurroundColor">The Inner Surround color of the rectangle area.</param>
    ''' <param name="P">The Point of the surrounding color.</param>
    ''' <param name="Rect">The Rectangle area to be filled.</param>
    ''' <param name="Curve">The Rounding border radius.</param>
    ''' <param name="TopLeft">Wether the top left of rectangle be round or not.</param>
    ''' <param name="TopRight">Wether the top right of rectangle be round or not.</param>
    ''' <param name="BottomLeft">Wether the bottom left of rectangle be round or not.</param>
    ''' <param name="BottomRight">Wether the bottom right of rectangle be round or not.</param>
    Public Sub FillWithInnerRectangle(ByVal G As Graphics, ByVal CenterColor As Color, ByVal SurroundColor As Color, ByVal P As Point, ByVal Rect As Rectangle, ByVal Curve As Integer,
                         Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True,
                         Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True)
        Using PGB As New PathGradientBrush(RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight))
            With PGB
                .CenterColor = CenterColor
                .SurroundColors = New Color() {SurroundColor}
                .FocusScales = P
                With G
                    Dim GP As New GraphicsPath With {.FillMode = FillMode.Winding}
                    GP.AddRectangle(Rect)
                    .FillPath(PGB, GP)
                    GP.Dispose()
                End With
            End With
        End Using
    End Sub

    ''' <summary>
    ''' The Method to fill the circle the base color and surrounding with another color(Rectangle with shadow).
    ''' </summary>
    ''' <param name="G">The Graphics to fill the circle.</param>
    ''' <param name="CenterColor">The Center color of the rectangle area.</param>
    ''' <param name="SurroundColor">The Inner Surround color of the rectangle area.</param>
    ''' <param name="P">The Point of the surrounding color.</param>
    ''' <param name="Rect">The circle area to be filled.</param>
    Public Sub FillWithInnerEllipse(ByVal G As Graphics, ByVal CenterColor As Color, ByVal SurroundColor As Color, ByVal P As Point, ByVal Rect As Rectangle)
        Dim GP As New GraphicsPath With {.FillMode = FillMode.Winding}
        GP.AddEllipse(Rect)
        Using PGB As New PathGradientBrush(GP)
            With PGB
                .CenterColor = CenterColor
                .SurroundColors = New Color() {SurroundColor}
                .FocusScales = P
                With G
                    .FillPath(PGB, GP)
                    GP.Dispose()
                End With
            End With
        End Using
    End Sub

    ''' <summary>
    ''' The Method to fill the rounded rectangle the base color and surrounding with another color(Rectangle with shadow).
    ''' </summary>
    ''' <param name="G">The Graphics to fill rounded the rectangle.</param>
    ''' <param name="CenterColor">The Center color of the rectangle area.</param>
    ''' <param name="SurroundColor">The Inner Surround color of the rectangle area.</param>
    ''' <param name="P">The Point of the surrounding color.</param>
    ''' <param name="Rect">The Rectangle area to be filled.</param>
    ''' <param name="Curve">The Rounding border radius.</param>
    ''' <param name="TopLeft">Wether the top left of rectangle be round or not.</param>
    ''' <param name="TopRight">Wether the top right of rectangle be round or not.</param>
    ''' <param name="BottomLeft">Wether the bottom left of rectangle be round or not.</param>
    ''' <param name="BottomRight">Wether the bottom right of rectangle be round or not.</param>
    Public Sub FillWithInnerRoundedPath(ByVal G As Graphics, ByVal CenterColor As Color, ByVal SurroundColor As Color, ByVal P As Point, ByVal Rect As Rectangle, ByVal Curve As Integer,
                     Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True,
                     Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True)
        Using PGB As New PathGradientBrush(RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight))
            With PGB
                .CenterColor = CenterColor
                .SurroundColors = New Color() {SurroundColor}
                .FocusScales = P
                With G
                    .FillPath(PGB, RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight))
                End With
            End With
        End Using
    End Sub

    ''' <summary>
    ''' The Method to draw the rounded rectangle area.
    ''' </summary>
    ''' <param name="G">The Graphics to draw rounded the rectangle.</param>
    ''' <param name="C">Border Color</param>
    ''' <param name="Size">Border thickness</param>
    ''' <param name="Rect">The Rectangle area to be drawn.</param>
    ''' <param name="Curve">The Rounding border radius.</param>
    ''' <param name="TopLeft">Wether the top left of rectangle be round or not.</param>
    ''' <param name="TopRight">Wether the top right of rectangle be round or not.</param>
    ''' <param name="BottomLeft">Wether the bottom left of rectangle be round or not.</param>
    ''' <param name="BottomRight">Wether the bottom right of rectangle be round or not.</param>
    Public Sub DrawRoundedPath(ByVal G As Graphics, ByVal C As Color, ByVal Size As Single, ByVal Rect As Rectangle, ByVal Curve As Integer,
                                 Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True,
                                 Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True)
        With G
            .DrawPath(New Pen(C, Size), RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight))
        End With
    End Sub

    ''' <summary>
    ''' The method to draw the triangle.
    ''' </summary>
    ''' <param name="G">The Graphics to draw triangle.</param>
    ''' <param name="C">The Triangle Color.</param>
    ''' <param name="Size">The Triangle thickness</param>
    ''' <param name="P1">Point 1</param>
    ''' <param name="P2">Point 2</param>
    ''' <param name="P3">Point 3</param>
    ''' <param name="P4">Point 4</param>
    ''' <param name="P5">Point 5</param>
    ''' <param name="P6">Point 6</param>
    Public Sub DrawTriangle(ByVal G As Graphics, ByVal C As Color, ByVal Size As Integer, ByVal P1 As Point, ByVal P2 As Point, ByVal P3 As Point, ByVal P4 As Point, ByVal P5 As Point, ByVal P6 As Point)
        With G
            .DrawLine(New Pen(C, Size), P1, P2)
            .DrawLine(New Pen(C, Size), P3, P4)
            .DrawLine(New Pen(C, Size), P5, P6)
        End With
    End Sub

    ''' <summary>
    ''' The Method to fill the rectangle with border.
    ''' </summary>
    ''' <param name="G">The Graphics to fill the the rectangle.</param>
    ''' <param name="Rect">The Rectangle to fill.</param>
    ''' <param name="RectColor">The Rectangle color.</param>
    ''' <param name="StrokeColor">The Stroke(Border) color.</param>
    ''' <param name="StrokeSize">The Stroke thickness.</param>
    Public Sub FillStrokedRectangle(ByVal G As Graphics, ByVal Rect As Rectangle, ByVal RectColor As Color, ByVal StrokeColor As Color, Optional ByVal StrokeSize As Integer = 1)
        Using B As New SolidBrush(RectColor), S As New Pen(StrokeColor, StrokeSize)
            G.FillRectangle(B, Rect)
            G.DrawRectangle(S, Rect)
        End Using
    End Sub

    ''' <summary>
    ''' The Method to fill rounded rectangle with border.
    ''' </summary>
    ''' <param name="G">The Graphics to fill rounded the rectangle.</param>
    ''' <param name="Rect">The Rectangle to fill.</param>
    ''' <param name="RectColor">The Rectangle color.</param>
    ''' <param name="StrokeColor">The Stroke(Border) color.</param>
    ''' <param name="StrokeSize">The Stroke thickness.</param>
    ''' <param name="Curve">The Rounding border radius.</param>
    ''' <param name="TopLeft">Wether the top left of rectangle be round or not.</param>
    ''' <param name="TopRight">Wether the top right of rectangle be round or not.</param>
    ''' <param name="BottomLeft">Wether the bottom left of rectangle be round or not.</param>
    ''' <param name="BottomRight">Wether the bottom right of rectangle be round or not.</param>
    Public Sub FillRoundedStrokedRectangle(ByVal G As Graphics, ByVal Rect As Rectangle, ByVal RectColor As Color, ByVal StrokeColor As Color, Optional ByVal StrokeSize As Integer = 1, Optional ByVal curve As Integer = 1,
                                 Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True,
                                 Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True)
        Using B As New SolidBrush(RectColor)
            FillRoundedPath(G, B, Rect, curve, TopLeft, TopRight, BottomLeft, BottomRight)
            DrawRoundedPath(G, StrokeColor, StrokeSize, Rect, curve, TopLeft, TopRight, BottomLeft, BottomRight)
        End Using
    End Sub

    ''' <summary>
    ''' The Method to draw the image with custom color.
    ''' </summary>
    ''' <param name="G"> The Graphic to draw the image.</param>
    ''' <param name="R"> The Rectangle area of image.</param>
    ''' <param name="_Image"> The image that the custom color applies on it.</param>
    ''' <param name="C">The Color that be applied to the image.</param>
    ''' <remarks></remarks>

    Public Sub DrawImageWithColor(ByVal G As Graphics, ByVal R As Rectangle, ByVal _Image As Image, C As Color)
        Dim ptsArray As Single()() = {
            New Single() {Convert.ToSingle(C.R / 255), 0, 0, 0, 0},
            New Single() {0, Convert.ToSingle(C.G / 255), 0, 0, 0},
            New Single() {0, 0, Convert.ToSingle(C.B / 255), 0, 0},
            New Single() {0, 0, 0, Convert.ToSingle(C.A / 255), 0},
            New Single() {Convert.ToSingle(C.R / 255), Convert.ToSingle(C.G / 255), Convert.ToSingle(C.B / 255), 0.0F, Convert.ToSingle(C.A / 255)}}
        Dim imgAttribs As New Imaging.ImageAttributes
        imgAttribs.SetColorMatrix(New Imaging.ColorMatrix(ptsArray), Imaging.ColorMatrixFlag.Default, Imaging.ColorAdjustType.Default)
        G.DrawImage(_Image, R, 0, 0, _Image.Width, _Image.Height, GraphicsUnit.Pixel, imgAttribs)
    End Sub

    ''' <summary>
    ''' The Method to draw the image with custom color.
    ''' </summary>
    ''' <param name="G"> The Graphic to draw the image.</param>
    ''' <param name="R"> The Rectangle area of image.</param>
    ''' <param name="_Image"> The Encoded base64 image that the custom color applies on it.</param>
    ''' <param name="C">The Color that be applied to the image.</param>
    ''' <remarks></remarks>
    Public Sub DrawImageWithColor(ByVal G As Graphics, ByVal R As Rectangle, ByVal _Image As String, C As Color)
        Dim IM As Image = ImageFromBase64(_Image)
        Dim ptsArray As Single()() = {
            New Single() {Convert.ToSingle(C.R / 255), 0, 0, 0, 0},
            New Single() {0, Convert.ToSingle(C.G / 255), 0, 0, 0},
            New Single() {0, 0, Convert.ToSingle(C.B / 255), 0, 0},
            New Single() {0, 0, 0, Convert.ToSingle(C.A / 255), 0},
            New Single() {Convert.ToSingle(C.R / 255), Convert.ToSingle(C.G / 255), Convert.ToSingle(C.B / 255), 0.0F, Convert.ToSingle(C.A / 255)}}
        Dim imgAttribs As New Imaging.ImageAttributes
        imgAttribs.SetColorMatrix(New Imaging.ColorMatrix(ptsArray), Imaging.ColorMatrixFlag.Default, Imaging.ColorAdjustType.Default)
        G.DrawImage(IM, R, 0, 0, IM.Width, IM.Height, GraphicsUnit.Pixel, imgAttribs)
    End Sub

#End Region

#Region " Shapes "

    ''' <summary>
    ''' The Triangle that joins 3 points to the triangle shape.
    ''' </summary>
    ''' <param name="P1">Point 1.</param>
    ''' <param name="P2">Point 2.</param>
    ''' <param name="P3">Point 3.</param>
    ''' <returns>The Trangle shape based on given points.</returns>
    Public Function Triangle(ByVal P1 As Point, ByVal P2 As Point, ByVal P3 As Point) As Point()
        Return New Point() {P1, P2, P3}
    End Function

#End Region

#Region " Brushes "

    ''' <summary>
    ''' The Brush with two colors one center another surounding the center based on the given rectangle area. 
    ''' </summary>
    ''' <param name="CenterColor">The Center color of the rectangle.</param>
    ''' <param name="SurroundColor">The Surrounding color of the rectangle.</param>
    ''' <param name="P">The Point of surrounding.</param>
    ''' <param name="Rect">The Rectangle of the brush.</param>
    ''' <returns>The Brush with two colors one center another surounding the center.</returns>
    Public Function GlowBrush(ByVal CenterColor As Color, ByVal SurroundColor As Color, ByVal P As Point, ByVal Rect As Rectangle) As PathGradientBrush
        Dim GP As New GraphicsPath With {.FillMode = FillMode.Winding}
        GP.AddRectangle(Rect)
        Return New PathGradientBrush(GP) With {.CenterColor = CenterColor, .SurroundColors = New Color() {SurroundColor}, .FocusScales = P}
        GP.Dispose()
    End Function

    ''' <summary>
    ''' The Brush from RGBA color.
    ''' </summary>
    ''' <param name="R">Red.</param>
    ''' <param name="G">Green.</param>
    ''' <param name="B">Blue.</param>
    ''' <param name="A">Alpha.</param>
    ''' <returns>The Brush from given RGBA color.</returns>
    Public Function SolidBrushRGBColor(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer, Optional ByVal A As Integer = 0) As SolidBrush
        Return New SolidBrush(Color.FromArgb(A, R, G, B))
    End Function

    ''' <summary>
    ''' The Brush from HEX color.
    ''' </summary>
    ''' <param name="C_WithoutHash">HEX Color without hash.</param>
    ''' <returns>The Brush from given HEX color.</returns>
    Public Function SolidBrushHTMlColor(ByVal C_WithoutHash As String) As SolidBrush
        Return New SolidBrush(GetHTMLColor(C_WithoutHash))
    End Function

#End Region

#Region " Pens "

    ''' <summary>
    ''' The Pen from RGBA color.
    ''' </summary>
    ''' <param name="R">Red.</param>
    ''' <param name="G">Green.</param>
    ''' <param name="B">Blue.</param>
    ''' <param name="A">Alpha.</param>
    ''' <returns>The Pen from given RGBA color.</returns>
    Public Function PenRGBColor(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer, ByVal A As Integer, ByVal Size As Single) As Pen
        Return New Pen(Color.FromArgb(A, R, G, B), Size)
    End Function

    ''' <summary>
    ''' The Pen from HEX color.
    ''' </summary>
    ''' <param name="C_WithoutHash">HEX Color without hash.</param>
    ''' <param name="Size">The Size of the pen.</param>
    ''' <returns></returns>
    Public Function PenHTMlColor(ByVal C_WithoutHash As String, Optional ByVal Size As Single = 1) As Pen
        Return New Pen(GetHTMLColor(C_WithoutHash), Size)
    End Function

#End Region

#Region " Colors "

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="C_WithoutHash"></param>
    ''' <returns></returns>
    Public Function GetHTMLColor(ByVal C_WithoutHash As String) As Color
        Return ColorTranslator.FromHtml("#" & C_WithoutHash)
    End Function

    ''' <summary>
    ''' The Color from HEX by alpha property.
    ''' </summary>
    ''' <param name="alpha">Alpha.</param>
    ''' <param name="C_WithoutHash">HEX Color without hash.</param>
    ''' <returns>The Color from HEX with given ammount of transparency</returns>
    Public Function GetAlphaHTMLColor(ByVal alpha As Integer, ByVal C_WithoutHash As String) As Color
        Return Color.FromArgb(alpha, ColorTranslator.FromHtml("#" & C_WithoutHash))
    End Function

#End Region

#Region " Methods "

    ''' <summary>
    ''' The String format to provide the alignment.
    ''' </summary>
    ''' <param name="Horizontal">Horizontal alignment.</param>
    ''' <param name="Vertical">Horizontal alignment. alignment.</param>
    ''' <returns>The String format.</returns>
    Public Function SetPosition(Optional ByVal Horizontal As StringAlignment = StringAlignment.Center, Optional ByVal Vertical As StringAlignment = StringAlignment.Center) As StringFormat
        Return New StringFormat() With {.Alignment = Horizontal, .LineAlignment = Vertical}
    End Function

    ''' <summary>
    ''' The Matrix array of single from color.
    ''' </summary>
    ''' <param name="C">The Color.</param>
    ''' <returns>The Matrix array of single from the given color</returns>
    Function ColorToMatrix(ByVal C As Color) As Single()()
        Return New Single()() {
            New Single() {Convert.ToSingle(C.R / 255), 0, 0, 0, 0},
            New Single() {0, Convert.ToSingle(C.G / 255), 0, 0, 0},
            New Single() {0, 0, Convert.ToSingle(C.B / 255), 0, 0},
            New Single() {0, 0, 0, Convert.ToSingle(C.A / 255), 0},
            New Single() {Convert.ToSingle(C.R / 255), Convert.ToSingle(C.G / 255), Convert.ToSingle(C.B / 255), 0.0F, Convert.ToSingle(C.A / 255)}}
    End Function

    ''' <summary>
    ''' The Image from encoded base64 image.
    ''' </summary>
    ''' <param name="Base64Image">The Encoded base64 image</param>
    ''' <returns>The Image from encoded base64.</returns>
    Public Function ImageFromBase64(ByVal Base64Image As String) As Image
        Using ms As New System.IO.MemoryStream(Convert.FromBase64String(Base64Image))
            Return Image.FromStream(ms)
        End Using
    End Function


#End Region

#Region " Round Border "

    ''' <summary>
    ''' Credits : AeonHack
    ''' </summary>

    Public Function RoundRec(ByVal r As Rectangle, ByVal Curve As Integer,
                                 Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True,
                                 Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True) As GraphicsPath
        Dim CreateRoundPath As New GraphicsPath(FillMode.Winding)
        If TopLeft Then
            CreateRoundPath.AddArc(r.X, r.Y, Curve, Curve, 180.0F, 90.0F)
        Else
            CreateRoundPath.AddLine(r.X, r.Y, r.X, r.Y)
        End If
        If TopRight Then
            CreateRoundPath.AddArc(r.Right - Curve, r.Y, Curve, Curve, 270, 90)
        Else
            CreateRoundPath.AddLine(r.Right - r.Width, r.Y, r.Width, r.Y)
        End If
        If BottomRight Then
            CreateRoundPath.AddArc(r.Right - Curve, r.Bottom - Curve, Curve, Curve, 0.0F, 90)
        Else
            CreateRoundPath.AddLine(r.Right, r.Bottom, r.Right, r.Bottom)

        End If
        If BottomLeft Then
            CreateRoundPath.AddArc(r.X, (r.Bottom + r.Y) - Curve, Curve, Curve, 90, 90)
        Else
            CreateRoundPath.AddLine(r.X, r.Bottom, r.X, r.Bottom)
        End If
        CreateRoundPath.CloseFigure()
        Return CreateRoundPath
    End Function

#End Region

End Module

#End Region

#Region " TabControl "

Public Class YoutubeTabControl : Inherits TabControl

#Region " Declarations "

    Dim tabIconHeight As Integer = 18 'Default 14
    Dim tabIconWidth As Integer = 18 'Default 14
    Private R As Rectangle
    Private _LocatedPostion, _ImageLocation, _TextLocation, _HeaderTextLocation As Point


#End Region

#Region " Constructors "

    Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        UpdateStyles()
        SizeMode = TabSizeMode.Fixed
        Dock = DockStyle.None
        ItemSize = New Size(38, 180)
        Alignment = TabAlignment.Left
        Font = New Font("Myriad Pro", 9)
        _LocatedPostion = New Point(-1, -1)
        _ImageLocation = New Point(30, 13)
        _TextLocation = New Point(50, 2)
        _HeaderTextLocation = New Point(16, 5)
    End Sub

#End Region

#Region " Events "

    Protected Overrides Sub OnCreateControl()
        For Each Tab As TabPage In TabPages
            Tab.BackColor = Colors.LightSilver
            Invalidate()
        Next
        MyBase.OnCreateControl()
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        If DesignMode Then Return
        _LocatedPostion = e.Location
        Cursor = Cursors.Hand
        Invalidate()
        MyBase.OnMouseMove(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        _LocatedPostion = New Point(-1, -1)
        Cursor = Cursors.Default
        Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

#End Region

#Region " Properties "

    <Category("Custom"),
    Description("Gets or sets the tab pages image location.")>
    Public Property ImageLocation As Point
        Get
            Return _ImageLocation
        End Get
        Set(value As Point)
            _ImageLocation = value
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
     Description("Gets or sets the tab pages text location.")>
    Public Property TextLocation As Point
        Get
            Return _TextLocation
        End Get
        Set(value As Point)
            _TextLocation = value
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
     Description("Gets or sets the tab pages header text location.")>
    Public Property HeaderTextLocation As Point
        Get
            Return _HeaderTextLocation
        End Get
        Set(value As Point)
            _HeaderTextLocation = value
            Invalidate()
        End Set
    End Property

#End Region

#Region " Draw Control "

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        G.InterpolationMode = InterpolationMode.HighQualityBicubic

        G.FillRectangle(Brushes.White, New Rectangle(0, 0, ItemSize.Height, Height))
        G.FillRectangle(Brushes.LightSilver, New Rectangle(ItemSize.Height, 0, Width, Height))
        Using SF As New StringFormat() With {.LineAlignment = StringAlignment.Center}

            For i As Integer = 0 To TabCount - 1

                R = GetTabRect(i)

                If Not TabPages(i).Tag Is Nothing Then

                    Using F As New Font(Font.Name, 9, FontStyle.Bold)

                        G.DrawString(TabPages(i).Text.ToUpper(), F, Brushes.Red, New Rectangle(R.X + HeaderTextLocation.X, R.Y + HeaderTextLocation.Y, R.Width - 2, R.Height), SF)

                    End Using

                ElseIf i = SelectedIndex Then

                    G.FillRectangle(Brushes.Red, New Rectangle(R.X - 2, R.Y + 2, R.Width - 1, R.Height - 2))

                    G.DrawString(TabPages(i).Text, Font, Brushes.White, New Rectangle(R.X + TextLocation.X, R.Y + TextLocation.Y, R.Width - 2, R.Height), SF)

                Else

                    If R.Contains(_LocatedPostion) Then

                        G.FillRectangle(Brushes.Gray, New Rectangle(R.X - 2, R.Y + 2, R.Width - 1, R.Height - 2))

                        G.DrawString(TabPages(i).Text, Font, Brushes.White, New Rectangle(R.X + TextLocation.X, R.Y + TextLocation.Y, R.Width - 2, R.Height), SF)

                    Else

                        G.DrawString(TabPages(i).Text, Font, Brushes.Gray, New Rectangle(R.X + TextLocation.X, R.Y + TextLocation.Y, R.Width - 2, R.Height), SF)

                    End If

                End If

                If Not ImageList Is Nothing AndAlso ImageList.Images(i) IsNot Nothing AndAlso TabPages(i).Tag Is Nothing Then

                    DrawImageWithColor(G, New Rectangle(R.X + ImageLocation.X, R.Y + ImageLocation.Y, tabIconWidth, tabIconHeight), ImageList.Images(i), If(i = SelectedIndex OrElse R.Contains(_LocatedPostion), Colors.White, Colors.Gray))

                End If

            Next

        End Using

    End Sub

#End Region

End Class

Public Class YoutubeHorizontalTabControl : Inherits TabControl

#Region " Declarations "

    Private _LocatedPostion As Point
    Private R As Rectangle

#End Region

#Region " Constructors "

    Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        UpdateStyles()
        SizeMode = TabSizeMode.Fixed
        Dock = DockStyle.None
        ItemSize = New Size(90, 48)
        Alignment = TabAlignment.Top
        Font = New Font("Myriad Pro", 9)
        _LocatedPostion = New Point(-1, -1)
    End Sub

#End Region

#Region " Events "

    Protected Overrides Sub OnCreateControl()
        For Each Tab As TabPage In TabPages
            Tab.BackColor = Colors.White
            Invalidate()
        Next
        MyBase.OnCreateControl()
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        If DesignMode Then Return
        _LocatedPostion = e.Location
        Cursor = Cursors.Hand
        Invalidate()
        MyBase.OnMouseMove(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        _LocatedPostion = New Point(-1, -1)
        Cursor = Cursors.Default
        Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

#End Region

#Region " Properties "

#End Region

#Region " Draw Control "

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        G.InterpolationMode = InterpolationMode.HighQualityBilinear
        G.CompositingQuality = CompositingQuality.HighQuality

        G.FillRectangle(Brushes.White, New Rectangle(0, 0, Width, ItemSize.Height))
        G.FillRectangle(Brushes.White, New Rectangle(0, ItemSize.Height + 3, Width, Height))
        Using SF As New StringFormat() With {.LineAlignment = StringAlignment.Center}

            For i As Integer = 0 To TabCount - 1

                R = GetTabRect(i)

                If i = SelectedIndex Then

                    G.FillRectangle(Brushes.Red, New Rectangle(R.X - 2, R.Height - 4, R.Width - 1, 4))

                    G.DrawString(TabPages(i).Text, Font, Brushes.DarkGray, R, SetPosition())

                Else

                    If R.Contains(_LocatedPostion) Then

                        G.DrawString(TabPages(i).Text, Font, Brushes.DarkGray, R, SetPosition())

                    Else

                        G.DrawString(TabPages(i).Text, Font, Brushes.Gray, R, SetPosition())

                    End If

                End If
            Next

        End Using

    End Sub

#End Region

End Class

#End Region

#Region " Button "

Public Class YoutubeButton : Inherits Control

#Region " Declarations "

    Private State As MouseMode
    Private _Style As iStyle
    Private _BorderRadius As Integer

#End Region

#Region " Constructors "

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        UpdateStyles()
        BackColor = Color.Transparent
        Font = New Font("Segoe UI", 10)
        _BorderRadius = 0
        _Style = iStyle.Light
        State = MouseMode.Normal
    End Sub

#End Region

#Region " Events "

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseMode.Pushed
        Cursor = Cursors.Hand
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseHover(e As EventArgs)
        MyBase.OnMouseHover(e)
        State = MouseMode.Hovered
        Cursor = Cursors.Hand
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseMode.Normal
        Cursor = Cursors.Default
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseMode.Hovered
        Cursor = Cursors.Hand
        Invalidate()
    End Sub


#End Region

#Region " Properties "

    <Category("Custom"),
    Description("Gets or sets the style for the control.")>
    Public Property Style As iStyle
        Get
            Return _Style
        End Get
        Set(value As iStyle)
            _Style = value
            Invalidate()
        End Set
    End Property

    <Category("Custom"), Description("Gets or sets the rounded corner degree of the control.")>
    Public Property BorderRadius As Integer
        Get
            Return _BorderRadius
        End Get
        Set(value As Integer)
            _BorderRadius = value
            Invalidate()
        End Set
    End Property

#End Region

#Region " Draw Control "

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G As Graphics = e.Graphics, Rect As New Rectangle(0, 0, Width - 1, Height - 1)
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        Dim GP As New GraphicsPath()

        If BorderRadius > 1 Then
            G.SmoothingMode = SmoothingMode.AntiAlias
            GP = RoundRec(Rect, BorderRadius)
        Else
            GP.AddRectangle(Rect)
        End If

        Select Case State
            Case MouseMode.Normal
                G.FillPath(If(Style = iStyle.Light, Brushes.LightSilver, Brushes.Blue), GP)
                G.DrawPath(If(Style = iStyle.Light, Pens.Silver, Pens.LighterBlue), GP)
                G.DrawString(Text, Font, If(Style = iStyle.Light, Brushes.Gray, Brushes.White), Rect, SetPosition())
            Case MouseMode.Hovered
                G.FillPath(If(Style = iStyle.Light, Brushes.Silver, Brushes.LighterBlue), GP)
                G.DrawPath(If(Style = iStyle.Light, Pens.Silver, Pens.Blue), GP)
                G.DrawString(Text, Font, If(Style = iStyle.Light, Brushes.Gray, Brushes.White), Rect, SetPosition())
            Case MouseMode.Pushed
                G.FillPath(If(Style = iStyle.Light, Brushes.LightGray, Brushes.DarkBlue), GP)
                G.DrawPath(If(Style = iStyle.Light, Pens.Silver, Pens.DarkBlue), GP)
                G.DrawString(Text, Font, If(Style = iStyle.Light, Brushes.Gray, Brushes.White), Rect, SetPosition())
        End Select

    End Sub

#End Region

#Region " Enumerators "

    Enum iStyle
        Light
        Blue
    End Enum

#End Region

End Class


#End Region

#Region " ButtonX "

Public Class YoutubeButtonX : Inherits Control

#Region " Declarations "

    Private _LeftText, _RightText As String
    Private RedPart, LightPart As Rectangle
    Private State As MouseMode
    Private _Style As iStyle

#End Region

#Region " Constructors "

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        UpdateStyles()
        BackColor = Color.Transparent
        Font = New Font("Segoe UI", 10)
        _Style = iStyle.Red
        State = MouseMode.Normal
        _LeftText = "12,961,386"
        _RightText = "Subscribe"
    End Sub

#End Region

#Region " Events "

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseMode.Pushed
        Cursor = Cursors.Hand
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseHover(e As EventArgs)
        MyBase.OnMouseHover(e)
        State = MouseMode.Hovered
        Cursor = Cursors.Hand
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseMode.Normal
        Cursor = Cursors.Default
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseMode.Hovered
        Cursor = Cursors.Hand
        Invalidate()
    End Sub


#End Region

#Region " Properties "

    <Category("Custom"),
    Description("Gets or sets the style for the control.")>
    Public Property Style As iStyle
        Get
            Return _Style
        End Get
        Set(value As iStyle)
            _Style = value
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets the text of the left side of the control.")>
    Public Property LeftText As String
        Get
            Return _LeftText
        End Get
        Set(value As String)
            _LeftText = value
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets the text of the right side of the control.")>
    Public Property RightText As String
        Get
            Return _RightText
        End Get
        Set(value As String)
            _RightText = value
            Invalidate()
        End Set
    End Property

#End Region

#Region " Draw Control "

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G As Graphics = e.Graphics, Rect As New Rectangle(0, 0, Width - 1, Height - 1)
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        G.SmoothingMode = SmoothingMode.AntiAlias
        RedPart = New Rectangle(0, 0, Width / 2, Height)
        LightPart = New Rectangle(Width / 2, 0, Width - Width / 2, Height)

        Select Case State

            Case MouseMode.Normal
                G.FillPath(If(Style = iStyle.Red, Brushes.Red, Brushes.Blue), RoundRec(RedPart, 6, True, False, True, False))
                G.FillRectangle(Brushes.LightSilver, LightPart)
                G.DrawLine(Pens.Silver, Convert.ToInt32(Width / 2), 0, Convert.ToInt32(Width - 1), 0)
                G.DrawLine(Pens.Silver, Convert.ToInt32(Width / 2), Height - 1, Width, Height - 1)
                G.DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height)
                G.DrawString(RightText, Font, Brushes.White, RedPart, SetPosition())
                G.DrawString(LeftText, Font, Brushes.Gray, LightPart, SetPosition())
            Case MouseMode.Hovered
                G.FillPath(If(Style = iStyle.Red, Brushes.LightRed, Brushes.LighterBlue), RoundRec(RedPart, 6, True, False, True, False))
                G.FillRectangle(Brushes.LightSilver, LightPart)
                G.DrawLine(Pens.Silver, Convert.ToInt32(Width / 2), 0, Convert.ToInt32(Width - 1), 0)
                G.DrawLine(Pens.Silver, Convert.ToInt32(Width / 2), Height - 1, Width, Height - 1)
                G.DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height)
                G.DrawString(RightText, Font, Brushes.White, RedPart, SetPosition())
                G.DrawString(LeftText, Font, Brushes.Gray, LightPart, SetPosition())
            Case MouseMode.Pushed
                G.FillPath(If(Style = iStyle.Red, Brushes.DarkRed, Brushes.DarkBlue), RoundRec(RedPart, 6, True, False, True, False))
                G.FillRectangle(Brushes.LightSilver, LightPart)
                G.DrawLine(Pens.Silver, Convert.ToInt32(Width / 2), 0, Convert.ToInt32(Width - 1), 0)
                G.DrawLine(Pens.Silver, Convert.ToInt32(Width / 2), Height - 1, Width, Height - 1)
                G.DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height)
                G.DrawString(RightText, Font, Brushes.White, RedPart, SetPosition())
                G.DrawString(LeftText, Font, Brushes.Gray, LightPart, SetPosition())
        End Select

    End Sub

#End Region

#Region " Enumerators "

    Enum iStyle
        Blue
        Red
    End Enum

#End Region

End Class


#End Region

#Region " TextBox "

<DefaultEvent("TextChanged")> Public Class YoutubeTextbox : Inherits Control

#Region " Declarations "

    Private WithEvents T As New TextBox()
    Private _TextAlign As HorizontalAlignment
    Private _MaxLength As Integer
    Private _ReadOnly, _Multiline, _UseSystemPasswordChar As Boolean
    Private _Image As Image
    Private State As MouseMode
    Private _AutoCompleteSource As AutoCompleteSource, _AutoCompleteMode As AutoCompleteMode
    Private _AutoCompleteCustomSource As AutoCompleteStringCollection
    Private _Lines As String(), _WatermarkText As String

#End Region

#Region " Native Methods "

    Private Declare Auto Function SendMessage Lib "user32.dll" (hWnd As IntPtr, msg As Integer, wParam As Integer, <System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)> lParam As String) As Int32

#End Region

#Region " Properties "

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    ReadOnly Property BorderStyle As BorderStyle
        Get
            Return BorderStyle.None
        End Get
    End Property

    <Category("Custom"),
    Description("Gets or sets how text is aligned in TextBox control.")>
    Public Overloads Property TextAlign As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If T IsNot Nothing Then
                T.TextAlign = value
            End If
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets how text is aligned in TextBox control.")>
    Public Overloads Property MaxLength As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If T IsNot Nothing Then
                T.MaxLength = value
            End If
            Invalidate()
        End Set
    End Property

    <Browsable(False), [ReadOnly](True)>
    Public Overloads ReadOnly Property BackColor As Color
        Get
            Return Color.Transparent
        End Get
    End Property

    <Category("Custom"),
    Description("Gets or sets the foreground color of the control.")>
    <Browsable(False), [ReadOnly](True)>
    Public Overloads ReadOnly Property ForeColor As Color
        Get
            Return Color.Transparent
        End Get
    End Property

    <Category("Custom"),
    Description("Gets or sets a value indicating whether text in the text box is read-only.")>
    Public Overloads Property [ReadOnly] As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If T IsNot Nothing Then
                T.ReadOnly = value
            End If
        End Set
    End Property

    <Category("Custom"),
     Description("Gets or sets a value indicating whether the text in  TextBox control should appear as the default password character.")>
    Public Overloads Property UseSystemPasswordChar As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If T IsNot Nothing Then
                T.UseSystemPasswordChar = value
            End If
        End Set
    End Property

    <Category("Custom"),
     Description("Gets or sets a value indicating whether this is a multiline System.Windows.Forms.TextBox control.")>
    Public Overloads Property Multiline As Boolean
        Get
            Return _Multiline
        End Get
        Set(value As Boolean)
            _Multiline = value
            If T Is Nothing Then Exit Property
            T.Multiline = value
            If value Then
                T.Height = Height - 10
            Else
                Height = T.Height + 10
            End If
        End Set
    End Property

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overloads ReadOnly Property BackgroundImage As Image
        Get
            Return Nothing
        End Get
    End Property

    <Category("Custom"),
    Description("Gets or sets the current text in  TextBox.")>
    Public Overloads Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If T IsNot Nothing Then
                T.Text = value
            End If
        End Set
    End Property

    <Category("Custom"),
     Description("Gets or sets the text in the System.Windows.Forms.TextBox while being empty.")>
    Public Property WatermarkText As String
        Get
            Return _WatermarkText
        End Get
        Set(value As String)
            _WatermarkText = value
            SendMessage(T.Handle, 5377, 0, value)
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets the image of the control.")>
    Public Property Image As Image
        Get
            Return _Image
        End Get
        Set(value As Image)
            _Image = value
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets a value specifying the source of complete strings used for automatic completion.")>
    Public Property AutoCompleteSource As AutoCompleteSource
        Get
            Return _AutoCompleteSource
        End Get
        Set(value As AutoCompleteSource)
            _AutoCompleteSource = value
            If T IsNot Nothing Then
                T.AutoCompleteSource = value
            End If
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets a value specifying the source of complete strings used for automatic completion.")>
    Public Property AutoCompleteCustomSource As AutoCompleteStringCollection
        Get
            Return _AutoCompleteCustomSource
        End Get
        Set(value As AutoCompleteStringCollection)
            _AutoCompleteCustomSource = value
            If T IsNot Nothing Then
                T.AutoCompleteCustomSource = value
            End If
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets an option that controls how automatic completion works for the TextBox.")>
    Public Property AutoCompleteMode As AutoCompleteMode
        Get
            Return _AutoCompleteMode
        End Get
        Set(value As AutoCompleteMode)
            _AutoCompleteMode = value
            If T IsNot Nothing Then
                T.AutoCompleteMode = value
            End If
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets the font of the text displayed by the control.")>
    Public Overloads Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If T Is Nothing Then Exit Property
            T.Font = value
            T.Location = New Point(5, 5)
            T.Width = Width - 8
            If Not Multiline Then Height = T.Height + 11
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets the lines of text in the control.")>
    Public Property Lines As String()
        Get
            Return _Lines
        End Get
        Set(value As String())
            _Lines = value
            If T Is Nothing Then Exit Property
            T.Lines = value
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets the ContextMenuStrip associated with this control.")>
    Public Overrides Property ContextMenuStrip As ContextMenuStrip
        Get
            Return MyBase.ContextMenuStrip
        End Get
        Set(value As ContextMenuStrip)
            MyBase.ContextMenuStrip = value
            If T Is Nothing Then Return
            T.ContextMenuStrip = value
            Invalidate()
        End Set
    End Property

#End Region

#Region " Constructors "

    Sub New()
        SetStyle(ControlStyles.UserPaint Or
                  ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
                  ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        UpdateStyles()
        _MaxLength = 32767
        _TextAlign = HorizontalAlignment.Left
        _ReadOnly = False
        _UseSystemPasswordChar = False
        _WatermarkText = String.Empty
        _Image = Nothing
        State = MouseMode.Normal
        _AutoCompleteSource = AutoCompleteSource.None
        _AutoCompleteMode = AutoCompleteMode.None
        _Multiline = False
        _Lines = Nothing
        Font = New Font("Segoe UI", 10)
        With T
            .Multiline = False
            .Cursor = Cursors.IBeam
            .BackColor = Colors.White
            .ForeColor = Colors.Silver
            .BorderStyle = BorderStyle.None
            .Location = New Point(7, 8)
            .Font = Font
            .UseSystemPasswordChar = UseSystemPasswordChar
        End With
        Size = New Size(135, 30)
        If Multiline Then
            T.Height = Height - 11
        Else
            Height = T.Height + 11
        End If
    End Sub

#End Region

#Region " Events "

    Public Shadows Event TextChanged As TextChangedEventHandler
    Public Delegate Sub TextChangedEventHandler(sender As Object)

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(T) Then Controls.Add(T)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        T.Size = New Size(Width - 10, Height - 10)
    End Sub

#Region " TextBox MouseEvents "

    Private Sub T_MouseLeave(ByVal sender As Object, e As EventArgs) Handles T.MouseLeave
        State = MouseMode.Normal
        Invalidate()
    End Sub

    Private Sub T_MouseEnter(ByVal sender As Object, e As EventArgs) Handles T.MouseEnter, T.MouseDown, T.MouseHover
        State = MouseMode.Pushed
        Invalidate()
    End Sub

    Private Sub T_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles T.TextChanged
        Text = T.Text
        RaiseEvent TextChanged(Me)
        Invalidate()
    End Sub

    Private Sub T_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles T.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.A Then e.SuppressKeyPress = True
        If e.Control AndAlso e.KeyCode = Keys.C Then
            T.Copy()
            e.SuppressKeyPress = True
        End If
        State = MouseMode.Pushed
        Invalidate()
    End Sub

#End Region

#End Region

#Region " Draw Control "

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        Dim GP As New GraphicsPath, Rect As New Rectangle(0, 0, Width - 1, Height - 1)

        GP.AddRectangle(Rect)

        GP.CloseFigure()
        Using B As New PathGradientBrush(GP) With {.CenterColor = Colors.White, .SurroundColors = New Color() {Colors.LightSilver}, .FocusScales = New PointF(0.98F, 0.75F)}, P As New Pen(Colors.Silver), P2 As New Pen(Colors.Blue)
            Select Case State
                Case MouseMode.Normal
                    G.FillRectangle(B, Rect)
                    G.DrawRectangle(P, Rect)
                Case MouseMode.Pushed
                    G.FillRectangle(B, Rect)
                    G.DrawRectangle(P2, Rect)
            End Select

        End Using

        If Not Image Is Nothing Then
            T.Location = New Point(31, 5)
            T.Width = Width - 60
            G.InterpolationMode = InterpolationMode.HighQualityBicubic
            G.DrawImage(Image, New Rectangle(8, 6, 16, 16))
        Else

            T.Location = New Point(7, 5)
            T.Width = Width - 10

        End If

        GP.Dispose()

    End Sub

#End Region

End Class

#End Region

#Region " Seperator "

Public Class YoutubeSeperator : Inherits Control

#Region " Variables "

    Private _SeperatorStyle As Style
    Private _SeperatorColor As Color

#End Region

#Region " Enumerators "

    Enum Style
        Horizental
        Vertiacal
    End Enum

#End Region

#Region " Properties "

    <Category("Custom"),
    Description("Gets or sets the style for the control.")>
    Public Property SeperatorStyle As Style
        Get
            Return _SeperatorStyle
        End Get
        Set(value As Style)
            _SeperatorStyle = value
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets the color for the control.")>
    Public Property SeperatorColor As Color
        Get
            Return _SeperatorColor
        End Get
        Set(value As Color)
            _SeperatorColor = value
            Invalidate()
        End Set
    End Property

#End Region

#Region " Constructors "

    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        UpdateStyles()
        BackColor = Color.Transparent
        _SeperatorStyle = Style.Horizental
        _SeperatorColor = Colors.Silver
    End Sub

#End Region

#Region " Draw Control "

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        Using P As New Pen(SeperatorColor)
            Select Case SeperatorStyle
                Case Style.Horizental
                    G.DrawLine(P, 0, 1, Width, 1)
                Case Style.Vertiacal
                    G.DrawLine(P, 1, 0, 1, Height)
            End Select
        End Using

    End Sub

#End Region

#Region " Events "

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If SeperatorStyle = Style.Horizental Then
            Height = 4
        Else
            Width = 4
        End If
    End Sub

#End Region

End Class

#End Region

#Region " Label "

<DefaultEvent("TextChanged")> Public Class YoutubeLabel : Inherits Control

#Region " Draw Cotnrol "

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        Using TB As New SolidBrush(ForeColor)
            e.Graphics.DrawString(Text, Font, TB, ClientRectangle)
        End Using
    End Sub

#End Region

#Region " Constructors "

    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        UpdateStyles()
        BackColor = Color.Transparent
        ForeColor = Color.Silver
        Font = New Font("Myriad Pro", 10)
    End Sub

#End Region

#Region " Events "

    Public Shadows Event TextChanged As TextChangedEventHandler
    Public Delegate Sub TextChangedEventHandler(sender As Object)

    Protected Overrides Sub OnResize(e As EventArgs)
        Height = Font.Height
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        RaiseEvent TextChanged(Me)
        Invalidate()
    End Sub

#End Region

End Class

#End Region

#Region " Link Label "
Class YoutubeLinkLabel : Inherits LinkLabel

#Region " Constructors "

    Sub New()
        Font = New Font("Myriad Pro", 10)
        BackColor = Color.Transparent
        LinkColor = Colors.Blue
        ActiveLinkColor = Color.FromArgb(40, 113, 164)
        VisitedLinkColor = Color.FromArgb(29, 83, 120)
        LinkBehavior = LinkBehavior.HoverUnderline
    End Sub

#End Region

End Class

#End Region

#Region " Progress "

<DefaultEvent("ValueChanged"), DefaultProperty("Value")> Public Class YoutubeProgressBar : Inherits Control

#Region " Declarations "

    Private _Value, _Maximum As Integer
    Event ValueChanged(sender As Object)
    Private _Style As iStyle

#End Region

#Region " Constructors "

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or
                       ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        UpdateStyles()
        BackColor = Color.Transparent
        _Maximum = 100
        _Value = 0
        _Style = iStyle.Red
    End Sub

#End Region

#Region " Properties "

    <Category("Custom"),
    Description("Gets or sets the current position of the progressbar.")>
    Public Property Value As Integer
        Get
            If _Value < 0 Then
                Return 0
            Else
                Return _Value
            End If
        End Get
        Set(ByVal Value As Integer)
            If Value > Maximum Then
                Value = Maximum
            End If
            _Value = Value
            RaiseEvent ValueChanged(Me)
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets the maximum value of the progressbar.")>
    Public Property Maximum As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal Value As Integer)
            Select Case Value
                Case Is < _Value
                    _Value = Value
            End Select
            _Maximum = Value
            Invalidate()
        End Set
    End Property

    <Category("Custom"),
    Description("Gets or sets the style for the control.")>
    Public Property Style As iStyle
        Get
            Return _Style
        End Get
        Set(value As iStyle)
            _Style = value
            Invalidate()
        End Set
    End Property

#End Region

#Region " Draw Control "

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

        Dim G As Graphics = e.Graphics, GP As New GraphicsPath

        Dim CurrentValue As Integer = Convert.ToInt32(Value / Maximum * Width)
        Dim Rect As New Rectangle(0, 0, Width, Height)

        G.FillRectangle(Brushes.LightGray, Rect)

        If Not CurrentValue = 0 Then

            G.FillRectangle(If(Style = iStyle.Red, Brushes.Red, Brushes.Blue), New Rectangle(Rect.X, Rect.Y, CurrentValue, Rect.Height))

        End If

        GP.Dispose()
    End Sub

#End Region

#Region " Enumerators "

    Enum iStyle
        Red
        Blue
    End Enum

#End Region

End Class

#End Region

#Region " CheckBox "

<DefaultEvent("CheckedChanged"), DefaultProperty("Checked")>
Public Class YoutubeCheckBox : Inherits Control

#Region " Declarations "

    Private _Checked As Boolean
    Protected State As MouseMode = MouseMode.Normal

#End Region

#Region " Properties "

    <Category("Custom"),
    Description("Gets or set a value indicating whether the control is in the checked state.")>
    Property Checked As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End Set
    End Property

#End Region

#Region " Constructors "

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
     ControlStyles.SupportsTransparentBackColor Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        Cursor = Cursors.Hand
        BackColor = Color.Transparent
        ForeColor = Color.FromArgb(121, 121, 121)
        Font = New Font("Segoe UI", 9)
        UpdateStyles()
    End Sub

#End Region

#Region " Draw Control "

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Dim rect As New Rectangle(0, 0, 18, 17)
        Using F As New Font("Marlett", 14)
            G.FillRectangle(Brushes.LighterSilver, rect)
            If Checked Then G.DrawString("b", F, Brushes.Gray, New Rectangle(-2, 0, Width, Height))
            G.DrawRectangle(Pens.Silver, New Rectangle(0, 0, 17, 16))
            G.DrawString(Text, Font, Brushes.Gray, New Rectangle(18, 2, Width, Height - 4), SetPosition(StringAlignment.Near))
        End Using

    End Sub

#End Region

#Region " Events "

    Event CheckedChanged(ByVal sender As Object)

    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        _Checked = Not Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        Invalidate() : MyBase.OnTextChanged(e)
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Height = 17
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseHover(e As EventArgs)
        MyBase.OnMouseHover(e)
        State = MouseMode.Hovered
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseMode.Normal
        Invalidate()
    End Sub

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

End Class

#End Region

#Region " RadioButton "

<DefaultEvent("CheckedChanged"), DefaultProperty("Checked")> Public Class YoutubeRadioButton : Inherits Control

#Region " Declarations "

    Private _Checked As Boolean
    Protected _Group As Integer

#End Region

#Region " Properties "

    <Category("Custom"),
    Description("Gets or set a value indicating whether the control is in the checked state.")>
    Property Checked As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End Set
    End Property

    <Category("Custom")>
    Property Group As Integer
        Get
            Return _Group
        End Get
        Set(ByVal value As Integer)
            _Group = value
            Invalidate()
        End Set
    End Property

#End Region

#Region " Constructors "

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
    ControlStyles.SupportsTransparentBackColor Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        UpdateStyles()
        Cursor = Cursors.Hand
        BackColor = Color.Transparent
        ForeColor = Color.FromArgb(121, 121, 121)
        Font = New Font("Segoe UI", 9, FontStyle.Regular)
        Group = 1
    End Sub

#End Region

#Region " Draw Control "

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        G.SmoothingMode = SmoothingMode.AntiAlias
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        Using F As New Font("Marlett", 14)
            G.FillEllipse(Brushes.LighterSilver, New Rectangle(0, 0, 21, 21))
            If Checked Then G.FillEllipse(Brushes.Gray, New Rectangle(5, 5, 10, 10))
            G.DrawString(Text, Font, Brushes.Gray, New Rectangle(21, 1, Width, Height - 2), SetPosition(StringAlignment.Near))
            G.DrawEllipse(Pens.Silver, New Rectangle(0, 0, 20, 20))
        End Using

    End Sub

#End Region

#Region " Events "

    Event CheckedChanged(ByVal sender As Object)

    Private Sub UpdateState()
        If Not IsHandleCreated OrElse Not Checked Then Return
        For Each C As Control In Parent.Controls
            If C IsNot Me AndAlso TypeOf C Is YoutubeRadioButton AndAlso DirectCast(C, YoutubeRadioButton).Group = _Group Then
                DirectCast(C, YoutubeRadioButton).Checked = False
            End If
        Next
    End Sub

    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        _Checked = Not Checked
        UpdateState()
        MyBase.OnClick(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnCreateControl()
        UpdateState()
        MyBase.OnCreateControl()
    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        Invalidate() : MyBase.OnTextChanged(e)
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Height = 22
        Invalidate()
    End Sub

#End Region

End Class

#End Region

#Region " ComboBox "

<DefaultEvent("SelectedIndexChanged")> Public Class YoutubeComboBox : Inherits ComboBox

#Region " Declarations "

    Private _StartIndex As Integer = 0
    Shadows Event SelectedIndexChanged(ByVal sender As Object)

#End Region

#Region " Constructors "

    Sub New()

        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or
                  ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        Font = New Font("Segoe UI", 11)
        DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        DoubleBuffered = True
        StartIndex = 0
        DropDownStyle = ComboBoxStyle.DropDownList
        UpdateStyles()
    End Sub

#End Region

#Region " Properties "

    <Category("Custom Properties"),
    Description("Gets or sets the index specifying the currently selected item.")>
    Private Property StartIndex As Integer
        Get
            Return _StartIndex
        End Get
        Set(ByVal value As Integer)
            _StartIndex = value
            Try
                MyBase.SelectedIndex = value
                RaiseEvent SelectedIndexChanged(Me)
            Catch
            End Try
            Invalidate()
        End Set
    End Property

#End Region

#Region " Draw Control "

    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        Dim G As Graphics = e.Graphics
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Try

            Using BG As New SolidBrush(If((e.State And DrawItemState.Selected) = DrawItemState.Selected, Colors.Gray, Colors.White)), TC As New SolidBrush(If((e.State And DrawItemState.Selected) = DrawItemState.Selected, Colors.White, Colors.Gray)), F As New Font(Font.Name, 9)
                G.FillRectangle(BG, e.Bounds)
                G.DrawString(GetItemText(Items(e.Index)), F, TC, e.Bounds)
            End Using

        Catch
        End Try

    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G As Graphics = e.Graphics

        G.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Dim GP As New GraphicsPath, Rect As New Rectangle(0, 0, Width - 1, Height - 1)
        GP.AddRectangle(Rect)
        GP.CloseFigure()
        Using B As New PathGradientBrush(GP) With {.CenterColor = Colors.White, .SurroundColors = New Color() {Colors.LightSilver}, .FocusScales = New PointF(0.98F, 0.75F)}
            G.FillPath(B, GP)
            G.DrawPath(Pens.Silver, GP)
        End Using

        G.SmoothingMode = SmoothingMode.AntiAlias

        DrawTriangle(G, Colors.Silver, 1.5,
                  New Point(Width - 20, 12), New Point(Width - 16, 16),
                  New Point(Width - 16, 16), New Point(Width - 12, 12),
                  New Point(Width - 16, 17), New Point(Width - 16, 16)
                  )
        G.SmoothingMode = SmoothingMode.None
        Using F As New Font(Font.Name, 10)
            G.DrawString(Text, F, Brushes.Silver, New Rectangle(7, 0, Width - 1, Height - 1), SetPosition(StringAlignment.Near))
        End Using
        GP.Dispose()
    End Sub

#End Region

#Region " Events "

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Invalidate()
    End Sub

#End Region

End Class

#End Region

#Region " GroupBox "

Public Class YouTubeGroupBox : Inherits ContainerControl

#Region " Declarations "

    Private R As Rectangle
    Private _Style As iStyle

#End Region

#Region " Properties "

    <Category("Custom"), Description("Gets or sets the image of the control.")> Public Property Image As Image

    <Category("Custom"),
    Description("Gets or sets the style for the control.")>
    Public Property Style As iStyle
        Get
            Return _Style
        End Get
        Set(value As iStyle)
            _Style = value
            Invalidate()
        End Set
    End Property


#End Region

#Region " Constructors "

    Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10)
        BackColor = Color.Transparent
        UpdateStyles()
        Image = Nothing
        _Style = iStyle.Blue
    End Sub

#End Region

#Region " Draw Control "

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        Dim Rect As New Rectangle(0, 0, Width - 1, Height - 1)
        R = New Rectangle(Width - 30, 15, 20, 20)
        G.FillRectangle(Brushes.White, Rect)
        G.FillRectangle(If(Style = iStyle.Blue, Brushes.Blue, Brushes.Red), New Rectangle(0, 0, Width - 1, 50))
        G.DrawString(Text, Font, Brushes.White, New Rectangle(If(Image Is Nothing, 10, 35), 0, Width - 1, 50), SetPosition(StringAlignment.Near))
        If Image IsNot Nothing Then DrawImageWithColor(G, New Rectangle(12, 15, 18, 18), Image, Colors.White)
        Using F As New Font(Font, FontStyle.Bold)
            G.DrawString("x", F, Brushes.White, R, SetPosition())
        End Using

        G.DrawRectangle(If(Style = iStyle.Blue, Pens.Blue, Pens.Red), Rect)
    End Sub

#End Region

#Region " Events "

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If R.Contains(e.Location) Then
            Cursor = Cursors.Hand
        Else
            Cursor = Cursors.Default
        End If
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = MouseButtons.Left AndAlso R.Contains(e.Location) Then
            Parent.Controls.Remove(Me)
        End If
    End Sub

#End Region

#Region " Enumerators "

    Enum iStyle
        Blue
        Red
    End Enum

#End Region

End Class

#End Region

#Region " Colors & Brushes Pens "

Public NotInheritable Class Colors

    Public Shared ReadOnly Property Red As Color
        Get
            Return Color.FromArgb(204, 24, 30)
        End Get
    End Property

    Public Shared ReadOnly Property LightRed As Color
        Get
            Return Color.FromArgb(230, 33, 23)
        End Get
    End Property

    Public Shared ReadOnly Property DarkRed As Color
        Get
            Return Color.FromArgb(179, 18, 23)
        End Get
    End Property

    Public Shared ReadOnly Property Blue As Color
        Get
            Return Color.FromArgb(18, 109, 179)
        End Get
    End Property

    Public Shared ReadOnly Property LighterBlue As Color
        Get
            Return Color.FromArgb(22, 122, 198)
        End Get
    End Property

    Public Shared ReadOnly Property DarkBlue As Color
        Get
            Return Color.FromArgb(9, 91, 153)
        End Get
    End Property

    Public Shared ReadOnly Property White As Color
        Get
            Return Color.White
        End Get
    End Property

    Public Shared ReadOnly Property Silver As Color
        Get
            Return Color.FromArgb(211, 211, 211)
        End Get
    End Property

    Public Shared ReadOnly Property LightSilver As Color
        Get
            Return Color.FromArgb(241, 241, 241)
        End Get
    End Property

    Public Shared ReadOnly Property LighterSilver As Color
        Get
            Return Color.FromArgb(248, 248, 248)
        End Get
    End Property

    Public Shared ReadOnly Property DarkGray As Color
        Get
            Return Color.FromArgb(51, 51, 51)
        End Get
    End Property

    Public Shared ReadOnly Property Gray As Color
        Get
            Return Color.FromArgb(102, 102, 102)
        End Get
    End Property

    Public Shared ReadOnly Property LightGray As Color
        Get
            Return Color.FromArgb(198, 198, 198)
        End Get
    End Property

    Public Shared ReadOnly Property LighterGray As Color
        Get
            Return Color.FromArgb(233, 233, 233)
        End Get
    End Property

End Class

Public NotInheritable Class Brushes

    Public Shared ReadOnly Property Red As SolidBrush
        Get
            Return New SolidBrush(Colors.Red)
        End Get
    End Property

    Public Shared ReadOnly Property LightRed As SolidBrush
        Get
            Return New SolidBrush(Colors.LightRed)
        End Get
    End Property

    Public Shared ReadOnly Property DarkRed As SolidBrush
        Get
            Return New SolidBrush(Colors.DarkRed)
        End Get
    End Property

    Public Shared ReadOnly Property Blue As SolidBrush
        Get
            Return New SolidBrush(Colors.Blue)
        End Get
    End Property

    Public Shared ReadOnly Property LighterBlue As SolidBrush
        Get
            Return New SolidBrush(Colors.LighterBlue)
        End Get
    End Property

    Public Shared ReadOnly Property DarkBlue As SolidBrush
        Get
            Return New SolidBrush(Colors.DarkBlue)
        End Get
    End Property

    Public Shared ReadOnly Property White As SolidBrush
        Get
            Return New SolidBrush(Colors.White)
        End Get
    End Property

    Public Shared ReadOnly Property Silver As SolidBrush
        Get
            Return New SolidBrush(Colors.Silver)
        End Get
    End Property

    Public Shared ReadOnly Property LightSilver As SolidBrush
        Get
            Return New SolidBrush(Colors.LightSilver)
        End Get
    End Property

    Public Shared ReadOnly Property LighterSilver As SolidBrush
        Get
            Return New SolidBrush(Colors.LighterSilver)
        End Get
    End Property

    Public Shared ReadOnly Property DarkGray As SolidBrush
        Get
            Return New SolidBrush(Colors.DarkGray)
        End Get
    End Property

    Public Shared ReadOnly Property Gray As SolidBrush
        Get
            Return New SolidBrush(Colors.Gray)
        End Get
    End Property

    Public Shared ReadOnly Property LightGray As SolidBrush
        Get
            Return New SolidBrush(Colors.LightGray)
        End Get
    End Property

    Public Shared ReadOnly Property LighterGray As SolidBrush
        Get
            Return New SolidBrush(Colors.LighterGray)
        End Get
    End Property

End Class

Public NotInheritable Class Pens

    Public Shared ReadOnly Property Red As Pen
        Get
            Return New Pen(Colors.Red)
        End Get
    End Property

    Public Shared ReadOnly Property LightRed As Pen
        Get
            Return New Pen(Colors.LightRed)
        End Get
    End Property

    Public Shared ReadOnly Property DarkRed As Pen
        Get
            Return New Pen(Colors.DarkRed)
        End Get
    End Property

    Public Shared ReadOnly Property Blue As Pen
        Get
            Return New Pen(Colors.Blue)
        End Get
    End Property

    Public Shared ReadOnly Property LighterBlue As Pen
        Get
            Return New Pen(Colors.LighterBlue)
        End Get
    End Property

    Public Shared ReadOnly Property DarkBlue As Pen
        Get
            Return New Pen(Colors.DarkBlue)
        End Get
    End Property

    Public Shared ReadOnly Property White As Pen
        Get
            Return New Pen(Colors.White)
        End Get
    End Property

    Public Shared ReadOnly Property Silver As Pen
        Get
            Return New Pen(Colors.Silver)
        End Get
    End Property

    Public Shared ReadOnly Property LightSilver As Pen
        Get
            Return New Pen(Colors.Gray)
        End Get
    End Property

    Public Shared ReadOnly Property LighterSilver As Pen
        Get
            Return New Pen(Colors.LighterSilver)
        End Get
    End Property

    Public Shared ReadOnly Property DarkGray As Pen
        Get
            Return New Pen(Colors.DarkGray)
        End Get
    End Property

    Public Shared ReadOnly Property Gray As Pen
        Get
            Return New Pen(Colors.Gray)
        End Get
    End Property

    Public Shared ReadOnly Property LightGray As Pen
        Get
            Return New Pen(Colors.LightGray)
        End Get
    End Property

    Public Shared ReadOnly Property LighterGray As Pen
        Get
            Return New Pen(Colors.LighterGray)
        End Get
    End Property

End Class

#End Region