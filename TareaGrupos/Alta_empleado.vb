﻿Imports Logica
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

    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Hide()
        Listado.Show()
    End Sub

    Private Sub lbl_especialidad_Click(sender As Object, e As EventArgs) Handles lbl_especialidad.Click

    End Sub

    Private Sub btn_salir_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class