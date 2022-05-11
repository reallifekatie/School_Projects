' Program:  Fitness Challenge
' Author:   Katie Smith
' Date:     3-7-2022
' Purpose:  The Fitness Challenge program enters the weight loss from team members for a fitness challenge.
'               It displays each weight loss value.  After all weight loss values have been entered, it
'               displays the average weight loss for the team.

Option Strict On

Public Class frmFitness
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' this even handler defines what happens when the user clicks Exit from the menu options
        Close()
    End Sub

    Private Sub frmFitness_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ' this event handler defines what happens when the program loads
        lblAverageLoss.Visible = False

    End Sub

    Private Sub btnWeightLoss_Click(sender As Object, e As EventArgs) Handles btnWeightLoss.Click
        ' this event handler defines what all happens when the user clicks the Enter Weight Loss button
        ' variables are defined to be used throughout the program
        Dim strWeightLoss As String
        Dim decWeightLoss As Decimal
        Dim decAverageLoss As Decimal
        Dim decTotalWeightLoss As Decimal = 0D

        ' these are the string variables
        Dim strInputMessage As String = "Enter the weight loss for team member #"
        Dim strInputHeading As String = "Weight Loss"
        Dim strNormalMessage As String = "Enter the weight loss for team member #"
        Dim strNonNumericError As String = "Error - Enter a number for the weight loss of team member #"
        Dim strNegativeError As String = "Error - Enter a positive number for the weight loss of team member #"

        ' additional variables used in the loops
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 8
        Dim intNumberOfEntries As Integer = 1

        strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strWeightLoss = strCancelClicked
            ' confirms the user's entry is numeric
            ' if it isn't numeric, a message is displayed
            If IsNumeric(strWeightLoss) Then
                decWeightLoss = Convert.ToDecimal(strWeightLoss)
                If decWeightLoss > 0 Then
                    lstWeightLoss.Items.Add(decWeightLoss)
                    decTotalWeightLoss += decWeightLoss
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        ' as long as the user entered more than 1 weight loss, this code calculates the average and displays it
        If intNumberOfEntries > 1 Then
            lblAverageLoss.Visible = True
            decAverageLoss = decTotalWeightLoss / (intNumberOfEntries - 1)
            lblAverageLoss.Text = "Average weight loss is " & decAverageLoss.ToString("F1") & " lbs"
        Else
            MsgBox("No weight loss value entered")
        End If

        btnWeightLoss.Enabled = False

    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' this event handler defines what happens when the user clicks the Clear button from menu
        lstWeightLoss.Items.Clear()
        lblAverageLoss.Visible = False
        btnWeightLoss.Enabled = True
    End Sub

    Private Sub frmFitness_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
