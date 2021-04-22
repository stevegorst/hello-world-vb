Public Class Withdraw
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        varbalance = varbalance - 10 'this will take away 10 from the balance'
        PostWithdraw.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        varbalance = varbalance - 20 'this will take away 20 from the balance'
        PostWithdraw.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        varbalance = varbalance - 50 'this will take away 50 from the balance'
        PostWithdraw.Show()
        Me.Hide()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        varbalance = varbalance - 100 'this will take away 100 from the balance'
        PostWithdraw.Show()
        Me.Hide()
    End Sub
End Class