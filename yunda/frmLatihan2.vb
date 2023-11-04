
Public Class frmlatihan2
    'Deklarasi variabel
    Dim TotalGaji, BesarPajak As Single ' variabel global
    Const Pajak As Single = 0.025 'constanta

    Private Sub txtJamKerja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjamkerja.TextChanged
        TotalGaji = Val(txtjamkerja.Text) * Val(txtUpah.Text)
        BesarPajak = TotalGaji * Pajak
        txtTotalgaji.Text = FormatNumber(TotalGaji, 0)
        txtPajak.Text = FormatNumber(BesarPajak, 0)
    End Sub

    Private Sub txtUpah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUpah.TextChanged
        TotalGaji = Val(txtjamkerja.Text) * Val(txtUpah.Text)
        BesarPajak = TotalGaji * Pajak
        txtTotalgaji.Text = FormatNumber(TotalGaji, 0)
        txtPajak.Text = FormatNumber(BesarPajak, 0)
    End Sub

    Private Sub txtPotongan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpotongan.TextChanged
        Dim SisaGaji As Single 'variabel lokal
        SisaGaji = TotalGaji - BesarPajak - Val(txtpotongan.Text)
        txtSisaGaji.Text = FormatNumber(SisaGaji, 0)
    End Sub

    Private Sub btnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        txtNama.Text = ""
        txtjamkerja.Text = ""
        txtUpah.Text = ""
        txtTotalgaji.Text = ""
        txtPajak.Text = ""
        txtpotongan.Text = ""
        txtSisaGaji.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Dispose()
    End Sub
End Class