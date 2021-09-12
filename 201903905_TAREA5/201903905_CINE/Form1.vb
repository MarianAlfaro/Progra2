Public Class Form1
    Private Sub Descuento1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Descuento1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If indice < 9 Then
            funcionA(indice) = ComboBox2.SelectedItem
            cineA(indice) = ComboBox1.SelectedItem
            subtotalapagar(indice) = CalcularSubTotal(funcionA(indice), cineA(indice)) * Val(TextBox1.Text)
            descuento1A(indice) = subtotalapagar(indice) * CalculoDescuento1(funcionA(indice), cineA(indice))
            descuento2A(indice) = subtotalapagar(indice) * CalculoDescuento2(funcionA(indice), cineA(indice))

            Funcion.Items.Add(funcionA(indice))
            Cine.Items.Add(cineA(indice))
            Subtotal.Items.Add(subtotalapagar(indice))
            Descuento1.Items.Add(descuento1A(indice))
            Descuento2.Items.Add(descuento2A(indice))
            Total.Items.Add(subtotalapagar(indice) - descuento1A(indice) - descuento2A(indice))
        ElseIf indice >= 9 Then

        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cine.Items.Clear()
        Funcion.Items.Clear()
        Subtotal.Items.Clear()
        Descuento1.Items.Clear()
        Descuento2.Items.Clear()
        Total.Items.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        TextBox1.Clear()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()

    End Sub


End Class
