Public Class Form1
    ' Encapsulation of checking for a valid input
    ' Invalid conditions:
    ' 1. If either of the textboxes are empty
    ' 2. If either of the textboxes contain a non-numeric value
    Private Sub Check()
        If addend1.Text = "" Or addend2.Text = "" Then
            MsgBox("Please enter a number in both boxes")
        End If
        If (Not (IsNumeric(addend1))) Or (Not (IsNumeric(addend2))) Then
            MsgBox("Please enter a VALID number in both boxes")
        End If

    End Sub

    ' Addition
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Check()
        ans.Text = Val(addend1.Text) + Val(addend2.Text)
    End Sub

    ' Subtraction
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Check()
        ans.Text = Val(addend1.Text) - Val(addend2.Text)
    End Sub

    ' Multiplication
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Check()
        ans.Text = Val(addend1.Text) * Val(addend2.Text)
    End Sub

    ' Division
    ' Special case: Cannot divide by zero
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Check()
        If addend2.Text = "0" Then
            MsgBox("Cannot divide by zero")
            Exit Sub
        End If

        ans.Text = Val(addend1.Text) / Val(addend2.Text)
    End Sub

    ' Exits process
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
End Class
