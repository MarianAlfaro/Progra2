Public Class Form1
    Private Sub CálculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálculoToolStripMenuItem.Click

        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MsgBox("Los campos están vacíos")
            Exit Sub
        End If

        If (ComboBox1.SelectedIndex = -1) Or (ComboBox2.SelectedIndex = -1) Then
            MsgBox("Seleccione una opción")
            Exit Sub
        End If

        For fila As Integer = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If (matriz(fila, 0) = TextBox1.Text) Then
                    MsgBox("El NIT ya existe")
                    Exit Sub
                End If

            End If
        Next

        If index < 6 Then
            matriz(index, 0) = TextBox1.Text
            matriz(index, 1) = TextBox2.Text
            matriz(index, 2) = TextBox3.Text
            matriz(index, 3) = TextBox4.Text
            matriz(index, 4) = ComboBox1.Text
            matriz(index, 5) = ComboBox2.Text

            Select Case ComboBox1.SelectedIndex
                Case 0
                    matriz(index, 6) = Val(TextBox3.Text) * 350
                Case 1
                    matriz(index, 6) = Val(TextBox3.Text) * 250
                Case 2
                    matriz(index, 6) = Val(TextBox3.Text) * 150
            End Select

            Select Case ComboBox2.SelectedIndex
                Case 0 Or 1
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.1 * -1
                Case 2
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.08 * -1
                Case 3
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.015
            End Select

            matriz(index, 8) = Val(matriz(index, 6)) + Val(matriz(index, 7))

            MsgBox("Se almacenaron los siguientes datos con éxito" + matriz(index, 0) + matriz(index, 1) + matriz(index, 2) + matriz(index, 3) + matriz(index, 4) + matriz(index, 5) + matriz(index, 6) + matriz(index, 7) + matriz(index, 8) + matriz(index, 9))
            index = index + 1
        End If


    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

        Dim fila As Integer = 0
        While fila < 6
            If (matriz(fila, 0) <> Nothing) Then
                DataGridView1.Rows.Add(matriz(fila, 0), matriz(fila, 1), matriz(fila, 2), matriz(fila, 3), matriz(fila, 4), matriz(fila, 5), matriz(fila, 6), matriz(fila, 7), matriz(fila, 8), matriz(fila, 9))
            End If
            fila = fila + 1
        End While

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            MsgBox("No seleccionó NIT")
            Exit Sub
        End If

        Dim encontro = False

        For fila As Integer = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If (matriz(fila, 0) = TextBox1.Text) Then
                    TextBox2.Text = matriz(fila, 1)
                    TextBox3.Text = matriz(fila, 2)
                    TextBox4.Text = matriz(fila, 3)
                    ComboBox1.Text = matriz(fila, 4)
                    ComboBox2.Text = matriz(fila, 5)
                    encontro = True
                    MsgBox("Se encontró el paciente")
                    Exit Sub
                End If

            End If
        Next

        If (encontro = False) Then
            MsgBox("No se encontró el paciente")
        End If

    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click

        For fila As Integer = 0 To 5
            For columna As Integer = 0 To 8
                matriz(fila, columna) = Nothing
            Next
        Next

    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem.Click

        Dim fila As Integer = 0

        Dim estadistica1 = 0
        Dim estadistica2 = 0
        Dim estadistica3 = 0

        While fila < 6
            If (matriz(fila, 0) <> Nothing) Then

                If matriz(fila, 4) = "Privada" Then
                    estadistica1 = estadistica1 + 1
                End If

                If matriz(fila, 5) = "Transferencia" Then
                    estadistica2 = estadistica2 + Val(matriz(fila, 8))
                End If

                If matriz(fila, 4) = "No privada" Then
                    estadistica3 = estadistica3 + Val(matriz(fila, 2))
                End If

            End If
            fila = fila + 1
        End While

        TextBox5.Text = estadistica1
        TextBox6.Text = estadistica2
        TextBox7.Text = estadistica3

    End Sub

    Private Sub LimpiarEstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadísticasToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub LimpiarTablaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarTablaToolStripMenuItem.Click

        DataGridView1.Rows.Clear()

    End Sub
End Class
