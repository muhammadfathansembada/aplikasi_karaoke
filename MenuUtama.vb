Public Class MenuUtama

    Private Sub btnMenuOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuOrder.Click
        MenuSewa()
    End Sub

    Private Sub MenuSewa()
        Form1.Show()
    End Sub

    Private Sub btnMenuInformasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuInformasi.Click
        MenuInformasi()
    End Sub

    Private Sub MenuInformasi()
        FormInformasi.Show()
    End Sub

    Private Sub btnMenuPembayaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuPembayaran.Click
        MenuPembayaran()
    End Sub

    Private Sub MenuPembayaran()
        FormPembayaran.Show()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        End
    End Sub
End Class
