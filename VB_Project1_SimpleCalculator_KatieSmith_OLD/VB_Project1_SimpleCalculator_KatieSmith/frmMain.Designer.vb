<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblOperand1 = New System.Windows.Forms.Label()
        Me.lblOperand2 = New System.Windows.Forms.Label()
        Me.txtInputOperand1 = New System.Windows.Forms.TextBox()
        Me.txtInputOperand2 = New System.Windows.Forms.TextBox()
        Me.lblOutputResults = New System.Windows.Forms.Label()
        Me.btnOneButton = New System.Windows.Forms.Button()
        Me.btnTwoButton = New System.Windows.Forms.Button()
        Me.btnThreeButton = New System.Windows.Forms.Button()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.btnFourButton = New System.Windows.Forms.Button()
        Me.btnFiveButton = New System.Windows.Forms.Button()
        Me.btnSixButton = New System.Windows.Forms.Button()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.btnSevenButton = New System.Windows.Forms.Button()
        Me.btnEightButton = New System.Windows.Forms.Button()
        Me.btnNineButton = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnZeroButton = New System.Windows.Forms.Button()
        Me.btnDecimalButton = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(60, 27)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(265, 36)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Simple Calculator"
        '
        'lblOperand1
        '
        Me.lblOperand1.AutoSize = True
        Me.lblOperand1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperand1.Location = New System.Drawing.Point(72, 79)
        Me.lblOperand1.Name = "lblOperand1"
        Me.lblOperand1.Size = New System.Drawing.Size(102, 21)
        Me.lblOperand1.TabIndex = 1
        Me.lblOperand1.Text = "OPERAND 1"
        '
        'lblOperand2
        '
        Me.lblOperand2.AutoSize = True
        Me.lblOperand2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperand2.Location = New System.Drawing.Point(213, 79)
        Me.lblOperand2.Name = "lblOperand2"
        Me.lblOperand2.Size = New System.Drawing.Size(102, 21)
        Me.lblOperand2.TabIndex = 2
        Me.lblOperand2.Text = "OPERAND 2"
        '
        'txtInputOperand1
        '
        Me.txtInputOperand1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputOperand1.Location = New System.Drawing.Point(76, 110)
        Me.txtInputOperand1.Name = "txtInputOperand1"
        Me.txtInputOperand1.Size = New System.Drawing.Size(98, 27)
        Me.txtInputOperand1.TabIndex = 1
        '
        'txtInputOperand2
        '
        Me.txtInputOperand2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputOperand2.Location = New System.Drawing.Point(217, 110)
        Me.txtInputOperand2.Name = "txtInputOperand2"
        Me.txtInputOperand2.Size = New System.Drawing.Size(98, 27)
        Me.txtInputOperand2.TabIndex = 2
        '
        'lblOutputResults
        '
        Me.lblOutputResults.AutoSize = True
        Me.lblOutputResults.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputResults.Location = New System.Drawing.Point(82, 161)
        Me.lblOutputResults.Name = "lblOutputResults"
        Me.lblOutputResults.Size = New System.Drawing.Size(273, 22)
        Me.lblOutputResults.TabIndex = 5
        Me.lblOutputResults.Text = "oper1 operation oper2 = ???"
        '
        'btnOneButton
        '
        Me.btnOneButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOneButton.ForeColor = System.Drawing.Color.Black
        Me.btnOneButton.Location = New System.Drawing.Point(65, 207)
        Me.btnOneButton.Name = "btnOneButton"
        Me.btnOneButton.Size = New System.Drawing.Size(44, 44)
        Me.btnOneButton.TabIndex = 9
        Me.btnOneButton.Text = "1"
        Me.btnOneButton.UseVisualStyleBackColor = True
        '
        'btnTwoButton
        '
        Me.btnTwoButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwoButton.ForeColor = System.Drawing.Color.Black
        Me.btnTwoButton.Location = New System.Drawing.Point(135, 207)
        Me.btnTwoButton.Name = "btnTwoButton"
        Me.btnTwoButton.Size = New System.Drawing.Size(44, 44)
        Me.btnTwoButton.TabIndex = 10
        Me.btnTwoButton.Text = "2"
        Me.btnTwoButton.UseVisualStyleBackColor = True
        '
        'btnThreeButton
        '
        Me.btnThreeButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThreeButton.ForeColor = System.Drawing.Color.Black
        Me.btnThreeButton.Location = New System.Drawing.Point(205, 207)
        Me.btnThreeButton.Name = "btnThreeButton"
        Me.btnThreeButton.Size = New System.Drawing.Size(44, 44)
        Me.btnThreeButton.TabIndex = 11
        Me.btnThreeButton.Text = "3"
        Me.btnThreeButton.UseVisualStyleBackColor = True
        '
        'btnAddition
        '
        Me.btnAddition.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddition.ForeColor = System.Drawing.Color.Black
        Me.btnAddition.Location = New System.Drawing.Point(275, 207)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(44, 44)
        Me.btnAddition.TabIndex = 3
        Me.btnAddition.Text = "+"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'btnFourButton
        '
        Me.btnFourButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFourButton.ForeColor = System.Drawing.Color.Black
        Me.btnFourButton.Location = New System.Drawing.Point(65, 273)
        Me.btnFourButton.Name = "btnFourButton"
        Me.btnFourButton.Size = New System.Drawing.Size(44, 44)
        Me.btnFourButton.TabIndex = 12
        Me.btnFourButton.Text = "4"
        Me.btnFourButton.UseVisualStyleBackColor = True
        '
        'btnFiveButton
        '
        Me.btnFiveButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiveButton.ForeColor = System.Drawing.Color.Black
        Me.btnFiveButton.Location = New System.Drawing.Point(135, 273)
        Me.btnFiveButton.Name = "btnFiveButton"
        Me.btnFiveButton.Size = New System.Drawing.Size(44, 44)
        Me.btnFiveButton.TabIndex = 13
        Me.btnFiveButton.Text = "5"
        Me.btnFiveButton.UseVisualStyleBackColor = True
        '
        'btnSixButton
        '
        Me.btnSixButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSixButton.ForeColor = System.Drawing.Color.Black
        Me.btnSixButton.Location = New System.Drawing.Point(205, 273)
        Me.btnSixButton.Name = "btnSixButton"
        Me.btnSixButton.Size = New System.Drawing.Size(44, 44)
        Me.btnSixButton.TabIndex = 14
        Me.btnSixButton.Text = "6"
        Me.btnSixButton.UseVisualStyleBackColor = True
        '
        'btnSubtraction
        '
        Me.btnSubtraction.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtraction.ForeColor = System.Drawing.Color.Black
        Me.btnSubtraction.Location = New System.Drawing.Point(275, 273)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(44, 44)
        Me.btnSubtraction.TabIndex = 4
        Me.btnSubtraction.Text = "-"
        Me.btnSubtraction.UseVisualStyleBackColor = True
        '
        'btnSevenButton
        '
        Me.btnSevenButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSevenButton.ForeColor = System.Drawing.Color.Black
        Me.btnSevenButton.Location = New System.Drawing.Point(65, 339)
        Me.btnSevenButton.Name = "btnSevenButton"
        Me.btnSevenButton.Size = New System.Drawing.Size(44, 44)
        Me.btnSevenButton.TabIndex = 15
        Me.btnSevenButton.Text = "7"
        Me.btnSevenButton.UseVisualStyleBackColor = True
        '
        'btnEightButton
        '
        Me.btnEightButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEightButton.ForeColor = System.Drawing.Color.Black
        Me.btnEightButton.Location = New System.Drawing.Point(135, 339)
        Me.btnEightButton.Name = "btnEightButton"
        Me.btnEightButton.Size = New System.Drawing.Size(44, 44)
        Me.btnEightButton.TabIndex = 16
        Me.btnEightButton.Text = "8"
        Me.btnEightButton.UseVisualStyleBackColor = True
        '
        'btnNineButton
        '
        Me.btnNineButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNineButton.ForeColor = System.Drawing.Color.Black
        Me.btnNineButton.Location = New System.Drawing.Point(205, 339)
        Me.btnNineButton.Name = "btnNineButton"
        Me.btnNineButton.Size = New System.Drawing.Size(44, 44)
        Me.btnNineButton.TabIndex = 17
        Me.btnNineButton.Text = "9"
        Me.btnNineButton.UseVisualStyleBackColor = True
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplication.ForeColor = System.Drawing.Color.Black
        Me.btnMultiplication.Location = New System.Drawing.Point(275, 339)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(44, 44)
        Me.btnMultiplication.TabIndex = 5
        Me.btnMultiplication.Text = "*"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(65, 405)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(44, 44)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "CLR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnZeroButton
        '
        Me.btnZeroButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZeroButton.ForeColor = System.Drawing.Color.Black
        Me.btnZeroButton.Location = New System.Drawing.Point(135, 405)
        Me.btnZeroButton.Name = "btnZeroButton"
        Me.btnZeroButton.Size = New System.Drawing.Size(44, 44)
        Me.btnZeroButton.TabIndex = 18
        Me.btnZeroButton.Text = "0"
        Me.btnZeroButton.UseVisualStyleBackColor = True
        '
        'btnDecimalButton
        '
        Me.btnDecimalButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimalButton.ForeColor = System.Drawing.Color.Black
        Me.btnDecimalButton.Location = New System.Drawing.Point(205, 405)
        Me.btnDecimalButton.Name = "btnDecimalButton"
        Me.btnDecimalButton.Size = New System.Drawing.Size(44, 44)
        Me.btnDecimalButton.TabIndex = 19
        Me.btnDecimalButton.Text = "."
        Me.btnDecimalButton.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.ForeColor = System.Drawing.Color.Black
        Me.btnDivision.Location = New System.Drawing.Point(275, 405)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(44, 44)
        Me.btnDivision.TabIndex = 6
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(120, 468)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(144, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(384, 516)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnDecimalButton)
        Me.Controls.Add(Me.btnZeroButton)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btnNineButton)
        Me.Controls.Add(Me.btnEightButton)
        Me.Controls.Add(Me.btnSevenButton)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.btnSixButton)
        Me.Controls.Add(Me.btnFiveButton)
        Me.Controls.Add(Me.btnFourButton)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.btnThreeButton)
        Me.Controls.Add(Me.btnTwoButton)
        Me.Controls.Add(Me.btnOneButton)
        Me.Controls.Add(Me.lblOutputResults)
        Me.Controls.Add(Me.txtInputOperand2)
        Me.Controls.Add(Me.txtInputOperand1)
        Me.Controls.Add(Me.lblOperand2)
        Me.Controls.Add(Me.lblOperand1)
        Me.Controls.Add(Me.lblHeader)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmMain"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblOperand1 As Label
    Friend WithEvents lblOperand2 As Label
    Friend WithEvents txtInputOperand1 As TextBox
    Friend WithEvents txtInputOperand2 As TextBox
    Friend WithEvents lblOutputResults As Label
    Friend WithEvents btnOneButton As Button
    Friend WithEvents btnTwoButton As Button
    Friend WithEvents btnThreeButton As Button
    Friend WithEvents btnAddition As Button
    Friend WithEvents btnFourButton As Button
    Friend WithEvents btnFiveButton As Button
    Friend WithEvents btnSixButton As Button
    Friend WithEvents btnSubtraction As Button
    Friend WithEvents btnSevenButton As Button
    Friend WithEvents btnEightButton As Button
    Friend WithEvents btnNineButton As Button
    Friend WithEvents btnMultiplication As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnZeroButton As Button
    Friend WithEvents btnDecimalButton As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnExit As Button
End Class
