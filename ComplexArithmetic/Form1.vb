Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decDiscount As Decimal
        Dim decTotalCost As Decimal
        Dim decPostage As Decimal

        decPrice = 5
        iQuantity = 10
        decDiscount = 2
        decPostage = 3

        decTotalCost = ((decPrice - decDiscount) * iQuantity) + decPostage

        'BO(DM)(AS) => o stands for power of number, b => brackets

        MsgBox(decTotalCost)

    End Sub
End Class
