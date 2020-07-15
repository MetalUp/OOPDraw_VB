﻿Public Class Ellipse
    Inherits Shape

    Public Sub New(p As Pen, x1 As Integer, y1 As Integer)
        MyBase.New(p, x1, y1)
    End Sub

    Public Sub New(p As Pen, x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        MyBase.New(p, x1, y1, x2, y2)
    End Sub

    Public Overrides Sub Draw(g As Graphics)
        Dim x As Integer = Math.Min(X1, X2)
        Dim y As Integer = Math.Min(Y1, Y2)
        Dim w As Integer = Math.Max(X1, X2) - x
        Dim h As Integer = Math.Max(Y1, Y2) - y
        If w > 0 AndAlso h > 0 Then
            g.DrawArc(Pen, x, y, w, h, 0F, 360.0F)
        End If
    End Sub
End Class
