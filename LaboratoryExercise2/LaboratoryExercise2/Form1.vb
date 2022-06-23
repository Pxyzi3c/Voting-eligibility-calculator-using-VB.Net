Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        Dim greeting As String
        Dim name As String
        Dim gender As String
        Dim age As Integer

        name = txtName.Text
        gender = txtGender.Text
        age = Val(txtAge.Text.ToString)
        greeting = "Good Day, "

        If (name = String.Empty Or txtAge.Text = String.Empty Or gender = String.Empty) Then
            MsgBox("Fill out all the fields!", vbOKOnly + vbCritical, "Warning")
        ElseIf (gender = "M" Or gender = "m") Then
            If (age >= 18 And age < 60) Then
                greeting = "You can now vote Mr. " + name
                txtGreeting.Text = greeting
            ElseIf (age >= 60) Then
                greeting = "Enjoy your discounts Mr. " + name
                txtGreeting.Text = greeting
            ElseIf (age >= 0 And age <= 17) Then
                greeting = "Enjoy being young Mr. " + name
                txtGreeting.Text = greeting
            Else
                MsgBox("Enter a valid Age!", vbOKOnly + vbCritical, "Warning")
            End If
        ElseIf (gender = "F" Or gender = "f") Then
            If (age >= 18 And age < 60) Then
                greeting = "You can now vote Ms. " + name
                txtGreeting.Text = greeting
            ElseIf (age >= 60) Then
                greeting = "Enjoy your discounts Ms. " + name
                txtGreeting.Text = greeting
            ElseIf (age >= 0 And age <= 17) Then
                greeting = "Enjoy being young Ms. " + name
                txtGreeting.Text = greeting
            Else
                MsgBox("Enter a valid Age!", vbOKOnly + vbCritical, "Warning")
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAge.Text = String.Empty
        txtName.Text = String.Empty
        txtGender.Text = String.Empty
        txtGreeting.Text = String.Empty
    End Sub

End Class
