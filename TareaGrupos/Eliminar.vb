Imports System.Data.Common
Imports System.Data.Odbc

Public Class Eliminar
    Dim conexion As BDatos.Conexion = New BDatos.Conexion
    Dim buscar As Logica.buscar = New Logica.buscar
    Dim eliminar As Logica.eliminar = New Logica.eliminar
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        txt_cedula.Enabled = False
        Try
            Dim consulta As String = "select * from empleado "
            gvPersonas.DataSource = conexion.EjecutarConsulta(consulta)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        txt_cedula.Enabled = True
        txt_cedula.Clear()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            Dim cedula As Integer = txt_cedula.Text
            eliminar.eliminarConsulta(cedula)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

End Class