Imports System.Data.OleDb

Public Class SuppliesForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim strConnection As String = "provider=Microsoft.ACE.OLEDB.12.0;" &
"Data Source=C:\Users\Danmw\Documents\HRS.accdb;"
        Dim myConnection As New OleDbConnection(strConnection)
        Dim strSQL As String = "Select * from Supplies "
        Dim myCommand As New OleDbCommand(strSQL, myConnection)
        Dim myReader As OleDbDataReader

        Dim myDataAdapter As New OleDbDataAdapter(myCommand)
        Dim myDataSet As New DataSet()
        Dim myDataTable As New DataTable()

        myConnection.Open()
        myReader = myCommand.ExecuteReader
        myReader.Read()

        ' Open the connection

        ' Define the query to select data from the table
        Dim query As String = "SELECT * FROM Supplies "

        ' Create a data adapter to execute the query and fill the data set
        Using adapter As New OleDbDataAdapter(query, myConnection)
            ' Create a new data set
            Dim table As New DataTable()

            ' Fill the data set with the results of the query
            adapter.Fill(table)

            ' Set the data source for the DataGridView to the data set
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

End Class