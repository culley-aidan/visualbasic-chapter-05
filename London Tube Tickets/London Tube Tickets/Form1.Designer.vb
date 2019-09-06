<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLondonTubeTickets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblTicketCount = New System.Windows.Forms.Label()
        Me.txtTicketCount = New System.Windows.Forms.TextBox()
        Me.grpTicketzones = New System.Windows.Forms.GroupBox()
        Me.radZones13 = New System.Windows.Forms.RadioButton()
        Me.radZones15 = New System.Windows.Forms.RadioButton()
        Me.radZones16 = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpTicketzones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Sienna
        Me.lblHeading.Location = New System.Drawing.Point(12, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(284, 36)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "London Tube Tickets"
        '
        'lblTicketCount
        '
        Me.lblTicketCount.AutoSize = True
        Me.lblTicketCount.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketCount.ForeColor = System.Drawing.Color.Sienna
        Me.lblTicketCount.Location = New System.Drawing.Point(13, 82)
        Me.lblTicketCount.Name = "lblTicketCount"
        Me.lblTicketCount.Size = New System.Drawing.Size(179, 25)
        Me.lblTicketCount.TabIndex = 1
        Me.lblTicketCount.Text = "Number of Tickets: "
        '
        'txtTicketCount
        '
        Me.txtTicketCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtTicketCount.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicketCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTicketCount.Location = New System.Drawing.Point(196, 79)
        Me.txtTicketCount.Name = "txtTicketCount"
        Me.txtTicketCount.Size = New System.Drawing.Size(58, 33)
        Me.txtTicketCount.TabIndex = 2
        '
        'grpTicketzones
        '
        Me.grpTicketzones.BackColor = System.Drawing.Color.AliceBlue
        Me.grpTicketzones.Controls.Add(Me.radZones16)
        Me.grpTicketzones.Controls.Add(Me.radZones15)
        Me.grpTicketzones.Controls.Add(Me.radZones13)
        Me.grpTicketzones.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTicketzones.ForeColor = System.Drawing.Color.Sienna
        Me.grpTicketzones.Location = New System.Drawing.Point(18, 136)
        Me.grpTicketzones.Name = "grpTicketzones"
        Me.grpTicketzones.Size = New System.Drawing.Size(278, 109)
        Me.grpTicketzones.TabIndex = 3
        Me.grpTicketzones.TabStop = False
        Me.grpTicketzones.Text = "Ticket Zones"
        '
        'radZones13
        '
        Me.radZones13.AutoSize = True
        Me.radZones13.Location = New System.Drawing.Point(6, 29)
        Me.radZones13.Name = "radZones13"
        Me.radZones13.Size = New System.Drawing.Size(101, 27)
        Me.radZones13.TabIndex = 0
        Me.radZones13.TabStop = True
        Me.radZones13.Text = "Zones 1-3"
        Me.radZones13.UseVisualStyleBackColor = True
        '
        'radZones15
        '
        Me.radZones15.AutoSize = True
        Me.radZones15.Location = New System.Drawing.Point(171, 29)
        Me.radZones15.Name = "radZones15"
        Me.radZones15.Size = New System.Drawing.Size(101, 27)
        Me.radZones15.TabIndex = 1
        Me.radZones15.TabStop = True
        Me.radZones15.Text = "Zones 1-5"
        Me.radZones15.UseVisualStyleBackColor = True
        '
        'radZones16
        '
        Me.radZones16.AutoSize = True
        Me.radZones16.Location = New System.Drawing.Point(85, 62)
        Me.radZones16.Name = "radZones16"
        Me.radZones16.Size = New System.Drawing.Size(101, 27)
        Me.radZones16.TabIndex = 2
        Me.radZones16.TabStop = True
        Me.radZones16.Text = "Zones 1-6"
        Me.radZones16.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Sienna
        Me.btnCalculate.Location = New System.Drawing.Point(18, 371)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(119, 43)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmLondonTubeTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpTicketzones)
        Me.Controls.Add(Me.txtTicketCount)
        Me.Controls.Add(Me.lblTicketCount)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmLondonTubeTickets"
        Me.Text = "London Tube Tickets"
        Me.grpTicketzones.ResumeLayout(False)
        Me.grpTicketzones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblTicketCount As Label
    Friend WithEvents txtTicketCount As TextBox
    Friend WithEvents grpTicketzones As GroupBox
    Friend WithEvents radZones13 As RadioButton
    Friend WithEvents radZones15 As RadioButton
    Friend WithEvents radZones16 As RadioButton
    Friend WithEvents btnCalculate As Button
End Class
