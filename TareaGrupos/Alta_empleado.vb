Imports Logica
Imports System.Data.Odbc
Imports System.Data.Common
Public Class Alta_empleado
    Dim empleado As Logica.alta_empleado = New Logica.alta_empleado()
    Private Sub btn_alta_Click(sender As Object, e As EventArgs) Handles btn_alta.Click
        If empleado.esCorrectaCedula(txt_cedula.Text) _
            And txt_primer_nombre.Text <> "" _
            And txt_primer_apellido.Text <> "" _
            And txt_sueldomens.Text <> "" _
            And txt_direccion.Text <> "" _
            And cbo_tipo.SelectedValue <> 0 Then
            If empleado.agregarRegistro(Integer.Parse(txt_cedula.Text), txt_primer_nombre.Text, txt_segundo_nombre.Text, txt_primer_apellido.Text, txt_segundo_apellido.Text, cbo_tipo.Text, txt_sueldomens.Text, txt_telefono.Text, txt_direccion.Text) = True Then
                MsgBox("Registro agregado correctamente !")

                limpiarFormulario()
            End If
        End If
    End Sub

    Public Sub limpiarFormulario()

        txt_cedula.Clear()
        txt_primer_nombre.Clear()
        txt_segundo_nombre.Clear()
        txt_primer_apellido.Clear()
        txt_segundo_apellido.Clear()
        txt_direccion.Clear()
        txt_telefono.Clear()
        txt_sueldomens.Clear()

    End Sub

    Private Sub btn_salir_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_traer_datos_con_grid_Click(sender As Object, e As EventArgs) Handles btn_traer_datos_con_grid.Click
        Dim conOdbc As New OdbcConnection("dsn=ConexionTareaGrupo;uid=root;pwd=;")
        Dim tipo As String = cbo_tipoListado.Text
        Dim consulta As String

        If tipo = "Todos" Then
            consulta = "SELECT * FROM empleado "
        Else
            consulta = "SELECT * FROM empleado "
            consulta = consulta & "WHERE TIPO =" & "'" & tipo & "'"
        End If

        Dim conexion As BDatos.Conexion = New BDatos.Conexion
        Try
            gvPersonas.DataSource = conexion.EjecutarConsulta(consulta)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cbo_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo.SelectedIndexChanged

    End Sub

    Private Sub cbo_tipoListado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipoListado.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_sueldoTotal.Click

    End Sub
End Class
