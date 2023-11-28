Module Validaciones
    'Funcion que solo permite el ingreso de caracteres tipo letra
    Public Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Funcion que solo permite el ingreso de caracteres tipo texto
    Public Sub SoloTexto(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Public Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Funcion para que permite el ingreso de numeros enteros y decimales
    Public Sub NumerosDecimales(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        Dim caracteres() As Char = {"."c}

        If (Char.IsDigit(e.KeyChar) Or caracteres.Contains(e.KeyChar)) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Funcion para que permite el ingreso de numeros enteros y letras
    Public Sub LetrasNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Module
