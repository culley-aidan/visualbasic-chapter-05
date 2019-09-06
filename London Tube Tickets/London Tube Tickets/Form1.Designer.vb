<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLondonTubeTickets
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
        Me.lblTicketCount = New System.Windows.Forms.Label()
        Me.txtTicketCount = New System.Windows.Forms.TextBox()
        Me.grpTicketzones = New System.Windows.Forms.GroupBox()
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
        Me.grpTicketzones.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTicketzones.ForeColor = System.Drawing.Color.Sienna
        Me.grpTicketzones.Location = New System.Drawing.Point(18, 136)
        Me.grpTicketzones.Name = "grpTicketzones"
        Me.grpTicketzones.Size = New System.Drawing.Size(278, 100)
        Me.grpTicketzones.TabIndex = 3
        Me.grpTicketzones.TabStop = False
        Me.grpTicketzones.Text = "Ticket Zones"
        '
        'frmLondonTubeTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpTicketzones)
        Me.Controls.Add(Me.txtTicketCount)
        Me.Controls.Add(Me.lblTicketCount)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmLondonTubeTickets"
        Me.Text = "London Tube Tickets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblTicketCount As Label
    Friend WithEvents txtTicketCount As TextBox
    Friend WithEvents grpTicketzones As GroupBox
End Class
