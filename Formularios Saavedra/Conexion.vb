Imports System.Data.SqlServerCe

Module Conexion

    Public conexion As New SqlCeConnection(My.Settings.CadenaConexion)

    Private Sub conectar()

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
        Catch e As SqlCeException
            MessageBox.Show(e.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub desconectar()

        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If

    End Sub

    Public Sub consultarNQ(ByVal sql As String, ByRef command As SqlCeCommand)

        Try
            conectar()
            command.CommandText = sql
            command.Connection = conexion
            command.ExecuteNonQuery()
            desconectar()
        Catch ex As SqlCeException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Function consultarES(ByVal sql As String, ByRef command As SqlCeCommand) As Object
        Dim resultado As Object = New Object

        Try
            conectar()
            command.CommandText = sql
            command.Connection = conexion
            resultado = command.ExecuteScalar()
            desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return resultado
    End Function

    Function consultarReader(ByVal sql As String)

        Dim reader As SqlCeDataReader
        Dim dt As New DataTable

        Try
            conectar()
            formMain.command.CommandText = sql
            formMain.command.Connection = conexion
            reader = formMain.command.ExecuteReader()
            dt.Load(reader)
            desconectar()
        Catch ex As SqlCeException
            reader = Nothing
        End Try

        Return dt

    End Function

    Sub cargarTablaEnDataSet(ByVal tabla As String)

        formMain.command.Connection = conexion

        ' Crea tabla en dataset si no existe
        If Not formMain.dataset.Tables.Contains(tabla) Then
            formMain.dataset.Tables.Add(tabla)
        End If

        'Limpiamos la tabla
        formMain.dataset.Tables(tabla).Clear()

        formMain.command.CommandText = "Select * FROM " & tabla

        'Refrescamos el contenido
        formMain.tableadapter.Fill(formMain.dataset.Tables.Item(tabla))

    End Sub

End Module

