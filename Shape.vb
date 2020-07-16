Imports System.Drawing.Drawing2D

Public MustInherit Class Shape

    Public ReadOnly Property Selected As Boolean

    Protected _Pen As Pen
    Public ReadOnly Property Pen() As Pen
        Get
            Return _Pen
        End Get
    End Property

    Protected _X1 As Integer
    Public ReadOnly Property X1() As Integer
        Get
            Return _X1
        End Get
    End Property

    Protected _Y1 As Integer
    Public ReadOnly Property Y1() As Integer
        Get
            Return _Y1
        End Get
    End Property

    Protected _X2 As Integer
    Public ReadOnly Property X2() As Integer
        Get
            Return _X2
        End Get
    End Property

    Protected _Y2 As Integer
    Public ReadOnly Property Y2() As Integer
        Get
            Return _Y2
        End Get
    End Property

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer)
        _Pen = New Pen(p.Color, p.Width)
        _X1 = x1
        _Y1 = y1
        _X2 = x2
        _Y2 = y2
    End Sub

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer)
        Me.New(p, x1, y1, x1, y1)
    End Sub

    Public MustOverride Sub Draw(ByVal g As Graphics)
    Public Overridable Sub GrowTo(ByVal x2 As Integer, ByVal y2 As Integer)
        _X2 = x2
        _Y2 = y2
    End Sub

    Public Function EnclosingRectangle() As (Integer, Integer, Integer, Integer)
        Dim x As Integer = Math.Min(X1, X2)
        Dim y As Integer = Math.Min(Y1, Y2)
        Dim w As Integer = Math.Max(X1, X2) - x
        Dim h As Integer = Math.Max(Y1, Y2) - y
        Return (x, y, w, h)
    End Function

    Public Sub MoveBy(ByVal xDelta As Integer, ByVal yDelta As Integer)
        _X1 += xDelta
        _Y1 += yDelta
        _X2 += xDelta
        _Y2 += yDelta
    End Sub

    Public Sub SelectIt()
        _Selected = True
        Pen.DashStyle = DashStyle.Dash
    End Sub

    Public Sub Deselect()
        _Selected = False
        Pen.DashStyle = DashStyle.Solid
    End Sub

End Class
