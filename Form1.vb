Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim valor1, valor2 As Double

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtValor1.Text = ""
        txtValor2.Text = ""
        txtResultado.Text = ""


    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        valor1 = txtValor1.Text
        valor2 = txtValor2.Text

        txtResultado.Text = valor1 - valor2
    End Sub

    Private Sub btnVezes_Click(sender As Object, e As EventArgs) Handles btnVezes.Click
        valor1 = txtValor1.Text
        valor2 = txtValor2.Text

        txtResultado.Text = valor1 * valor2
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        valor1 = txtValor1.Text
        valor2 = txtValor2.Text

        txtResultado.Text = valor1 / valor2
    End Sub

    Private Sub btnMais_Click(sender As Object, e As EventArgs) Handles btnMais.Click
        valor1 = txtValor1.Text
        valor2 = txtValor2.Text

        txtResultado.Text = valor1 + valor2


    End Sub
End Class
