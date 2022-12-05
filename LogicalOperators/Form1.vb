Public Class Form1
    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        Dim iScore As Integer

        If IsNumeric(txtExamScore.Text) = True Then
            iScore = CInt(txtExamScore.Text) 'convert integer manually
        Else
            MsgBox("You must enter a number")
            Exit Sub
        End If

        If iScore < 0 Or iScore > 100 Then
            MsgBox("That is not a valid score. Enter a number between 0 and 100!")
            'Exit Sub 'forces program to stop => return
        ElseIf iScore >= 50 Then
            MsgBox("pass")
        ElseIf iScore < 50 Then
            MsgBox("fail")
        End If

        ' > < = (these are relational)
        ' Or And (these are logical)

        MsgBox("all done")

    End Sub
End Class
