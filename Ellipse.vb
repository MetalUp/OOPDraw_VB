Public Class Ellipse
    Inherits Shape

    Public Sub New(p As Pen, x1 As Integer, y1 As Integer)
        MyBase.New(p, x1, y1)
    End Sub

    Public Sub New(p As Pen, x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        MyBase.New(p, x1, y1, x2, y2)
    End Sub

    Public Overrides Sub Draw(ByVal g As Graphics)
        DrawClosedArc(g, Me)
    End Sub

End Class
