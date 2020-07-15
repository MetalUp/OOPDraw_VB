
Public Class OOPDraw

    Private currentPen As Pen = New Pen(Color.Black)
    Private dragging As Boolean = False
    Private startOfDrag As Point = Point.Empty
    Private lastMousePosition As Point = Point.Empty
    Private shapes As List(Of Shape) = New List(Of Shape)

    Public Sub New()
        InitializeComponent()
        LineWidth.SelectedItem = "Medium"
        Colour.SelectedItem = "Green"
        Shape.SelectedItem = "Line"
    End Sub

    Private Sub Canvas_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Canvas.Paint
        Dim gr As Graphics = e.Graphics
        For Each shape As Shape In shapes
            shape.Draw(gr)
        Next
    End Sub

    Private Sub Canvas_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Canvas.MouseDown
        dragging = True
        startOfDrag = e.Location
        lastMousePosition = e.Location
        Select Case Shape.Text
            Case "Line"
                shapes.Add(New Line(currentPen, e.X, e.Y))
            Case "Rectangle"
                shapes.Add(New Rectangle(currentPen, e.X, e.Y))
            Case "Ellipse"
                shapes.Add(New Ellipse(currentPen, e.X, e.Y))
            Case "Circle"
                shapes.Add(New Circle(currentPen, e.X, e.Y))
        End Select
    End Sub

    Private Sub Canvas_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Canvas.MouseMove
        If dragging Then
            Dim shape As Shape = shapes.Last()
            shape.GrowTo(e.X, e.Y)
            lastMousePosition = e.Location
            Refresh()
        End If
    End Sub

    Private Sub Canvas_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Canvas.MouseUp
        dragging = False
    End Sub

    Private Sub LineWidth_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles LineWidth.SelectedIndexChanged
        Dim width As Single = currentPen.Width
        Select Case LineWidth.Text
            Case "Thin"
                width = 2.0F
            Case "Medium"
                width = 4.0F
            Case "Thick"
                width = 8.0F
        End Select
        currentPen = New Pen(currentPen.Color, width)
    End Sub

    Private Sub Colour_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Colour.SelectedIndexChanged
        Dim color As Color = currentPen.Color
        Select Case Colour.Text
            Case "Red"
                color = Color.Red
            Case "Blue"
                color = Color.Blue
            Case "Green"
                color = Color.Green
        End Select
        currentPen = New Pen(color, currentPen.Width)
    End Sub
End Class

