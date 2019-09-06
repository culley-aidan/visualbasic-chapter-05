' Program Name: London Tube tickets
' Author:       Aidan J Culley
' Date:         September 6th, 2019
' Purpose:      This windows application computes the estimated cost of single fare tickets
'               based on the number of tickets entered and what zone the ticket covers

Option Strict On
Public Class frmLondonTubeTickets
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' The btnCalculate event handler calculates the estimated cost of 
        ' tickets based on ticket count and zones covered.

        Dim intTicketCount As Integer
        Dim decCostPerTicket As Decimal
        Dim decUSCostPerTicket As Decimal
        Dim decTotalCost As Decimal
        Dim decUSTotalCost As Decimal
        Dim decZone13 As Decimal = 4.9D
        Dim decZone15 As Decimal = 5.9D
        Dim decZone16 As Decimal = 6D
        Dim decUSZone13 As Decimal = 6.03D
        Dim decUSZone15 As Decimal = 7.26D
        Dim decUSZone16 As Decimal = 7.39D

        If IsNumeric(txtTicketCount.Text) Then
            intTicketCount = Convert.ToInt32(txtTicketCount.Text)
            If intTicketCount > 0 Then
                If radZones13.Checked Then
                    decCostPerTicket = decZone13
                    decUSCostPerTicket = decUSZone13
                ElseIf radZones15.Checked Then
                    decCostPerTicket = decZone15
                    decUSCostPerTicket = decUSZone15
                ElseIf radZones16.Checked Then
                    decCostPerTicket = decZone16
                    decUSCostPerTicket = decUSZone16
                End If
                decTotalCost = Math.Round(decCostPerTicket * intTicketCount, 2)
                decUSTotalCost = Math.Round(decUSCostPerTicket * intTicketCount, 2)
                lblTotalCost.Text = String.Format("${0} (£{1})", decUSTotalCost, decTotalCost)
            Else
                MsgBox("You entered " & intTicketCount.ToString() & ", Enter a positive number", , "Input Error")
                txtTicketCount.Text = ""
                txtTicketCount.Focus()
            End If
        Else
            MsgBox("Enter the total ticket amount", , "Input Error")
            txtTicketCount.Text = ""
            txtTicketCount.Focus()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' this event handler is executed when the user clicks the clear button
        txtTicketCount.Clear()
        lblTotalCost.Text = ""
        radZones13.Checked = True
        radZones15.Checked = False
        radZones16.Checked = False
        txtTicketCount.Focus()
    End Sub

    Private Sub FrmLondonTubeTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start
        ' of the program. it sets focus to ticket count and clears cost label

        txtTicketCount.Focus()
        lblTotalCost.Text = ""
    End Sub
End Class
