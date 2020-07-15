Public Class Rectangle
    Inherits Shape

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer)
        MyBase.New(p, x1, y1, x2, y2)
    End Sub

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer)
        MyBase.New(p, x1, y1, x1, y1)
    End Sub

    Public Overrides Sub Draw(ByVal g As Graphics)
        Dim x As Integer = Math.Min(X1, X2)
        Dim y As Integer = Math.Min(Y1, Y2)
        Dim w As Integer = Math.Max(X1, X2) - x
        Dim h As Integer = Math.Max(Y1, Y2) - y
        g.DrawRectangle(Pen, x, y, w, h)
    End Sub

End Class
