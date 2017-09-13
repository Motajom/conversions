Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
    End Sub
End Class