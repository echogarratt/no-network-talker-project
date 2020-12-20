Public Class Form1
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If loudMode = True Then
                SAPI.speak("ding ding ding")
                SAPI.speak("ding ding ding")
            End If
            SAPI.speak(TextBox1.Text)
        End If


        If e.KeyChar = Convert.ToChar(27) Then
            TextBox1.Text = ""
        End If

    End Sub


    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox1.KeyDown

        If loudMode = True And e.Control Then
            SAPI.speak("ding ding ding")
        End If

        If e.Control AndAlso e.KeyCode = Keys.D1 Then
            TextBox1.Text = ("Yes")
            SAPI.speak(TextBox1.Text)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D2 Then
            TextBox1.Text = ("No")
            SAPI.speak(TextBox1.Text)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D3 Then
            TextBox1.Text = ("Maybe")
            SAPI.speak(TextBox1.Text)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D4 Then
            TextBox1.Text = ("I feel hungry")
            SAPI.speak(TextBox1.Text)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D5 Then
            TextBox1.Text = ("I feel sick")
            SAPI.speak(TextBox1.Text)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D6 Then
            TextBox1.Text = ("I feel tired")
            SAPI.speak(TextBox1.Text)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D7 Then
            TextBox1.Text = ("I feel happy")
            SAPI.speak(TextBox1.Text)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D8 Then
            TextBox1.Text = ("I feel sad")
            SAPI.speak(TextBox1.Text)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D9 Then
            TextBox1.Text = ("Please leave me alone")
            SAPI.speak(TextBox1.Text)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D0 Then
            TextBox1.Text = ("I want a hug please")
            SAPI.speak(TextBox1.Text)
        End If



        If e.Alt AndAlso e.KeyCode = Keys.D1 Then
            TextBox1.Text = TextBox2.Text
            SAPI.speak(TextBox1.Text)
        ElseIf e.Alt AndAlso e.KeyCode = Keys.D2 Then
            TextBox1.Text = TextBox3.Text
            SAPI.speak(TextBox1.Text)
        ElseIf e.Alt AndAlso e.KeyCode = Keys.D3 Then
            TextBox1.Text = TextBox4.Text
            SAPI.speak(TextBox1.Text)
        ElseIf e.Alt AndAlso e.KeyCode = Keys.D4 Then
            TextBox1.Text = TextBox5.Text
            SAPI.speak(TextBox1.Text)
        ElseIf e.Alt AndAlso e.KeyCode = Keys.D5 Then
            TextBox1.Text = TextBox6.Text
            SAPI.speak(TextBox1.Text)
        ElseIf e.Alt AndAlso e.KeyCode = Keys.D6 Then
            TextBox1.Text = TextBox7.Text
            SAPI.speak(TextBox1.Text)
        ElseIf e.Alt AndAlso e.KeyCode = Keys.D7 Then
            TextBox1.Text = TextBox8.Text
            SAPI.speak(TextBox1.Text)
        ElseIf e.Alt AndAlso e.KeyCode = Keys.D8 Then
            TextBox1.Text = TextBox9.Text
            SAPI.speak(TextBox1.Text)
        ElseIf e.Alt AndAlso e.KeyCode = Keys.D9 Then
            TextBox1.Text = TextBox10.Text
            SAPI.speak(TextBox1.Text)
        ElseIf e.Alt AndAlso e.KeyCode = Keys.D0 Then
            TextBox1.Text = TextBox11.Text
            SAPI.speak(TextBox1.Text)
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If loudMode = True Then
            SAPI.speak("ding ding ding")
            SAPI.speak("ding ding ding")
        End If
        SAPI.speak(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If loudMode = True Then
            Button2.Text = "Loud room mode: off"
            loudMode = False
        ElseIf loudMode = False Then
            Button2.Text = "Loud room mode: on"
            loudMode = True
        End If


    End Sub
End Class
