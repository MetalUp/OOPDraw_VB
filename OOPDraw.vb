
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
        Action.SelectedItem = "Draw"
    End Sub

    Private Sub Canvas_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Canvas.Paint
        Dim gr As Graphics = e.Graphics
        For Each shape As Shape In shapes
            shape.Draw(gr)
        Next
        If Not selectionBox Is Nothing Then
            selectionBox.Draw(gr)
        End If
    End Sub

    Private Sub Canvas_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Canvas.MouseDown
        dragging = True
        startOfDrag = e.Location
        lastMousePosition = e.Location
        Select Case Action.Text
            Case "Draw"
                AddShape(e)
            Case "Select"
                Dim p As Pen = New Pen(Color.Black, 1.0F)
                selectionBox = New Rectangle(p, startOfDrag.X, startOfDrag.Y)
        End Select
    End Sub

    Private Sub AddShape(e As MouseEventArgs)
        DeselectAll()
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
        shapes.Last().SelectIt()
    End Sub

    Private Sub Canvas_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Canvas.MouseMove
        If dragging Then
            Dim shape As Shape = shapes.Last()
            Select Case Action.Text
                Case "Move"
                    MoveSelectedShapes(e)
                Case "Draw"
                    shape.GrowTo(e.X, e.Y)
                Case "Select"
                    selectionBox.GrowTo(e.X, e.Y)
                    SelectShapes()
            End Select
            lastMousePosition = e.Location
            Refresh()
        End If
    End Sub

    Private Sub Canvas_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Canvas.MouseUp
        dragging = False
        lastMousePosition = Point.Empty
        selectionBox = Nothing
        Refresh()
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

    Private Sub DeselectAll()
        For Each s As Shape In shapes
            s.Deselect()
        Next
    End Sub

    Private selectionBox As Rectangle

    Private Sub SelectShapes()
        DeselectAll()

        For Each s As Shape In shapes
            If selectionBox.FullySurrounds(s) Then s.SelectIt()
        Next
    End Sub

    Private Function GetSelectedShapes() As List(Of Shape)
        Return shapes.Where(Function(s) s.Selected).ToList()
    End Function

    Private Sub MoveSelectedShapes(ByVal e As MouseEventArgs)
        For Each s As Shape In GetSelectedShapes()
            s.MoveBy(e.X - lastMousePosition.X, e.Y - lastMousePosition.Y)
        Next
    End Sub

End Class

