Public Class Form1
    Private Sub GuardarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem1.Click
        If indice < 13 Then
            etapa(indice) = TextBox1.Text
            equipo(indice) = ComboBox1.SelectedItem
            kilometros(indice) = TextBox2.Text
            tiempo(indice) = TextBox3.Text

            If RadioButton1.Checked = True Then
                nacionalidad(indice) = "Guatemalteco"
            Else
                nacionalidad(indice) = "Extranjero"
            End If

            If Val(TextBox3.Text) >= 120 & Val(TextBox3.Text) < 140 Then
                penalización(indice) = 30
            ElseIf Val(TextBox3.Text) >= 140 & Val(TextBox3.Text) < 160 Then
                penalización(indice) = 40
            ElseIf Val(TextBox3.Text) >= 160 Then
                penalización(indice) = Val(TextBox3.Text) + 50
            End If

            If ((Val(TextBox3.Text) < 85) And (ComboBox1.SelectedItem = "Movistar")) Then
                reducción(indice) = 15
            ElseIf ComboBox1.SelectedItem = "Pro Team" Then
                reducción(indice) = 10
            End If

            tiempototal(indice) = tiempo(indice) + penalización(indice) - reducción(indice)

        End If
    End Sub

    Private Sub MostrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem1.Click
        While indice < 13
            DataGridView1.Rows.Add(etapa(indice), equipo(indice), kilometros(indice), tiempo(indice), nacionalidad(indice), penalización(indice), reducción(indice), tiempototal(indice))
            indice = indice + 1
        End While
    End Sub

    Private Sub EstadísticasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem1.Click
        Dim estadistica1 = 0
        Dim estadistica2 = 0
        Dim estadistica3 = 0
        Dim estadistica4 = 0
        Dim estadistica5 = 0
        Dim estadistica6 = 0
        Dim estadistica7 = 0
        Dim estadistica8 = 0
        Dim estadistica9 = 0

        While indice < 13
            If (indice <> Nothing) Then

                If (nacionalidad(indice) = "Guatemalteco" & kilometros(indice) >= 45) Then
                    estadistica1 = estadistica1 + 1
                End If

                If (equipo(indice) = "Sky") Then
                    estadistica2 = estadistica2 + Val(kilometros(indice))
                End If
                If (equipo(indice) = "Movistar") Then
                    estadistica3 = estadistica3 + Val(kilometros(indice))
                End If
                If (equipo(indice) = "Pro Cycling") Then
                    estadistica4 = estadistica4 + Val(kilometros(indice))
                End If
                If (equipo(indice) = "Pro Team") Then
                    estadistica5 = estadistica5 + Val(kilometros(indice))
                End If

                If (equipo(indice) = "Sky") Then
                    estadistica6 = estadistica6 + Val(tiempototal(indice))
                End If
                If (equipo(indice) = "Movistar") Then
                    estadistica7 = estadistica7 + Val(tiempototal(indice))
                End If
                If (equipo(indice) = "Pro Cycling") Then
                    estadistica8 = estadistica8 + Val(tiempototal(indice))
                End If
                If (equipo(indice) = "Pro Team") Then
                    estadistica9 = estadistica9 + Val(tiempototal(indice))
                End If


            End If
            indice = indice + 1
        End While

        TextBox4.Text = estadistica1

        TextBox5.Text = estadistica2
        TextBox6.Text = estadistica3
        TextBox7.Text = estadistica4
        TextBox8.Text = estadistica5

        TextBox9.Text = estadistica6
        TextBox10.Text = estadistica7
        TextBox11.Text = estadistica8
        TextBox12.Text = estadistica9
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = -1
        RadioButton1.Checked = -1
        RadioButton2.Checked = -1

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem1.Click

        For indice As Integer = 0 To 13
        Next

    End Sub

    Private Sub LimpiarEstadísticasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LimpiarEstadísticasToolStripMenuItem1.Click

        TextBox4.Clear()

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            MsgBox("No indicó etapa")
            Exit Sub
        End If

        Dim encontro = False

        For indice As Integer = 0 To 13
            If (indice <> Nothing) Then
                If (etapa(indice) = TextBox1.Text) Then
                    ComboBox1.Text = equipo(indice)
                    TextBox2.Text = kilometros(indice)
                    TextBox3.Text = tiempo(indice)
                    encontro = True
                    MsgBox("Se encontró el paciente")
                    Exit Sub
                End If

            End If
        Next

        If (encontro = False) Then
            MsgBox("No se encontraron datos para esta etapa")
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
    End Sub

    Private Sub OrdenAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenAscendenteToolStripMenuItem.Click
        Dim columna As DataGridViewColumn
        Dim ds As New DataSet()
        Dim dt As New DataTable("Columnas")
        Dim dc As New DataColumn("nombre", GetType(String))
        dt.Columns.Add(dc)
        For Each columna In Me.DataGridView1.Columns
            Dim dr As DataRow = dt.NewRow
            dr("nombre") = columna.HeaderText
            dt.Rows.Add(dr)
        Next
        ds.Tables.Add(dt)
        ds.WriteXml("C:\datagridview.xml")


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        While indice < 13
            If (indice <> Nothing) Then
                DataGridView1.Rows.Add(etapa(indice), equipo(indice), kilometros(indice), tiempo(indice), nacionalidad(indice), penalización(indice), reducción(indice), tiempototal(indice))
            End If
            indice = indice + 1
        End While
    End Sub
End Class
