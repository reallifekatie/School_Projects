<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCityRentals
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
        Me.lstCityNames = New System.Windows.Forms.ListBox()
        Me.lstCityRents = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstCityNames
        '
        Me.lstCityNames.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCityNames.FormattingEnabled = True
        Me.lstCityNames.ItemHeight = 16
        Me.lstCityNames.Location = New System.Drawing.Point(52, 42)
        Me.lstCityNames.Name = "lstCityNames"
        Me.lstCityNames.Size = New System.Drawing.Size(164, 164)
        Me.lstCityNames.TabIndex = 0
        '
        'lstCityRents
        '
        Me.lstCityRents.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCityRents.FormattingEnabled = True
        Me.lstCityRents.ItemHeight = 16
        Me.lstCityRents.Location = New System.Drawing.Point(312, 42)
        Me.lstCityRents.Name = "lstCityRents"
        Me.lstCityRents.Size = New System.Drawing.Size(150, 164)
        Me.lstCityRents.TabIndex = 1
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnReturn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(121, 240)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(296, 79)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return to Rental Cities"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'frmCityRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 349)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstCityRents)
        Me.Controls.Add(Me.lstCityNames)
        Me.Name = "frmCityRentals"
        Me.Text = "City Rentals"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstCityNames As ListBox
    Friend WithEvents lstCityRents As ListBox
    Friend WithEvents btnReturn As Button
End Class
