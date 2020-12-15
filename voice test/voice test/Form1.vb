Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SAPI.speak(TextBox1.Text)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SAPI.Voice = SAPI.GetVoices.Item(voiceNum)
        voiceNum = voiceNum + 1
        If voiceNum = 3 Then
            voiceNum = 0
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
    End Sub

End Class
