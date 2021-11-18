Public Class Form1

    Dim contadorVentanaTexto As Integer
    Dim contadorVentanaImagen As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub exit_app_Click(sender As Object, e As EventArgs) Handles exit_app.Click
        Me.Close()

    End Sub

    Private Sub TSB_texto_Click(sender As Object, e As EventArgs) Handles TSB_texto.Click, TSM_texto.Click
        Dim MiFormTexto As New FormTexto
        MiFormTexto.MdiParent = Me
        contadorVentanaTexto += 1
        MiFormTexto.Text = MiFormTexto.Text + " -- Nº" + Str(contadorVentanaTexto)

        MiFormTexto.Show()
    End Sub

    Private Sub TSB_imagen_Click(sender As Object, e As EventArgs) Handles TSB_imagen.Click, TSM_imagen.Click
        Dim MiFormImagen As New FormImagen
        MiFormImagen.MdiParent = Me
        contadorVentanaImagen += 1
        MiFormImagen.Text = MiFormImagen.Text + " -- Nº" + contadorVentanaImagen.ToString

        MiFormImagen.Show()
    End Sub
    Private Sub TSB_info_Click(sender As Object, e As EventArgs) Handles TSB_info.Click, TSM_info.Click
        Dim AcercaDe As New Acerca_de

        AcercaDe.ShowDialog()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TSM_cerrarActual_Click(sender As Object, e As EventArgs) Handles TSM_cerrarActual.Click

        If (Me.MdiChildren.Length > 0) Then

            ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub TSM_cerrarTodo_Click(sender As Object, e As EventArgs) Handles TSM_cerrarTodo.Click, TSB_cerrar.Click

        For Each Pestaña As Form In Me.MdiChildren

            Pestaña.Close()
        Next
    End Sub
End Class
