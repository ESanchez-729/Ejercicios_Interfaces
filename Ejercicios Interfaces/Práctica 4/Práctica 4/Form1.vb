Public Class Form1
    Private Sub Agregar(sender As Object, e As EventArgs) Handles Btn_color.Click, Btn_marca.Click, Btn_modelo.Click

        Dim MiBoton As Button = sender
        Dim MiTexto As TextBox = MiBoton.Tag
        Dim MiLista As ListBox = MiTexto.Tag

        If (MiTexto.Text.Trim = "") Or Not (MiLista.Items.IndexOf(MiTexto.Text) = -1) Then Exit Sub

        MiLista.Items.Add(MiTexto.Text)

        MiTexto.Clear()

    End Sub

    Private Sub Eliminar(sender As Object, e As EventArgs) Handles Btn_color2.Click, Btn_marca2.Click, Btn_modelo2.Click

        Dim MiBoton As Button = sender
        Dim MiLista As ListBox = MiBoton.Tag

        MiLista.Items.Remove(MiLista.SelectedItem)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        RelacionListas()
    End Sub

    Private Sub RelacionListas()

        Btn_color.Tag = TextBox_color
        TextBox_color.Tag = ListBox_color
        ListBox_color.Tag = Btn_color

        Btn_marca.Tag = TextBox_marca
        TextBox_marca.Tag = ListBox_marcas
        ListBox_marcas.Tag = Btn_marca

        Btn_modelo.Tag = TextBox_modelo
        TextBox_modelo.Tag = ListBox_modelo
        ListBox_modelo.Tag = Btn_modelo

        Btn_color2.Tag = ListBox_color
        Btn_marca2.Tag = ListBox_marcas
        Btn_modelo2.Tag = ListBox_modelo

    End Sub

    Private Sub TextBox_color_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_color.KeyPress, TextBox_marca.KeyPress, TextBox_modelo.KeyPress
        Dim MiTexto As TextBox = sender
        Dim MiBoton As Button = MiTexto.Tag.Tag
        If e.KeyChar = Chr(13) Then

            e.Handled = True
            Agregar(MiBoton, New EventArgs)

        End If
    End Sub
End Class
