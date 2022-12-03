Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        MsgBox("Welcome")
        MsgBox("to")
        MsgBox("the")
        MsgBox("VB.NET")

        ' Modern way to do it (OOP)
        MessageBox.Show("this is another message")
    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click
        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Yiğit Can"
        stLastName = "Ayaz"

        MsgBox("hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")

        stFirstName = "Deniz"
        stLastName = "Ayaz"

        MsgBox("hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")

    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColour = "red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #11/2/2020# ' 2 november 2020 - we write in american format

        MsgBox("the car is " & stMake & vbNewLine & stModel & vbNewLine & iDoors & vbNewLine & stColour & vbNewLine & bTaxed & vbNewLine & iEngineSize & vbNewLine & decPrice & vbNewLine & dtDateRegistered)
    End Sub
End Class

