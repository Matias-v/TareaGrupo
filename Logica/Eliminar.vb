Imports System.Data.Odbc
Imports System.Data.Common

Public Class eliminar
    Public Function eliminarConsulta(cedula As Integer)

        Dim guardado As Boolean = False
        Try
            Dim conODBC As New OdbcConnection("dsn=ConexionTareaGrupo;uid=root;pwd=;")
            conODBC.Open()
            Dim consulta As OdbcCommand
            consulta = New OdbcCommand("delete from empleado where cedula=" & cedula.ToString, conODBC)
            consulta.ExecuteNonQuery()
            guardado = True
            conODBC.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Return guardado
    End Function
End Class
