<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_empleado
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
        Me.lbl_primer_nombre = New System.Windows.Forms.Label()
        Me.lbl_segundo_nombre = New System.Windows.Forms.Label()
        Me.lbl_primer_apellido = New System.Windows.Forms.Label()
        Me.lbl_segundo_apellido = New System.Windows.Forms.Label()
        Me.txt_primer_nombre = New System.Windows.Forms.TextBox()
        Me.txt_segundo_nombre = New System.Windows.Forms.TextBox()
        Me.txt_primer_apellido = New System.Windows.Forms.TextBox()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.lbl_cedula = New System.Windows.Forms.Label()
        Me.txt_segundo_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_especialidad = New System.Windows.Forms.Label()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.btn_alta = New System.Windows.Forms.Button()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.txt_sueldomens = New System.Windows.Forms.TextBox()
        Me.lbl_sueldomens = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.gvPersonas = New System.Windows.Forms.DataGridView()
        Me.btn_traer_datos_con_grid = New System.Windows.Forms.Button()
        Me.cbo_tipoListado = New System.Windows.Forms.ComboBox()
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_primer_nombre
        '
        Me.lbl_primer_nombre.AutoSize = True
        Me.lbl_primer_nombre.Location = New System.Drawing.Point(10, 30)
        Me.lbl_primer_nombre.Name = "lbl_primer_nombre"
        Me.lbl_primer_nombre.Size = New System.Drawing.Size(74, 13)
        Me.lbl_primer_nombre.TabIndex = 0
        Me.lbl_primer_nombre.Text = "Primer nombre"
        '
        'lbl_segundo_nombre
        '
        Me.lbl_segundo_nombre.AutoSize = True
        Me.lbl_segundo_nombre.Location = New System.Drawing.Point(180, 30)
        Me.lbl_segundo_nombre.Name = "lbl_segundo_nombre"
        Me.lbl_segundo_nombre.Size = New System.Drawing.Size(88, 13)
        Me.lbl_segundo_nombre.TabIndex = 1
        Me.lbl_segundo_nombre.Text = "Segundo nombre"
        '
        'lbl_primer_apellido
        '
        Me.lbl_primer_apellido.AutoSize = True
        Me.lbl_primer_apellido.Location = New System.Drawing.Point(9, 79)
        Me.lbl_primer_apellido.Name = "lbl_primer_apellido"
        Me.lbl_primer_apellido.Size = New System.Drawing.Size(75, 13)
        Me.lbl_primer_apellido.TabIndex = 2
        Me.lbl_primer_apellido.Text = "Primer apellido"
        '
        'lbl_segundo_apellido
        '
        Me.lbl_segundo_apellido.AutoSize = True
        Me.lbl_segundo_apellido.Location = New System.Drawing.Point(180, 79)
        Me.lbl_segundo_apellido.Name = "lbl_segundo_apellido"
        Me.lbl_segundo_apellido.Size = New System.Drawing.Size(89, 13)
        Me.lbl_segundo_apellido.TabIndex = 3
        Me.lbl_segundo_apellido.Text = "Segundo apellido"
        '
        'txt_primer_nombre
        '
        Me.txt_primer_nombre.Location = New System.Drawing.Point(12, 46)
        Me.txt_primer_nombre.Name = "txt_primer_nombre"
        Me.txt_primer_nombre.Size = New System.Drawing.Size(144, 20)
        Me.txt_primer_nombre.TabIndex = 4
        '
        'txt_segundo_nombre
        '
        Me.txt_segundo_nombre.Location = New System.Drawing.Point(183, 46)
        Me.txt_segundo_nombre.Name = "txt_segundo_nombre"
        Me.txt_segundo_nombre.Size = New System.Drawing.Size(144, 20)
        Me.txt_segundo_nombre.TabIndex = 5
        '
        'txt_primer_apellido
        '
        Me.txt_primer_apellido.Location = New System.Drawing.Point(13, 95)
        Me.txt_primer_apellido.Name = "txt_primer_apellido"
        Me.txt_primer_apellido.Size = New System.Drawing.Size(143, 20)
        Me.txt_primer_apellido.TabIndex = 6
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(13, 142)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(143, 20)
        Me.txt_cedula.TabIndex = 9
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Location = New System.Drawing.Point(10, 126)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(40, 13)
        Me.lbl_cedula.TabIndex = 8
        Me.lbl_cedula.Text = "Cedula"
        '
        'txt_segundo_apellido
        '
        Me.txt_segundo_apellido.Location = New System.Drawing.Point(183, 95)
        Me.txt_segundo_apellido.Name = "txt_segundo_apellido"
        Me.txt_segundo_apellido.Size = New System.Drawing.Size(144, 20)
        Me.txt_segundo_apellido.TabIndex = 10
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Location = New System.Drawing.Point(330, 30)
        Me.lbl_especialidad.Name = "lbl_especialidad"
        Me.lbl_especialidad.Size = New System.Drawing.Size(28, 13)
        Me.lbl_especialidad.TabIndex = 11
        Me.lbl_especialidad.Text = "Tipo"
        '
        'cbo_tipo
        '
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Items.AddRange(New Object() {"Operario", "Administrativo", "Gerente"})
        Me.cbo_tipo.Location = New System.Drawing.Point(333, 46)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(105, 21)
        Me.cbo_tipo.TabIndex = 12
        '
        'btn_alta
        '
        Me.btn_alta.Location = New System.Drawing.Point(13, 230)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(138, 26)
        Me.btn_alta.TabIndex = 13
        Me.btn_alta.Text = "Dar de alta"
        Me.btn_alta.UseVisualStyleBackColor = True
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(13, 186)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(143, 20)
        Me.txt_direccion.TabIndex = 16
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(10, 170)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(52, 13)
        Me.lbl_direccion.TabIndex = 15
        Me.lbl_direccion.Text = "Direccion"
        '
        'txt_sueldomens
        '
        Me.txt_sueldomens.Location = New System.Drawing.Point(183, 142)
        Me.txt_sueldomens.Name = "txt_sueldomens"
        Me.txt_sueldomens.Size = New System.Drawing.Size(143, 20)
        Me.txt_sueldomens.TabIndex = 18
        '
        'lbl_sueldomens
        '
        Me.lbl_sueldomens.AutoSize = True
        Me.lbl_sueldomens.Location = New System.Drawing.Point(180, 126)
        Me.lbl_sueldomens.Name = "lbl_sueldomens"
        Me.lbl_sueldomens.Size = New System.Drawing.Size(82, 13)
        Me.lbl_sueldomens.TabIndex = 17
        Me.lbl_sueldomens.Text = "Sueldo mensual"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(183, 186)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(143, 20)
        Me.txt_telefono.TabIndex = 20
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(180, 170)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telefono.TabIndex = 19
        Me.lbl_telefono.Text = "Telefono"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(417, 394)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(104, 26)
        Me.btn_salir.TabIndex = 21
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'gvPersonas
        '
        Me.gvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvPersonas.Location = New System.Drawing.Point(13, 262)
        Me.gvPersonas.Name = "gvPersonas"
        Me.gvPersonas.Size = New System.Drawing.Size(508, 126)
        Me.gvPersonas.TabIndex = 22
        '
        'btn_traer_datos_con_grid
        '
        Me.btn_traer_datos_con_grid.Location = New System.Drawing.Point(172, 230)
        Me.btn_traer_datos_con_grid.Name = "btn_traer_datos_con_grid"
        Me.btn_traer_datos_con_grid.Size = New System.Drawing.Size(163, 26)
        Me.btn_traer_datos_con_grid.TabIndex = 23
        Me.btn_traer_datos_con_grid.Text = "Traer datos "
        Me.btn_traer_datos_con_grid.UseVisualStyleBackColor = True
        '
        'cbo_tipoListado
        '
        Me.cbo_tipoListado.FormattingEnabled = True
        Me.cbo_tipoListado.Items.AddRange(New Object() {"Administrativo", "Operario", "Gerente", "Todos"})
        Me.cbo_tipoListado.Location = New System.Drawing.Point(344, 230)
        Me.cbo_tipoListado.Name = "cbo_tipoListado"
        Me.cbo_tipoListado.Size = New System.Drawing.Size(127, 21)
        Me.cbo_tipoListado.TabIndex = 24
        Me.cbo_tipoListado.Text = "Tipo"
        '
        'Alta_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 425)
        Me.Controls.Add(Me.cbo_tipoListado)
        Me.Controls.Add(Me.btn_traer_datos_con_grid)
        Me.Controls.Add(Me.gvPersonas)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.txt_sueldomens)
        Me.Controls.Add(Me.lbl_sueldomens)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.lbl_direccion)
        Me.Controls.Add(Me.btn_alta)
        Me.Controls.Add(Me.cbo_tipo)
        Me.Controls.Add(Me.lbl_especialidad)
        Me.Controls.Add(Me.txt_segundo_apellido)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(Me.lbl_cedula)
        Me.Controls.Add(Me.txt_primer_apellido)
        Me.Controls.Add(Me.txt_segundo_nombre)
        Me.Controls.Add(Me.txt_primer_nombre)
        Me.Controls.Add(Me.lbl_segundo_apellido)
        Me.Controls.Add(Me.lbl_primer_apellido)
        Me.Controls.Add(Me.lbl_segundo_nombre)
        Me.Controls.Add(Me.lbl_primer_nombre)
        Me.Name = "Alta_empleado"
        Me.Text = "Alta empleado"
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_primer_nombre As Label
    Friend WithEvents lbl_segundo_nombre As Label
    Friend WithEvents lbl_primer_apellido As Label
    Friend WithEvents lbl_segundo_apellido As Label
    Friend WithEvents txt_primer_nombre As TextBox
    Friend WithEvents txt_segundo_nombre As TextBox
    Friend WithEvents txt_primer_apellido As TextBox
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents lbl_cedula As Label
    Friend WithEvents txt_segundo_apellido As TextBox
    Friend WithEvents lbl_especialidad As Label
    Friend WithEvents cbo_tipo As ComboBox
    Friend WithEvents btn_alta As Button
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents txt_sueldomens As TextBox
    Friend WithEvents lbl_sueldomens As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents btn_salir As Button
    Friend WithEvents gvPersonas As DataGridView
    Friend WithEvents btn_traer_datos_con_grid As Button
    Friend WithEvents cbo_tipoListado As ComboBox
End Class
