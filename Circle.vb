Public Class Circle
    Inherits Shape

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer)
        MyBase.New(p, x1, y1)
    End Sub

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer)
        MyBase.New(p, x1, y1, x2, y2)
        GrowTo(x2, y2)
    End Sub

    Public Overrides Sub Draw(ByVal g As Graphics)
        Dim x As Integer = Math.Min(X1, X2)
        Dim y As Integer = Math.Min(Y1, Y2)
        Dim w As Integer = Math.Max(X1, X2) - x
        Dim h As Integer = Math.Max(Y1, Y2) - y

        If w > 0 AndAlso h > 0 Then
            g.DrawArc(Pen, x, y, w, h, 0F, 360.0F)
        End If
    End Sub

    Public Overrides Sub GrowTo(ByVal x2 As Integer, ByVal y2 As Integer)
        Dim diameter As Integer = Math.Max(x2 - X1, y2 - Y1)
        _X2 = X1 + diameter
        _Y2 = Y1 + diameter
    End Sub
End Class