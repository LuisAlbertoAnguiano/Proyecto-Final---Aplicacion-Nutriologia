Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.SqlServer

Public Class Login
    Dim server As String = "Data Source = ASREN-PC\SQLSERVER; Initial Catalog = BD_Nutriologo; Integrated Security = True "
    Dim conectar As New SqlConnection
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

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        conectar.Close()
        Dim password As String = txtContrasenia.Text
        conectar.ConnectionString = Server
        conectar.Open()
        Dim query As String = "SELECT Contraseña FROM Usuario WHERE Nombre=@usuario"
        Dim cmd As New SqlCommand(query, conectar)
        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text)
        Dim resultado
        resultado = cmd.ExecuteScalar()
        Dim hashedpassword As String = HashPassword(password)
        Dim soniguales As Boolean = String.Equals(resultado, hashedpassword)

        If (soniguales) Then
            MessageBox.Show("Login Exitoso")
            IdentificarUsuario(dgv_Usuario, txtUsuario.Text)
            ActiveUser = dgv_Usuario.Rows(0).Cells(0).Value
            conectar.Close()
            conn.Close()
            MainMenu.Show()
            Me.Hide()
            txtContrasenia.Text = ""
            txtUsuario.Text = ""
        Else
            MessageBox.Show("Usuario o contraseña incorrecto")
        End If
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Me.Hide()
        conn.Close()
        AgregarUsuario.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
    End Sub
End Class