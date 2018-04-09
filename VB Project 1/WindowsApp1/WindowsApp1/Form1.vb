'Written By: Louis Magdaleno'
'CIS 217 - Project #3'
'this program will calculate the price of an ice cream cone based on the number of scoops and additional toppings selected
Public Class frmIceCreamStore
    'global variables to store cost of scoops and toppings'
    Dim scoop_cost As Double = 0.00
    Dim toppings_cost As Double = 0.00
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub calculate_total_cost(toppings As Double, scoops As Double)
        txtTotal.Text = (scoops + toppings).ToString("C2")
    End Sub

    'setting the cost of scoops depending on the radio button selected'
    Private Sub radiobtn_CheckedChanged(sender As RadioButton, e As EventArgs) Handles rdbtnOneScoop.CheckedChanged, rdbtnTwoScoops.CheckedChanged, rdbtnThreeScoops.CheckedChanged
        If sender.Name = "rdbtnOneScoop" Then
            scoop_cost = 1.0
        ElseIf sender.Name = "rdbtnTwoScoops" Then
            scoop_cost = 2.0
        ElseIf sender.Name = "rdbtnThreeScoops" Then
            scoop_cost = 3.0
        End If
        calculate_total_cost(toppings_cost, scoop_cost)
    End Sub
    'on form load, setting total to $0.00'
    Private Sub frmIceCreamStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtTotal.Text = 0.00.ToString("C2")
    End Sub
    'calculating cost of toppings based on toppings selected'
    Private Sub chkbx_CheckedChanged(sender As CheckBox, e As EventArgs) Handles chkbxSprinkles.CheckedChanged, chkbxCherrySyrup.CheckedChanged, chkbxChocolateChips.CheckedChanged, chkbxGummyWorms.CheckedChanged, chkbxOreos.CheckedChanged
        If sender.Checked Then
            toppings_cost += 0.5
        Else
            toppings_cost -= 0.5
        End If
        calculate_total_cost(toppings_cost, scoop_cost)
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        toppings_cost = 0
        scoop_cost = 1.0
        rdbtnOneScoop.Checked = True
        chkbxCherrySyrup.Checked = False
        chkbxChocolateChips.Checked = False
        chkbxGummyWorms.Checked = False
        chkbxOreos.Checked = False
        chkbxSprinkles.Checked = False
        calculate_total_cost(0, 1)
        lstbxFlavors.Select()

    End Sub
End Class
