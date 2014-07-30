Public Class Form1

    Dim SEARCHNOTE As String = "..."
    Dim SELECTEDJOB As String = String.Empty

    Public Sub saveSettings()
        If job1.Text <> "" Then
            If Hour1.Text = "" Then
                Hour1.Text = 0
            End If
            If minute1.Text = "" Then
                minute1.Text = 0
            End If
        End If

        If job2.Text <> "" Then
            If hour2.Text = "" Then
                hour2.Text = 0
            End If
            If minute2.Text = "" Then
                minute2.Text = 0
            End If
        End If

        If job3.Text <> "" Then
            If hour3.Text = "" Then
                hour3.Text = 0
            End If
            If minute3.Text = "" Then
                minute3.Text = 0
            End If
        End If

        If job4.Text <> "" Then
            If hour4.Text = "" Then
                hour4.Text = 0
            End If
            If minute4.Text = "" Then
                minute4.Text = 0
            End If
        End If

        If job5.Text <> "" Then
            If hour5.Text = "" Then
                hour5.Text = 0
            End If
            If minute5.Text = "" Then
                minute5.Text = 0
            End If
        End If

        If job6.Text <> "" Then
            If hour6.Text = "" Then
                hour6.Text = 0
            End If
            If minute6.Text = "" Then
                minute6.Text = 0
            End If
        End If

        If job7.Text <> "" Then
            If hour7.Text = "" Then
                hour7.Text = 0
            End If
            If minute7.Text = "" Then
                minute7.Text = 0
            End If
        End If

        If job8.Text <> "" Then
            If hour8.Text = "" Then
                hour8.Text = 0
            End If
            If minute8.Text = "" Then
                minute8.Text = 0
            End If
        End If

        If job9.Text <> "" Then
            If hour9.Text = "" Then
                hour9.Text = 0
            End If
            If minute9.Text = "" Then
                minute9.Text = 0
            End If
        End If

        If job10.Text <> "" Then
            If hour10.Text = "" Then
                hour10.Text = 0
            End If
            If minute10.Text = "" Then
                minute10.Text = 0
            End If
        End If

        If job11.Text <> "" Then
            If hour11.Text = "" Then
                hour11.Text = 0
            End If
            If minute11.Text = "" Then
                minute11.Text = 0
            End If
        End If

        If job12.Text <> "" Then
            If hour12.Text = "" Then
                hour12.Text = 0
            End If
            If minute12.Text = "" Then
                minute12.Text = 0
            End If
        End If

        If job13.Text <> "" Then
            If hour13.Text = "" Then
                hour13.Text = 0
            End If
            If minute13.Text = "" Then
                minute13.Text = 0
            End If
        End If

        If job14.Text <> "" Then
            If hour14.Text = "" Then
                hour14.Text = 0
            End If
            If minute14.Text = "" Then
                minute14.Text = 0
            End If
        End If

        If job15.Text <> "" Then
            If hour15.Text = "" Then
                hour15.Text = 0
            End If
            If minute15.Text = "" Then
                minute15.Text = 0
            End If
        End If

        If job16.Text <> "" Then
            If hour16.Text = "" Then
                hour16.Text = 0
            End If
            If minute16.Text = "" Then
                minute16.Text = 0
            End If
        End If


        If job17.Text <> "" Then
            If hour17.Text = "" Then
                hour17.Text = 0
            End If
            If minute17.Text = "" Then
                minute17.Text = 0
            End If
        End If

        If job18.Text <> "" Then
            If hour18.Text = "" Then
                hour18.Text = 0
            End If
            If minute18.Text = "" Then
                minute18.Text = 0
            End If
        End If

        If job19.Text <> "" Then
            If hour19.Text = "" Then
                hour19.Text = 0
            End If
            If minute19.Text = "" Then
                minute19.Text = 0
            End If
        End If

        If job20.Text <> "" Then
            If hour20.Text = "" Then
                hour20.Text = 0
            End If
            If minute20.Text = "" Then
                minute20.Text = 0
            End If
        End If

        If job21.Text <> "" Then
            If hour21.Text = "" Then
                hour21.Text = 0
            End If
            If minute21.Text = "" Then
                minute21.Text = 0
            End If
        End If

        If job22.Text <> "" Then
            If hour22.Text = "" Then
                hour22.Text = 0
            End If
            If minute22.Text = "" Then
                minute22.Text = 0
            End If
        End If

        If job1.Text <> "" Then
            If hour23.Text = "" Then
                hour23.Text = 0
            End If
            If minute23.Text = "" Then
                minute23.Text = 0
            End If
        End If

        If job24.Text <> "" Then
            If hour24.Text = "" Then
                hour24.Text = 0
            End If
            If minute24.Text = "" Then
                minute24.Text = 0
            End If
        End If

        If job25.Text <> "" Then
            If hour25.Text = "" Then
                hour25.Text = 0
            End If
            If minute25.Text = "" Then
                minute25.Text = 0
            End If
        End If

        'Try
        My.Settings.job1 = job1.Text
        My.Settings.job2 = job2.Text
        My.Settings.job3 = job3.Text
        My.Settings.job4 = job4.Text
        My.Settings.job5 = job5.Text
        My.Settings.job6 = job6.Text
        My.Settings.job7 = job7.Text
        My.Settings.job8 = job8.Text
        My.Settings.job9 = job9.Text
        My.Settings.job10 = job10.Text
        My.Settings.job11 = job11.Text
        My.Settings.job12 = job12.Text
        My.Settings.job13 = job13.Text
        My.Settings.job14 = job14.Text
        My.Settings.job15 = job15.Text
        My.Settings.job16 = job16.Text
        My.Settings.job17 = job17.Text
        My.Settings.job18 = job18.Text
        My.Settings.job19 = job19.Text
        My.Settings.job20 = job20.Text
        My.Settings.job21 = job21.Text
        My.Settings.job22 = job22.Text
        My.Settings.job23 = job23.Text
        My.Settings.job24 = job24.Text
        My.Settings.job25 = job25.Text
        My.Settings.date1 = date1.Text
        My.Settings.date2 = date2.Text
        My.Settings.date3 = date3.Text
        My.Settings.date4 = date4.Text
        My.Settings.date5 = date5.Text
        My.Settings.date6 = date6.Text
        My.Settings.date7 = date7.Text
        My.Settings.date8 = date8.Text
        My.Settings.date9 = date9.Text
        My.Settings.date10 = date10.Text
        My.Settings.date11 = date11.Text
        My.Settings.date12 = date12.Text
        My.Settings.date13 = date13.Text
        My.Settings.date14 = date14.Text
        My.Settings.date15 = date15.Text
        My.Settings.date16 = date16.Text
        My.Settings.date17 = date17.Text
        My.Settings.date18 = date18.Text
        My.Settings.date19 = date19.Text
        My.Settings.date20 = date20.Text
        My.Settings.date21 = date21.Text
        My.Settings.date22 = date22.Text
        My.Settings.date23 = date23.Text
        My.Settings.date24 = date24.Text
        My.Settings.date25 = date25.Text
        My.Settings.hr1 = Hour1.Text
        My.Settings.hr2 = hour2.Text
        My.Settings.hr3 = hour3.Text
        My.Settings.hr4 = hour4.Text
        My.Settings.hr5 = hour5.Text
        My.Settings.hr6 = hour6.Text
        My.Settings.hr7 = hour7.Text
        My.Settings.hr8 = hour8.Text
        My.Settings.hr9 = hour9.Text
        My.Settings.hr10 = hour10.Text
        My.Settings.hr11 = hour11.Text
        My.Settings.hr12 = hour12.Text
        My.Settings.hr13 = hour13.Text
        My.Settings.hr14 = hour14.Text
        My.Settings.hr15 = hour15.Text
        My.Settings.hr16 = hour16.Text
        My.Settings.hr17 = hour17.Text
        My.Settings.hr18 = hour18.Text
        My.Settings.hr19 = hour19.Text
        My.Settings.hr20 = hour20.Text
        My.Settings.hr21 = hour21.Text
        My.Settings.hr22 = hour22.Text
        My.Settings.hr23 = hour23.Text
        My.Settings.hr24 = hour24.Text
        My.Settings.hr25 = hour25.Text
        My.Settings.min1 = minute1.Text
        My.Settings.min2 = minute2.Text
        My.Settings.min3 = minute3.Text
        My.Settings.min4 = minute4.Text
        My.Settings.min5 = minute5.Text
        My.Settings.min6 = minute6.Text
        My.Settings.min7 = minute7.Text
        My.Settings.min8 = minute8.Text
        My.Settings.min9 = minute9.Text
        My.Settings.min10 = minute10.Text
        My.Settings.min11 = minute11.Text
        My.Settings.min12 = minute12.Text
        My.Settings.min13 = minute13.Text
        My.Settings.min14 = minute14.Text
        My.Settings.min15 = minute15.Text
        My.Settings.min16 = minute16.Text
        My.Settings.min17 = minute17.Text
        My.Settings.min18 = minute18.Text
        My.Settings.min19 = minute19.Text
        My.Settings.min20 = minute20.Text
        My.Settings.min21 = minute21.Text
        My.Settings.min22 = minute22.Text
        My.Settings.min23 = minute23.Text
        My.Settings.min24 = minute24.Text
        My.Settings.min25 = minute25.Text

        'Catch ex As Exception

        'End Try


    End Sub

    Public Sub loadSettings()
        job1.Text = My.Settings.job1
        job2.Text = My.Settings.job2
        job3.Text = My.Settings.job3
        job4.Text = My.Settings.job4
        job5.Text = My.Settings.job5
        job6.Text = My.Settings.job6
        job7.Text = My.Settings.job7
        job8.Text = My.Settings.job8
        job9.Text = My.Settings.job9
        job10.Text = My.Settings.job10
        job11.Text = My.Settings.job11
        job12.Text = My.Settings.job12
        job13.Text = My.Settings.job13
        job14.Text = My.Settings.job14
        job15.Text = My.Settings.job15
        job16.Text = My.Settings.job16
        job17.Text = My.Settings.job17
        job18.Text = My.Settings.job18
        job19.Text = My.Settings.job19
        job20.Text = My.Settings.job20
        job21.Text = My.Settings.job21
        job22.Text = My.Settings.job22
        job23.Text = My.Settings.job23
        job24.Text = My.Settings.job24
        job25.Text = My.Settings.job25
        date1.Text = My.Settings.date1
        date2.Text = My.Settings.date2
        date3.Text = My.Settings.date3
        date4.Text = My.Settings.date4
        date5.Text = My.Settings.date5
        date6.Text = My.Settings.date6
        date7.Text = My.Settings.date7
        date8.Text = My.Settings.date8
        date9.Text = My.Settings.date9
        date10.Text = My.Settings.date10
        date11.Text = My.Settings.date11
        date12.Text = My.Settings.date12
        date13.Text = My.Settings.date13
        date14.Text = My.Settings.date14
        date15.Text = My.Settings.date15
        date16.Text = My.Settings.date16
        date17.Text = My.Settings.date17
        date18.Text = My.Settings.date18
        date19.Text = My.Settings.date19
        date20.Text = My.Settings.date20
        date21.Text = My.Settings.date21
        date22.Text = My.Settings.date22
        date23.Text = My.Settings.date23
        date24.Text = My.Settings.date24
        date25.Text = My.Settings.date25
        Hour1.Text = My.Settings.hr1
        hour2.Text = My.Settings.hr2
        hour3.Text = My.Settings.hr3
        hour4.Text = My.Settings.hr4
        hour5.Text = My.Settings.hr5
        hour6.Text = My.Settings.hr6
        hour7.Text = My.Settings.hr7
        hour8.Text = My.Settings.hr8
        hour9.Text = My.Settings.hr9
        hour10.Text = My.Settings.hr10
        hour11.Text = My.Settings.hr11
        hour12.Text = My.Settings.hr12
        hour13.Text = My.Settings.hr13
        hour14.Text = My.Settings.hr14
        hour15.Text = My.Settings.hr15
        hour16.Text = My.Settings.hr16
        hour17.Text = My.Settings.hr17
        hour18.Text = My.Settings.hr18
        hour19.Text = My.Settings.hr19
        hour20.Text = My.Settings.hr20
        hour21.Text = My.Settings.hr21
        hour22.Text = My.Settings.hr22
        hour23.Text = My.Settings.hr23
        hour24.Text = My.Settings.hr24
        hour25.Text = My.Settings.hr25
        minute1.Text = My.Settings.min1
        minute2.Text = My.Settings.min2
        minute3.Text = My.Settings.min3
        minute4.Text = My.Settings.min4
        minute5.Text = My.Settings.min5
        minute6.Text = My.Settings.min6
        minute7.Text = My.Settings.min7
        minute8.Text = My.Settings.min8
        minute9.Text = My.Settings.min9
        minute10.Text = My.Settings.min10
        minute11.Text = My.Settings.min11
        minute12.Text = My.Settings.min12
        minute13.Text = My.Settings.min13
        minute14.Text = My.Settings.min14
        minute15.Text = My.Settings.min15
        minute16.Text = My.Settings.min16
        minute17.Text = My.Settings.min17
        minute18.Text = My.Settings.min18
        minute19.Text = My.Settings.min19
        minute20.Text = My.Settings.min20
        minute21.Text = My.Settings.min21
        minute22.Text = My.Settings.min22
        minute23.Text = My.Settings.min23
        minute24.Text = My.Settings.min24
        minute25.Text = My.Settings.min25
    End Sub

    Public Sub ClearSettings()
        Dim int As Integer
        int = MessageBox.Show("Are you sure you want to clear your time sheet?", "Clear?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If int = 6 Then
            My.Settings.job1 = String.Empty
            My.Settings.job2 = String.Empty
            My.Settings.job3 = String.Empty
            My.Settings.job4 = String.Empty
            My.Settings.job5 = String.Empty
            My.Settings.job6 = String.Empty
            My.Settings.job7 = String.Empty
            My.Settings.job8 = String.Empty
            My.Settings.job9 = String.Empty
            My.Settings.job10 = String.Empty
            My.Settings.job11 = String.Empty
            My.Settings.job12 = String.Empty
            My.Settings.job13 = String.Empty
            My.Settings.job14 = String.Empty
            My.Settings.job15 = String.Empty
            My.Settings.job16 = String.Empty
            My.Settings.job17 = String.Empty
            My.Settings.job18 = String.Empty
            My.Settings.job19 = String.Empty
            My.Settings.job20 = String.Empty
            My.Settings.job21 = String.Empty
            My.Settings.job22 = String.Empty
            My.Settings.job23 = String.Empty
            My.Settings.job24 = String.Empty
            My.Settings.job25 = String.Empty
            My.Settings.date1 = String.Empty
            My.Settings.date2 = String.Empty
            My.Settings.date3 = String.Empty
            My.Settings.date4 = String.Empty
            My.Settings.date5 = String.Empty
            My.Settings.date6 = String.Empty
            My.Settings.date7 = String.Empty
            My.Settings.date8 = String.Empty
            My.Settings.date9 = String.Empty
            My.Settings.date10 = String.Empty
            My.Settings.date11 = String.Empty
            My.Settings.date12 = String.Empty
            My.Settings.date13 = String.Empty
            My.Settings.date14 = String.Empty
            My.Settings.date15 = String.Empty
            My.Settings.date16 = String.Empty
            My.Settings.date17 = String.Empty
            My.Settings.date18 = String.Empty
            My.Settings.date19 = String.Empty
            My.Settings.date20 = String.Empty
            My.Settings.date21 = String.Empty
            My.Settings.date22 = String.Empty
            My.Settings.date23 = String.Empty
            My.Settings.date24 = String.Empty
            My.Settings.date25 = String.Empty
            My.Settings.hr1 = String.Empty
            My.Settings.hr2 = String.Empty
            My.Settings.hr3 = String.Empty
            My.Settings.hr4 = String.Empty
            My.Settings.hr5 = String.Empty
            My.Settings.hr6 = String.Empty
            My.Settings.hr7 = String.Empty
            My.Settings.hr8 = String.Empty
            My.Settings.hr9 = String.Empty
            My.Settings.hr10 = String.Empty
            My.Settings.hr11 = String.Empty
            My.Settings.hr12 = String.Empty
            My.Settings.hr13 = String.Empty
            My.Settings.hr14 = String.Empty
            My.Settings.hr15 = String.Empty
            My.Settings.hr16 = String.Empty
            My.Settings.hr17 = String.Empty
            My.Settings.hr18 = String.Empty
            My.Settings.hr19 = String.Empty
            My.Settings.hr20 = String.Empty
            My.Settings.hr21 = String.Empty
            My.Settings.hr22 = String.Empty
            My.Settings.hr23 = String.Empty
            My.Settings.hr24 = String.Empty
            My.Settings.hr25 = String.Empty
            My.Settings.min1 = String.Empty
            My.Settings.min2 = String.Empty
            My.Settings.min3 = String.Empty
            My.Settings.min4 = String.Empty
            My.Settings.min5 = String.Empty
            My.Settings.min6 = String.Empty
            My.Settings.min7 = String.Empty
            My.Settings.min8 = String.Empty
            My.Settings.min9 = String.Empty
            My.Settings.min10 = String.Empty
            My.Settings.min11 = String.Empty
            My.Settings.min12 = String.Empty
            My.Settings.min13 = String.Empty
            My.Settings.min14 = String.Empty
            My.Settings.min15 = String.Empty
            My.Settings.min16 = String.Empty
            My.Settings.min17 = String.Empty
            My.Settings.min18 = String.Empty
            My.Settings.min19 = String.Empty
            My.Settings.min20 = String.Empty
            My.Settings.min21 = String.Empty
            My.Settings.min22 = String.Empty
            My.Settings.min23 = String.Empty
            My.Settings.min24 = String.Empty
            My.Settings.min25 = String.Empty
            loadSettings()
            saveSettings()
        End If
    End Sub

    Public Sub ShowDayPanel(ByVal day)
        PanelMonday.Visible = False
        PanelTuesday.Visible = False
        PanelWednesday.Visible = False
        PanelThursday.Visible = False
        PanelFriday.Visible = False
        PanelWelcome.Visible = False

        Select Case day
            Case "Monday"
                PanelMonday.Visible = True
            Case "Tuesday"
                PanelTuesday.Visible = True
            Case "Wednesday"
                PanelWednesday.Visible = True
            Case "Thursday"
                PanelThursday.Visible = True
            Case "Friday"
                PanelFriday.Visible = True
            Case "Home"
                PanelWelcome.Visible = True
        End Select

        saveSettings()
    End Sub

    Private Sub SearchResults(ByVal SELECTEDJOB)
        If job1.Text = SEARCHNOTE Then
            job1.Text = SELECTEDJOB
        ElseIf job2.Text = SEARCHNOTE Then
            job2.Text = SELECTEDJOB
        ElseIf job3.Text = SEARCHNOTE Then
            job3.Text = SELECTEDJOB
        ElseIf job4.Text = SEARCHNOTE Then
            job4.Text = SELECTEDJOB
        ElseIf job5.Text = SEARCHNOTE Then
            job5.Text = SELECTEDJOB
        ElseIf job6.Text = SEARCHNOTE Then
            job6.Text = SELECTEDJOB
        ElseIf job7.Text = SEARCHNOTE Then
            job7.Text = SELECTEDJOB
        ElseIf job8.Text = SEARCHNOTE Then
            job8.Text = SELECTEDJOB
        ElseIf job9.Text = SEARCHNOTE Then
            job9.Text = SELECTEDJOB
        ElseIf job10.Text = SEARCHNOTE Then
            job10.Text = SELECTEDJOB
        ElseIf job11.Text = SEARCHNOTE Then
            job11.Text = SELECTEDJOB
        ElseIf job12.Text = SEARCHNOTE Then
            job12.Text = SELECTEDJOB
        ElseIf job13.Text = SEARCHNOTE Then
            job13.Text = SELECTEDJOB
        ElseIf job14.Text = SEARCHNOTE Then
            job14.Text = SELECTEDJOB
        ElseIf job15.Text = SEARCHNOTE Then
            job15.Text = SELECTEDJOB
        ElseIf job16.Text = SEARCHNOTE Then
            job16.Text = SELECTEDJOB
        ElseIf job17.Text = SEARCHNOTE Then
            job17.Text = SELECTEDJOB
        ElseIf job18.Text = SEARCHNOTE Then
            job18.Text = SELECTEDJOB
        ElseIf job19.Text = SEARCHNOTE Then
            job19.Text = SELECTEDJOB
        ElseIf job20.Text = SEARCHNOTE Then
            job20.Text = SELECTEDJOB
        ElseIf job21.Text = SEARCHNOTE Then
            job21.Text = SELECTEDJOB
        ElseIf job22.Text = SEARCHNOTE Then
            job22.Text = SELECTEDJOB
        ElseIf job23.Text = SEARCHNOTE Then
            job23.Text = SELECTEDJOB
        ElseIf job24.Text = SEARCHNOTE Then
            job24.Text = SELECTEDJOB
        ElseIf job25.Text = SEARCHNOTE Then
            job25.Text = SELECTEDJOB
        End If
    End Sub

    Public Sub ShowSearchPanel()

    End Sub

    Private Sub MenuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSave.Click
        saveSettings()

    End Sub

    Private Sub MenuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExit.Click
        Close()
    End Sub

    Private Sub MenuMonday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMonday.Click
        ShowDayPanel("Monday")
    End Sub

    Private Sub MenuTuesday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTuesday.Click
        ShowDayPanel("Tuesday")
    End Sub

    Private Sub MenuWednesday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuWednesday.Click
        ShowDayPanel("Wednesday")
    End Sub

    Private Sub MenuThursday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuThursday.Click
        ShowDayPanel("Thursday")
    End Sub

    Private Sub MenuFriday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFriday.Click
        ShowDayPanel("Friday")
    End Sub

    Private Sub MenuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClear.Click
        ClearSettings()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSettings()
        Me.Width = 332
    End Sub

    Private Sub Form1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        saveSettings()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        saveSettings()
    End Sub

    Private Sub TimeSheetHomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeSheetHomeToolStripMenuItem.Click
        ShowDayPanel("Home")
    End Sub

    Private Sub BtnSubmitJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubmitJob.Click
        SELECTEDJOB = ListBox_JobList.SelectedItem
        SearchResults(SELECTEDJOB)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        SELECTEDJOB = String.Empty
        SearchResults(SELECTEDJOB)
    End Sub

    Private Sub startstop25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop25.Click
        job25.Text = SEARCHNOTE
        ShowSearchPanel()
    End Sub
End Class
