Public Class FormTexto
    Private Sub TSM_borrarTexto_Click(sender As Object, e As EventArgs) Handles TSM_borrarTexto.Click

        RichTextBox1.Clear()

    End Sub

    Private Sub TSM_insertarTexto_Click(sender As Object, e As EventArgs) Handles TSM_insertarTexto.Click

        RichTextBox1.Paste()
    End Sub
End Class