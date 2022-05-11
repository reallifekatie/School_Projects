' Program:  Decking Cost Calculator Application
' Author:   Katie Smith
' Date:     2-10-22
' Purpose:  This is a program that allows a user to enter their square footage, select the type of 
'               decking materials they wish to use, and calculate an estimated cost      

Option Strict On

Public Class frmDecking
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This button calculates the estimated cost of decking,
        ' based on the square footage and decking type

        ' declaration and initialization of variables to be used throughout program
        Dim decFootage As Decimal
        Dim decCostPerSquareFoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decLumberCost As Decimal = 2.35D
        Dim decRedwoodCost As Decimal = 7.75D
        Dim decCompositeCost As Decimal = 8.5D

        ' if statement to determine whether user entered a number and whether it is a positive number
        If IsNumeric(txtFootage.Text) Then
            decFootage = Convert.ToDecimal(txtFootage.Text)
            If decFootage > 0 Then
                If radLumber.Checked Then
                    decCostPerSquareFoot = decLumberCost
                ElseIf radRedwood.Checked Then
                    decCostPerSquareFoot = decRedwoodCost
                ElseIf radComposite.Checked Then
                    decCostPerSquareFoot = decCompositeCost
                End If
                decCostEstimate = decFootage * decCostPerSquareFoot
                lblCostEstimate.Text = decCostEstimate.ToString("C")
            Else
                MsgBox("You entered " & decFootage.ToString() & ".  Enter a Positive Number.", , "Input Error")
                txtFootage.Text = ""
                txtFootage.Focus()
            End If
        Else
            ' Display error message if user entered a non-numeric value
            MsgBox("Enter the Square Footage of Decking", , "Input Error")
            txtFootage.Text = ""
            txtFootage.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' this clears all input and output fields when user clicks Clear so they can enter info again
        txtFootage.Clear()
        lblCostEstimate.Text = ""
        radLumber.Checked = True
        radRedwood.Checked = False
        radComposite.Checked = False
        txtFootage.Focus()
    End Sub

    Private Sub frmDecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' this event outlines what happens when the user initially opens the program
        txtFootage.Focus()
        txtFootage.Text = ""
    End Sub
End Class
