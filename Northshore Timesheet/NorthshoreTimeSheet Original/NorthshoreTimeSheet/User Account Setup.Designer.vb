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
        Me.Label65 = New System.Windows.Forms.Label()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Pay = New System.Windows.Forms.ComboBox()
        Me.title = New System.Windows.Forms.ComboBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.namebox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(12, 9)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(158, 18)
        Me.Label65.TabIndex = 46
        Me.Label65.Text = "User Account Setup"
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(219, 171)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 45
        Me.BtnOK.Text = "Ok"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'Pay
        '
        Me.Pay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Pay.FormattingEnabled = True
        Me.Pay.Items.AddRange(New Object() {"Salary", "Hourly"})
        Me.Pay.Location = New System.Drawing.Point(110, 121)
        Me.Pay.Name = "Pay"
        Me.Pay.Size = New System.Drawing.Size(184, 21)
        Me.Pay.TabIndex = 44
        '
        'title
        '
        Me.title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.title.FormattingEnabled = True
        Me.title.Items.AddRange(New Object() {"Accounting", "Estimator", "Officer", "Project Engineer", "Northshore - Project Manager", "NorthClad - Project Manager", "Other"})
        Me.title.Location = New System.Drawing.Point(110, 94)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(184, 21)
        Me.title.TabIndex = 43
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(13, 122)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(28, 13)
        Me.Label62.TabIndex = 42
        Me.Label62.Text = "Pay:"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(13, 96)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(50, 13)
        Me.Label63.TabIndex = 41
        Me.Label63.Text = "Job Title:"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(12, 71)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(92, 13)
        Me.Label64.TabIndex = 39
        Me.Label64.Text = "Name (First & Last):"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'namebox
        '
        Me.namebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.namebox.FormattingEnabled = True
        Me.namebox.Items.AddRange(New Object() {"Blue, Kristy", "Camp, Rocky", "Dardis, Heather", "Dudik, Chris", "Elbert, Brian", "Elbert, Dennis", "Evers, Michael", "Flatt, Justin", "Flatt, Karen", "Gouy, Kristi", "Gustafson, Jessica", "Gustafson, Joel", "Haertel, Brandan", "Haertel, Corey", "Heck, Al", "Hutchinson, Tina", "Johnson, Dino", "Killian, Dave", "Knudtson, Eric", "Masters, Dave", "McBee, Todd", "McBride, Miah", "Meyer, Jeff", "Wines, Cornellia"})
        Me.namebox.Location = New System.Drawing.Point(110, 67)
        Me.namebox.Name = "namebox"
        Me.namebox.Size = New System.Drawing.Size(184, 21)
        Me.namebox.TabIndex = 48
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 206)
        Me.Controls.Add(Me.namebox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.Pay)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label64)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Account Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents Pay As System.Windows.Forms.ComboBox
    Friend WithEvents title As System.Windows.Forms.ComboBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents namebox As System.Windows.Forms.ComboBox
End Class
