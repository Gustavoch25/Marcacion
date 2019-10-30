<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class marcacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(marcacion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtOutEntrada = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbOpciones = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 72)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Por favor ponga su" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dedo en el huellero" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y esperar la confirmacion."
        '
        'TxtOutEntrada
        '
        Me.TxtOutEntrada.AutoSize = True
        Me.TxtOutEntrada.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOutEntrada.Location = New System.Drawing.Point(119, 247)
        Me.TxtOutEntrada.Name = "TxtOutEntrada"
        Me.TxtOutEntrada.Size = New System.Drawing.Size(109, 26)
        Me.TxtOutEntrada.TabIndex = 2
        Me.TxtOutEntrada.Text = "Bienvenid@"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "REGISTRO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AsistenciaTelf.My.Resources.Resources.Huella
        Me.PictureBox1.Location = New System.Drawing.Point(210, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnRegistro
        '
        Me.btnRegistro.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.Location = New System.Drawing.Point(683, 38)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(90, 28)
        Me.btnRegistro.TabIndex = 6
        Me.btnRegistro.Text = "Registar"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(683, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Marcación de:"
        '
        'cbOpciones
        '
        Me.cbOpciones.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOpciones.FormattingEnabled = True
        Me.cbOpciones.Items.AddRange(New Object() {"--Seleccionar--", "Ingreso", "Salida"})
        Me.cbOpciones.Location = New System.Drawing.Point(17, 64)
        Me.cbOpciones.Name = "cbOpciones"
        Me.cbOpciones.Size = New System.Drawing.Size(159, 28)
        Me.cbOpciones.TabIndex = 5
        '
        'marcacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 331)
        Me.Controls.Add(Me.cbOpciones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtOutEntrada)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "marcacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcación"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegistro As Button
    Friend WithEvents TxtOutEntrada As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbOpciones As ComboBox
End Class
