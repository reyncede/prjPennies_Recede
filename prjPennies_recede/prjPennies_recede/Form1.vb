Option Strict On
Option Explicit On
Option Infer Off
Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Declare Variables
        Dim pennies As Integer
        Integer.TryParse(txtPennies.Text, pennies)

        'Dollars = 100 pennies , Quarter = 25  pennies, Dimes = 10 pennies, Nickels = 5 pennies
        Dim dollars As Integer = pennies \ 100
        Dim remaining As Integer = pennies Mod 100
        Dim quarter As Integer = remaining \ 25
        remaining = remaining Mod 25
        Dim dimes As Integer = remaining \ 10
        remaining = remaining Mod 10
        Dim nickels As Integer = remaining \ 5

        'Display Texts
        txtNickels.Text = Convert.ToString(nickels)
        txtDimes.Text = Convert.ToString(dimes)
        txtQuarters.Text = Convert.ToString(quarter)
        txtDollars.Text = Convert.ToString(dollars)
        txtRemaining.Text = Convert.ToString(remaining)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear Textboxes
        txtPennies.Clear()
        txtNickels.Clear()
        txtDimes.Clear()
        txtQuarters.Clear()
        txtDollars.Clear()
        txtRemaining.Clear()
        txtPennies.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
