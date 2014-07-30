Public Class FormReportBug

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()

    End Sub

    Private Sub BtnSubmitBug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubmitBug.Click
        Dim bugs As New System.IO.StreamWriter("P:\Northshore Time Sheet\Help\Bugs.delorean", True)
        'Dim bugname As String = Form3.Namebox.Text
        'Dim buginfo As String = BugBox.Text

        bugs.WriteLine(My.Settings.User)
        bugs.WriteLine(BugBox.Text)
        bugs.WriteLine("")

        bugs.Close()
        MessageBox.Show("Thank You, This Problem will be investigated ASAP")
        Me.Close()

    End Sub

    Private Sub BugBox_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BugBox.MouseClick
        If BugBox.Text = "This isnt working right..." Then
            BugBox.Text = ""
        End If

    End Sub
End Class