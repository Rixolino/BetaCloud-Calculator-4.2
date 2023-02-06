Public Class LinEquationTriple
    Dim fract
    Dim Dxs
    Dim Dys
    Dim Dzs
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Dim m
    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.ResizeRedraw, True)

    End Sub

    Private Const cGrip As Integer = 16
    Private Const cCaption As Integer = 32

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = &H84 Then
            Dim pos As Point = New Point(m.LParam.ToInt32())
            pos = Me.PointToClient(pos)

            If pos.Y < cCaption Then
                m.Result = CType(2, IntPtr)
                Return
            End If

            If pos.X >= Me.ClientSize.Width - cGrip AndAlso pos.Y >= Me.ClientSize.Height - cGrip Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If



        MyBase.WndProc(m)
    End Sub

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Normal.Show()
        Me.Close()
    End Sub

    Private Sub ScientificActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificActualToolStripMenuItem.Click
        Scientific.Show()
        Me.Close()
    End Sub

    Private Sub UnitOfMeasureToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FunctionConverter.Show()
        Me.Close()
    End Sub

    Private Sub NormalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem1.Click
        Linearequations.Show()
        Me.Close()
    End Sub

    Private Sub FormulasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulasToolStripMenuItem.Click
        Formulas.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a1.Text = ""
        a2.Text = ""
        a3.Text = ""
        b1.Text = ""
        b2.Text = ""
        b3.Text = ""
        c1.Text = ""
        c2.Text = ""
        c3.Text = ""
        d1.Text = ""
        d2.Text = ""
        d3.Text = ""
        Resultx.Text = ""
        Resulty.Text = ""
        Resultz.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button3.Click
        fract = (a1.Text * b2.Text * c3.Text) + (b1.Text * c2.Text * a3.Text) + (c1.Text * a2.Text * b3.Text) - (c1.Text * b2.Text * a3.Text) - (b1.Text * a2.Text * c3.Text) - (a1.Text * c2.Text * b3.Text)
        Dxs = (d1.Text * b2.Text * c3.Text) + (b1.Text * c2.Text * d3.Text) + (c1.Text * d2.Text * b3.Text) - (c1.Text * b2.Text * d3.Text) - (b1.Text * d2.Text * c3.Text) - (d1.Text * c2.Text * b3.Text)
        Dys = (a1.Text * d2.Text * c3.Text) + (d1.Text * c2.Text * a3.Text) + (c1.Text * a2.Text * d3.Text) - (c1.Text * d2.Text * a3.Text) - (d1.Text * a2.Text * c3.Text) - (a1.Text * c2.Text * d3.Text)
        Dzs = (a1.Text * b2.Text * d3.Text) + (b1.Text * d2.Text * a3.Text) + (d1.Text * a2.Text * b3.Text) - (d1.Text * b2.Text * a3.Text) - (b1.Text * a2.Text * d3.Text) - (a1.Text * d2.Text * b3.Text)
        Resultx.Text = Dxs / fract
        Resulty.Text = Dys / fract
        Resultz.Text = Dzs / fract

        If Resultx.Text = "NaN" Then
            Resultx.Text = "Indeterminate"
        End If

        If Resulty.Text = "NaN" Then
            Resulty.Text = "Indeterminate"
        End If

        If Resultz.Text = "NaN" Then
            Resultz.Text = "Indeterminate"
        End If

        If Resultx.Text = "∞" Then
            Resultx.Text = "Infinite solution"
        End If

        If Resulty.Text = "∞" Then
            Resulty.Text = "Infinite solution"
        End If

        If Resultz.Text = "∞" Then
            Resultz.Text = "Infinite solution"
        End If

        If Resultx.Text = "-∞" Then
            Resultx.Text = "Infinite solution"
        End If

        If Resulty.Text = "-∞" Then
            Resulty.Text = "Infinite solution"
        End If

        If Resultz.Text = "-∞" Then
            Resultz.Text = "Infinite solution"
        End If

    End Sub

    Private Sub Resulty_TextChanged(sender As Object, e As EventArgs) Handles Resulty.TextChanged

    End Sub

    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TEmore.Show()
    End Sub

    Private Sub LinEquationTriple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        Me.Close()
        Programmer.Show()
    End Sub

    Private Sub FastMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastMenuToolStripMenuItem.Click
        FastMenu.Show()
    End Sub
End Class