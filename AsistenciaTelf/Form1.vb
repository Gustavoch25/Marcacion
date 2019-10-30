Imports System.IO
Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient

Public Class marcacion
    Implements DPFP.Capture.EventHandler

    Private template As DPFP.Template
    Private Captura As DPFP.Capture.Capture
    Private verificador As DPFP.Verification.Verification

    Protected Overridable Sub Init()
        Try
            Captura = New Capture()
            If Not Captura Is Nothing Then
                Captura.EventHandler = Me
                verificador = New Verification.Verification()
                template = New Template()
            Else
                MessageBox.Show("No se pudo instancia la captura")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo inicializar la captura")
        End Try
    End Sub

    Protected Sub iniciarCaptura()
        If Not Captura Is Nothing Then
            Try
                Captura.StartCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo iniciar la captura")
            End Try
        End If
    End Sub

    Protected Sub pararCaptura()
        If Not Captura Is Nothing Then
            Try
                Captura.StopCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo detener la captura")
            End Try
        End If
    End Sub

    Protected Function ConvertirSampleaMapadeBits(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion() 'es una variable de  tipo coversor de dpfp.sample
        Dim mapaBits As Bitmap = Nothing
        convertidor.ConvertToPicture(Sample, mapaBits)
        Return mapaBits
    End Function

    Protected Function extraerCaracteristicas(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim alimentacion As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim caracteristicas As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, alimentacion, caracteristicas)
        If (alimentacion = DPFP.Capture.CaptureFeedback.Good) Then
            Return caracteristicas
        Else
            Return Nothing
        End If
    End Function
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        Dim caracteristicas As DPFP.FeatureSet = extraerCaracteristicas(Sample, DPFP.Processing.DataPurpose.Verification)
        'Dim txtfecha As String = ""
        Dim txtfecha As String = DateTime.Now.ToString("dd/MM/yyyy") 'fecha actual
        Dim txthora As String = Now.ToString("HH:mm:ss")
        Dim marcacion As String = cbOpciones.SelectedItem.ToString()
        If Not caracteristicas Is Nothing Then
            Dim result As New DPFP.Verification.Verification.Result()
            Dim builderconex As New MySqlConnectionStringBuilder()
            builderconex.Server = "localhost"
            builderconex.UserID = "root"
            builderconex.Password = ""
            builderconex.Database = "prueba"
            Dim conexion As New MySqlConnection(builderconex.ToString())
            conexion.Open()
            Dim cmd As New MySqlCommand()
            cmd = conexion.CreateCommand
            cmd.CommandText = "SELECT * FROM usuarios"
            Dim read As MySqlDataReader
            read = cmd.ExecuteReader()
            Dim verificado As Boolean = False
            Dim id As Int32 = 0
            Dim nombre As String = ""
            Dim apePaterno As String = ""
            Dim apeMaterno As String = ""
            Dim fullname As String = ""
            While (read.Read())
                'nombre = read("Nombre")
                Dim memoria As New MemoryStream(CType(read("huella"), Byte()))
                template.DeSerialize(memoria.ToArray())
                verificador.Verify(caracteristicas, template, result)
                If (result.Verified) Then
                    id = read("id")
                    nombre = read("Nombre")
                    apePaterno = read("apePaterno")
                    apeMaterno = read("apeMaterno")
                    fullname = nombre + " " + apePaterno + " " + apeMaterno
                    verificado = True
                    Exit While
                End If
            End While
            read.Dispose()
            cmd.Dispose()
            If (verificado) Then
                If marcacion = "Ingreso" Then
                    Dim vsql As New MySqlCommand()
                    vsql = conexion.CreateCommand
                    vsql.CommandText = "Select id_usuarios FROM registrousuarios WHERE fecha_ingreso = '" & txtfecha & "' And id_usuarios = '" & id & "' "
                    Dim readvsql As MySqlDataReader
                    readvsql = vsql.ExecuteReader()
                    Dim data As String = ""
                    While (readvsql.Read())
                        data = readvsql("id_usuarios")
                        MessageBox.Show("Ya esta registrado en ingreso")
                        readvsql.Dispose()
                        vsql.Dispose()
                        conexion.Close()
                        conexion.Dispose()
                        Exit Sub
                    End While
                    readvsql.Dispose()
                    vsql.Dispose()

                    Dim cmdReg As New MySqlCommand()
                    cmdReg = conexion.CreateCommand
                    cmdReg.CommandText = "INSERT INTO registrousuarios(id_usuarios, fecha_ingreso, hora_ingreso, fecha_salida, hora_salida) VALUES(?,?,?,?,?)"
                    cmdReg.Parameters.AddWithValue("id_usuarios", id)
                    cmdReg.Parameters.AddWithValue("fecha_ingreso", txtfecha)
                    cmdReg.Parameters.AddWithValue("hora_ingreso", txthora)
                    cmdReg.Parameters.AddWithValue("fecha_salida", "")
                    cmdReg.Parameters.AddWithValue("hora_salida", "")
                    cmdReg.ExecuteNonQuery()
                    cmdReg.Dispose()

                    MessageBox.Show(fullname + marcacion + txtfecha + txthora)

                ElseIf marcacion = "Salida" Then
                    'Falta terminar 
                    'UPDATE army SET troop1 = @troop1, troop2 = @troop2, troop3 = @troop3, hero = @hero WHERE username = 'ryan'

                    Dim subNum As Int32 = Convert.ToInt32(Microsoft.VisualBasic.Left(txthora, 2))

                    If 16 <= subNum And subNum < 17 Then
                        Dim txtfechapas As String = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy")
                        Dim cmdRegTN As New MySqlCommand()
                        cmdRegTN = conexion.CreateCommand
                        cmdRegTN.CommandText = "UPDATE registrousuarios SET fecha_salida = @fch_salida, hora_salida = @hr_salida WHERE id_usuarios = '" & id & "' AND fecha_ingreso = '" & txtfechapas & "' "
                        cmdRegTN.Parameters.AddWithValue("@fch_salida", txtfecha)
                        cmdRegTN.Parameters.AddWithValue("@hr_salida", txthora)
                        cmdRegTN.ExecuteNonQuery()
                        cmdRegTN.Dispose()
                        conexion.Close()
                        conexion.Dispose()

                        MessageBox.Show(fullname + marcacion + txtfecha + txthora)
                        Exit Sub
                    End If

                    Dim cmdReg As New MySqlCommand()
                    cmdReg = conexion.CreateCommand
                    cmdReg.CommandText = "UPDATE registrousuarios SET fecha_salida = @fch_salida, hora_salida = @hr_salida WHERE id_usuarios = '" & id & "' AND fecha_ingreso = '" & txtfecha & "' "
                    cmdReg.Parameters.AddWithValue("@fch_salida", txtfecha)
                    cmdReg.Parameters.AddWithValue("@hr_salida", txthora)
                    cmdReg.ExecuteNonQuery()
                    cmdReg.Dispose()

                    MessageBox.Show(fullname + marcacion + txtfecha + txthora)
                End If

            Else
                MessageBox.Show("No se encontro ningun reguistro")
            End If
            conexion.Close()
            conexion.Dispose()
        End If
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        'MessageBox.Show("Se detecto huella")
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        pararCaptura()
        Dim ventanaRegistro As New Registro()
        ventanaRegistro.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventanaPrueba As New Inicio()
        ventanaPrueba.ShowDialog()
    End Sub

    Private Sub Marcacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        iniciarCaptura()
        cbOpciones.DropDownStyle = ComboBoxStyle.DropDownList
        cbOpciones.SelectedIndex = 0
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Marcacion_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        pararCaptura()
    End Sub

    Private Sub Marcacion_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Init()
        iniciarCaptura()
    End Sub
End Class
