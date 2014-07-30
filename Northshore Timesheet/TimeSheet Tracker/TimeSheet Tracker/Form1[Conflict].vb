Imports System
Imports System.Resources
Imports System.IO



Public Class Form1
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''FUNCTIONS''''''''''''''''''''''''''''''''''''
    Public Sub uploadlisttosettings()
        Dim d As String = ComboBox_date.SelectedItem
        Dim j As String = ListBox_Jobs.Items.Item(0) & "~" & ListBox_Hours.Items.IndexOf(0) & "|" & _
            ListBox_Jobs.Items.IndexOf(1) & "~" & ListBox_Hours.Items.IndexOf(1) & "|" & _
            ListBox_Jobs.Items.IndexOf(2) & "~" & ListBox_Hours.Items.IndexOf(2) & "|" & _
            ListBox_Jobs.Items.IndexOf(3) & "~" & ListBox_Hours.Items.IndexOf(3) & "|" & _
            ListBox_Jobs.Items.IndexOf(4) & "~" & ListBox_Hours.Items.IndexOf(4) & "|" & _
            ListBox_Jobs.Items.IndexOf(5) & "~" & ListBox_Hours.Items.IndexOf(5) & "|" & _
            ListBox_Jobs.Items.IndexOf(6) & "~" & ListBox_Hours.Items.IndexOf(6) & "|" & _
            ListBox_Jobs.Items.IndexOf(7) & "~" & ListBox_Hours.Items.IndexOf(7) & "|" & _
            ListBox_Jobs.Items.IndexOf(8) & "~" & ListBox_Hours.Items.IndexOf(8) & "|" & _
            ListBox_Jobs.Items.IndexOf(9) & "~" & ListBox_Hours.Items.IndexOf(9)


        If d = "Friday" Then
            My.Settings.Friday_Jobs = j
            My.Settings.Friday_Date = TextBox_date.Text
        End If

        My.Settings.Save()
    End Sub

    Public Sub Change_Date()

        Dim day_value As String = ComboBox_date.SelectedItem

        ListBox_Jobs.Items.Clear()
        ListBox_Hours.Items.Clear()

        If day_value = "Friday" Then
            Dim jobs() As String = My.Settings.Friday_Jobs.Split("|")

            For Each i As String In jobs
                Dim splice() As String = i.Split("~")
                ListBox_Jobs.Items.Add(splice(0))
                ListBox_Hours.Items.Add(splice(1))

            Next
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
        MessageBox.Show(My.Settings.Friday_Jobs)


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
            Change_Date()
        ElseIf d = "Friday" Then
            TextBox_date.Text = My.Settings.Friday_Date
            Change_Date()
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
            ElseIf ComboBox2.SelectedItem = "Delete Job" Then
                Dim si As Integer = ListBox_Jobs.SelectedIndex
                ListBox_Jobs.Items.RemoveAt(si)
                ListBox_Hours.Items.RemoveAt(si)
                uploadlisttosettings()

            ElseIf ComboBox2.SelectedItem = "Clear Whole Day" Then

                'ElseIf ComboBox2.SelectedItem = "" Then
            End If
        Else
            MessageBox.Show("You didnt pick a job to edit", "Oops")
        End If
    End Sub
End Class
