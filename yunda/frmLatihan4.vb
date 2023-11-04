Public Class frmLatihan4
    Dim JmlHargaAir, Denda As Single

    Sub Hitung_Harga_Air()
        Dim Harga1, Harga2, Harga3, Harga4, By_Adm, Total_By
        Dim Jml_Pakai As Integer
        Jml_Pakai = Val(txtBI.Text) - Val(txtBL.Text)
        txtJml.Text = Format(Jml_Pakai, 0)
        If cboGol.Text = "RA" Then
            By_Adm = 10000
            If Jml_Pakai < 10 Then
                Harga1 = 10 * 2500
                Harga2 = 0
                Harga3 = 0
                Harga4 = 0
            ElseIf Jml_Pakai < 20 Then
                Harga1 = 10 * 2500
                Harga2 = (Jml_Pakai - 10) * 3400
                Harga3 = 0
                Harga4 = 0
            ElseIf Jml_Pakai < 30 Then
                Harga1 = 10 * 2500
                Harga2 = 10 * 3400
                Harga3 = (Jml_Pakai - 20) * 4000
                Harga4 = 0
            Else
                Harga1 = 10 * 2500
                Harga2 = 10 * 3400
                Harga3 = 10 * 4000
                Harga4 = (Jml_Pakai - 30) * 5000
            End If
        Else
            By_Adm = 20000
            If Jml_Pakai < 10 Then
                Harga1 = 10 * 3500
                Harga2 = 0
                Harga3 = 0
                Harga4 = 0
            ElseIf Jml_Pakai < 20 Then
                Harga1 = 10 * 3500
                Harga2 = (Jml_Pakai - 10) * 4500
                Harga3 = 0
                Harga4 = 0
            ElseIf Jml_Pakai < 30 Then
                Harga1 = 10 * 3500
                Harga2 = 10 * 4500
                Harga3 = (Jml_Pakai - 20) * 6000
                Harga4 = 0
            Else
                Harga1 = 10 * 3500
                Harga2 = 10 * 4500
                Harga3 = 10 * 6000
                Harga4 = (Jml_Pakai - 30) * 7000
            End If
        End If
        JmlHargaAir = Harga1 + Harga2 + Harga3 + Harga4
        txtHarga1.Text = FormatNumber(Harga1, 0)
        txtHarga2.Text = FormatNumber(Harga2, 0)
        txtHarga3.Text = FormatNumber(Harga3, 0)
        txtHarga4.Text = FormatNumber(Harga4, 0)
        txtBy_Adm.Text = FormatNumber(By_Adm, 0)
        Total_By = JmlHargaAir + By_Adm + Denda
        txtJmlHarga.Text = FormatNumber(JmlHargaAir, 0)
        txtTotal.Text = FormatNumber(Total_By, 0)
    End Sub

    Sub Hitung_Denda()
        If dtpJual.Value.Day > 20 Then
            Denda = 6000
        Else
            Denda = 0
        End If
        txtDenda.Text = FormatNumber(Denda, 0)
        If JmlHargaAir > 0 Then
            Hitung_Harga_Air()
        End If
    End Sub
    Private Sub txtBI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBI.TextChanged
        Hitung_Harga_Air()
    End Sub

    Private Sub txtBL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBL.TextChanged
        Hitung_Harga_Air()
    End Sub

    Private Sub dtpJual_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpJual.ValueChanged
        Hitung_Denda()
    End Sub

    Private Sub cboGol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGol.SelectedIndexChanged
        Hitung_Harga_Air()
    End Sub
    Private Sub txtBI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBI.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True    End Sub

    Private Sub frmLatihan4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Dispose()
    End Sub
End Class

