dim result As Boolean = False
dim query As String ="SELECT COUNT(*) FROM user WHERE username =:user AND Password  =:pass"
dim count As Integer =convert.toint32(cmd.executeScalar())

' This class is for login and sign in methods
Imports Oracle.ManagedDataAccess.Client
Imports System.Windows.Forms

Public Class Auth
    Private connectionString As String = "YOUR_CONNECTION_STRING_HERE" ' Set your connection string

    Public Function CheckLogin(user As String, pass As String) As Boolean
        Dim result As Boolean = False

        Using conn As New OracleConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM user WHERE username = :user AND Password = :pass"
                Using cmd As New OracleCommand(query, conn)
                    cmd.Parameters.Add(":user", user)
                    cmd.Parameters.Add(":pass", pass)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        result = True
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Connection failed: " & ex.Message)
            End Try
        End Using

        Return result
    End Function
End Class
