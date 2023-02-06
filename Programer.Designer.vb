<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Programmer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programmer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minimizea = New System.Windows.Forms.Label()
        Me.Closea = New System.Windows.Forms.Label()
        Me.Butt0 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtCalc = New System.Windows.Forms.Button()
        Me.Resetr = New System.Windows.Forms.Button()
        Me.Butt1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammerActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinaryAdditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BinToDec = New System.Windows.Forms.CheckBox()
        Me.DecToBin = New System.Windows.Forms.CheckBox()
        Me.Butt2 = New System.Windows.Forms.Button()
        Me.Butt3 = New System.Windows.Forms.Button()
        Me.Butt4 = New System.Windows.Forms.Button()
        Me.Butt5 = New System.Windows.Forms.Button()
        Me.Butt7 = New System.Windows.Forms.Button()
        Me.Butt8 = New System.Windows.Forms.Button()
        Me.Butt6 = New System.Windows.Forms.Button()
        Me.Butt9 = New System.Windows.Forms.Button()
        Me.F2 = New System.Windows.Forms.Label()
        Me.F1 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DecToOct = New System.Windows.Forms.CheckBox()
        Me.OctToDec = New System.Windows.Forms.CheckBox()
        Me.information = New System.Windows.Forms.Label()
        Me.OctToHex = New System.Windows.Forms.CheckBox()
        Me.OctToBin = New System.Windows.Forms.CheckBox()
        Me.DecToHex = New System.Windows.Forms.CheckBox()
        Me.BintoOct = New System.Windows.Forms.CheckBox()
        Me.BinToHex = New System.Windows.Forms.CheckBox()
        Me.HexToOct = New System.Windows.Forms.CheckBox()
        Me.HexToBin = New System.Windows.Forms.CheckBox()
        Me.HexToDec = New System.Windows.Forms.CheckBox()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.ButtonB = New System.Windows.Forms.Button()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.ButtonD = New System.Windows.Forms.Button()
        Me.ButtonF = New System.Windows.Forms.Button()
        Me.ButtonE = New System.Windows.Forms.Button()
        Me.BinToAsc = New System.Windows.Forms.CheckBox()
        Me.ButtonBackspace = New System.Windows.Forms.Button()
        Me.Pastes = New System.Windows.Forms.Button()
        Me.copies = New System.Windows.Forms.Button()
        Me.FastMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 22)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Programmer Calculator"
        '
        'Minimizea
        '
        Me.Minimizea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizea.AutoSize = True
        Me.Minimizea.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimizea.Location = New System.Drawing.Point(745, -5)
        Me.Minimizea.Name = "Minimizea"
        Me.Minimizea.Size = New System.Drawing.Size(30, 40)
        Me.Minimizea.TabIndex = 78
        Me.Minimizea.Text = "-"
        '
        'Closea
        '
        Me.Closea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closea.AutoSize = True
        Me.Closea.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closea.Location = New System.Drawing.Point(781, -2)
        Me.Closea.Name = "Closea"
        Me.Closea.Size = New System.Drawing.Size(37, 37)
        Me.Closea.TabIndex = 77
        Me.Closea.Text = "X"
        '
        'Butt0
        '
        Me.Butt0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt0.Enabled = False
        Me.Butt0.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Butt0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt0.Location = New System.Drawing.Point(360, 644)
        Me.Butt0.Name = "Butt0"
        Me.Butt0.Size = New System.Drawing.Size(96, 53)
        Me.Butt0.TabIndex = 74
        Me.Butt0.Text = "0"
        Me.Butt0.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(188, 57)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(447, 58)
        Me.TextBox1.TabIndex = 72
        '
        'ButtCalc
        '
        Me.ButtCalc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtCalc.Enabled = False
        Me.ButtCalc.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.ButtCalc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtCalc.Location = New System.Drawing.Point(208, 723)
        Me.ButtCalc.Name = "ButtCalc"
        Me.ButtCalc.Size = New System.Drawing.Size(400, 42)
        Me.ButtCalc.TabIndex = 71
        Me.ButtCalc.Text = "="
        Me.ButtCalc.UseVisualStyleBackColor = True
        '
        'Resetr
        '
        Me.Resetr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Resetr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Resetr.Location = New System.Drawing.Point(133, 424)
        Me.Resetr.Name = "Resetr"
        Me.Resetr.Size = New System.Drawing.Size(75, 23)
        Me.Resetr.TabIndex = 70
        Me.Resetr.Text = "Reset"
        Me.Resetr.UseVisualStyleBackColor = True
        '
        'Butt1
        '
        Me.Butt1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt1.Enabled = False
        Me.Butt1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butt1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt1.Location = New System.Drawing.Point(234, 424)
        Me.Butt1.Name = "Butt1"
        Me.Butt1.Size = New System.Drawing.Size(96, 53)
        Me.Butt1.TabIndex = 58
        Me.Butt1.Text = "1"
        Me.Butt1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlText
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.FastMenuToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 31)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(401, 28)
        Me.MenuStrip1.TabIndex = 75
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalActualToolStripMenuItem, Me.ScientificToolStripMenuItem, Me.ProgrammerActualToolStripMenuItem})
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
        Me.NormalActualToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.NormalActualToolStripMenuItem.Text = "Standard"
        '
        'ScientificToolStripMenuItem
        '
        Me.ScientificToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.ScientificToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem"
        Me.ScientificToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ScientificToolStripMenuItem.Text = "Scientific"
        '
        'ProgrammerActualToolStripMenuItem
        '
        Me.ProgrammerActualToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.ProgrammerActualToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BinaryAdditionToolStripMenuItem})
        Me.ProgrammerActualToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ProgrammerActualToolStripMenuItem.Name = "ProgrammerActualToolStripMenuItem"
        Me.ProgrammerActualToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ProgrammerActualToolStripMenuItem.Text = "Programmer (Actual)"
        '
        'BinaryAdditionToolStripMenuItem
        '
        Me.BinaryAdditionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.BinaryAdditionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.BinaryAdditionToolStripMenuItem.Name = "BinaryAdditionToolStripMenuItem"
        Me.BinaryAdditionToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.BinaryAdditionToolStripMenuItem.Text = "Binary Addition"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(188, 148)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(447, 58)
        Me.TextBox2.TabIndex = 80
        '
        'BinToDec
        '
        Me.BinToDec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BinToDec.AutoSize = True
        Me.BinToDec.Location = New System.Drawing.Point(162, 238)
        Me.BinToDec.Name = "BinToDec"
        Me.BinToDec.Size = New System.Drawing.Size(134, 20)
        Me.BinToDec.TabIndex = 81
        Me.BinToDec.Text = "Binary -> Decimal"
        Me.BinToDec.UseVisualStyleBackColor = True
        '
        'DecToBin
        '
        Me.DecToBin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DecToBin.AutoSize = True
        Me.DecToBin.Location = New System.Drawing.Point(322, 238)
        Me.DecToBin.Name = "DecToBin"
        Me.DecToBin.Size = New System.Drawing.Size(134, 20)
        Me.DecToBin.TabIndex = 82
        Me.DecToBin.Text = "Decimal -> Binary"
        Me.DecToBin.UseVisualStyleBackColor = True
        '
        'Butt2
        '
        Me.Butt2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt2.Enabled = False
        Me.Butt2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Butt2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt2.Location = New System.Drawing.Point(360, 424)
        Me.Butt2.Name = "Butt2"
        Me.Butt2.Size = New System.Drawing.Size(96, 53)
        Me.Butt2.TabIndex = 84
        Me.Butt2.Text = "2"
        Me.Butt2.UseVisualStyleBackColor = True
        '
        'Butt3
        '
        Me.Butt3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt3.Enabled = False
        Me.Butt3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butt3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt3.Location = New System.Drawing.Point(474, 424)
        Me.Butt3.Name = "Butt3"
        Me.Butt3.Size = New System.Drawing.Size(96, 53)
        Me.Butt3.TabIndex = 83
        Me.Butt3.Text = "3"
        Me.Butt3.UseVisualStyleBackColor = True
        '
        'Butt4
        '
        Me.Butt4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt4.Enabled = False
        Me.Butt4.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Butt4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt4.Location = New System.Drawing.Point(234, 496)
        Me.Butt4.Name = "Butt4"
        Me.Butt4.Size = New System.Drawing.Size(96, 53)
        Me.Butt4.TabIndex = 86
        Me.Butt4.Text = "4"
        Me.Butt4.UseVisualStyleBackColor = True
        '
        'Butt5
        '
        Me.Butt5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt5.Enabled = False
        Me.Butt5.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butt5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt5.Location = New System.Drawing.Point(360, 496)
        Me.Butt5.Name = "Butt5"
        Me.Butt5.Size = New System.Drawing.Size(96, 53)
        Me.Butt5.TabIndex = 85
        Me.Butt5.Text = "5"
        Me.Butt5.UseVisualStyleBackColor = True
        '
        'Butt7
        '
        Me.Butt7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt7.Enabled = False
        Me.Butt7.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Butt7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt7.Location = New System.Drawing.Point(234, 575)
        Me.Butt7.Name = "Butt7"
        Me.Butt7.Size = New System.Drawing.Size(96, 53)
        Me.Butt7.TabIndex = 88
        Me.Butt7.Text = "7"
        Me.Butt7.UseVisualStyleBackColor = True
        '
        'Butt8
        '
        Me.Butt8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt8.Enabled = False
        Me.Butt8.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butt8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt8.Location = New System.Drawing.Point(360, 575)
        Me.Butt8.Name = "Butt8"
        Me.Butt8.Size = New System.Drawing.Size(96, 53)
        Me.Butt8.TabIndex = 87
        Me.Butt8.Text = "8"
        Me.Butt8.UseVisualStyleBackColor = True
        '
        'Butt6
        '
        Me.Butt6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt6.Enabled = False
        Me.Butt6.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Butt6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt6.Location = New System.Drawing.Point(474, 496)
        Me.Butt6.Name = "Butt6"
        Me.Butt6.Size = New System.Drawing.Size(96, 53)
        Me.Butt6.TabIndex = 90
        Me.Butt6.Text = "6"
        Me.Butt6.UseVisualStyleBackColor = True
        '
        'Butt9
        '
        Me.Butt9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt9.Enabled = False
        Me.Butt9.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Butt9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt9.Location = New System.Drawing.Point(474, 575)
        Me.Butt9.Name = "Butt9"
        Me.Butt9.Size = New System.Drawing.Size(96, 53)
        Me.Butt9.TabIndex = 91
        Me.Butt9.Text = "9"
        Me.Butt9.UseVisualStyleBackColor = True
        '
        'F2
        '
        Me.F2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.F2.AutoSize = True
        Me.F2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F2.Location = New System.Drawing.Point(661, 148)
        Me.F2.Name = "F2"
        Me.F2.Size = New System.Drawing.Size(0, 22)
        Me.F2.TabIndex = 92
        '
        'F1
        '
        Me.F1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.F1.AutoSize = True
        Me.F1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F1.Location = New System.Drawing.Point(661, 70)
        Me.F1.Name = "F1"
        Me.F1.Size = New System.Drawing.Size(0, 22)
        Me.F1.TabIndex = 93
        '
        'Button10
        '
        Me.Button10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button10.Location = New System.Drawing.Point(133, 453)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 94
        Me.Button10.Tag = ""
        Me.Button10.Text = "Del1"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'DecToOct
        '
        Me.DecToOct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DecToOct.AutoSize = True
        Me.DecToOct.Location = New System.Drawing.Point(322, 266)
        Me.DecToOct.Name = "DecToOct"
        Me.DecToOct.Size = New System.Drawing.Size(127, 20)
        Me.DecToOct.TabIndex = 96
        Me.DecToOct.Text = "Decimal -> Octal"
        Me.DecToOct.UseVisualStyleBackColor = True
        '
        'OctToDec
        '
        Me.OctToDec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OctToDec.AutoSize = True
        Me.OctToDec.Location = New System.Drawing.Point(520, 238)
        Me.OctToDec.Name = "OctToDec"
        Me.OctToDec.Size = New System.Drawing.Size(127, 20)
        Me.OctToDec.TabIndex = 95
        Me.OctToDec.Text = "Octal -> Decimal"
        Me.OctToDec.UseVisualStyleBackColor = True
        '
        'information
        '
        Me.information.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.information.AutoSize = True
        Me.information.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.information.Location = New System.Drawing.Point(599, 596)
        Me.information.Name = "information"
        Me.information.Size = New System.Drawing.Size(176, 20)
        Me.information.TabIndex = 97
        Me.information.Text = "Hexadecimal numbers"
        '
        'OctToHex
        '
        Me.OctToHex.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OctToHex.AutoSize = True
        Me.OctToHex.Location = New System.Drawing.Point(520, 292)
        Me.OctToHex.Name = "OctToHex"
        Me.OctToHex.Size = New System.Drawing.Size(157, 20)
        Me.OctToHex.TabIndex = 101
        Me.OctToHex.Text = "Octal -> Hexadecimal"
        Me.OctToHex.UseVisualStyleBackColor = True
        '
        'OctToBin
        '
        Me.OctToBin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OctToBin.AutoSize = True
        Me.OctToBin.Location = New System.Drawing.Point(520, 266)
        Me.OctToBin.Name = "OctToBin"
        Me.OctToBin.Size = New System.Drawing.Size(115, 20)
        Me.OctToBin.TabIndex = 100
        Me.OctToBin.Text = "Octal -> Binary"
        Me.OctToBin.UseVisualStyleBackColor = True
        '
        'DecToHex
        '
        Me.DecToHex.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DecToHex.AutoSize = True
        Me.DecToHex.Location = New System.Drawing.Point(322, 292)
        Me.DecToHex.Name = "DecToHex"
        Me.DecToHex.Size = New System.Drawing.Size(176, 20)
        Me.DecToHex.TabIndex = 99
        Me.DecToHex.Text = "Decimal -> Hexadecimal"
        Me.DecToHex.UseVisualStyleBackColor = True
        '
        'BintoOct
        '
        Me.BintoOct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BintoOct.AutoSize = True
        Me.BintoOct.Location = New System.Drawing.Point(162, 266)
        Me.BintoOct.Name = "BintoOct"
        Me.BintoOct.Size = New System.Drawing.Size(115, 20)
        Me.BintoOct.TabIndex = 98
        Me.BintoOct.Text = "Binary -> Octal"
        Me.BintoOct.UseVisualStyleBackColor = True
        '
        'BinToHex
        '
        Me.BinToHex.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BinToHex.AutoSize = True
        Me.BinToHex.Location = New System.Drawing.Point(162, 292)
        Me.BinToHex.Name = "BinToHex"
        Me.BinToHex.Size = New System.Drawing.Size(164, 20)
        Me.BinToHex.TabIndex = 102
        Me.BinToHex.Text = "Binary -> Hexadecimal"
        Me.BinToHex.UseVisualStyleBackColor = True
        '
        'HexToOct
        '
        Me.HexToOct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HexToOct.AutoSize = True
        Me.HexToOct.Location = New System.Drawing.Point(322, 389)
        Me.HexToOct.Name = "HexToOct"
        Me.HexToOct.Size = New System.Drawing.Size(157, 20)
        Me.HexToOct.TabIndex = 105
        Me.HexToOct.Text = "Hexadecimal -> Octal"
        Me.HexToOct.UseVisualStyleBackColor = True
        '
        'HexToBin
        '
        Me.HexToBin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HexToBin.AutoSize = True
        Me.HexToBin.Location = New System.Drawing.Point(322, 363)
        Me.HexToBin.Name = "HexToBin"
        Me.HexToBin.Size = New System.Drawing.Size(164, 20)
        Me.HexToBin.TabIndex = 104
        Me.HexToBin.Text = "Hexadecimal -> Binary"
        Me.HexToBin.UseVisualStyleBackColor = True
        '
        'HexToDec
        '
        Me.HexToDec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HexToDec.AutoSize = True
        Me.HexToDec.Location = New System.Drawing.Point(322, 335)
        Me.HexToDec.Name = "HexToDec"
        Me.HexToDec.Size = New System.Drawing.Size(176, 20)
        Me.HexToDec.TabIndex = 103
        Me.HexToDec.Text = "Hexadecimal -> Decimal"
        Me.HexToDec.UseVisualStyleBackColor = True
        '
        'ButtonC
        '
        Me.ButtonC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonC.Enabled = False
        Me.ButtonC.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.ButtonC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonC.Location = New System.Drawing.Point(612, 485)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(66, 40)
        Me.ButtonC.TabIndex = 108
        Me.ButtonC.Text = "C"
        Me.ButtonC.UseVisualStyleBackColor = True
        '
        'ButtonB
        '
        Me.ButtonB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonB.Enabled = False
        Me.ButtonB.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.ButtonB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonB.Location = New System.Drawing.Point(702, 425)
        Me.ButtonB.Name = "ButtonB"
        Me.ButtonB.Size = New System.Drawing.Size(66, 40)
        Me.ButtonB.TabIndex = 107
        Me.ButtonB.Text = "B"
        Me.ButtonB.UseVisualStyleBackColor = True
        '
        'ButtonA
        '
        Me.ButtonA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonA.Enabled = False
        Me.ButtonA.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonA.Location = New System.Drawing.Point(612, 425)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(66, 40)
        Me.ButtonA.TabIndex = 106
        Me.ButtonA.Text = "A"
        Me.ButtonA.UseVisualStyleBackColor = True
        '
        'ButtonD
        '
        Me.ButtonD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonD.Enabled = False
        Me.ButtonD.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.ButtonD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonD.Location = New System.Drawing.Point(702, 485)
        Me.ButtonD.Name = "ButtonD"
        Me.ButtonD.Size = New System.Drawing.Size(66, 40)
        Me.ButtonD.TabIndex = 109
        Me.ButtonD.Text = "D"
        Me.ButtonD.UseVisualStyleBackColor = True
        '
        'ButtonF
        '
        Me.ButtonF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonF.Enabled = False
        Me.ButtonF.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.ButtonF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonF.Location = New System.Drawing.Point(702, 544)
        Me.ButtonF.Name = "ButtonF"
        Me.ButtonF.Size = New System.Drawing.Size(66, 40)
        Me.ButtonF.TabIndex = 111
        Me.ButtonF.Text = "F"
        Me.ButtonF.UseVisualStyleBackColor = True
        '
        'ButtonE
        '
        Me.ButtonE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonE.Enabled = False
        Me.ButtonE.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonE.Location = New System.Drawing.Point(612, 544)
        Me.ButtonE.Name = "ButtonE"
        Me.ButtonE.Size = New System.Drawing.Size(66, 40)
        Me.ButtonE.TabIndex = 110
        Me.ButtonE.Text = "E"
        Me.ButtonE.UseVisualStyleBackColor = True
        '
        'BinToAsc
        '
        Me.BinToAsc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BinToAsc.AutoSize = True
        Me.BinToAsc.Location = New System.Drawing.Point(162, 318)
        Me.BinToAsc.Name = "BinToAsc"
        Me.BinToAsc.Size = New System.Drawing.Size(117, 20)
        Me.BinToAsc.TabIndex = 112
        Me.BinToAsc.Text = "Binary -> ASCII"
        Me.BinToAsc.UseVisualStyleBackColor = True
        '
        'ButtonBackspace
        '
        Me.ButtonBackspace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonBackspace.Enabled = False
        Me.ButtonBackspace.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.ButtonBackspace.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonBackspace.Location = New System.Drawing.Point(474, 644)
        Me.ButtonBackspace.Name = "ButtonBackspace"
        Me.ButtonBackspace.Size = New System.Drawing.Size(96, 53)
        Me.ButtonBackspace.TabIndex = 113
        Me.ButtonBackspace.Text = "←"
        Me.ButtonBackspace.UseVisualStyleBackColor = True
        '
        'Pastes
        '
        Me.Pastes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pastes.Enabled = False
        Me.Pastes.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pastes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Pastes.Location = New System.Drawing.Point(41, 70)
        Me.Pastes.Name = "Pastes"
        Me.Pastes.Size = New System.Drawing.Size(86, 45)
        Me.Pastes.TabIndex = 114
        Me.Pastes.Text = "Paste"
        Me.Pastes.UseVisualStyleBackColor = True
        '
        'copies
        '
        Me.copies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.copies.Enabled = False
        Me.copies.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copies.ForeColor = System.Drawing.SystemColors.ControlText
        Me.copies.Location = New System.Drawing.Point(41, 159)
        Me.copies.Name = "copies"
        Me.copies.Size = New System.Drawing.Size(86, 47)
        Me.copies.TabIndex = 115
        Me.copies.Text = "Copy"
        Me.copies.UseVisualStyleBackColor = True
        '
        'FastMenuToolStripMenuItem
        '
        Me.FastMenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.FastMenuToolStripMenuItem.Name = "FastMenuToolStripMenuItem"
        Me.FastMenuToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.FastMenuToolStripMenuItem.Text = "Fast Menu"
        '
        'Programmer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(820, 894)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.copies)
        Me.Controls.Add(Me.Pastes)
        Me.Controls.Add(Me.ButtonBackspace)
        Me.Controls.Add(Me.BinToAsc)
        Me.Controls.Add(Me.ButtonF)
        Me.Controls.Add(Me.ButtonE)
        Me.Controls.Add(Me.ButtonD)
        Me.Controls.Add(Me.ButtonC)
        Me.Controls.Add(Me.ButtonB)
        Me.Controls.Add(Me.ButtonA)
        Me.Controls.Add(Me.HexToOct)
        Me.Controls.Add(Me.HexToBin)
        Me.Controls.Add(Me.HexToDec)
        Me.Controls.Add(Me.DecToHex)
        Me.Controls.Add(Me.BinToHex)
        Me.Controls.Add(Me.OctToHex)
        Me.Controls.Add(Me.OctToBin)
        Me.Controls.Add(Me.BintoOct)
        Me.Controls.Add(Me.information)
        Me.Controls.Add(Me.DecToOct)
        Me.Controls.Add(Me.OctToDec)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.F1)
        Me.Controls.Add(Me.F2)
        Me.Controls.Add(Me.Butt9)
        Me.Controls.Add(Me.Butt6)
        Me.Controls.Add(Me.Butt7)
        Me.Controls.Add(Me.Butt8)
        Me.Controls.Add(Me.Butt4)
        Me.Controls.Add(Me.Butt5)
        Me.Controls.Add(Me.Butt2)
        Me.Controls.Add(Me.Butt3)
        Me.Controls.Add(Me.DecToBin)
        Me.Controls.Add(Me.BinToDec)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Minimizea)
        Me.Controls.Add(Me.Closea)
        Me.Controls.Add(Me.Butt0)
        Me.Controls.Add(Me.ButtCalc)
        Me.Controls.Add(Me.Resetr)
        Me.Controls.Add(Me.Butt1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Programmer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BetaCloud Calculator (Programmer)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Minimizea As Label
    Friend WithEvents Closea As Label
    Friend WithEvents Butt0 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtCalc As Button
    Friend WithEvents Resetr As Button
    Friend WithEvents Butt1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgrammerActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BinToDec As CheckBox
    Friend WithEvents DecToBin As CheckBox
    Friend WithEvents Butt2 As Button
    Friend WithEvents Butt3 As Button
    Friend WithEvents Butt4 As Button
    Friend WithEvents Butt5 As Button
    Friend WithEvents Butt7 As Button
    Friend WithEvents Butt8 As Button
    Friend WithEvents Butt6 As Button
    Friend WithEvents Butt9 As Button
    Friend WithEvents F2 As Label
    Friend WithEvents F1 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents DecToOct As CheckBox
    Friend WithEvents OctToDec As CheckBox
    Friend WithEvents information As Label
    Friend WithEvents OctToHex As CheckBox
    Friend WithEvents OctToBin As CheckBox
    Friend WithEvents DecToHex As CheckBox
    Friend WithEvents BintoOct As CheckBox
    Friend WithEvents BinToHex As CheckBox
    Friend WithEvents HexToOct As CheckBox
    Friend WithEvents HexToBin As CheckBox
    Friend WithEvents HexToDec As CheckBox
    Friend WithEvents ButtonC As Button
    Friend WithEvents ButtonB As Button
    Friend WithEvents ButtonA As Button
    Friend WithEvents ButtonD As Button
    Friend WithEvents ButtonF As Button
    Friend WithEvents ButtonE As Button
    Friend WithEvents BinToAsc As CheckBox
    Friend WithEvents ButtonBackspace As Button
    Friend WithEvents Pastes As Button
    Friend WithEvents copies As Button
    Friend WithEvents BinaryAdditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastMenuToolStripMenuItem As ToolStripMenuItem
End Class
