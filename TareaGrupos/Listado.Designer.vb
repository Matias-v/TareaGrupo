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
        Me.gvPersonas = New System.Windows.Forms.DataGridView()
        Me.cbo_tipoListado = New System.Windows.Forms.ComboBox()
        Me.btn_traer_datos_con_grid = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvPersonas
        '
        Me.gvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvPersonas.Location = New System.Drawing.Point(12, 74)
        Me.gvPersonas.Name = "gvPersonas"
        Me.gvPersonas.Size = New System.Drawing.Size(734, 187)
        Me.gvPersonas.TabIndex = 30
        '
        'cbo_tipoListado
        '
        Me.cbo_tipoListado.FormattingEnabled = True
        Me.cbo_tipoListado.Items.AddRange(New Object() {"Nombre y apellido", "Direccion y telefono", "Sueldo y tipo", "Todo"})
        Me.cbo_tipoListado.Location = New System.Drawing.Point(202, 25)
        Me.cbo_tipoListado.Name = "cbo_tipoListado"
        Me.cbo_tipoListado.Size = New System.Drawing.Size(127, 21)
        Me.cbo_tipoListado.TabIndex = 32
        Me.cbo_tipoListado.Text = "Tipo"
        '
        'btn_traer_datos_con_grid
        '
        Me.btn_traer_datos_con_grid.Location = New System.Drawing.Point(12, 25)
        Me.btn_traer_datos_con_grid.Name = "btn_traer_datos_con_grid"
        Me.btn_traer_datos_con_grid.Size = New System.Drawing.Size(163, 26)
        Me.btn_traer_datos_con_grid.TabIndex = 31
        Me.btn_traer_datos_con_grid.Text = "Traer datos "
        Me.btn_traer_datos_con_grid.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(642, 279)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(104, 26)
        Me.btn_salir.TabIndex = 33
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 317)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.cbo_tipoListado)
        Me.Controls.Add(Me.btn_traer_datos_con_grid)
        Me.Controls.Add(Me.gvPersonas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Listado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Listado"
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gvPersonas As DataGridView
    Friend WithEvents cbo_tipoListado As ComboBox
    Friend WithEvents btn_traer_datos_con_grid As Button
    Friend WithEvents btn_salir As Button
End Class
