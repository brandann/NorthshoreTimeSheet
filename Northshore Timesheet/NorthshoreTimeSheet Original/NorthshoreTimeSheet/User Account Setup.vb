Public Class Form1

    Private Sub namebox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles namebox.SelectedIndexChanged
        My.Settings.User = namebox.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub title_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles title.SelectedIndexChanged
        My.Settings.Position = title.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub Pay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pay.SelectedIndexChanged
        My.Settings.Pay = Pay.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.loadusersetup = False Then

            Timesheet_Main.Show()
            Me.Close()

        End If
        namebox.SelectedItem = My.Settings.User
        title.SelectedItem = My.Settings.Position
        Pay.SelectedItem = My.Settings.Pay

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        If My.Settings.User <> "" And My.Settings.Position <> "" And My.Settings.Pay <> "" Then

            Timesheet_Main.Show()
            Me.Close()
            My.Settings.loadusersetup = False
            My.Settings.Save()
        Else
            MessageBox.Show("Please Fill out the Fields to Continue.", "Setup Required")
        End If
    End Sub
End Class