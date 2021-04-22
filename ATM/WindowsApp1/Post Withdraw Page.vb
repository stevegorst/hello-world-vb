Public Class PostWithdraw
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainMenu.Show() 'this is will take the user back to the menu'
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Logout.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'this is a message box for the HELP button'
        MsgBox("Log out if you choose to leave the ATM" & vbCrLf & "Go back to menu if you want to use another service")
    End Sub
End Class