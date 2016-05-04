Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class MemInputForm
    Dim connection As New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbprovider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        Dim dbsource = "Data Source=|DataDirectory|\ProjectDB1.accdb"
        Dim sql = "INSERT INTO CUSTOMER (lname, fname, phone, billAddress2," & _
            "email, billAddress1, city, state, zip, memID, balance, minitial)" & _
            "Values (?,?,?,?,?,?,?,?,?,?,?,?)"
        Try
            Using con = New OleDb.OleDbConnection(dbprovider & dbsource)
                Using cmd = New OleDb.OleDbCommand(sql, con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@lname", lnameTextBox.Text)
                    cmd.Parameters.AddWithValue("@fname", fnameTextBox.Text)
                    cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text)
                    cmd.Parameters.AddWithValue("@billaddress2", billAddress2TextBox.Text)
                    cmd.Parameters.AddWithValue("@email", emailTextBox.Text)
                    cmd.Parameters.AddWithValue("@billaddress1", billAddress1TextBox.Text)
                    cmd.Parameters.AddWithValue("@city", cityTextBox.Text)
                    cmd.Parameters.AddWithValue("@state", stateTextBox.Text)
                    cmd.Parameters.AddWithValue("@zip", zipTextBox.Text)
                    cmd.Parameters.AddWithValue("@memID", memIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@balance", balanceTextbox.Text)
                    cmd.Parameters.AddWithValue("@minitial", minitialTextBox.Text)

                    cmd.ExecuteNonQuery()

                End Using
            End Using




        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
            'Finally
            connection.Close()


        End Try

    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Hide()
        MemInfoForm.Show()
    End Sub

    
End Class