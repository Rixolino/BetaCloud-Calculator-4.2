Public Class TEmore
    Dim fract, Dxs, Dys, Dzs
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Me.Close()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
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
    Private Sub TEmore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LinEquationTriple.Resultx.Text = "" Then
            If LinEquationTriple.Resulty.Text = "" Then
                If LinEquationTriple.Resultz.Text = "" Then
                    MsgBox("You need to insert unknowns before procceded!")
                End If
            End If
        End If

        If Resultx.Text = "NaN" Then
            Resultx.Text = "Indeterminate"
        End If

        If Resulty.Text = "NaN" Then
            Resulty.Text = "Indeterminate"
        End If

        If Resultx.Text = "∞" Then
            Resultx.Text = "Infinite solution"
        End If

        If Resulty.Text = "∞" Then
            Resulty.Text = "Infinite solution"
        End If

        If Resultx.Text = "-∞" Then
            Resultx.Text = "Infinite solution"
        End If

        If Resulty.Text = "-∞" Then
            Resulty.Text = "Infinite solution"
        End If

        If Resultz.Text = "NaN" Then
            Resultz.Text = "Indeterminate"
        End If

        If Resultz.Text = "∞" Then
            Resultz.Text = "Infinite solution"
        End If

        If Resultz.Text = "-∞" Then
            Resulty.Text = "Infinite solution"
        End If

        fract = (LinEquationTriple.a1.Text * LinEquationTriple.b2.Text * LinEquationTriple.c3.Text) + (LinEquationTriple.b1.Text * LinEquationTriple.c2.Text * LinEquationTriple.a3.Text) + (LinEquationTriple.c1.Text * LinEquationTriple.a2.Text * LinEquationTriple.b3.Text) - (LinEquationTriple.c1.Text * LinEquationTriple.b2.Text * LinEquationTriple.a3.Text) - (LinEquationTriple.b1.Text * LinEquationTriple.a2.Text * LinEquationTriple.c3.Text) - (LinEquationTriple.a1.Text * LinEquationTriple.c2.Text * LinEquationTriple.b3.Text)
        Dxs = (LinEquationTriple.d1.Text * LinEquationTriple.b2.Text * LinEquationTriple.c3.Text) + (LinEquationTriple.b1.Text * LinEquationTriple.c2.Text * LinEquationTriple.d3.Text) + (LinEquationTriple.c1.Text * LinEquationTriple.d2.Text * LinEquationTriple.b3.Text) - (LinEquationTriple.c1.Text * LinEquationTriple.b2.Text * LinEquationTriple.d3.Text) - (LinEquationTriple.b1.Text * LinEquationTriple.d2.Text * LinEquationTriple.c3.Text) - (LinEquationTriple.d1.Text * LinEquationTriple.c2.Text * LinEquationTriple.b3.Text)
        Dys = (LinEquationTriple.a1.Text * LinEquationTriple.d2.Text * LinEquationTriple.c3.Text) + (LinEquationTriple.d1.Text * LinEquationTriple.c2.Text * LinEquationTriple.a3.Text) + (LinEquationTriple.c1.Text * LinEquationTriple.a2.Text * LinEquationTriple.d3.Text) - (LinEquationTriple.c1.Text * LinEquationTriple.d2.Text * LinEquationTriple.a3.Text) - (LinEquationTriple.d1.Text * LinEquationTriple.a2.Text * LinEquationTriple.c3.Text) - (LinEquationTriple.a1.Text * LinEquationTriple.c2.Text * LinEquationTriple.d3.Text)
        Dzs = (LinEquationTriple.a1.Text * LinEquationTriple.b2.Text * LinEquationTriple.d3.Text) + (LinEquationTriple.b1.Text * LinEquationTriple.d2.Text * LinEquationTriple.a3.Text) + (LinEquationTriple.d1.Text * LinEquationTriple.a2.Text * LinEquationTriple.b3.Text) - (LinEquationTriple.d1.Text * LinEquationTriple.b2.Text * LinEquationTriple.a3.Text) - (LinEquationTriple.b1.Text * LinEquationTriple.a2.Text * LinEquationTriple.d3.Text) - (LinEquationTriple.a1.Text * LinEquationTriple.d2.Text * LinEquationTriple.b3.Text)
        Dx.Text = Dxs
        Dy.Text = Dys
        Dz.Text = Dzs
        Ds.Text = fract
        Resultx.Text = Dxs / fract
        Resulty.Text = Dys / fract
        Resultz.Text = Dzs / fract
    End Sub
End Class