Public Class MainMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        changepin.Show() 'will take the user to change pin page'
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        balance.Show() 'will take the user to balance page'
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Withdraw.Show() 'will take the user to withdraw page'
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("choose the service you require") 'will show the user a help facility'
    End Sub

End Class