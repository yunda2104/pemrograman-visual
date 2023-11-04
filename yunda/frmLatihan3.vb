Public Class frmLatihan3
    Dim Harga_Satuan, Sisa_Harga
    Sub KosongkanForm()
        txtNama_Brg.Text = ""
        txtHarga.Text = ""
        txtjml.Text = ""
        txtTotal.Text = ""
        txtPajak.Text = ""
        txtpotongan.Text = ""
        txtSisa.Text = ""
        Label9.Text = 0
        txtuang_kbl.Text = ""
        dtpjual.Value = Now
    End Sub

    Private Sub txtkb_validated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkb_validated.Click
        Dim Kode_Brg, Nama_Brg As String

        Kode_Brg = Trim(txtkb_validated.Text)
        If txtkb_validated.Text = "" Then
            Exit Sub
        End If
        If Kode_Brg = "B-01" Then
            Nama_Brg = "Buku"
            Harga_Satuan = 5000
        ElseIf Kode_Brg = "B-02" Then
            Nama_Brg = "Pensil"
            Harga_Satuan = 3000
        ElseIf Kode_Brg = "B-03" Then
            Nama_Brg = "Tip-ex"
            Harga_Satuan = 2000
        Else
            MessageBox.Show("Maaf, Kode Barang tidak Dikenal", "Info",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
            KosongkanForm()
            txtkb_validated.Text = ""
            txtkb_validated.Focus()
            Exit Sub
        End If
        txtnama_brg.Text = Nama_Brg
        txtharga.Text = FormatNumber(Harga_Satuan, 0)
    End Sub

    Private Sub txtjml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjml.Click
        Dim Pajak, Potongan, Total_Hrg As Single
        Total_Hrg = Harga_Satuan * Val(txtjml.Text)
        Pajak = 0.1 * Total_Hrg
        If Total_Hrg > 500000 Then
            Potongan = 25000
        Else
            Potongan = 0
        End If
        Sisa_Harga = Total_Hrg + Pajak - Potongan
        txttotal.Text = FormatNumber(Total_Hrg, 0)
        txtpajak.Text = FormatNumber(Pajak, 0)
        txtpotongan.Text = FormatNumber(Potongan, 0)
        txtSisa.Text = FormatNumber(Sisa_Harga, 0)
    End Sub

    Private Sub txtjml_pby_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Dim Uang_Kbl As Single
        Uang_Kbl = Label9.Text - Sisa_Harga
        If Label9.Text < Sisa_Harga Then
            MsgBox("Maaf, Jumlah Uang Kurang", MessageBoxIcon.Information, "Info")
            Label9.Text = ""
            txtuang_kbl.Text = ""
            Label9.Focus()
            Exit Sub
        Else
            txtuang_kbl.Text = FormatNumber(Uang_Kbl, 0)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        KosongkanForm()
        txtkb_validated.Text = ""
        txtkb_validated.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub frmLatihan3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KosongkanForm()
    End Sub
    Private Sub frmLatihan3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'Untuk Menggunakan Tombol Enter
        'Atur Properties Form untuk Key Preview = True
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub txtJml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjml.KeyPress
        'Hanya Boleh diisi dengan angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub txtJml_Pby_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJml_Pby.TextChanged
        ' Mengatur Format angka pada saat diinput
        If txtJml_Pby.Text = "" Then txtJml_Pby.Text = 0
        txtJml_Pby.Text = FormatNumber(txtJml_Pby.Text, 0)
        txtJml_Pby.SelectionStart = txtJml_Pby.Text.Length
    End Sub
End Class

