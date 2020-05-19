Imports System.Data.Odbc
Imports System.Data.Common

Public Class modificar
    Public Function Modificar(ci As String, pnom As String, snom As String, pape As String, sape As String, dir As String, sueldo As Integer, tipo As String) As Boolean
        Dim conODBC As OdbcConnection
        conODBC = New OdbcConnection("dsn=ConexionTareaGrupo;uid=root;pwd=;")
        Dim consulta As String
        Dim command As OdbcCommand
        consulta = "UPDATE empleado SET "
        consulta &= "primer_nombre = '" & pnom & "',"
        consulta &= "segundo_nombre = '" & snom & "',"
        consulta &= "primer_apellido = '" & pape & "',"
        consulta &= "segundo_apellido = '" & sape & "',"
        consulta &= "direccion = '" & dir & "',"
        consulta &= "sueldoMens = " & sueldo.ToString & ","
        consulta &= "tipo = '" & tipo & "' "
        consulta &= "where cedula= " & ci.ToString
        Try
            command = New OdbcCommand(consulta, conODBC)
            conODBC.Open()
            command.ExecuteNonQuery()
            conODBC.Close()
            Return True
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Function
End Class
