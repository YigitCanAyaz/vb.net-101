Public Class Form1
    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click

        Dim stTarget As String
        Dim astFruit(9) As String
        Dim bFound As Boolean


        astFruit(0) = "Apple"
        astFruit(1) = "Mango"
        astFruit(2) = "Strawberry"
        astFruit(3) = "Banana"
        astFruit(4) = "Tomato"
        astFruit(5) = "Grape"
        astFruit(6) = "Pear"
        astFruit(7) = "Lemon"
        astFruit(8) = "Melon"
        astFruit(9) = "Fig"

        stTarget = InputBox("Which fruit are you looking for?")

        Dim i As Integer
        For i = 0 To 9
            If UCase(astFruit(i)) = UCase((stTarget)) Then
                bFound = True
                Exit For
            End If
        Next

        If bFound = True Then
            MsgBox("found it")
        Else
            MsgBox("not found it")
        End If
    End Sub
End Class
