' Program:  Comic Convention
' Author:   Katie Smith
' Date:     2-13-22
' Purpose:  To compute the registration cost of attending a Comic Convention.

Option Strict On

Public Class frmMain
    ' Declaring and initializing my constant variables to be used for math
    Const _cintConvHeroCost As Integer = 380
    Const _cintConvAutoCost As Integer = 275
    Const _cintConvention As Integer = 209

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Variable declarations
        Dim intInputGroupSize As Integer
        Dim decOutputRegistrationCost As Decimal
        intInputGroupSize = Convert.ToInt32(txtInputGroupSize.Text)

        ' Start a series of nested if-elseif-else statements to confirm user's input meets certain criteria
        If IsNumeric(txtInputGroupSize.Text) Then
            If intInputGroupSize > 0 Then
                If intInputGroupSize <= 20 Then
                    ' This is where we do the math based on num of tickets and which radio button is selected
                    If radConvHero.Checked Then
                        decOutputRegistrationCost = Convert.ToDecimal(intInputGroupSize) * Convert.ToDecimal(_cintConvHeroCost)
                        lblOutputRegCost.Text = decOutputRegistrationCost.ToString("C")
                        lblOutputRegCost.Visible = True
                        lblRegCost.Visible = True
                    ElseIf radConvAuto.Checked Then
                        decOutputRegistrationCost = Convert.ToDecimal(intInputGroupSize) * Convert.ToDecimal(_cintConvAutoCost)
                        lblOutputRegCost.Text = decOutputRegistrationCost.ToString("C")
                        lblOutputRegCost.Visible = True
                        lblRegCost.Visible = True
                    Else
                        decOutputRegistrationCost = Convert.ToDecimal(intInputGroupSize) * Convert.ToDecimal(_cintConvention)
                        lblOutputRegCost.Text = decOutputRegistrationCost.ToString("C")
                        lblOutputRegCost.Visible = True
                        lblRegCost.Visible = True
                    End If
                Else
                    MsgBox("Please enter a number less than 20.", , "Input Error")
                    txtInputGroupSize.Text = ""
                    txtInputGroupSize.Focus()
                End If
            Else
                MsgBox("Please enter a number greater than zero.", , "Input Error")
                txtInputGroupSize.Text = ""
                txtInputGroupSize.Focus()
            End If
        Else
            MsgBox("Please enter a valid number.", , "Input Error")
            txtInputGroupSize.Text = ""
            txtInputGroupSize.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Event handling for when the user clicks the Clear button
        ' Reseting everything for new input
        lblOutputRegCost.Text = ""
        lblOutputRegCost.Visible = False
        lblRegCost.Visible = False
        txtInputGroupSize.Clear()
        txtInputGroupSize.Focus()
        radConvAuto.Checked = False
        radConvHero.Checked = False
        radConvention.Checked = True
    End Sub
End Class
