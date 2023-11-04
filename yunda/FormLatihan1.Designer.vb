<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLatihan1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLatihan1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNopen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtT4Lahir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.JenisKelamin = New System.Windows.Forms.GroupBox()
        Me.rbtPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbtLaki = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboAgama = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clbPilProdi = New System.Windows.Forms.CheckedListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudGelDaftar = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.JenisKelamin.SuspendLayout()
        CType(Me.nudGelDaftar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. pendaftaran"
        '
        'txtNopen
        '
        Me.txtNopen.Location = New System.Drawing.Point(139, 11)
        Me.txtNopen.Name = "txtNopen"
        Me.txtNopen.Size = New System.Drawing.Size(77, 20)
        Me.txtNopen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Lengkap"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(139, 46)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(207, 20)
        Me.txtNama.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tempat Lahir"
        '
        'txtT4Lahir
        '
        Me.txtT4Lahir.Location = New System.Drawing.Point(139, 78)
        Me.txtT4Lahir.Name = "txtT4Lahir"
        Me.txtT4Lahir.Size = New System.Drawing.Size(207, 20)
        Me.txtT4Lahir.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tgl. Lahir"
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglLahir.Location = New System.Drawing.Point(139, 111)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(88, 20)
        Me.dtpTglLahir.TabIndex = 7
        '
        'JenisKelamin
        '
        Me.JenisKelamin.Controls.Add(Me.rbtPerempuan)
        Me.JenisKelamin.Controls.Add(Me.rbtLaki)
        Me.JenisKelamin.Location = New System.Drawing.Point(139, 147)
        Me.JenisKelamin.Name = "JenisKelamin"
        Me.JenisKelamin.Size = New System.Drawing.Size(165, 37)
        Me.JenisKelamin.TabIndex = 9
        Me.JenisKelamin.TabStop = False
        Me.JenisKelamin.Text = "Jenis Kelamin"
        '
        'rbtPerempuan
        '
        Me.rbtPerempuan.AutoSize = True
        Me.rbtPerempuan.Location = New System.Drawing.Point(78, 20)
        Me.rbtPerempuan.Name = "rbtPerempuan"
        Me.rbtPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbtPerempuan.TabIndex = 1
        Me.rbtPerempuan.TabStop = True
        Me.rbtPerempuan.Text = "Perempuan"
        Me.rbtPerempuan.UseVisualStyleBackColor = True
        '
        'rbtLaki
        '
        Me.rbtLaki.AutoSize = True
        Me.rbtLaki.Location = New System.Drawing.Point(7, 20)
        Me.rbtLaki.Name = "rbtLaki"
        Me.rbtLaki.Size = New System.Drawing.Size(64, 17)
        Me.rbtLaki.TabIndex = 0
        Me.rbtLaki.TabStop = True
        Me.rbtLaki.Text = "laki-Laki"
        Me.rbtLaki.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Agama"
        '
        'cboAgama
        '
        Me.cboAgama.FormattingEnabled = True
        Me.cboAgama.Location = New System.Drawing.Point(139, 193)
        Me.cboAgama.Name = "cboAgama"
        Me.cboAgama.Size = New System.Drawing.Size(141, 21)
        Me.cboAgama.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Pilihan Program Studi"
        '
        'clbPilProdi
        '
        Me.clbPilProdi.FormattingEnabled = True
        Me.clbPilProdi.Items.AddRange(New Object() {"Teknik Informatika", "Ilmu Hukum", "Manajemen", "Akuntansi", "Ilmu Pemerintahan"})
        Me.clbPilProdi.Location = New System.Drawing.Point(139, 231)
        Me.clbPilProdi.Name = "clbPilProdi"
        Me.clbPilProdi.Size = New System.Drawing.Size(141, 79)
        Me.clbPilProdi.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Gel. Pendaftaran"
        '
        'nudGelDaftar
        '
        Me.nudGelDaftar.Location = New System.Drawing.Point(139, 316)
        Me.nudGelDaftar.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudGelDaftar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudGelDaftar.Name = "nudGelDaftar"
        Me.nudGelDaftar.Size = New System.Drawing.Size(55, 20)
        Me.nudGelDaftar.TabIndex = 15
        Me.nudGelDaftar.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(474, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'btnBaru
        '
        Me.btnBaru.ForeColor = System.Drawing.Color.Red
        Me.btnBaru.Location = New System.Drawing.Point(488, 231)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 41)
        Me.btnBaru.TabIndex = 17
        Me.btnBaru.Text = "Baru"
        Me.btnBaru.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.ForeColor = System.Drawing.Color.Red
        Me.btnKeluar.Location = New System.Drawing.Point(488, 292)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 39)
        Me.btnKeluar.TabIndex = 18
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'FrmLatihan1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(622, 354)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.nudGelDaftar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.clbPilProdi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboAgama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.JenisKelamin)
        Me.Controls.Add(Me.dtpTglLahir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtT4Lahir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNopen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLatihan1"
        Me.Text = "Latihan 1"
        Me.JenisKelamin.ResumeLayout(False)
        Me.JenisKelamin.PerformLayout()
        CType(Me.nudGelDaftar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNopen As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtT4Lahir As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpTglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents JenisKelamin As System.Windows.Forms.GroupBox
    Friend WithEvents rbtPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rbtLaki As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboAgama As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents clbPilProdi As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudGelDaftar As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBaru As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button

End Class
