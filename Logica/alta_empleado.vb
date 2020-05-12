Imports System.Data.Common
Imports System.Data.Odbc

Public Class alta_empleado
    Public Function agregarRegistro(cedula As Integer, primer_nombre As String, segundo_nombre As String, primer_apellido As String, segundo_apellido As String, tipo As String, sueldomens As String, direccion As String, telefono As String) As Boolean

        Dim conODBC As New OdbcConnection("dsn=ConexionTareaGrupo;uid=root;pwd=;")

        Dim guardado As Boolean = False

        Dim consulta As String = "INSERT INTO empleado ("

        consulta = consulta & "cedula, primer_nombre, segundo_nombre, "
        consulta = consulta & "primer_apellido, segundo_apellido, tipo, "
        consulta = consulta & "sueldomens, telefono, direccion "
        consulta = consulta & ") VALUES ("
        consulta = consulta & cedula.ToString & ","
        consulta = consulta & "'" & primer_nombre & "',"
        consulta = consulta & "'" & segundo_nombre & "',"
        consulta = consulta & "'" & primer_apellido & "',"
        consulta = consulta & "'" & segundo_apellido & "',"
        consulta = consulta & "'" & tipo & "',"
        consulta = consulta & "'" & sueldomens & "',"
        consulta = consulta & "'" & direccion & "',"
        consulta = consulta & "'" & telefono & "')"

        Dim command As New OdbcCommand(consulta, conODBC)

        Try
            conODBC.Open()
            command.ExecuteNonQuery()
            conODBC.Close()
            guardado = True

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        Return guardado
    End Function

End Class
