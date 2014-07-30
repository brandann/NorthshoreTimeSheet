Imports System
Imports System.Diagnostics
Imports System.Threading


Public Class Timesheet_Main

    Private Sub savejobinfo()


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

        My.Settings.Date1 = date1.Text
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

        My.Settings.hour1 = Hour1.Text
        My.Settings.hour2 = hour2.Text
        My.Settings.hour3 = hour3.Text
        My.Settings.hour4 = hour4.Text
        My.Settings.hour5 = hour5.Text
        My.Settings.hour6 = hour6.Text
        My.Settings.hour7 = hour7.Text
        My.Settings.hour8 = hour8.Text
        My.Settings.hour9 = hour9.Text
        My.Settings.hour10 = hour10.Text
        My.Settings.hour11 = hour11.Text
        My.Settings.hour12 = hour12.Text
        My.Settings.hour13 = hour13.Text
        My.Settings.hour14 = hour14.Text
        My.Settings.hour15 = hour15.Text
        My.Settings.hour16 = hour16.Text
        My.Settings.hour17 = hour17.Text
        My.Settings.hour18 = hour18.Text
        My.Settings.hour19 = hour19.Text
        My.Settings.hour20 = hour20.Text
        My.Settings.hour21 = hour21.Text
        My.Settings.hour22 = hour22.Text
        My.Settings.hour23 = hour23.Text
        My.Settings.hour24 = hour24.Text
        My.Settings.hour25 = hour25.Text

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

        My.Settings.Save()


    End Sub

    Dim searchnote As String = "Searching... Please Select a Job."

    Private Sub BtnMonday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMonday.Click

        PanelMonday.Visible = True
        'Btndays.Visible = True

        PanelWelcome.Visible = False



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If My.Settings.User = "" Or My.Settings.Pay = "" Or My.Settings.Position = "" Then

        'MessageBox.Show("Welcome, Please setup User Account Settings in Tools > 'User Account Settings'. See Brandan For a tutorial", "Welcome")

        ' End If
        If My.Settings.whatsnewdiolog = True Then
            MessageBox.Show("The Northshore time sheet now has a 'Whats new' feature, logging all the changes and updates that are made. Find Whats new in the Help menu", "One Time Message")
            My.Settings.whatsnewdiolog = False

        End If
        If (Not System.IO.Directory.Exists("Y:\\Timesheet")) Then
            System.IO.Directory.CreateDirectory("Y:\\Timesheet")
        End If
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
        date1.Text = My.Settings.Date1
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
        Hour1.Text = My.Settings.hour1
        hour2.Text = My.Settings.hour2
        hour3.Text = My.Settings.hour3
        hour4.Text = My.Settings.hour4
        hour5.Text = My.Settings.hour5
        hour6.Text = My.Settings.hour6
        hour7.Text = My.Settings.hour7
        hour8.Text = My.Settings.hour8
        hour9.Text = My.Settings.hour9
        hour10.Text = My.Settings.hour10
        hour11.Text = My.Settings.hour11
        hour12.Text = My.Settings.hour12
        hour13.Text = My.Settings.hour13
        hour14.Text = My.Settings.hour14
        hour15.Text = My.Settings.hour15
        hour16.Text = My.Settings.hour16
        hour17.Text = My.Settings.hour17
        hour18.Text = My.Settings.hour18
        hour19.Text = My.Settings.hour19
        hour20.Text = My.Settings.hour20
        hour21.Text = My.Settings.hour21
        hour22.Text = My.Settings.hour22
        hour23.Text = My.Settings.hour23
        hour24.Text = My.Settings.hour24
        hour25.Text = My.Settings.hour25
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

        'Dim maj As String = NorthshoreTimeSheet.My.Application.Info.Version.Major.ToString & "."
        'Dim min As String = NorthshoreTimeSheet.My.Application.Info.Version.Minor & "."
        'Dim rev As String = NorthshoreTimeSheet.My.Application.Info.Version.Revision
        'Dim cre As String = " Brandan Haertel"

        'versionlbl.Text = maj & min & rev & cre







    End Sub

    Private Sub BtnTuesday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTuesday.Click
        PanelTuesday.Visible = True
        'Btndays.Visible = True

        PanelWelcome.Visible = False
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        savejobinfo()

        Close()
    End Sub

    Private Sub startstop1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop1.Click
        Dim TodaysDate As Date = Now

        If startstop1.Text = "Start" And job1.Text <> "" Then
            Timer1.Enabled = True
            date1.Text = TodaysDate.Date
            If Hour1.Text = "" Then
                Hour1.Text = "0"
            End If
            If minute1.Text = "" Then
                minute1.Text = "0"
            End If
            startstop1.Text = "Stop"
            startstop1.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job1.Text


        ElseIf startstop1.Text = "Start" And job1.Text = "" Then
            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop1.Text = "Stop" Then
            Timer1.Enabled = False
            startstop1.Text = "Start"
            startstop1.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
        ' Else
        ' MessageBox.Show("I am sorry, but for logistical reasons, you cannot have multiple jobs running at the same time. Please End any other job you have running", "Oops")
        '  End If

    End Sub

    Private Sub Btndays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PanelWelcome.Visible = True

        PanelMonday.Visible = False
        PanelTuesday.Visible = False
        PanelWednesday.Visible = False
        PanelThursday.Visible = False
        PanelFriday.Visible = False
        'Btndays.Visible = False
        '

    End Sub

    Private Sub Timer1Minute_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        minute1.Text = minute1.Text + 1
        If minute1.Text >= 60 Then
            minute1.Text = "0"
            Hour1.Text = Hour1.Text + 1

        End If

    End Sub

    Private Sub startstop2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop2.Click

        Dim TodaysDate As Date = Now



        If startstop2.Text = "Start" And job2.Text <> "" Then

            Timer2.Enabled = True
            date2.Text = TodaysDate.Date

            If hour2.Text = "" Then
                hour2.Text = "0"
            End If
            If minute2.Text = "" Then
                minute2.Text = "0"
            End If

            startstop2.Text = "Stop"
            startstop2.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job2.Text

        ElseIf startstop2.Text = "Start" And job2.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop2.Text = "Stop" Then

            Timer2.Enabled = False

            startstop2.Text = "Start"
            startstop2.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If



    End Sub

    Private Sub startstop3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop3.Click

        Dim TodaysDate As Date = Now



        If startstop3.Text = "Start" And job3.Text <> "" Then

            Timer3.Enabled = True
            date3.Text = TodaysDate.Date

            If hour3.Text = "" Then
                hour3.Text = "0"
            End If
            If minute3.Text = "" Then
                minute3.Text = "0"
            End If

            startstop3.Text = "Stop"
            startstop3.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job3.Text

        ElseIf startstop3.Text = "Start" And job3.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop3.Text = "Stop" Then

            Timer3.Enabled = False

            startstop3.Text = "Start"
            startstop3.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop4.Click

        Dim TodaysDate As Date = Now



        If startstop4.Text = "Start" And job4.Text <> "" Then

            Timer4.Enabled = True
            date4.Text = TodaysDate.Date

            If hour4.Text = "" Then
                hour4.Text = "0"
            End If
            If minute4.Text = "" Then
                minute4.Text = "0"
            End If

            startstop4.Text = "Stop"
            startstop4.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job4.Text


        ElseIf startstop4.Text = "Start" And job4.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop4.Text = "Stop" Then

            Timer4.Enabled = False

            startstop4.Text = "Start"
            startstop4.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If

    End Sub

    Private Sub startstop5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop5.Click

        Dim TodaysDate As Date = Now



        If startstop5.Text = "Start" And job5.Text <> "" Then

            Timer5.Enabled = True
            date5.Text = TodaysDate.Date

            If hour5.Text = "" Then
                hour5.Text = "0"
            End If
            If minute5.Text = "" Then
                minute5.Text = "0"
            End If

            startstop5.Text = "Stop"
            startstop5.BackColor = Color.OrangeRed

            ExplorerTitle.Text = job5.Text
        ElseIf startstop5.Text = "Start" And job5.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop5.Text = "Stop" Then

            Timer5.Enabled = False

            startstop5.Text = "Start"
            startstop5.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        minute2.Text = minute2.Text + 1

        If minute2.Text >= 60 Then
            minute2.Text = "0"
            hour2.Text = hour2.Text + 1

        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        minute3.Text = minute3.Text + 1

        If minute3.Text >= 60 Then
            minute3.Text = "0"
            hour3.Text = hour3.Text + 1

        End If

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        minute4.Text = minute4.Text + 1

        If minute4.Text >= 60 Then
            minute4.Text = "0"
            hour4.Text = hour4.Text + 1

        End If

    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        minute5.Text = minute5.Text + 1

        If minute5.Text >= 60 Then
            minute5.Text = "0"
            hour5.Text = hour5.Text + 1

        End If

    End Sub

    Private Sub BtnWednesday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWednesday.Click
        PanelWednesday.Visible = True
        'Btndays.Visible = True

        PanelWelcome.Visible = False
    End Sub

    Private Sub BtnThursday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnThursday.Click
        PanelThursday.Visible = True
        'Btndays.Visible = True

        PanelWelcome.Visible = False
    End Sub

    Private Sub BtnFriday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFriday.Click
        PanelFriday.Visible = True
        'Btndays.Visible = True

        PanelWelcome.Visible = False
    End Sub



    Private Sub startstop6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop6.Click
        Dim TodaysDate As Date = Now



        If startstop6.Text = "Start" And job6.Text <> "" Then

            Timer6.Enabled = True
            date6.Text = TodaysDate.Date

            If hour6.Text = "" Then
                hour6.Text = "0"
            End If
            If minute6.Text = "" Then
                minute6.Text = "0"
            End If

            startstop6.Text = "Stop"
            startstop6.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job6.Text

        ElseIf startstop6.Text = "Start" And job6.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop6.Text = "Stop" Then

            Timer6.Enabled = False

            startstop6.Text = "Start"
            startstop6.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop7.Click
        Dim TodaysDate As Date = Now



        If startstop7.Text = "Start" And job7.Text <> "" Then

            Timer7.Enabled = True
            date7.Text = TodaysDate.Date

            If hour7.Text = "" Then
                hour7.Text = "0"
            End If
            If minute7.Text = "" Then
                minute7.Text = "0"
            End If

            startstop7.Text = "Stop"
            startstop7.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job7.Text

        ElseIf startstop7.Text = "Start" And job7.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop7.Text = "Stop" Then

            Timer7.Enabled = False

            startstop7.Text = "Start"
            startstop7.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop8.Click
        Dim TodaysDate As Date = Now



        If startstop8.Text = "Start" And job8.Text <> "" Then

            Timer8.Enabled = True
            date8.Text = TodaysDate.Date

            If hour8.Text = "" Then
                hour8.Text = "0"
            End If
            If minute8.Text = "" Then
                minute8.Text = "0"
            End If

            startstop8.Text = "Stop"
            startstop8.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job8.Text

        ElseIf startstop8.Text = "Start" And job8.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop8.Text = "Stop" Then

            Timer8.Enabled = False

            startstop8.Text = "Start"
            startstop8.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop9.Click
        Dim TodaysDate As Date = Now



        If startstop9.Text = "Start" And job9.Text <> "" Then

            Timer9.Enabled = True
            date9.Text = TodaysDate.Date

            If hour9.Text = "" Then
                hour9.Text = "0"
            End If
            If minute9.Text = "" Then
                minute9.Text = "0"
            End If

            startstop9.Text = "Stop"
            startstop9.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job9.Text

        ElseIf startstop9.Text = "Start" And job9.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop9.Text = "Stop" Then

            Timer9.Enabled = False

            startstop9.Text = "Start"
            startstop9.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop10.Click
        Dim TodaysDate As Date = Now



        If startstop10.Text = "Start" And job10.Text <> "" Then

            Timer10.Enabled = True
            date10.Text = TodaysDate.Date

            If hour10.Text = "" Then
                hour10.Text = "0"
            End If
            If minute10.Text = "" Then
                minute10.Text = "0"
            End If

            startstop10.Text = "Stop"
            startstop10.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job10.Text

        ElseIf startstop10.Text = "Start" And job10.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop10.Text = "Stop" Then

            Timer10.Enabled = False

            startstop10.Text = "Start"
            startstop10.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop11.Click
        Dim TodaysDate As Date = Now



        If startstop11.Text = "Start" And job11.Text <> "" Then

            Timer11.Enabled = True
            date11.Text = TodaysDate.Date

            If hour11.Text = "" Then
                hour11.Text = "0"
            End If
            If minute11.Text = "" Then
                minute11.Text = "0"
            End If

            startstop11.Text = "Stop"
            startstop11.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job11.Text

        ElseIf startstop11.Text = "Start" And job11.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop11.Text = "Stop" Then

            Timer11.Enabled = False

            startstop11.Text = "Start"
            startstop11.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop12.Click
        Dim TodaysDate As Date = Now



        If startstop12.Text = "Start" And job12.Text <> "" Then

            Timer12.Enabled = True
            date12.Text = TodaysDate.Date

            If hour12.Text = "" Then
                hour12.Text = "0"
            End If
            If minute12.Text = "" Then
                minute12.Text = "0"
            End If

            startstop12.Text = "Stop"
            startstop12.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job12.Text

        ElseIf startstop12.Text = "Start" And job12.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop12.Text = "Stop" Then

            Timer12.Enabled = False

            startstop12.Text = "Start"
            startstop12.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop13.Click
        Dim TodaysDate As Date = Now



        If startstop13.Text = "Start" And job13.Text <> "" Then

            Timer13.Enabled = True
            date13.Text = TodaysDate.Date

            If hour13.Text = "" Then
                hour13.Text = "0"
            End If
            If minute13.Text = "" Then
                minute13.Text = "0"
            End If

            startstop13.Text = "Stop"
            startstop13.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job13.Text

        ElseIf startstop13.Text = "Start" And job13.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop13.Text = "Stop" Then

            Timer13.Enabled = False

            startstop13.Text = "Start"
            startstop13.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop14.Click
        Dim TodaysDate As Date = Now



        If startstop14.Text = "Start" And job14.Text <> "" Then

            Timer14.Enabled = True
            date14.Text = TodaysDate.Date

            If hour14.Text = "" Then
                hour14.Text = "0"
            End If
            If minute14.Text = "" Then
                minute14.Text = "0"
            End If

            startstop14.Text = "Stop"
            startstop14.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job14.Text

        ElseIf startstop14.Text = "Start" And job14.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop14.Text = "Stop" Then

            Timer14.Enabled = False

            startstop14.Text = "Start"
            startstop14.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop15.Click
        Dim TodaysDate As Date = Now



        If startstop15.Text = "Start" And job15.Text <> "" Then

            Timer15.Enabled = True
            date15.Text = TodaysDate.Date

            If hour15.Text = "" Then
                hour15.Text = "0"
            End If
            If minute15.Text = "" Then
                minute15.Text = "0"
            End If

            startstop15.Text = "Stop"
            startstop15.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job15.Text

        ElseIf startstop15.Text = "Start" And job15.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop15.Text = "Stop" Then

            Timer15.Enabled = False

            startstop15.Text = "Start"
            startstop15.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop16.Click
        Dim TodaysDate As Date = Now



        If startstop16.Text = "Start" And job16.Text <> "" Then

            Timer16.Enabled = True
            date16.Text = TodaysDate.Date

            If hour16.Text = "" Then
                hour16.Text = "0"
            End If
            If minute16.Text = "" Then
                minute16.Text = "0"
            End If

            startstop16.Text = "Stop"
            startstop16.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job16.Text

        ElseIf startstop16.Text = "Start" And job16.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop16.Text = "Stop" Then

            Timer16.Enabled = False

            startstop16.Text = "Start"
            startstop16.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop17.Click
        Dim TodaysDate As Date = Now



        If startstop17.Text = "Start" And job17.Text <> "" Then

            Timer17.Enabled = True
            date17.Text = TodaysDate.Date

            If hour17.Text = "" Then
                hour17.Text = "0"
            End If
            If minute17.Text = "" Then
                minute17.Text = "0"
            End If

            startstop17.Text = "Stop"
            startstop17.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job17.Text

        ElseIf startstop17.Text = "Start" And job17.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop17.Text = "Stop" Then

            Timer17.Enabled = False

            startstop17.Text = "Start"
            startstop17.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop18.Click
        Dim TodaysDate As Date = Now



        If startstop18.Text = "Start" And job18.Text <> "" Then

            Timer18.Enabled = True
            date18.Text = TodaysDate.Date

            If hour18.Text = "" Then
                hour18.Text = "0"
            End If
            If minute18.Text = "" Then
                minute18.Text = "0"
            End If

            startstop18.Text = "Stop"
            startstop18.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job18.Text

        ElseIf startstop18.Text = "Start" And job18.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop18.Text = "Stop" Then

            Timer18.Enabled = False

            startstop18.Text = "Start"
            startstop18.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop19.Click
        Dim TodaysDate As Date = Now



        If startstop19.Text = "Start" And job19.Text <> "" Then

            Timer19.Enabled = True
            date19.Text = TodaysDate.Date

            If hour19.Text = "" Then
                hour19.Text = "0"
            End If
            If minute19.Text = "" Then
                minute19.Text = "0"
            End If

            startstop19.Text = "Stop"
            startstop19.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job19.Text

        ElseIf startstop19.Text = "Start" And job19.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop19.Text = "Stop" Then

            Timer19.Enabled = False

            startstop19.Text = "Start"
            startstop19.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop20.Click
        Dim TodaysDate As Date = Now



        If startstop20.Text = "Start" And job20.Text <> "" Then

            Timer20.Enabled = True
            date20.Text = TodaysDate.Date

            If hour20.Text = "" Then
                hour20.Text = "0"
            End If
            If minute20.Text = "" Then
                minute20.Text = "0"
            End If

            startstop20.Text = "Stop"
            startstop20.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job20.Text

        ElseIf startstop20.Text = "Start" And job20.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop20.Text = "Stop" Then

            Timer20.Enabled = False

            startstop20.Text = "Start"
            startstop20.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop21.Click




        If startstop21.Text = "Start" And job21.Text <> "" Then
            Dim TodaysDate As Date = Now
            Timer21.Enabled = True
            date21.Text = TodaysDate.Date

            If hour21.Text = "" Then
                hour21.Text = "0"
            End If
            If minute21.Text = "" Then
                minute21.Text = "0"
            End If

            startstop21.Text = "Stop"
            startstop21.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job21.Text

        ElseIf startstop21.Text = "Start" And job21.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop21.Text = "Stop" Then

            Timer21.Enabled = False

            startstop21.Text = "Start"
            startstop21.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If



    End Sub

    Private Sub startstop22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop22.Click
        Dim TodaysDate As Date = Now



        If startstop22.Text = "Start" And job22.Text <> "" Then

            Timer22.Enabled = True
            date22.Text = TodaysDate.Date

            If hour22.Text = "" Then
                hour22.Text = "0"
            End If
            If minute22.Text = "" Then
                minute22.Text = "0"
            End If

            startstop22.Text = "Stop"
            startstop22.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job22.Text

        ElseIf startstop22.Text = "Start" And job22.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop22.Text = "Stop" Then

            Timer22.Enabled = False

            startstop22.Text = "Start"
            startstop22.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop23.Click
        Dim TodaysDate As Date = Now



        If startstop23.Text = "Start" And job23.Text <> "" Then

            Timer23.Enabled = True
            date23.Text = TodaysDate.Date

            If hour23.Text = "" Then
                hour23.Text = "0"
            End If
            If minute23.Text = "" Then
                minute23.Text = "0"
            End If

            startstop23.Text = "Stop"
            startstop23.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job23.Text

        ElseIf startstop23.Text = "Start" And job23.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop23.Text = "Stop" Then

            Timer23.Enabled = False

            startstop23.Text = "Start"
            startstop23.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop24.Click
        Dim TodaysDate As Date = Now



        If startstop24.Text = "Start" And job24.Text <> "" Then

            Timer24.Enabled = True
            date24.Text = TodaysDate.Date

            If hour24.Text = "" Then
                hour24.Text = "0"
            End If
            If minute24.Text = "" Then
                minute24.Text = "0"
            End If

            startstop24.Text = "Stop"
            startstop24.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job24.Text

        ElseIf startstop24.Text = "Start" And job24.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop24.Text = "Stop" Then

            Timer24.Enabled = False

            startstop24.Text = "Start"
            startstop24.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()
        End If
    End Sub

    Private Sub startstop25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startstop25.Click
        Dim TodaysDate As Date = Now



        If startstop25.Text = "Start" And job25.Text <> "" Then

            Timer25.Enabled = True
            date25.Text = TodaysDate.Date

            If hour25.Text = "" Then
                hour25.Text = "0"
            End If
            If minute25.Text = "" Then
                minute25.Text = "0"
            End If

            startstop25.Text = "Stop"
            startstop25.BackColor = Color.OrangeRed
            ExplorerTitle.Text = job25.Text

        ElseIf startstop25.Text = "Start" And job25.Text = "" Then

            MessageBox.Show("You must first select a job before starting one.")

        ElseIf startstop25.Text = "Stop" Then

            Timer25.Enabled = False

            startstop25.Text = "Start"
            startstop25.BackColor = Control.DefaultBackColor
            ExplorerTitle.Text = ""
            exploreroff()

        End If
    End Sub

    Private Sub BtnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetup.Click


    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        minute6.Text = minute6.Text + 1

        If minute6.Text >= 60 Then
            minute6.Text = "0"
            hour6.Text = hour6.Text + 1

        End If
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        minute7.Text = minute7.Text + 1

        If minute7.Text >= 60 Then
            minute7.Text = "0"
            hour7.Text = hour7.Text + 1

        End If
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        minute8.Text = minute8.Text + 1

        If minute8.Text >= 60 Then
            minute8.Text = "0"
            hour8.Text = hour8.Text + 1

        End If
    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        minute9.Text = minute9.Text + 1

        If minute9.text >= 60 Then
            minute9.Text = "0"
            hour9.Text = hour9.Text + 1

        End If
    End Sub

    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        minute10.Text = minute10.Text + 1

        If minute10.text >= 60 Then
            minute10.Text = "0"
            hour10.Text = hour10.Text + 1

        End If
    End Sub

    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick
        minute11.Text = minute11.Text + 1

        If minute11.text >= 60 Then
            minute11.Text = "0"
            hour11.Text = hour11.Text + 1

        End If
    End Sub

    Private Sub Timer12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer12.Tick
        minute12.Text = minute12.Text + 1

        If minute12.text >= 60 Then
            minute12.Text = "0"
            hour12.Text = hour12.Text + 1

        End If
    End Sub

    Private Sub Timer13_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer13.Tick
        minute13.Text = minute13.Text + 1

        If minute13.text >= 60 Then
            minute13.Text = "0"
            hour13.Text = hour13.Text + 1

        End If
    End Sub

    Private Sub Timer14_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer14.Tick
        minute14.Text = minute14.Text + 1

        If minute14.text >= 60 Then
            minute14.Text = "0"
            hour14.Text = hour14.Text + 1

        End If
    End Sub

    Private Sub Timer15_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer15.Tick
        minute15.Text = minute15.Text + 1

        If minute15.text >= 60 Then
            minute15.Text = "0"
            hour15.Text = hour15.Text + 1

        End If
    End Sub

    Private Sub Timer16_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer16.Tick
        minute16.Text = minute16.Text + 1

        If minute16.text >= 60 Then
            minute16.Text = "0"
            hour16.Text = hour16.Text + 1

        End If
    End Sub

    Private Sub Timer17_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer17.Tick
        minute17.Text = minute17.Text + 1

        If minute17.text >= 60 Then
            minute17.Text = "0"
            hour17.Text = hour17.Text + 1

        End If
    End Sub

    Private Sub Timer18_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer18.Tick
        minute18.Text = minute18.Text + 1

        If minute18.text >= 60 Then
            minute18.Text = "0"
            hour18.Text = hour18.Text + 1

        End If
    End Sub

    Private Sub Timer19_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer19.Tick
        minute19.Text = minute19.Text + 1

        If minute19.text >= 60 Then
            minute19.Text = "0"
            hour19.Text = hour19.Text + 1

        End If
    End Sub

    Private Sub Timer20_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer20.Tick

        minute20.Text = minute20.Text + 1

        If minute20.text >= 60 Then
            minute20.Text = "0"
            hour20.Text = hour20.Text + 1

        End If
    End Sub

    Private Sub Timer21_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer21.Tick
        minute21.Text = minute21.Text + 1

        If minute21.text >= 60 Then
            minute21.Text = "0"
            hour21.Text = hour21.Text + 1

        End If
    End Sub

    Private Sub Timer22_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer22.Tick
        minute22.Text = minute22.Text + 1

        If minute22.text >= 60 Then
            minute22.Text = "0"
            hour22.Text = hour22.Text + 1

        End If
    End Sub

    Private Sub Timer23_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer23.Tick
        minute23.Text = minute23.Text + 1

        If minute23.text >= 60 Then
            minute23.Text = "0"
            hour23.Text = hour23.Text + 1

        End If
    End Sub

    Private Sub Timer24_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer24.Tick
        minute24.Text = minute24.Text + 1

        If minute24.text >= 60 Then
            minute24.Text = "0"
            hour24.Text = hour24.Text + 1

        End If
    End Sub

    Private Sub Timer25_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer25.Tick
        minute25.Text = minute25.Text + 1

        If minute25.text >= 60 Then
            minute25.Text = "0"
            hour25.Text = hour25.Text + 1

        End If
    End Sub


    Private Sub Form1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        savejobinfo()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        savejobinfo()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        job1.Text = ""
        date1.Text = ""
        Hour1.Text = ""
        minute1.Text = ""
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        job2.Text = ""
        date2.Text = ""
        hour2.Text = ""
        minute2.Text = ""
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        job3.Text = ""
        date3.Text = ""
        hour3.Text = ""
        minute3.Text = ""
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        job4.Text = ""
        date4.Text = ""
        hour4.Text = ""
        minute4.Text = ""

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        job5.Text = ""
        date5.Text = ""
        hour5.Text = ""
        minute5.Text = ""
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        job6.Text = ""
        date6.Text = ""
        hour6.Text = ""
        minute6.Text = ""

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        job7.Text = ""
        date7.Text = ""
        hour7.Text = ""
        minute7.Text = ""
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        job8.Text = ""
        date8.Text = ""
        hour8.Text = ""
        minute8.Text = ""
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        job9.Text = ""
        date9.Text = ""
        hour9.Text = ""
        minute9.Text = ""
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        job10.Text = ""
        date10.Text = ""
        hour10.Text = ""
        minute10.Text = ""
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        job11.Text = ""
        date11.Text = ""
        hour11.Text = ""
        minute11.Text = ""
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        job12.Text = ""
        date12.Text = ""
        hour12.Text = ""
        minute12.Text = ""
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        job13.Text = ""
        date13.Text = ""
        hour13.Text = ""
        minute13.Text = ""
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        job14.Text = ""
        date14.Text = ""
        hour14.Text = ""
        minute14.Text = ""

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        job15.Text = ""
        date15.Text = ""
        hour15.Text = ""
        minute15.Text = ""
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        job16.Text = ""
        date16.Text = ""
        hour16.Text = ""
        minute16.Text = ""
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        job17.Text = ""
        date17.Text = ""
        hour17.Text = ""
        minute17.Text = ""

    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        job18.Text = ""
        date18.Text = ""
        hour18.Text = ""
        minute18.Text = ""
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        job19.Text = ""
        date19.Text = ""
        hour19.Text = ""
        minute19.Text = ""
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        job20.Text = ""
        date20.Text = ""
        hour20.Text = ""
        minute20.Text = ""
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        job21.Text = ""
        date21.Text = ""
        hour21.Text = ""
        minute21.Text = ""
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        job22.Text = ""
        date22.Text = ""
        hour22.Text = ""
        minute22.Text = ""
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        job23.Text = ""
        date23.Text = ""
        hour23.Text = ""
        minute23.Text = ""
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        job24.Text = ""
        date24.Text = ""
        hour24.Text = ""
        minute24.Text = ""
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        job25.Text = ""
        date25.Text = ""
        hour25.Text = ""
        minute25.Text = ""
    End Sub



    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        PanelWelcome.Visible = True
        PanelMonday.Visible = False
        PanelTuesday.Visible = False
        PanelWednesday.Visible = False
        PanelThursday.Visible = False
        PanelFriday.Visible = False

    End Sub
    Public Sub searchforajob(ByVal job)
        job.text = searchnote
        TabControl_Explorer.Visible = False
        ExplorerNote.Visible = False
        ExplorerTitle.Visible = False
        panelchoosejob.Visible = True
        Me.Width = 720

    End Sub
   

    Private Sub job1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job1.MouseDoubleClick
        searchforajob(job1)
    End Sub

    Private Sub job2_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job2.MouseDoubleClick
        searchforajob(job2)


    End Sub

    Private Sub job3_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job3.MouseDoubleClick
        searchforajob(job3)


    End Sub

    Private Sub job4_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job4.MouseDoubleClick
        searchforajob(job4)


    End Sub

    Private Sub job5_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job5.MouseDoubleClick
        searchforajob(job5)


    End Sub

    Private Sub job6_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job6.MouseDoubleClick
        searchforajob(job6)


    End Sub

    Private Sub job7_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job7.MouseDoubleClick
        searchforajob(job7)


    End Sub

    Private Sub job8_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job8.MouseDoubleClick
        searchforajob(job8)


    End Sub

    Private Sub job9_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job9.MouseDoubleClick
        searchforajob(job9)


    End Sub

    Private Sub job10_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job10.MouseDoubleClick
        searchforajob(job10)


    End Sub

    Private Sub job11_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job11.MouseDoubleClick
        searchforajob(job11)


    End Sub

    Private Sub job12_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job12.MouseDoubleClick
        searchforajob(job12)


    End Sub

    Private Sub job13_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job13.MouseDoubleClick
        searchforajob(job13)


    End Sub

    Private Sub job14_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job14.MouseDoubleClick
        searchforajob(job14)

    End Sub

    Private Sub job15_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job15.MouseDoubleClick
        searchforajob(job15)

    End Sub

    Private Sub job16_MouseDoubleClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job16.MouseDoubleClick
        searchforajob(job16)

    End Sub

    Private Sub job17_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job17.MouseDoubleClick
        searchforajob(job17)

    End Sub

    Private Sub job18_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job18.MouseDoubleClick
        searchforajob(job18)

    End Sub

    Private Sub job19_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job19.MouseDoubleClick
        searchforajob(job19)


    End Sub

    Private Sub job20_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job20.MouseDoubleClick
        searchforajob(job20)

    End Sub

    Private Sub job21_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job21.MouseDoubleClick
        searchforajob(job21)

    End Sub

    Private Sub job22_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job22.MouseDoubleClick
        searchforajob(job22)

    End Sub

    Private Sub job23_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job23.MouseDoubleClick
        searchforajob(job23)

    End Sub

    Private Sub job24_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job24.MouseDoubleClick
        searchforajob(job24)

    End Sub

    Private Sub job25_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles job25.MouseDoubleClick
        searchforajob(job25)

    End Sub


    Private Sub SearchResults(ByVal notez)
        If job1.Text = searchnote Then
            job1.Text = notez
        ElseIf job2.Text = searchnote Then
            job2.Text = notez
        ElseIf job3.Text = searchnote Then
            job3.Text = notez
        ElseIf job4.Text = searchnote Then
            job4.Text = notez
        ElseIf job5.Text = searchnote Then
            job5.Text = notez
        ElseIf job6.Text = searchnote Then
            job6.Text = notez
        ElseIf job7.Text = searchnote Then
            job7.Text = notez
        ElseIf job8.Text = searchnote Then
            job8.Text = notez
        ElseIf job9.Text = searchnote Then
            job9.Text = notez
        ElseIf job10.Text = searchnote Then
            job10.Text = notez
        ElseIf job11.Text = searchnote Then
            job11.Text = notez
        ElseIf job12.Text = searchnote Then
            job12.Text = notez
        ElseIf job13.Text = searchnote Then
            job13.Text = notez
        ElseIf job14.Text = searchnote Then
            job14.Text = notez
        ElseIf job15.Text = searchnote Then
            job15.Text = notez
        ElseIf job16.Text = searchnote Then
            job16.Text = notez
        ElseIf job17.Text = searchnote Then
            job17.Text = notez
        ElseIf job18.Text = searchnote Then
            job18.Text = notez
        ElseIf job19.Text = searchnote Then
            job19.Text = notez
        ElseIf job20.Text = searchnote Then
            job20.Text = notez
        ElseIf job21.Text = searchnote Then
            job21.Text = notez
        ElseIf job22.Text = searchnote Then
            job22.Text = notez
        ElseIf job23.Text = searchnote Then
            job23.Text = notez
        ElseIf job24.Text = searchnote Then
            job24.Text = notez
        ElseIf job25.Text = searchnote Then
            job25.Text = notez
        End If
    End Sub



    Private Sub BtnSubmitJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubmitJob.Click
        If ListBox_JobList.SelectedItem <> "" Then
            SearchResults(ListBox_JobList.SelectedItem)
            panelchoosejob.Visible = False
            Me.Width = 315

            
        Else
            MessageBox.Show("Please Choose a job")
            SearchResults(ListBox_JobList.SelectedItem)
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        SearchResults("")
        panelchoosejob.Visible = False
        Me.Width = 315
        My.Settings.Company = ""

    End Sub
  

    Private Sub ListBox_JobList_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox_JobList.MouseDoubleClick
        If ListBox_JobList.SelectedItem <> "" Then
            SearchResults(ListBox_JobList.SelectedItem)
            panelchoosejob.Visible = False
            Me.Width = 315
        Else
            MessageBox.Show("Please Choose a job")
            SearchResults(ListBox_JobList.SelectedItem)
        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox_JobList.Items.Clear()
        For Each northshorejoblist As String In _
                My.Computer.FileSystem.GetDirectories("P:\Job File")

            'add all the job folder names to the list
            ListBox_JobList.Items.Add(northshorejoblist.Substring(12))
        Next
        ListBox_JobList.Items.Remove("$RECYCLE.BIN")
        ListBox_JobList.Items.Remove("1-Closed Jobs")
        ListBox_JobList.Items.Remove("1-Doc Templates")
        ListBox_JobList.Items.Remove("1-Insurance Policies")
        ListBox_JobList.Items.Remove("1-Job Template")
        ListBox_JobList.Items.Remove("1-Mailing Log")
        ListBox_JobList.Items.Remove("1-Master Contracts")
        ListBox_JobList.Items.Remove("1-pre job info tracking")
        ListBox_JobList.Items.Remove("1-Project Schedule File")
        ListBox_JobList.Items.Remove("1-Small Jobs")
        ListBox_JobList.Items.Remove("Hanging Folder lists")
        ListBox_JobList.Items.Remove("MASTER SUBCONTRACTS")
        ListBox_JobList.Items.Remove("My Data Sources")
        ListBox_JobList.Items.Remove("1-Job template")
        ListBox_JobList.Items.Remove("1-NorthClad Closed Jobs")
        ListBox_JobList.Items.Remove("northclad small jobs")
        ListBox_JobList.Items.Remove("temp")
        ListBox_JobList.Items.Remove("Z-Misc")
        My.Settings.Company = "Northshore"
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox_JobList.Items.Clear()
        For Each northcladjoblist As String In _
            My.Computer.FileSystem.GetDirectories("P:\job file - northclad\")

            'add all the job folder names to the list
            ListBox_JobList.Items.Add(northcladjoblist.Substring(24))
        Next
        ListBox_JobList.Items.Remove("$RECYCLE.BIN")
        ListBox_JobList.Items.Remove("1-Closed Jobs")
        ListBox_JobList.Items.Remove("1-Doc Templates")
        ListBox_JobList.Items.Remove("1-Insurance Policies")
        ListBox_JobList.Items.Remove("1-Job Template")
        ListBox_JobList.Items.Remove("1-Mailing Log")
        ListBox_JobList.Items.Remove("1-Master Contracts")
        ListBox_JobList.Items.Remove("1-pre job info tracking")
        ListBox_JobList.Items.Remove("1-Project Schedule File")
        ListBox_JobList.Items.Remove("1-Small Jobs")
        ListBox_JobList.Items.Remove("Hanging Folder lists")
        ListBox_JobList.Items.Remove("MASTER SUBCONTRACTS")
        ListBox_JobList.Items.Remove("My Data Sources")
        ListBox_JobList.Items.Remove("1-Job template")
        ListBox_JobList.Items.Remove("1-NorthClad Closed Jobs")
        ListBox_JobList.Items.Remove("northclad small jobs")
        ListBox_JobList.Items.Remove("temp")
        ListBox_JobList.Items.Remove("Z-Misc")
        My.Settings.Company = "Northclad"
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox_JobList.Items.Clear()
        For Each oldnorthshorejoblist As String In _
                My.Computer.FileSystem.GetDirectories("P:\Job File\1-Closed Jobs\2006 Closed Jobs")
            ListBox_JobList.Items.Add(oldnorthshorejoblist.Substring(43))
        Next

        For Each oldnorthshorejoblist As String In _
        My.Computer.FileSystem.GetDirectories("P:\Job File\1-Closed Jobs\2007 Closed Jobs")
            ListBox_JobList.Items.Add(oldnorthshorejoblist.Substring(43))
        Next

        For Each oldnorthshorejoblist As String In _
            My.Computer.FileSystem.GetDirectories("P:\Job File\1-Closed Jobs\2008 Closed Jobs")
            ListBox_JobList.Items.Add(oldnorthshorejoblist.Substring(43))
        Next

        For Each oldnorthshorejoblist As String In _
            My.Computer.FileSystem.GetDirectories("P:\Job File\1-Closed Jobs\2009 Closed Jobs")
            ListBox_JobList.Items.Add(oldnorthshorejoblist.Substring(43))
        Next

        For Each oldnorthshorejoblist As String In _
            My.Computer.FileSystem.GetDirectories("P:\Job File\1-Closed Jobs\2010 Closed Jobs")
            ListBox_JobList.Items.Add(oldnorthshorejoblist.Substring(43))
        Next

        For Each oldnorthshorejoblist As String In _
            My.Computer.FileSystem.GetDirectories("P:\Job File\1-Closed Jobs\2011 Closed Jobs")
            ListBox_JobList.Items.Add(oldnorthshorejoblist.Substring(43))
        Next

        For Each oldnorthshorejoblist As String In _
            My.Computer.FileSystem.GetDirectories("P:\Job File\1-Closed Jobs\2012 Closed Jobs")
            ListBox_JobList.Items.Add(oldnorthshorejoblist.Substring(43))
        Next
        ListBox_JobList.Items.Remove("$RECYCLE.BIN")
        ListBox_JobList.Items.Remove("1-Closed Jobs")
        ListBox_JobList.Items.Remove("1-Doc Templates")
        ListBox_JobList.Items.Remove("1-Insurance Policies")
        ListBox_JobList.Items.Remove("1-Job Template")
        ListBox_JobList.Items.Remove("1-Mailing Log")
        ListBox_JobList.Items.Remove("1-Master Contracts")
        ListBox_JobList.Items.Remove("1-pre job info tracking")
        ListBox_JobList.Items.Remove("1-Project Schedule File")
        ListBox_JobList.Items.Remove("1-Small Jobs")
        ListBox_JobList.Items.Remove("Hanging Folder lists")
        ListBox_JobList.Items.Remove("MASTER SUBCONTRACTS")
        ListBox_JobList.Items.Remove("My Data Sources")
        ListBox_JobList.Items.Remove("1-Job template")
        ListBox_JobList.Items.Remove("1-NorthClad Closed Jobs")
        ListBox_JobList.Items.Remove("northclad small jobs")
        ListBox_JobList.Items.Remove("temp")
        ListBox_JobList.Items.Remove("Z-Misc")
        My.Settings.Company = "Old Northshore"
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox_JobList.Items.Clear()
        For Each oldnorthcladjoblist As String In _
            My.Computer.FileSystem.GetDirectories("P:\job file - northclad\1-NorthClad Closed Jobs\2010 NorthClad Closed Jobs")
            ListBox_JobList.Items.Add(oldnorthcladjoblist.Substring(75))
        Next

        For Each oldnorthcladjoblist As String In _
        My.Computer.FileSystem.GetDirectories("P:\job file - northclad\1-NorthClad Closed Jobs\2010 NorthClad Closed Jobs")
            ListBox_JobList.Items.Add(oldnorthcladjoblist.Substring(75))
        Next

        For Each oldnorthcladjoblist As String In _
        My.Computer.FileSystem.GetDirectories("P:\job file - northclad\1-NorthClad Closed Jobs\2010 NorthClad Closed Jobs")
            ListBox_JobList.Items.Add(oldnorthcladjoblist.Substring(75))
        Next
        ListBox_JobList.Items.Remove("$RECYCLE.BIN")
        ListBox_JobList.Items.Remove("1-Closed Jobs")
        ListBox_JobList.Items.Remove("1-Doc Templates")
        ListBox_JobList.Items.Remove("1-Insurance Policies")
        ListBox_JobList.Items.Remove("1-Job Template")
        ListBox_JobList.Items.Remove("1-Mailing Log")
        ListBox_JobList.Items.Remove("1-Master Contracts")
        ListBox_JobList.Items.Remove("1-pre job info tracking")
        ListBox_JobList.Items.Remove("1-Project Schedule File")
        ListBox_JobList.Items.Remove("1-Small Jobs")
        ListBox_JobList.Items.Remove("Hanging Folder lists")
        ListBox_JobList.Items.Remove("MASTER SUBCONTRACTS")
        ListBox_JobList.Items.Remove("My Data Sources")
        ListBox_JobList.Items.Remove("1-Job template")
        ListBox_JobList.Items.Remove("1-NorthClad Closed Jobs")
        ListBox_JobList.Items.Remove("northclad small jobs")
        ListBox_JobList.Items.Remove("temp")
        ListBox_JobList.Items.Remove("Z-Misc")
        My.Settings.Company = "Old Northclad"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ListBox_JobList.Items.Clear()
        ListBox_JobList.Items.Add("0000-Vacation Pay (Hourly Employees)")
        ListBox_JobList.Items.Add("0000-Off No Pay (Personal Day)")
        ListBox_JobList.Items.Add("0000-Holiday Pay (Salary Employees)")
        ListBox_JobList.Items.Add("0001-Office")
        ListBox_JobList.Items.Add("0001-R&D")
        ListBox_JobList.Items.Add("0001-Shop")
        ListBox_JobList.Items.Add("0002-Closed Jobs")
        My.Settings.Company = "Office"

       
    End Sub
    

    

    Private Sub WhatsNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhatsNewToolStripMenuItem.Click
        whatsnewform.Show()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        savejobinfo()
        MessageBox.Show("Your job data has been saved. Remember: this program saves automaticly everytime you close it.", "Save")

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        savejobinfo()

        Close()
    End Sub

    Private Sub MondayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MondayToolStripMenuItem.Click
        PanelMonday.Visible = True
        PanelTuesday.Visible = False
        PanelWednesday.Visible = False
        PanelThursday.Visible = False
        PanelFriday.Visible = False
        PanelWelcome.Visible = False
    End Sub

    Private Sub TuesdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TuesdayToolStripMenuItem.Click
        PanelMonday.Visible = False
        PanelTuesday.Visible = True
        PanelWednesday.Visible = False
        PanelThursday.Visible = False
        PanelFriday.Visible = False
        PanelWelcome.Visible = False
    End Sub

    Private Sub WedensdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WedensdayToolStripMenuItem.Click
        PanelMonday.Visible = False
        PanelTuesday.Visible = False
        PanelWednesday.Visible = True
        PanelThursday.Visible = False
        PanelFriday.Visible = False
        PanelWelcome.Visible = False
    End Sub

    Private Sub ThusrdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThusrdayToolStripMenuItem.Click
        PanelMonday.Visible = False
        PanelTuesday.Visible = False
        PanelWednesday.Visible = False
        PanelThursday.Visible = True
        PanelFriday.Visible = False
        PanelWelcome.Visible = False
    End Sub

    Private Sub FridayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FridayToolStripMenuItem.Click
        PanelMonday.Visible = False
        PanelTuesday.Visible = False
        PanelWednesday.Visible = False
        PanelThursday.Visible = False
        PanelFriday.Visible = True
        PanelWelcome.Visible = False
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        PanelMonday.Visible = False
        PanelTuesday.Visible = False
        PanelWednesday.Visible = False
        PanelThursday.Visible = False
        PanelFriday.Visible = False
        PanelWelcome.Visible = True
    End Sub

    Private Sub UserAccountSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountSetupToolStripMenuItem.Click


        My.Settings.loadusersetup = True
        My.Settings.Save()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub PublishTimeSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PublishTimeSheetToolStripMenuItem.Click
        PanelMonday.Visible = False
        PanelTuesday.Visible = False
        PanelWednesday.Visible = False
        PanelThursday.Visible = False
        PanelFriday.Visible = False
        PanelWelcome.Visible = True


        'TIMESHEET_MAIN PUBLISH BUTTON
        'ADDS DATA TO FORM4 THEN OPENS REVIEWFORM FOR REVIEW

        If job1.Text <> "" Then
            Form4.DateListBox.Items.Add(date1.Text)
            Form4.JobListBox.Items.Add(job1.Text)
            If Hour1.Text = "" Then
                Hour1.Text = "0"
            End If
            If minute1.Text = "" Then
                minute1.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((Hour1.Text * 60) + minute1.Text) / 60, "0.00"))
        End If




        If job2.Text <> "" Then
            Form4.DateListBox.Items.Add(date2.Text)
            Form4.JobListBox.Items.Add(job2.Text)
            If hour2.Text = "" Then
                hour2.Text = "0"
            End If
            If minute2.Text = "" Then
                minute2.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour2.Text * 60) + minute2.Text) / 60, "0.00"))
        End If




        If job3.Text <> "" Then
            Form4.DateListBox.Items.Add(date3.Text)
            Form4.JobListBox.Items.Add(job3.Text)
            If hour3.Text = "" Then
                hour3.Text = "0"
            End If
            If minute3.Text = "" Then
                minute3.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour3.Text * 60) + minute3.Text) / 60, "0.00"))
        End If




        If job4.Text <> "" Then
            Form4.DateListBox.Items.Add(date4.Text)
            Form4.JobListBox.Items.Add(job4.Text)
            If hour4.Text = "" Then
                hour4.Text = "0"
            End If
            If minute4.Text = "" Then
                minute4.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour4.Text * 60) + minute4.Text) / 60, "0.00"))
        End If




        If job5.Text <> "" Then
            Form4.DateListBox.Items.Add(date5.Text)
            Form4.JobListBox.Items.Add(job5.Text)
            If hour5.Text = "" Then
                hour5.Text = "0"
            End If
            If minute5.Text = "" Then
                minute5.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour5.Text * 60) + minute5.Text) / 60, "0.00"))
        End If




        If job6.Text <> "" Then
            Form4.DateListBox.Items.Add(date6.Text)
            Form4.JobListBox.Items.Add(job6.Text)
            If hour6.Text = "" Then
                hour6.Text = "0"
            End If
            If minute6.Text = "" Then
                minute6.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour6.Text * 60) + minute6.Text) / 60, "0.00"))
        End If




        If job7.Text <> "" Then
            Form4.DateListBox.Items.Add(date7.Text)
            Form4.JobListBox.Items.Add(job7.Text)
            If hour7.Text = "" Then
                hour7.Text = "0"
            End If
            If minute7.Text = "" Then
                minute7.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour7.Text * 60) + minute7.Text) / 60, "0.00"))
        End If




        If job8.Text <> "" Then
            Form4.DateListBox.Items.Add(date8.Text)
            Form4.JobListBox.Items.Add(job8.Text)
            If hour8.Text = "" Then
                hour8.Text = "0"
            End If
            If minute8.Text = "" Then
                minute8.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour8.Text * 60) + minute8.Text) / 60, "0.00"))
        End If




        If job9.Text <> "" Then
            Form4.DateListBox.Items.Add(date9.Text)
            Form4.JobListBox.Items.Add(job9.Text)
            If hour9.Text = "" Then
                hour9.Text = "0"
            End If
            If minute9.Text = "" Then
                minute9.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour9.Text * 60) + minute9.Text) / 60, "0.00"))
        End If




        If job10.Text <> "" Then
            Form4.DateListBox.Items.Add(date10.Text)
            Form4.JobListBox.Items.Add(job10.Text)
            If hour10.Text = "" Then
                hour10.Text = "0"
            End If
            If minute10.Text = "" Then
                minute10.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour10.Text * 60) + minute10.Text) / 60, "0.00"))
        End If




        If job11.Text <> "" Then
            Form4.DateListBox.Items.Add(date11.Text)
            Form4.JobListBox.Items.Add(job11.Text)
            If hour11.Text = "" Then
                hour11.Text = "0"
            End If
            If minute11.Text = "" Then
                minute11.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour11.Text * 60) + minute11.Text) / 60, "0.00"))
        End If




        If job12.Text <> "" Then
            Form4.DateListBox.Items.Add(date12.Text)
            Form4.JobListBox.Items.Add(job12.Text)
            If hour12.Text = "" Then
                hour12.Text = "0"
            End If
            If minute12.Text = "" Then
                minute12.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour12.Text * 60) + minute12.Text) / 60, "0.00"))
        End If




        If job13.Text <> "" Then
            Form4.DateListBox.Items.Add(date13.Text)
            Form4.JobListBox.Items.Add(job13.Text)
            If hour13.Text = "" Then
                hour13.Text = "0"
            End If
            If minute13.Text = "" Then
                minute13.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour13.Text * 60) + minute13.Text) / 60, "0.00"))
        End If




        If job14.Text <> "" Then
            Form4.DateListBox.Items.Add(date14.Text)
            Form4.JobListBox.Items.Add(job14.Text)
            If hour14.Text = "" Then
                hour14.Text = "0"
            End If
            If minute14.Text = "" Then
                minute14.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour14.Text * 60) + minute14.Text) / 60, "0.00"))
        End If




        If job15.Text <> "" Then
            Form4.DateListBox.Items.Add(date15.Text)
            Form4.JobListBox.Items.Add(job15.Text)
            If hour15.Text = "" Then
                hour15.Text = "0"
            End If
            If minute15.Text = "" Then
                minute15.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour15.Text * 60) + minute15.Text) / 60, "0.00"))
        End If




        If job16.Text <> "" Then
            Form4.DateListBox.Items.Add(date16.Text)
            Form4.JobListBox.Items.Add(job16.Text)
            If hour16.Text = "" Then
                hour16.Text = "0"
            End If
            If minute16.Text = "" Then
                minute16.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour16.Text * 60) + minute16.Text) / 60, "0.00"))
        End If




        If job17.Text <> "" Then
            Form4.DateListBox.Items.Add(date17.Text)
            Form4.JobListBox.Items.Add(job17.Text)
            If hour17.Text = "" Then
                hour17.Text = "0"
            End If
            If minute17.Text = "" Then
                minute17.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour17.Text * 60) + minute17.Text) / 60, "0.00"))
        End If




        If job18.Text <> "" Then
            Form4.DateListBox.Items.Add(date18.Text)
            Form4.JobListBox.Items.Add(job18.Text)
            If hour18.Text = "" Then
                hour18.Text = "0"
            End If
            If minute18.Text = "" Then
                minute18.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour18.Text * 60) + minute18.Text) / 60, "0.00"))
        End If




        If job19.Text <> "" Then
            Form4.DateListBox.Items.Add(date19.Text)
            Form4.JobListBox.Items.Add(job19.Text)
            If hour19.Text = "" Then
                hour19.Text = "0"
            End If
            If minute19.Text = "" Then
                minute19.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour19.Text * 60) + minute19.Text) / 60, "0.00"))
        End If




        If job20.Text <> "" Then
            Form4.DateListBox.Items.Add(date20.Text)
            Form4.JobListBox.Items.Add(job20.Text)
            If hour20.Text = "" Then
                hour20.Text = "0"
            End If
            If minute20.Text = "" Then
                minute20.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour20.Text * 60) + minute20.Text) / 60, "0.00"))
        End If




        If job21.Text <> "" Then
            Form4.DateListBox.Items.Add(date21.Text)
            Form4.JobListBox.Items.Add(job21.Text)
            If hour21.Text = "" Then
                hour21.Text = "0"
            End If
            If minute21.Text = "" Then
                minute21.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour21.Text * 60) + minute21.Text) / 60, "0.00"))
        End If




        If job22.Text <> "" Then
            Form4.DateListBox.Items.Add(date22.Text)
            Form4.JobListBox.Items.Add(job22.Text)
            If hour22.Text = "" Then
                hour22.Text = "0"
            End If
            If minute22.Text = "" Then
                minute22.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour22.Text * 60) + minute22.Text) / 60, "0.00"))
        End If




        If job23.Text <> "" Then
            Form4.DateListBox.Items.Add(date23.Text)
            Form4.JobListBox.Items.Add(job23.Text)
            If hour23.Text = "" Then
                hour23.Text = "0"
            End If
            If minute23.Text = "" Then
                minute23.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour23.Text * 60) + minute23.Text) / 60, "0.00"))
        End If




        If job24.Text <> "" Then
            Form4.DateListBox.Items.Add(date24.Text)
            Form4.JobListBox.Items.Add(job24.Text)
            If hour24.Text = "" Then
                hour24.Text = "0"
            End If
            If minute24.Text = "" Then
                minute24.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour24.Text * 60) + minute24.Text) / 60, "0.00"))
        End If




        If job25.Text <> "" Then
            Form4.DateListBox.Items.Add(date25.Text)
            Form4.JobListBox.Items.Add(job25.Text)
            If hour25.Text = "" Then
                hour25.Text = "0"
            End If
            If minute25.Text = "" Then
                minute25.Text = "0"
            End If
            Form4.TimeListBox.Items.Add(Format(((hour25.Text * 60) + minute25.Text) / 60, "0.00"))
        End If



        ReviewForm.Show()
        Me.Hide()
    End Sub

    Private Sub ClearTimesheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearTimesheetToolStripMenuItem.Click
        Dim clearsure As Integer
        clearsure = MsgBox("Are you sure you would like to clear the time sheet? This Cannot be undone.", 4, "Conformation")
        If clearsure = 6 Then

            My.Settings.job1 = ""
            My.Settings.job2 = ""
            My.Settings.job3 = ""
            My.Settings.job4 = ""
            My.Settings.job5 = ""
            My.Settings.job6 = ""
            My.Settings.job7 = ""
            My.Settings.job8 = ""
            My.Settings.job9 = ""
            My.Settings.job10 = ""
            My.Settings.job11 = ""
            My.Settings.job12 = ""
            My.Settings.job13 = ""
            My.Settings.job14 = ""
            My.Settings.job15 = ""
            My.Settings.job16 = ""
            My.Settings.job17 = ""
            My.Settings.job18 = ""
            My.Settings.job19 = ""
            My.Settings.job20 = ""
            My.Settings.job21 = ""
            My.Settings.job22 = ""
            My.Settings.job23 = ""
            My.Settings.job24 = ""
            My.Settings.job25 = ""
            My.Settings.Date1 = ""
            My.Settings.date2 = ""
            My.Settings.date3 = ""
            My.Settings.date4 = ""
            My.Settings.date5 = ""
            My.Settings.date6 = ""
            My.Settings.date7 = ""
            My.Settings.date8 = ""
            My.Settings.date9 = ""
            My.Settings.date10 = ""
            My.Settings.date11 = ""
            My.Settings.date12 = ""
            My.Settings.date13 = ""
            My.Settings.date14 = ""
            My.Settings.date15 = ""
            My.Settings.date16 = ""
            My.Settings.date17 = ""
            My.Settings.date18 = ""
            My.Settings.date19 = ""
            My.Settings.date20 = ""
            My.Settings.date21 = ""
            My.Settings.date22 = ""
            My.Settings.date23 = ""
            My.Settings.date24 = ""
            My.Settings.date25 = ""
            My.Settings.hour1 = ""
            My.Settings.hour2 = ""
            My.Settings.hour3 = ""
            My.Settings.hour4 = ""
            My.Settings.hour5 = ""
            My.Settings.hour6 = ""
            My.Settings.hour7 = ""
            My.Settings.hour8 = ""
            My.Settings.hour9 = ""
            My.Settings.hour10 = ""
            My.Settings.hour11 = ""
            My.Settings.hour12 = ""
            My.Settings.hour13 = ""
            My.Settings.hour14 = ""
            My.Settings.hour15 = ""
            My.Settings.hour16 = ""
            My.Settings.hour17 = ""
            My.Settings.hour18 = ""
            My.Settings.hour19 = ""
            My.Settings.hour20 = ""
            My.Settings.hour21 = ""
            My.Settings.hour22 = ""
            My.Settings.hour23 = ""
            My.Settings.hour24 = ""
            My.Settings.hour25 = ""
            My.Settings.min1 = ""
            My.Settings.min2 = ""
            My.Settings.min3 = ""
            My.Settings.min4 = ""
            My.Settings.min5 = ""
            My.Settings.min6 = ""
            My.Settings.min7 = ""
            My.Settings.min8 = ""
            My.Settings.min9 = ""
            My.Settings.min10 = ""
            My.Settings.min11 = ""
            My.Settings.min12 = ""
            My.Settings.min13 = ""
            My.Settings.min14 = ""
            My.Settings.min15 = ""
            My.Settings.min16 = ""
            My.Settings.min17 = ""
            My.Settings.min18 = ""
            My.Settings.min19 = ""
            My.Settings.min20 = ""
            My.Settings.min21 = ""
            My.Settings.min22 = ""
            My.Settings.min23 = ""
            My.Settings.min24 = ""
            My.Settings.min25 = ""
            My.Settings.Save()
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
            date1.Text = My.Settings.Date1
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
            Hour1.Text = My.Settings.hour1
            hour2.Text = My.Settings.hour2
            hour3.Text = My.Settings.hour3
            hour4.Text = My.Settings.hour4
            hour5.Text = My.Settings.hour5
            hour6.Text = My.Settings.hour6
            hour7.Text = My.Settings.hour7
            hour8.Text = My.Settings.hour8
            hour9.Text = My.Settings.hour9
            hour10.Text = My.Settings.hour10
            hour11.Text = My.Settings.hour11
            hour12.Text = My.Settings.hour12
            hour13.Text = My.Settings.hour13
            hour14.Text = My.Settings.hour14
            hour15.Text = My.Settings.hour15
            hour16.Text = My.Settings.hour16
            hour17.Text = My.Settings.hour17
            hour18.Text = My.Settings.hour18
            hour19.Text = My.Settings.hour19
            hour20.Text = My.Settings.hour20
            hour21.Text = My.Settings.hour21
            hour22.Text = My.Settings.hour22
            hour23.Text = My.Settings.hour23
            hour24.Text = My.Settings.hour24
            hour25.Text = My.Settings.hour25
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


        End If
    End Sub

    Private Sub ReportABugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportABugToolStripMenuItem.Click
        FormReportBug.Show()
    End Sub

    Private Sub MakeASugestionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeASugestionToolStripMenuItem.Click
        FormSugestions.Show()
    End Sub

    Private Sub WhatsNewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhatsNewToolStripMenuItem1.Click
        whatsnewform.Show()

    End Sub
    'Public Sub calchours()
    '  Weekhours.Text = "0"

    '  Try
    '  Weekhours.Text = Weekhours.Text + ((Hour1.Text * 60) + minute1.Text) / 60
    ' Catch ex As Exception
    '  End Try
    '  Try
    '     Weekhours.Text = Weekhours.Text + ((hour2.Text * 60) + minute2.Text) / 61
    '  Catch ex As Exception
    '  End Try
    '  Try
    '    Weekhours.Text = Weekhours.Text + ((hour3.Text * 60) + minute3.Text) / 62
    '  Catch ex As Exception
    '  End Try
    '  Try
    '     Weekhours.Text = Weekhours.Text + ((hour4.Text * 60) + minute4.Text) / 63
    ' Catch ex As Exception
    ' End Try
    ' Try
    '    Weekhours.Text = Weekhours.Text + ((hour5.Text * 60) + minute5.Text) / 64
    ' Catch ex As Exception
    ' End Try
    ' Try
    '     Weekhours.Text = Weekhours.Text + ((hour6.Text * 60) + minute6.Text) / 65
    ' Catch ex As Exception
    ' End Try
    ' Try
    '     Weekhours.Text = Weekhours.Text + ((hour7.Text * 60) + minute7.Text) / 66
    ' Catch ex As Exception
    ' End Try
       '     Weekhours.Text = Weekhours.Text + ((hour8.Text * 60) + minute8.Text) / 67
    '  Catch ex As Exception
    ' End Try
    '  Try
    '    Weekhours.Text = Weekhours.Text + ((hour9.Text * 60) + minute9.Text) / 68
    ' Catch ex As Exception
    ' End Try
    ' Try
    '    Weekhours.Text = Weekhours.Text + ((hour10.Text * 60) + minute10.Text) / 69
    ' Catch ex As Exception
    ' End Try
    ' Try
    '   Weekhours.Text = Weekhours.Text + ((hour11.Text * 60) + minute11.Text) / 70
    ' Catch ex As Exception
    ' End Try
    ' Try
    '    Weekhours.Text = Weekhours.Text + ((hour12.Text * 60) + minute12.Text) / 71
    ' Catch ex As Exception
    ' End Try
    ' Try
    '    Weekhours.Text = Weekhours.Text + ((hour13.Text * 60) + minute13.Text) / 72
    ' Catch ex As Exception
    ' End Try
    ' Try
    '     Weekhours.Text = Weekhours.Text + ((hour14.Text * 60) + minute14.Text) / 73
    ' Catch ex As Exception
    ' End Try
    '  Try
    '     Weekhours.Text = Weekhours.Text + ((hour15.Text * 60) + minute15.Text) / 74
    ' Catch ex As Exception
    '  End Try
    '  Try
    '     Weekhours.Text = Weekhours.Text + ((hour16.Text * 60) + minute16.Text) / 75
    ' Catch ex As Exception
    ' End Try
    '  Try
    '     Weekhours.Text = Weekhours.Text + ((hour17.Text * 60) + minute17.Text) / 76
    '  Catch ex As Exception
    '  End Try
    '  Try
    '      Weekhours.Text = Weekhours.Text + ((hour18.Text * 60) + minute18.Text) / 77
    '  Catch ex As Exception
    ' End Try
    ' Try
    '     Weekhours.Text = Weekhours.Text + ((hour19.Text * 60) + minute19.Text) / 78
    ' Catch ex As Exception
    '  End Try
    '  Try
    '      Weekhours.Text = Weekhours.Text + ((hour20.Text * 60) + minute20.Text) / 79
    ' Catch ex As Exception
    '  End Try
    ' Try
    '     Weekhours.Text = Weekhours.Text + ((hour21.Text * 60) + minute21.Text) / 80
    ' Catch ex As Exception
    '  End Try
    '  Try
    '     Weekhours.Text = Weekhours.Text + ((hour22.Text * 60) + minute22.Text) / 81
    '  Catch ex As Exception
    '  End Try
    '  Try
    '      Weekhours.Text = Weekhours.Text + ((hour23.Text * 60) + minute23.Text) / 82
    '  Catch ex As Exception
    '  End Try
    '  Try
    '    Weekhours.Text = Weekhours.Text + ((hour24.Text * 60) + minute24.Text) / 83
    ' Catch ex As Exception
    ' End Try
    '  Try
    '     Weekhours.Text = Weekhours.Text + ((hour25.Text * 60) + minute25.Text) / 84
    ' Catch ex As Exception
    '  End Try


    'End Sub

    Private Sub hour21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hour21.TextChanged
        ' calchours()

    End Sub

    Private Sub minute21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minute21.TextChanged
        ' calchours()
    End Sub

    Private Sub hour22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hour22.TextChanged
        'calchours()
    End Sub

    Private Sub minute22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minute22.TextChanged
        'calchours()
    End Sub

    Private Sub hour23_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hour23.TextChanged
        'calchours()
    End Sub

    Private Sub minute23_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minute23.TextChanged
        'calchours()
    End Sub

    Private Sub hour24_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hour24.TextChanged
        'calchours()
    End Sub

    Private Sub minute24_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minute24.TextChanged
        ' calchours()
    End Sub

    Private Sub hour25_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hour25.TextChanged
        ' calchours()
    End Sub

    Private Sub minute25_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minute25.TextChanged
        'calchours()
    End Sub


    Private Sub TutorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutorialToolStripMenuItem.Click
        System.Diagnostics.Process.Start("P:\Northshore Time Sheet\Tutorial.pdf")

    End Sub

    Private Sub MathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MathToolStripMenuItem.Click
        ' Me.Width = 600
        ' Me.Height = 600
        'MathTab.Visible = True



    End Sub
    Public Sub donebutton(ByVal last)

        ' MathTab.Visible = False
        ' last.Visible = True

    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim lastwindow As String = My.Settings.PreviousActiveWindow
        ' donebutton(lastwindow)

    End Sub

    Private Sub LookupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookupToolStripMenuItem.Click
        'Me.Width = 600
        'Me.Height = 600
        'lookuptab.visable=true

    End Sub

    Private Sub NewJobCreatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewJobCreatorToolStripMenuItem.Click
        newjobcreatorform.Show()

    End Sub

    
    

    Private Sub JobExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobExplorerToolStripMenuItem.Click

        If CheckBox_Explorer.Checked = True Then
            CheckBox_Explorer.Checked = False
            exploreroff()
        Else
            CheckBox_Explorer.Checked = True
            exploreron()
        End If
        

    End Sub

    Public Sub exploreron()

        If CheckBox_Explorer.Checked = True And ExplorerTitle.Text <> "" Then
            TabControl_Explorer.Visible = True
            ExplorerTitle.Visible = True
            ExplorerNote.Visible = True
            Me.Width = 720
            'CheckBox_Explorer.Checked = True

            Dim active_job As String = ExplorerTitle.Text
            Dim active_job_location_Northshore As String = "P:\Job file\" & active_job
            Dim active_job_location_Northclad As String = "P:\Job file - NORTHCLAD\" & active_job
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Try
                For Each i1 As String In System.IO.Directory.GetDirectories(active_job_location_Northshore & "\Submittals\CADD Shops\")

                    ListBox_Autocad_1.Items.Add(i1)


                Next
            Catch ex As Exception
            End Try

            Try
                For Each i2 As String In System.IO.Directory.GetDirectories(active_job_location_Northclad & "\Submittals\CADD Shops\")

                    ListBox_Autocad_1.Items.Add(i2)


                Next
            Catch ex As Exception
            End Try
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Try
                For Each i3 As String In My.Computer.FileSystem.GetFiles(active_job_location_Northshore & "\Workorders\")
                    'Dim dirc As String = i
                    ' Dim arydirc() As String = i.Split("\")
                    ListBox_Workorders.Items.Add(i3)

                Next
            Catch ex As Exception
            End Try

            Try
                For Each i4 As String In My.Computer.FileSystem.GetFiles(active_job_location_Northclad & "\Workorders\")
                    ' Dim dirc As String = i
                    ' Dim arydirc() As String = i.Split("\")
                    ListBox_Workorders.Items.Add(i4)

                Next
            Catch ex As Exception
            End Try
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Try
                For Each i5 As String In My.Computer.FileSystem.GetFiles(active_job_location_Northshore & "\Plans\")
                    'Dim dirc As String = i
                    ' Dim arydirc() As String = i.Split("\")
                    ListBox_Plans.Items.Add(i5)

                Next
            Catch ex As Exception
            End Try

            Try
                For Each i6 As String In My.Computer.FileSystem.GetFiles(active_job_location_Northclad & "\Plans\")
                    ' Dim dirc As String = i
                    ' Dim arydirc() As String = i.Split("\")
                    ListBox_Plans.Items.Add(i6)

                Next
            Catch ex As Exception
            End Try
           
        End If

        ListBox_Autocad_1.Sorted = True

        ListBox_Autocad_1.Refresh()

        Dim index As Integer

        Dim itemcount As Integer = ListBox_Autocad_1.Items.Count


        If itemcount > 1 Then
            Dim lastitem As String = ListBox_Autocad_1.Items(itemcount - 1)


            For index = itemcount - 2 To 0 Step -1

                If ListBox_Autocad_1.Items(index) = lastitem Then

                    ListBox_Autocad_1.Items.RemoveAt(index)

                Else

                    lastitem = ListBox_Autocad_1.Items(index)

                End If

            Next

        End If

        ListBox_Workorders.Sorted = True

        ListBox_Workorders.Refresh()

        Dim index2 As Integer

        Dim itemcount2 As Integer = ListBox_Workorders.Items.Count



        If itemcount2 > 1 Then

            Dim lastitem As String = ListBox_Workorders.Items(itemcount2 - 1)



            For index2 = itemcount2 - 2 To 0 Step -1

                If ListBox_Workorders.Items(index2) = lastitem Then

                    ListBox_Workorders.Items.RemoveAt(index2)

                Else

                    lastitem = ListBox_Workorders.Items(index2)

                End If

            Next

        End If

        ListBox_Plans.Sorted = True

        ListBox_Plans.Refresh()

        Dim index3 As Integer

        Dim itemcount3 As Integer = ListBox_Plans.Items.Count



        If itemcount3 > 1 Then

            Dim lastitem As String = ListBox_Plans.Items(itemcount3 - 1)



            For index3 = itemcount3 - 2 To 0 Step -1

                If ListBox_Plans.Items(index3) = lastitem Then

                    ListBox_Plans.Items.RemoveAt(index3)

                Else

                    lastitem = ListBox_Plans.Items(index3)

                End If

            Next

        End If


    End Sub

    Public Sub exploreroff()
        TabControl_Explorer.Visible = False
        ExplorerTitle.Visible = False
        ExplorerNote.Visible = False
        Me.Width = 315
        'CheckBox_Explorer.Checked = False

        ListBox_Autocad_1.Items.Clear()
        ListBox_Autocad_2.Items.Clear()
        ListBox_Workorders.Items.Clear()
        ListBox_Plans.Items.Clear()

        'ListBox_Support.Items.Clear()
        'ListBox_System.Items.Clear()


    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_Explorer.CheckedChanged
        If CheckBox_Explorer.Checked = True Then

            exploreron()
        Else

            exploreroff()
        End If
    End Sub

    Private Sub CheckBox1_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_Explorer.CheckStateChanged

    End Sub

    Private Sub ListBox_Autocad_1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox_Autocad_1.MouseClick
        Dim folder As String = ListBox_Autocad_1.SelectedItem
        ListBox_Autocad_2.Items.Clear()

        Try

            For Each i As String In My.Computer.FileSystem.GetFiles(folder, FileIO.SearchOption.SearchTopLevelOnly, "*.dwg")
                Dim dirc As String = i
                'Dim int As Integer
                Dim arydirc() As String = i.Split("\")
                ListBox_Autocad_2.Items.Add(arydirc(6))
                    Next
             

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListBox_Autocad_2_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox_Autocad_2.MouseDoubleClick
        Dim d As String = ListBox_Autocad_1.SelectedItem
        Dim f As String = ListBox_Autocad_2.SelectedItem
        Dim openf As String = d & "\" & f

        System.Diagnostics.Process.Start(openf)

    End Sub

    Private Sub ListBox_Workorders_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_Workorders.DoubleClick
        System.Diagnostics.Process.Start(ListBox_Workorders.SelectedItem)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If ListBox_JobList.SelectedItem <> "" Then
            SearchResults(ListBox_JobList.SelectedItem)
            panelchoosejob.Visible = False
            Me.Width = 315

            Dim company As String = My.Settings.Company
            Dim job As String = ListBox_JobList.SelectedItem
            Dim Northshore As String = "P:\Job File\"
            'Dim OldNorthshore As String = "P:\Job File\"
            Dim Northclad As String = "P:\Job file - NORTHCLAD\"
            'Dim OldNorthclad As String=

            If company = "Northshore" Then
                Process.Start("explorer.exe", Northshore & job)
            ElseIf company = "Northclad" Then
                Process.Start("explorer.exe", Northclad & job)
            End If
        Else
            MessageBox.Show("Please Choose a job")
            SearchResults(ListBox_JobList.SelectedItem)
        End If
    End Sub

    Private Sub ListBox_Plans_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox_Plans.MouseDoubleClick
        Dim plan As String = ListBox_Plans.SelectedItem
        System.Diagnostics.Process.Start(plan)
    End Sub

    Private Sub ArchUnitConverterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchUnitConverterToolStripMenuItem.Click
        Process.Start("P:\Northshore Time Sheet\Help\Architectural Unit Converter_97.exe")

    End Sub

    Private Sub EqualPanelsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EqualPanelsToolStripMenuItem.Click
        Process.Start("P:\Northshore Time Sheet\Help\Equal Panels.exe")
    End Sub

    Private Sub RiseRunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RiseRunToolStripMenuItem.Click
        Process.Start("P:\Northshore Time Sheet\Help\New Rise Run.exe")
    End Sub

    Private Sub NotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotesToolStripMenuItem.Click
        Process.Start("P:\Northshore Time Sheet\Tools\Notes.exe")
    End Sub

    Private Sub PictureBox2_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDoubleClick
        Form3.Show()

    End Sub
End Class
