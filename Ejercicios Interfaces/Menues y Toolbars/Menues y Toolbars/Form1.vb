Public Class Form1

    Private Sub Salir(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub AbrirCajaTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCajaTextoToolStripMenuItem.Click
        Dim Micaja As New RichTextBox
        Micaja.Multiline = True
        Me.Controls.Add(Micaja)
        Micaja.Dock = DockStyle.Fill

    End Sub


End Class
