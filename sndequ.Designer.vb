<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sndequ
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sndequ))
        Me.title = New System.Windows.Forms.Label()
        Me.Minimizea = New System.Windows.Forms.Label()
        Me.Closea = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.a = New System.Windows.Forms.TextBox()
        Me.b = New System.Windows.Forms.TextBox()
        Me.c = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.delta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.Label()
        Me.n1 = New System.Windows.Forms.Label()
        Me.dn = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.r1 = New System.Windows.Forms.Label()
        Me.r2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.errrs = New System.Windows.Forms.Label()
        Me.retta = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ProgrammerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.SystemColors.Control
        Me.title.Location = New System.Drawing.Point(19, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(220, 22)
        Me.title.TabIndex = 142
        Me.title.Text = "Second Degree Equations"
        '
        'Minimizea
        '
        Me.Minimizea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizea.AutoSize = True
        Me.Minimizea.BackColor = System.Drawing.Color.Transparent
        Me.Minimizea.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimizea.Location = New System.Drawing.Point(1272, -5)
        Me.Minimizea.Name = "Minimizea"
        Me.Minimizea.Size = New System.Drawing.Size(30, 40)
        Me.Minimizea.TabIndex = 141
        Me.Minimizea.Text = "-"
        '
        'Closea
        '
        Me.Closea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closea.AutoSize = True
        Me.Closea.BackColor = System.Drawing.Color.Transparent
        Me.Closea.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closea.Location = New System.Drawing.Point(1309, -2)
        Me.Closea.Name = "Closea"
        Me.Closea.Size = New System.Drawing.Size(37, 37)
        Me.Closea.TabIndex = 140
        Me.Closea.Text = "X"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlText
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.FastMenuToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(23, 33)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(400, 28)
        Me.MenuStrip1.TabIndex = 205
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
        'a
        '
        Me.a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.a.BackColor = System.Drawing.SystemColors.ControlText
        Me.a.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.ForeColor = System.Drawing.SystemColors.Window
        Me.a.Location = New System.Drawing.Point(12, 121)
        Me.a.Multiline = True
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(345, 56)
        Me.a.TabIndex = 206
        '
        'b
        '
        Me.b.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.b.BackColor = System.Drawing.SystemColors.ControlText
        Me.b.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.ForeColor = System.Drawing.SystemColors.Window
        Me.b.Location = New System.Drawing.Point(437, 120)
        Me.b.Multiline = True
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(375, 57)
        Me.b.TabIndex = 207
        '
        'c
        '
        Me.c.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.c.BackColor = System.Drawing.SystemColors.ControlText
        Me.c.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.ForeColor = System.Drawing.SystemColors.Window
        Me.c.Location = New System.Drawing.Point(876, 117)
        Me.c.Multiline = True
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(329, 60)
        Me.c.TabIndex = 208
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(366, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 25)
        Me.Label1.TabIndex = 209
        Me.Label1.Text = "x"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 25)
        Me.Label2.TabIndex = 210
        Me.Label2.Text = "2"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(818, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 25)
        Me.Label3.TabIndex = 211
        Me.Label3.Text = "x"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(474, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 37)
        Me.Button1.TabIndex = 212
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(407, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 25)
        Me.Label4.TabIndex = 213
        Me.Label4.Text = "+"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(846, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 25)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "+"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1245, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 51)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "= 0"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(127, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 36)
        Me.Label6.TabIndex = 216
        Me.Label6.Text = "Δ = b^2 - 4ac ="
        '
        'delta
        '
        Me.delta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.delta.BackColor = System.Drawing.SystemColors.ControlText
        Me.delta.Enabled = False
        Me.delta.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delta.ForeColor = System.Drawing.SystemColors.Window
        Me.delta.Location = New System.Drawing.Point(355, 307)
        Me.delta.Multiline = True
        Me.delta.Name = "delta"
        Me.delta.Size = New System.Drawing.Size(378, 46)
        Me.delta.TabIndex = 217
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(91, 482)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 36)
        Me.Label8.TabIndex = 218
        Me.Label8.Text = "x(1,2) ="
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(350, 482)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 22)
        Me.Label9.TabIndex = 220
        Me.Label9.Text = "+/-"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(388, 459)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 51)
        Me.Label10.TabIndex = 222
        Me.Label10.Text = "√"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(414, 452)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(217, 16)
        Me.Label11.TabIndex = 223
        Me.Label11.Text = "______________________________"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(225, 511)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(406, 16)
        Me.Label12.TabIndex = 224
        Me.Label12.Text = "_________________________________________________________"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(643, 506)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 51)
        Me.Label13.TabIndex = 226
        Me.Label13.Text = "="
        '
        'dt
        '
        Me.dt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dt.AutoSize = True
        Me.dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(430, 469)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(150, 38)
        Me.dt.TabIndex = 227
        Me.dt.Text = "b^2 - 4ac"
        '
        'n1
        '
        Me.n1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.n1.AutoSize = True
        Me.n1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n1.Location = New System.Drawing.Point(281, 468)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(46, 38)
        Me.n1.TabIndex = 228
        Me.n1.Text = "-b"
        '
        'dn
        '
        Me.dn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dn.AutoSize = True
        Me.dn.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dn.Location = New System.Drawing.Point(390, 548)
        Me.dn.Name = "dn"
        Me.dn.Size = New System.Drawing.Size(53, 38)
        Me.dn.TabIndex = 229
        Me.dn.Text = "2a"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(735, 396)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 36)
        Me.Label19.TabIndex = 232
        Me.Label19.Text = "x1 = "
        '
        'r1
        '
        Me.r1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.r1.AutoSize = True
        Me.r1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.Location = New System.Drawing.Point(822, 396)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(0, 36)
        Me.r1.TabIndex = 233
        '
        'r2
        '
        Me.r2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.r2.AutoSize = True
        Me.r2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r2.Location = New System.Drawing.Point(822, 506)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(0, 36)
        Me.r2.TabIndex = 235
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(735, 506)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 36)
        Me.Label22.TabIndex = 234
        Me.Label22.Text = "x2 = "
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(704, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 37)
        Me.Button2.TabIndex = 236
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'errrs
        '
        Me.errrs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.errrs.AutoSize = True
        Me.errrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errrs.Location = New System.Drawing.Point(1062, 434)
        Me.errrs.Name = "errrs"
        Me.errrs.Size = New System.Drawing.Size(0, 38)
        Me.errrs.TabIndex = 237
        '
        'retta
        '
        Me.retta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.retta.AutoSize = True
        Me.retta.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retta.Location = New System.Drawing.Point(787, 587)
        Me.retta.Name = "retta"
        Me.retta.Size = New System.Drawing.Size(0, 38)
        Me.retta.TabIndex = 238
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(147, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 29)
        Me.Label14.TabIndex = 239
        Me.Label14.Text = "ax^2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(606, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 29)
        Me.Label15.TabIndex = 240
        Me.Label15.Text = "bx"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1027, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 29)
        Me.Label16.TabIndex = 241
        Me.Label16.Text = "c"
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
        'sndequ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(1348, 643)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.retta)
        Me.Controls.Add(Me.errrs)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.r2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.r1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.dn)
        Me.Controls.Add(Me.n1)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.delta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Minimizea)
        Me.Controls.Add(Me.Closea)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "sndequ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BetaCloud Calculator (Second Degree Equations)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As Label
    Friend WithEvents Minimizea As Label
    Friend WithEvents Closea As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents a As TextBox
    Friend WithEvents b As TextBox
    Friend WithEvents c As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents delta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dt As Label
    Friend WithEvents n1 As Label
    Friend WithEvents dn As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents r1 As Label
    Friend WithEvents r2 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents errrs As Label
    Friend WithEvents retta As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ProgrammerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastMenuToolStripMenuItem As ToolStripMenuItem
End Class
