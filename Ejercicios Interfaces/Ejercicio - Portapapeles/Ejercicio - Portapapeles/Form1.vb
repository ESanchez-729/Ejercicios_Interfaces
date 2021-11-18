Public Class Form1
    Private Sub PicBox_Imagen_DoubleClick(sender As Object, e As EventArgs) Handles PicBox_Imagen.DoubleClick

        Dim MiPictureBox As PictureBox = sender

        MiPictureBox.Image = Clipboard.GetImage()
    End Sub

    Private Sub RichTextBox1_DoubleClick(sender As Object, e As EventArgs) Handles RichTextBox1.DoubleClick
        Dim MiRTexto As RichTextBox = sender

        MiRTexto.Paste()
    End Sub
End Class
