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
        Me.grpBadges.Location = New System.Drawing.Point(56, 131)
        Me.grpBadges.Name = "grpBadges"
        Me.grpBadges.Size = New System.Drawing.Size(384, 131)
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
        Me.radSuperHero.TabStop = True
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
        Me.radAutographs.TabStop = True
        Me.radAutographs.Text = "Convention + Autographs"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Location = New System.Drawing.Point(6, 97)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(118, 27)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'frmComicConvention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
