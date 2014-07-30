<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newjobcreatorform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newjobcreatorform))
        Me.ListBox_jobs = New System.Windows.Forms.ListBox()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Job = New System.Windows.Forms.TextBox()
        Me.Listbox_Workorder = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox_jobs
        '
        Me.ListBox_jobs.FormattingEnabled = True
        Me.ListBox_jobs.Location = New System.Drawing.Point(12, 68)
        Me.ListBox_jobs.Name = "ListBox_jobs"
        Me.ListBox_jobs.Size = New System.Drawing.Size(678, 225)
        Me.ListBox_jobs.TabIndex = 13
        '
        'Button_Start
        '
        Me.Button_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Start.Location = New System.Drawing.Point(605, 402)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(85, 34)
        Me.Button_Start.TabIndex = 12
        Me.Button_Start.Text = "Lets Start!"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Button_Exit
        '
        Me.Button_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Exit.Location = New System.Drawing.Point(12, 402)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(85, 34)
        Me.Button_Exit.TabIndex = 11
        Me.Button_Exit.Text = "Exit"
        Me.Button_Exit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Welcome, Please select a job to start!"
        '
        'TextBox_Job
        '
        Me.TextBox_Job.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Job.Location = New System.Drawing.Point(137, 374)
        Me.TextBox_Job.Name = "TextBox_Job"
        Me.TextBox_Job.Size = New System.Drawing.Size(553, 20)
        Me.TextBox_Job.TabIndex = 8
        '
        'Listbox_Workorder
        '
        Me.Listbox_Workorder.FormattingEnabled = True
        Me.Listbox_Workorder.Location = New System.Drawing.Point(12, 299)
        Me.Listbox_Workorder.Name = "Listbox_Workorder"
        Me.Listbox_Workorder.Size = New System.Drawing.Size(678, 69)
        Me.Listbox_Workorder.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Northshore"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Northclad"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Cad Job Folder Name..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(314, 427)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Location = New System.Drawing.Point(544, 41)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Password.Size = New System.Drawing.Size(146, 20)
        Me.TextBox_Password.TabIndex = 21
        '
        'newjobcreatorform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 448)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Listbox_Workorder)
        Me.Controls.Add(Me.ListBox_jobs)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.Button_Exit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Job)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "newjobcreatorform"
        Me.Text = "New Job Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox_jobs As System.Windows.Forms.ListBox
    Friend WithEvents Button_Start As System.Windows.Forms.Button
    Friend WithEvents Button_Exit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Job As System.Windows.Forms.TextBox
    Friend WithEvents Listbox_Workorder As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Password As System.Windows.Forms.TextBox
End Class
