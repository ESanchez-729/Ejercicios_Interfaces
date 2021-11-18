Public Class FormImagen
    Private Sub BorrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarTodoToolStripMenuItem.Click

        PictureBox1.Image = Nothing
    End Sub

    Private Sub InsertarDesdePortapapelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarDesdePortapapelesToolStripMenuItem.Click

        PictureBox1.Image = Clipboard.GetImage
    End Sub
End Class