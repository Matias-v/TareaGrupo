Public Class buscar
    Public Function buscarConsulta(cedula As Integer)
        Dim consulta As String = "SELECT * FROM EMPLEADOS WHERE ced=" & cedula & ""
        Return consulta
    End Function
End Class
