<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGridView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGridView))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pctFleaJumping = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnReplayMovement = New System.Windows.Forms.Button()
        Me.lblTracking = New System.Windows.Forms.Label()
        Me.cboSelectFlea = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSaveAndView = New System.Windows.Forms.Button()
        Me.lblLeast = New System.Windows.Forms.Label()
        Me.lblFurthest = New System.Windows.Forms.Label()
        Me.lblAverageFleas = New System.Windows.Forms.Label()
        Me.lblMaxFleas = New System.Windows.Forms.Label()
        Me.lblFilledCells = New System.Windows.Forms.Label()
        Me.lblEmptyCells = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.prgSimmProgress = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.txtBellRings = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblViewingGrid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pctFleaJumping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pctFleaJumping)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.prgSimmProgress)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblViewingGrid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(630, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 629)
        Me.Panel1.TabIndex = 0
        '
        'pctFleaJumping
        '
        Me.pctFleaJumping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctFleaJumping.Enabled = False
        Me.pctFleaJumping.Image = CType(resources.GetObject("pctFleaJumping.Image"), System.Drawing.Image)
        Me.pctFleaJumping.Location = New System.Drawing.Point(68, 469)
        Me.pctFleaJumping.Name = "pctFleaJumping"
        Me.pctFleaJumping.Size = New System.Drawing.Size(104, 104)
        Me.pctFleaJumping.TabIndex = 5
        Me.pctFleaJumping.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 583)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Simmulation Progress:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnReplayMovement)
        Me.GroupBox3.Controls.Add(Me.lblTracking)
        Me.GroupBox3.Controls.Add(Me.cboSelectFlea)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 354)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(222, 101)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Flea Tracking:"
        '
        'btnReplayMovement
        '
        Me.btnReplayMovement.Enabled = False
        Me.btnReplayMovement.Location = New System.Drawing.Point(41, 70)
        Me.btnReplayMovement.Name = "btnReplayMovement"
        Me.btnReplayMovement.Size = New System.Drawing.Size(136, 23)
        Me.btnReplayMovement.TabIndex = 3
        Me.btnReplayMovement.Text = "Replay Movement"
        Me.btnReplayMovement.UseVisualStyleBackColor = True
        '
        'lblTracking
        '
        Me.lblTracking.AutoSize = True
        Me.lblTracking.Enabled = False
        Me.lblTracking.Location = New System.Drawing.Point(6, 27)
        Me.lblTracking.Name = "lblTracking"
        Me.lblTracking.Size = New System.Drawing.Size(83, 13)
        Me.lblTracking.TabIndex = 2
        Me.lblTracking.Text = "Select a flea:"
        '
        'cboSelectFlea
        '
        Me.cboSelectFlea.Enabled = False
        Me.cboSelectFlea.FormattingEnabled = True
        Me.cboSelectFlea.Location = New System.Drawing.Point(6, 43)
        Me.cboSelectFlea.Name = "cboSelectFlea"
        Me.cboSelectFlea.Size = New System.Drawing.Size(210, 21)
        Me.cboSelectFlea.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveAndView)
        Me.GroupBox2.Controls.Add(Me.lblLeast)
        Me.GroupBox2.Controls.Add(Me.lblFurthest)
        Me.GroupBox2.Controls.Add(Me.lblAverageFleas)
        Me.GroupBox2.Controls.Add(Me.lblMaxFleas)
        Me.GroupBox2.Controls.Add(Me.lblFilledCells)
        Me.GroupBox2.Controls.Add(Me.lblEmptyCells)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 175)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Simmulation Results:"
        '
        'btnSaveAndView
        '
        Me.btnSaveAndView.Enabled = False
        Me.btnSaveAndView.Location = New System.Drawing.Point(24, 140)
        Me.btnSaveAndView.Name = "btnSaveAndView"
        Me.btnSaveAndView.Size = New System.Drawing.Size(178, 23)
        Me.btnSaveAndView.TabIndex = 14
        Me.btnSaveAndView.Text = "&Save and View Scoreboard"
        Me.btnSaveAndView.UseVisualStyleBackColor = True
        '
        'lblLeast
        '
        Me.lblLeast.BackColor = System.Drawing.Color.Black
        Me.lblLeast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLeast.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeast.ForeColor = System.Drawing.Color.Lime
        Me.lblLeast.Location = New System.Drawing.Point(144, 109)
        Me.lblLeast.Name = "lblLeast"
        Me.lblLeast.Size = New System.Drawing.Size(50, 15)
        Me.lblLeast.TabIndex = 13
        Me.lblLeast.Text = "Label16"
        '
        'lblFurthest
        '
        Me.lblFurthest.BackColor = System.Drawing.Color.Black
        Me.lblFurthest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFurthest.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFurthest.ForeColor = System.Drawing.Color.Lime
        Me.lblFurthest.Location = New System.Drawing.Point(144, 94)
        Me.lblFurthest.Name = "lblFurthest"
        Me.lblFurthest.Size = New System.Drawing.Size(50, 15)
        Me.lblFurthest.TabIndex = 12
        Me.lblFurthest.Text = "Label15"
        '
        'lblAverageFleas
        '
        Me.lblAverageFleas.BackColor = System.Drawing.Color.Black
        Me.lblAverageFleas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageFleas.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageFleas.ForeColor = System.Drawing.Color.Lime
        Me.lblAverageFleas.Location = New System.Drawing.Point(144, 73)
        Me.lblAverageFleas.Name = "lblAverageFleas"
        Me.lblAverageFleas.Size = New System.Drawing.Size(50, 15)
        Me.lblAverageFleas.TabIndex = 11
        Me.lblAverageFleas.Text = "Label14"
        '
        'lblMaxFleas
        '
        Me.lblMaxFleas.BackColor = System.Drawing.Color.Black
        Me.lblMaxFleas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaxFleas.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxFleas.ForeColor = System.Drawing.Color.Lime
        Me.lblMaxFleas.Location = New System.Drawing.Point(144, 58)
        Me.lblMaxFleas.Name = "lblMaxFleas"
        Me.lblMaxFleas.Size = New System.Drawing.Size(50, 15)
        Me.lblMaxFleas.TabIndex = 10
        Me.lblMaxFleas.Text = "Label13"
        '
        'lblFilledCells
        '
        Me.lblFilledCells.BackColor = System.Drawing.Color.Black
        Me.lblFilledCells.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFilledCells.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilledCells.ForeColor = System.Drawing.Color.Lime
        Me.lblFilledCells.Location = New System.Drawing.Point(144, 36)
        Me.lblFilledCells.Name = "lblFilledCells"
        Me.lblFilledCells.Size = New System.Drawing.Size(50, 15)
        Me.lblFilledCells.TabIndex = 9
        Me.lblFilledCells.Text = "Label12"
        '
        'lblEmptyCells
        '
        Me.lblEmptyCells.BackColor = System.Drawing.Color.Black
        Me.lblEmptyCells.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmptyCells.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmptyCells.ForeColor = System.Drawing.Color.Lime
        Me.lblEmptyCells.Location = New System.Drawing.Point(144, 20)
        Me.lblEmptyCells.Name = "lblEmptyCells"
        Me.lblEmptyCells.Size = New System.Drawing.Size(50, 15)
        Me.lblEmptyCells.TabIndex = 8
        Me.lblEmptyCells.Text = "999999"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Leaset distance:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Furthest distance:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Average fleas per cell:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Max fleas ever in a cell: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Filled cells:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Empty cells:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'prgSimmProgress
        '
        Me.prgSimmProgress.Location = New System.Drawing.Point(12, 599)
        Me.prgSimmProgress.Name = "prgSimmProgress"
        Me.prgSimmProgress.Size = New System.Drawing.Size(210, 23)
        Me.prgSimmProgress.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnBegin)
        Me.GroupBox1.Controls.Add(Me.txtBellRings)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 92)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Simulation Controls:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(143, 61)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnBegin
        '
        Me.btnBegin.Location = New System.Drawing.Point(6, 61)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(75, 23)
        Me.btnBegin.TabIndex = 2
        Me.btnBegin.Text = "Begin"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'txtBellRings
        '
        Me.txtBellRings.Location = New System.Drawing.Point(81, 29)
        Me.txtBellRings.Name = "txtBellRings"
        Me.txtBellRings.Size = New System.Drawing.Size(137, 20)
        Me.txtBellRings.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bell Rings:"
        '
        'lblViewingGrid
        '
        Me.lblViewingGrid.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblViewingGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewingGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewingGrid.ForeColor = System.Drawing.Color.Black
        Me.lblViewingGrid.Location = New System.Drawing.Point(3, 29)
        Me.lblViewingGrid.Name = "lblViewingGrid"
        Me.lblViewingGrid.Size = New System.Drawing.Size(225, 29)
        Me.lblViewingGrid.TabIndex = 1
        Me.lblViewingGrid.Text = "Uni-matrix01"
        Me.lblViewingGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currently viewing Grid:"
        '
        'frmGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 631)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmGridView"
        Me.Text = "Grid View: Uni-matrix01"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pctFleaJumping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblViewingGrid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBellRings As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReplayMovement As System.Windows.Forms.Button
    Friend WithEvents lblTracking As System.Windows.Forms.Label
    Friend WithEvents cboSelectFlea As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLeast As System.Windows.Forms.Label
    Friend WithEvents lblFurthest As System.Windows.Forms.Label
    Friend WithEvents lblAverageFleas As System.Windows.Forms.Label
    Friend WithEvents lblMaxFleas As System.Windows.Forms.Label
    Friend WithEvents lblFilledCells As System.Windows.Forms.Label
    Friend WithEvents lblEmptyCells As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents prgSimmProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnBegin As System.Windows.Forms.Button
    Friend WithEvents pctFleaJumping As System.Windows.Forms.PictureBox
    Friend WithEvents btnSaveAndView As System.Windows.Forms.Button
End Class
