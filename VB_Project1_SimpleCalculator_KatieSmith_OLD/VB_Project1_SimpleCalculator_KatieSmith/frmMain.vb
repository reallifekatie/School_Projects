' Program:  Project 1 Simple Calculator
' Author:   Katie Smith
' Date:     2-22-2022
' Purpose:  Allows the user to enter values for two operands, then select an arithmetic
'               operation to perform on them.  The result of the operation will be displayed.

Option Strict On

Public Class frmMain

    Dim dblInputOperand1 As Double
    Dim dblInputOperand2 As Double
    Dim strInputOperand1 As String = ""
    Dim strInputOperand2 As String = ""
    Dim strOutputTotal As String = " "
    Dim currTextBox As TextBox


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '        txtInputOperand1.Text = " "
        '        txtInputOperand2.Text = " "
        txtInputOperand1.Focus()
        lblOutputResults.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub txtInputOperand1_TextChanged(sender As Object, e As EventArgs) Handles txtInputOperand1.TextChanged
        currTextBox = txtInputOperand1
    End Sub

    Private Sub btnOneButton_Click(sender As Object, e As EventArgs) Handles btnOneButton.Click
        currTextBox.Text = currTextBox.Text & "1"
    End Sub

    Private Sub txtInputOperand2_TextChanged(sender As Object, e As EventArgs) Handles txtInputOperand2.TextChanged
        currTextBox = txtInputOperand2
    End Sub

    Private Sub btnTwoButton_Click(sender As Object, e As EventArgs) Handles btnTwoButton.Click
        currTextBox.Text = currTextBox.Text & "2"
    End Sub

    Private Sub btnThreeButton_Click(sender As Object, e As EventArgs) Handles btnThreeButton.Click
        currTextBox.Text = currTextBox.Text & "3"
    End Sub

    Private Sub btnFourButton_Click(sender As Object, e As EventArgs) Handles btnFourButton.Click
        currTextBox.Text = currTextBox.Text & "4"
    End Sub

    Private Sub btnFiveButton_Click(sender As Object, e As EventArgs) Handles btnFiveButton.Click
        currTextBox.Text = currTextBox.Text & "5"
    End Sub

    Private Sub btnSixButton_Click(sender As Object, e As EventArgs) Handles btnSixButton.Click
        currTextBox.Text = currTextBox.Text & "6"
    End Sub

    Private Sub btnSevenButton_Click(sender As Object, e As EventArgs) Handles btnSevenButton.Click
        currTextBox.Text = currTextBox.Text & "7"
    End Sub

    Private Sub btnEightButton_Click(sender As Object, e As EventArgs) Handles btnEightButton.Click
        currTextBox.Text = currTextBox.Text & "8"
    End Sub

    Private Sub btnNineButton_Click(sender As Object, e As EventArgs) Handles btnNineButton.Click
        currTextBox.Text = currTextBox.Text & "9"
    End Sub

    Private Sub btnZeroButton_Click(sender As Object, e As EventArgs) Handles btnZeroButton.Click
        currTextBox.Text = currTextBox.Text & "0"
    End Sub

    Private Sub btnDecimalButton_Click(sender As Object, e As EventArgs) Handles btnDecimalButton.Click
        currTextBox.Text = currTextBox.Text & "."
    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        ' currTextBox.Text = currTextBox.Text & "+"
    End Sub

    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        ' currTextBox.Text = currTextBox.Text & "-"
    End Sub
End Class
