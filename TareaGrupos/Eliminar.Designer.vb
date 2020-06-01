<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar
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
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.lbl_cedula = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.gvPersonas = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(22, 64)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(132, 20)
        Me.txt_cedula.TabIndex = 0
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Location = New System.Drawing.Point(28, 48)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(40, 13)
        Me.lbl_cedula.TabIndex = 1
        Me.lbl_cedula.Text = "Cedula"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(450, 54)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(84, 30)
        Me.btn_eliminar.TabIndex = 24
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'gvPersonas
        '
        Me.gvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvPersonas.Location = New System.Drawing.Point(12, 118)
        Me.gvPersonas.Name = "gvPersonas"
        Me.gvPersonas.Size = New System.Drawing.Size(565, 126)
        Me.gvPersonas.TabIndex = 23
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(284, 54)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(84, 30)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(450, 270)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(104, 26)
        Me.btn_salir.TabIndex = 25
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 308)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.gvPersonas)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_cedula)
        Me.Controls.Add(Me.txt_cedula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Eliminar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Eliminar"
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents lbl_cedula As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents gvPersonas As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_salir As Button
End Class
