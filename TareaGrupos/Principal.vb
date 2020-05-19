Public Class Principal
    Private Sub btn_alta_empleado_Click(sender As Object, e As EventArgs) Handles btn_alta_empleado.Click
        Alta_empleado.Show()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Modificar.Show()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Eliminar.Show()
    End Sub

    Private Sub btn_listado_Click(sender As Object, e As EventArgs) Handles btn_listado.Click
        Listado.Show()
    End Sub
End Class