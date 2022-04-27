Public Class Form1
    Dim strTemp As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "モグラ" Then
            strTemp = Button1.Text
            Button1.Text = Button2.Text
            Button2.Text = strTemp
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "モグラ" Then
            strTemp = Button1.Text
            Button1.Text = Button2.Text
            Button2.Text = strTemp
        End If
    End Sub
End Class
