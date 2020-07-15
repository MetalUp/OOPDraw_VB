Public Class Line
    Inherits Shape

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer)
        MyBase.New(p, x1, y1, x2, y2)
    End Sub

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer)
        MyBase.New(p, x1, y1, x1, y1)
    End Sub

    Public Overrides Sub Draw(ByVal g As Graphics)
        g.DrawLine(Pen, X1, Y1, X2, Y2)
    End Sub

End Class
