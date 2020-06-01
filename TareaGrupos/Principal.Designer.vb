<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_agregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_modificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_listado = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsb_agregar = New System.Windows.Forms.ToolStripButton()
        Me.tsb_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsb_listado = New System.Windows.Forms.ToolStripButton()
        Me.tsb_modificar = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MantenimientoToolStripMenuItem1
        '
        Me.MantenimientoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_agregar, Me.tsm_eliminar, Me.tsm_modificar, Me.tsm_listado})
        Me.MantenimientoToolStripMenuItem1.Name = "MantenimientoToolStripMenuItem1"
        Me.MantenimientoToolStripMenuItem1.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem1.Text = "Mantenimiento"
        '
        'tsm_agregar
        '
        Me.tsm_agregar.Name = "tsm_agregar"
        Me.tsm_agregar.Size = New System.Drawing.Size(180, 22)
        Me.tsm_agregar.Text = "Agregar"
        '
        'tsm_eliminar
        '
        Me.tsm_eliminar.Name = "tsm_eliminar"
        Me.tsm_eliminar.Size = New System.Drawing.Size(180, 22)
        Me.tsm_eliminar.Text = "Eliminar"
        '
        'tsm_modificar
        '
        Me.tsm_modificar.Name = "tsm_modificar"
        Me.tsm_modificar.Size = New System.Drawing.Size(180, 22)
        Me.tsm_modificar.Text = "Modificar"
        '
        'tsm_listado
        '
        Me.tsm_listado.Name = "tsm_listado"
        Me.tsm_listado.Size = New System.Drawing.Size(180, 22)
        Me.tsm_listado.Text = "Listados"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_agregar, Me.tsb_eliminar, Me.tsb_listado, Me.tsb_modificar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsb_agregar
        '
        Me.tsb_agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_agregar.Image = CType(resources.GetObject("tsb_agregar.Image"), System.Drawing.Image)
        Me.tsb_agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_agregar.Name = "tsb_agregar"
        Me.tsb_agregar.Size = New System.Drawing.Size(23, 22)
        Me.tsb_agregar.Text = "ToolStripButton1"
        '
        'tsb_eliminar
        '
        Me.tsb_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_eliminar.Image = CType(resources.GetObject("tsb_eliminar.Image"), System.Drawing.Image)
        Me.tsb_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_eliminar.Name = "tsb_eliminar"
        Me.tsb_eliminar.Size = New System.Drawing.Size(23, 22)
        Me.tsb_eliminar.Text = "ToolStripButton2"
        '
        'tsb_listado
        '
        Me.tsb_listado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_listado.Image = CType(resources.GetObject("tsb_listado.Image"), System.Drawing.Image)
        Me.tsb_listado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_listado.Name = "tsb_listado"
        Me.tsb_listado.Size = New System.Drawing.Size(23, 22)
        Me.tsb_listado.Text = "ToolStripButton3"
        '
        'tsb_modificar
        '
        Me.tsb_modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_modificar.Image = CType(resources.GetObject("tsb_modificar.Image"), System.Drawing.Image)
        Me.tsb_modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_modificar.Name = "tsb_modificar"
        Me.tsb_modificar.Size = New System.Drawing.Size(23, 22)
        Me.tsb_modificar.Text = "ToolStripButton4"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.IsMdiContainer = True
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tsm_agregar As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsb_agregar As ToolStripButton
    Friend WithEvents tsb_eliminar As ToolStripButton
    Friend WithEvents tsb_listado As ToolStripButton
    Friend WithEvents tsb_modificar As ToolStripButton
    Friend WithEvents tsm_eliminar As ToolStripMenuItem
    Friend WithEvents tsm_modificar As ToolStripMenuItem
    Friend WithEvents tsm_listado As ToolStripMenuItem
End Class
