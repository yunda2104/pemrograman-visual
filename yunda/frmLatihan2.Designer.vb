<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlatihan2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtjamkerja = New System.Windows.Forms.TextBox()
        Me.txtUpah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalgaji = New System.Windows.Forms.TextBox()
        Me.txtPajak = New System.Windows.Forms.TextBox()
        Me.txtpotongan = New System.Windows.Forms.TextBox()
        Me.txtSisaGaji = New System.Windows.Forms.TextBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah jam kerja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Upah/Jam"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(120, 33)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(131, 20)
        Me.txtNama.TabIndex = 3
        '
        'txtjamkerja
        '
        Me.txtjamkerja.Location = New System.Drawing.Point(120, 70)
        Me.txtjamkerja.Name = "txtjamkerja"
        Me.txtjamkerja.Size = New System.Drawing.Size(45, 20)
        Me.txtjamkerja.TabIndex = 4
        Me.txtjamkerja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUpah
        '
        Me.txtUpah.Location = New System.Drawing.Point(120, 106)
        Me.txtUpah.Name = "txtUpah"
        Me.txtUpah.Size = New System.Drawing.Size(63, 20)
        Me.txtUpah.TabIndex = 5
        Me.txtUpah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(250, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Gaji"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Pajak Penghasilan 2.5%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Potongan Lain-lain"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(259, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Sisa Gaji"
        '
        'txtTotalgaji
        '
        Me.txtTotalgaji.Enabled = False
        Me.txtTotalgaji.Location = New System.Drawing.Point(318, 185)
        Me.txtTotalgaji.Name = "txtTotalgaji"
        Me.txtTotalgaji.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalgaji.TabIndex = 10
        Me.txtTotalgaji.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPajak
        '
        Me.txtPajak.Enabled = False
        Me.txtPajak.Location = New System.Drawing.Point(318, 219)
        Me.txtPajak.Name = "txtPajak"
        Me.txtPajak.Size = New System.Drawing.Size(100, 20)
        Me.txtPajak.TabIndex = 11
        Me.txtPajak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpotongan
        '
        Me.txtpotongan.Location = New System.Drawing.Point(318, 253)
        Me.txtpotongan.Name = "txtpotongan"
        Me.txtpotongan.Size = New System.Drawing.Size(100, 20)
        Me.txtpotongan.TabIndex = 12
        Me.txtpotongan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSisaGaji
        '
        Me.txtSisaGaji.Enabled = False
        Me.txtSisaGaji.Location = New System.Drawing.Point(318, 285)
        Me.txtSisaGaji.Name = "txtSisaGaji"
        Me.txtSisaGaji.Size = New System.Drawing.Size(100, 20)
        Me.txtSisaGaji.TabIndex = 13
        Me.txtSisaGaji.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(359, 370)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 15
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBaru
        '
        Me.btnBaru.Location = New System.Drawing.Point(262, 370)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 23)
        Me.btnBaru.TabIndex = 16
        Me.btnBaru.Text = "Baru"
        Me.btnBaru.UseVisualStyleBackColor = True
        '
        'frmlatihan2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(533, 419)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.txtSisaGaji)
        Me.Controls.Add(Me.txtpotongan)
        Me.Controls.Add(Me.txtPajak)
        Me.Controls.Add(Me.txtTotalgaji)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUpah)
        Me.Controls.Add(Me.txtjamkerja)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmlatihan2"
        Me.Text = "Baru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtjamkerja As System.Windows.Forms.TextBox
    Friend WithEvents txtUpah As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalgaji As System.Windows.Forms.TextBox
    Friend WithEvents txtPajak As System.Windows.Forms.TextBox
    Friend WithEvents txtpotongan As System.Windows.Forms.TextBox
    Friend WithEvents txtSisaGaji As System.Windows.Forms.TextBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnBaru As System.Windows.Forms.Button
End Class
