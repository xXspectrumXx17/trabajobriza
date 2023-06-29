Imports MySql.Data.MySqlClient
Public Class Transacciones
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim connection As New MySqlConnection("datasource=127.0.0.1;username=root;password=")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM transaccion", connection)

        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub Transacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class