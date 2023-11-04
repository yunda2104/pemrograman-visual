Public Class FrmLatihan6__3_

    Private Sub FrmLatihan6__3__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim I As Integer
        For I = 1 To 31
            Me.cmbTgl.Items.Add(Str(I))
        Next
        For I = 1 To 12
            Me.cmbBulan.Items.Add(MonthName(I))
        Next
        For I = 2000 To Year(Now)
            Me.cmbTahun.Items.Add(Str(I))
        Next
    End Sub
    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        Dim celcius As Integer
        Dim fahrenhet, remour As Single
        For celcius = txtAwal.Text To txtAkhir.Text Step txtStep.Text
            fahrenhet = (9 / 5 * celcius) + 32
            remour = 4 / 5 * celcius
            lblHasil.Items.Add(celcius)
            lblHasil2.Items.Add(fahrenhet)
            lblHasil3.Items.Add(remour)
        Next
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAwal.Text = ""
        txtAkhir.Text = ""
        txtStep.Text = ""
        lblHasil.Items.Clear()
        lblHasil2.Items.Clear()
        lblHasil3.Items.Clear()
        txtAwal.Focus()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class