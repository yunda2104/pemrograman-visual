Public Class FrmTugas3
    Dim Hasil As Single

    Private Sub Pangkat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pangkat.Click
        Hasil = Val(txtNilai1.Text) ^ Val(txtNilai2.Text)
        txtHasil.Text = FormatNumber(Hasil, 0)
        lblOperator.Text = "^"
    End Sub

    Private Sub btnSisaBagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSisaBagi.Click
        Hasil = Val(txtNilai1.Text) Mod Val(txtNilai2.Text)
        txtHasil.Text = FormatNumber(Hasil, 0)
        lblOperator.Text = "%"
    End Sub

    Private Sub btnBagiReal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBagiReal.Click
        Hasil = Val(txtNilai1.Text) / Val(txtNilai2.Text)
        txtHasil.Text = FormatNumber(Hasil, 0)
        lblOperator.Text = "/"
    End Sub

    Private Sub btnBagiBulat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBagiBulat.Click
        Hasil = Val(txtNilai1.Text) \ Val(txtNilai2.Text)
        txtHasil.Text = FormatNumber(Hasil, 0)
        lblOperator.Text = "\"
    End Sub

    Private Sub btnKali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKali.Click
        Hasil = Val(txtNilai1.Text) * Val(txtNilai2.Text)
        txtHasil.Text = FormatNumber(Hasil, 0)
        lblOperator.Text = "*"
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Hasil = Val(txtNilai1.Text) + Val(txtNilai2.Text)
        txtHasil.Text = FormatNumber(Hasil, 0)
        lblOperator.Text = "+"
    End Sub

    Private Sub btnKurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKurang.Click
        Hasil = Val(txtNilai1.Text) - Val(txtNilai2.Text)
        txtHasil.Text = FormatNumber(Hasil, 0)
        lblOperator.Text = "-"
    End Sub

    Private Sub btnAkar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAkar.Click
        Hasil = Math.Sqrt(Val(txtNilai1.Text))
        txtHasil.Text = FormatNumber(Hasil, 0)
        lblOperator.Text = "Math.Sqrt"
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
