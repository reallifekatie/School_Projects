' Program:  Soda Vending Machine
' Author:   Katie Smith
' Date:     3-31-22
' Purpose:  The vending machine program will allow the user to make selections from a drink machine.
'           The user will simiulate inserting coins.  When enough "money" has been entered, the user 
'           will make his/her selection of a drink.

Option Strict On

Public Class frmMain
    ' declaration and initialization of constant variables
    Dim _cdecSodaCost As Decimal = 1.25D
    Dim _cdecNickelAmount As Decimal = 0.05D
    Dim _cdecDimeAmount As Decimal = 0.1D
    Dim _cdecQuarterAmount As Decimal = 0.25D
    Dim _cdecDollarAmount As Decimal = 1D
    Dim _cdecAmountInserted As Decimal = 0.00D
    Dim _cdecChangeBack As Decimal = 0.00D

    ' declaration and initialization of constant variables for error messaging
    Dim _cstrErrorHeader As String = "Error"
    Dim _cstrInsufficientFunds As String = "Insuffucient funds inserted. Enter more money."

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' event handler for when user clicks the Exit button
        Close()
    End Sub

    Private Sub frmMain_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ' event handler to define what happens when the program initially loads
        ' making sure the picture boxes are in invisible
        lblEnjoy.Visible = False
        picOutputCokeReg.Visible = False
        picOutputDietCoke.Visible = False
        picOutputCokeZero.Visible = False
        picOutputOrangeVanilla.Visible = False
        picOutputDasani.Visible = False
        picOutputCherryVanillaZero.Visible = False
        picOutputCherryVanilla.Visible = False
        picOutputStarlight.Visible = False

    End Sub

    Private Function EnoughMoneyEntered() As Boolean
        ' new function declared to verify the user has entered enough money
        ' if-statement will compare amount inserted vs the cost of a soda
        Dim blnEnoughMoney As Boolean = False
        If _cdecAmountInserted >= _cdecSodaCost Then
            blnEnoughMoney = True
        End If
        Return blnEnoughMoney
    End Function

    Private Sub btnNickel_Click(sender As Object, e As EventArgs) Handles btnNickel.Click
        ' event handler for when the user clicks the button to add a nickel to the machine
        ' the constant amount of a nickel is accumulated to the constant variable of amount inserted
        ' that amount is published to the label for output
        _cdecAmountInserted += _cdecNickelAmount
        lblAmountInsertedMoney.Text = "$" & Convert.ToString(_cdecAmountInserted)
    End Sub

    Private Sub btnDime_Click(sender As Object, e As EventArgs) Handles btnDime.Click
        ' event handler for when the user clicks the button to add a dime to the machine
        ' the constant amount of a dime is accumulated to the constant variable of amount inserted
        ' that amount is published to the label for output
        _cdecAmountInserted += _cdecDimeAmount
        lblAmountInsertedMoney.Text = "$" & Convert.ToString(_cdecAmountInserted)
    End Sub

    Private Sub btnQuarter_Click(sender As Object, e As EventArgs) Handles btnQuarter.Click
        ' event handler for when the user clicks the button to add a quarter to the machine
        ' the constant amount of a quarter is accumulated to the constant variable of amount inserted
        ' that amount is published to the label for output
        _cdecAmountInserted += _cdecQuarterAmount
        lblAmountInsertedMoney.Text = "$" & Convert.ToString(_cdecAmountInserted)
    End Sub

    Private Sub btnDollar_Click(sender As Object, e As EventArgs) Handles btnDollar.Click
        ' event handler for when the user clicks the button to add a dollar to the machine
        ' the constant amount of a dollar is accumulated to the constant variable of amount inserted
        ' that amount is published to the label for output
        _cdecAmountInserted += _cdecDollarAmount
        lblAmountInsertedMoney.Text = "$" & Convert.ToString(_cdecAmountInserted)
    End Sub

    Private Sub btnCoke_Click(sender As Object, e As EventArgs) Handles btnCoke.Click
        ' event handler for when user clicks the button to buy a regular Coke
        ' new variables declared and initialized
        Dim blnReadyForOutput As Boolean
        Dim decAmountInserted As Decimal = 0.00D
        ' new boolean variable is used to call function to verify the user entered enough money
        blnReadyForOutput = EnoughMoneyEntered()
        ' if-statement that checks whether user entered enough money
        ' if user did enter enough money, then all pics are hidden except the user's selection and
        '   the program subtracts the money for the drink from the user's input and provides change
        If blnReadyForOutput = True Then
            picOutputCokeReg.Visible = True
            picOutputDietCoke.Visible = False
            picOutputCokeZero.Visible = False
            picOutputOrangeVanilla.Visible = False
            picOutputDasani.Visible = False
            picOutputCherryVanillaZero.Visible = False
            picOutputCherryVanilla.Visible = False
            picOutputStarlight.Visible = False
            lblEnjoy.Visible = True
            _cdecChangeBack = _cdecAmountInserted - _cdecSodaCost
            lblChangeBackMoney.Text = "$" & Convert.ToString(_cdecChangeBack)
            lblAmountInsertedMoney.Text = "$" & Convert.ToString(decAmountInserted)
            _cdecAmountInserted = 0.00D
        Else
            MsgBox(_cstrInsufficientFunds, , _cstrErrorHeader)
        End If
    End Sub

    Private Sub btnDietCoke_Click(sender As Object, e As EventArgs) Handles btnDietCoke.Click
        ' event handler for when user clicks the button to buy a Diet Coke
        ' new variables declared and initialized
        Dim blnReadyForOutput As Boolean
        Dim decAmountInserted As Decimal = 0.00D
        ' new boolean variable is used to call function to verify the user entered enough money
        blnReadyForOutput = EnoughMoneyEntered()
        ' if-statement that checks whether user entered enough money
        ' if user did enter enough money, then all pics are hidden except the user's selection and
        '   the program subtracts the money for the drink from the user's input and provides change
        If blnReadyForOutput = True Then
            picOutputDietCoke.Visible = True
            picOutputCokeReg.Visible = False
            picOutputCokeZero.Visible = False
            picOutputOrangeVanilla.Visible = False
            picOutputDasani.Visible = False
            picOutputCherryVanillaZero.Visible = False
            picOutputCherryVanilla.Visible = False
            picOutputStarlight.Visible = False
            lblEnjoy.Visible = True
            _cdecChangeBack = _cdecAmountInserted - _cdecSodaCost
            lblChangeBackMoney.Text = "$" & Convert.ToString(_cdecChangeBack)
            lblAmountInsertedMoney.Text = "$" & Convert.ToString(decAmountInserted)
            _cdecAmountInserted = 0.00D
        Else
            MsgBox(_cstrInsufficientFunds, , _cstrErrorHeader)
        End If
    End Sub

    Private Sub btnCokeZero_Click(sender As Object, e As EventArgs) Handles btnCokeZero.Click
        ' event handler for when user clicks the button to buy a Diet Coke
        ' new variables declared and initialized
        Dim blnReadyForOutput As Boolean
        Dim decAmountInserted As Decimal = 0.00D
        ' new boolean variable is used to call function to verify the user entered enough money
        blnReadyForOutput = EnoughMoneyEntered()
        ' if-statement that checks whether user entered enough money
        ' if user did enter enough money, then all pics are hidden except the user's selection and
        '   the program subtracts the money for the drink from the user's input and provides change
        If blnReadyForOutput = True Then
            picOutputCokeZero.Visible = True
            picOutputCokeReg.Visible = False
            picOutputDietCoke.Visible = False
            picOutputOrangeVanilla.Visible = False
            picOutputDasani.Visible = False
            picOutputCherryVanillaZero.Visible = False
            picOutputCherryVanilla.Visible = False
            picOutputStarlight.Visible = False
            lblEnjoy.Visible = True
            _cdecChangeBack = _cdecAmountInserted - _cdecSodaCost
            lblChangeBackMoney.Text = "$" & Convert.ToString(_cdecChangeBack)
            lblAmountInsertedMoney.Text = "$" & Convert.ToString(decAmountInserted)
            _cdecAmountInserted = 0.00D
        Else
            MsgBox(_cstrInsufficientFunds, , _cstrErrorHeader)
        End If
    End Sub

    Private Sub btnOrangeVanilla_Click(sender As Object, e As EventArgs) Handles btnOrangeVanilla.Click
        ' event handler for when user clicks the button to buy a Diet Coke
        ' new variables declared and initialized
        Dim blnReadyForOutput As Boolean
        Dim decAmountInserted As Decimal = 0.00D
        ' new boolean variable is used to call function to verify the user entered enough money
        blnReadyForOutput = EnoughMoneyEntered()
        ' if-statement that checks whether user entered enough money
        ' if user did enter enough money, then all pics are hidden except the user's selection and
        '   the program subtracts the money for the drink from the user's input and provides change
        If blnReadyForOutput = True Then
            picOutputOrangeVanilla.Visible = True
            picOutputCokeReg.Visible = False
            picOutputDietCoke.Visible = False
            picOutputCokeZero.Visible = False
            picOutputDasani.Visible = False
            picOutputCherryVanillaZero.Visible = False
            picOutputCherryVanilla.Visible = False
            picOutputStarlight.Visible = False
            lblEnjoy.Visible = True
            _cdecChangeBack = _cdecAmountInserted - _cdecSodaCost
            lblChangeBackMoney.Text = "$" & Convert.ToString(_cdecChangeBack)
            lblAmountInsertedMoney.Text = "$" & Convert.ToString(decAmountInserted)
            _cdecAmountInserted = 0.00D
        Else
            MsgBox(_cstrInsufficientFunds, , _cstrErrorHeader)
        End If
    End Sub

    Private Sub btnDasani_Click(sender As Object, e As EventArgs) Handles btnDasani.Click
        ' event handler for when user clicks the button to buy a Diet Coke
        ' new variables declared and initialized
        Dim blnReadyForOutput As Boolean
        Dim decAmountInserted As Decimal = 0.00D
        ' new boolean variable is used to call function to verify the user entered enough money
        blnReadyForOutput = EnoughMoneyEntered()
        ' if-statement that checks whether user entered enough money
        ' if user did enter enough money, then all pics are hidden except the user's selection and
        '   the program subtracts the money for the drink from the user's input and provides change
        If blnReadyForOutput = True Then
            picOutputDasani.Visible = True
            picOutputCokeReg.Visible = False
            picOutputDietCoke.Visible = False
            picOutputCokeZero.Visible = False
            picOutputOrangeVanilla.Visible = False
            picOutputCherryVanillaZero.Visible = False
            picOutputCherryVanilla.Visible = False
            picOutputStarlight.Visible = False
            lblEnjoy.Visible = True
            _cdecChangeBack = _cdecAmountInserted - _cdecSodaCost
            lblChangeBackMoney.Text = "$" & Convert.ToString(_cdecChangeBack)
            lblAmountInsertedMoney.Text = "$" & Convert.ToString(decAmountInserted)
            _cdecAmountInserted = 0.00D
        Else
            MsgBox(_cstrInsufficientFunds, , _cstrErrorHeader)
        End If
    End Sub

    Private Sub btnCherryVanillaZero_Click(sender As Object, e As EventArgs) Handles btnCherryVanillaZero.Click
        ' event handler for when user clicks the button to buy a Diet Coke
        ' new variables declared and initialized
        Dim blnReadyForOutput As Boolean
        Dim decAmountInserted As Decimal = 0.00D
        ' new boolean variable is used to call function to verify the user entered enough money
        blnReadyForOutput = EnoughMoneyEntered()
        ' if-statement that checks whether user entered enough money
        ' if user did enter enough money, then all pics are hidden except the user's selection and
        '   the program subtracts the money for the drink from the user's input and provides change
        If blnReadyForOutput = True Then
            picOutputCherryVanillaZero.Visible = True
            picOutputCokeReg.Visible = False
            picOutputDietCoke.Visible = False
            picOutputCokeZero.Visible = False
            picOutputOrangeVanilla.Visible = False
            picOutputDasani.Visible = False
            picOutputCherryVanilla.Visible = False
            picOutputStarlight.Visible = False
            lblEnjoy.Visible = True
            _cdecChangeBack = _cdecAmountInserted - _cdecSodaCost
            lblChangeBackMoney.Text = "$" & Convert.ToString(_cdecChangeBack)
            lblAmountInsertedMoney.Text = "$" & Convert.ToString(decAmountInserted)
            _cdecAmountInserted = 0.00D
        Else
            MsgBox(_cstrInsufficientFunds, , _cstrErrorHeader)
        End If
    End Sub

    Private Sub btnCherryVanilla_Click(sender As Object, e As EventArgs) Handles btnCherryVanilla.Click
        ' event handler for when user clicks the button to buy a Diet Coke
        ' new variables declared and initialized
        Dim blnReadyForOutput As Boolean
        Dim decAmountInserted As Decimal = 0.00D
        ' new boolean variable is used to call function to verify the user entered enough money
        blnReadyForOutput = EnoughMoneyEntered()
        ' if-statement that checks whether user entered enough money
        ' if user did enter enough money, then all pics are hidden except the user's selection and
        '   the program subtracts the money for the drink from the user's input and provides change
        If blnReadyForOutput = True Then
            picOutputCherryVanilla.Visible = True
            picOutputCokeReg.Visible = False
            picOutputDietCoke.Visible = False
            picOutputCokeZero.Visible = False
            picOutputOrangeVanilla.Visible = False
            picOutputDasani.Visible = False
            picOutputCherryVanillaZero.Visible = False
            picOutputStarlight.Visible = False
            lblEnjoy.Visible = True
            _cdecChangeBack = _cdecAmountInserted - _cdecSodaCost
            lblChangeBackMoney.Text = "$" & Convert.ToString(_cdecChangeBack)
            lblAmountInsertedMoney.Text = "$" & Convert.ToString(decAmountInserted)
            _cdecAmountInserted = 0.00D
        Else
            MsgBox(_cstrInsufficientFunds, , _cstrErrorHeader)
        End If
    End Sub

    Private Sub btnStarlight_Click(sender As Object, e As EventArgs) Handles btnStarlight.Click
        ' event handler for when user clicks the button to buy a Diet Coke
        ' new variables declared and initialized
        Dim blnReadyForOutput As Boolean
        Dim decAmountInserted As Decimal = 0.00D
        ' new boolean variable is used to call function to verify the user entered enough money
        blnReadyForOutput = EnoughMoneyEntered()
        ' if-statement that checks whether user entered enough money
        ' if user did enter enough money, then all pics are hidden except the user's selection and
        '   the program subtracts the money for the drink from the user's input and provides change
        If blnReadyForOutput = True Then
            picOutputStarlight.Visible = True
            picOutputCokeReg.Visible = False
            picOutputDietCoke.Visible = False
            picOutputCokeZero.Visible = False
            picOutputOrangeVanilla.Visible = False
            picOutputDasani.Visible = False
            picOutputCherryVanillaZero.Visible = False
            picOutputCherryVanilla.Visible = False
            lblEnjoy.Visible = True
            _cdecChangeBack = _cdecAmountInserted - _cdecSodaCost
            lblChangeBackMoney.Text = "$" & Convert.ToString(_cdecChangeBack)
            lblAmountInsertedMoney.Text = "$" & Convert.ToString(decAmountInserted)
            _cdecAmountInserted = 0.00D
        Else
            MsgBox(_cstrInsufficientFunds, , _cstrErrorHeader)
        End If
    End Sub
End Class
