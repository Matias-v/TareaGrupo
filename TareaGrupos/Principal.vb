Public Class Principal
    Private Sub tamanio()
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub


    Private Sub btn_alta_empleado_Click(sender As Object, e As EventArgs)
        Alta_empleado.Show()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs)
        Modificar.Show()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs)
        Eliminar.Show()
    End Sub

    Private Sub btn_listado_Click(sender As Object, e As EventArgs)
        Listado.Show()
    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsb_agregar_Click(sender As Object, e As EventArgs) Handles tsb_agregar.Click
        mostrarAgregar()
    End Sub

    Private Sub tsb_eliminar_Click(sender As Object, e As EventArgs) Handles tsb_eliminar.Click
        mostrarEliminar()
    End Sub

    Private Sub tsb_listado_Click(sender As Object, e As EventArgs) Handles tsb_listado.Click
        mostrarListado()

    End Sub

    Private Sub tsb_modificar_Click(sender As Object, e As EventArgs) Handles tsb_modificar.Click
        mostrarModificar()
    End Sub
    Private Sub mostrarAgregar()
        Dim agr As Alta_empleado = New Alta_empleado()
        agr.MdiParent = Me
        Dim posX As Integer = 50
        Dim posY As Integer = 50
        agr.Top = posX
        agr.Left = posY
        agr.Show()
    End Sub
    Private Sub mostrarEliminar()
        Dim eli As Eliminar = New Eliminar()
        eli.MdiParent = Me
        Dim posX As Integer = 50
        Dim posY As Integer = 50
        eli.Top = posX
        eli.Left = posY
        eli.Show()
    End Sub
    Private Sub mostrarListado()
        Dim lis As Listado = New Listado()
        lis.MdiParent = Me
        Dim posX As Integer = 50
        Dim posY As Integer = 50
        lis.Top = posX
        lis.Left = posY
        lis.Show()
    End Sub
    Private Sub mostrarModificar()
        Dim modi As Modificar = New Modificar()
        modi.MdiParent = Me
        Dim posX As Integer = 50
        Dim posY As Integer = 50
        modi.Top = posX
        modi.Left = posY
        modi.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsm_agregar.Click
        mostrarAgregar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles tsm_eliminar.Click
        mostrarEliminar()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsm_modificar.Click
        mostrarModificar()
    End Sub

    Private Sub ListadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsm_listado.Click
        mostrarListado()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class