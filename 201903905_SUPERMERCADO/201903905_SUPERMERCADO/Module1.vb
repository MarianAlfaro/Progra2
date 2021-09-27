Module Module1

    Public nit(5) As Integer
    Public nombre(5) As String
    Public direccion(5) As String
    Public producto(5) As String
    Public cantidad(5) As Integer
    Public subtotal(5) As Double
    Public vdescuento(5) As Double
    Public vrecargo(5) As Double
    Public vtotal(5) As Double

    Public efectivo(5) As Double
    Public tarjeta(5) As Double

    Public indice As Byte = 0

    Public calculosubtotal As Double = 0
    Public calculodescuento As Double = 0
    Public calculototal As Double = 0

    Function fsubtotal(Aproducto As String, Acantidad As Double) As Double
        Select Case Form1.ComboBox1.SelectedIndex
            Case 0
                calculosubtotal = Val(Form1.TextBox4.Text) * 3.5
            Case 1
                calculosubtotal = Val(Form1.TextBox4.Text) * 5
            Case 2
                calculosubtotal = Val(Form1.TextBox4.Text) * 8.5
            Case 3
                calculosubtotal = Val(Form1.TextBox4.Text) * 4.5
            Case 4
                calculosubtotal = Val(Form1.TextBox4.Text) * 3
            Case 5
                calculosubtotal = Val(Form1.TextBox4.Text) * 18
        End Select
        Return calculosubtotal
    End Function

    Function fdescuento(Aefectivo As Double) As Double
        If (Form1.CheckBox1.Checked And Val(Form1.TextBox4.Text >= 5)) Then
            fdescuento = 5 / 100
        Else
            fdescuento = 0
        End If
        Return fdescuento

    End Function

    Function frecargo(Atarjeta As Double) As Double
        If (Form1.CheckBox2.Checked) Then
            frecargo = 8 / 100
        Else
            frecargo = 0
        End If
        Return frecargo
    End Function



End Module
