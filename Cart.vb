Imports System.Data.OleDb

Public Class Cart
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\opiyo\Music\HRS.accdb;"

    Public Sub AddItemToCart(itemName As String)
        Dim itemDetails = GetItemDetailsFromDatabase(itemName)
        Dim itemNameFromDB As String = itemDetails.itemName
        Dim price As Decimal = itemDetails.price

        If price > 0 Then
            Dim confirmMessage As String = $"Add {itemNameFromDB} to cart for ${price}?"

            If MessageBox.Show(confirmMessage, "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                ' Add item to cart
                CartListBox.Items.Add(itemNameFromDB)

                ' Calculate and display total
                UpdateTotal()
            End If
        Else
            MessageBox.Show("Price not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function GetItemDetailsFromDatabase(itemName As String) As (itemName As String, price As Decimal)
        Dim query As String = "SELECT itemName, Price FROM Items WHERE itemName LIKE @itemName"
        Dim itemNames() As String = {"itemName", "SoupsandSalads", "MainCourses", "Desserts", "Non-alcoholicDrinks", "AlcoholicDrinks"}
        Dim price As Decimal = 0
        Dim itemNameFromDB As String = ""


        Try
            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@itemName", itemName)
                    connection.Open()
                    Dim reader As OleDbDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        itemNameFromDB = reader("itemName").ToString()
                        price = Convert.ToDecimal(reader("Price"))
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return (itemNameFromDB, price)
    End Function

    Private Sub UpdateTotal()
        ' Implement your logic to update the total here
    End Sub

End Class
