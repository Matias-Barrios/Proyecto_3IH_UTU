Imports System.Drawing.Drawing2D

Public Class BorderLabel
    Inherits Label

    Public Sub New()
        MyBase.New
        OutlineForeColor = Color.Green
        OutlineWidth = 2
    End Sub

    Public Property OutlineForeColor As Color
        Get
        End Get
        Set
        End Set
    End Property

    Public Property OutlineWidth As Single
        Get
        End Get
        Set
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        e.Graphics.FillRectangle(New SolidBrush(BackColor), ClientRectangle)
        Dim gp As GraphicsPath = New GraphicsPath
        Dim outline As Pen = New Pen(Me.OutlineForeColor, Me.OutlineWidth)
        Dim sf As StringFormat = New StringFormat
        Dim foreBrush As Brush = New SolidBrush(ForeColor)
        gp.AddString(Text, Font.FontFamily, CType(Font.Style, Integer), Font.Size, ClientRectangle, sf)
        e.Graphics.ScaleTransform(1.3!, 1.35!)
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        e.Graphics.DrawPath(outline, gp)
        e.Graphics.FillPath(foreBrush, gp)
    End Sub
End Class