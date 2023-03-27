Public Class Form1
    Private Sub btnEncriptar_Click(sender As Object, e As EventArgs)

        txtEncriptado.Text = Encriptador.Generador.Encripta(txtSinEncriptar.Text)

    End Sub

    Private Sub btnDesencriptar_Click(sender As Object, e As EventArgs)

        txtResultado.Text = Encriptador.Generador.Desencripta(txtEncriptado.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        txtEncriptado.Text = Encriptador.Numeros.Encripta(txtSinEncriptar.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtResultado.Text = Encriptador.Numeros.Desencripta(txtEncriptado.Text)

    End Sub
End Class
