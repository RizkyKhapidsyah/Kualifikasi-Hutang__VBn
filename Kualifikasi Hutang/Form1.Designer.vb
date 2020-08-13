<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.teksGajiPerTahun = New System.Windows.Forms.TextBox()
        Me.teksTahunKerja = New System.Windows.Forms.TextBox()
        Me.labelPesan = New System.Windows.Forms.Label()
        Me.tombolPeriksa = New System.Windows.Forms.Button()
        Me.tombolBersihkan = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.teksTahunKerja)
        Me.GroupBox1.Controls.Add(Me.teksGajiPerTahun)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan Informasi Berikut:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gaji Per Tahun:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telah Bekerja (dalam Tahun):"
        '
        'teksGajiPerTahun
        '
        Me.teksGajiPerTahun.Location = New System.Drawing.Point(165, 23)
        Me.teksGajiPerTahun.Name = "teksGajiPerTahun"
        Me.teksGajiPerTahun.Size = New System.Drawing.Size(152, 20)
        Me.teksGajiPerTahun.TabIndex = 2
        '
        'teksTahunKerja
        '
        Me.teksTahunKerja.Location = New System.Drawing.Point(165, 54)
        Me.teksTahunKerja.Name = "teksTahunKerja"
        Me.teksTahunKerja.Size = New System.Drawing.Size(152, 20)
        Me.teksTahunKerja.TabIndex = 3
        '
        'labelPesan
        '
        Me.labelPesan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelPesan.Location = New System.Drawing.Point(13, 132)
        Me.labelPesan.Name = "labelPesan"
        Me.labelPesan.Size = New System.Drawing.Size(332, 23)
        Me.labelPesan.TabIndex = 1
        Me.labelPesan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tombolPeriksa
        '
        Me.tombolPeriksa.Location = New System.Drawing.Point(13, 184)
        Me.tombolPeriksa.Name = "tombolPeriksa"
        Me.tombolPeriksa.Size = New System.Drawing.Size(116, 41)
        Me.tombolPeriksa.TabIndex = 2
        Me.tombolPeriksa.Text = "Periksa Kualifikasi"
        Me.tombolPeriksa.UseVisualStyleBackColor = True
        '
        'tombolBersihkan
        '
        Me.tombolBersihkan.Location = New System.Drawing.Point(135, 184)
        Me.tombolBersihkan.Name = "tombolBersihkan"
        Me.tombolBersihkan.Size = New System.Drawing.Size(103, 41)
        Me.tombolBersihkan.TabIndex = 3
        Me.tombolBersihkan.Text = "Bersihkan"
        Me.tombolBersihkan.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(244, 184)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(101, 41)
        Me.tombolKeluar.TabIndex = 4
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 244)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolBersihkan)
        Me.Controls.Add(Me.tombolPeriksa)
        Me.Controls.Add(Me.labelPesan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Kualifikasi Hutang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents teksTahunKerja As System.Windows.Forms.TextBox
    Friend WithEvents teksGajiPerTahun As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labelPesan As System.Windows.Forms.Label
    Friend WithEvents tombolPeriksa As System.Windows.Forms.Button
    Friend WithEvents tombolBersihkan As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
