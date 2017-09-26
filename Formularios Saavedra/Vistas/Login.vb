Imports System.ComponentModel

Public Class Login

    Dim ControlesConErrores As List(Of Control) = New List(Of Control)

#Region "Botones"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Validaciones
        If tbUsuario.Text = "" Or tbContraseña.Text = "" Then

            formMain.ErrorProvider.SetError(tbContraseña, "Complete todos los Campos")
            Exit Sub
        End If

        If verificarUsuario(tbUsuario.Text, tbContraseña.Text) Then

            formMain.userVerificado(True)

            formMain.splitMain.Panel2.Controls.Clear()
            formMain.AdminPantallas("Inicio")
        Else
            formMain.ErrorProvider.SetError(tbContraseña, "Usuario y/o Contraseña Inválido/s")
            Exit Sub
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUsuario.Focus()
    End Sub

#End Region

#Region "Validaciones"

    Private Sub tbUsuario_Validating(sender As Object, e As CancelEventArgs) Handles tbUsuario.Validating
        If (sender.Text = "") Then
            formMain.ErrorProvider.SetError(sender, "Debe ingresar un Usuario")
            If Not ControlesConErrores.Contains(sender) Then
                ControlesConErrores.Add(sender)
            End If
        Else
            formMain.ErrorProvider.SetError(sender, "")
            ControlesConErrores.Remove(sender)
        End If
    End Sub
    Private Sub tbContraseña_Validating(sender As Object, e As CancelEventArgs) Handles tbContraseña.Validating
        If (sender.Text = "") Then
            formMain.ErrorProvider.SetError(sender, "Debe ingresar una Contraseña")
            If Not ControlesConErrores.Contains(sender) Then
                ControlesConErrores.Add(sender)
            End If
        Else
            formMain.ErrorProvider.SetError(sender, "")
            ControlesConErrores.Remove(sender)
        End If
    End Sub

#End Region

End Class
