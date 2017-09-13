Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "CURRENCY" Then
            Me.Hide()
            Form2.Show()
        ElseIf ListBox1.SelectedItem = "VOLUME" Then
            Me.Hide()
            Form5.Show()
        Else : Me.Hide()
            Form4.Show()
        End If
    End Sub
End Class