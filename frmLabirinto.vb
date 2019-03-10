Public Class frmLabirinto
    Private Sub Now()
        InitializeComponent()
        MoveToStart()

    End Sub
    Private Sub lblFinish_Click(sender As Object, e As EventArgs) Handles lblFinish.Click
        MessageBox.Show("PARABENS")
        frmPrincipal.Show()
        Me.Hide()


    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = pnlLabirinto.Location()
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles lbl1.MouseEnter, lbl29.MouseEnter, lbl27.MouseEnter, lbl26.MouseEnter, lbl25.MouseEnter, lbl24.MouseEnter, lbl23.MouseEnter, lbl22.MouseEnter, lbl21.MouseEnter, lbl20.MouseEnter, lbl19.MouseEnter, lbl18.MouseEnter, lbl17.MouseEnter, lbl16.MouseEnter, lbl13.MouseEnter, lbl30.MouseEnter, lbl32.MouseEnter, lbl31.MouseEnter, lbl33.MouseEnter, lbl14.MouseEnter, lbl12.MouseEnter, lbl11.MouseEnter, lbl10.MouseEnter, lbl9.MouseEnter, lbl8.MouseEnter, lbl7.MouseEnter, lbl6.MouseEnter, lbl5.MouseEnter, lbl4.MouseEnter, lbl3.MouseEnter, lbl2.MouseEnter
        MoveToStart()

    End Sub
End Class