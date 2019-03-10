Public Class frmXO

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If lblturn.Text = "X" Then
            btn1.Text = "X"
            lblturn.Text = "O"
        Else
            btn1.Text = "O"
            lblturn.Text = "X"
        End If
        btn1.Enabled = False
        'win Conditional for X'
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If

        'win Conditional for O'
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If lblturn.Text = "X" Then
            btn2.Text = "X"
            lblturn.Text = "O"
        Else
            btn2.Text = "O"
            lblturn.Text = "X"
        End If
        btn2.Enabled = False
        'win Conditional for X'
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If

        'win Conditional for O'
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If lblturn.Text = "X" Then
            btn3.Text = "X"
            lblturn.Text = "O"
        Else
            btn3.Text = "O"
            lblturn.Text = "X"
        End If
        btn3.Enabled = False
        'win Conditional for X'
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If

        'win Conditional for O'
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If lblturn.Text = "X" Then
            btn4.Text = "X"
            lblturn.Text = "O"
        Else
            btn4.Text = "O"
            lblturn.Text = "X"
        End If
        btn4.Enabled = False
        'win Conditional for X'
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If

        'win Conditional for O'
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If lblturn.Text = "X" Then
            btn5.Text = "X"
            lblturn.Text = "O"
        Else
            btn5.Text = "O"
            lblturn.Text = "X"
        End If
        btn5.Enabled = False
        'win Conditional for X'
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If

        'win Conditional for O'
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If lblturn.Text = "X" Then
            btn6.Text = "X"
            lblturn.Text = "O"
        Else
            btn6.Text = "O"
            lblturn.Text = "X"
        End If
        btn6.Enabled = False
        'win Conditional for X'
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If

        'win Conditional for O'
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If lblturn.Text = "X" Then
            btn7.Text = "X"
            lblturn.Text = "O"
        Else
            btn7.Text = "O"
            lblturn.Text = "X"
        End If
        btn7.Enabled = False
        'win Conditional for X'
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If

        'win Conditional for O'
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If lblturn.Text = "X" Then
            btn8.Text = "X"
            lblturn.Text = "O"
        Else
            btn8.Text = "O"
            lblturn.Text = "X"
        End If
        btn8.Enabled = False
        'win Conditional for X'
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If

        'win Conditional for O'
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If lblturn.Text = "X" Then
            btn9.Text = "X"
            lblturn.Text = "O"
        Else
            btn9.Text = "O"
            lblturn.Text = "X"
        End If
        btn9.Enabled = False
        'win Conditional for X'
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn7.Text = "X" And btn5.Text = "X" And btn3.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            MsgBox("JOGADOR X GANHOU")
            ScoreX.Text = Val(ScoreX.Text) + 1
        End If

        'win Conditional for O'
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn7.Text = "O" And btn5.Text = "O" And btn3.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            MsgBox("JOGADOR O GANHOU")
            ScoreO.Text = Val(ScoreO.Text) + 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btn1.Text = ""
        btn1.Enabled = True
        btn2.Text = ""
        btn2.Enabled = True
        btn3.Text = ""
        btn3.Enabled = True
        btn4.Text = ""
        btn4.Enabled = True
        btn5.Text = ""
        btn5.Enabled = True
        btn6.Text = ""
        btn6.Enabled = True
        btn7.Text = ""
        btn7.Enabled = True
        btn8.Text = ""
        btn8.Enabled = True
        btn9.Text = ""
        btn9.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmPrincipal.Show()
        Me.Close()


    End Sub

   
  
End Class