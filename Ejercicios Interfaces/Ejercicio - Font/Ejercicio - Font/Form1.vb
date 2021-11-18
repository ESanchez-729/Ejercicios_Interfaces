Public Class Form1

    Dim MiEstilo As FontStyle
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        cargarFuentes()

    End Sub

    Private Sub cargarFuentes()
        Dim MiFuente As FontFamily
        For Each MiFuente In FontFamily.Families

            Cmb_box_fuentes.Items.Add(MiFuente.Name)
        Next

        Cmb_box_fuentes.Text = Cmb_box_fuentes.Items(0)
    End Sub

    Private Sub modificarEstilo()
        Lbl_Saludo.Font = New Font(Lbl_Saludo.Font, MiEstilo)

    End Sub

    Private Sub cambiarTamanyo()
        Lbl_Saludo.Font = New Font(Cmb_box_fuentes.Text, Tb_tamFuente.Value)

    End Sub

    Private Sub ComboBox_Status(sender As Object, e As EventArgs) Handles Cmb_box_fuentes.SelectedIndexChanged

        Lbl_Saludo.Font = New Font(Cmb_box_fuentes.Text, Tb_tamFuente.Value)
    End Sub

    Private Sub SelectorFuente(sender As Object, e As EventArgs) Handles Tb_tamFuente.Scroll

        Lbl_Saludo.Font = New Font(Cmb_box_fuentes.Text, Tb_tamFuente.Value)
    End Sub

    Private Sub Seleccionado(sender As Object, e As EventArgs) Handles Chk_box_negrita.CheckedChanged, Chk_box_inclinada.CheckedChanged, Chk_box_subrayada.CheckedChanged, Chk_box_tachada.CheckedChanged

        MiEstilo = 0

        For Each opcion As CheckBox In Panel_Opciones.Controls

            If opcion.Checked Then

                MiEstilo = MiEstilo + opcion.Font.Style
            End If
        Next

        If MiEstilo = FontStyle.Regular Then

            Chk_box_normal.Checked = True

        Else

            Chk_box_normal.Checked = False
        End If

        modificarEstilo()
    End Sub

    Private Sub status_normal(sender As Object, e As EventArgs) Handles Chk_box_normal.CheckedChanged
        Dim opcion As CheckBox = sender
        If MiEstilo = 0 Then opcion.Checked = True

        If opcion.Checked Then
            MiEstilo = 0
            opcion.Checked = True

            For Each estilo As CheckBox In Panel_Opciones.Controls
                estilo.Checked = False
            Next
        End If

        modificarEstilo()

    End Sub

    Private Sub Tb_scroll(sender As Object, e As EventArgs) Handles Tb_tamFuente.Scroll
        cambiarTamanyo()
        modificarEstilo()

    End Sub

    Private Sub Cb_Fuentes_status(sender As Object, e As EventArgs) Handles Cmb_box_fuentes.SelectedIndexChanged
        cambiarTamanyo()
        modificarEstilo()

    End Sub
End Class
