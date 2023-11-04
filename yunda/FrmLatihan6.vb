Public Class FrmLatihan6
    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        Dim angka As Integer
        'Cetak Bilangan 1 s/d batas nilai yang diinput
        For angka = 1 To txtNilai.Text
            lbHasil.Items.Add(angka)
        Next
    End Sub    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNilai.Text = ""
        lbHasil.Items.Clear()
        txtNilai.Focus()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class