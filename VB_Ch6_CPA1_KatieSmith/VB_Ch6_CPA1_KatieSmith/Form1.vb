' Program:  Most Rainfall in the USA
' Author:   Katie Smith
' Date:     3/19/22
' Purpose:  This application was written for Kauai, Hawaii, the rainiest location in the United States,
'               to comput the average monthly amount of rainfall per year.

Option Strict On

Public Class Form1
    Private Sub Form1_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ' this even handler details what happens when the application initially loads
        lblOutputAverageRainfallPerMonth.Visible = False
        btnEnterRainfall.Enabled = True
    End Sub

    Private Sub btnEnterRainfall_Click(sender As Object, e As EventArgs) Handles btnEnterRainfall.Click
        ' variables are declared, and in some cases initialized, to be used throughout the program
        Dim strRainfallInches As String
        Dim decRainfallInches As Decimal
        Dim decAverageRainfall As Decimal
        Dim decTotalRainfall As Decimal = 0D

        ' these variables are specific to the popup box
        Dim strInputMessage As String = "Enter rainfall inches for month #"
        Dim strInputHeading As String = "Rainfall"
        Dim strNormalMessage As String = "Enter rainfall inches for month #"
        Dim strNonNumericError As String = "Error - Enter a number for month #"
        Dim strNegativeError As String = "Error - Enter a positive number for month #"

        ' variables used within the InputBox
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 12
        Dim intNumberOfEntries As Integer = 1

        ' variable to be used to put together the user-facing message in the InputBox
        strRainfallInches = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        ' Do Until loop to cycle thru user's inputs to confirm they entered acceptable and correct info
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRainfallInches = strCancelClicked
            ' if statement to confirm user entered a number
            If IsNumeric(strRainfallInches) Then
                decRainfallInches = Convert.ToDecimal(strRainfallInches)
                ' if statement to confirm user entered a positive value
                If decRainfallInches > 0 Then
                    lstInputRainfallInches.Items.Add(decRainfallInches)
                    decTotalRainfall += decRainfallInches
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            ' if statement to keep popping InputBox for user as long as they haven't reached the max
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strRainfallInches = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop
        ' if statement to calculate the average rainfall
        If intNumberOfEntries > 1 Then
            lblRainfallAverage.Visible = True
            decAverageRainfall = decTotalRainfall / (intNumberOfEntries - 1)
            lblOutputAverageRainfallPerMonth.Text = "Average Rainfall per Month is " & decAverageRainfall.ToString("F1") & " inches"
        Else
            MsgBox("No rainfall value entered")
        End If
        btnEnterRainfall.Enabled = False
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' this event handler details what happens when the user clicks the Clear button from the menu
        lblOutputAverageRainfallPerMonth.Visible = False
        btnEnterRainfall.Enabled = True
        lstInputRainfallInches.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' this event handler details what happens when the user clicks the Exit button from the menu
        Close()
    End Sub
End Class
