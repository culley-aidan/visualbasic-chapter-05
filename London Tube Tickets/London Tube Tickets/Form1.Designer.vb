﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.grpTicketzones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Sienna
        Me.lblHeading.Location = New System.Drawing.Point(55, 9)
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
        Me.lblTicketCount.Location = New System.Drawing.Point(56, 82)
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
        Me.txtTicketCount.Location = New System.Drawing.Point(251, 79)
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
        Me.grpTicketzones.Location = New System.Drawing.Point(61, 136)
        Me.grpTicketzones.Name = "grpTicketzones"
        Me.grpTicketzones.Size = New System.Drawing.Size(278, 109)
        Me.grpTicketzones.TabIndex = 3
        Me.grpTicketzones.TabStop = False
        Me.grpTicketzones.Text = "Ticket Zones"
        '
        'radZones13
        '
        Me.radZones13.AutoSize = True
        Me.radZones13.Checked = True
        Me.radZones13.Location = New System.Drawing.Point(18, 29)
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
        Me.radZones15.Text = "Zones 1-5"
        Me.radZones15.UseVisualStyleBackColor = True
        '
        'radZones16
        '
        Me.radZones16.AutoSize = True
        Me.radZones16.Location = New System.Drawing.Point(90, 62)
        Me.radZones16.Name = "radZones16"
        Me.radZones16.Size = New System.Drawing.Size(101, 27)
        Me.radZones16.TabIndex = 2
        Me.radZones16.Text = "Zones 1-6"
        Me.radZones16.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Sienna
        Me.btnCalculate.Location = New System.Drawing.Point(61, 320)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(119, 43)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Sienna
        Me.btnClear.Location = New System.Drawing.Point(220, 320)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 43)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Sienna
        Me.lblCost.Location = New System.Drawing.Point(56, 267)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(105, 25)
        Me.lblCost.TabIndex = 6
        Me.lblCost.Text = "Total Cost:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.Sienna
        Me.lblTotalCost.Location = New System.Drawing.Point(240, 267)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(93, 25)
        Me.lblTotalCost.TabIndex = 7
        Me.lblTotalCost.Text = "$0000.00"
        '
        'frmLondonTubeTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(388, 399)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnClear)
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
    Friend WithEvents btnClear As Button
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTotalCost As Label
End Class
