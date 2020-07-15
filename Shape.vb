Public MustInherit Class Shape
    Protected _Pen As Pen
    Public ReadOnly Property Pen() As Pen
        Get
            Return _Pen
        End Get
    End Property

    Protected _X1 As Integer
    Public ReadOnly Property X1() As Integer
        Get
            Return _X1
        End Get
    End Property

    Protected _Y1 As Integer
    Public ReadOnly Property Y1() As Integer
        Get
            Return _Y1
        End Get
    End Property

    Protected _X2 As Integer
    Public ReadOnly Property X2() As Integer
        Get
            Return _X2
        End Get
    End Property

    Protected _Y2 As Integer
    Public ReadOnly Property Y2() As Integer
        Get
            Return _Y2
        End Get
    End Property

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

    Public MustOverride Sub Draw(ByVal g As Graphics)
    Public Overridable Sub GrowTo(ByVal x2 As Integer, ByVal y2 As Integer)
        _X2 = x2
        _Y2 = y2
    End Sub
End Class
