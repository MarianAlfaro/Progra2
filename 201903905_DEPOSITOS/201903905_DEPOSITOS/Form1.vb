Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If RadioButton3.Checked = True Then
            Select Case Saldo_Nuevo
                Case 1.01 To 1000.99
                    Intereses = 1.5 / 100
                Case 1001 To 5000.99
                    Intereses = 2.5 / 100
                Case 5001 To 15000.99
                    Intereses = 7.5 / 100
                Case Is >= 15001
                    Intereses = 10 / 100
            End Select
            Saldo_Nuevo = Val(MontoCP.Text) + Val(MontoOB.Text) + Val(MontoE.Text) + Val(SaldoAnterior.Text)
            Saldo_Nuevo = Saldo_Nuevo + Saldo_Nuevo * Intereses
            SaldoNuevo.Text = Str(Saldo_Nuevo)
        End If

        If RadioButton2.Checked = True Then
            Select Case Val(SaldoAnterior.Text)
                Case 1.01 To 10000.99
                    Intereses = 2.5 / 100
                Case 10001 To 15000.99
                    Intereses = 3 / 100
                Case Is >= 15001
                    Intereses = 4.5 / 100
            End Select
            Saldo_Nuevo = Val(MontoCP.Text) + Val(MontoOB.Text) + Val(MontoE.Text) + Val(SaldoAnterior.Text) * Intereses
            SaldoNuevo.Text = Str(Saldo_Nuevo)
        End If

        If RadioButton1.Checked = True Then
            Saldo_Nuevo = Val(MontoCP.Text) + Val(MontoOB.Text) + Val(MontoE.Text) + Val(SaldoAnterior.Text)
            SaldoNuevo.Text = Str(Saldo_Nuevo)
        End If
        Interes.Text = Str(Intereses * 100) + "%"


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If RadioButton1.Checked = True Then
            TipoDeSeleccionado = True
        ElseIf RadioButton2.Checked = True Then
            TipoDeSeleccionado = True
        ElseIf RadioButton3.Checked = True Then
            TipoDeSeleccionado = True
        End If

        If TipoDeSeleccionado = True Then
            If CheckBox1.Checked = True Then
                MontoCP.Enabled = True
            End If

            If CheckBox1.Checked = False Then
                MontoCP.Enabled = False
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If RadioButton1.Checked = True Then
            TipoDeSeleccionado = True
        ElseIf RadioButton2.Checked = True Then
            TipoDeSeleccionado = True
        ElseIf RadioButton3.Checked = True Then
            TipoDeSeleccionado = True
        End If

        If TipoDeSeleccionado = True Then
            If CheckBox2.Checked = True Then
                MontoOB.Enabled = True
            End If

            If CheckBox2.Checked = False Then
                MontoOB.Enabled = False
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If RadioButton1.Checked = True Then
            TipoDeSeleccionado = True
        ElseIf RadioButton2.Checked = True Then
            TipoDeSeleccionado = True
        ElseIf RadioButton3.Checked = True Then
            TipoDeSeleccionado = True
        End If

        If TipoDeSeleccionado = True Then
            If CheckBox3.Checked = True Then
                MontoE.Enabled = True
            End If

            If CheckBox3.Checked = False Then
                MontoE.Enabled = False
            End If
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MontoCP.Clear()
        MontoOB.Clear()
        MontoE.Clear()
        SaldoAnterior.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub
End Class
