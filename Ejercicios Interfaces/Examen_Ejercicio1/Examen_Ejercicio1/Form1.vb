Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fuentes()
        control()


    End Sub

    Private Sub fuentes()

        Dim fuente As FontFamily

        For Each fuente In FontFamily.Families

            CB_Fuentes.Items.Add(fuente.Name)

        Next

        CB_Fuentes.Text = CB_Fuentes.Items(0)
    End Sub


    Private Sub TB_Fuentes_Scroll(sender As Object, e As EventArgs) Handles TB_Fuentes.Scroll

        tamano()

    End Sub

    Private Sub tamano()

        Lbl_Fuentes.Font = New Font(CB_Fuentes.Text, TB_Fuentes.Value)
    End Sub

    Private Sub CB_Fuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Fuentes.SelectedIndexChanged

        Lbl_Fuentes.Font = New Font(CB_Fuentes.Text, TB_Fuentes.Value)
    End Sub

    Private Sub Btn_colores_Click(sender As Object, e As EventArgs) Handles Btn_colores.Click

        For Each panel As Panel In GB_colores.Controls

            panel.BackColor = Color.FromArgb(255, Rnd() * 255, Rnd() * 255, Rnd() * 255)

        Next
    End Sub

    Private Sub cambiarColor(sender As Object, e As EventArgs)

        Dim panel As Panel = sender

        For Each radios As RadioButton In GB_opciones.Controls
            If radios.Checked Then
                Select Case radios.Name

                    Case "Rbtn_fuente"
                        Lbl_Fuentes.ForeColor = panel.BackColor

                    Case "Rbtn_fondo"
                        Lbl_Fuentes.BackColor = panel.BackColor
                End Select
            End If
        Next
    End Sub

    Private Sub control()

        For Each panel As Panel In GB_colores.Controls

            AddHandler panel.Click, AddressOf Me.cambiarColor

        Next
    End Sub
End Class
