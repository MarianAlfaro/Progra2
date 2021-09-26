Module Module1

    Public vnit(5) As Integer
    Public vmarca(5) As String
    Public vplaca(5) As String
    Public vdias(5) As Integer
    Public vefectivo(5) As Double
    Public vtarjeta(5) As Double
    Public vpagoparcial(5) As Double
    Public vpagototal(5) As Double
    Public vdescuento
    Public vrecargo

    Public indice As Byte = 0


    Public calcpagoparcial As Double = 0
    Public calcdescuento As Double = 0
    Public calcrecargo As Double = 0
    Public calcpagototal As Double = 0


    Function fpagoparcail(vdias As Integer, vmarca As String) As Double
        Select Case Form1.ComboBox1.SelectedIndex
            Case 0
                calcpagoparcial = 250 * Val(Form1.TextBox3.Text)
            Case 1
                calcpagoparcial = 450 * Val(Form1.TextBox3.Text)
            Case 2
                calcpagoparcial = 325 * Val(Form1.TextBox3.Text)
            Case 3
                calcpagoparcial = 300 * Val(Form1.TextBox3.Text)
        End Select
        Return calcpagoparcial
    End Function

    Function fdescuento(vefectivo As Double) As Double
        If (Form1.CheckBox1.Checked And Val(Form1.TextBox4.Text = 100)) Then
            fdescuento = 0.05
        Else
            fdescuento = 0
        End If
        Return fdescuento
    End Function

    Function frecargo(vtarjeta As Double) As Double
        If (Form1.CheckBox2.Checked And Val(Form1.TextBox5.Text = 100)) Then
            frecargo = 0.025
        Else
            frecargo = 0
        End If
        Return frecargo
    End Function




End Module
