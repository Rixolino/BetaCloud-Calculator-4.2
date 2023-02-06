Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports MetroApps
Imports Windows.UI.ViewManagement
Public Class Normal
    Dim a, b
    Dim op As String
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Dim m
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
    <DllImport("user32.dll")>
    Public Shared Function SystemParametersInfo(ByVal uAction As Integer, ByVal uParam As Integer, ByRef lpvParam As Integer, ByVal fuWinIni As Integer) As Integer
    End Function

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
    Private Const SPI_GETNONCLIENTMETRICS As Integer = 41
    Private Const SPI_SETNONCLIENTMETRICS As Integer = 42
    Private Const SPIF_UPDATEINIFILE As Integer = &H1

    Sub SwitchMode()
        If SystemInformation.HighContrast = True Then
            Me.BackColor = Color.DarkGray
            Me.ForeColor = Color.White
        Else
            Me.BackColor = Color.White
            Me.ForeColor = Color.Black
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Butt1.Click
        TextBox1.Text = TextBox1.Text & “1”
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Butt2.Click
        TextBox1.Text = TextBox1.Text & “2”
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Butt3.Click
        TextBox1.Text = TextBox1.Text & “3”
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Butt4.Click
        TextBox1.Text = TextBox1.Text & “4”
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Butt5.Click
        TextBox1.Text = TextBox1.Text & “5”
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Butt6.Click
        TextBox1.Text = TextBox1.Text & “6”
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Butt7.Click
        TextBox1.Text = TextBox1.Text & “7”
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Butt8.Click
        TextBox1.Text = TextBox1.Text & “8”
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Butt9.Click
        TextBox1.Text = TextBox1.Text & “9”
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Butt0.Click
        TextBox1.Text = TextBox1.Text & “0”
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Plus.Click
        a = CDbl(TextBox1.Text)
        op = “+”
        TextBox1.Text = “”
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Molt.Click
        a = CDbl(TextBox1.Text)
        op = “*”
        TextBox1.Text = “”
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Div.Click
        a = CDbl(TextBox1.Text)
        op = “/”
        TextBox1.Text = “”
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = “”

    End Sub

    Private Sub ScOpen_Click(sender As Object, e As EventArgs)
        Scientific.Show()
        Me.Hide()
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        TextBox1.Text = “”
        Me.Hide()
        Scientific.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles minx.Click
        TextBox1.Text = "-"
    End Sub

    Private Sub Copy_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ThemeSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        Me.Hide()
        Programmer.Show()
    End Sub

    Private Sub ButtonBackspace_Click(sender As Object, e As EventArgs) Handles ButtonBackspace.Click
        If TextBox1.Text < " " Then
            TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1 + 1)
        Else
            TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1)
        End If
    End Sub

    Private Sub BinaryAdditionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinaryAdditionToolStripMenuItem.Click
        Me.Hide()
        BinaryOp.Show()
    End Sub

    Private Sub FastMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastMenuToolStripMenuItem.Click
        FastMenu.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Minus.Click
        a = CDbl(TextBox1.Text)
        op = “-”
        TextBox1.Text = “”
    End Sub
End Class
