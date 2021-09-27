Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nit(indice) = Val(TextBox1.Text)
        nombre(indice) = Val(TextBox2.Text)
        direccion(indice) = Val(TextBox3.Text)
        cantidad(indice) = Val(TextBox4.Text)


        If (indice <= 5) Then

            producto(indice) = ComboBox1.SelectedItem
            subtotal(indice) = fsubtotal(producto(indice), cantidad(indice))
            vdescuento(indice) = subtotal(indice) * fdescuento(efectivo(indice))
            vrecargo(indice) = subtotal(indice) * frecargo(efectivo(indice))
            vtotal(indice) = subtotal(indice) - vdescuento(indice) + vrecargo(indice)


            ListBox1.Items.Add(nit(indice))
            ListBox2.Items.Add(nombre(indice))
            ListBox3.Items.Add(direccion(indice))
            ListBox4.Items.Add(producto(indice))
            ListBox5.Items.Add(subtotal(indice))
            ListBox6.Items.Add(vdescuento(indice))
            ListBox7.Items.Add(vrecargo(indice))
            ListBox8.Items.Add(vtotal(indice))
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()

    End Sub
End Class
