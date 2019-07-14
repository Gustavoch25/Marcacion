Public Class marcacion
    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim ventanaRegistro As New Registro()
        ventanaRegistro.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventanaPrueba As New Inicio()
        ventanaPrueba.ShowDialog()
    End Sub
End Class
