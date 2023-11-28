Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class AgregarUsuario
    Dim usuario As String
    Public Function HashPassword(ByVal password As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()

            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim password As String = txtContrasenia.Text
        Dim hashedpass = HashPassword(password)

        If txt_Id.TextLength > 0 And txtUsuario.TextLength > 0 And txtContrasenia.TextLength > 0 And txtrecontra.TextLength > 0 Then

            If txtContrasenia.Text = txtrecontra.Text Then
                conn.Close()
                conn.Open()
                Dim cmd As New SqlCommand("sp_AgregarUsuario", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", txt_Id.Text)
                cmd.Parameters.AddWithValue("@Nombre", txtUsuario.Text)
                cmd.Parameters.AddWithValue("@Contraseña", hashedpass.ToString())

                Try

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuario agregado correctamente")
                Catch ex As SqlException
                    MessageBox.Show(ex.ToString())
                End Try
                conn.Close()
                Login.Show()
                Me.Close()
            Else
                MessageBox.Show("La contraseña no es identica, por favor verifique la contraseña")
            End If

        Else
            MessageBox.Show("Por favor ingrese todos los datos requeridos")
        End If
    End Sub

    Private Sub AgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        GenerarNumID(txt_Id, "Usuario")
    End Sub

    Private Sub AgregarUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        conn.Close()
        Login.Show()
    End Sub
End Class