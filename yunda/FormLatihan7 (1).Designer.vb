<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhile
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
        Me.lbHasil = New System.Windows.Forms.ListBox()
        Me.btnWhile1_10 = New System.Windows.Forms.Button()
        Me.btnWhileGanjil = New System.Windows.Forms.Button()
        Me.btnWhileGenap = New System.Windows.Forms.Button()
        Me.btnJumNilai = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbHasil
        '
        Me.lbHasil.FormattingEnabled = True
        Me.lbHasil.Location = New System.Drawing.Point(12, 12)
        Me.lbHasil.Name = "lbHasil"
        Me.lbHasil.Size = New System.Drawing.Size(120, 212)
        Me.lbHasil.TabIndex = 0
        '
        'btnWhile1_10
        '
        Me.btnWhile1_10.Location = New System.Drawing.Point(159, 12)
        Me.btnWhile1_10.Name = "btnWhile1_10"
        Me.btnWhile1_10.Size = New System.Drawing.Size(75, 36)
        Me.btnWhile1_10.TabIndex = 1
        Me.btnWhile1_10.Text = "While 1-10"
        Me.btnWhile1_10.UseVisualStyleBackColor = True
        '
        'btnWhileGanjil
        '
        Me.btnWhileGanjil.Location = New System.Drawing.Point(159, 54)
        Me.btnWhileGanjil.Name = "btnWhileGanjil"
        Me.btnWhileGanjil.Size = New System.Drawing.Size(75, 37)
        Me.btnWhileGanjil.TabIndex = 2
        Me.btnWhileGanjil.Text = "While Ganjil"
        Me.btnWhileGanjil.UseVisualStyleBackColor = True
        '
        'btnWhileGenap
        '
        Me.btnWhileGenap.Location = New System.Drawing.Point(159, 97)
        Me.btnWhileGenap.Name = "btnWhileGenap"
        Me.btnWhileGenap.Size = New System.Drawing.Size(75, 34)
        Me.btnWhileGenap.TabIndex = 3
        Me.btnWhileGenap.Text = "While Genap"
        Me.btnWhileGenap.UseVisualStyleBackColor = True
        '
        'btnJumNilai
        '
        Me.btnJumNilai.Location = New System.Drawing.Point(159, 137)
        Me.btnJumNilai.Name = "btnJumNilai"
        Me.btnJumNilai.Size = New System.Drawing.Size(75, 34)
        Me.btnJumNilai.TabIndex = 4
        Me.btnJumNilai.Text = "Jum Nilai"
        Me.btnJumNilai.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(159, 177)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmWhile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(260, 231)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnJumNilai)
        Me.Controls.Add(Me.btnWhileGenap)
        Me.Controls.Add(Me.btnWhileGanjil)
        Me.Controls.Add(Me.btnWhile1_10)
        Me.Controls.Add(Me.lbHasil)
        Me.Name = "frmWhile"
        Me.Text = "Looping dgn While"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbHasil As System.Windows.Forms.ListBox
    Friend WithEvents btnWhile1_10 As System.Windows.Forms.Button
    Friend WithEvents btnWhileGanjil As System.Windows.Forms.Button
    Friend WithEvents btnWhileGenap As System.Windows.Forms.Button
    Friend WithEvents btnJumNilai As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
