Public Class changepin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        varpin = txtnewpin.Text 'this will update the pin'
        Loginpage.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'this is a message box for the HELP button'
        MsgBox("enter your new pin")
    End Sub

End Class