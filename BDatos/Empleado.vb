Public Class Empleado : Inherits Persona

    Property _tipo As String
    Property _sueldoMens As Double
    Property _telefono As Integer
    Property _direccion As String
    Public Sub New()

    End Sub

    Public Sub New(cedula As Integer,
                    primer_nombre As String,
                    segundo_nombre As String,
                    primer_apellido As String,
                    segundo_apellido As String,
                    tipo As String,
                    sueldoMens As Double,
                    telefono As Integer,
                    direccion As String)

        Me.Cedula = cedula
        _primer_nombre = primer_nombre
        _segundo_nombre = segundo_nombre
        _primer_apellido = primer_apellido
        _segundo_apellido = segundo_apellido
        _tipo = tipo
        _sueldoMens = sueldoMens
        _telefono = telefono
        _direccion = direccion

    End Sub

    Public Sub CalcularSueldo()

    End Sub

End Class
