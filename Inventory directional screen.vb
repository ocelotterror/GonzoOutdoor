Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class Inventory_directional_screen
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim connection As New OleDbConnection

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Me.Hide()
        Add_Update_Screen.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim choice As Integer

        choice = MessageBox.Show("Are you certain you want to discontinue this item?", " Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If choice = DialogResult.Yes Then
            Call DltTnv()
        ElseIf choice = DialogResult.No Then
            MessageBox.Show("Inventory not deleted")
        End If
    End Sub

    Private Sub DltTnv()
        Dim dltQuery As String
        Dim dltcomman As OleDbCommand = New OleDbCommand
        Dim InventoryDeleted As Integer

        dltQuery = "Delete from PRODUCTS" & "WHERE ProductID=" & IDTextBox.Text

        dltcomman.CommandText = dltQuery
        dltcomman.Connection = connection

        connection.Open()

        dltcomman.Parameters.Add(New OleDbParameter("ProdID", IDTextBox))

        InventoryDeleted = dltcomman.ExecuteNonQuery

        If InventoryDeleted = 1 Then
            MessageBox.Show("Inventory Deleted Successful")
        ElseIf InventoryDeleted > 1 Then
            MessageBox.Show(" Multiple Inventory records deleted!", "Check Selection", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        ElseIf InventoryDeleted < 0 Then
            MessageBox.Show(" Inventory Not Deleted", "Error!")
        End If


        connection.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Me.Hide()
        Add_Update_Screen.Show()

    End Sub

    Private Sub IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles IDTextBox.TextChanged

    End Sub

    Private Sub Inventory_directional_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class