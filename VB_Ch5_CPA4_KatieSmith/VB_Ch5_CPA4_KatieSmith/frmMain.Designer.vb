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
        Me.lblEnterNumber = New System.Windows.Forms.Label()
        Me.txtInputNumber = New System.Windows.Forms.TextBox()
        Me.grpConversionType = New System.Windows.Forms.GroupBox()
        Me.radImpToMet = New System.Windows.Forms.RadioButton()
        Me.radMetToImp = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picConstruction = New System.Windows.Forms.PictureBox()
        Me.lblConvertsTo = New System.Windows.Forms.Label()
        Me.grpConversionType.SuspendLayout()
        CType(Me.picConstruction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(24, 18)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(308, 28)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Building Plans Conversion"
        '
        'lblEnterNumber
        '
        Me.lblEnterNumber.AutoSize = True
        Me.lblEnterNumber.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterNumber.Location = New System.Drawing.Point(25, 70)
        Me.lblEnterNumber.Name = "lblEnterNumber"
        Me.lblEnterNumber.Size = New System.Drawing.Size(212, 21)
        Me.lblEnterNumber.TabIndex = 1
        Me.lblEnterNumber.Text = "Enter Number to Convert:"
        '
        'txtInputNumber
        '
        Me.txtInputNumber.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputNumber.Location = New System.Drawing.Point(259, 67)
        Me.txtInputNumber.Name = "txtInputNumber"
        Me.txtInputNumber.Size = New System.Drawing.Size(73, 27)
        Me.txtInputNumber.TabIndex = 2
        Me.txtInputNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpConversionType
        '
        Me.grpConversionType.Controls.Add(Me.radMetToImp)
        Me.grpConversionType.Controls.Add(Me.radImpToMet)
        Me.grpConversionType.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConversionType.Location = New System.Drawing.Point(62, 100)
        Me.grpConversionType.Name = "grpConversionType"
        Me.grpConversionType.Size = New System.Drawing.Size(200, 100)
        Me.grpConversionType.TabIndex = 3
        Me.grpConversionType.TabStop = False
        Me.grpConversionType.Text = "Conversion Options:"
        '
        'radImpToMet
        '
        Me.radImpToMet.AutoSize = True
        Me.radImpToMet.Checked = True
        Me.radImpToMet.Location = New System.Drawing.Point(10, 32)
        Me.radImpToMet.Name = "radImpToMet"
        Me.radImpToMet.Size = New System.Drawing.Size(157, 24)
        Me.radImpToMet.TabIndex = 0
        Me.radImpToMet.TabStop = True
        Me.radImpToMet.Text = "Imperial to Metric"
        Me.radImpToMet.UseVisualStyleBackColor = True
        '
        'radMetToImp
        '
        Me.radMetToImp.AutoSize = True
        Me.radMetToImp.Location = New System.Drawing.Point(10, 67)
        Me.radMetToImp.Name = "radMetToImp"
        Me.radMetToImp.Size = New System.Drawing.Size(157, 24)
        Me.radMetToImp.TabIndex = 1
        Me.radMetToImp.Text = "Metric to Imperial"
        Me.radMetToImp.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(43, 256)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(105, 29)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(206, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 29)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'picConstruction
        '
        Me.picConstruction.Image = Global.VB_Ch5_CPA4_KatieSmith.My.Resources.Resources.construction
        Me.picConstruction.Location = New System.Drawing.Point(361, 4)
        Me.picConstruction.Name = "picConstruction"
        Me.picConstruction.Size = New System.Drawing.Size(436, 300)
        Me.picConstruction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picConstruction.TabIndex = 6
        Me.picConstruction.TabStop = False
        '
        'lblConvertsTo
        '
        Me.lblConvertsTo.AutoSize = True
        Me.lblConvertsTo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertsTo.Location = New System.Drawing.Point(41, 217)
        Me.lblConvertsTo.Name = "lblConvertsTo"
        Me.lblConvertsTo.Size = New System.Drawing.Size(111, 21)
        Me.lblConvertsTo.TabIndex = 7
        Me.lblConvertsTo.Text = "Converts To: "
        Me.lblConvertsTo.Visible = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 294)
        Me.Controls.Add(Me.lblConvertsTo)
        Me.Controls.Add(Me.picConstruction)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpConversionType)
        Me.Controls.Add(Me.txtInputNumber)
        Me.Controls.Add(Me.lblEnterNumber)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmMain"
        Me.Text = "Building Plans Conversion"
        Me.grpConversionType.ResumeLayout(False)
        Me.grpConversionType.PerformLayout()
        CType(Me.picConstruction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblEnterNumber As Label
    Friend WithEvents txtInputNumber As TextBox
    Friend WithEvents grpConversionType As GroupBox
    Friend WithEvents radMetToImp As RadioButton
    Friend WithEvents radImpToMet As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents picConstruction As PictureBox
    Friend WithEvents lblConvertsTo As Label
End Class
