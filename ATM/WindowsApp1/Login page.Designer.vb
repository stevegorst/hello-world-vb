<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loginpage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PinSlot = New System.Windows.Forms.TextBox()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.lblmessage = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your pin"
        '
        'PinSlot
        '
        Me.PinSlot.Location = New System.Drawing.Point(271, 110)
        Me.PinSlot.Name = "PinSlot"
        Me.PinSlot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PinSlot.Size = New System.Drawing.Size(116, 20)
        Me.PinSlot.TabIndex = 1
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Location = New System.Drawing.Point(271, 145)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(116, 23)
        Me.SubmitBtn.TabIndex = 2
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'lblmessage
        '
        Me.lblmessage.AutoSize = True
        Me.lblmessage.Location = New System.Drawing.Point(378, 241)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(0, 13)
        Me.lblmessage.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(25, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Help"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Loginpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 287)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblmessage)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.PinSlot)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Loginpage"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents PinSlot As TextBox
    Friend WithEvents lblmessage As Label
    Friend WithEvents Button2 As Button
End Class
