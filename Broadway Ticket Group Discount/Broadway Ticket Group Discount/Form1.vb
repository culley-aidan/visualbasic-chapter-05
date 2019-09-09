' Program Name: Broadway Ticket Group Discount
' Author:       Aidan J, Culley
' Date:         September 9th, 2019
' Purpose:      This windows application computes the estimated cost of tickets based on the 
'               number  of tickets purchased and the bulk discounts of tickets

Option Strict On
Public Class frmBroadwayDiscount

    Const intGroup18 As Integer = 249
    Const intGroup912 As Integer = 219
    Const intGroup1324 As Integer = 199
    Const intGroup2599 As Integer = 169

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim totalTickets As Integer
        Dim discount As Integer
        Dim totalCost As Integer

        If IsNumeric(txtGroupCount.Text) Then
            totalTickets = Convert.ToInt32(txtGroupCount.Text)
            If totalTickets >= 1 And totalTickets < 100 Then
                Select Case totalTickets
                    Case 1 To 8
                        discount = intGroup18
                    Case 9 To 12
                        discount = intGroup912
                    Case 13 To 24
                        discount = intGroup1324
                    Case 25 To 99
                        discount = intGroup2599
                End Select
                totalCost = totalTickets * discount
                lblTotalCost.Text = totalCost.ToString("C")
            Else
                MsgBox("You entered " & totalTickets.ToString() & ", Enter a positive number between 1-100", , "Input Error")
            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Enter the total amount of tickets", , "Input Error")
            txtGroupCount.Text = ""
            txtGroupCount.Focus()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroupCount.Clear()
        lblTotalCost.Text = ""
        txtGroupCount.Focus()
    End Sub

    Private Sub FrmBroadwayDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGroup18.Text = String.Format("1-8 people  -  ${0} per person", intGroup18)
        lblGroup912.Text = String.Format("9-12 people  -  ${0} per person", intGroup912)
        lblGroup1324.Text = String.Format("13-24 people  -  ${0} per person", intGroup1324)
        lblGroup2599.Text = String.Format("25-99 people  -  ${0} per person", intGroup2599)
        txtGroupCount.Clear()
        lblTotalCost.Text = ""
        txtGroupCount.Focus()
    End Sub
End Class
