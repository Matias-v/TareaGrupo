Public Class Administrativo
    Inherits Empleado

    Public Sub New()

    End Sub

    Public Sub New(cedula As Integer,
                    primer_nombre As String,
                    segundo_nombre As String,
                    primer_apellido As String,
                    segundo_apellido As String,
                    tipo As String,
                    sueldo As Double)

        Me.Cedula = cedula
        _primer_nombre = primer_nombre
        _segundo_nombre = segundo_nombre
        _primer_apellido = primer_apellido
        _segundo_apellido = segundo_apellido
        _tipo = tipo
        _sueldoMens = sueldo

    End Sub

    Public Function CalcularSueldo(sueldo As Double)

        sueldo = sueldo + (sueldo * 0.27)
        Return sueldo
    End Function
End Class
