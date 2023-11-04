<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTugas3
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
        Me.txtNilai1 = New System.Windows.Forms.TextBox()
        Me.txtNilai2 = New System.Windows.Forms.TextBox()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnAkar = New System.Windows.Forms.Button()
        Me.btnKurang = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnKali = New System.Windows.Forms.Button()
        Me.btnBagiBulat = New System.Windows.Forms.Button()
        Me.btnBagiReal = New System.Windows.Forms.Button()
        Me.btnSisaBagi = New System.Windows.Forms.Button()
        Me.Pangkat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(172, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(340, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'txtNilai1
        '
        Me.txtNilai1.Location = New System.Drawing.Point(12, 41)
        Me.txtNilai1.Name = "txtNilai1"
        Me.txtNilai1.Size = New System.Drawing.Size(90, 20)
        Me.txtNilai1.TabIndex = 3
        '
        'txtNilai2
        '
        Me.txtNilai2.Location = New System.Drawing.Point(165, 44)
        Me.txtNilai2.Name = "txtNilai2"
        Me.txtNilai2.Size = New System.Drawing.Size(100, 20)
        Me.txtNilai2.TabIndex = 4
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(322, 44)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(100, 20)
        Me.txtHasil.TabIndex = 5
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator.ForeColor = System.Drawing.Color.White
        Me.lblOperator.Location = New System.Drawing.Point(119, 44)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(25, 13)
        Me.lblOperator.TabIndex = 6
        Me.lblOperator.Text = "opr"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(286, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "="
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnKeluar)
        Me.GroupBox1.Controls.Add(Me.btnAkar)
        Me.GroupBox1.Controls.Add(Me.btnKurang)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.btnKali)
        Me.GroupBox1.Controls.Add(Me.btnBagiBulat)
        Me.GroupBox1.Controls.Add(Me.btnBagiReal)
        Me.GroupBox1.Controls.Add(Me.btnSisaBagi)
        Me.GroupBox1.Controls.Add(Me.Pangkat)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 127)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operator dan Fungsi Matematika"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnKeluar.ForeColor = System.Drawing.Color.Black
        Me.btnKeluar.Location = New System.Drawing.Point(204, 76)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(126, 36)
        Me.btnKeluar.TabIndex = 8
        Me.btnKeluar.Text = "Exit"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnAkar
        '
        Me.btnAkar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAkar.ForeColor = System.Drawing.Color.Black
        Me.btnAkar.Location = New System.Drawing.Point(138, 76)
        Me.btnAkar.Name = "btnAkar"
        Me.btnAkar.Size = New System.Drawing.Size(59, 36)
        Me.btnAkar.TabIndex = 7
        Me.btnAkar.Text = "Akar K Nil.1"
        Me.btnAkar.UseVisualStyleBackColor = False
        '
        'btnKurang
        '
        Me.btnKurang.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnKurang.ForeColor = System.Drawing.Color.Black
        Me.btnKurang.Location = New System.Drawing.Point(77, 76)
        Me.btnKurang.Name = "btnKurang"
        Me.btnKurang.Size = New System.Drawing.Size(53, 36)
        Me.btnKurang.TabIndex = 6
        Me.btnKurang.Text = "Kurang"
        Me.btnKurang.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Location = New System.Drawing.Point(7, 74)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(64, 38)
        Me.btnTambah.TabIndex = 5
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnKali
        '
        Me.btnKali.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnKali.ForeColor = System.Drawing.Color.Black
        Me.btnKali.Location = New System.Drawing.Point(262, 27)
        Me.btnKali.Name = "btnKali"
        Me.btnKali.Size = New System.Drawing.Size(68, 41)
        Me.btnKali.TabIndex = 4
        Me.btnKali.Text = "Kali"
        Me.btnKali.UseVisualStyleBackColor = False
        '
        'btnBagiBulat
        '
        Me.btnBagiBulat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBagiBulat.ForeColor = System.Drawing.Color.Black
        Me.btnBagiBulat.Location = New System.Drawing.Point(203, 27)
        Me.btnBagiBulat.Name = "btnBagiBulat"
        Me.btnBagiBulat.Size = New System.Drawing.Size(53, 39)
        Me.btnBagiBulat.TabIndex = 3
        Me.btnBagiBulat.Text = "Bagi Bulat"
        Me.btnBagiBulat.UseVisualStyleBackColor = False
        '
        'btnBagiReal
        '
        Me.btnBagiReal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBagiReal.ForeColor = System.Drawing.Color.Black
        Me.btnBagiReal.Location = New System.Drawing.Point(138, 28)
        Me.btnBagiReal.Name = "btnBagiReal"
        Me.btnBagiReal.Size = New System.Drawing.Size(59, 39)
        Me.btnBagiReal.TabIndex = 2
        Me.btnBagiReal.Text = "Bagi Real"
        Me.btnBagiReal.UseVisualStyleBackColor = False
        '
        'btnSisaBagi
        '
        Me.btnSisaBagi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSisaBagi.ForeColor = System.Drawing.Color.Black
        Me.btnSisaBagi.Location = New System.Drawing.Point(78, 29)
        Me.btnSisaBagi.Name = "btnSisaBagi"
        Me.btnSisaBagi.Size = New System.Drawing.Size(54, 41)
        Me.btnSisaBagi.TabIndex = 1
        Me.btnSisaBagi.Text = "Sisa Bagi"
        Me.btnSisaBagi.UseVisualStyleBackColor = False
        '
        'Pangkat
        '
        Me.Pangkat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Pangkat.ForeColor = System.Drawing.Color.Black
        Me.Pangkat.Location = New System.Drawing.Point(7, 29)
        Me.Pangkat.Name = "Pangkat"
        Me.Pangkat.Size = New System.Drawing.Size(64, 39)
        Me.Pangkat.TabIndex = 0
        Me.Pangkat.Text = "Pangkat"
        Me.Pangkat.UseVisualStyleBackColor = False
        '
        'FrmTugas3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(445, 253)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.txtNilai2)
        Me.Controls.Add(Me.txtNilai1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmTugas3"
        Me.Text = "FrmTugas3"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNilai1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNilai2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox
    Friend WithEvents lblOperator As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnAkar As System.Windows.Forms.Button
    Friend WithEvents btnKurang As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnKali As System.Windows.Forms.Button
    Friend WithEvents btnBagiBulat As System.Windows.Forms.Button
    Friend WithEvents btnBagiReal As System.Windows.Forms.Button
    Friend WithEvents btnSisaBagi As System.Windows.Forms.Button
    Friend WithEvents Pangkat As System.Windows.Forms.Button
End Class
