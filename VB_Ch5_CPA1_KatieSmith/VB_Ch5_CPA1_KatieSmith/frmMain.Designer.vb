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
        Me.lblEnterWeight = New System.Windows.Forms.Label()
        Me.txtInputWeight = New System.Windows.Forms.TextBox()
        Me.grpConvertWeight = New System.Windows.Forms.GroupBox()
        Me.radVenusWeight = New System.Windows.Forms.RadioButton()
        Me.radMarsWeight = New System.Windows.Forms.RadioButton()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOutputResults = New System.Windows.Forms.Label()
        Me.picPlanets = New System.Windows.Forms.PictureBox()
        Me.grpConvertWeight.SuspendLayout()
        CType(Me.picPlanets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(490, 26)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(215, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Venus or Mars?"
        '
        'lblEnterWeight
        '
        Me.lblEnterWeight.AutoSize = True
        Me.lblEnterWeight.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterWeight.Location = New System.Drawing.Point(455, 83)
        Me.lblEnterWeight.Name = "lblEnterWeight"
        Me.lblEnterWeight.Size = New System.Drawing.Size(131, 22)
        Me.lblEnterWeight.TabIndex = 1
        Me.lblEnterWeight.Text = "Enter Weight:"
        '
        'txtInputWeight
        '
        Me.txtInputWeight.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputWeight.Location = New System.Drawing.Point(664, 80)
        Me.txtInputWeight.Name = "txtInputWeight"
        Me.txtInputWeight.Size = New System.Drawing.Size(72, 31)
        Me.txtInputWeight.TabIndex = 2
        Me.txtInputWeight.Text = "xxx"
        Me.txtInputWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpConvertWeight
        '
        Me.grpConvertWeight.BackColor = System.Drawing.Color.White
        Me.grpConvertWeight.Controls.Add(Me.radMarsWeight)
        Me.grpConvertWeight.Controls.Add(Me.radVenusWeight)
        Me.grpConvertWeight.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConvertWeight.Location = New System.Drawing.Point(473, 146)
        Me.grpConvertWeight.Name = "grpConvertWeight"
        Me.grpConvertWeight.Size = New System.Drawing.Size(263, 120)
        Me.grpConvertWeight.TabIndex = 3
        Me.grpConvertWeight.TabStop = False
        Me.grpConvertWeight.Text = "Convert Weight"
        '
        'radVenusWeight
        '
        Me.radVenusWeight.AutoSize = True
        Me.radVenusWeight.Checked = True
        Me.radVenusWeight.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVenusWeight.Location = New System.Drawing.Point(7, 30)
        Me.radVenusWeight.Name = "radVenusWeight"
        Me.radVenusWeight.Size = New System.Drawing.Size(225, 25)
        Me.radVenusWeight.TabIndex = 0
        Me.radVenusWeight.TabStop = True
        Me.radVenusWeight.Text = "Convert to Venus Weight"
        Me.radVenusWeight.UseVisualStyleBackColor = True
        '
        'radMarsWeight
        '
        Me.radMarsWeight.AutoSize = True
        Me.radMarsWeight.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMarsWeight.Location = New System.Drawing.Point(7, 64)
        Me.radMarsWeight.Name = "radMarsWeight"
        Me.radMarsWeight.Size = New System.Drawing.Size(215, 25)
        Me.radMarsWeight.TabIndex = 1
        Me.radMarsWeight.Text = "Convert to Mars Weight"
        Me.radMarsWeight.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Gold
        Me.btnDisplay.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(473, 305)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(99, 32)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gold
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(637, 305)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 32)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblOutputResults
        '
        Me.lblOutputResults.AutoSize = True
        Me.lblOutputResults.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputResults.Location = New System.Drawing.Point(415, 382)
        Me.lblOutputResults.Name = "lblOutputResults"
        Me.lblOutputResults.Size = New System.Drawing.Size(310, 19)
        Me.lblOutputResults.TabIndex = 6
        Me.lblOutputResults.Text = "Your weight on XXX is XXX lbs or XX kg."
        '
        'picPlanets
        '
        Me.picPlanets.Image = Global.VB_Ch5_CPA1_KatieSmith.My.Resources.Resources.planets
        Me.picPlanets.Location = New System.Drawing.Point(2, 2)
        Me.picPlanets.Name = "picPlanets"
        Me.picPlanets.Size = New System.Drawing.Size(383, 446)
        Me.picPlanets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlanets.TabIndex = 7
        Me.picPlanets.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picPlanets)
        Me.Controls.Add(Me.lblOutputResults)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.grpConvertWeight)
        Me.Controls.Add(Me.txtInputWeight)
        Me.Controls.Add(Me.lblEnterWeight)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmMain"
        Me.Text = "Planetary Weight"
        Me.grpConvertWeight.ResumeLayout(False)
        Me.grpConvertWeight.PerformLayout()
        CType(Me.picPlanets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblEnterWeight As Label
    Friend WithEvents txtInputWeight As TextBox
    Friend WithEvents grpConvertWeight As GroupBox
    Friend WithEvents radMarsWeight As RadioButton
    Friend WithEvents radVenusWeight As RadioButton
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblOutputResults As Label
    Friend WithEvents picPlanets As PictureBox
End Class
