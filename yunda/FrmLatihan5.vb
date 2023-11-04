Public Class FrmLatihan5
    Dim nRata As Single
    Dim cNa, CKet As String

    Private Sub txtTgs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTgs.TextChanged
        Call HitungRata2()
    End Sub
    Sub HitungRata2()
        nRata = (Val(txtTgs.Text) + Val(txtUts.Text) + Val(txtUas.Text)) / 3
        Select Case nRata
            Case Is > 85
                cNa = "A"
            Case 75 To 85
                cNa = "B"
            Case 60 To 74.99
                cNa = "C"
            Case 40 To 59.99
                cNa = "D"
            Case Is < 40
                cNa = "E"
        End Select
        Select Case cNa
            Case "A", "B", "C"
                CKet = "Lulus"
            Case "D"
                CKet = "Mengulang"
            Case "E"
                CKet = "Tdk Lulus"
        End Select        txtRata.Text = FormatNumber(nRata, 2)
        txtNa.Text = cNa
        txtKet.Text = CKet
    End Sub
    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Dispose()
    End Sub    Private Sub txtUts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUts.TextChanged
        Call HitungRata2()
    End Sub
    Private Sub txtUas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUas.TextChanged
        Call HitungRata2()
    End Sub
    Private Sub FrmLatih5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'Menggunakan Tombol Enter
        'Ubah Key Preview di Form menjadi True
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub    Private Sub btnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        txtNim.Clear()
        txtNama.Clear()
        txtMK.Clear()
        txtTgs.Clear()
        txtUas.Clear()
        txtUts.Clear()
        txtRata.Clear()
        txtNa.Clear()
        txtKet.Clear()
        dtpUjian.Value = Now
        txtNim.Focus()
    End Sub
End Class