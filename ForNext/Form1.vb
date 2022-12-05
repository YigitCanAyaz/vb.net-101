Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim iCount As Integer
        Dim stOut As String

        For iCount = 50 To 0 Step -5
            'Beep()
            'Threading.Thread.Sleep(3000)
            'MsgBox(iCount)
            stOut = stOut & iCount & vbNewLine
        Next

        MsgBox(stOut)


    End Sub
End Class
