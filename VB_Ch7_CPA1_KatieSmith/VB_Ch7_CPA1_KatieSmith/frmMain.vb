' Program:  IMAX Theatre
' Author:   Katie Smith
' Date:     3-26-22
' Purpose:  This application computes the cost of matinee and evening tickets with varying base and data plans.

Option Strict On

Public Class frmMain
    ' declared and initialized constant variables to be used throughout the program
    Private _intMatineeCost As Integer = 16
    Private _intEveningCost As Integer = 27

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' this event handler defines what happens when the program initially loads
        ' basically, it makes a bunch of things invisible until later
        ' and this is where we dictate the sleep time associated with the splash screen
        Threading.Thread.Sleep(4000)
        txtNumberOfTickets.Text = ""
        lblNumberOfTickets.Visible = False
        txtNumberOfTickets.Visible = False
        btnClear.Visible = False
        btnTicketCost.Visible = False
        lblOutputText.Visible = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' this event handler defines what happens when the user clicks the Clear button
        ' most fields are marked invisible and the number of tickets field is cleared out
        txtNumberOfTickets.Text = ""
        lblNumberOfTickets.Visible = False
        txtNumberOfTickets.Visible = False
        btnClear.Visible = False
        btnTicketCost.Visible = False
        lblOutputText.Visible = False
    End Sub

    Private Sub btnTicketCost_Click(sender As Object, e As EventArgs) Handles btnTicketCost.Click
        ' define variables to be used to calculate the price of tickets
        Dim intNumberOfTickets As Integer
        Dim blnNumberOfTicketsIsValid As Boolean = False
        Dim intUserSelectedTicketType As Integer
        Dim intTicketPrice As Integer
        Dim strOutputTicketCost As String
        Dim intTotalCostOfTickets As Integer
        ' boolean variable calls a function to validate the user's input
        blnNumberOfTicketsIsValid = ValidateNumberOfTickets()

        ' if-statement to calculate the cost of the tickets, as long as the user's input passed validity test
        If blnNumberOfTicketsIsValid = True Then
            intNumberOfTickets = Convert.ToInt32(txtNumberOfTickets.Text)
            intUserSelectedTicketType = cboTicketType.SelectedIndex
            ' select-case structure to calculate based on the user's selection of ticket type
            ' each of these function calls will return the ticket cost of that ticket type
            Select Case intUserSelectedTicketType
                Case 0
                    intTicketPrice = MatineeTicket()
                Case 1
                    intTicketPrice = EveningTicket()
            End Select
            ' once we have the cost of the ticket (based on ticket type), we can calculate the total cost based on price and 
            ' number of tickets entered by user
            ' Then we output that cost to the label associated with the output
            intTotalCostOfTickets = intNumberOfTickets * intTicketPrice
            strOutputTicketCost = Convert.ToString(intTotalCostOfTickets)
            lblOutputText.Text = "$" & strOutputTicketCost & " for the tickets"
        End If
    End Sub

    Private Function MatineeTicket() As Integer
        ' function call defined for matinee tickets
        ' this function will return the cost of the Matinee ticket
        Dim intTicketPriceCost As Integer
        intTicketPriceCost = _intMatineeCost
        Return intTicketPriceCost
    End Function

    Private Function EveningTicket() As Integer
        ' functon call defined for evening tickets
        ' this function will return the cost of the Evening ticket
        Dim intTicketPriceCost As Integer
        intTicketPriceCost = _intEveningCost
        Return intTicketPriceCost
    End Function

    Private Function ValidateNumberOfTickets() As Boolean
        ' function to validate the user's input
        ' this function confirms the user entered a positive integer
        '   if it does, the user's entry passes validity and the ticket cost can be calculated in a separate event handler
        '   if it doesn't, a message box is displayed to the user instructing them to enter their ticket number
        Dim intTicketNumberEntered As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strNumberOfTicketsMessage As String = "Please enter the number of tickets needed."
        Dim strMessageBoxTitle As String = "Error"
        ' try-catch block to avoid program shutdowns based on bad user input
        Try
            intTicketNumberEntered = Convert.ToInt32(txtNumberOfTickets.Text)
            If intTicketNumberEntered > 0 Then
                blnValidityCheck = True
            Else
                MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
                txtNumberOfTickets.Clear()
                txtNumberOfTickets.Focus()
            End If
        Catch Exception As FormatException
            MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
            txtNumberOfTickets.Clear()
            txtNumberOfTickets.Focus()
        Catch Exception As OverflowException
            MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
            txtNumberOfTickets.Clear()
            txtNumberOfTickets.Focus()
        Catch Exception As SystemException
            MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
            txtNumberOfTickets.Clear()
            txtNumberOfTickets.Focus()
        End Try
        Return blnValidityCheck
    End Function

    Private Sub cboTicketType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTicketType.SelectedIndexChanged
        ' this event handler helps to define the behavior of the initial dropdown box of ticket type options
        ' once the user selects a ticket type, then the rest of the fields are displayed
        Dim intTicketType As Integer

        intTicketType = cboTicketType.SelectedIndex

        ' make items visible after selection
        lblNumberOfTickets.Visible = True
        txtNumberOfTickets.Visible = True
        btnClear.Visible = True
        btnTicketCost.Visible = True
        lblOutputText.Visible = True
        ' clear label for output
        lblOutputText.Text = ""
    End Sub
End Class
