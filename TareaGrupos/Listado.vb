Imports System.Data.Common
Imports System.Data.Odbc
Public Class Listado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_prueba_conexion.Click
        Dim conOdbc As New OdbcConnection("dsn=ConexionTareaGrupo;uid=root;pwd=;")
        Try
            conOdbc.Open()
            MsgBox("Conexion exitosa")
            conOdbc.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub


    Private Sub btn_traer_datos_con_grid_Click(sender As Object, e As EventArgs) Handles btn_traer_datos_con_grid.Click
        Dim conOdbc As New OdbcConnection("dsn=ConexionTareaGrupo;uid=root;pwd=;")
        Dim dt As DataTable
        Dim da As OdbcDataAdapter
        Dim ds As New DataSet
        Dim tipo As String = cbo_tipo.Text
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Hide()
        Alta_empleado.Show()
    End Sub
End Class