Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click

        Dim iRange As Integer
        iRange = CInt(InputBox("What number do you want to count up to"))

        Dim sType As String
        sType = InputBox("Dou you want odd numbers or even numbers?")

        Dim iCount As Integer

        If sType.ToUpper() = "EVEN" Then
            iCount = 0
        ElseIf sType.ToUpper() = "ODD" Then
            iCount = 1
        Else
            MsgBox("Please write even or odd!")
            Exit Sub
        End If

        For i = iCount To iRange Step 2
            MsgBox(i)
        Next


    End Sub
End Class
