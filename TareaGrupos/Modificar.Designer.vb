<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar
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
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.gvPersonas = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_cedula = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txt_sueldomens = New System.Windows.Forms.TextBox()
        Me.lbl_sueldomens = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.txt_segundo_apellido = New System.Windows.Forms.TextBox()
        Me.txt_primer_apellido = New System.Windows.Forms.TextBox()
        Me.txt_segundo_nombre = New System.Windows.Forms.TextBox()
        Me.txt_primer_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_segundo_apellido = New System.Windows.Forms.Label()
        Me.lbl_primer_apellido = New System.Windows.Forms.Label()
        Me.lbl_segundo_nombre = New System.Windows.Forms.Label()
        Me.lbl_primer_nombre = New System.Windows.Forms.Label()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.lbl_especialidad = New System.Windows.Forms.Label()
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(564, 378)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(104, 26)
        Me.btn_salir.TabIndex = 31
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(31, 361)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(84, 30)
        Me.btn_modificar.TabIndex = 30
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'gvPersonas
        '
        Me.gvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvPersonas.Location = New System.Drawing.Point(12, 114)
        Me.gvPersonas.Name = "gvPersonas"
        Me.gvPersonas.Size = New System.Drawing.Size(565, 126)
        Me.gvPersonas.TabIndex = 29
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(284, 50)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(84, 30)
        Me.btn_buscar.TabIndex = 28
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Location = New System.Drawing.Point(28, 44)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(40, 13)
        Me.lbl_cedula.TabIndex = 27
        Me.lbl_cedula.Text = "Cedula"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(22, 60)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(132, 20)
        Me.txt_cedula.TabIndex = 26
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(322, 314)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(143, 20)
        Me.txt_telefono.TabIndex = 47
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(319, 298)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telefono.TabIndex = 46
        Me.lbl_telefono.Text = "Telefono"
        '
        'txt_sueldomens
        '
        Me.txt_sueldomens.Location = New System.Drawing.Point(471, 273)
        Me.txt_sueldomens.Name = "txt_sueldomens"
        Me.txt_sueldomens.Size = New System.Drawing.Size(143, 20)
        Me.txt_sueldomens.TabIndex = 45
        '
        'lbl_sueldomens
        '
        Me.lbl_sueldomens.AutoSize = True
        Me.lbl_sueldomens.Location = New System.Drawing.Point(468, 257)
        Me.lbl_sueldomens.Name = "lbl_sueldomens"
        Me.lbl_sueldomens.Size = New System.Drawing.Size(82, 13)
        Me.lbl_sueldomens.TabIndex = 44
        Me.lbl_sueldomens.Text = "Sueldo mensual"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(322, 273)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(143, 20)
        Me.txt_direccion.TabIndex = 43
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(319, 257)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(52, 13)
        Me.lbl_direccion.TabIndex = 42
        Me.lbl_direccion.Text = "Direccion"
        '
        'txt_segundo_apellido
        '
        Me.txt_segundo_apellido.Location = New System.Drawing.Point(172, 314)
        Me.txt_segundo_apellido.Name = "txt_segundo_apellido"
        Me.txt_segundo_apellido.Size = New System.Drawing.Size(144, 20)
        Me.txt_segundo_apellido.TabIndex = 41
        '
        'txt_primer_apellido
        '
        Me.txt_primer_apellido.Location = New System.Drawing.Point(23, 314)
        Me.txt_primer_apellido.Name = "txt_primer_apellido"
        Me.txt_primer_apellido.Size = New System.Drawing.Size(143, 20)
        Me.txt_primer_apellido.TabIndex = 38
        '
        'txt_segundo_nombre
        '
        Me.txt_segundo_nombre.Location = New System.Drawing.Point(172, 273)
        Me.txt_segundo_nombre.Name = "txt_segundo_nombre"
        Me.txt_segundo_nombre.Size = New System.Drawing.Size(144, 20)
        Me.txt_segundo_nombre.TabIndex = 37
        '
        'txt_primer_nombre
        '
        Me.txt_primer_nombre.Location = New System.Drawing.Point(22, 273)
        Me.txt_primer_nombre.Name = "txt_primer_nombre"
        Me.txt_primer_nombre.Size = New System.Drawing.Size(144, 20)
        Me.txt_primer_nombre.TabIndex = 36
        '
        'lbl_segundo_apellido
        '
        Me.lbl_segundo_apellido.AutoSize = True
        Me.lbl_segundo_apellido.Location = New System.Drawing.Point(169, 298)
        Me.lbl_segundo_apellido.Name = "lbl_segundo_apellido"
        Me.lbl_segundo_apellido.Size = New System.Drawing.Size(89, 13)
        Me.lbl_segundo_apellido.TabIndex = 35
        Me.lbl_segundo_apellido.Text = "Segundo apellido"
        '
        'lbl_primer_apellido
        '
        Me.lbl_primer_apellido.AutoSize = True
        Me.lbl_primer_apellido.Location = New System.Drawing.Point(19, 298)
        Me.lbl_primer_apellido.Name = "lbl_primer_apellido"
        Me.lbl_primer_apellido.Size = New System.Drawing.Size(75, 13)
        Me.lbl_primer_apellido.TabIndex = 34
        Me.lbl_primer_apellido.Text = "Primer apellido"
        '
        'lbl_segundo_nombre
        '
        Me.lbl_segundo_nombre.AutoSize = True
        Me.lbl_segundo_nombre.Location = New System.Drawing.Point(169, 257)
        Me.lbl_segundo_nombre.Name = "lbl_segundo_nombre"
        Me.lbl_segundo_nombre.Size = New System.Drawing.Size(88, 13)
        Me.lbl_segundo_nombre.TabIndex = 33
        Me.lbl_segundo_nombre.Text = "Segundo nombre"
        '
        'lbl_primer_nombre
        '
        Me.lbl_primer_nombre.AutoSize = True
        Me.lbl_primer_nombre.Location = New System.Drawing.Point(20, 257)
        Me.lbl_primer_nombre.Name = "lbl_primer_nombre"
        Me.lbl_primer_nombre.Size = New System.Drawing.Size(74, 13)
        Me.lbl_primer_nombre.TabIndex = 32
        Me.lbl_primer_nombre.Text = "Primer nombre"
        '
        'cbo_tipo
        '
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Items.AddRange(New Object() {"Operario", "Administrativo", "Gerente"})
        Me.cbo_tipo.Location = New System.Drawing.Point(472, 313)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(105, 21)
        Me.cbo_tipo.TabIndex = 49
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Location = New System.Drawing.Point(469, 297)
        Me.lbl_especialidad.Name = "lbl_especialidad"
        Me.lbl_especialidad.Size = New System.Drawing.Size(28, 13)
        Me.lbl_especialidad.TabIndex = 48
        Me.lbl_especialidad.Text = "Tipo"
        '
        'Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 416)
        Me.Controls.Add(Me.cbo_tipo)
        Me.Controls.Add(Me.lbl_especialidad)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.txt_sueldomens)
        Me.Controls.Add(Me.lbl_sueldomens)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.lbl_direccion)
        Me.Controls.Add(Me.txt_segundo_apellido)
        Me.Controls.Add(Me.txt_primer_apellido)
        Me.Controls.Add(Me.txt_segundo_nombre)
        Me.Controls.Add(Me.txt_primer_nombre)
        Me.Controls.Add(Me.lbl_segundo_apellido)
        Me.Controls.Add(Me.lbl_primer_apellido)
        Me.Controls.Add(Me.lbl_segundo_nombre)
        Me.Controls.Add(Me.lbl_primer_nombre)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.gvPersonas)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_cedula)
        Me.Controls.Add(Me.txt_cedula)
        Me.Name = "Modificar"
        Me.Text = "Modificar"
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents gvPersonas As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_cedula As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents txt_sueldomens As TextBox
    Friend WithEvents lbl_sueldomens As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents txt_segundo_apellido As TextBox
    Friend WithEvents txt_primer_apellido As TextBox
    Friend WithEvents txt_segundo_nombre As TextBox
    Friend WithEvents txt_primer_nombre As TextBox
    Friend WithEvents lbl_segundo_apellido As Label
    Friend WithEvents lbl_primer_apellido As Label
    Friend WithEvents lbl_segundo_nombre As Label
    Friend WithEvents lbl_primer_nombre As Label
    Friend WithEvents cbo_tipo As ComboBox
    Friend WithEvents lbl_especialidad As Label
End Class
