' Program:  Gaming Art
' Author:   Katie Smith
' Date:     4-20-22
' Purpose:  This application opens a Windows form that displays an Access database with data for local
'               artwork.  The data can be viewed, updated, and deleted.  The application also computes
'               the total value of the Game Art & Design collection.

Option Strict On

Public Class frmArt
    Private Sub frmArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ArtDataSet.Artist' table. You can move, or remove it, as needed.
        Me.ArtistTableAdapter.Fill(Me.ArtDataSet.Artist)

    End Sub

    Private Sub ArtistBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArtistBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArtistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArtDataSet)

    End Sub

    Private Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        ' strSql is a SQL statement that selects all the fields from the Artist table
        Dim strSql As String = "SELECT * FROM Artist"

        ' strPath provides the database type and path of the Art database
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=D:\Art.accdb"
        Dim odaArtist As New OleDb.OleDbDataAdapter(strSql, strPath)

        Dim datValue As New DataTable
        Dim intCount As Integer
        Dim decTotalValue As Decimal = 0D

        ' the DataTable name datValue is filled with the table data
        odaArtist.Fill(datValue)
        ' the connection to the database is disconnected
        odaArtist.Dispose()
        For intCount = 0 To datValue.Rows.Count - 1
            decTotalValue += Convert.ToDecimal(datValue.Rows(intCount)("Retail Price"))
        Next
        lblTotalRetailValue.Visible = True
        lblTotalRetailValue.Text = "The Total Retail Value is " & decTotalValue.ToString("C")
    End Sub

End Class
