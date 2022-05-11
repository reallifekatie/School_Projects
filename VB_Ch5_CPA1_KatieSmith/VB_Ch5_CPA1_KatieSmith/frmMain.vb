' Program:  Planetary Weight
' Author:   Katie Smith
' Date:     2-13-22
' Purpose:  This application calculates a user's weight in pounds and kilograms on Venus or on Mars.

Option Strict On

Public Class frmMain
    ' Constants declared to establish conversion rates to be used later
    Const _cdecVenusConversionRate As Decimal = 0.907D
    Const _cdecMarsConversionRate As Decimal = 0.377D
    Const _cdecPoundsToKilosRate As Decimal = 0.454D

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This section defines what happens when the application loads
        txtInputWeight.Text = ""
        lblOutputResults.Text = ""
        radVenusWeight.Checked = True
        radMarsWeight.Checked = False
        txtInputWeight.Focus()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' This event handler details what happens when user clicks the Display button
        ' Variables declared
        Dim decInputWeight As Decimal
        Dim decWeightInPounds As Decimal
        Dim decWeightInKilos As Decimal
        Dim strInputWeight As String
        Dim strVenusName As String = "Venus"
        Dim strMarsName As String = "Mars"

        ' if statement to ensure the user enters a positive number in the Enter Weight field
        If IsNumeric(txtInputWeight.Text) Then
            If radVenusWeight.Checked Then
                strInputWeight = txtInputWeight.Text
                decInputWeight = Convert.ToDecimal(strInputWeight)
                decWeightInPounds = decInputWeight * _cdecVenusConversionRate
                decWeightInKilos = decWeightInPounds * _cdecPoundsToKilosRate
                lblOutputResults.Text = "Your weight on " & strVenusName & " is " & decWeightInPounds.ToString("N") & " lbs " & decWeightInKilos.ToString("N") & " kg."

            ElseIf radMarsWeight.Checked Then
                strInputWeight = txtInputWeight.Text
                decInputWeight = Convert.ToDecimal(strInputWeight)
                decWeightInPounds = decInputWeight * _cdecMarsConversionRate
                decWeightInKilos = decWeightInPounds * _cdecPoundsToKilosRate
                lblOutputResults.Text = "Your weight on " & strMarsName & " is " & decWeightInPounds.ToString("N") & " lbs " & decWeightInKilos.ToString("N") & " kg."

            End If
        Else
            ' if user enters a non-numeric number or negative number, message box displays
            MsgBox("Please try again with a number greater than zero.", , "Input Error")
            txtInputWeight.Text = ""
            txtInputWeight.Focus()

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' this event handler establishes what happens when the user clicks the Clear button
        txtInputWeight.Clear()
        lblOutputResults.Text = ""
        txtInputWeight.Focus()
        radVenusWeight.Checked = True
        radMarsWeight.Checked = False
    End Sub
End Class
