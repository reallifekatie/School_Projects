' the frmCityRentals class is opened by frmApartmentRental and displays both lists of information

Public Class frmCityRentals
    Private Sub CityRentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' this event is a second form that displays the cities and their average rent
        'Dim strItem As String
        Dim intItem As Integer

        ' sorts the array
        Array.Sort(frmApartmentRental._strTopTenCities)
        Array.Sort(frmApartmentRental._intCityAverage)

        ' used 2 for-loops used to populate the listbox with city names and city rental averages from the arrays
        For intItem = 1 To frmApartmentRental._strTopTenCities.Length - 1
            lstCityNames.Items.Add(frmApartmentRental._strTopTenCities(intItem))
        Next
        For intItem = 1 To frmApartmentRental._intCityAverage.Length - 1
            lstCityRents.Items.Add(Convert.ToString(frmApartmentRental._intCityAverage(intItem)))
        Next
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' this procedure opens the first form
        Dim frmFirst As New frmApartmentRental
        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class