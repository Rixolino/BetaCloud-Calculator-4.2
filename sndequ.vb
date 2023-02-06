Public Class sndequ
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Dim d, den As Double
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

    Private Sub NormalActualToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NormalActualToolStripMenuItem.Click
        Normal.Show()
        Me.Close()
    End Sub

    Private Sub ScientificToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Scientific.Show()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        retta.Text = ""
        errrs.Text = ""
        Label6.Text = "Δ = " & (b.Text ^ 2) & "-" & "(" & 4 * (a.Text * c.Text) & ") = "


        delta.Text = (b.Text ^ 2) - 4 * (a.Text * c.Text)

        If (delta.Text < 0) Then retta.Text = "=====================> R"

        If (delta.Text < 0) Then errrs.Text = "(∀x∈R)"

        If (delta.Text < 0) Then MsgBox("Impossible to calculate this equation (no real solutions exist)")

        If (delta.Text = 0) Then MsgBox("WARNING: This equation will have double results (in graphics, the lines will be superimposed)")

        n1.Text = b.Text * -1

        dt.Text = delta.Text

        dn.Text = 2 * a.Text

        r1.Text = ((b.Text * -1) - Math.Sqrt(b.Text ^ 2 - 4 * (a.Text * c.Text))) / (2 * a.Text)

        r2.Text = ((b.Text * -1) + Math.Sqrt(b.Text ^ 2 - 4 * (a.Text * c.Text))) / (2 * a.Text)

    End Sub

    Private Sub sndequ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a.Text = ""
        b.Text = ""
        c.Text = ""
        delta.Text = ""
        n1.Text = "-b"
        dt.Text = "b^2 - 4ac"
        dn.Text = "2a"
        r1.Text = ""
        r2.Text = ""
        Label6.Text = "Δ = b^2 - 4ac = "
        errrs.Text = ""
        retta.Text = ""
    End Sub

    Private Sub r2_Click(sender As Object, e As EventArgs) Handles r2.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub r1_Click(sender As Object, e As EventArgs) Handles r1.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub dn_Click(sender As Object, e As EventArgs) Handles dn.Click

    End Sub

    Private Sub n1_Click(sender As Object, e As EventArgs) Handles n1.Click

    End Sub

    Private Sub dt_Click(sender As Object, e As EventArgs) Handles dt.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub delta_TextChanged(sender As Object, e As EventArgs) Handles delta.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub c_TextChanged(sender As Object, e As EventArgs) Handles c.TextChanged

    End Sub

    Private Sub b_TextChanged(sender As Object, e As EventArgs) Handles b.TextChanged

    End Sub

    Private Sub a_TextChanged(sender As Object, e As EventArgs) Handles a.TextChanged

    End Sub

    Private Sub FastMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastMenuToolStripMenuItem.Click
        FastMenu.Show()
    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        Programmer.Show()
    End Sub

    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub
End Class