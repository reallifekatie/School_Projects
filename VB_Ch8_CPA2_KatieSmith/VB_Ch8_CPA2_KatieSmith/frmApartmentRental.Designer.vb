<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApartmentRental
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayTopTenCitiesRentalCostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.picRental = New System.Windows.Forms.PictureBox()
        Me.lstCityList = New System.Windows.Forms.ListBox()
        Me.lblSelectedCityHeader = New System.Windows.Forms.Label()
        Me.lblSelectedCityRental = New System.Windows.Forms.Label()
        Me.btnComputeAvgRental = New System.Windows.Forms.Button()
        Me.lblAvgRentalCityCost = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picRental, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblHeader.Location = New System.Drawing.Point(56, 37)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(538, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Two-Bedroom Median Apartment Rental"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(650, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayTopTenCitiesRentalCostToolStripMenuItem, Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'DisplayTopTenCitiesRentalCostToolStripMenuItem
        '
        Me.DisplayTopTenCitiesRentalCostToolStripMenuItem.Name = "DisplayTopTenCitiesRentalCostToolStripMenuItem"
        Me.DisplayTopTenCitiesRentalCostToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.DisplayTopTenCitiesRentalCostToolStripMenuItem.Text = "&Display Top Ten Cities and Rental Cost"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(273, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(273, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'picRental
        '
        Me.picRental.Image = Global.VB_Ch8_CPA2_KatieSmith.My.Resources.Resources.rental
        Me.picRental.Location = New System.Drawing.Point(87, 110)
        Me.picRental.Name = "picRental"
        Me.picRental.Size = New System.Drawing.Size(170, 171)
        Me.picRental.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRental.TabIndex = 2
        Me.picRental.TabStop = False
        '
        'lstCityList
        '
        Me.lstCityList.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCityList.FormattingEnabled = True
        Me.lstCityList.ItemHeight = 17
        Me.lstCityList.Location = New System.Drawing.Point(385, 115)
        Me.lstCityList.Name = "lstCityList"
        Me.lstCityList.Size = New System.Drawing.Size(149, 174)
        Me.lstCityList.TabIndex = 3
        '
        'lblSelectedCityHeader
        '
        Me.lblSelectedCityHeader.AutoSize = True
        Me.lblSelectedCityHeader.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedCityHeader.Location = New System.Drawing.Point(380, 96)
        Me.lblSelectedCityHeader.Name = "lblSelectedCityHeader"
        Me.lblSelectedCityHeader.Size = New System.Drawing.Size(76, 17)
        Me.lblSelectedCityHeader.TabIndex = 4
        Me.lblSelectedCityHeader.Text = "Select City:"
        '
        'lblSelectedCityRental
        '
        Me.lblSelectedCityRental.AutoSize = True
        Me.lblSelectedCityRental.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedCityRental.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblSelectedCityRental.Location = New System.Drawing.Point(147, 301)
        Me.lblSelectedCityRental.Name = "lblSelectedCityRental"
        Me.lblSelectedCityRental.Size = New System.Drawing.Size(356, 18)
        Me.lblSelectedCityRental.TabIndex = 5
        Me.lblSelectedCityRental.Text = "The selected city rental's median cost of $X,XXX"
        Me.lblSelectedCityRental.Visible = False
        '
        'btnComputeAvgRental
        '
        Me.btnComputeAvgRental.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnComputeAvgRental.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeAvgRental.ForeColor = System.Drawing.Color.White
        Me.btnComputeAvgRental.Location = New System.Drawing.Point(185, 336)
        Me.btnComputeAvgRental.Name = "btnComputeAvgRental"
        Me.btnComputeAvgRental.Size = New System.Drawing.Size(281, 37)
        Me.btnComputeAvgRental.TabIndex = 6
        Me.btnComputeAvgRental.Text = "Compute Average Rental"
        Me.btnComputeAvgRental.UseVisualStyleBackColor = False
        Me.btnComputeAvgRental.Visible = False
        '
        'lblAvgRentalCityCost
        '
        Me.lblAvgRentalCityCost.AutoSize = True
        Me.lblAvgRentalCityCost.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRentalCityCost.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblAvgRentalCityCost.Location = New System.Drawing.Point(163, 393)
        Me.lblAvgRentalCityCost.Name = "lblAvgRentalCityCost"
        Me.lblAvgRentalCityCost.Size = New System.Drawing.Size(325, 23)
        Me.lblAvgRentalCityCost.TabIndex = 7
        Me.lblAvgRentalCityCost.Text = "Average Rental City Cost:  $X,XXX"
        Me.lblAvgRentalCityCost.Visible = False
        '
        'frmApartmentRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 450)
        Me.Controls.Add(Me.lblAvgRentalCityCost)
        Me.Controls.Add(Me.btnComputeAvgRental)
        Me.Controls.Add(Me.lblSelectedCityRental)
        Me.Controls.Add(Me.lblSelectedCityHeader)
        Me.Controls.Add(Me.lstCityList)
        Me.Controls.Add(Me.picRental)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmApartmentRental"
        Me.Text = "Apartment Rental by City"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picRental, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents DisplayTopTenCitiesRentalCostToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents picRental As PictureBox
    Friend WithEvents lstCityList As ListBox
    Friend WithEvents lblSelectedCityHeader As Label
    Friend WithEvents lblSelectedCityRental As Label
    Friend WithEvents btnComputeAvgRental As Button
    Friend WithEvents lblAvgRentalCityCost As Label
End Class
