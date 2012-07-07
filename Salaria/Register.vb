Imports MySql.Data.MySqlClient
Public Class Register

    Private Sub Register_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Login.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = TextBox3.Text Then
            Dim RequeteSQL As String
            Dim objCommand As MySqlCommand
            Dim objDataReader As MySqlDataReader
            Dim MyAdapter As MySqlDataAdapter = New MySqlDataAdapter()
            Dim connectString As String = "Server=88.198.43.24;Database=salaria;UserID=trinitos;Password=equipesalaria12"
            Try
                Dim Connection As MySqlConnection = New MySqlConnection()
                Connection.ConnectionString = connectString
                Connection.Open()
                Try
                    RequeteSQL = "Select * from Compte WHERE '" + TextBox1.Text + "' ;"
                    objCommand = New MySqlCommand(RequeteSQL, Connection)
                    objDataReader = objCommand.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show("Le nom de compte existe déja.", "Inscription", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
                Try
                    RequeteSQL = "Select * from Compte WHERE '" + TextBox4.Text + "' ;"
                    objCommand = New MySqlCommand(RequeteSQL, Connection)
                    objDataReader = objCommand.ExecuteReader
                Catch ex As Exception

                    MessageBox.Show("Le pseudo existe déja.", "Inscription", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
                objDataReader.Close()
                RequeteSQL = "INSERT INTO `salaria`.`Compte` (`Username`, `Password`, `Pseudo`) VALUES ('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox4.Text + "');"
                objDataReader = objCommand.ExecuteReader
                objDataReader.Close()
                Connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            MessageBox.Show("Vos mots de passes sont incorrectes.", "Inscription", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class