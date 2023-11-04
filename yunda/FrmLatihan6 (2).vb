Public Class FrmLatihan6__2_
    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        Dim angka As Integer
        For angka = txtAwal.Text To txtAkhir.Text
            lblHasil.Items.Add(angka)
        Next
        For angka = txtAwal.Text To txtAkhir.Text
            If angka = 5 Then Exit For
            lblHasil2.Items.Add(angka)
        Next
        For angka = txtAwal.Text To txtAkhir.Text
            If angka = 5 Then Continue For
            lblHasil3.Items.Add(angka)
        Next
    End Sub    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAwal.Text = ""
        txtAkhir.Text = ""
        lblHasil.Items.Clear()
        lblHasil2.Items.Clear()
        lblHasil3.Items.Clear()
        txtAwal.Focus()
    End Sub    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class