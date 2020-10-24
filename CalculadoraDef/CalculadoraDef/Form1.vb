Public Class Calculadora

    Dim Operacion As String
    Dim Valor1 As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim presionarOperador As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b1.Click
        Concatenar()
        TxtResultado.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b2.Click
        Concatenar()
        TxtResultado.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles b3.Click
        Concatenar()
        TxtResultado.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles b4.Click
        Concatenar()
        TxtResultado.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles b5.Click
        Concatenar()
        TxtResultado.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles b6.Click
        Concatenar()
        TxtResultado.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles b7.Click
        Concatenar()
        TxtResultado.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles b8.Click
        Concatenar()
        TxtResultado.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles b9.Click
        Concatenar()
        TxtResultado.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles b0.Click
        Concatenar()
        TxtResultado.Text &= "0"
    End Sub




    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles bpunto.Click
        Concatenar()
        If InStr(TxtResultado.Text, ".", CompareMethod.Text) = 0 Then
            TxtResultado.Text &= "."
        End If
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles bborrar.Click
        TxtResultado.Text = "0"
        Valor2 = Nothing
        Valor1 = Nothing
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles bigual.Click
        HacerOperacion()
        Operacion = ""
    End Sub





    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles bsumar.Click
        HacerOperacion()
        Operacion = "+"
    End Sub

    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles brestar.Click
        HacerOperacion()
        Operacion = "-"
    End Sub

    Private Sub ButtonMultiplicacion_Click(sender As Object, e As EventArgs) Handles bmultiplicar.Click
        HacerOperacion()
        Operacion = "*"
    End Sub

    Private Sub ButtonDivison_Click(sender As Object, e As EventArgs) Handles bdividir.Click
        HacerOperacion()
        Operacion = "/"
    End Sub







    Public Sub HacerOperacion()
        presionarOperador = True
        Valor2 = Val(TxtResultado.Text)
        If Valor1 IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    Valor1 = Valor1 + Valor2
                Case "-"
                    Valor1 = Valor1 - Valor2
                Case "*"
                    Valor1 = Valor1 * Valor2
                Case "/"
                    Valor1 = Valor1 / Valor2
            End Select
            TxtResultado.Text = Valor1
        Else
            Valor1 = Valor2
        End If
    End Sub

    Public Sub Concatenar()
        If presionarOperador = True Then
            TxtResultado.Text = " "
            presionarOperador = False
        ElseIf TxtResultado.Text = "0" Then
            TxtResultado.Text = " "
        End If
    End Sub

End Class
