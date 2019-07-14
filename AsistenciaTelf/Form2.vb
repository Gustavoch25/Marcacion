Imports System.IO
Imports System.Text
Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient
Public Class Registro
    Implements DPFP.Capture.EventHandler

    Private captura As DPFP.Capture.Capture
    Private enroller As DPFP.Processing.Enrollment
    Private Delegate Sub _delegadoMuestra(ByVal text As String)
    Private Delegate Sub _delegadoControles()
    Private template As DPFP.Template

    Private Sub mostrarVeces(ByVal texto As String)
        If (vecesDedo.InvokeRequired) Then
            Dim deleg As New _delegadoMuestra(AddressOf mostrarVeces)
            Me.Invoke(deleg, New Object() {texto})
        Else
            vecesDedo.Text = texto
        End If
    End Sub

    Private Sub modificarControles()
        If (btnGuardar.InvokeRequired) Then
            Dim deleg As New _delegadoControles(AddressOf modificarControles)
            Me.Invoke(deleg, New Object() {})
        Else
            btnGuardar.Enabled = True
        End If
    End Sub

    Protected Overridable Sub Init()
        Try
            captura = New Capture()
            If Not captura Is Nothing Then
                captura.EventHandler = Me
                enroller = New DPFP.Processing.Enrollment()
                Dim text As New StringBuilder()
                text.AppendFormat("Necesitas pasar el dedo {0} veces", enroller.FeaturesNeeded)
                vecesDedo.Text = text.ToString()
            Else
                MessageBox.Show("No se pudo instanciar la captura")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo inicializar la captura")
        End Try
    End Sub

    Protected Sub iniciarCaptura()
        If Not captura Is Nothing Then
            Try
                captura.StartCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo iniciar la captura")
            End Try
        End If
    End Sub

    Protected Sub pararCaptura()
        If Not captura Is Nothing Then
            Try
                captura.StopCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo detener la captura")
            End Try
        End If
    End Sub
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        ponerImagen(ConvertirSampleaMapadeBits(Sample))
        Procesar(Sample)
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        iniciarCaptura()
        cbArea.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Registro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        pararCaptura()
    End Sub

    Protected Function ConvertirSampleaMapadeBits(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion()
        Dim mapaBits As Bitmap = Nothing
        convertidor.ConvertToPicture(Sample, mapaBits)
        Return mapaBits
    End Function

    Private Sub ponerImagen(ByVal bmp)
        imagenHuella.Image = bmp
    End Sub

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

    Protected Sub Procesar(ByVal Sample As DPFP.Sample)
        Dim caracteristicas As DPFP.FeatureSet = extraerCaracteristicas(Sample, DPFP.Processing.DataPurpose.Enrollment)
        If (Not caracteristicas Is Nothing) Then
            Try
                enroller.AddFeatures(caracteristicas)
            Finally
                Dim text As New StringBuilder()
                text.AppendFormat("Necesitas pasar el dedo {0} veces", enroller.FeaturesNeeded)
                mostrarVeces(text.ToString())
                Select Case enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready
                        template = enroller.Template
                        pararCaptura()
                        modificarControles()
                    Case DPFP.Processing.Enrollment.Status.Failed
                        enroller.Clear()
                        pararCaptura()
                        iniciarCaptura()
                End Select
            End Try
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim builderconex As New MySqlConnectionStringBuilder()
        builderconex.Server = "localhost"
        builderconex.UserID = "root"
        builderconex.Password = ""
        builderconex.Database = "prueba"
        Dim conexion As New MySqlConnection(builderconex.ToString())
        conexion.Open()
        Dim cmd As New MySqlCommand()
        cmd = conexion.CreateCommand
        If (txtNombre.Text.ToString().Equals("")) Then
            MessageBox.Show("Debes de llenar el campo nombre")
        ElseIf (txtApPat.Text.ToString().Equals("")) Then
            MessageBox.Show("Debes de llenar el campo Apellido Paterno")
        ElseIf (txtApMat.Text.ToString().Equals("")) Then
            MessageBox.Show("Debes de llenar el campo Apellido Materno")
        ElseIf (cbArea.Text.ToString().Equals("")) Then
            MessageBox.Show("Debes de llenar el campo Área")
        Else
            cmd.CommandText = "INSERT INTO usuarios(nombre, apePaterno, apeMaterno, area, huella, estado) VALUES(?,?,?,?,?,?)"
            cmd.Parameters.AddWithValue("nombre", txtNombre.Text.ToString())
            cmd.Parameters.AddWithValue("apePaterno", txtApPat.Text.ToString())
            cmd.Parameters.AddWithValue("apeMaterno", txtApMat.Text.ToString())
            Dim area = cbArea.SelectedItem.ToString()
            cmd.Parameters.AddWithValue("area", area)
            Using fm As New MemoryStream(template.Bytes)
                cmd.Parameters.AddWithValue("huella", fm.ToArray())
            End Using
            cmd.Parameters.AddWithValue("estado", "activo")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
            MessageBox.Show("ok")
        End If
    End Sub
End Class