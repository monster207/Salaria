Public Class Form1


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Login.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MessageBox.Show("Êtes-vous sure de vouloir quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


End Class