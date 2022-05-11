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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblOutputText = New System.Windows.Forms.Label()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.cboKaraokeSelection = New System.Windows.Forms.ComboBox()
        Me.lblRequestToUser = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblOutputText)
        Me.Panel1.Controls.Add(Me.btnClearForm)
        Me.Panel1.Controls.Add(Me.btnTotalCost)
        Me.Panel1.Controls.Add(Me.txtUserInput)
        Me.Panel1.Controls.Add(Me.cboKaraokeSelection)
        Me.Panel1.Controls.Add(Me.lblRequestToUser)
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Location = New System.Drawing.Point(342, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 448)
        Me.Panel1.TabIndex = 0
        '
        'lblOutputText
        '
        Me.lblOutputText.AutoSize = True
        Me.lblOutputText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputText.ForeColor = System.Drawing.Color.White
        Me.lblOutputText.Location = New System.Drawing.Point(44, 376)
        Me.lblOutputText.Name = "lblOutputText"
        Me.lblOutputText.Size = New System.Drawing.Size(369, 25)
        Me.lblOutputText.TabIndex = 6
        Me.lblOutputText.Text = "Total Cost of Karaoke Night - $XX.XX"
        '
        'btnClearForm
        '
        Me.btnClearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.Location = New System.Drawing.Point(256, 301)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(138, 37)
        Me.btnClearForm.TabIndex = 5
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnTotalCost
        '
        Me.btnTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalCost.Location = New System.Drawing.Point(63, 301)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(138, 37)
        Me.btnTotalCost.TabIndex = 4
        Me.btnTotalCost.Text = "Total Cost"
        Me.btnTotalCost.UseVisualStyleBackColor = True
        '
        'txtUserInput
        '
        Me.txtUserInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInput.Location = New System.Drawing.Point(209, 239)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(38, 26)
        Me.txtUserInput.TabIndex = 3
        Me.txtUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboKaraokeSelection
        '
        Me.cboKaraokeSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKaraokeSelection.FormattingEnabled = True
        Me.cboKaraokeSelection.Items.AddRange(New Object() {"Hours in Private Karaoke Booth ($8.99 per hour)", "Songs in Private Karaoke Booth ($2.99 per song)"})
        Me.cboKaraokeSelection.Location = New System.Drawing.Point(38, 114)
        Me.cboKaraokeSelection.Name = "cboKaraokeSelection"
        Me.cboKaraokeSelection.Size = New System.Drawing.Size(381, 28)
        Me.cboKaraokeSelection.TabIndex = 2
        Me.cboKaraokeSelection.Text = "Make Your Selection:"
        '
        'lblRequestToUser
        '
        Me.lblRequestToUser.AutoSize = True
        Me.lblRequestToUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequestToUser.ForeColor = System.Drawing.Color.White
        Me.lblRequestToUser.Location = New System.Drawing.Point(89, 183)
        Me.lblRequestToUser.Name = "lblRequestToUser"
        Me.lblRequestToUser.Size = New System.Drawing.Size(278, 24)
        Me.lblRequestToUser.TabIndex = 1
        Me.lblRequestToUser.Text = "Hourly Rental of Karaoke Room:"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(62, 30)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(332, 37)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Karaoke Music Night"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnTotalCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VB_Ch7_CPA2_KatieSmith.My.Resources.Resources.karaoke
        Me.CancelButton = Me.btnClearForm
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMain"
        Me.Text = "Karaoke Music Night"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblOutputText As Label
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents cboKaraokeSelection As ComboBox
    Friend WithEvents lblRequestToUser As Label
    Friend WithEvents lblHeader As Label
End Class
