Public Class FormPembayaran

    Private Sub btnCekPembayaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCekPembayaran.Click
        oSewa.Carisewa(txtKodePembayaran.Text)
        If (sewa_baru = False) Then
            TampilSewa()
        Else
            MessageBox.Show("Data tidak ditemukan")
        End If
    End Sub

    Private Sub TampilSewa()
        txtKodePembayaran.Text = oSewa.kode_bayar
        txtNama.Text = oSewa.nama
        txtUmur.Text = oSewa.usia
        txtAlamat.Text = oSewa.alamat
        If (oSewa.pilihan_paket = "Paket 1") Then
            txtPilihanPaket.Text = "Paket 1"
        ElseIf (oSewa.pilihan_paket = "Paket 2") Then
            txtPilihanPaket.Text = "Paket 2"
        ElseIf (oSewa.pilihan_paket = "Paket 3") Then
            txtPilihanPaket.Text = "Paket 3"
        Else
            txtPilihanPaket.Text = ""
        End If
        txtYgHrsByr.Text = oSewa.harga
    End Sub

    Private Sub Kembalian()
        txtKembalian.Text = txtUangTunai.Text - txtYgHrsByr.Text
    End Sub

    Private Sub bbtnKembalian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbtnKembalian.Click
        Kembalian()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        MessageBox.Show("Pembayaran Telah Berhasil", "Terima Kasih")
        Me.Close()
    End Sub
End Class
