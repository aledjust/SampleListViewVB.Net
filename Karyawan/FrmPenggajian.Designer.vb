<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPenggajian
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
        Me.LvKaryawan = New System.Windows.Forms.ListView()
        Me.colNik = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNama = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colJabatan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGajiPokok = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTunjanganIstri = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTunjanganAnak = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colJamLembur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPajak = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotalGaji = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_max = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_totalpage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_hal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.colImage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.txt_max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LvKaryawan
        '
        Me.LvKaryawan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvKaryawan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNik, Me.colNama, Me.colJabatan, Me.colGajiPokok, Me.colStatus, Me.colTunjanganIstri, Me.colTunjanganAnak, Me.colJamLembur, Me.colPajak, Me.colTotalGaji, Me.colImage})
        Me.LvKaryawan.FullRowSelect = True
        Me.LvKaryawan.Location = New System.Drawing.Point(12, 175)
        Me.LvKaryawan.Name = "LvKaryawan"
        Me.LvKaryawan.Size = New System.Drawing.Size(920, 178)
        Me.LvKaryawan.TabIndex = 0
        Me.LvKaryawan.UseCompatibleStateImageBehavior = False
        Me.LvKaryawan.View = System.Windows.Forms.View.Details
        '
        'colNik
        '
        Me.colNik.Text = "NIK"
        Me.colNik.Width = 150
        '
        'colNama
        '
        Me.colNama.Text = "NAMA"
        Me.colNama.Width = 150
        '
        'colJabatan
        '
        Me.colJabatan.Text = "JABATAN"
        Me.colJabatan.Width = 150
        '
        'colGajiPokok
        '
        Me.colGajiPokok.Text = "GAJI POKOK"
        Me.colGajiPokok.Width = 150
        '
        'colStatus
        '
        Me.colStatus.Text = "STATUS"
        Me.colStatus.Width = 80
        '
        'colTunjanganIstri
        '
        Me.colTunjanganIstri.Text = "TUNJANGAN ISTRI"
        Me.colTunjanganIstri.Width = 150
        '
        'colTunjanganAnak
        '
        Me.colTunjanganAnak.Text = "TUNJANGAN ANAK"
        Me.colTunjanganAnak.Width = 150
        '
        'colJamLembur
        '
        Me.colJamLembur.Text = "JAM LEMBUR"
        Me.colJamLembur.Width = 150
        '
        'colPajak
        '
        Me.colPajak.Text = "PAJAK"
        Me.colPajak.Width = 150
        '
        'colTotalGaji
        '
        Me.colTotalGaji.Text = "TOTAL GAJI"
        Me.colTotalGaji.Width = 150
        '
        'txt_max
        '
        Me.txt_max.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_max.Location = New System.Drawing.Point(138, 374)
        Me.txt_max.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_max.Name = "txt_max"
        Me.txt_max.Size = New System.Drawing.Size(41, 20)
        Me.txt_max.TabIndex = 12
        Me.txt_max.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Jumlah Baris / Halaman"
        '
        'lbl_totalpage
        '
        Me.lbl_totalpage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_totalpage.AutoSize = True
        Me.lbl_totalpage.Location = New System.Drawing.Point(141, 411)
        Me.lbl_totalpage.Name = "lbl_totalpage"
        Me.lbl_totalpage.Size = New System.Drawing.Size(39, 13)
        Me.lbl_totalpage.TabIndex = 16
        Me.lbl_totalpage.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "/"
        '
        'cbo_hal
        '
        Me.cbo_hal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbo_hal.FormattingEnabled = True
        Me.cbo_hal.Location = New System.Drawing.Point(69, 406)
        Me.cbo_hal.Name = "cbo_hal"
        Me.cbo_hal.Size = New System.Drawing.Size(48, 21)
        Me.cbo_hal.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Halaman"
        '
        'BtnLast
        '
        Me.BtnLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLast.Location = New System.Drawing.Point(864, 376)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(61, 23)
        Me.BtnLast.TabIndex = 20
        Me.BtnLast.Tag = "3"
        Me.BtnLast.Text = ">>"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNext.Location = New System.Drawing.Point(797, 376)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(61, 23)
        Me.BtnNext.TabIndex = 19
        Me.BtnNext.Tag = "2"
        Me.BtnNext.Text = ">"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrev.Location = New System.Drawing.Point(730, 376)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(61, 23)
        Me.BtnPrev.TabIndex = 18
        Me.BtnPrev.Tag = "1"
        Me.BtnPrev.Text = "<"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFirst.Location = New System.Drawing.Point(663, 376)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(61, 23)
        Me.BtnFirst.TabIndex = 17
        Me.BtnFirst.Tag = "0"
        Me.BtnFirst.Text = "<<"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Location = New System.Drawing.Point(16, 40)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(105, 76)
        Me.BtnAddNew.TabIndex = 21
        Me.BtnAddNew.Tag = "1"
        Me.BtnAddNew.Text = "ADD NEW"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Location = New System.Drawing.Point(156, 40)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(105, 76)
        Me.BtnFind.TabIndex = 22
        Me.BtnFind.Tag = "1"
        Me.BtnFind.Text = "FIND DATA"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(42, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 110)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(445, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 140)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profile Picture"
        '
        'colImage
        '
        Me.colImage.Text = ""
        Me.colImage.Width = 0
        '
        'FrmPenggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(944, 456)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnFind)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnPrev)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.lbl_totalpage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbo_hal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_max)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LvKaryawan)
        Me.Name = "FrmPenggajian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":.. Karyawan Apps ..:"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txt_max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LvKaryawan As System.Windows.Forms.ListView
    Friend WithEvents colNik As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNama As System.Windows.Forms.ColumnHeader
    Friend WithEvents colJabatan As System.Windows.Forms.ColumnHeader
    Friend WithEvents colGajiPokok As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTunjanganIstri As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTunjanganAnak As System.Windows.Forms.ColumnHeader
    Friend WithEvents colJamLembur As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPajak As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTotalGaji As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_max As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_totalpage As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_hal As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents colImage As System.Windows.Forms.ColumnHeader

End Class
