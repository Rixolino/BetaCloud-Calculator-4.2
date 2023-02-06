Public Class Scientific
    Dim memory As Double
    Dim operation As String
    Dim a, b As Double
    Dim op As String
    Dim x
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Dim m, f
    Public Sub Perf(ByRef f As Size)

    End Sub
    Public Sub New()
        InitializeComponent()

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
    Function Factorial(n As Integer) As Integer
        If n <= 1 Then
            Return 1
        End If
        Return Factorial(n - 1) * n
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Me.Close()
        Normal.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & “1”
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & “2”
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & “3”
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & “4”
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & “5”
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & “6”
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text & “7”
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & “8”
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text & “9”
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        TextBox1.Text = TextBox1.Text & “0”
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & “(”
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & “)”
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = Math.Sin(TextBox1.Text)
        TextBox2.Text = "sin"
        functions.Text = ""
        xEsp.Enabled = True
        Button29.Enabled = True
        ButtonAnsC.Show()
    End Sub
    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = Math.Tan(TextBox1.Text)
        ButtonAnsC.Show()
        rooting.Hide()
        exproot.Hide()
        functions.Text = ""
        TextBox2.Text = "tan"
        xEsp.Enabled = True
        Button29.Enabled = True
    End Sub

    Private Sub GreekPi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreekPi.Click
        TextBox1.Text = Math.PI
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Error1.Text = ""
        TextBox1.Text = “”
        TextBox2.Text = “”
        TextBox3.Text = “”
        oplabel.Text = ""
        functions.Text = ""
        ERRProvider.Text = ""
        exproot.Hide()
        rooting.Hide()
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        ButtonAnsC.Hide()
        xEsp.Enabled = True
        Button29.Enabled = True
    End Sub
    Private Sub sqrtB_Click(sender As Object, e As EventArgs) Handles sqrtB.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = Math.Sqrt(TextBox1.Text)
        TextBox2.Text = "sqrt"
        oplabel.Text = "√"
        xEsp.Enabled = True
        Button29.Enabled = True
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        functions.Text = ""
        ButtonAnsC.Show()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text ^ (1 / 3)
        TextBox2.Text = "cbrt"
        functions.Text = ""
        oplabel.Text = "3√"
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        xEsp.Enabled = True
        Button29.Enabled = True
        ButtonAnsC.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        b = CDbl(TextBox1.Text)
        Select Case op
            Case “/”
                TextBox1.Text = a / b
            Case “*”
                TextBox1.Text = a * b
            Case “+”
                TextBox1.Text = a + b
            Case “-”
                TextBox1.Text = a - b
        End Select
    End Sub

    Private Sub MoltButt_Click(sender As Object, e As EventArgs) Handles MoltButt.Click
        rooting.Hide()
        exproot.Hide()
        TextBox3.Text = TextBox1.Text * TextBox2.Text
        oplabel.Text = "*"
        functions.Text = ""
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        If (TextBox2.Text = "") Then
            TextBox2.Text = "0"
        End If
        ButtonAnsC.Show()
    End Sub

    Private Sub MinusButt_Click(sender As Object, e As EventArgs) Handles MinusButt.Click
        rooting.Hide()
        exproot.Hide()
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        TextBox3.Text = (a - b)
        oplabel.Text = "-"
        functions.Text = ""
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        If (TextBox2.Text = "") Then
            TextBox2.Text = "0"
        End If
        ButtonAnsC.Show()
    End Sub

    Private Sub DivButton_Click(sender As Object, e As EventArgs) Handles DivButton.Click
        rooting.Hide()
        exproot.Hide()
        TextBox3.Text = TextBox1.Text / TextBox2.Text
        oplabel.Text = "/"
        functions.Text = ""
        ButtonAnsC.Show()
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        If (TextBox2.Text = "") Then
            TextBox2.Text = "0"
        End If
        If TextBox3.Text = "∞" Then
            Error1.Text = "Impossible to divide by zero"
        End If

        If TextBox3.Text = "NaN" Then
            Error1.Text = "Indeterminate"
        End If
    End Sub

    Private Sub ScientificActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificActualToolStripMenuItem.Click

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        If (TextBox2.Text = "") Then
            TextBox2.Text = "0"
        End If
        exproot.Show()
        rooting.Show()
        oplabel.Text = "x√"
        functions.Text = ""
        TextBox3.Text = TextBox1.Text ^ (1 / TextBox2.Text)
        ButtonAnsC.Hide()
    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox2.Text = TextBox2.Text & “1”
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox2.Text = TextBox2.Text & “2”
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox2.Text = TextBox2.Text & “3”
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox2.Text = TextBox2.Text & “4”
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox2.Text = TextBox2.Text & “5”
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox2.Text = TextBox2.Text & “6”
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox2.Text = TextBox2.Text & “7”
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Text = TextBox2.Text & “8”
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Text = TextBox2.Text & “9”
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = TextBox2.Text & “0”
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub TenEsp_Click(sender As Object, e As EventArgs) Handles xEsp.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        If (TextBox2.Text = "") Then
            TextBox2.Text = "0"
        End If
        rooting.Hide()
        exproot.Hide()
        TextBox3.Text = TextBox1.Text ^ TextBox2.Text
        oplabel.Text = "^"
        functions.Text = ""
        ButtonAnsC.Show()
    End Sub

    Private Sub SquarePot_Click(sender As Object, e As EventArgs) Handles SquarePot.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text ^ 2
        TextBox2.Text = "2"
        oplabel.Text = "^"
        xEsp.Enabled = True
        Button29.Enabled = True
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        rooting.Hide()
        exproot.Hide()
        functions.Text = ""
        ButtonAnsC.Show()
    End Sub

    Private Sub CubButt_Click(sender As Object, e As EventArgs) Handles CubButt.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text ^ 3
        oplabel.Text = "^"
        functions.Text = ""
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = True
        Button29.Enabled = True
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        TextBox2.Text = "3"
        ButtonAnsC.Show()
    End Sub

    Private Sub DEGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEGToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 180 / Math.PI
        functions.Show()
        functions.Text = "RAD => DEG"
        oplabel.Text = ""
        TextBox2.Text = "*180/π"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub NeperoButt_Click(sender As Object, e As EventArgs) Handles NeperoButt.Click
        TextBox1.Text = 2.71828182846
    End Sub
    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = Math.Cos(TextBox1.Text)
        functions.Text = ""
        TextBox2.Text = "cos"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = True
        Button29.Enabled = True
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox2.Text = "%"
        TextBox3.Text = (TextBox1.Text / 100)
        functions.Text = ""
        oplabel.Text = ""
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = True
        Button29.Enabled = True
    End Sub

    Private Sub Button32_Click_1(sender As Object, e As EventArgs) Handles Button32.Click
        TextBox1.Text = "-"
    End Sub

    Private Sub EspButton_Click(sender As Object, e As EventArgs) Handles EspButton.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = Factorial(TextBox1.Text)
        TextBox2.Text = "fact"
        functions.Text = ""
        oplabel.Text = "!"
        rooting.Hide()
        exproot.Hide()
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        xEsp.Enabled = True
        Button29.Enabled = True
        ButtonAnsC.Show()
    End Sub

    Private Sub Button1000_Click(sender As Object, e As EventArgs) Handles Button1000.Click
        TextBox2.Text = TextBox2.Text & “-”
    End Sub

    Private Sub Del1_Click(sender As Object, e As EventArgs) Handles Del1.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
        Error1.Text = ""
        rooting.Hide()
        exproot.Hide()
        oplabel.Text = ""
        ButtonAnsC.Hide()
    End Sub

    Private Sub Del2_Click(sender As Object, e As EventArgs) Handles Del2.Click
        Error1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        xEsp.Enabled = True
        Button29.Enabled = True
        functions.Text = ""
        rooting.Hide()
        exproot.Hide()
        oplabel.Text = ""
        ButtonAnsC.Hide()
    End Sub



    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        TextBox2.Text = 2.71828182846
    End Sub

    Private Sub GreekPi2_Click(sender As Object, e As EventArgs) Handles GreekPi2.Click
        TextBox2.Text = Math.PI
    End Sub


    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        rooting.Hide()
        exproot.Hide()
        TextBox3.Text = Math.Log(TextBox1.Text)
        TextBox2.Text = "log"
        functions.Text = ""
        xEsp.Enabled = True
        Button29.Enabled = True
        ButtonAnsC.Show()
    End Sub

    Private Sub Ans_Click(sender As Object, e As EventArgs) Handles Ans.Click
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        xEsp.Enabled = True
        Button29.Enabled = True
        functions.Text = ""
        TextBox1.Text = TextBox3.Text
        TextBox2.Text = ""
        TextBox3.Text = ""
        oplabel.Text = ""
    End Sub

    Private Sub ButtonAnsC_Click(sender As Object, e As EventArgs) Handles ButtonAnsC.Click
        My.Computer.Clipboard.SetText(TextBox1.Text & oplabel.Text & TextBox2.Text & "=" & TextBox3.Text)
        MsgBox("Copied with success!")
    End Sub

    Private Sub FormulasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulasToolStripMenuItem.Click
        Formulas.Show()
    End Sub

    Private Sub RADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RADToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        rooting.Hide()
        exproot.Hide()
        TextBox3.Text = TextBox1.Text * Math.PI / 180
        functions.Show()
        TextBox2.Text = "*π/180"
        oplabel.Text = ""
        functions.Text = "DEG => RAD"
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub INVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INVToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        rooting.Hide()
        exproot.Hide()
        TextBox3.Text = TextBox1.Text * 180 / 200
        functions.Show()
        TextBox2.Text = "*180/200"
        oplabel.Text = ""
        functions.Text = "GRAD => DEG"
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub GRADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GRADToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        rooting.Hide()
        exproot.Hide()
        TextBox3.Text = TextBox1.Text * Math.PI / 200
        functions.Show()
        TextBox2.Text = "*π/200"
        oplabel.Text = ""
        functions.Text = "GRAD => RAD"
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub RADGRADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RADGRADToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        rooting.Hide()
        exproot.Hide()
        TextBox3.Text = TextBox1.Text * 200 / Math.PI
        functions.Show()
        TextBox2.Text = "*200/π"
        oplabel.Text = ""
        functions.Text = "RAD => GRAD"
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DEGGRADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEGGRADToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        rooting.Hide()
        exproot.Hide()
        TextBox3.Text = TextBox1.Text * 200 / 180
        functions.Show()
        TextBox2.Text = "*200/180"
        oplabel.Text = ""
        functions.Text = "DEG => GRAD"
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub FunctionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunctionsToolStripMenuItem.Click

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox1.Text = TextBox1.Text & “,”
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        TextBox2.Text = TextBox2.Text & “,”
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub LinearEquationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinearEquationsToolStripMenuItem.Click

    End Sub

    Private Sub NormalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem1.Click
        Linearequations.Show()
        Me.Close()
    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedToolStripMenuItem.Click
        LinEquationTriple.Show()
        Me.Close()
    End Sub
    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversionToolStripMenuItem.Click

    End Sub
    Private Sub KmHmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmHmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "k => h"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub KmDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmDamToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 100
        TextBox2.Text = "*100"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "k => da"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub KmMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmMToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 1000
        TextBox2.Text = "*1000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "k => u"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub KmDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmDmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 10000
        TextBox2.Text = "*10000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "k => d"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub KmCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmCmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 100000
        TextBox2.Text = "*100000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "k => c"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub KmMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmMmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 1000000
        TextBox2.Text = "*1000000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "k => m"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmKmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmKmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "h => k"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmDamToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "h => k"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmMToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 100
        TextBox2.Text = "*100"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "h => u"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmDmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 1000
        TextBox2.Text = "*1000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "h => d"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmCmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 10000
        TextBox2.Text = "*10000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "h => c"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmMmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 100000
        TextBox2.Text = "*100000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "h => m"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamKmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamKmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 100
        TextBox2.Text = "/100"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "da => k"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamHmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamHmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "da => h"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamMToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "da => u"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamDmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 100
        TextBox2.Text = "*100"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "da => d"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamCmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 1000
        TextBox2.Text = "*1000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "da => c"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamMmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 10000
        TextBox2.Text = "*10000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "da => m"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MKmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MKmToolStripMenuItem1.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 1000
        TextBox2.Text = "/1000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "u => k"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MHmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MHmToolStripMenuItem1.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 100
        TextBox2.Text = "/100"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "u => h"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MDamToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MDamToolStripMenuItem1.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "u => da"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MDmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "u => d"
    End Sub

    Private Sub MCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MCmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 100
        TextBox2.Text = "*100"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "u => c"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MMmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 1000
        TextBox2.Text = "*1000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "u => m"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmKmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmKmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 10000
        TextBox2.Text = "/10000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "d => k"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmHmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmHmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 1000
        TextBox2.Text = "/1000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "d => h"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmDamToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 100
        TextBox2.Text = "/100"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "d => da"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmMToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "d => u"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmCmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "d => c"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmMmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 100
        TextBox2.Text = "*100"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "d => m"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub CmKmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CmKmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 100000
        TextBox2.Text = "/100000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "c => k"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub
    Private Sub CmDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CmDamToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 10000
        TextBox2.Text = "/10000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "c => h"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 1000
        TextBox2.Text = "/1000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "c => da"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub CmMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CmMToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 100
        TextBox2.Text = "/100"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "c => u"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub CmDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CmDmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "c => d"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub CmMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CmMmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "c => m"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmKmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MmKmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 1000000
        TextBox2.Text = "/1000000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "mm => km"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MmCmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 100000
        TextBox2.Text = "/100000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "mm => hm"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MmDamToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 10000
        TextBox2.Text = "/10000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "mm => dam"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmMToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MmMToolStripMenuItem1.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 1000
        TextBox2.Text = "/1000"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "mm => m"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MmDmToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 100
        TextBox2.Text = "/100"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "mm => dm"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmCmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MmCmToolStripMenuItem1.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        oplabel.Text = ""
        functions.Show()
        functions.Text = "mm => cm"
        rooting.Hide()
        exproot.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub ThemeSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Scientific_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        If FormWindowState.Maximized = True Then
            TextBox3.MaximumSize = New System.Drawing.Size(370, 76)
        End If
        TextBox3.MaximumSize = New System.Drawing.Size(302, 76)

    End Sub

    Private Sub FirstToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FirstToolStripMenuItem.Click
        fstequ.Show()
        Me.Close()
    End Sub

    Private Sub UnitOfMeasureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitOfMeasureToolStripMenuItem.Click
        Programmer.Show()
        Me.Close()
    End Sub

    Private Sub ButtonBackspace1_Click(sender As Object, e As EventArgs) Handles ButtonBackspace1.Click
        If TextBox1.Text < " " Then
            TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1 + 1)
        Else
            TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1)
        End If
    End Sub

    Private Sub ButtonBackspace2_Click(sender As Object, e As EventArgs) Handles ButtonBackspace2.Click
        If TextBox2.Text < " " Then
            TextBox2.Text = Mid(TextBox2.Text, 1, Len(TextBox2.Text) - 1 + 1)
        Else
            TextBox2.Text = Mid(TextBox2.Text, 1, Len(TextBox2.Text) - 1)
        End If
    End Sub

    Private Sub BinaryAdditionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinaryAdditionToolStripMenuItem.Click
        Me.Close()
        BinaryOp.Show()
    End Sub

    Private Sub FirstToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FirstToolStripMenuItem1.Click
        Me.Close()
        Inequalities.Show()
    End Sub

    Private Sub FastMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastMenuToolStripMenuItem.Click
        FastMenu.Show()
    End Sub

    Private Sub GraphicsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GraphicsToolStripMenuItem1.Click
        Math_Graphics.Show()
    End Sub

    Private Sub SecondToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecondToolStripMenuItem.Click
        sndequ.Show()
        Me.Close()
    End Sub

    Private Sub PlusButt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusButt.Click
        rooting.Hide()
        exproot.Hide()
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        TextBox3.Text = (a + b)
        oplabel.Text = "+"
        functions.Text = ""
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        If (TextBox2.Text = "") Then
            TextBox2.Text = "0"
        End If
        ButtonAnsC.Show()
    End Sub
End Class