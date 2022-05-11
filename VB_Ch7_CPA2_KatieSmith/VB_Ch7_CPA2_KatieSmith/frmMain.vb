' Program:  Karaoke Music Night
' Author:   Katie Smith
' Date:     3-27-22
' Purpose:  This application computes either the customized evening cost of an open microphone costing $2.99 per song or
'               renting a private karaoke room for $8.99 an hour.

Option Strict On

Public Class frmMain
    ' declared and initialized constant variables to be used throughout the program
    Dim _decPerSongRate As Decimal = 2.99D
    Dim _decPerHourRate As Decimal = 8.99D
    Dim _strRequestNumberOfSongs As String = "Per Song Rental of Karaoke Room:"
    Dim _strRequestNumberOfHours As String = "Hourly Rental of Karaoke Room:"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' this event handler defines what happens when the program initially loads
        ' also defined here is the timeframe for the Splash Screen to appear before program loads
        Threading.Thread.Sleep(3000)
        txtUserInput.Text = ""
        lblRequestToUser.Visible = False
        lblOutputText.Visible = False
        txtUserInput.Visible = False
        btnTotalCost.Visible = False
        btnClearForm.Visible = False
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        ' this event handler defines what happens when the user clicks the Clear button
        txtUserInput.Text = ""
        lblRequestToUser.Visible = False
        lblOutputText.Visible = False
        txtUserInput.Visible = False
        btnTotalCost.Visible = False
        btnClearForm.Visible = False
    End Sub

    Private Function PerSongSelection() As Decimal
        ' this function pulls in the constant for the rate customer pays per song if they
        '   choose that option for karaoke
        Dim decPerSongRate As Decimal
        decPerSongRate = _decPerSongRate
        Return decPerSongRate
    End Function

    Private Function PerHourSelection() As Decimal
        ' this function pulls in the constant for the rate customer pays per hour if they
        '   choose that option for karaoke
        Dim decPerHourRate As Decimal
        decPerHourRate = _decPerHourRate
        Return decPerHourRate
    End Function

    Private Sub cboKaraokeSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKaraokeSelection.SelectedIndexChanged
        ' this event handler is for the combo box that contains the pricing options for 
        '   the customer to choose from
        ' declaration of variable, then assign it to the selection made by customer in the
        '   combo box
        Dim intSelectionType As Integer
        intSelectionType = cboKaraokeSelection.SelectedIndex
        ' Select-Case statement that designs the combo box and assigns to each option the
        '   associated constant string
        Select Case intSelectionType
            Case 0
                lblRequestToUser.Text = _strRequestNumberOfHours
            Case 1
                lblRequestToUser.Text = _strRequestNumberOfSongs
        End Select
        ' display the rest of the form based on the user's selection from combo box
        lblRequestToUser.Visible = True
        txtUserInput.Visible = True
        btnClearForm.Visible = True
        btnTotalCost.Visible = True
    End Sub

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        ' event handler for when the user clicks the Total Cost button
        ' new variables declared for use in this event
        Dim decUserInput As Decimal
        Dim blnUserInputIsValid As Boolean
        Dim intUserSelectedRentalType As Integer
        Dim decRentalRate As Decimal
        Dim decTotalCost As Decimal
        Dim strOutputCost As String
        ' boolean call to function to confirm the user's input is valid
        blnUserInputIsValid = ValidateUserInput()
        ' if-statement for value returned from function above
        ' if the user's input is valid, then the user's input is assigned to a decimal variable
        If blnUserInputIsValid = True Then
            decUserInput = Convert.ToDecimal(txtUserInput.Text)
            intUserSelectedRentalType = cboKaraokeSelection.SelectedIndex
            ' Select-Case structure that assigns the returned value from 2 separate functions to
            '   a decimal variable
            Select Case intUserSelectedRentalType
                Case 0
                    decRentalRate = PerHourRental()
                Case 1
                    decRentalRate = PerSongRental()
            End Select
        End If
        ' based on user's input, input validation, and the user's selection from the dropdown list,
        '   the output statement is written with appropriate karaoke pricing
        decTotalCost = decRentalRate * decUserInput
        strOutputCost = Convert.ToString(decTotalCost)
        lblOutputText.Text = "Total Cost of Karaoke Night - $" & strOutputCost
        lblOutputText.Visible = True
    End Sub

    Private Function PerHourRental() As Decimal
        ' function to assign constant for the karaoke hourly rental rate to variable and return to
        '   the Select-Case structure that called it
        Dim decHourlyRate As Decimal
        decHourlyRate = _decPerHourRate
        Return decHourlyRate
    End Function

    Private Function PerSongRental() As Decimal
        ' function to assign constant for the karaoke per song rental rate to variable and return to
        '   the Select-Case structure that called it
        Dim decSongRate As Decimal
        decSongRate = _decPerSongRate
        Return decSongRate
    End Function

    Private Function ValidateUserInput() As Boolean
        ' boolean function to validate the user's input as a positive integer
        ' if user's input is not valid, a popup box is displayed requesting the correct input
        Dim intUserInput As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strUserInputMessage As String = "Please enter a positive number."
        Dim strMessageBoxTitle As String = "Error"
        ' Try-Catch structure to review the user's input for validity
        ' Catch statements included for exception handling
        Try
            intUserInput = Convert.ToInt32(txtUserInput.Text)
            If intUserInput > 0 Then
                blnValidityCheck = True
            Else
                MsgBox(strUserInputMessage, , strMessageBoxTitle)
                txtUserInput.Clear()
                txtUserInput.Focus()
                lblOutputText.Visible = False
            End If
        Catch Exception As FormatException
            MsgBox(strUserInputMessage, , strMessageBoxTitle)
            txtUserInput.Clear()
            txtUserInput.Focus()
        Catch Exception As OverflowException
            MsgBox(strUserInputMessage, , strMessageBoxTitle)
            txtUserInput.Clear()
            txtUserInput.Focus()
        Catch Exception As SystemException
            MsgBox(strUserInputMessage, , strMessageBoxTitle)
            txtUserInput.Clear()
            txtUserInput.Focus()
        End Try
        Return blnValidityCheck
    End Function
End Class
