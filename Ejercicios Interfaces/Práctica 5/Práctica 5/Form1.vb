Public Class Form1

    Dim MiListaOrigen As ListBox
    Dim MiListaDestino As ListBox
    Private Sub CargaForm(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarControles()

    End Sub

    Private Sub InicializarControles()
        Txt_box1.Tag = ListBox1
        Btn_limpiar1.Tag = ListBox1

        Txt_box2.Tag = ListBox2
        Btn_limpiar2.Tag = ListBox2

        Txt_box3.Tag = ListBox3
        Btn_limpiar3.Tag = ListBox3

    End Sub
    Private Sub AgregarDatos(sender As Object, e As KeyPressEventArgs) Handles Txt_box1.KeyPress, Txt_box2.KeyPress, Txt_box3.KeyPress

        Dim MiTexto As TextBox = sender
        Dim MiLista As ListBox = MiTexto.Tag

        If Asc(e.KeyChar) = Keys.Enter Then

            e.Handled = True
            If (MiTexto.Text.Trim = "") Or Not (MiLista.Items.IndexOf(MiTexto.Text.Trim) = -1) Then Exit Sub
            MiLista.Items.Add(MiTexto.Text.Trim)
            MiTexto.Clear()
            MiTexto.Focus()

            End If
    End Sub

    Private Sub LimpiarLista(sender As Object, e As EventArgs) Handles Btn_limpiar1.Click, Btn_limpiar2.Click, Btn_limpiar3.Click

        Dim MiBoton As Button = sender
        Dim MiLista As ListBox = MiBoton.Tag

        MiLista.Items.Clear()

    End Sub

    Private Sub IntercambioListas()

        Do While MiListaOrigen.SelectedItems.Count

            MiListaDestino.Items.Add(MiListaOrigen.SelectedItems(0))
            MiListaOrigen.Items.Remove(MiListaOrigen.SelectedItems(0))

        Loop

    End Sub

    'Private Sub MoverElemento(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick, ListBox2.DoubleClick, ListBox3.DoubleClick

    '    Dim MiLista As ListBox = sender

    '    If MiLista.SelectedItems.Count = 0 Then Exit Sub

    '    Select Case MiLista.Name
    '        Case "ListBox1"

    '            MiListaOrigen = ListBox1
    '            MiListaDestino = ListBox2

    '        Case "ListBox2"

    '            MiListaOrigen = ListBox2
    '            MiListaDestino = ListBox3

    '        Case "ListBox3"

    '            MiListaOrigen = ListBox3
    '            MiListaDestino = ListBox1

    '    End Select

    '    IntercambioListas()

    'End Sub

    Private Sub Desplazar(sender As Object, e As EventArgs) Handles Btn_mover1.Click, Btn_mover2.Click, Btn_mover3.Click, Btn_mover4.Click

        Dim MiBoton As Button = sender
        Select Case MiBoton.Name
            Case "Btn_mover1"
                MiListaOrigen = ListBox1
                MiListaDestino = ListBox2

            Case "Btn_mover2"
                MiListaOrigen = ListBox2
                MiListaDestino = ListBox1

            Case "Btn_mover3"
                MiListaOrigen = ListBox2
                MiListaDestino = ListBox3

            Case "Btn_mover4"
                MiListaOrigen = ListBox3
                MiListaDestino = ListBox2

        End Select

        If MiListaOrigen.SelectedItems.Count = 0 Then

            For i As Integer = 0 To MiListaOrigen.Items.Count - 1

                MiListaOrigen.SetSelected(i, True)
            Next

        End If

        IntercambioListas()
    End Sub

    Private Sub Listas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown, ListBox2.MouseDown, ListBox3.MouseDown
        MiListaOrigen = sender
        Select Case MiListaOrigen.Name

            Case ListBox1.Name
                MiListaDestino = ListBox2

            Case ListBox2.Name
                MiListaDestino = ListBox3

            Case ListBox3.Name
                MiListaDestino = ListBox1
        End Select

        If e.Clicks = 2 Then

            IntercambioListas()

        End If

        MiListaOrigen.DoDragDrop(MiListaOrigen.Text, DragDropEffects.Move)

    End Sub

    Private Sub Listas_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragOver, ListBox2.DragOver, ListBox3.DragOver
        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub Listas_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragDrop, ListBox2.DragDrop, ListBox3.DragDrop
        MiListaDestino = sender
        IntercambioListas()

    End Sub
End Class
