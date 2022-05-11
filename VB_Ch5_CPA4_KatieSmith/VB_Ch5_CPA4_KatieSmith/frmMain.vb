' Program:  Building Plans Conversion
' Author:   Katie Smith
' Date:     2-13-22
' Purpose:  This application converts inches to meters or from meters to inches
'           when building plans need to be converted between Imperial and Metric systems.

Option Strict On

Public Class frmMain
    ' Declare and initialize constant variables for math later
    Const _cdecImpToMetRate As Decimal = 0.0254D
    Const _cdecMetToImpRate As Decimal = 39.37008D

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' declare variables to be used throughout the program
        Dim decInputNumber As Decimal
        Dim decOutputResult As Decimal

        decInputNumber = Convert.ToDecimal(txtInputNumber.Text)

        ' Nested if statements to confirm the user entered clean info
        If IsNumeric(txtInputNumber.Text) And decInputNumber > 0 Then
            ' If statements to determine output based on user selections
            If radImpToMet.Checked = True Then
                decOutputResult = decInputNumber * _cdecImpToMetRate
                lblConvertsTo.Text = "Converts to:   " & decOutputResult.ToString("N") & " meters "
                lblConvertsTo.Visible = True
            Else
                decOutputResult = decInputNumber * _cdecMetToImpRate
                lblConvertsTo.Text = "Converts to:   " & decOutputResult.ToString("N") & " inches "
                lblConvertsTo.Visible = True
            End If
        Else
            MsgBox("Please enter a number greater than zero. ", , "Invalid Entry")
            txtInputNumber.Text = ""
            txtInputNumber.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' this event handler dictates what happens when user clicks Clear button
        txtInputNumber.Text = ""
        txtInputNumber.Focus()
        radImpToMet.Checked = True
        radMetToImp.Checked = False
        lblConvertsTo.Visible = False
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' this event handler dictates what happens as the program is starting
        txtInputNumber.Text = ""
        txtInputNumber.Focus()
        radImpToMet.Checked = True
        radMetToImp.Checked = False
        lblConvertsTo.Visible = False
    End Sub
End Class
