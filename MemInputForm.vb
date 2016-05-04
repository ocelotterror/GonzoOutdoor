Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class MemInputForm


    Private db As New DBControl
    Dim connection As New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbprovider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        Dim dbsource = "Data Source=|DataDirectory|\ProjectDB1.accdb"
        Dim sql = "INSERT INTO CUSTOMER (lname, fname, phone, billAddress2," &
            "email, billAddress1, city, state, zip, memID, balance, minitial)" &
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim da As New OleDbDataAdapter
        Dim connection As New OleDbConnection
        ' Dim str As String

        '  connection.ConnectionString = My.Settings.ProjectDB1ConnectionString1

        '  connection.Open()

        Dim dbprovider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        Dim dbsource = "Data Source=|DataDirectory|\ProjectDB1.accdb"
        Dim sql = "Update CUSTOMER Set lname=" & lnameTextBox.Text & ", fname=" & fnameTextBox.Text & ", phone=" & phoneTextBox.Text & ", billAddress2=" & billAddress2TextBox.Text & " , email = " & emailTextBox.Text & ", billAddress1 = " & billAddress1TextBox.Text & ", city = " & cityTextBox.Text & ", state = " & stateTextBox.Text & ", zip = " & zipTextBox.Text & ", balance = " & balanceTextbox.Text & ", minitial = " & minitialTextBox.Text & " Where memID= " & Integer.Parse(memIDTextBox.Text)
        '  "Values (?,?,?,?,?,?,?,?,?,?,?,?) where memid = " & memIDTextBox.Text
        'memID=" & memIDTextBox.Text & "
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
                    ' cmd.Parameters.AddWithValue("@minitial", minitialTextBox.Text)

                    cmd.ExecuteNonQuery()

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error While updating record On table..." & ex.Message, "updateRecords")
            'Finally
            connection.Close()


        End Try

        ' db.AddParam("@phone", phoneTextBox.Text)
        '  db.AddParam("@lname", lnameTextBox.Text)
        '  db.AddParam("@fname", fnameTextBox.Text)
        ' db.AddParam("@bad1", billAddress1TextBox.Text)
        ' db.AddParam("@bad2", billAddress2TextBox.Text)
        ' db.AddParam("@minitial", minitialTextBox.Text)
        ' db.AddParam("@bal", balanceTextbox.Text)
        ' db.AddParam("@memid", memIDTextBox.Text)


        'db.ExecQuery("UPDATE ORDERS Set phone=@phone, lname =@lname, fname =@fname, billaddress1=@bad1, billaddress2=@bad2, minitial=@minitial" &
        ' "WHERE memID=@memid")

        ' str = "update [Customer] Set [phone] = '" & phoneTextBox.Text & "', [Lname] = '" & lnameTextBox.Text & "', [fname] = '" & fnameTextBox.Text & "', [minitial] = '" & minitialTextBox.Text & "', [balance] = '" & balanceTextbox.Text & "', [billAddress1] = '" & billAddress1TextBox.Text & "', [billAddress2] = '" & billAddress2TextBox.Text & "', Where [memID] = '" & memIDTextBox.Text & "'"
        'Dim cmd As OleDbCommand = New OleDbCommand(str, connection)
        ' Try
        'cmd.ExecuteNonQuery()
        'cmd.dispose()
        connection.Close()
        ' Catch ex As Exception
        ' MsgBox(ex.Message)
        '     End Try




    End Sub
End Class