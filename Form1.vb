Public Class Form1
    Dim nb1 As String
    Dim op As String
    Dim nb2 As String
    Dim result As String
    Dim res As String
    Dim op1 As String
    Dim nb3 As String
    Dim op2 As String
    Dim nb4 As String
    Dim op3 As String
    Dim nb5 As String
    Dim incr As String
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        incr = 0
        nb1 = TextBox1.Text
        op = TextBox3.Text
        nb2 = TextBox4.Text
        op1 = TextBox5.Text
        nb3 = TextBox6.Text
        op2 = TextBox7.Text
        nb4 = TextBox8.Text
        op3 = TextBox9.Text
        nb5 = TextBox10.Text
        result = TextBox2.Text
        res = 0
        Label3.Text = "Base number will be here"
        While res IsNot result
            Timer1.Start()
        End While
        Label3.Text = res
    End Sub

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        incr = incr + 0.1
        If TextBox1.Text = "@" Then
            nb1 = incr
        End If
        If TextBox4.Text = "@" Then
            nb2 = incr
        End If
        If TextBox6.Text = "@" Then
            nb3 = incr
        End If
        If TextBox8.Text = "@" Then
            nb4 = incr
        End If
        If TextBox10.Text = "@" Then
            nb5 = incr
        End If
        If op = "+" Then
            Res = nb1 + nb2
        ElseIf op = "-" Then
            Res = nb1 - nb2
        ElseIf op = "/" Then
            Res = nb1 / nb2
        ElseIf op = "*" Then
            Res = nb1 * nb2
        End If
        If op1 = "+" Then
            Res = Res + nb3
        ElseIf op1 = "-" Then
            Res = Res - nb3
        ElseIf op1 = "/" Then
            Res = Res / nb3
        ElseIf op1 = "*" Then
            Res = Res * nb3
        End If
        If op2 = "+" Then
            Res = Res + nb4
        ElseIf op2 = "-" Then
            Res = Res - nb4
        ElseIf op2 = "/" Then
            Res = Res / nb4
        ElseIf op2 = "*" Then
            Res = Res * nb4
        End If
        If op3 = "+" Then
            Res = Res + nb5
        ElseIf op3 = "-" Then
            Res = Res - nb5
        ElseIf op3 = "/" Then
            Res = Res / nb5
        ElseIf op3 = "*" Then
            Res = Res * nb5
        End If
        Timer1.Stop()
    End Sub
End Class
