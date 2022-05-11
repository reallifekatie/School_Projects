' Program:  Softball Scoreboard
' Author:   Katie Smith
' Date:     3-20-22
' Purpose:  This application calculates the score of each inning during a softball game for one team.

Option Strict On

Public Class frmMain
    Private Sub frmMain_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ' event handler for when the program initially loads
        lblOutputMessage.Visible = False
        btnEnterScore.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' This event handler is for when the user clicks Exit from the menu
        Close()
    End Sub

    Private Sub btnEnterScore_Click(sender As Object, e As EventArgs) Handles btnEnterScore.Click
        ' This event handler is for when the user clicks the Enter Score button
        ' Declaration of many and initialization of string variables
        Dim strRunsScored As String
        Dim intRunsScored As Integer
        Dim intTotalRunsScored As Integer = 0I
        Dim strInputMessage As String = "Enter runs scored for inning #"
        Dim strInputHeading As String = "Runs Scored"
        Dim strNormalMessage As String = "Enter runs scored for inning #"
        Dim strNonNumericError As String = "Error - Enter number of runs scored for inning #"
        Dim strNegativeError As String = "Error - Enter a positive number of runs for inning #"

        ' Declaration and initialization of variables used in loops to follow and InputBox
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries = 7
        Dim intNumberOfEntries = 1
        strRunsScored = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        ' Do Until loop to confirm the user's input is a real number and not negative
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRunsScored = strCancelClicked
            ' if-statement to confirm user input a real number
            If IsNumeric(strRunsScored) Then
                intRunsScored = Convert.ToInt32(strRunsScored)
                ' if-statement to confirm user input is a positive number
                If intRunsScored >= 0 Then
                    lstScoresEachInning.Items.Add(intRunsScored)
                    intTotalRunsScored += intRunsScored
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strRunsScored = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop
        ' if-statement to prepare the output statement for the user based on the scores input for all innings
        If intNumberOfEntries > 1 Then
            lblOutputMessage.Visible = True
            lblOutputMessage.Text = "Total Runs Scored: " & intTotalRunsScored.ToString
        Else
            MsgBox("No score entered.")
        End If
        btnEnterScore.Enabled = False
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' Event handler for when the user clicks Clear button from the menu
        lblOutputMessage.Visible = False
        lstScoresEachInning.Items.Clear()
        btnEnterScore.Enabled = True
    End Sub
End Class
