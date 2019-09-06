<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicConvention
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblAttendees = New System.Windows.Forms.Label()
        Me.txtAttendees = New System.Windows.Forms.TextBox()
        Me.grpBadges = New System.Windows.Forms.GroupBox()
        Me.radSuperHero = New System.Windows.Forms.RadioButton()
        Me.radAutographs = New System.Windows.Forms.RadioButton()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpBadges.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Sienna
        Me.lblHeading.Location = New System.Drawing.Point(96, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(258, 36)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Comic Convention"
        '
        'lblAttendees
        '
        Me.lblAttendees.AutoSize = True
        Me.lblAttendees.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendees.ForeColor = System.Drawing.Color.Sienna
        Me.lblAttendees.Location = New System.Drawing.Point(70, 74)
        Me.lblAttendees.Name = "lblAttendees"
        Me.lblAttendees.Size = New System.Drawing.Size(209, 25)
        Me.lblAttendees.TabIndex = 1
        Me.lblAttendees.Text = "Group Member Count:"
        '
        'txtAttendees
        '
        Me.txtAttendees.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttendees.Location = New System.Drawing.Point(285, 71)
        Me.txtAttendees.Name = "txtAttendees"
        Me.txtAttendees.Size = New System.Drawing.Size(58, 33)
        Me.txtAttendees.TabIndex = 2
        '
        'grpBadges
        '
        Me.grpBadges.BackColor = System.Drawing.Color.AliceBlue
        Me.grpBadges.Controls.Add(Me.radConvention)
        Me.grpBadges.Controls.Add(Me.radAutographs)
        Me.grpBadges.Controls.Add(Me.radSuperHero)
        Me.grpBadges.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadges.ForeColor = System.Drawing.Color.Sienna
        Me.grpBadges.Location = New System.Drawing.Point(48, 110)
        Me.grpBadges.Name = "grpBadges"
        Me.grpBadges.Size = New System.Drawing.Size(320, 131)
        Me.grpBadges.TabIndex = 3
        Me.grpBadges.TabStop = False
        Me.grpBadges.Text = "Badge Type"
        '
        'radSuperHero
        '
        Me.radSuperHero.AutoSize = True
        Me.radSuperHero.Location = New System.Drawing.Point(6, 29)
        Me.radSuperHero.Name = "radSuperHero"
        Me.radSuperHero.Size = New System.Drawing.Size(306, 27)
        Me.radSuperHero.TabIndex = 0
        Me.radSuperHero.Text = "Convention + Superhero Experience"
        Me.radSuperHero.UseVisualStyleBackColor = True
        '
        'radAutographs
        '
        Me.radAutographs.AutoSize = True
        Me.radAutographs.Location = New System.Drawing.Point(6, 63)
        Me.radAutographs.Name = "radAutographs"
        Me.radAutographs.Size = New System.Drawing.Size(226, 27)
        Me.radAutographs.TabIndex = 1
        Me.radAutographs.Text = "Convention + Autographs"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Checked = True
        Me.radConvention.Location = New System.Drawing.Point(6, 97)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(118, 27)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Sienna
        Me.lblCost.Location = New System.Drawing.Point(49, 261)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(105, 25)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Total Cost:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.Sienna
        Me.lblTotalCost.Location = New System.Drawing.Point(267, 261)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(93, 25)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Sienna
        Me.btnCalculate.Location = New System.Drawing.Point(36, 310)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(118, 38)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmComicConvention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.grpBadges)
        Me.Controls.Add(Me.txtAttendees)
        Me.Controls.Add(Me.lblAttendees)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmComicConvention"
        Me.Text = "Comic Convention"
        Me.grpBadges.ResumeLayout(False)
        Me.grpBadges.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblAttendees As Label
    Friend WithEvents txtAttendees As TextBox
    Friend WithEvents grpBadges As GroupBox
    Friend WithEvents radSuperHero As RadioButton
    Friend WithEvents radAutographs As RadioButton
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
End Class
