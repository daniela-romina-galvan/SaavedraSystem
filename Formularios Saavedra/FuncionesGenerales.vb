Module FuncionesGenerales

#Region "Validaciones"

    Public Sub keyverify(ByVal e As System.Windows.Forms.KeyPressEventArgs,
                         Optional ByVal letras As Boolean = False,
                         Optional ByVal numeros As Boolean = False,
                         Optional ByVal comas As Boolean = False,
                         Optional ByVal puntosAComas As Boolean = False,
                         Optional ByVal espacios As Boolean = False,
                         Optional ByVal control As Boolean = True,
                         Optional ByVal otros As Boolean = False)

        If Char.IsLetter(e.KeyChar) Then        ' Permite o cancela ingreso de letras
            e.Handled = Not letras
        ElseIf Char.IsDigit(e.KeyChar) Then     ' Permite o cancela ingreso de numeros
            e.Handled = Not numeros
        ElseIf e.KeyChar = "," Then             ' Permite o cancela ingreso de comas
            e.Handled = Not comas
        ElseIf comas And e.KeyChar = "." Then   ' Si se permiten comas y el caracter es un punto
            If puntosAComas Then                ' Permite o cancela la sustitución de punto por coma
                e.KeyChar = ","
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf Char.IsSeparator(e.KeyChar) Then ' Permite o cancela ingreso de espacios
            e.Handled = Not espacios
        ElseIf Char.IsControl(e.KeyChar) Then   ' Permite o cancela ingreso caracteres de control
            e.Handled = Not control
        Else
            e.Handled = Not otros               ' Permite o cancela ingreso de otros caracteres
        End If

    End Sub

#End Region

End Module
