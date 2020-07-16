Public Class Rectangle
    Inherits Shape

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer)
        MyBase.New(p, x1, y1, x2, y2)
    End Sub

    Public Sub New(ByVal p As Pen, ByVal x1 As Integer, ByVal y1 As Integer)
        MyBase.New(p, x1, y1, x1, y1)
    End Sub

    Public Overrides Sub Draw(ByVal g As Graphics)
        Dim enc = EnclosingRectangle()
        g.DrawRectangle(Pen, enc.Item1, enc.Item2, enc.Item3, enc.Item4)
    End Sub

    Public Function FullySurrounds(ByVal s As Shape) As Boolean
        Dim enc = EnclosingRectangle()
        Dim x = enc.Item1
        Dim y = enc.Item2
        Dim w = enc.Item3
        Dim h = enc.Item4
        Dim sEnc = s.EnclosingRectangle()
        Dim xs = sEnc.Item1
        Dim ys = sEnc.Item2
        Dim ws = sEnc.Item3
        Dim hs = sEnc.Item4
        Return x < xs And y < ys And x + w > xs + ws And y + h > ys + hs
    End Function

End Class
