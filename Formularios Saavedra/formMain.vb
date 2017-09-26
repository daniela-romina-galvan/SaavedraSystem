Imports System.Data.SqlServerCe

Public Class formMain

    Public dataset As New DataSet
    Public command As New SqlCeCommand()
    Public tableadapter As New SqlCeDataAdapter
    Public query As String
    Public userLogueado As String


#Region "Botones"

    Private Sub picInicio_Click(sender As Object, e As EventArgs) Handles picInicio.Click
        AdminPantallas("Inicio")
    End Sub
    Private Sub picFormularios_Click(sender As Object, e As EventArgs) Handles picFormularios.Click

    End Sub
    Private Sub picClientes_Click(sender As Object, e As EventArgs) Handles picClientes.Click

    End Sub
    Private Sub picListaPrecios_Click(sender As Object, e As EventArgs) Handles picListaPrecios.Click

    End Sub
    Private Sub picFormaPago_Click(sender As Object, e As EventArgs) Handles picFormaPago.Click

    End Sub
    Private Sub picVentas_Click(sender As Object, e As EventArgs) Handles picVentas.Click

    End Sub
    Private Sub picDevoluciones_Click(sender As Object, e As EventArgs) Handles picDevoluciones.Click

    End Sub
    Private Sub picStock_Click(sender As Object, e As EventArgs) Handles picStock.Click

    End Sub
    Private Sub picSalir_Click(sender As Object, e As EventArgs) Handles picSalir.Click
        desloguear()
        userVerificado(False)
    End Sub

#End Region

#Region "Eventos"

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminPantallas("Login")
    End Sub

#End Region

#Region "Helpers"

    Public Sub AdminPantallas(ByVal pantalla As String)
        Dim bandera As Boolean = False

        ' Si la pantalla no se encuentra cargada, la hace visible
        For Each ctrl As Control In splitMain.Panel2.Controls
            If pantalla = ctrl.Name Then
                ctrl.Show()
                bandera = True
            Else
                ctrl.Hide()
                bandera = False
            End If
        Next

        If bandera = False Then
            Select Case pantalla
                Case "Inicio"
                    Dim pantallaClientes As Inicio = New Inicio()
                    pantallaClientes.Dock = DockStyle.Fill
                    splitMain.Panel2.Controls.Add(pantallaClientes)
                Case "Login"
                    Dim pantallaLogin As Login = New Login()
                    pantallaLogin.Dock = DockStyle.Fill
                    splitMain.Panel2.Controls.Add(pantallaLogin)
                Case Else
                    MessageBox.Show("Error del administrador de pantallas")
            End Select

        End If

    End Sub
    Private Sub desloguear()

        splitMain.Panel2.Controls.Clear()
        AdminPantallas("Login")

    End Sub
    Public Sub userVerificado(ByVal verify As Boolean)

        If verify = True Then
            picInicio.Enabled = True
            picFormularios.Enabled = True
            picClientes.Enabled = True
            picListaPrecios.Enabled = True
            picFormaPago.Enabled = True
            picVentas.Enabled = True
            picDevoluciones.Enabled = True
            picStock.Enabled = True
            picSalir.Enabled = True
        Else
            picInicio.Enabled = False
            picFormularios.Enabled = False
            picClientes.Enabled = False
            picListaPrecios.Enabled = False
            picFormaPago.Enabled = False
            picVentas.Enabled = False
            picDevoluciones.Enabled = False
            picStock.Enabled = False
            picSalir.Enabled = False
        End If

    End Sub

#End Region

End Class
