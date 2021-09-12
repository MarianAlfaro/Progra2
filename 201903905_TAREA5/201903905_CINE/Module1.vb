Module Module1

    Public funcionA(8)
    Public cineA(8)
    Public subtotalapagar(8)
    Public descuento1A(8)
    Public descuento2A(8)
    Public totalapagarA(8)

    Public indice = 0



    Public CalculoSubTotal As Double = 0
    Public CalculoDesc1 As Double = 0
    Public CalculoDesc2 As Double = 0
    Public Total As Double = 0

    Function CalcularSubTotal(funcion As String, cine As String) As Double
        Select Case cine
            Case "A"
                Select Case funcion
                    Case "1"
                        CalculoSubTotal = 30
                    Case "2"
                        CalculoSubTotal = 35
                    Case Else
                        CalculoSubTotal = 40
                End Select
            Case "B"
                Select Case funcion
                    Case "1"
                        CalculoSubTotal = 24
                    Case "2"
                        CalculoSubTotal = 34
                    Case Else
                        CalculoSubTotal = 44
                End Select
            Case "C"
                Select Case funcion
                    Case "1"
                        CalculoSubTotal = 35
                    Case "2"
                        CalculoSubTotal = 40
                    Case Else
                        CalculoSubTotal = 50
                End Select

        End Select


        Return CalculoSubTotal

    End Function

    Function CalculoDescuento1(funcion As String, cine As String) As Double

        If (funcion = "3" Or funcion = "4") And (cine = "C" Or cine = "B") Then
            CalculoDescuento1 = 0.055
        ElseIf (funcion = "1") And (cine = "C" Or cine = "B") Then
            CalculoDescuento1 = 0.03
        ElseIf (funcion = "2") And (cine = "A") Then
            CalculoDescuento1 = 0.015
        End If
        Return CalculoDescuento1
    End Function

    Function CalculoDescuento2(funcion As String, cine As String) As Double

        If (subtotalapagar(indice) >= 100 And subtotalapagar(indice) < 300) Then
            CalculoDescuento2 = 0.02
        ElseIf (subtotalapagar(indice) >= 300 And subtotalapagar(indice) < 500) Then
            CalculoDescuento2 = 0.04
        ElseIf (subtotalapagar(indice) >= 500 And subtotalapagar(indice) < 1000) Then
            CalculoDescuento2 = 0.06
        End If
        Return CalculoDescuento2

    End Function

End Module
