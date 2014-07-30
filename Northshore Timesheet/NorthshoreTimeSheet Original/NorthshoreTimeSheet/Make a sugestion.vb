Public Class FormSugestions

    Private Sub SugestionBox_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SugestionBox.MouseClick
        If SugestionBox.Text = "It would be cool if..." Then
            SugestionBox.Text = ""
        End If


    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        Dim sugestions As New System.IO.StreamWriter("P:\Northshore Time Sheet\Help\Sugestions.delorean", True)
        
        sugestions.WriteLine(My.Settings.User)
        sugestions.WriteLine(SugestionBox.Text)
        sugestions.WriteLine("")

        sugestions.Close()
        MessageBox.Show("Thank You.")
        Me.Close()

    End Sub
End Class