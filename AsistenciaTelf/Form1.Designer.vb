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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Ingreso = New System.Windows.Forms.TabPage()
        Me.TxtOutEntrada = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Salida = New System.Windows.Forms.TabPage()
        Me.TxtInpSalida = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Ingreso.SuspendLayout()
        Me.Salida.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 72)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Por favor ponga su" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dedo en el huellero" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y esperar la confirmacion."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Ingreso)
        Me.TabControl1.Controls.Add(Me.Salida)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 306)
        Me.TabControl1.TabIndex = 2
        '
        'Ingreso
        '
        Me.Ingreso.Controls.Add(Me.TxtOutEntrada)
        Me.Ingreso.Controls.Add(Me.Label2)
        Me.Ingreso.Controls.Add(Me.PictureBox1)
        Me.Ingreso.Controls.Add(Me.Label1)
        Me.Ingreso.Location = New System.Drawing.Point(4, 25)
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.Padding = New System.Windows.Forms.Padding(3)
        Me.Ingreso.Size = New System.Drawing.Size(640, 277)
        Me.Ingreso.TabIndex = 0
        Me.Ingreso.Text = "INGRESO"
        Me.Ingreso.UseVisualStyleBackColor = True
        '
        'TxtOutEntrada
        '
        Me.TxtOutEntrada.AutoSize = True
        Me.TxtOutEntrada.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOutEntrada.Location = New System.Drawing.Point(69, 204)
        Me.TxtOutEntrada.Name = "TxtOutEntrada"
        Me.TxtOutEntrada.Size = New System.Drawing.Size(109, 26)
        Me.TxtOutEntrada.TabIndex = 7
        Me.TxtOutEntrada.Text = "Bienvenid@"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "INGRESO"
        '
        'Salida
        '
        Me.Salida.Controls.Add(Me.TxtInpSalida)
        Me.Salida.Controls.Add(Me.Label3)
        Me.Salida.Controls.Add(Me.Label4)
        Me.Salida.Controls.Add(Me.PictureBox2)
        Me.Salida.Location = New System.Drawing.Point(4, 25)
        Me.Salida.Name = "Salida"
        Me.Salida.Padding = New System.Windows.Forms.Padding(3)
        Me.Salida.Size = New System.Drawing.Size(640, 277)
        Me.Salida.TabIndex = 1
        Me.Salida.Text = "SALIDA"
        Me.Salida.UseVisualStyleBackColor = True
        '
        'TxtInpSalida
        '
        Me.TxtInpSalida.AutoSize = True
        Me.TxtInpSalida.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInpSalida.Location = New System.Drawing.Point(63, 199)
        Me.TxtInpSalida.Name = "TxtInpSalida"
        Me.TxtInpSalida.Size = New System.Drawing.Size(127, 26)
        Me.TxtInpSalida.TabIndex = 6
        Me.TxtInpSalida.Text = "Hasta Pronto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(277, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SALIDA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 72)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Por favor ponga su" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dedo en el huellero" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y esperar la confirmacion."
        '
        'btnRegistro
        '
        Me.btnRegistro.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.Location = New System.Drawing.Point(683, 38)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(90, 28)
        Me.btnRegistro.TabIndex = 3
        Me.btnRegistro.Text = "Registar"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AsistenciaTelf.My.Resources.Resources.Huella
        Me.PictureBox1.Location = New System.Drawing.Point(160, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AsistenciaTelf.My.Resources.Resources.Huella
        Me.PictureBox2.Location = New System.Drawing.Point(155, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(683, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'marcacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 331)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "marcacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcación"
        Me.TabControl1.ResumeLayout(False)
        Me.Ingreso.ResumeLayout(False)
        Me.Ingreso.PerformLayout()
        Me.Salida.ResumeLayout(False)
        Me.Salida.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Ingreso As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Salida As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegistro As Button
    Friend WithEvents TxtOutEntrada As Label
    Friend WithEvents TxtInpSalida As Label
    Friend WithEvents Button1 As Button
End Class
