Public Class Modificar
    Dim buscar As Logica.buscar = New Logica.buscar
    Dim conexion As BDatos.Conexion = New BDatos.Conexion
    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ocultar()
    End Sub
    Private Sub Ocultar()
        txt_primer_nombre.Visible = False
        txt_segundo_nombre.Visible = False
        txt_primer_apellido.Visible = False
        txt_segundo_apellido.Visible = False
        txt_sueldomens.Visible = False
        txt_direccion.Visible = False
        txt_telefono.Visible = False
        cbo_tipo.Visible = False

        btn_modificar.Visible = False

        lbl_primer_nombre.Visible = False
        lbl_segundo_nombre.Visible = False
        lbl_primer_apellido.Visible = False
        lbl_segundo_apellido.Visible = False
        lbl_sueldomens.Visible = False
        lbl_especialidad.Visible = False
        lbl_direccion.Visible = False
        lbl_telefono.Visible = False
    End Sub
    Private Sub Mostrar()
        txt_primer_nombre.Visible = True
        txt_segundo_nombre.Visible = True
        txt_primer_apellido.Visible = True
        txt_segundo_apellido.Visible = True
        txt_sueldomens.Visible = True
        txt_direccion.Visible = True
        txt_telefono.Visible = True
        cbo_tipo.Visible = True

        btn_modificar.Visible = True

        lbl_primer_nombre.Visible = True
        lbl_segundo_nombre.Visible = True
        lbl_primer_apellido.Visible = True
        lbl_segundo_apellido.Visible = True
        lbl_sueldomens.Visible = True
        lbl_especialidad.Visible = True
        lbl_direccion.Visible = True
        lbl_telefono.Visible = True
    End Sub

    Private Sub Limpiar()
        txt_primer_nombre.Clear()
        txt_segundo_nombre.Clear()
        txt_primer_apellido.Clear()
        txt_segundo_apellido.Clear()
        txt_sueldomens.Clear()
        txt_direccion.Clear()
        txt_telefono.Clear()
        cbo_tipo.SelectedIndex = -1
    End Sub
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Mostrar()
        Dim conexion As BDatos.Conexion = New BDatos.Conexion
        Try
            Dim cedula As Integer = txt_cedula.Text
            Dim consulta As String = "select * from empleado where cedula =" & cedula
            gvPersonas.DataSource = conexion.EjecutarConsulta(consulta)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        txt_cedula.Enabled = True
    End Sub
    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim modific As Logica.modificar = New Logica.modificar()
        modific.Modificar(Integer.Parse(txt_cedula.Text),
                   txt_primer_nombre.Text, txt_segundo_nombre.Text, txt_primer_apellido.Text, txt_segundo_apellido.Text,
                   txt_direccion.Text, Double.Parse(txt_sueldomens.Text),
                   cbo_tipo.Text)

    End Sub

    Private Sub gvPersonas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvPersonas.CellContentClick

    End Sub
    Private Sub gvPersonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvPersonas.CellClick
        Dim i As Integer
        i = gvPersonas.CurrentRow.Index

        Try
            txt_cedula.Text = gvPersonas.Item(0, i).Value()
            txt_primer_nombre.Text = gvPersonas.Item(1, i).Value()
            txt_segundo_nombre.Text = gvPersonas.Item(2, i).Value()
            txt_primer_apellido.Text = gvPersonas.Item(3, i).Value()
            txt_segundo_apellido.Text = gvPersonas.Item(4, i).Value()
            cbo_tipo.Text = gvPersonas.Item(5, i).Value()
            txt_direccion.Text = gvPersonas.Item(8, i).Value()
            txt_telefono.Text = gvPersonas.Item(7, i).Value()
            txt_sueldomens.Text = gvPersonas.Item(6, i).Value()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class