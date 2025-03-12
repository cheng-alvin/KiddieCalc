Public Class Form1
    Sub Check()
        If addend1.Text = "" Or addend2.Text = "" Then
            MsgBox("Please enter a number in both boxes")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Check()
        ans.Text = Val(addend1.Text) + Val(addend2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Check()
        ans.Text = Val(addend1.Text) - Val(addend2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Check()
        ans.Text = Val(addend1.Text) * Val(addend2.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Check()
        If addend2.Text = "0" Then
            MsgBox("Cannot divide by zero")
            Exit Sub
        End If

        ans.Text = Val(addend1.Text) / Val(addend2.Text)
    End Sub


End Class
