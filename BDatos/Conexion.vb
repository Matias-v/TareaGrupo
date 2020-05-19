Imports System.Data.Common
Imports System.Data.Odbc
Public Class Conexion



    Property _conODBC As OdbcConnection

    Public Sub New()
        _conODBC = New OdbcConnection("dsn=ConexionTareaGrupo;uid=root;pwd=;")
    End Sub

        Public Sub AbrirConexion()
            Try
                _conODBC.Open()
            Catch ex As Exception
                Throw New Exception("ERROR en AbrirConexion() :: " + ex.Message)
            End Try
        End Sub

        Public Sub CerrarConexion()
            Try
                _conODBC.Close()
            Catch ex As Exception
                Throw New Exception("ERROR en CerrarConexion() :: " + ex.Message)
            End Try
        End Sub

    Public Function EjecutarConsulta(consulta As String) As DataTable
        Dim dt As New DataTable
        Dim da As OdbcDataAdapter
        Dim ds As New DataSet
        _conODBC = New OdbcConnection("dsn=ConexionTareaGrupo;uid=root;pwd=;")
        Try
            da = New OdbcDataAdapter(consulta, _conODBC)
            _conODBC.Open()
            da.Fill(ds)
            _conODBC.Close()
            dt = ds.Tables(0)
        Catch ex As Exception
            Throw New Exception("ERROR en EjecutarConsulta() : " + ex.Message)
        End Try
        Return dt
    End Function
End Class