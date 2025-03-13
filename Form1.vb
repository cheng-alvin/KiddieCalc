Public Class Form1
    ' Encapsulation of checking for a valid input
    ' Invalid conditions:
    ' 1. If either of the textboxes are empty
    ' 2. If either of the textboxes contain a non-numeric value
    Private Function IsOkay()
        If addend1.Text = "" Or addend2.Text = "" Then
            MsgBox("Please enter a number in both boxes")
            Return False
        End If
        If (Not (IsNumeric(addend1.Text))) Or (Not (IsNumeric(addend2.Text))) Then
            MsgBox("Please enter a VALID number in both boxes")
            Return False
        End If

        Return True
    End Function

    ' Addition
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsOkay() Then
            ans.Text = Val(addend1.Text) + Val(addend2.Text)
        End If
    End Sub

    ' Subtraction
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsOkay() Then
            ans.Text = Val(addend1.Text) - Val(addend2.Text)
        End If
    End Sub

    ' Multiplication
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsOkay() Then
            ans.Text = Val(addend1.Text) * Val(addend2.Text)
        End If
    End Sub

    ' Division
    ' Special edge case: Cannot divide by zero (Will report and stop process)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsOkay() Then
            Exit Sub
        End If

        ' Handle edge case
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        addend1.Text = ""
        addend2.Text = ""
        ans.Text = ""
    End Sub
End Class
