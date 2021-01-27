Public Class Form1

    Private Sub Simpan()
        sewa_baru = True
        oSewa.kode_bayar() = txtKodeBayar.Text
        oSewa.nama() = txtNama.Text
        oSewa.usia() = txtUsia.Text
        oSewa.alamat() = txtAlamat.Text
        If (rbPkt1.Checked = True) Then
            oSewa.pilihan_paket = "Paket 1"
        End If
        If (rbPkt2.Checked = True) Then
            oSewa.pilihan_paket = "Paket 2"
        End If
        If (rbPkt3.Checked = True) Then
            oSewa.pilihan_paket = "Paket 3"
        End If
        oSewa.harga() = txtHarga.Text

        oSewa.Simpan()

        Reload()
        If (oSewa.InsertState = True) Then
            MessageBox.Show("Data Berhasil Disimpan.")
        ElseIf (oSewa.UpdateState = True) Then
            MessageBox.Show("Data Berhasil Diperbarui.")
        Else
            MessageBox.Show("Data Gagal Disimpan.")
        End If
        ClearEntry()
    End Sub

    Private Sub ClearEntry()
        txtKodeBayar.Clear()
        txtNama.Clear()
        txtUsia.Clear()
        txtAlamat.Clear()
        rbPkt1.Checked = False
        rbPkt2.Checked = False
        rbPkt3.Checked = False
        txtHarga.Clear()
        txtKodeBayar.Focus()
    End Sub

    Private Sub Reload()
        oSewa.getAllData(DataGridView1)
    End Sub

    Private Sub Hapus()
        If (sewa_baru = False And txtKodeBayar.Text <> "") Then
            oSewa.Hapus(txtKodeBayar.Text)
            ClearEntry()
            Reload()
        End If
    End Sub

    Private Sub rbPkt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPkt1.CheckedChanged
        txtHarga.Text = "150000"
    End Sub

    Private Sub rbPkt2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPkt2.CheckedChanged
        txtHarga.Text = "230000"
    End Sub

    Private Sub rbPkt3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPkt3.CheckedChanged
        txtHarga.Text = "290000"
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If (txtKodeBayar.Text <> "") Then
            Simpan()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("Kode Pembayaran Tidak Boleh Kosong!")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearEntry()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Hapus()
    End Sub

    Private Sub txtKodeBayar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBayar.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oSewa.Carisewa(txtKodeBayar.Text)
            If (sewa_baru = False) Then
                TampilSewa()
            Else
                MessageBox.Show("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub TampilSewa()
        txtKodeBayar.Text = oSewa.kode_bayar
        txtNama.Text = oSewa.nama
        txtUsia.Text = oSewa.usia
        txtAlamat.Text = oSewa.alamat
        If (oSewa.pilihan_paket = "Paket 1") Then
            rbPkt1.Checked = True
        ElseIf (oSewa.pilihan_paket = "Paket 2") Then
            rbPkt2.Checked = True
        ElseIf (oSewa.pilihan_paket = "Paket 3") Then
            rbPkt3.Checked = True
        Else
            rbPkt1.Checked = False
            rbPkt2.Checked = False
            rbPkt3.Checked = False
        End If
        txtHarga.Text = oSewa.harga

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
