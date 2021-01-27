Public Class FormInformasi

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Paket1()
    End Sub

    Private Sub Paket1()
        MessageBox.Show("Durasi 120 menit, Maks. 3 orang, Harga Rp. 150000", "Paket 1")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Paket2()
    End Sub

    Private Sub Paket2()
        MessageBox.Show("Durasi 150 menit, Maks. 6 orang, Harga Rp. 230000", "Paket 2")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Paket3()
    End Sub

    Private Sub Paket3()
        MessageBox.Show("Durasi 180 menit, Maks. 10 orang, Harga 290000", "Paket 3")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Peraturan()
    End Sub

    Private Sub Peraturan()
        MessageBox.Show("Tidak Boleh Merokok!, Tidak Boleh Mesum!, Tidak Boleh Membawa Narkoba!", "Peraturan")
    End Sub
End Class
