' Program:  Project 1 Simple Calculator
' Author:   Katie Smith
' Date:     2-22-2022
' Purpose:  Allows the user to enter values for two operands, then select an arithmetic
'               operation to perform on them.  The result of the operation will be displayed.

Option Strict On

Public Class frmMain
    ' declared the variables to be used throughout the program
    Dim currTextBox As TextBox
    Dim dblInputOperand1 As Decimal
    Dim dblInputOperand2 As Decimal
    Dim strOutputResults As String
    Dim dblMathResult As Decimal

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' event handler for when the program initially loads
        txtInputOperand1.Focus()
        lblOutputResults.Visible = False
    End Sub

    Private Sub txtInputOperand1_TextChanged(sender As Object, e As EventArgs) Handles txtInputOperand1.TextChanged
        ' conversion of the user's input to a double and assign to variable
        dblInputOperand1 = Convert.ToDecimal(txtInputOperand1.Text)
    End Sub

    Private Sub txtInputOperand2_TextChanged(sender As Object, e As EventArgs) Handles txtInputOperand2.TextChanged
        ' conversion of the user's input to a double and assign to variable
        dblInputOperand2 = Convert.ToDecimal(txtInputOperand2.Text)
    End Sub

    Private Sub btnOneButton_Click(sender As Object, e As EventArgs) Handles btnOneButton.Click
        ' event to add the 1 digit to anything that was already in the text box
        currTextBox.Text = currTextBox.Text & "1"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' closes the program when the user clicks Exit Program button
        Close()
    End Sub

    Private Sub txtInputOperand1_Enter(sender As Object, e As EventArgs) Handles txtInputOperand1.Enter
        ' defines the focus so the program knows where to put additional characters from user
        currTextBox = txtInputOperand1
    End Sub

    Private Sub txtInputOperand2_Enter(sender As Object, e As EventArgs) Handles txtInputOperand2.Enter
        ' defines the focus so the program knows where to put additional characters from user
        currTextBox = txtInputOperand2
    End Sub

    Private Sub btnTwoButton_Click(sender As Object, e As EventArgs) Handles btnTwoButton.Click
        ' event to add the 2 digit to anything that was already in the text box
        currTextBox.Text = currTextBox.Text & "2"
    End Sub

    Private Sub btnThreeButton_Click(sender As Object, e As EventArgs) Handles btnThreeButton.Click
        ' event to add the 3 digit to anything that was already in the text box
        currTextBox.Text = currTextBox.Text & "3"
    End Sub

    Private Sub btnFourButton_Click(sender As Object, e As EventArgs) Handles btnFourButton.Click
        ' event to add the 4 digit to anything that was already in the text box
        currTextBox.Text = currTextBox.Text & "4"
    End Sub

    Private Sub btnFiveButton_Click(sender As Object, e As EventArgs) Handles btnFiveButton.Click
        ' event to add the 5 digit to anything that was already in the text box
        currTextBox.Text = currTextBox.Text & "5"
    End Sub

    Private Sub btnSixButton_Click(sender As Object, e As EventArgs) Handles btnSixButton.Click
        ' event to add the 6 digit to anything that was already in the text box
        currTextBox.Text = currTextBox.Text & "6"
    End Sub

    Private Sub btnSevenButton_Click(sender As Object, e As EventArgs) Handles btnSevenButton.Click
        ' event to add the 7 digit to anything that was already in the text box
        currTextBox.Text = currTextBox.Text & "7"
    End Sub

    Private Sub btnEightButton_Click(sender As Object, e As EventArgs) Handles btnEightButton.Click
        ' event to add the 8 digit to anything that was already in the text box
        currTextBox.Text = currTextBox.Text & "8"
    End Sub

    Private Sub btnNineButton_Click(sender As Object, e As EventArgs) Handles btnNineButton.Click
        ' event to add the 9 digit to anything that was already in the text box
        currTextBox.Text = currTextBox.Text & "9"
    End Sub

    Private Sub btnZeroButton_Click(sender As Object, e As EventArgs) Handles btnZeroButton.Click
        ' event to add the 0 digit to anything that was already in the text box
        currTextBox.Text = currTextBox.Text & "0"
    End Sub

    Private Sub btnDecimalButton_Click(sender As Object, e As EventArgs) Handles btnDecimalButton.Click
        ' event to add a decimal point to anything that was already in the text box
        currTextBox.Text = currTextBox.Text & "."
    End Sub

    Private Sub btnAdditionButton_Click(sender As Object, e As EventArgs) Handles btnAdditionButton.Click
        ' event to complete the arithmetic when the user clicks the addition button
        ' essentially, do the math and convert it all to a string for output
        dblMathResult = dblInputOperand1 + dblInputOperand2
        strOutputResults = txtInputOperand1.Text & " + " & txtInputOperand2.Text
        lblOutputResults.Text = strOutputResults & " = " & Convert.ToString(dblMathResult)
        lblOutputResults.Visible = True
    End Sub

    Private Sub btnClearButton_Click(sender As Object, e As EventArgs) Handles btnClearButton.Click
        ' event to define the actions for when the user clicks the Clr button
        txtInputOperand1.Text = ""
        txtInputOperand2.Text = ""
        txtInputOperand1.Focus()
        lblOutputResults.Visible = False
    End Sub

    Private Sub btnSubtractionButton_Click(sender As Object, e As EventArgs) Handles btnSubtractionButton.Click
        ' event to complete the arithmetic when the user clicks the subtraction button
        ' essentially, do the math and convert it all to a string for output
        dblMathResult = dblInputOperand1 - dblInputOperand2
        strOutputResults = txtInputOperand1.Text & " - " & txtInputOperand2.Text
        lblOutputResults.Text = strOutputResults & " = " & Convert.ToString(dblMathResult)
        lblOutputResults.Visible = True
    End Sub

    Private Sub btnMultiplicationButton_Click(sender As Object, e As EventArgs) Handles btnMultiplicationButton.Click
        ' event to complete the arithmetic when the user clicks the multiplication button
        ' essentially, do the math and convert it all to a string for output
        dblMathResult = dblInputOperand1 * dblInputOperand2
        strOutputResults = txtInputOperand1.Text & " * " & txtInputOperand2.Text
        lblOutputResults.Text = strOutputResults & " = " & Convert.ToString(dblMathResult)
        lblOutputResults.Visible = True
    End Sub

    Private Sub btnDivisionButton_Click(sender As Object, e As EventArgs) Handles btnDivisionButton.Click
        ' event to complete the arithmetic when the user clicks the division button
        ' essentially, do the math and convert it all to a string for output
        dblMathResult = dblInputOperand1 / dblInputOperand2
        strOutputResults = txtInputOperand1.Text & " / " & txtInputOperand2.Text
        lblOutputResults.Text = strOutputResults & " = " & Convert.ToString(dblMathResult)
        lblOutputResults.Visible = True
    End Sub
End Class
