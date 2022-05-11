<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartHome
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboSelectMonth = New System.Windows.Forms.ComboBox()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.lblElectricSavings = New System.Windows.Forms.Label()
        Me.btnDisplayStats = New System.Windows.Forms.Button()
        Me.lblAvgMonthSavings = New System.Windows.Forms.Label()
        Me.lblMostSignificant = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(353, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(241, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Smart Home"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VB_Ch8_CPA1_KatieSmith.My.Resources.Resources.smarthome
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 275)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'cboSelectMonth
        '
        Me.cboSelectMonth.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectMonth.FormattingEnabled = True
        Me.cboSelectMonth.Location = New System.Drawing.Point(390, 160)
        Me.cboSelectMonth.Name = "cboSelectMonth"
        Me.cboSelectMonth.Size = New System.Drawing.Size(158, 26)
        Me.cboSelectMonth.TabIndex = 6
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.Location = New System.Drawing.Point(332, 86)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(302, 38)
        Me.lblTitle2.TabIndex = 7
        Me.lblTitle2.Text = "Electric Savings"
        '
        'lblElectricSavings
        '
        Me.lblElectricSavings.AutoSize = True
        Me.lblElectricSavings.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElectricSavings.Location = New System.Drawing.Point(134, 304)
        Me.lblElectricSavings.Name = "lblElectricSavings"
        Me.lblElectricSavings.Size = New System.Drawing.Size(18, 18)
        Me.lblElectricSavings.TabIndex = 8
        Me.lblElectricSavings.Text = "x"
        Me.lblElectricSavings.Visible = False
        '
        'btnDisplayStats
        '
        Me.btnDisplayStats.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDisplayStats.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayStats.ForeColor = System.Drawing.Color.White
        Me.btnDisplayStats.Location = New System.Drawing.Point(192, 337)
        Me.btnDisplayStats.Name = "btnDisplayStats"
        Me.btnDisplayStats.Size = New System.Drawing.Size(232, 38)
        Me.btnDisplayStats.TabIndex = 9
        Me.btnDisplayStats.Text = "Display Statistics"
        Me.btnDisplayStats.UseVisualStyleBackColor = False
        '
        'lblAvgMonthSavings
        '
        Me.lblAvgMonthSavings.AutoSize = True
        Me.lblAvgMonthSavings.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgMonthSavings.Location = New System.Drawing.Point(175, 404)
        Me.lblAvgMonthSavings.Name = "lblAvgMonthSavings"
        Me.lblAvgMonthSavings.Size = New System.Drawing.Size(287, 18)
        Me.lblAvgMonthSavings.TabIndex = 10
        Me.lblAvgMonthSavings.Text = "The average monthly savings: $"
        Me.lblAvgMonthSavings.Visible = False
        '
        'lblMostSignificant
        '
        Me.lblMostSignificant.AutoSize = True
        Me.lblMostSignificant.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostSignificant.Location = New System.Drawing.Point(110, 444)
        Me.lblMostSignificant.Name = "lblMostSignificant"
        Me.lblMostSignificant.Size = New System.Drawing.Size(402, 18)
        Me.lblMostSignificant.TabIndex = 11
        Me.lblMostSignificant.Text = "XXX had the most significant monthly savings"
        Me.lblMostSignificant.Visible = False
        '
        'frmSmartHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(650, 490)
        Me.Controls.Add(Me.lblMostSignificant)
        Me.Controls.Add(Me.lblAvgMonthSavings)
        Me.Controls.Add(Me.btnDisplayStats)
        Me.Controls.Add(Me.lblElectricSavings)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.cboSelectMonth)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmSmartHome"
        Me.Text = "Smart Home Application"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboSelectMonth As ComboBox
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents lblElectricSavings As Label
    Friend WithEvents btnDisplayStats As Button
    Friend WithEvents lblAvgMonthSavings As Label
    Friend WithEvents lblMostSignificant As Label
End Class
