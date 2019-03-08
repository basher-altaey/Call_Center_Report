<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
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
        Me.reportDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.reportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportDataGridView
        '
        Me.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reportDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.reportDataGridView.Name = "reportDataGridView"
        Me.reportDataGridView.Size = New System.Drawing.Size(468, 366)
        Me.reportDataGridView.TabIndex = 0
        '
        'report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 390)
        Me.Controls.Add(Me.reportDataGridView)
        Me.Name = "report"
        Me.Text = "Form1"
        CType(Me.reportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportDataGridView As System.Windows.Forms.DataGridView

End Class
