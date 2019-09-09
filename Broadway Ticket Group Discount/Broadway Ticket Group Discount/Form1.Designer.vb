<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroadwayDiscount
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
        Me.lblGroupCount = New System.Windows.Forms.Label()
        Me.txtGroupCount = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpDiscounts = New System.Windows.Forms.GroupBox()
        Me.lblGroup18 = New System.Windows.Forms.Label()
        Me.grpDiscounts.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Sienna
        Me.lblHeading.Location = New System.Drawing.Point(13, 13)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(440, 36)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Broadway Ticket Group Discount"
        '
        'lblGroupCount
        '
        Me.lblGroupCount.AutoSize = True
        Me.lblGroupCount.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupCount.ForeColor = System.Drawing.Color.Sienna
        Me.lblGroupCount.Location = New System.Drawing.Point(69, 67)
        Me.lblGroupCount.Name = "lblGroupCount"
        Me.lblGroupCount.Size = New System.Drawing.Size(209, 25)
        Me.lblGroupCount.TabIndex = 1
        Me.lblGroupCount.Text = "Group Member Count:"
        '
        'txtGroupCount
        '
        Me.txtGroupCount.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupCount.Location = New System.Drawing.Point(317, 64)
        Me.txtGroupCount.Name = "txtGroupCount"
        Me.txtGroupCount.Size = New System.Drawing.Size(51, 33)
        Me.txtGroupCount.TabIndex = 2
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Sienna
        Me.lblCost.Location = New System.Drawing.Point(69, 290)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(110, 25)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "Total Cost: "
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.Sienna
        Me.lblTotalCost.Location = New System.Drawing.Point(275, 290)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(93, 25)
        Me.lblTotalCost.TabIndex = 4
        Me.lblTotalCost.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Sienna
        Me.btnCalculate.Location = New System.Drawing.Point(74, 339)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(118, 40)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Sienna
        Me.btnClear.Location = New System.Drawing.Point(250, 339)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 40)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'grpDiscounts
        '
        Me.grpDiscounts.BackColor = System.Drawing.Color.AliceBlue
        Me.grpDiscounts.Controls.Add(Me.lblGroup18)
        Me.grpDiscounts.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDiscounts.ForeColor = System.Drawing.Color.Sienna
        Me.grpDiscounts.Location = New System.Drawing.Point(74, 121)
        Me.grpDiscounts.Name = "grpDiscounts"
        Me.grpDiscounts.Size = New System.Drawing.Size(294, 146)
        Me.grpDiscounts.TabIndex = 7
        Me.grpDiscounts.TabStop = False
        Me.grpDiscounts.Text = "Discounts"
        '
        'lblGroup18
        '
        Me.lblGroup18.AutoSize = True
        Me.lblGroup18.Location = New System.Drawing.Point(29, 26)
        Me.lblGroup18.Name = "lblGroup18"
        Me.lblGroup18.Size = New System.Drawing.Size(233, 23)
        Me.lblGroup18.TabIndex = 0
        Me.lblGroup18.Text = "1-8 people  -  $xxx per person"
        '
        'frmBroadwayDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(458, 450)
        Me.Controls.Add(Me.grpDiscounts)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtGroupCount)
        Me.Controls.Add(Me.lblGroupCount)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBroadwayDiscount"
        Me.Text = "Broadway Ticket Group Discount"
        Me.grpDiscounts.ResumeLayout(False)
        Me.grpDiscounts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblGroupCount As Label
    Friend WithEvents txtGroupCount As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grpDiscounts As GroupBox
    Friend WithEvents lblGroup18 As Label
End Class
