Imports System
Imports System.Resources
Imports System.IO



Public Class Form1
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''FUNCTIONS''''''''''''''''''''''''''''''''''''
    Public Sub writesettings(ByVal day)
        Dim mrd As String = "My.Resources." & Day
        Dim mrt As String = "My.Resources." & day & "_Time"


        Using writer As StreamWriter = New StreamWriter(mrd)
            For Each i As String In ListBox_Jobs.Items
                writer.WriteLine(i)
            Next
        End Using
        Using writer As StreamWriter = New StreamWriter(mrt)
            For Each i As String In ListBox_Hours.Items
                writer.WriteLine(i)
            Next
        End Using
    End Sub

    Public Sub uploadlisttosettings()
        Dim d As String = ComboBox_date.SelectedItem

        If d = "Monday" Then
            My.Settings.monday_jobs.Clear()

            My.Settings.monday_date = TextBox_date.Text

        ElseIf d = "Tuesday" Then
            writesettings(d)
            My.Settings.tuesday_date = TextBox_date.Text

        ElseIf d = "Wesnesday" Then
            writesettings(d)
            My.Settings.wednesday_date = TextBox_date.Text

        ElseIf d = "Thursday" Then
            writesettings(d)
            My.Settings.thursday_date = TextBox_date.Text

        ElseIf d = "Friday" Then
            writesettings(d)
            My.Settings.Friday_Date = TextBox_date.Text

        ElseIf d = "Saturday" Then
            writesettings(d)
            My.Settings.saturday_date = TextBox_date.Text

        ElseIf d = "Sunday" Then
            writesettings(d)
            My.Settings.sunday_date = TextBox_date.Text
        End If

        My.Settings.Save()
    End Sub

    

    Public Sub downloadsettings()

        Dim d As String = ComboBox_date.SelectedItem

        If d = "Monday" Then
            Using reader As StreamReader = New StreamReader(My.Resources.Monday)
                For Each i As String In reader.ReadLine()
                    ListBox_Jobs.Items.Add(i)
                Next
            End Using
            Using reader As StreamReader = New StreamReader(My.Resources.Monday_time)
                For Each i As String In reader.ReadLine()
                    ListBox_Hours.Items.Add(i)
                Next
            End Using


        ElseIf d = "Tuesday" Then
            Using reader As StreamReader = New StreamReader(My.Resources.Tuesday)
                For Each i As String In reader.ReadLine()
                    ListBox_Jobs.Items.Add(i)
                Next
            End Using
            Using reader As StreamReader = New StreamReader(My.Resources.Tuesday_time)
                For Each i As String In reader.ReadLine()
                    ListBox_Hours.Items.Add(i)
                Next
            End Using


        ElseIf d = "Wednesday" Then
            Using reader As StreamReader = New StreamReader(My.Resources.Wednesday)
                For Each i As String In reader.ReadLine()
                    ListBox_Jobs.Items.Add(i)
                Next
            End Using
            Using reader As StreamReader = New StreamReader(My.Resources.Wednesday_Time)
                For Each i As String In reader.ReadLine()
                    ListBox_Hours.Items.Add(i)
                Next
            End Using



        ElseIf d = "Thursday" Then
            Using reader As StreamReader = New StreamReader(My.Resources.Thursday)
                For Each i As String In reader.ReadLine()
                    ListBox_Jobs.Items.Add(i)
                Next
            End Using
            Using reader As StreamReader = New StreamReader(My.Resources.Thursday_Time)
                For Each i As String In reader.ReadLine()
                    ListBox_Hours.Items.Add(i)
                Next
            End Using



        ElseIf d = "Friday" Then
            Using reader As StreamReader = New StreamReader(My.Resources.Friday)
                For Each i As String In reader.ReadLine()
                    ListBox_Jobs.Items.Add(i)
                Next
            End Using
            Using reader As StreamReader = New StreamReader(My.Resources.Friday_Time)
                For Each i As String In reader.ReadLine()
                    ListBox_Hours.Items.Add(i)
                Next
            End Using



        ElseIf d = "Saturday" Then
            Using reader As StreamReader = New StreamReader(My.Resources.Saturday)
                For Each i As String In reader.ReadLine()
                    ListBox_Jobs.Items.Add(i)
                Next
            End Using
            Using reader As StreamReader = New StreamReader(My.Resources.Saturday_time)
                For Each i As String In reader.ReadLine()
                    ListBox_Hours.Items.Add(i)
                Next
            End Using



        ElseIf d = "Sunday" Then
            Using reader As StreamReader = New StreamReader(My.Resources.Sunday)
                For Each i As String In reader.ReadLine()
                    ListBox_Jobs.Items.Add(i)
                Next
            End Using
            Using reader As StreamReader = New StreamReader(My.Resources.Sunday_time)
                For Each i As String In reader.ReadLine()
                    ListBox_Hours.Items.Add(i)
                Next
            End Using



        End If

    End Sub

    Public Sub showpanel_splash(ByVal v As Object)
        Me.Width = 400
        Me.Height = 250

        Panel_bug.Visible = False
        Panel_Editjob.Visible = False
        Panel_Foilthunder.Visible = False
        Panel_Jobs.Visible = False
        Panel_Northshorelogo.Visible = False
        Panel_review.Visible = False
        Panel_sugestion.Visible = False
        Panel_User.Visible = False
        Panel_Whatsnew.Visible = False
        Panel_Timesheet.Visible = False
        StatusStrip1.Visible = False
        MenuStrip1.Visible = False

        v.Location = New Point(0, 27)
        v.Visible = True

    End Sub

    Public Sub showPanel(ByVal v As Object)
        Me.Width = 400
        Me.Height = 250

        Panel_bug.Visible = False
        Panel_Editjob.Visible = False
        Panel_Foilthunder.Visible = False
        Panel_Jobs.Visible = False
        Panel_Northshorelogo.Visible = False
        Panel_review.Visible = False
        Panel_sugestion.Visible = False
        Panel_User.Visible = False
        Panel_Whatsnew.Visible = False
        Panel_Timesheet.Visible = False

        StatusStrip1.Visible = True
        MenuStrip1.Visible = True

        v.Location = New Point(0, 27)
        v.Visible = True

        If Panel_review.Visible = True Then
            Me.Width = 400
            Me.Height = 550
        End If

    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''END FUNCTIONS''''''''''''''''''''''''''''''''''''

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showpanel_splash(Panel_Northshorelogo)
        Timer_Splash.Enabled = True

        Dim d As Date = Now
        Dim ds As String = Format(d, "dddd").ToString
        ComboBox_date.SelectedItem = ds

        DatePicker.CustomFormat = ""
        'MessageBox.Show(My.Settings.Friday_Jobs)


    End Sub

    Private Sub Timer_Splash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Splash.Tick
        If Panel_Foilthunder.Visible = True Then
            showPanel(Panel_Timesheet)
            Timer_Splash.Enabled = False
        ElseIf Panel_Northshorelogo.Visible = True Then
            showpanel_splash(Panel_Foilthunder)

        End If
    End Sub

    Private Sub ComboBox_date_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_date.SelectedIndexChanged
        Dim d As String = ComboBox_date.SelectedItem

        If d = "Monday" Then
            TextBox_date.Text = My.Settings.monday_date
            downloadsettings()
        ElseIf d = "Tuesday" Then
            TextBox_date.Text = My.Settings.tuesday_date
            downloadsettings()
        ElseIf d = "Wesnesday" Then
            TextBox_date.Text = My.Settings.wednesday_date
            downloadsettings()
        ElseIf d = "Thursday" Then
            TextBox_date.Text = My.Settings.thursday_date
            downloadsettings()
        ElseIf d = "Friday" Then
            TextBox_date.Text = My.Settings.Friday_Date
            downloadsettings()
        ElseIf d = "Saturday" Then
            TextBox_date.Text = My.Settings.saturday_date
            downloadsettings()
        ElseIf d = "Sunday" Then
            TextBox_date.Text = My.Settings.sunday_date
            downloadsettings()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        My.Settings.Save()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        My.Settings.Save()
        Close()

    End Sub

    Private Sub PublishTimeSheetNowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PublishTimeSheetNowToolStripMenuItem.Click
        showPanel(Panel_review)

    End Sub

    Private Sub ReportABugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportABugToolStripMenuItem.Click
        showPanel(Panel_bug)
    End Sub

    Private Sub MakeASugestionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeASugestionToolStripMenuItem.Click
        showPanel(Panel_sugestion)

    End Sub

    Private Sub UserAccountSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountSetupToolStripMenuItem.Click
        showPanel(Panel_User)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox_date.SelectedItem = "" Then
            MessageBox.Show("Select a day to start working", "Oops")
        Else
            showPanel(Panel_Jobs)
        End If
    End Sub

    Private Sub ComboBox2_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedValueChanged
        'Edit Job Entry
        'Delete(Job)
        'Clear Whole Day
        Dim sj As String = ListBox_Jobs.SelectedItem
        If sj <> "" Then
            If ComboBox2.SelectedItem = "Edit Job Entry" Then
                My.Settings.oldedit = sj
                showPanel(Panel_Editjob)
                uploadlisttosettings()
            ElseIf ComboBox2.SelectedItem = "Delete Job" Then
                Dim si As Integer = ListBox_Jobs.SelectedIndex
                ListBox_Jobs.Items.RemoveAt(si)
                ListBox_Hours.Items.RemoveAt(si)
                uploadlisttosettings()
            ElseIf ComboBox2.SelectedItem = "Clear Whole Day" Then
                ListBox_Hours.Items.Clear()
                ListBox_Jobs.Items.Clear()
                uploadlisttosettings()
            End If

        Else
            MessageBox.Show("You didnt pick a job to edit", "Oops")
        End If
    End Sub

    Private Sub Form1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        uploadlisttosettings()

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        uploadlisttosettings()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class
