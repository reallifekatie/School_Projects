' Program:  Broadway Ticket Group Discount
' Author:   Katie Smith
' Date:     2-15-22
' Purpose:  xxx

Option Strict On

Public Class frmMain
    ' declaration and initialization of constant variables
    Dim _cintOneToEightCost As Integer = 249I
    Dim _cintNineToTwelve As Integer = 219I
    Dim _cintThirteenToTwentyFour As Integer = 199I
    Dim _cintTwentyFiveUp As Integer = 169I

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' event handler for when user clicks Exit button
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' event handler for when user clicks Calculate button
        ' declaration of variables to be used
        Dim intOutputTicketCost As Integer
        Dim intInputNumberOfTickets As Integer

        ' nested if-else to confirm user enters valid number
        If IsNumeric(txtInputNumTix.Text) Then
            ' initializing variable based on user's input
            intInputNumberOfTickets = Convert.ToInt32(txtInputNumTix.Text)
            If intInputNumberOfTickets > 0 Then
                ' Case statement to dictate output based on user's input
                Select Case intInputNumberOfTickets
                    Case 1 To 8
                        intOutputTicketCost = intInputNumberOfTickets * _cintOneToEightCost
                        lblOutputTotalCost.Text = intOutputTicketCost.ToString("C")
                    Case 9 To 12
                        intOutputTicketCost = intInputNumberOfTickets * _cintNineToTwelve
                        lblOutputTotalCost.Text = intOutputTicketCost.ToString("C")
                    Case 13 To 24
                        intOutputTicketCost = intInputNumberOfTickets * _cintThirteenToTwentyFour
                        lblOutputTotalCost.Text = intOutputTicketCost.ToString("C")
                    Case 25 To 99
                        intOutputTicketCost = intInputNumberOfTickets * _cintTwentyFiveUp
                        lblOutputTotalCost.Text = intOutputTicketCost.ToString("C")
                    Case Else
                        lblOutputTotalCost.Text = "Invalid Selection"
                        txtInputNumTix.Text = ""
                        txtInputNumTix.Focus()
                End Select
            Else
                MsgBox("Please enter a valid number greater than 0 and less than 100.", , "Input Error")
                txtInputNumTix.Text = ""
                txtInputNumTix.Focus()
            End If
        Else
            MsgBox("Please enter a valid number greater than 0 and less than 100.", , "Input Error")
            txtInputNumTix.Text = ""
            txtInputNumTix.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' event handler for when user clicks Clear button
        txtInputNumTix.Text = ""
        lblOutputTotalCost.Text = ""
        txtInputNumTix.Focus()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' event handler for when program initially loads
        txtInputNumTix.Text = ""
        lblOutputTotalCost.Text = ""
        txtInputNumTix.Focus()
    End Sub
End Class
