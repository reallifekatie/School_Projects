' Program:  Smart Home Monthly Electric Savings
' Author:   Katie Smith
' Date:     4-11-22
' Purpose:  This application opens a text file that lists the monthly savings of a smart home's electric
'               bill in comparison to a previous year without smart device activation.

Option Strict On

Public Class frmSmartHome
    ' declaration and initialization of constant variables
    Dim _strElectricSavings As String = "The electric savings for "
    Dim _strAverageMonthlySavings As String = "The average monthly savings: "
    Dim _strMostSignificant As String = " had the most significant monthly savings"
    ' declaration of array variables
    Public Shared _intSizeOfArray As Integer = 12
    Public Shared _strMonthName(_intSizeOfArray) As String
    Public Shared _decMonthSavings(_intSizeOfArray) As Decimal

    Private Sub btnDisplayStats_Click(sender As Object, e As EventArgs) Handles btnDisplayStats.Click
        ' this event handler is for when the user clicks the Display Statistics button
        ' declaration of variables to be used in computing average monthly savings and determining which month
        '   had the most significant savings
        Dim intSelectedIndex As Integer
        Dim decTotalSavings As Decimal
        Dim decAvgSavings As Decimal
        Dim intIndex As Integer
        Dim decMax As Decimal = 0
        Dim strNoMonthSelected As String = "Please select a month from the dropdown list."

        ' for loop to cycle thru the savings for each month and accumulate their total to calculate their average
        For intIndex = 0 To (_decMonthSavings.Length - 1)
            decTotalSavings += _decMonthSavings(intIndex)
        Next
        decAvgSavings = decTotalSavings / 12

        ' if statement to display the average savings
        ' else statement displays an error message if user clicks button without choosing from combo box
        If cboSelectMonth.SelectedIndex >= 0 Then
            intSelectedIndex = cboSelectMonth.SelectedIndex
            lblAvgMonthSavings.Text = _strAverageMonthlySavings & decAvgSavings.ToString("C")
            lblAvgMonthSavings.Visible = True
        Else
            MsgBox(strNoMonthSelected, , "Error")
        End If

        ' for loop to determine which month had the most significant savings and display that value to label
        For intIndex = 0 To (_decMonthSavings.Length - 1)
            If _decMonthSavings(intIndex) > decMax Then
                decMax = _decMonthSavings(intIndex)
                lblMostSignificant.Text = _strMonthName(intIndex) & _strMostSignificant
                lblMostSignificant.Visible = True
            End If
        Next
    End Sub

    Private Sub frmSmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' event handler for when the application loads
        ' initialize an instance of the StreamReader object and declare variables
        Dim objReader As IO.StreamReader
        Dim intCount As Integer = 0
        Dim strLocationAndNameOfFile As String = "d:\savings.txt"
        Dim strFileError As String = "The file is not available.  Try again when the file is available."

        ' if statement & do-while loop to cycle thru the text file and assign each of the variables to parallel arrays
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            ' read the file line by line until the file is completed
            Do While objReader.Peek <> -1
                _strMonthName(intCount) = objReader.ReadLine()
                cboSelectMonth.Items.Add(_strMonthName(intCount))
                _decMonthSavings(intCount) = Convert.ToDecimal(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()

        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If

    End Sub

    Private Sub cboSelectMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectMonth.SelectedIndexChanged
        ' declaration of variable to help regulate user's selection from combo box
        Dim intSelectedMonthIndex As Integer

        ' if statement to cycle thru the users selection and display the savings for the month they selected
        If cboSelectMonth.SelectedIndex >= -1 Then
            intSelectedMonthIndex = cboSelectMonth.SelectedIndex

            lblElectricSavings.Text = _strElectricSavings & _strMonthName(intSelectedMonthIndex) &
                " is $" & _decMonthSavings(intSelectedMonthIndex)
            lblElectricSavings.Visible = True
        Else
            lblElectricSavings.Text = "boo"
            lblElectricSavings.Visible = True
        End If
    End Sub
End Class
