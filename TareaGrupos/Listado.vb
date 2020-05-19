Imports System.Data.Odbc
Imports System.Data.Common
Public Class Listado
    Private Sub btn_traer_datos_con_grid_Click(sender As Object, e As EventArgs) Handles btn_traer_datos_con_grid.Click
        Dim conOdbc As New OdbcConnection("dsn=ConexionTareaGrupo;uid=root;pwd=;")
        Dim tipo As String = cbo_tipoListado.Text
        Dim consulta As String

        Select Case tipo
            Case "Nombre y apellido"
                consulta = "select cedula,primer_nombre,primer_apellido from empleado "
            Case "Direccion y telefono"
                consulta = "select cedula,direccion,telefono from empleado"
            Case "Sueldo y tipo"
                consulta = "select cedula,tipo,sueldoMens from empleado"
            Case "Todo"
                consulta = "select * FROM empleado "
        End Select

        Dim conexion As BDatos.Conexion = New BDatos.Conexion
        Try
            gvPersonas.DataSource = conexion.EjecutarConsulta(consulta)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub cbo_tipoListado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipoListado.SelectedIndexChanged

    End Sub
End Class