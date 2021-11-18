Public Class Form1
    Private Sub ImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click
        Dim MiFormImagen As New Form_Imagen
        Dim MiImagen As Image = Nothing
        MiFormImagen.MdiParent = Me

        AbrirArchivo.ShowDialog()
        'MessageBox.Show(AbrirArchivo.FileName)
        MiImagen = Image.FromFile(AbrirArchivo.FileName)

        MiFormImagen.PictureBox1.Image = MiImagen
        MiFormImagen.Show()
    End Sub

    Private Sub FicheroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FicheroToolStripMenuItem.Click
        Dim MiFormTexto As New FormTexto
        MiFormTexto.MdiParent = Me

        AbrirFichero.ShowDialog()
        MiFormTexto.RichTextBox1.LoadFile(AbrirFichero.FileName)

        MiFormTexto.Show()
    End Sub
End Class
