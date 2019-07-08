Public Class marcacion
    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim ventanaRegistro As New Registro()
        ventanaRegistro.ShowDialog()
    End Sub
End Class
