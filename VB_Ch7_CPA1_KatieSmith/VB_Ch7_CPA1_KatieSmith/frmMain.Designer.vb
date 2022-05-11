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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTicketCost = New System.Windows.Forms.Button()
        Me.txtNumberOfTickets = New System.Windows.Forms.TextBox()
        Me.lblNumberOfTickets = New System.Windows.Forms.Label()
        Me.cboTicketType = New System.Windows.Forms.ComboBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblOutputText)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnTicketCost)
        Me.Panel1.Controls.Add(Me.txtNumberOfTickets)
        Me.Panel1.Controls.Add(Me.lblNumberOfTickets)
        Me.Panel1.Controls.Add(Me.cboTicketType)
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Location = New System.Drawing.Point(395, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 448)
        Me.Panel1.TabIndex = 0
        '
        'lblOutputText
        '
        Me.lblOutputText.AutoSize = True
        Me.lblOutputText.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lblOutputText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputText.ForeColor = System.Drawing.Color.White
        Me.lblOutputText.Location = New System.Drawing.Point(108, 368)
        Me.lblOutputText.Name = "lblOutputText"
        Me.lblOutputText.Size = New System.Drawing.Size(188, 20)
        Me.lblOutputText.TabIndex = 6
        Me.lblOutputText.Text = "$XX.XX for the tickets"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(126, 282)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(153, 38)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnTicketCost
        '
        Me.btnTicketCost.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnTicketCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTicketCost.ForeColor = System.Drawing.Color.White
        Me.btnTicketCost.Location = New System.Drawing.Point(126, 228)
        Me.btnTicketCost.Name = "btnTicketCost"
        Me.btnTicketCost.Size = New System.Drawing.Size(153, 38)
        Me.btnTicketCost.TabIndex = 4
        Me.btnTicketCost.Text = "Ticket Cost"
        Me.btnTicketCost.UseVisualStyleBackColor = False
        '
        'txtNumberOfTickets
        '
        Me.txtNumberOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfTickets.Location = New System.Drawing.Point(185, 162)
        Me.txtNumberOfTickets.Name = "txtNumberOfTickets"
        Me.txtNumberOfTickets.Size = New System.Drawing.Size(35, 26)
        Me.txtNumberOfTickets.TabIndex = 3
        Me.txtNumberOfTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumberOfTickets
        '
        Me.lblNumberOfTickets.AutoSize = True
        Me.lblNumberOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfTickets.Location = New System.Drawing.Point(123, 132)
        Me.lblNumberOfTickets.Name = "lblNumberOfTickets"
        Me.lblNumberOfTickets.Size = New System.Drawing.Size(159, 20)
        Me.lblNumberOfTickets.TabIndex = 2
        Me.lblNumberOfTickets.Text = "Number of Tickets:"
        '
        'cboTicketType
        '
        Me.cboTicketType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTicketType.FormattingEnabled = True
        Me.cboTicketType.Items.AddRange(New Object() {"Matinee  $16", "Evening  $27"})
        Me.cboTicketType.Location = New System.Drawing.Point(115, 79)
        Me.cboTicketType.Name = "cboTicketType"
        Me.cboTicketType.Size = New System.Drawing.Size(174, 28)
        Me.cboTicketType.TabIndex = 1
        Me.cboTicketType.Text = "Select Ticket Type"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(41, 23)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(343, 37)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "IMAX Theatre Tickets"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VB_Ch7_CPA1_KatieSmith.My.Resources.Resources.imax
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMain"
        Me.Text = "Purchase IMAX Theatre Tickets"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblOutputText As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnTicketCost As Button
    Friend WithEvents txtNumberOfTickets As TextBox
    Friend WithEvents lblNumberOfTickets As Label
    Friend WithEvents cboTicketType As ComboBox
    Friend WithEvents lblHeader As Label
End Class
