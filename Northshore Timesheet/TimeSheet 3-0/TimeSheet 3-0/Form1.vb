Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Height = 352
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ' If TextBox_NewJob.Text <> "" Then
        'Dim newjob As String = TextBox_NewJob.Text
        '  ListBox1.Items.Add(newjob)
        ' End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        For Each i In ListBox1.Items
            My.Settings.date1.Add(i)
        Next
        My.Settings.Save()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim c As Integer = My.Settings.date1.Count
        Try
            For Each i In My.Settings.date1
                Dim index As Integer = c
                ListBox1.Items.Add(My.Settings.date1.IndexOf(index))

                index = index - 1
                If index = -1 Then

                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub
End Class
