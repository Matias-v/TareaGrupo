<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado
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
        Me.btn_prueba_conexion = New System.Windows.Forms.Button()
        Me.btn_traer_datos_con_grid = New System.Windows.Forms.Button()
        Me.gvPersonas = New System.Windows.Forms.DataGridView()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_prueba_conexion
        '
        Me.btn_prueba_conexion.Location = New System.Drawing.Point(37, 39)
        Me.btn_prueba_conexion.Name = "btn_prueba_conexion"
        Me.btn_prueba_conexion.Size = New System.Drawing.Size(169, 36)
        Me.btn_prueba_conexion.TabIndex = 0
        Me.btn_prueba_conexion.Text = "Prueba conexion"
        Me.btn_prueba_conexion.UseVisualStyleBackColor = True
        '
        'btn_traer_datos_con_grid
        '
        Me.btn_traer_datos_con_grid.Location = New System.Drawing.Point(223, 39)
        Me.btn_traer_datos_con_grid.Name = "btn_traer_datos_con_grid"
        Me.btn_traer_datos_con_grid.Size = New System.Drawing.Size(173, 36)
        Me.btn_traer_datos_con_grid.TabIndex = 2
        Me.btn_traer_datos_con_grid.Text = "Traer datos "
        Me.btn_traer_datos_con_grid.UseVisualStyleBackColor = True
        '
        'gvPersonas
        '
        Me.gvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvPersonas.Location = New System.Drawing.Point(12, 131)
        Me.gvPersonas.Name = "gvPersonas"
        Me.gvPersonas.Size = New System.Drawing.Size(683, 210)
        Me.gvPersonas.TabIndex = 4
        '
        'cbo_tipo
        '
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Items.AddRange(New Object() {"Administrativo", "Operario", "Gerente", "Todos"})
        Me.cbo_tipo.Location = New System.Drawing.Point(432, 48)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(177, 21)
        Me.cbo_tipo.TabIndex = 5
        Me.cbo_tipo.Text = "Tipo"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(606, 88)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(111, 23)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(472, 88)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(111, 23)
        Me.btn_volver.TabIndex = 7
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'Listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 447)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.cbo_tipo)
        Me.Controls.Add(Me.gvPersonas)
        Me.Controls.Add(Me.btn_traer_datos_con_grid)
        Me.Controls.Add(Me.btn_prueba_conexion)
        Me.Name = "Listado"
        Me.Text = "Traer datos"
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_prueba_conexion As Button
    Friend WithEvents btn_traer_datos_con_grid As Button
    Friend WithEvents gvPersonas As DataGridView
    Friend WithEvents cbo_tipo As ComboBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_volver As Button
End Class
