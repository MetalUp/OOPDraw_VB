<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OOPDraw
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Canvas = New System.Windows.Forms.PictureBox()
        Me.LineWidth = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Colour = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Shape = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Action = New System.Windows.Forms.ComboBox()
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Canvas
        '
        Me.Canvas.BackColor = System.Drawing.SystemColors.Window
        Me.Canvas.Location = New System.Drawing.Point(292, 13)
        Me.Canvas.Name = "Canvas"
        Me.Canvas.Size = New System.Drawing.Size(709, 602)
        Me.Canvas.TabIndex = 0
        Me.Canvas.TabStop = False
        '
        'LineWidth
        '
        Me.LineWidth.FormattingEnabled = True
        Me.LineWidth.Items.AddRange(New Object() {"Thin", "Medium", "Thick"})
        Me.LineWidth.Location = New System.Drawing.Point(26, 56)
        Me.LineWidth.Name = "LineWidth"
        Me.LineWidth.Size = New System.Drawing.Size(121, 28)
        Me.LineWidth.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Line Width"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Colour"
        '
        'Colour
        '
        Me.Colour.FormattingEnabled = True
        Me.Colour.Items.AddRange(New Object() {"Red", "Green", "Blue"})
        Me.Colour.Location = New System.Drawing.Point(26, 127)
        Me.Colour.Name = "Colour"
        Me.Colour.Size = New System.Drawing.Size(121, 28)
        Me.Colour.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Shape"
        '
        'Shape
        '
        Me.Shape.FormattingEnabled = True
        Me.Shape.Items.AddRange(New Object() {"Line", "Rectangle", "Ellipse", "Circle"})
        Me.Shape.Location = New System.Drawing.Point(26, 200)
        Me.Shape.Name = "Shape"
        Me.Shape.Size = New System.Drawing.Size(121, 28)
        Me.Shape.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Action"
        '
        'Action
        '
        Me.Action.FormattingEnabled = True
        Me.Action.Items.AddRange(New Object() {"Draw", "Move", "Select", "Group", "Delete", "Duplicate"})
        Me.Action.Location = New System.Drawing.Point(26, 277)
        Me.Action.Name = "Action"
        Me.Action.Size = New System.Drawing.Size(121, 28)
        Me.Action.TabIndex = 8
        '
        'OOPDraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 627)
        Me.Controls.Add(Me.Action)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Shape)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Colour)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LineWidth)
        Me.Controls.Add(Me.Canvas)
        Me.Name = "OOPDraw"
        Me.Text = "OOPDraw"
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Canvas As PictureBox
    Friend WithEvents LineWidth As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Colour As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Shape As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Action As ComboBox
End Class
