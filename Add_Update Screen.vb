Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Data.SqlClient




Public Class Add_Update_Screen

    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim connection As New OleDbConnection
    Private Sub Add_Update_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim dbprovider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        Dim dbsource = "Data Source=|DataDirectory|\ProjectDBU1.accdb"
        Dim sql = " INSERT INTO PRODUCTS (ProductID, Product_Name, Product_Price, Product_Quantity, Product_Description, SupplierID) Values (?,?,?,?,?,?)"
        Try
            Using con = New OleDb.OleDbConnection(dbprovider & dbsource)
                Using cmd As New OleDb.OleDbCommand(sql, con)
                    'Using cmd = New OleDb.OleDbCommand(sql, con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@ProductID", ProductIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@Product_Name", ProdNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@Product_Price", ProductPriceTextBox.Text)
                    cmd.Parameters.AddWithValue("@Product_Quantity", ProdQTextBox.Text)
                    cmd.Parameters.AddWithValue("@Product_Description", ProdDescTextBox.Text)
                    cmd.Parameters.AddWithValue("@SupplierID", SupplierTextBox.Text)

                    cmd.ExecuteNonQuery()
                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(" Error while inserting inventory information")
            connection.Close()
        End Try

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        Inventory_directional_screen.Show()

    End Sub
End Class