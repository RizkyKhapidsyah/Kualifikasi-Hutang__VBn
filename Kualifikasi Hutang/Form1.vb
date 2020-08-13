Public Class Form1

    Private Sub tombolPeriksa_Click(sender As Object, e As EventArgs) Handles tombolPeriksa.Click
        'variabel-variabel untuk memuat data masukan
        Dim dblGaji As Double
        Dim intTahunBekerja As Integer

        Try
            ' Get the user's input.
            dblGaji = CDbl(teksGajiPerTahun.Text)
            intTahunBekerja = CInt(teksTahunKerja.Text)

            'menentukan apakah aplikan memenuhi kualifikasi
            'untuk menerima pinjaman
            If dblGaji > 300000000 Then
                If intTahunBekerja > 2 Then
                    labelPesan.Text = "Aplikan memenuhi kualifiksi"
                Else
                    labelPesan.Text = "Aplikan tidak memenuhi kualifiksi"
                End If
            Else
                If intTahunBekerja > 5 Then
                    labelPesan.Text = "Aplikan memenuhi kualifiksi"
                Else
                    labelPesan.Text = "Aplikan tidak memenuhi kualifiksi"
                End If
            End If
        Catch ex As Exception
            'menampilkan pesan error.
            labelPesan.Text = "Masukkan nilai numerik"
        End Try
    End Sub

    Private Sub tombolBersihkan_Click(sender As Object, e As EventArgs) Handles tombolBersihkan.Click
        teksGajiPerTahun.Text = String.Empty
        teksTahunKerja.Text = String.Empty
        labelPesan.Text = String.Empty

        'mengatur fokus kembali ke teksSkor1
        teksGajiPerTahun.Focus()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
