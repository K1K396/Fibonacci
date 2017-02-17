Public Class Form1
    Function fibonacci(numero As Integer) As Integer
        Dim anterior As Integer = 1
        Dim siguiente As Integer = 1
        Dim actual As Integer
        Dim cont As Integer = 0
        While cont <= numero
            actual = anterior + siguiente
            anterior = siguiente
            siguiente = actual
            cont = cont + 1
        End While
        Return actual
    End Function
    Private Sub btnFibonacci_Click(sender As Object, e As EventArgs) Handles btnFibonacci.Click
        txtRespuesta.Text = fibonacci(txtParametro.Text)
    End Sub
End Class
