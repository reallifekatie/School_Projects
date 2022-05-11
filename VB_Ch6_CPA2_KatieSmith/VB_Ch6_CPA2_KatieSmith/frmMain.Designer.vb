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
        Me.btnEnterInternetSpeed = New System.Windows.Forms.Button()
        Me.lstSpeedInputs = New System.Windows.Forms.ListBox()
        Me.lblOutputSpeedAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.White
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(335, 38)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(340, 29)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Internet Speed Test Survey"
        '
        'btnEnterInternetSpeed
        '
        Me.btnEnterInternetSpeed.BackColor = System.Drawing.Color.YellowGreen
        Me.btnEnterInternetSpeed.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterInternetSpeed.Location = New System.Drawing.Point(414, 112)
        Me.btnEnterInternetSpeed.Name = "btnEnterInternetSpeed"
        Me.btnEnterInternetSpeed.Size = New System.Drawing.Size(188, 38)
        Me.btnEnterInternetSpeed.TabIndex = 1
        Me.btnEnterInternetSpeed.Text = "Enter Internet Speed"
        Me.btnEnterInternetSpeed.UseVisualStyleBackColor = False
        '
        'lstSpeedInputs
        '
        Me.lstSpeedInputs.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSpeedInputs.FormattingEnabled = True
        Me.lstSpeedInputs.ItemHeight = 16
        Me.lstSpeedInputs.Location = New System.Drawing.Point(674, 112)
        Me.lstSpeedInputs.Name = "lstSpeedInputs"
        Me.lstSpeedInputs.Size = New System.Drawing.Size(77, 132)
        Me.lstSpeedInputs.TabIndex = 2
        '
        'lblOutputSpeedAverage
        '
        Me.lblOutputSpeedAverage.AutoSize = True
        Me.lblOutputSpeedAverage.BackColor = System.Drawing.Color.White
        Me.lblOutputSpeedAverage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputSpeedAverage.Location = New System.Drawing.Point(443, 374)
        Me.lblOutputSpeedAverage.Name = "lblOutputSpeedAverage"
        Me.lblOutputSpeedAverage.Size = New System.Drawing.Size(317, 19)
        Me.lblOutputSpeedAverage.TabIndex = 3
        Me.lblOutputSpeedAverage.Text = "Average Internet Speed:  XX.XX Mbps"
        Me.lblOutputSpeedAverage.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VB_Ch6_CPA2_KatieSmith.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOutputSpeedAverage)
        Me.Controls.Add(Me.lstSpeedInputs)
        Me.Controls.Add(Me.btnEnterInternetSpeed)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmMain"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents btnEnterInternetSpeed As Button
    Friend WithEvents lstSpeedInputs As ListBox
    Friend WithEvents lblOutputSpeedAverage As Label
End Class
