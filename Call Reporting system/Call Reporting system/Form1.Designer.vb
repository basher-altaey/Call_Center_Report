<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EmployeeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.dateTextBox = New System.Windows.Forms.TextBox()
        Me.TotalsuccessfulcallsTextBox = New System.Windows.Forms.TextBox()
        Me.TotalphonetimeTextBox = New System.Windows.Forms.TextBox()
        Me.TotalhoursworkedTextBox = New System.Windows.Forms.TextBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.totalcallsTextBox = New System.Windows.Forms.TextBox()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.PrintAllPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WriteToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(29, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(29, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date dd/mm/yy"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Location = New System.Drawing.Point(29, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total successful calls"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(29, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Amount of telphone Time (min)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(29, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total  Amount of Hours worked"
        '
        'EmployeeIDComboBox
        '
        Me.EmployeeIDComboBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.EmployeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmployeeIDComboBox.FormattingEnabled = True
        Me.EmployeeIDComboBox.Location = New System.Drawing.Point(329, 93)
        Me.EmployeeIDComboBox.Name = "EmployeeIDComboBox"
        Me.EmployeeIDComboBox.Size = New System.Drawing.Size(125, 21)
        Me.EmployeeIDComboBox.TabIndex = 1
        '
        'dateTextBox
        '
        Me.dateTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.dateTextBox.ForeColor = System.Drawing.Color.Red
        Me.dateTextBox.Location = New System.Drawing.Point(329, 132)
        Me.dateTextBox.Name = "dateTextBox"
        Me.dateTextBox.Size = New System.Drawing.Size(125, 20)
        Me.dateTextBox.TabIndex = 2
        Me.dateTextBox.Text = "dd/mm/yy"
        Me.dateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalsuccessfulcallsTextBox
        '
        Me.TotalsuccessfulcallsTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalsuccessfulcallsTextBox.Location = New System.Drawing.Point(329, 218)
        Me.TotalsuccessfulcallsTextBox.Name = "TotalsuccessfulcallsTextBox"
        Me.TotalsuccessfulcallsTextBox.Size = New System.Drawing.Size(125, 20)
        Me.TotalsuccessfulcallsTextBox.TabIndex = 4
        '
        'TotalphonetimeTextBox
        '
        Me.TotalphonetimeTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalphonetimeTextBox.Location = New System.Drawing.Point(329, 254)
        Me.TotalphonetimeTextBox.Name = "TotalphonetimeTextBox"
        Me.TotalphonetimeTextBox.Size = New System.Drawing.Size(125, 20)
        Me.TotalphonetimeTextBox.TabIndex = 5
        '
        'TotalhoursworkedTextBox
        '
        Me.TotalhoursworkedTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalhoursworkedTextBox.Location = New System.Drawing.Point(329, 302)
        Me.TotalhoursworkedTextBox.Name = "TotalhoursworkedTextBox"
        Me.TotalhoursworkedTextBox.Size = New System.Drawing.Size(125, 20)
        Me.TotalhoursworkedTextBox.TabIndex = 6
        '
        'saveButton
        '
        Me.saveButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.saveButton.Location = New System.Drawing.Point(32, 392)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 7
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.clearButton.Location = New System.Drawing.Point(266, 392)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 10
        Me.clearButton.Text = "ClearButton"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(183, 27)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(0, 29)
        Me.nameLabel.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label6.Location = New System.Drawing.Point(29, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Calls"
        '
        'totalcallsTextBox
        '
        Me.totalcallsTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.totalcallsTextBox.Location = New System.Drawing.Point(329, 174)
        Me.totalcallsTextBox.Name = "totalcallsTextBox"
        Me.totalcallsTextBox.Size = New System.Drawing.Size(125, 20)
        Me.totalcallsTextBox.TabIndex = 3
        '
        'displayButton
        '
        Me.displayButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.displayButton.Location = New System.Drawing.Point(153, 392)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(75, 23)
        Me.displayButton.TabIndex = 9
        Me.displayButton.Text = "Display"
        Me.displayButton.UseVisualStyleBackColor = False
        '
        'PrintAllPrintDocument
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WriteToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'WriteToolStripMenuItem
        '
        Me.WriteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WriteToFileToolStripMenuItem})
        Me.WriteToolStripMenuItem.Name = "WriteToolStripMenuItem"
        Me.WriteToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.WriteToolStripMenuItem.Text = "Write"
        '
        'WriteToFileToolStripMenuItem
        '
        Me.WriteToFileToolStripMenuItem.Name = "WriteToFileToolStripMenuItem"
        Me.WriteToFileToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.WriteToFileToolStripMenuItem.Text = "Write to File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(397, 392)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 14
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(611, 439)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.TotalhoursworkedTextBox)
        Me.Controls.Add(Me.TotalphonetimeTextBox)
        Me.Controls.Add(Me.totalcallsTextBox)
        Me.Controls.Add(Me.TotalsuccessfulcallsTextBox)
        Me.Controls.Add(Me.dateTextBox)
        Me.Controls.Add(Me.EmployeeIDComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents EmployeeIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents dateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalsuccessfulcallsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalphonetimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalhoursworkedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents totalcallsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents PrintAllPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WriteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WriteToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
