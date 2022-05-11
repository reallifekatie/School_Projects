' Program:  Apartment Rental by City
' Author:   Katie Smith
' Date:     4-14-22
' Purpose:  This application uses a text file of median rental costs for a two-bedroom apartment in 10 major
'               cities to find the average rental cost.  The user can select a city to display the median
'               rental cost for that city.

Option Strict On

Public Class frmApartmentRental
    ' declaration and initialization of variables to be used throughout program
    Public Shared _intSizeOfArray As Integer = 10
    Public Shared _strTopTenCities(_intSizeOfArray) As String
    Public Shared _intCityAverage(_intSizeOfArray) As Integer
    Dim _strSelectedCityMedianCost As String = "The selected city rental's median cost of "
    Dim _strAvgCityRentalCost As String = "Average Rental City Cost: "

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' this event handler defines what happens when user clicks the Exit button from menu options
        Application.Exit()
    End Sub

    Private Sub fromApartmentRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' event handler for when program initially loads
        ' variables declared to read from the text file
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "d:\rentals.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not available.  Try again when the file is available."

        ' verify the file exists
        ' display an error message if file does not exist in the location specified
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            ' read the file line by line and assign the values to array
            Do While objReader.Peek <> -1
                _strTopTenCities(intCount) = objReader.ReadLine()
                _intCityAverage(intCount) = Convert.ToInt32(objReader.ReadLine)
                lstCityList.Items.Add(_strTopTenCities(intCount))
                intCount += 1
            Loop
            objReader.Close()
        Else
            MsgBox(strFileError, , "Error")
        End If
    End Sub

    Private Sub DisplayTopTenCitiesRentalCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayTopTenCitiesRentalCostToolStripMenuItem.Click
        ' event handler that creates an instance of the frmCityRentals form window
        Dim frmSecond As New frmCityRentals

        ' hid this form and show the frmCityRentals form
        Hide()
        frmSecond.ShowDialog()
    End Sub

    Private Sub lstCityList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCityList.SelectedIndexChanged
        ' event handler for when user makes their selection from the listbox
        ' delcaration of variables
        Dim intSelectedCity As Integer
        Dim intSelectedIndex As Integer

        ' creating an instance variable for the user's selection from listbox
        intSelectedIndex = lstCityList.SelectedIndex
        intSelectedCity = _intCityAverage(intSelectedIndex)

        ' if-statement to display the average city rent for the user's selected city from listbox
        If intSelectedIndex >= 0 Then
            lblSelectedCityRental.Text = _strSelectedCityMedianCost & _intCityAverage(intSelectedIndex).ToString("C")
            lblSelectedCityRental.Visible = True
            btnComputeAvgRental.Visible = True
        Else
            MsgBox("An error has occurred.", , "Error")
        End If
    End Sub

    Private Sub btnComputeAvgRental_Click(sender As Object, e As EventArgs) Handles btnComputeAvgRental.Click
        ' event handler for when user clicks the Compute Average Rental button on main form
        ' calls function to calculate average rental cost
        ComputeAverageRentalCost()
    End Sub

    Private Sub ComputeAverageRentalCost()
        ' this function computes the average rental cost and displays it
        ' variables declared and initialized
        Dim intTotalRentalCost As Integer
        Dim decAvgRentalCost As Decimal
        Dim intIndex As Integer
        Dim intNumberOfCities As Integer = 10

        ' for-loop to calculate the total rental cost of all cities
        For intIndex = 0 To (_intCityAverage.Length - 1)
            intTotalRentalCost += _intCityAverage(intIndex)
        Next
        ' average rent is calculated from total rent variable and displayed appropriately
        decAvgRentalCost = Convert.ToDecimal(intTotalRentalCost / intNumberOfCities)
        lblAvgRentalCityCost.Text = _strAvgCityRentalCost & decAvgRentalCost.ToString("C")
        lblAvgRentalCityCost.Visible = True
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' event handler for when user clicks the Clear button from menu strip
        lblAvgRentalCityCost.Visible = False
        lblSelectedCityRental.Visible = False
        btnComputeAvgRental.Visible = False
    End Sub
End Class
