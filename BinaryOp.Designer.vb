<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BinaryOp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BinaryOp))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minimizea = New System.Windows.Forms.Label()
        Me.Closea = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammerActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinaryAdditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ButtCalc = New System.Windows.Forms.Button()
        Me.Resetr = New System.Windows.Forms.Button()
        Me.TextBox3BIN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2BIN = New System.Windows.Forms.TextBox()
        Me.TextBox1BIN = New System.Windows.Forms.TextBox()
        Me.copies = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.op = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(520, 22)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Programmer Calculator: Operation convertitor to binary numbers"
        '
        'Minimizea
        '
        Me.Minimizea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizea.AutoSize = True
        Me.Minimizea.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimizea.Location = New System.Drawing.Point(1136, -5)
        Me.Minimizea.Name = "Minimizea"
        Me.Minimizea.Size = New System.Drawing.Size(30, 40)
        Me.Minimizea.TabIndex = 82
        Me.Minimizea.Text = "-"
        '
        'Closea
        '
        Me.Closea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closea.AutoSize = True
        Me.Closea.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closea.Location = New System.Drawing.Point(1172, -2)
        Me.Closea.Name = "Closea"
        Me.Closea.Size = New System.Drawing.Size(37, 37)
        Me.Closea.TabIndex = 81
        Me.Closea.Text = "X"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlText
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.FastMenuToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(7, 31)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(251, 28)
        Me.MenuStrip1.TabIndex = 80
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
        Me.NormalActualToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.NormalActualToolStripMenuItem.Text = "Standard"
        '
        'ScientificToolStripMenuItem
        '
        Me.ScientificToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.ScientificToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem"
        Me.ScientificToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.ScientificToolStripMenuItem.Text = "Scientific"
        '
        'ProgrammerActualToolStripMenuItem
        '
        Me.ProgrammerActualToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.ProgrammerActualToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BinaryAdditionToolStripMenuItem})
        Me.ProgrammerActualToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ProgrammerActualToolStripMenuItem.Name = "ProgrammerActualToolStripMenuItem"
        Me.ProgrammerActualToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.ProgrammerActualToolStripMenuItem.Text = "Programmer"
        '
        'BinaryAdditionToolStripMenuItem
        '
        Me.BinaryAdditionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.BinaryAdditionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.BinaryAdditionToolStripMenuItem.Name = "BinaryAdditionToolStripMenuItem"
        Me.BinaryAdditionToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.BinaryAdditionToolStripMenuItem.Text = "Binary Addition (Actual)"
        '
        'FastMenuToolStripMenuItem
        '
        Me.FastMenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.FastMenuToolStripMenuItem.Name = "FastMenuToolStripMenuItem"
        Me.FastMenuToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.FastMenuToolStripMenuItem.Text = "Fast Menu"
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
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(115, 254)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(447, 58)
        Me.TextBox2.TabIndex = 95
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(115, 163)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(447, 58)
        Me.TextBox1.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(578, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "="
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(455, 16)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "________________________________________________________________"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox3.Location = New System.Drawing.Point(115, 367)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(447, 58)
        Me.TextBox3.TabIndex = 105
        '
        'ButtCalc
        '
        Me.ButtCalc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtCalc.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.ButtCalc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtCalc.Location = New System.Drawing.Point(110, 525)
        Me.ButtCalc.Name = "ButtCalc"
        Me.ButtCalc.Size = New System.Drawing.Size(452, 42)
        Me.ButtCalc.TabIndex = 106
        Me.ButtCalc.Text = "="
        Me.ButtCalc.UseVisualStyleBackColor = True
        '
        'Resetr
        '
        Me.Resetr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Resetr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Resetr.Location = New System.Drawing.Point(115, 446)
        Me.Resetr.Name = "Resetr"
        Me.Resetr.Size = New System.Drawing.Size(75, 23)
        Me.Resetr.TabIndex = 115
        Me.Resetr.Text = "Clear"
        Me.Resetr.UseVisualStyleBackColor = True
        '
        'TextBox3BIN
        '
        Me.TextBox3BIN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3BIN.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox3BIN.Enabled = False
        Me.TextBox3BIN.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.TextBox3BIN.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox3BIN.Location = New System.Drawing.Point(665, 367)
        Me.TextBox3BIN.Multiline = True
        Me.TextBox3BIN.Name = "TextBox3BIN"
        Me.TextBox3BIN.Size = New System.Drawing.Size(447, 58)
        Me.TextBox3BIN.TabIndex = 132
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(647, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(455, 16)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "________________________________________________________________"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1118, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 25)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "="
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1118, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 25)
        Me.Label7.TabIndex = 129
        '
        'TextBox2BIN
        '
        Me.TextBox2BIN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2BIN.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox2BIN.Enabled = False
        Me.TextBox2BIN.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.TextBox2BIN.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox2BIN.Location = New System.Drawing.Point(665, 254)
        Me.TextBox2BIN.Multiline = True
        Me.TextBox2BIN.Name = "TextBox2BIN"
        Me.TextBox2BIN.Size = New System.Drawing.Size(447, 58)
        Me.TextBox2BIN.TabIndex = 128
        '
        'TextBox1BIN
        '
        Me.TextBox1BIN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1BIN.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1BIN.Enabled = False
        Me.TextBox1BIN.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.TextBox1BIN.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1BIN.Location = New System.Drawing.Point(665, 163)
        Me.TextBox1BIN.Multiline = True
        Me.TextBox1BIN.Name = "TextBox1BIN"
        Me.TextBox1BIN.Size = New System.Drawing.Size(447, 58)
        Me.TextBox1BIN.TabIndex = 127
        '
        'copies
        '
        Me.copies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.copies.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copies.ForeColor = System.Drawing.SystemColors.ControlText
        Me.copies.Location = New System.Drawing.Point(668, 446)
        Me.copies.Name = "copies"
        Me.copies.Size = New System.Drawing.Size(86, 47)
        Me.copies.TabIndex = 133
        Me.copies.Text = "Copy"
        Me.copies.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(262, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 29)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "DECIMAL"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(821, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 29)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "BINARY"
        '
        'op
        '
        Me.op.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.op.BackColor = System.Drawing.SystemColors.ControlText
        Me.op.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.op.ForeColor = System.Drawing.SystemColors.Window
        Me.op.Location = New System.Drawing.Point(568, 174)
        Me.op.Multiline = True
        Me.op.Name = "op"
        Me.op.Size = New System.Drawing.Size(37, 33)
        Me.op.TabIndex = 208
        Me.op.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BinaryOp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(1209, 703)
        Me.Controls.Add(Me.op)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.copies)
        Me.Controls.Add(Me.TextBox3BIN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2BIN)
        Me.Controls.Add(Me.TextBox1BIN)
        Me.Controls.Add(Me.Resetr)
        Me.Controls.Add(Me.ButtCalc)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Minimizea)
        Me.Controls.Add(Me.Closea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BinaryOp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BetaCloud Calculator (Addition convertitor to binary numbers)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Minimizea As Label
    Friend WithEvents Closea As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ButtCalc As Button
    Friend WithEvents Resetr As Button
    Friend WithEvents TextBox3BIN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2BIN As TextBox
    Friend WithEvents TextBox1BIN As TextBox
    Friend WithEvents copies As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgrammerActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BinaryAdditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents op As TextBox
End Class
