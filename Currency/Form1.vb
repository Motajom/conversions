Public Class Form1



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String = "michael"
        Dim password As String = "motajo"
        If TextBox2.Text = username And TextBox3.Text = password Then
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("wrong username/password combination")
        End If
    End Sub
   

End Class
