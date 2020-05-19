Public Class eliminar
    Public Function eliminarConsulta(cedula As Integer)

        Try

            Dim consulta As String = "DELETE FROM empleados WHERE ced= " & cedula
            Return consulta
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Function
End Class
