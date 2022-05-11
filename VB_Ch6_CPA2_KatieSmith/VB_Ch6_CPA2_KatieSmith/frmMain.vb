' Program:  Internet Speed Test Survey
' Author:   Katie Smith
' Date:     3-20-22
' Purpose:  This application finds the average speed of a home internet connection.
'               (See speedtest.net to measure your own connections's download speed).

Option Strict On

Public Class frmMain
    Private Sub frmMain_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ' event handler for when the program initially loads
        ' the output average label will be hidden when program loads
        lblOutputSpeedAverage.Visible = False
    End Sub

    Private Sub btnEnterInternetSpeed_Click(sender As Object, e As EventArgs) Handles btnEnterInternetSpeed.Click
        ' declaring variables to be used throughout the program
        ' a few of the variables are initialized below; primarily the strings for InputBox
        Dim strInternetSpeed As String
        Dim decInternetSpeed As Decimal
        Dim decAverageInternetSpeed As Decimal
        Dim decTotalInternetSpeed As Decimal = 0D
        Dim strInputMessage As String = "Enter internet speed #"
        Dim strInputHeading As String = "Internet Speed"
        Dim strNormalMessage As String = "Enter internet speed #"
        Dim strNonNumericError As String = "Error - enter a number for internet speed #"
        Dim strNegativeError As String = "Error - enter a positive number for internet speed #"

        ' declaring and initializing variables to be used within the InputBox and if-statements
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 10
        Dim intNumberOfEntries As Integer = 1

        ' initializing the variable that will dictate the output message within InputBox
        strInternetSpeed = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        ' Do Until loop to verify the user entered appropriate input
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strInternetSpeed = strCancelClicked
            ' if statement to determine if user entered a real number
            If IsNumeric(strInternetSpeed) Then
                decInternetSpeed = Convert.ToDecimal(strInternetSpeed)
                ' if statement to confirm the user entered a positive number
                If decInternetSpeed > 0 Then
                    lstSpeedInputs.Items.Add(decInternetSpeed)
                    decTotalInternetSpeed += decInternetSpeed
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            ' this if-statement dictates the outgoing message to the user based on the number of entries
            ' being less than or equal to the max number of entries
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strInternetSpeed = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop
        ' if-statement that does the appropriate math and displays the average internet speed to the user
        If intNumberOfEntries > 1 Then
            lblOutputSpeedAverage.Visible = True
            decAverageInternetSpeed = decTotalInternetSpeed / (intNumberOfEntries - 1)
            lblOutputSpeedAverage.Text = "Average Internet Speed: " & decAverageInternetSpeed.ToString("F2") & " Mbps"
        Else
            MsgBox("No internet speed was entered.")
        End If
        ' when calculates are complete, the Enter Internet Speed button will be disabled
        btnEnterInternetSpeed.Enabled = False
    End Sub
End Class
