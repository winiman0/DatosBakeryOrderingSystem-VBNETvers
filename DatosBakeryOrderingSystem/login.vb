Imports System.Data.OleDb

Public Class login
    Dim connect As New OleDbConnection
    Dim command As OleDbCommand
    Dim sql As String = Nothing
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\uni\mac24 - ogos 24\csc301\VB Project\DatosBakeryOrderingSystem\DatosBakeryOrderingSystem\datosBakery.accdb;"
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtUsername.Text = "admin" And txtPassword.Text = "admin1234." Then
            orderLogAdmin.Show()
            Me.Hide()
        Else
            sql = "SELECT * FROM tblCustomer WHERE custUsername = ? and custPassword = ?"

            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
            command.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPassword.Text

            Dim check = Convert.ToInt32(command.ExecuteScalar())

            If check > 0 Then
                'THEN SUCCESSFUL LOGIN
                MessageBox.Show("Successfully Login!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ProductList.Show()
                Me.Hide()
            Else
                'THEN , WRONG PASSWORD/USERNAME
                MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


    End Sub
End Class
