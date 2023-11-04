Public Class frmWhile2
    Private Sub frmWhile2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        i = 0
        'Berulang Selama Kondisi Bernilai Benar
        While i < 10
            i = i + 1
            ComboBox1.Items.Add(i)
        End While
        'Berulang Selama Kondisi Bernilai Benar
        i = 0
        Do While i < 10
            i = i + 1
            ComboBox2.Items.Add(i)
            'If i = 5 Then
            ' Exit Do
            'End If
        Loop
        'Berulang Selama Kondisi Bernilai Salah
        i = 0
        Do Until i >= 10
            i = i + 1
            ComboBox3.Items.Add(i)
        Loop
        'Berulang Selama Kondisi Bernilai Benar
        i = 0
        Do
            i = i + 1
            ComboBox4.Items.Add(i)
        Loop While i < 10
        'Berulang Selama Kondisi Bernilai Salah
        i = 0
        Do
            i = i + 1
            ComboBox5.Items.Add(i)
        Loop Until i >= 10
    End Sub
End Class