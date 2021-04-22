Public Class Loginpage
    Dim varcount As Integer = 0

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        If PinSlot.Text = varpin Then
            MainMenu.Show() 'this will take the client to the next page'
            Me.Hide()
        Else
            lblmessage.Text = "You have entered the wrong pin"
            varcount += 1
        End If
        If varcount = 3 Then
            SubmitBtn.Enabled = False 'this will disable the submit button'
            lblmessage.Text = "You have been locked out"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        changepin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("enter pin above the submit button")
    End Sub
End Class
