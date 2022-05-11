' Program:  Elementary School Math Tutor
' Author:   Katie Smith
' Date:     4-21-22
' Purpose:  This application will help different levels of elementary school students learn their basic
'               math facts for addition and multiplication.

Option Strict On

Public Class frmElemMathMain
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' event handler for when user clicks Exit from the menu strip
        Application.Exit()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' event handler for when user clicks Clear from the menu strip
        lstMathTableDisplay.Items.Clear()
        mnuAddition.Checked = False
        mnuMultiplication.Checked = False
        radEarlyElem.Checked = False
        radUpperElem.Checked = False
    End Sub

    Private Sub frmElemMathMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' event handler for when the program initially loads
        radEarlyElem.Checked = False
        radUpperElem.Checked = False
    End Sub

    Private Sub frmElemMathMain_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ' event handler for when the program initally loads
        radEarlyElem.Checked = False
        radUpperElem.Checked = False
    End Sub

    Private Sub btnGenerateList_Click(sender As Object, e As EventArgs) Handles btnGenerateList.Click
        ' event handler for when user clicks the button to Generate List
        ' declaration and initialiazation of variables used in error handling
        Dim strErrorNoRadChecked As String = "No Grade Level selected.  Please try again."
        Dim strErrorNoOperationSelected As String = "You must select either Addition or Multiplication from
                the Operation Menu."
        Dim strErrorInvalidNumEntered As String = "Invalid number entered.  Please try again."

        ' declaration of variabled used to create an instance of the user's input
        Dim intUserInputNum As Integer

        ' a series of nested if-statements used to verify the user's input, radio button selection, and Operation selection
        If radEarlyElem.Checked = True Then
            If mnuAddition.Checked = True Then
                intUserInputNum = Convert.ToInt32(InputBox("Enter a number between 0 and 6:", , " "))
                If intUserInputNum >= 0 And intUserInputNum <= 6 Then
                    EarlyAddition(intUserInputNum)
                Else
                    MsgBox(strErrorInvalidNumEntered, , "Error")
                End If
            ElseIf mnuMultiplication.Checked = True Then
                intUserInputNum = Convert.ToInt32(InputBox("Enter a number between 0 and 6:", , " "))
                If intUserInputNum >= 0 And intUserInputNum <= 6 Then
                    EarlyMultiplication(intUserInputNum)
                Else
                    MsgBox(strErrorInvalidNumEntered, , "Error")
                End If
            Else
                MsgBox(strErrorNoOperationSelected, , "Error - Operation Not Selected")
            End If
        ElseIf radUpperElem.Checked = True Then
            If mnuAddition.Checked = True Then
                intUserInputNum = Convert.ToInt32(InputBox("Enter a number between 0 and 12:", , " "))
                If intUserInputNum >= 0 And intUserInputNum <= 12 Then
                    UpperAddition(intUserInputNum)
                Else
                    MsgBox(strErrorInvalidNumEntered, , "Error")
                End If
            ElseIf mnuMultiplication.Checked = True Then
                intUserInputNum = Convert.ToInt32(InputBox("Enter a number between 0 and 12:", , " "))
                If intUserInputNum >= 0 And intUserInputNum <= 12 Then
                    UpperMultiplication(intUserInputNum)
                Else
                    MsgBox(strErrorInvalidNumEntered, , "Error")
                End If
            Else
                MsgBox(strErrorNoOperationSelected, , "Error - Operation Not Selected")
            End If
        Else
            MsgBox(strErrorNoRadChecked, , "Error")
        End If

    End Sub

    Private Sub EarlyAddition(ByVal intUserInput As Integer)
        ' function for user's selection of Early Elementary radio button and Addition Operation
        ' declaration of variables used in function
        Dim intSum As Integer
        Dim intMultiplier As Integer

        ' for-loop to iterate over the range of numbers associated with Early/Addition
        ' each iteration adds to the listbox
        For intMultiplier = 0 To 6
            intSum = intMultiplier + intUserInput
            lstMathTableDisplay.Items.Add(Convert.ToString(intUserInput & " + " & intMultiplier & " = " & intSum))
        Next
    End Sub

    Private Sub EarlyMultiplication(ByVal intUserInput As Integer)
        ' function for user's selection of Early Elementary radio button and Multiplication Operation
        ' declaration of variables used in function
        Dim intSum As Integer
        Dim intMultiplier As Integer

        ' for-loop to iterate over the range of numbers associated with Early/Multiplication
        ' each iteration adds to the listbox
        For intMultiplier = 0 To 6
            intSum = intMultiplier * intUserInput
            lstMathTableDisplay.Items.Add(Convert.ToString(intUserInput & " x " & intMultiplier & " = " & intSum))
        Next
    End Sub

    Private Sub UpperAddition(ByVal intUserInput As Integer)
        ' function for user's selection of Upper Elementary radio button and Addition Operation
        ' declaration of variables used in function
        Dim intSum As Integer
        Dim intMultiplier As Integer

        ' for-loop to iterate over the range of numbers associated with Upper/Addition
        ' each iteration adds to the listbox
        For intMultiplier = 0 To 12
            intSum = intMultiplier + intUserInput
            lstMathTableDisplay.Items.Add(Convert.ToString(intUserInput & " + " & intMultiplier & " = " & intSum))
        Next
    End Sub

    Private Sub UpperMultiplication(ByVal intUserInput As Integer)
        ' function for user's selection of Upper Elementary radio button and Multiplication Operation
        ' declaration of variables used in function
        Dim intSum As Integer
        Dim intMultiplier As Integer

        ' for-loop to iterate over the range of numbers associated with Upper/Multiplication
        ' each iteration adds to the listbox
        For intMultiplier = 0 To 12
            intSum = intMultiplier * intUserInput
            lstMathTableDisplay.Items.Add(Convert.ToString(intUserInput & " x " & intMultiplier & " = " & intSum))
        Next
    End Sub
End Class
