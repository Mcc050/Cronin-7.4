Public Class frmExtracredit

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim nums(,) As Double = {{7, 3, 1, 0},
                               {2, 5, 9, 8},
                               {0, 6, 4, 10}}
        lstOutput.Items.Add(nums(2, 1))
        lstOutput.Items.Add(nums.GetUpperBound(0))
        Dim total As Double = 0
        For Each num In nums
            total += num
        Next
        lstOutput.Items.Add(total)
        Dim total2 As Double = 0
        For c As Integer = 0 To nums.GetUpperBound(1)
            total2 += nums(2, c)
        Next
        lstOutput.Items.Add(total2)
    End Sub
End Class
