Public Class balance
    Private Sub balance_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        BalanceDisplay.Text = varbalance
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Logout.Show() 'this will take the user to the the logout page'
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'this is a message box for the HELP button'
        MsgBox("print receipt will log you out and print receipt")
    End Sub
End Class