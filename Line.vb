Public Class Line

    Public ReadOnly Property Pen As Pen
    Public ReadOnly Property X1 As Integer
    Public ReadOnly Property Y1 As Integer
    Public ReadOnly Property X2 As Integer
    Public ReadOnly Property Y2 As Integer

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer)
        _Pen = p
        _X1 = x1
        _Y1 = y1
        _X2 = x2
        _Y2 = y2
    End Sub

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer)
        Me.New(p, x1, y1, x1, y1)
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        g.DrawLine(Pen, X1, Y1, X2, Y2)
    End Sub

    Public Sub GrowTo(ByVal x2 As Integer, ByVal y2 As Integer)
        _X2 = x2
        _Y2 = y2
    End Sub
End Class
