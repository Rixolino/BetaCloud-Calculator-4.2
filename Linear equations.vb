Public Class Linearequations
    Dim fract As Integer
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
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles x1.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles d1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fract = (x1.Text * y2.Text) - (x2.Text * y1.Text)
        Resultx.Text = ((d1.Text * y2.Text) - (d2.Text * y1.Text)) / fract
        Resulty.Text = ((x1.Text * d2.Text) - (x2.Text * d1.Text)) / fract

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

    End Sub

    Private Sub ScientificActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificActualToolStripMenuItem.Click
        Me.Close()
        Scientific.Show()
    End Sub
    Function dec2frac(ByVal dblDecimal As Double) As String
        Dim intNumerator, intDenominator, intNegative As Integer
        Dim dblFraction, dblAccuracy As Double
        Dim txtDecimal As String

        dblAccuracy = 0.1                                       ' Set the initial Accuracy level.
        txtDecimal = dblDecimal.ToString                        ' Get a  string representation of the input number.

        For i As Integer = 0 To (txtDecimal.Length - 1)                                 ' Check each character to see if it's a decimal point...
            If txtDecimal.Substring(i, 1) = "." Then                    ' if it is then we get the number of digits behind the decimal
                dblAccuracy = 1 / 10 ^ (txtDecimal.Length - i)    '   assign the new accuracy level, and
                Exit For                                            '   exit the for loop.
            End If
        Next
        intNumerator = 0                                ' Set the initial numerator value to 0.
        intDenominator = 1                              ' Set the initial denominator value to 1.
        intNegative = 1                                 ' Set the negative value flag to positive.
        If dblDecimal < 0 Then
            intNegative = -1 ' If the desired decimal value is negative,
        End If

        dblFraction = 0                                 ' Set the fraction value to be 0/1.

        Do While Math.Abs(dblFraction - dblDecimal) > dblAccuracy   ' As long as we're still outside the
            '   desired accuracy, then...
            If Math.Abs(dblFraction) > Math.Abs(dblDecimal) Then      ' If our fraction is too big,
                intDenominator += 1         '   increase the denominator
            Else                                            ' Otherwise
                intNumerator += intNegative   '   increase the numerator.
            End If

            dblFraction = intNumerator / intDenominator     ' Set the new value of the fraction.

        Loop

        Return intNumerator.ToString & "/" & intDenominator.ToString ' Display the numerator and denominator
    End Function
    Function num(ByVal dblDecimal As Double) As String
        Dim intNumerator, intDenominator, intNegative As Integer
        Dim dblFraction, dblAccuracy As Double
        Dim txtDecimal As String

        dblAccuracy = 0.1                                       ' Set the initial Accuracy level.
        txtDecimal = dblDecimal.ToString                        ' Get a  string representation of the input number.

        For i As Integer = 0 To (txtDecimal.Length - 1)                                 ' Check each character to see if it's a decimal point...
            If txtDecimal.Substring(i, 1) = "." Then                    ' if it is then we get the number of digits behind the decimal
                dblAccuracy = 1 / 10 ^ (txtDecimal.Length - i)    '   assign the new accuracy level, and
                Exit For                                            '   exit the for loop.
            End If
        Next
        intNumerator = 0                                ' Set the initial numerator value to 0.
        intDenominator = 1                              ' Set the initial denominator value to 1.
        intNegative = 1                                 ' Set the negative value flag to positive.
        If dblDecimal < 0 Then
            intNegative = -1 ' If the desired decimal value is negative,
        End If

        dblFraction = 0                                 ' Set the fraction value to be 0/1.

        Do While Math.Abs(dblFraction - dblDecimal) > dblAccuracy   ' As long as we're still outside the
            '   desired accuracy, then...
            If Math.Abs(dblFraction) > Math.Abs(dblDecimal) Then      ' If our fraction is too big,
                intDenominator += 1         '   increase the denominator
            Else                                            ' Otherwise
                intNumerator += intNegative   '   increase the numerator.
            End If

            dblFraction = intNumerator / intDenominator     ' Set the new value of the fraction.

        Loop

        Return intNumerator.ToString
    End Function
    Function den(ByVal dblDecimal As Double) As String
        Dim intNumerator, intDenominator, intNegative As Integer
        Dim dblFraction, dblAccuracy As Double
        Dim txtDecimal As String

        dblAccuracy = 0.1                                       ' Set the initial Accuracy level.
        txtDecimal = dblDecimal.ToString                        ' Get a  string representation of the input number.

        For i As Integer = 0 To (txtDecimal.Length - 1)                                 ' Check each character to see if it's a decimal point...
            If txtDecimal.Substring(i, 1) = "." Then                    ' if it is then we get the number of digits behind the decimal
                dblAccuracy = 1 / 10 ^ (txtDecimal.Length - i)    '   assign the new accuracy level, and
                Exit For                                            '   exit the for loop.
            End If
        Next
        intNumerator = 0                                ' Set the initial numerator value to 0.
        intDenominator = 1                              ' Set the initial denominator value to 1.
        intNegative = 1                                 ' Set the negative value flag to positive.
        If dblDecimal < 0 Then
            intNegative = -1 ' If the desired decimal value is negative,
        End If

        dblFraction = 0                                 ' Set the fraction value to be 0/1.

        Do While Math.Abs(dblFraction - dblDecimal) > dblAccuracy   ' As long as we're still outside the
            '   desired accuracy, then...
            If Math.Abs(dblFraction) > Math.Abs(dblDecimal) Then      ' If our fraction is too big,
                intDenominator += 1         '   increase the denominator
            Else                                            ' Otherwise
                intNumerator += intNegative   '   increase the numerator.
            End If

            dblFraction = intNumerator / intDenominator     ' Set the new value of the fraction.

        Loop

        Return intDenominator.ToString
    End Function

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Me.Close()
        Normal.Show()
    End Sub

    Private Sub UnitOfMeasureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitOfMeasureToolStripMenuItem.Click
        Me.Close()
        Programmer.Show()
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
        x1.Text = ""
        x2.Text = ""
        y1.Text = ""
        y2.Text = ""
        d1.Text = ""
        d2.Text = ""
        Resultx.Text = ""
        Resulty.Text = ""
    End Sub

    Private Sub NormalActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalActualToolStripMenuItem.Click

    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedToolStripMenuItem.Click
        LinEquationTriple.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        LinEquationTriple.Show()
        Me.Close()
    End Sub

    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub Linearequations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DEmore.Show()
    End Sub

    Private Sub ThemeSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BinaryAdditionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinaryAdditionToolStripMenuItem.Click
        Me.Close()
        BinaryOp.Show()
    End Sub

    Private Sub FastMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastMenuToolStripMenuItem.Click
        FastMenu.Show()
    End Sub
End Class