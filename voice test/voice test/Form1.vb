﻿Public Class Form1
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


    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown, TextBox3.KeyDown, TextBox4.KeyDown, TextBox5.KeyDown, TextBox6.KeyDown, TextBox7.KeyDown, TextBox8.KeyDown, TextBox9.KeyDown, TextBox10.KeyDown, TextBox11.KeyDown, Button1.KeyDown, Button2.KeyDown, Button3.KeyDown

        If e.Alt Then
            e.SuppressKeyPress = True
        End If

        If loudMode = True And e.Control Then
            SAPI.speak("ding ding ding")
        End If

        If e.Control Then
            If e.KeyCode = Keys.D1 Then
                TextBox1.Text = ("Yes")
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D2 Then
                TextBox1.Text = ("No")
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D3 Then
                TextBox1.Text = ("Maybe")
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D4 Then
                TextBox1.Text = ("I feel hungry")
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D5 Then
                TextBox1.Text = ("I feel sick")
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D6 Then
                TextBox1.Text = ("I feel tired")
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D7 Then
                TextBox1.Text = ("I feel happy")
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D8 Then
                TextBox1.Text = ("I feel sad")
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D9 Then
                TextBox1.Text = ("Please leave me alone")
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D0 Then
                TextBox1.Text = ("I want a hug please")
                SAPI.speak(TextBox1.Text)
            End If
        End If



        If e.Alt Then
            If e.KeyCode = Keys.D1 Then
                TextBox1.Text = TextBox2.Text
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D2 Then
                TextBox1.Text = TextBox3.Text
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D3 Then
                TextBox1.Text = TextBox4.Text
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D4 Then
                TextBox1.Text = TextBox5.Text
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D5 Then
                TextBox1.Text = TextBox6.Text
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D6 Then
                TextBox1.Text = TextBox7.Text
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D7 Then
                TextBox1.Text = TextBox8.Text
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D8 Then
                TextBox1.Text = TextBox9.Text
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D9 Then
                TextBox1.Text = TextBox10.Text
                SAPI.speak(TextBox1.Text)
            ElseIf e.KeyCode = Keys.D0 Then
                TextBox1.Text = TextBox11.Text
                SAPI.speak(TextBox1.Text)
            End If
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim voice = ComboBox1.SelectedItem

        Dim voiceList = SAPI.GetVoices()
        Dim voiceData

        For i As Integer = 0 To voiceList.Count - 1
            If (voiceList.Item(i).GetDescription) = voice Then
                voiceData = voiceList.Item(i)
            End If
        Next

        SAPI.Voice = voiceData
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim voiceList = SAPI.GetVoices()

        Dim arrLst As New ArrayList
        For i As Integer = 0 To voiceList.Count - 1
            arrLst.Add(voiceList.Item(i).GetDescription)
        Next
        ComboBox1.DataSource = arrLst

    End Sub
End Class
