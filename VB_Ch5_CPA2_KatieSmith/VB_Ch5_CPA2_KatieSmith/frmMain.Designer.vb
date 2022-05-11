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
        Me.picComics = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtInputGroupSize = New System.Windows.Forms.TextBox()
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.radConvHero = New System.Windows.Forms.RadioButton()
        Me.radConvAuto = New System.Windows.Forms.RadioButton()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.lblRegCost = New System.Windows.Forms.Label()
        Me.lblOutputRegCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picComics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadgeType.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComics
        '
        Me.picComics.Image = Global.VB_Ch5_CPA2_KatieSmith.My.Resources.Resources.comic
        Me.picComics.Location = New System.Drawing.Point(1, 2)
        Me.picComics.Name = "picComics"
        Me.picComics.Size = New System.Drawing.Size(590, 186)
        Me.picComics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComics.TabIndex = 0
        Me.picComics.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Sienna
        Me.lblHeader.Location = New System.Drawing.Point(68, 208)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(471, 34)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Comic Convention Registration"
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Sienna
        Me.lblGroupSize.Location = New System.Drawing.Point(124, 267)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(104, 19)
        Me.lblGroupSize.TabIndex = 2
        Me.lblGroupSize.Text = "Group Size:"
        '
        'txtInputGroupSize
        '
        Me.txtInputGroupSize.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputGroupSize.ForeColor = System.Drawing.Color.Sienna
        Me.txtInputGroupSize.Location = New System.Drawing.Point(335, 260)
        Me.txtInputGroupSize.Name = "txtInputGroupSize"
        Me.txtInputGroupSize.Size = New System.Drawing.Size(71, 26)
        Me.txtInputGroupSize.TabIndex = 3
        Me.txtInputGroupSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpBadgeType
        '
        Me.grpBadgeType.BackColor = System.Drawing.Color.PaleTurquoise
        Me.grpBadgeType.Controls.Add(Me.radConvention)
        Me.grpBadgeType.Controls.Add(Me.radConvAuto)
        Me.grpBadgeType.Controls.Add(Me.radConvHero)
        Me.grpBadgeType.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.ForeColor = System.Drawing.Color.Sienna
        Me.grpBadgeType.Location = New System.Drawing.Point(127, 315)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(336, 100)
        Me.grpBadgeType.TabIndex = 4
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type:"
        '
        'radConvHero
        '
        Me.radConvHero.AutoSize = True
        Me.radConvHero.Location = New System.Drawing.Point(7, 20)
        Me.radConvHero.Name = "radConvHero"
        Me.radConvHero.Size = New System.Drawing.Size(322, 23)
        Me.radConvHero.TabIndex = 0
        Me.radConvHero.Text = "Convention + Superhero Experience"
        Me.radConvHero.UseVisualStyleBackColor = True
        '
        'radConvAuto
        '
        Me.radConvAuto.AutoSize = True
        Me.radConvAuto.Location = New System.Drawing.Point(7, 44)
        Me.radConvAuto.Name = "radConvAuto"
        Me.radConvAuto.Size = New System.Drawing.Size(239, 23)
        Me.radConvAuto.TabIndex = 1
        Me.radConvAuto.Text = "Convention + Autographs"
        Me.radConvAuto.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Checked = True
        Me.radConvention.Location = New System.Drawing.Point(7, 68)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(123, 23)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'lblRegCost
        '
        Me.lblRegCost.AutoSize = True
        Me.lblRegCost.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegCost.ForeColor = System.Drawing.Color.Sienna
        Me.lblRegCost.Location = New System.Drawing.Point(130, 446)
        Me.lblRegCost.Name = "lblRegCost"
        Me.lblRegCost.Size = New System.Drawing.Size(186, 21)
        Me.lblRegCost.TabIndex = 5
        Me.lblRegCost.Text = "Registration Cost:"
        Me.lblRegCost.Visible = False
        '
        'lblOutputRegCost
        '
        Me.lblOutputRegCost.AutoSize = True
        Me.lblOutputRegCost.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputRegCost.ForeColor = System.Drawing.Color.Sienna
        Me.lblOutputRegCost.Location = New System.Drawing.Point(368, 446)
        Me.lblOutputRegCost.Name = "lblOutputRegCost"
        Me.lblOutputRegCost.Size = New System.Drawing.Size(0, 21)
        Me.lblOutputRegCost.TabIndex = 6
        Me.lblOutputRegCost.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnCalculate.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(128, 499)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(142, 39)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(321, 499)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(146, 39)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(584, 550)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblOutputRegCost)
        Me.Controls.Add(Me.lblRegCost)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.txtInputGroupSize)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picComics)
        Me.Name = "frmMain"
        Me.Text = "Comic Convention Registration"
        CType(Me.picComics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComics As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtInputGroupSize As TextBox
    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radConvAuto As RadioButton
    Friend WithEvents radConvHero As RadioButton
    Friend WithEvents lblRegCost As Label
    Friend WithEvents lblOutputRegCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
