Imports System.Windows.Forms
Imports System.Drawing
Imports MathNet.Symbolics
Imports MathNet.Numerics.LinearAlgebra
Imports NCalc
Imports Expression = NCalc.Expression
Imports System.Web.ModelBinding

Public Class Math_Graphics
    Private zoom As Double = 1.0
    Private offsetX As Double = 0.0
    Private offsetY As Double = 0.0

    Private Sub DrawGraph(ByVal g As Graphics)
        ' Calcola il range degli assi x e y
        Dim xMin As Double = -10.0 * zoom + offsetX
        Dim xMax As Double = 10.0 * zoom + offsetX
        Dim yMin As Double = -10.0 * zoom + offsetY
        Dim yMax As Double = 10.0 * zoom + offsetY

        ' Calcola la larghezza e l'altezza della finestra di disegno
        Dim width As Integer = Me.ClientSize.Width
        Dim height As Integer = Me.ClientSize.Height

        ' Disegna gli assi x e y
        Dim xAxis As Point() = {New Point(0, height / 2), New Point(width, height / 2)}
        Dim yAxis As Point() = {New Point(width / 2, 0), New Point(width / 2, height)}
        g.DrawLines(Pens.White, xAxis)
        g.DrawLines(Pens.White, yAxis)

        ' Itera su ogni punto sull'asse x
        For x As Double = xMin To xMax Step 0.01
            If Not String.IsNullOrEmpty(TextBox1.Text) Then
                Dim expr As New Expression(TextBox1.Text)
                expr.Parameters("x") = x
                ' Calcola il corrispondente punto sull'asse y
                Dim y As Double = expr.Evaluate()
                Dim screenX As Integer = (x - xMin) / (xMax - xMin) * (width - 1)

                Dim screenY As Integer = (yMax - y) / (yMax - yMin) * (height - 1)

                ' Disegna il punto
                g.DrawRectangle(Pens.White, screenX, screenY, 1, 1)
            End If
        Next
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawGraph(e.Graphics)
    End Sub


    Private Sub Math_Graphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnZoomIn_Click(sender As Object, e As EventArgs) Handles btnZoomIn.Click
        zoom *= 1.25
        Me.Invalidate()
    End Sub

    Private Sub btnZoomOut_Click(sender As Object, e As EventArgs) Handles btnZoomout.Click
        zoom /= 1.25
        Me.Invalidate()
    End Sub

    Private Sub btnMoveLeft_Click(sender As Object, e As EventArgs) Handles btnMoveLeft.Click
        offsetX -= 10.0 * zoom
        Me.Invalidate()
    End Sub

    Private Sub btnMoveRight_Click(sender As Object, e As EventArgs) Handles btnMoveRight.Click
        offsetX += 10.0 * zoom
        Me.Invalidate()
    End Sub

    Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click
        offsetY -= 10.0 * zoom
        Me.Invalidate()
    End Sub

    Private Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click
        offsetY += 10.0 * zoom
        Me.Invalidate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Invalidate()
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub FastMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastMenuToolStripMenuItem.Click
        FastMenu.Show()
    End Sub

    Private Sub NormalActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalActualToolStripMenuItem.Click
        Me.Close()
        Normal.Show()
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Close()
        Scientific.Show()
    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        Me.Close()
        Programmer.Show()
    End Sub

    Private Sub BinaryAdditionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinaryAdditionToolStripMenuItem.Click
        Me.Close()
        BinaryOp.Show()
    End Sub
End Class
