Public Class frmWhile
    Dim I As Integer
    Private Sub btnWhile1_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhile1_10.Click
        lbHasil.Items.Clear()
        I = 1
        'Looping selama kondisi bernilai benar
        'While I <= 10
        ' lbHasil.Items.Add(I)
        ' I = I + 1
        'End While
        'Looping selama kondisi bernilai benar
        Do While I <= 10
            lbHasil.Items.Add(I)
            I = I + 1
        Loop
        'Looping selama kondisi bernilai salah
        'Do
        ' lbHasil.Items.Add(I)
        ' I = I + 1
        'Loop Until I > 10
    End Sub
    Private Sub btnWhileGanjil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhileGanjil.Click
        lbHasil.Items.Clear()
        I = 1
        While I <= 10
            lbHasil.Items.Add(I)
            I = I + 2
        End While
    End Sub    Private Sub btnJumNilai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJumNilai.Click
        Dim Jum As Integer
        lbHasil.Items.Clear()
        I = 1
        Jum = 0
        While I <= 10
            lbHasil.Items.Add(Jum & " + " & I & " = " & Jum + I)
            Jum = Jum + I
            I = I + 1
        End While
    End Sub    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class