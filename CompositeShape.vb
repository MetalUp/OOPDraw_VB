Imports System.Drawing.Drawing2D

Public Class CompositeShape
    Inherits Shape

    Private ReadOnly Property Components As List(Of Shape)

    Public Sub New(ByVal components As List(Of Shape))
        MyBase.New(New Pen(Color.Black, 1.0F), 0, 0, 0, 0)
        Pen.DashStyle = DashStyle.Dash
        _Components = components
        CalculateEnclosingRectangle()
    End Sub

    Private Sub CalculateEnclosingRectangle()
        _X1 = Components.Min(Function(m) Math.Min(m.X1, m.X2))
        _Y1 = Components.Min(Function(m) Math.Min(m.Y1, m.Y2))
        _X2 = Components.Max(Function(m) Math.Max(m.X1, m.X2))
        _Y2 = Components.Max(Function(m) Math.Max(m.Y1, m.Y2))
    End Sub

    Public Overrides Sub Draw(ByVal g As Graphics)
        For Each m As Shape In Components
            m.Draw(g)
        Next

        If Selected Then g.DrawRectangle(Pen, X1, Y1, X2 - X1, Y2 - Y1)
    End Sub

    Public Overrides Sub MoveBy(ByVal xDelta As Integer, ByVal yDelta As Integer)
        For Each m As Shape In Components
            m.MoveBy(xDelta, yDelta)
        Next
        CalculateEnclosingRectangle()
    End Sub

    Public Overrides Function Clone() As Shape
        Dim clones As List(Of Shape) = New List(Of Shape)()
        For Each comp As Shape In Components
            clones.Add(comp.Clone())
        Next
        Return New CompositeShape(clones)
    End Function
End Class
