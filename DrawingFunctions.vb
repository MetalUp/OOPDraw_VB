Module DrawingFunctions

    Sub DrawClosedArc(ByVal g As Graphics, ByVal shape As Shape)
        Dim enc = shape.EnclosingRectangle()
        If enc.Item3 > 0 And enc.Item4 > 0 Then
            g.DrawArc(shape.Pen, enc.Item1, enc.Item2, enc.Item3, enc.Item4, 0F, 360.0F)
        End If
    End Sub

End Module
