' Program Name: Comic Convention
' Author:       Aidan J Culley
' Date:         September 6th, 2019
' Purpose:      This windows application computes the estimated cost of group convention
'               tickets ased on what badge the group is using

Option Strict On
Public Class frmComicConvention
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' The btnCalculate event handler calculates the estimated cost of 
        ' registration cost for the group attending

        Dim intAttendees As Integer
        Dim decBadgeCost As Decimal
        Dim dectotalCost As Decimal
        Dim intSuperhero As Integer = 380
        Dim intAutographs As Integer = 275
        Dim intConvention As Integer = 209

        If IsNumeric(txtAttendees.Text) Then
            intAttendees = Convert.ToInt32(txtAttendees.Text)
            If intAttendees > 0 And intAttendees < 20 Then
                If radSuperHero.Checked Then
                    decBadgeCost = intSuperhero
                ElseIf radAutographs.Checked Then
                    decBadgeCost = intAutographs
                ElseIf radConvention.Checked Then
                    decBadgeCost = intConvention
                End If
                dectotalCost = intAttendees * decBadgeCost
                lblTotalCost.Text = dectotalCost.ToString("C")
            Else
                MsgBox("You entered " & intAttendees.ToString() & ", Enter a valid entry", , "Input Error")
                txtAttendees.Text = ""
                txtAttendees.Focus()
            End If
        Else
            MsgBox("Enter the total group size", , "Input Error")
            txtAttendees.Text = ""
            txtAttendees.Focus()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the clear button. It
        ' clears the text box and total cost label and resets the radio buttons.

        txtAttendees.Clear()
        lblTotalCost.Text = ""
        radSuperHero.Checked = False
        radAutographs.Checked = False
        radConvention.Checked = True
        txtAttendees.Focus()
    End Sub

    Private Sub FrmComicConvention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start of
        ' the program.

        txtAttendees.Focus()
        lblTotalCost.Text = ""
    End Sub
End Class
