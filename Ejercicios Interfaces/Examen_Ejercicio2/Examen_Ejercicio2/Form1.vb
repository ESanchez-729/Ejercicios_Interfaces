Public Class Form1
    Private Sub TextBox_productos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_productos.KeyPress

        Dim texto As TextBox = TextBox_productos
        Dim lista As ListBox = LB_productos

        If Asc(e.KeyChar) = Keys.Enter Then

            e.Handled = True
            If (texto.Text.Trim = "") Or Not (lista.Items.IndexOf(texto.Text.Trim) = -1) Then Exit Sub
            lista.Items.Add(texto.Text.Trim)
            texto.Clear()
            texto.Focus()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Rbtn_ninguno.Checked = True
        control()
    End Sub

    Private Sub activarElementos(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged

        Panel_apps.Enabled = True
        LB_productos.Enabled = True
        Btn_productos.Enabled = True
        TextBox_productos.Enabled = True
        TextBox_precio.Enabled = True
        LB_productos_comprados.Enabled = True

    End Sub

    Private Sub Rbtn_ninguno_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_ninguno.CheckedChanged

        If (Rbtn_ninguno.Checked) Then

            Panel_apps.Enabled = False
            LB_productos.Enabled = False
            Btn_productos.Enabled = False
            TextBox_productos.Enabled = False
            TextBox_precio.Enabled = False
            LB_productos_comprados.Enabled = False
            LB_productos.Items.Clear()
            LB_productos_comprados.Items.Clear()

            For Each check As CheckBox In Panel_apps.Controls

                check.Checked = False

            Next

        End If




    End Sub

    Private Sub anadirLista(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        If (RadioButton1.Checked) Then

            LB_productos.Items.Clear()
            Dim lista As ListBox = LB_productos
            Dim listaProductos() As String = {"Avast", "Steam", "Discord", "Afterburner"}

            For Each producto As String In listaProductos

                LB_productos.Items.Add(producto)
            Next

        End If

    End Sub

    Private Sub anadirLista2(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If (RadioButton2.Checked) Then

            LB_productos.Items.Clear()
            Dim lista As ListBox = LB_productos
            Dim listaProductos() As String = {"Panda", "Origin", "Skype", "Angel es subnormal"}

            For Each producto As String In listaProductos

                LB_productos.Items.Add(producto)
            Next

        End If

    End Sub

    Private Sub IntercambioListas()

        Do While LB_productos.SelectedItems.Count

            LB_productos_comprados.Items.Add(LB_productos.SelectedItems(0))
            LB_productos.Items.Remove(LB_productos.SelectedItems(0))

        Loop

    End Sub

    Private Sub Btn_productos_Click(sender As Object, e As EventArgs) Handles Btn_productos.Click

        If LB_productos.SelectedItems.Count = 0 Then

            For i As Integer = 0 To LB_productos.Items.Count - 1

                LB_productos.SetSelected(i, True)
            Next

        End If

        IntercambioListas()
    End Sub

    Private Sub hacerAlgo(sender As Object, e As EventArgs)

        Dim checkbox As CheckBox = sender


        If checkbox.Checked = True Then
            For indice As Integer = 0 To LB_productos_comprados.Items.Count - 1
                If LB_productos_comprados.Items(indice) = checkbox.Text Then
                    LB_productos_comprados.Items.RemoveAt(indice)
                End If
            Next

            LB_productos_comprados.Items.Add(checkbox.Text)
        ElseIf checkbox.Checked = False Then
            For indice As Integer = 0 To LB_productos_comprados.Items.Count - 1
                If LB_productos_comprados.Items(indice) = checkbox.Text Then
                    LB_productos_comprados.Items.RemoveAt(indice)
                    Exit Sub
                End If
            Next
        End If

    End Sub

    Private Sub control()

        For Each MiCheckBox As CheckBox In Panel_apps.Controls
            AddHandler MiCheckBox.CheckedChanged, AddressOf Me.hacerAlgo
        Next
    End Sub
End Class
