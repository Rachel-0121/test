Public Class Form1
    Dim i As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = "Hello World !! " & i














        i += 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

End Class
