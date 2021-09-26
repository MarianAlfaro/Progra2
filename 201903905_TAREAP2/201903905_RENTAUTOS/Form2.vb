Public Class Form2
    Private Sub Si_Click(sender As Object, e As EventArgs) Handles Si.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub No_Click(sender As Object, e As EventArgs) Handles No.Click
        Me.Close()
        Form1.Show()

    End Sub
End Class