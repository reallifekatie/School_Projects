' the frmDisplayInventory class is opened by frmDepreciation and displays the inventory file in sorted order
Public Class frmDisplayInventory
    Private Sub frmDisplayInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' the event handler that loads the 2nd forms window that displays the sorted inventory items
        Dim strItem As String

        ' sorts the _strInventoryItem array
        Array.Sort(frmDepreciation._strInventoryItem)

        ' display the _strInventoryItem array
        For Each strItem In frmDepreciation._strInventoryItem
            lstDisplay.Items.Add(strItem)
        Next
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' event handler for when the user clicks the button to return to the main application window
        Dim frmFirst As New frmDepreciation
        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class