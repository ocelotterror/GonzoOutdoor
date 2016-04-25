
Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms




Public Class MemInfoForm

    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim connection As New OleDbConnection
    Dim mcurrRow As Integer = 0


    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSQL As String = ""

        strSQL = "SELECT * FROM CUSTOMER"
        connection.ConnectionString = My.Settings.ProjectDB1ConnectionString1

        connection.Open()

        da = New OleDbDataAdapter(strSQL, connection)
        da.Fill(ds, "CUSTOMER")

        ScreenFill(mcurrRow)

        connection.Close()
    End Sub

    Private Sub ScreenFill(ByRef pcurrRow As Integer)


        custID.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(0)
        fnameTextbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(2)
        lnameTextbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(1)
        billaddress2Textbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(4)
        emailTextbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(5)
        billaddress1Textbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(6)
        phoneTextbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(3)
        cityTextbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(7)
        stateTextbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(8)
        zipTextbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(9)
        memIDTextbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(10)
        balanceTextbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(11)
        minitialTextbox.Text = ds.Tables("CUSTOMER").Rows(pcurrRow).Item(12)






    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Try
            Dim cb As New OleDbCommandBuilder(da)
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(2) = fnameTextbox.Text
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(1) = lnameTextbox.Text
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(3) = phoneTextbox.Text
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(4) = billaddress2Textbox.Text
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(5) = emailTextbox.Text
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(6) = billaddress1Textbox.Text
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(7) = cityTextbox.Text
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(8) = stateTextbox.Text
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(9) = zipTextbox.Text
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(10) = memIDTextbox.Text
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(11) = balanceTextbox.Text
            ds.Tables("CUSTOMER").Rows(mcurrRow).Item(12) = minitialTextbox.Text
            da.Update(ds, "CUSTOMER")

            MsgBox("Data Updated")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click

        'Test to see if moving beyond the end of the data set
        'Little strange because mcurrRow is an index subscript (base 0) and Count is a counting of all the records
        '(base 1).  This is why texting mcurrRow + 2 instead of mcurrRow + 1
        If (mcurrRow + 2) > ds.Tables("CUSTOMER").Rows.Count Then
            'Don't fool with the index and notify user
            MsgBox("No more records")
        Else
            'Advance the index
            mcurrRow += 1
        End If

        'Push current record position to screen
        ScreenFill(mcurrRow)

    End Sub



    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        'Test to see if moving beyond upper bound of the table dataset

        If mcurrRow <= 0 Then
            MsgBox("You're at the first record")
        Else
            'Decrement the index
            mcurrRow -= 1
        End If

        'Push current record position To screen
        ScreenFill(mcurrRow)
    End Sub


    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        'Stokes' testing of delete. Oh boy...
        Dim choice As Integer

        'displays messagebox for safety.
        choice = MessageBox.Show("Are you certain you want to perminantly delete this ENTIRE record?", "Delete?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        'Calls dltRow if user is certain, else stops
        If choice = DialogResult.Yes Then
            Call dltRow()
        ElseIf choice = DialogResult.No Then
            MessageBox.Show("Nothing deleted")
        End If


    End Sub

    'This is called in the deleteButton click action. Very carefully.
    Private Sub dltRow()
        Dim dltQuery As String 'to contain delete 
        Dim dltCommand As OleDbCommand = New OleDbCommand
        Dim recordsDeleted As Integer

        'contains the delete statement
        dltQuery = "DELETE FROM CUSTOMER " & "WHERE custID= " & custID.Text

        'sets delete command's necessary information: Query txt, and connection.
        dltCommand.CommandText = dltQuery
        dltCommand.Connection = connection

        connection.Open()

        'Deletes Active Record
        'Try

        dltCommand.Parameters.Add(New OleDbParameter("custID", custID))

        recordsDeleted = dltCommand.ExecuteNonQuery()



        If recordsDeleted = 1 Then
            MessageBox.Show("Record delete successful")
        ElseIf recordsDeleted > 1 Then
            MessageBox.Show("Multiple Records deleted!", "Too many", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf recordsDeleted <= 0 Then
            MessageBox.Show("Record not deleted", "Error!")
        End If

        ScreenFill(mcurrRow)


        'Catch ex As Exception


        'End Try


        connection.Close()

    End Sub


    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MemInputForm.Show()

        ' Dim objConnection As OleDbConnection

    End Sub

    Private Sub chargeButton_Click(sender As Object, e As EventArgs) Handles chargeButton.Click
        Dim chargeAmt As Double
        Dim choice As Integer

        'displays messagebox for input.
        chargeAmt = Double.Parse(InputBox("Input charge amount.", "Name Your Price", "0"))

        choice = MessageBox.Show("Is a charge of " & chargeAmt.ToString & " correct?", "Correct?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If choice = DialogResult.Yes Then
            Call chargeCust(chargeAmt)
        End If

    End Sub

    Public Sub chargeCust(ByVal chargeAmt As Double)
        Dim chargeCmd As OleDbCommand = New OleDbCommand
        Dim chargeQuery As String
        Dim rowCount As Integer
        Dim newBalance As Double

        newBalance = Double.Parse(balanceTextbox.Text) + chargeAmt

        'Superfluous code commented out.
        chargeQuery = "UPDATE CUSTOMER " & "SET balance= " & newBalance.ToString & " WHERE custID= " & custID.Text
        chargeCmd.Connection = connection
        chargeCmd.CommandText = chargeQuery

        chargeCmd.Parameters.Add(New OleDbParameter("custID", custID))
        chargeCmd.Parameters.Add(New OleDbParameter("balance", newBalance))

        Try
            connection.Open()

            rowCount = chargeCmd.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception

        End Try

        If rowCount = 1 Then
            MessageBox.Show("Charge Successful", "Accepted")
        Else
            MessageBox.Show("Charge Unsuccessful", "Declined")
        End If

        ds.Tables("CUSTOMER").Rows(mcurrRow).Item(11) = newBalance

        ScreenFill(mcurrRow)

    End Sub

   
End Class