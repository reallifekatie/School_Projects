<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblRainfallAverage = New System.Windows.Forms.Label()
        Me.btnEnterRainfall = New System.Windows.Forms.Button()
        Me.lblOutputAverageRainfallPerMonth = New System.Windows.Forms.Label()
        Me.lstInputRainfallInches = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblHeader.Location = New System.Drawing.Point(12, 43)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(484, 42)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Most Rainfall in US - Kauai"
        '
        'lblRainfallAverage
        '
        Me.lblRainfallAverage.AutoSize = True
        Me.lblRainfallAverage.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRainfallAverage.ForeColor = System.Drawing.Color.Teal
        Me.lblRainfallAverage.Location = New System.Drawing.Point(206, 108)
        Me.lblRainfallAverage.Name = "lblRainfallAverage"
        Me.lblRainfallAverage.Size = New System.Drawing.Size(111, 18)
        Me.lblRainfallAverage.TabIndex = 1
        Me.lblRainfallAverage.Text = "Rainfall Average"
        '
        'btnEnterRainfall
        '
        Me.btnEnterRainfall.BackColor = System.Drawing.Color.Indigo
        Me.btnEnterRainfall.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterRainfall.Location = New System.Drawing.Point(186, 154)
        Me.btnEnterRainfall.Name = "btnEnterRainfall"
        Me.btnEnterRainfall.Size = New System.Drawing.Size(160, 39)
        Me.btnEnterRainfall.TabIndex = 2
        Me.btnEnterRainfall.Text = "Enter Rainfall"
        Me.btnEnterRainfall.UseVisualStyleBackColor = False
        '
        'lblOutputAverageRainfallPerMonth
        '
        Me.lblOutputAverageRainfallPerMonth.AutoSize = True
        Me.lblOutputAverageRainfallPerMonth.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputAverageRainfallPerMonth.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblOutputAverageRainfallPerMonth.Location = New System.Drawing.Point(28, 224)
        Me.lblOutputAverageRainfallPerMonth.Name = "lblOutputAverageRainfallPerMonth"
        Me.lblOutputAverageRainfallPerMonth.Size = New System.Drawing.Size(446, 25)
        Me.lblOutputAverageRainfallPerMonth.TabIndex = 3
        Me.lblOutputAverageRainfallPerMonth.Text = "Average Rainfall per Month is XX.X inches"
        '
        'lstInputRainfallInches
        '
        Me.lstInputRainfallInches.FormattingEnabled = True
        Me.lstInputRainfallInches.Location = New System.Drawing.Point(595, 54)
        Me.lstInputRainfallInches.Name = "lstInputRainfallInches"
        Me.lstInputRainfallInches.Size = New System.Drawing.Size(54, 199)
        Me.lstInputRainfallInches.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VB_Ch6_CPA1_KatieSmith.My.Resources.Resources.hawaii
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstInputRainfallInches)
        Me.Controls.Add(Me.lblOutputAverageRainfallPerMonth)
        Me.Controls.Add(Me.btnEnterRainfall)
        Me.Controls.Add(Me.lblRainfallAverage)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Most Rainfall in US"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblRainfallAverage As Label
    Friend WithEvents btnEnterRainfall As Button
    Friend WithEvents lblOutputAverageRainfallPerMonth As Label
    Friend WithEvents lstInputRainfallInches As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
