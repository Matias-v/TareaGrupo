Imports System.Data.Common
Imports System.Data.Odbc

Public Class Eliminar
    Dim conexion As BDatos.Conexion = New BDatos.Conexion
    Dim buscar As Logica.buscar = New Logica.buscar
    Dim eliminar As Logica.eliminar = New Logica.eliminar
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        txt_cedula.Enabled = False
        Try
            Dim cedula As Integer = txt_cedula.Text
            Dim consulta As String = "select * from empleado where cedula =" & cedula
            gvPersonas.DataSource = conexion.EjecutarConsulta(consulta)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        txt_cedula.Enabled = True
        txt_cedula.Clear()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        gvPersonas.DataSource = conexion.EjecutarConsulta("select * from empleado where cedula = null")
        Try
            If txt_cedula.Text = "" Then
                MsgBox("Ingrese una cedula valida!")
            Else
                Dim conODBC As OdbcConnection
                conODBC = New OdbcConnection("dsn=ConexionTareaGrupo;uid=root;pwd=;")
                Dim cedula As Integer = txt_cedula.Text
                Dim consulta As String = "delete from empleados where cedula= " & cedula
                Dim da As OdbcDataAdapter

                Try
                    da = New OdbcDataAdapter(consulta, conODBC)
                    conODBC.Open()
                    conODBC.Close()
                Catch ex As Exception
                    Throw New Exception("ERROR en EjecutarConsulta() : " + ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

End Class