Public Class Form1
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click

        vnit(indice) = Val(TextBox1.Text)
        vplaca(indice) = Val(TextBox2.Text)
        vdias(indice) = Val(TextBox3.Text)
        vefectivo(indice) = Val(TextBox4.Text)
        vtarjeta(indice) = Val(TextBox5.Text)

        If Val(TextBox4.Text) + Val(TextBox5.Text) = 100 Then
            vpagoparcial(indice) = vefectivo(indice) + vtarjeta(indice)
            TextBox6.Text = vpagoparcial(indice)
        Else
            MsgBox("El pago no está completo.")
        End If

        If (indice <= 5) Then
            vmarca(indice) = ComboBox1.SelectedItem
            vpagoparcial(indice) = fpagoparcail(vdias(indice), vmarca(indice))
            vdescuento(indice) = vpagoparcial(indice) * fdescuento(vefectivo(indice))
            vrecargo(indice) = vpagoparcial(indice) * frecargo(vefectivo(indice))
            vpagototal(indice) = vpagoparcial(indice) - vdescuento(indice) + vrecargo(indice)

            Placa.Items.Add(vplaca(indice))
            Marca.Items.Add(vmarca(indice))
            Días.Items.Add(vdias(indice))
            PagoParcial.Items.Add(vpagoparcial(indice))
            PagoTotal.Items.Add(vpagototal(indice))

        End If

    End Sub

    Private Sub LimpiarEntradas_Click(sender As Object, e As EventArgs) Handles LimpiarEntradas.Click
        ComboBox1.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub LimpiarVectores_Click(sender As Object, e As EventArgs) Handles LimpiarVectores.Click
        Placa.Items.Clear()
        Marca.Items.Clear()
        Días.Items.Clear()
        PagoParcial.Items.Clear()
        PagoTotal.Items.Clear()

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Form2.Show()
    End Sub
End Class
