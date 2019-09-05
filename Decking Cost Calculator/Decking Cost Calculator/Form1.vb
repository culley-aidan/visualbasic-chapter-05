' Program Name: Decking cost Calculator Application
' Author:       Aidan J Culley
' Date:         September 5th, 2019
' Purpose:      This windows application computes the estimated cost of decking based on the
'               number of square feet and the following cost per square foot: Lumber - $2.34 per square foot;
'               Redwood - $7.75 per square foot; composite - $8.50 per square foot

Option Strict On
Public Class frmDecking
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' The btnCalculate event handler calculates the estimated cost of 
        ' decking based on the square footage and the decking type.

        ' Declarations
        Dim decFootage As Decimal
        Dim decCostPerSquarefoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decLumberCost As Decimal = 2.35D
        Dim decRedwoodCost As Decimal = 7.7D
        Dim decCompositeCost As Decimal = 8.5D

        ' Did user enter a numeric value?
        If IsNumeric(txtFootage.Text) Then
            decFootage = Convert.ToDecimal(txtFootage.Text)
            ' Is square Footage greater than zero
            If decFootage > 0 Then
                ' Determine cost per square foot
                If radLumber.Checked Then
                    decCostPerSquarefoot = decLumberCost
                ElseIf radRedwood.Checked Then
                    decCostPerSquarefoot = decRedwoodCost
                ElseIf radComposite.Checked Then
                    decCostPerSquarefoot = decCompositeCost
                End If
                ' Calculate and display the cost estimate
                decCostEstimate = decFootage * decCostPerSquarefoot
                lblCostEstimate.Text = decCostEstimate.ToString("C")
            Else
                ' Display error message if user entered a negative value
                MsgBox("You entered " & decFootage.ToString() & ", Enter a Positive Number", , "Input Error")
                txtFootage.Text = ""
                txtFootage.Focus()
            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Enter the Square Footage of Decking", , "Input Error")
            txtFootage.Text = ""
            txtFootage.Focus()
        End If
    End Sub
End Class
