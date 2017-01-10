<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScoreBoard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstEmpty = New System.Windows.Forms.ListBox()
        Me.lstFilled = New System.Windows.Forms.ListBox()
        Me.lstMax = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstAverage = New System.Windows.Forms.ListBox()
        Me.lstFurthest = New System.Windows.Forms.ListBox()
        Me.lstLeast = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Top 5 - Empty Cells"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Top 5 - Filled Cells"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Top 5 - Max Fleas In a Cell"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(303, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Top 5 - Average Fleas Per Cell"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Top 5 - Furthest Distance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(303, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Top 5 - Least Distance"
        '
        'lstEmpty
        '
        Me.lstEmpty.FormattingEnabled = True
        Me.lstEmpty.Location = New System.Drawing.Point(15, 79)
        Me.lstEmpty.Name = "lstEmpty"
        Me.lstEmpty.Size = New System.Drawing.Size(247, 95)
        Me.lstEmpty.TabIndex = 6
        '
        'lstFilled
        '
        Me.lstFilled.FormattingEnabled = True
        Me.lstFilled.Location = New System.Drawing.Point(306, 79)
        Me.lstFilled.Name = "lstFilled"
        Me.lstFilled.Size = New System.Drawing.Size(247, 95)
        Me.lstFilled.TabIndex = 7
        '
        'lstMax
        '
        Me.lstMax.FormattingEnabled = True
        Me.lstMax.Location = New System.Drawing.Point(15, 201)
        Me.lstMax.Name = "lstMax"
        Me.lstMax.Size = New System.Drawing.Size(247, 95)
        Me.lstMax.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(69, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(425, 34)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Scoreboard For 12 Bell Rings"
        '
        'lstAverage
        '
        Me.lstAverage.FormattingEnabled = True
        Me.lstAverage.Location = New System.Drawing.Point(306, 201)
        Me.lstAverage.Name = "lstAverage"
        Me.lstAverage.Size = New System.Drawing.Size(247, 95)
        Me.lstAverage.TabIndex = 10
        '
        'lstFurthest
        '
        Me.lstFurthest.FormattingEnabled = True
        Me.lstFurthest.Location = New System.Drawing.Point(15, 323)
        Me.lstFurthest.Name = "lstFurthest"
        Me.lstFurthest.Size = New System.Drawing.Size(247, 95)
        Me.lstFurthest.TabIndex = 11
        '
        'lstLeast
        '
        Me.lstLeast.FormattingEnabled = True
        Me.lstLeast.Location = New System.Drawing.Point(306, 323)
        Me.lstLeast.Name = "lstLeast"
        Me.lstLeast.Size = New System.Drawing.Size(247, 95)
        Me.lstLeast.TabIndex = 12
        '
        'frmScoreBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 430)
        Me.Controls.Add(Me.lstLeast)
        Me.Controls.Add(Me.lstFurthest)
        Me.Controls.Add(Me.lstAverage)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lstMax)
        Me.Controls.Add(Me.lstFilled)
        Me.Controls.Add(Me.lstEmpty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScoreBoard"
        Me.Text = "Scoreboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstEmpty As System.Windows.Forms.ListBox
    Friend WithEvents lstFilled As System.Windows.Forms.ListBox
    Friend WithEvents lstMax As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lstAverage As System.Windows.Forms.ListBox
    Friend WithEvents lstFurthest As System.Windows.Forms.ListBox
    Friend WithEvents lstLeast As System.Windows.Forms.ListBox
End Class
