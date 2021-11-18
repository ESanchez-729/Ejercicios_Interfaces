Public Class Form1
    Friend WithEvents MiReloj As Timer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        MiReloj = New Timer
        MiReloj.Interval = 1000
        MiReloj.Enabled = True
    End Sub

    Private Sub MiReloj_Tick(sender As Object, e As EventArgs) Handles MiReloj.Tick
        Label1.Text = Now().ToLongTimeString
    End Sub
End Class
