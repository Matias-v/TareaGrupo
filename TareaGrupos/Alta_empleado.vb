Imports Logica
Imports System.Data.Odbc
Imports System.Data.Common
Public Class Alta_empleado
    Dim empleado As Logica.alta_empleado = New Logica.alta_empleado()
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_segundo_nombre.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbl_primer_apellido.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lbl_cedula.Click

    End Sub

    Private Sub btn_alta_Click(sender As Object, e As EventArgs) Handles btn_alta.Click

        If empleado.agregarRegistro(Integer.Parse(txt_cedula.Text), txt_primer_nombre.Text, txt_segundo_nombre.Text, txt_primer_apellido.Text, txt_segundo_apellido.Text, cbo_tipo.Text, txt_sueldomens.Text, txt_telefono.Text, txt_direccion.Text) = True Then
            MsgBox("Registro agregado correctamente !")

            limpiarFormulario()
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
        Dim dt As DataTable
        Dim da As OdbcDataAdapter
        Dim ds As New DataSet
        Dim tipo As String = cbo_tipoListado.Text
        Dim consulta As String
        If tipo = "Todos" Then
            consulta = "SELECT * FROM empleado "
        Else
            consulta = "SELECT * FROM empleado "
            consulta = consulta & "WHERE TIPO =" & "'" & tipo & "'"
        End If
        Try
            da = New OdbcDataAdapter(consulta, conOdbc)
            conOdbc.Open()
            da.Fill(ds)
            conOdbc.Close()
            dt = ds.Tables(0)
            gvPersonas.DataSource = dt
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class
