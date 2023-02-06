<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fstequ
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fstequ))
        Me.a = New System.Windows.Forms.TextBox()
        Me.b = New System.Windows.Forms.TextBox()
        Me.c = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Minimizea = New System.Windows.Forms.Label()
        Me.Closea = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.a1 = New System.Windows.Forms.TextBox()
        Me.a2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgrammerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'a
        '
        Me.a.BackColor = System.Drawing.SystemColors.ControlText
        Me.a.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.ForeColor = System.Drawing.SystemColors.Control
        Me.a.Location = New System.Drawing.Point(86, 97)
        Me.a.Multiline = True
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(195, 44)
        Me.a.TabIndex = 0
        '
        'b
        '
        Me.b.BackColor = System.Drawing.SystemColors.ControlText
        Me.b.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.ForeColor = System.Drawing.SystemColors.Control
        Me.b.Location = New System.Drawing.Point(322, 97)
        Me.b.Multiline = True
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(195, 44)
        Me.b.TabIndex = 1
        '
        'c
        '
        Me.c.BackColor = System.Drawing.SystemColors.ControlText
        Me.c.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.ForeColor = System.Drawing.SystemColors.Control
        Me.c.Location = New System.Drawing.Point(562, 97)
        Me.c.Multiline = True
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(195, 44)
        Me.c.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "+"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(528, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "="
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(829, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Minimizea
        '
        Me.Minimizea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizea.AutoSize = True
        Me.Minimizea.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimizea.Location = New System.Drawing.Point(928, -5)
        Me.Minimizea.Name = "Minimizea"
        Me.Minimizea.Size = New System.Drawing.Size(30, 40)
        Me.Minimizea.TabIndex = 98
        Me.Minimizea.Text = "-"
        '
        'Closea
        '
        Me.Closea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closea.AutoSize = True
        Me.Closea.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closea.Location = New System.Drawing.Point(965, -2)
        Me.Closea.Name = "Closea"
        Me.Closea.Size = New System.Drawing.Size(37, 37)
        Me.Closea.TabIndex = 97
        Me.Closea.Text = "X"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.SystemColors.Control
        Me.title.Location = New System.Drawing.Point(21, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(194, 22)
        Me.title.TabIndex = 132
        Me.title.Text = "First Degree Equations"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(829, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 31)
        Me.Button2.TabIndex = 133
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 35)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "x ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "x"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlText
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.TextBox2.Location = New System.Drawing.Point(314, 226)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(400, 44)
        Me.TextBox2.TabIndex = 137
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlText
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.FastMenuToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(25, 43)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(401, 28)
        Me.MenuStrip1.TabIndex = 138
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalActualToolStripMenuItem, Me.ScientificToolStripMenuItem, Me.ProgrammerToolStripMenuItem})
        Me.CalculatorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NormalActualToolStripMenuItem
        '
        Me.NormalActualToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.NormalActualToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.NormalActualToolStripMenuItem.Name = "NormalActualToolStripMenuItem"
        Me.NormalActualToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NormalActualToolStripMenuItem.Text = "Standard"
        '
        'ScientificToolStripMenuItem
        '
        Me.ScientificToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.ScientificToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem"
        Me.ScientificToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ScientificToolStripMenuItem.Text = "Scientific"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(182, 395)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 32)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "FRACTION:"
        '
        'a1
        '
        Me.a1.BackColor = System.Drawing.SystemColors.ControlText
        Me.a1.Enabled = False
        Me.a1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a1.ForeColor = System.Drawing.SystemColors.Control
        Me.a1.Location = New System.Drawing.Point(386, 363)
        Me.a1.Multiline = True
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(195, 44)
        Me.a1.TabIndex = 140
        '
        'a2
        '
        Me.a2.BackColor = System.Drawing.SystemColors.ControlText
        Me.a2.Enabled = False
        Me.a2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a2.ForeColor = System.Drawing.SystemColors.Control
        Me.a2.Location = New System.Drawing.Point(386, 440)
        Me.a2.Multiline = True
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(195, 44)
        Me.a2.TabIndex = 141
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(386, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 32)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "____________"
        '
        'ProgrammerToolStripMenuItem
        '
        Me.ProgrammerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.ProgrammerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ProgrammerToolStripMenuItem.Name = "ProgrammerToolStripMenuItem"
        Me.ProgrammerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ProgrammerToolStripMenuItem.Text = "Programmer"
        '
        'FastMenuToolStripMenuItem
        '
        Me.FastMenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.FastMenuToolStripMenuItem.Name = "FastMenuToolStripMenuItem"
        Me.FastMenuToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.FastMenuToolStripMenuItem.Text = "Fast Menu"
        '
        'fstequ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(1005, 572)
        Me.Controls.Add(Me.a2)
        Me.Controls.Add(Me.a1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Minimizea)
        Me.Controls.Add(Me.Closea)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fstequ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BetaCloud Calculator (1st Degree Equations)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents a As TextBox
    Friend WithEvents b As TextBox
    Friend WithEvents c As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Minimizea As Label
    Friend WithEvents Closea As Label
    Friend WithEvents title As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents a1 As TextBox
    Friend WithEvents a2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ProgrammerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastMenuToolStripMenuItem As ToolStripMenuItem
End Class
