<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportBug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportBug))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BugBox = New System.Windows.Forms.TextBox()
        Me.BtnSubmitBug = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Describe the bug you found in the text box:"
        '
        'BugBox
        '
        Me.BugBox.Location = New System.Drawing.Point(13, 30)
        Me.BugBox.Multiline = True
        Me.BugBox.Name = "BugBox"
        Me.BugBox.Size = New System.Drawing.Size(259, 188)
        Me.BugBox.TabIndex = 1
        Me.BugBox.Text = "This isnt working right..."
        '
        'BtnSubmitBug
        '
        Me.BtnSubmitBug.Location = New System.Drawing.Point(197, 227)
        Me.BtnSubmitBug.Name = "BtnSubmitBug"
        Me.BtnSubmitBug.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmitBug.TabIndex = 2
        Me.BtnSubmitBug.Text = "Submit Bug"
        Me.BtnSubmitBug.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(12, 227)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormReportBug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSubmitBug)
        Me.Controls.Add(Me.BugBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReportBug"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report A Bug"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BugBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnSubmitBug As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
