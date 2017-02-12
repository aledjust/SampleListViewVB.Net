<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddNewData
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
        Me.txtNik = New System.Windows.Forms.TextBox()
        Me.lblNik = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblJabatan = New System.Windows.Forms.Label()
        Me.lblGajiPokok = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cmbJabatan = New System.Windows.Forms.ComboBox()
        Me.txtGajiPokok = New System.Windows.Forms.TextBox()
        Me.RdSingle = New System.Windows.Forms.RadioButton()
        Me.RdMarried = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtJmlhAnak = New System.Windows.Forms.TextBox()
        Me.lblJmlhAnak = New System.Windows.Forms.Label()
        Me.cmbDivisi = New System.Windows.Forms.ComboBox()
        Me.lblDivisi = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.txtJamLembur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNik
        '
        Me.txtNik.Location = New System.Drawing.Point(147, 25)
        Me.txtNik.Name = "txtNik"
        Me.txtNik.Size = New System.Drawing.Size(159, 20)
        Me.txtNik.TabIndex = 0
        '
        'lblNik
        '
        Me.lblNik.AutoSize = True
        Me.lblNik.Location = New System.Drawing.Point(29, 25)
        Me.lblNik.Name = "lblNik"
        Me.lblNik.Size = New System.Drawing.Size(25, 13)
        Me.lblNik.TabIndex = 1
        Me.lblNik.Text = "NIK"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(29, 57)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(38, 13)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "NAMA"
        '
        'lblJabatan
        '
        Me.lblJabatan.AutoSize = True
        Me.lblJabatan.Location = New System.Drawing.Point(29, 127)
        Me.lblJabatan.Name = "lblJabatan"
        Me.lblJabatan.Size = New System.Drawing.Size(55, 13)
        Me.lblJabatan.TabIndex = 3
        Me.lblJabatan.Text = "JABATAN"
        '
        'lblGajiPokok
        '
        Me.lblGajiPokok.AutoSize = True
        Me.lblGajiPokok.Location = New System.Drawing.Point(29, 165)
        Me.lblGajiPokok.Name = "lblGajiPokok"
        Me.lblGajiPokok.Size = New System.Drawing.Size(70, 13)
        Me.lblGajiPokok.TabIndex = 4
        Me.lblGajiPokok.Text = "GAJI POKOK"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(29, 250)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(50, 13)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "STATUS"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(147, 57)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(159, 20)
        Me.txtNama.TabIndex = 6
        '
        'cmbJabatan
        '
        Me.cmbJabatan.FormattingEnabled = True
        Me.cmbJabatan.Location = New System.Drawing.Point(147, 127)
        Me.cmbJabatan.Name = "cmbJabatan"
        Me.cmbJabatan.Size = New System.Drawing.Size(159, 21)
        Me.cmbJabatan.TabIndex = 7
        '
        'txtGajiPokok
        '
        Me.txtGajiPokok.Location = New System.Drawing.Point(147, 165)
        Me.txtGajiPokok.Name = "txtGajiPokok"
        Me.txtGajiPokok.Size = New System.Drawing.Size(159, 20)
        Me.txtGajiPokok.TabIndex = 8
        '
        'RdSingle
        '
        Me.RdSingle.AutoSize = True
        Me.RdSingle.Location = New System.Drawing.Point(147, 246)
        Me.RdSingle.Name = "RdSingle"
        Me.RdSingle.Size = New System.Drawing.Size(54, 17)
        Me.RdSingle.TabIndex = 9
        Me.RdSingle.TabStop = True
        Me.RdSingle.Text = "Single"
        Me.RdSingle.UseVisualStyleBackColor = True
        '
        'RdMarried
        '
        Me.RdMarried.AutoSize = True
        Me.RdMarried.Location = New System.Drawing.Point(147, 269)
        Me.RdMarried.Name = "RdMarried"
        Me.RdMarried.Size = New System.Drawing.Size(60, 17)
        Me.RdMarried.TabIndex = 10
        Me.RdMarried.TabStop = True
        Me.RdMarried.Text = "Married"
        Me.RdMarried.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(61, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 237)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(223, 415)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(107, 49)
        Me.BtnAdd.TabIndex = 12
        Me.BtnAdd.Text = "Add New"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnBrowse)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(361, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 337)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profile Picture"
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(117, 274)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(107, 36)
        Me.BtnBrowse.TabIndex = 13
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtJamLembur)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtJmlhAnak)
        Me.GroupBox2.Controls.Add(Me.lblJmlhAnak)
        Me.GroupBox2.Controls.Add(Me.cmbDivisi)
        Me.GroupBox2.Controls.Add(Me.lblDivisi)
        Me.GroupBox2.Controls.Add(Me.cmbJabatan)
        Me.GroupBox2.Controls.Add(Me.txtNik)
        Me.GroupBox2.Controls.Add(Me.lblNik)
        Me.GroupBox2.Controls.Add(Me.RdMarried)
        Me.GroupBox2.Controls.Add(Me.lblNama)
        Me.GroupBox2.Controls.Add(Me.RdSingle)
        Me.GroupBox2.Controls.Add(Me.lblJabatan)
        Me.GroupBox2.Controls.Add(Me.txtGajiPokok)
        Me.GroupBox2.Controls.Add(Me.lblGajiPokok)
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Controls.Add(Me.txtNama)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 337)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profile"
        '
        'txtJmlhAnak
        '
        Me.txtJmlhAnak.Location = New System.Drawing.Point(147, 298)
        Me.txtJmlhAnak.Name = "txtJmlhAnak"
        Me.txtJmlhAnak.Size = New System.Drawing.Size(159, 20)
        Me.txtJmlhAnak.TabIndex = 14
        '
        'lblJmlhAnak
        '
        Me.lblJmlhAnak.AutoSize = True
        Me.lblJmlhAnak.Location = New System.Drawing.Point(29, 298)
        Me.lblJmlhAnak.Name = "lblJmlhAnak"
        Me.lblJmlhAnak.Size = New System.Drawing.Size(82, 13)
        Me.lblJmlhAnak.TabIndex = 13
        Me.lblJmlhAnak.Text = "JUMLAH ANAK"
        '
        'cmbDivisi
        '
        Me.cmbDivisi.FormattingEnabled = True
        Me.cmbDivisi.Location = New System.Drawing.Point(147, 92)
        Me.cmbDivisi.Name = "cmbDivisi"
        Me.cmbDivisi.Size = New System.Drawing.Size(159, 21)
        Me.cmbDivisi.TabIndex = 12
        '
        'lblDivisi
        '
        Me.lblDivisi.AutoSize = True
        Me.lblDivisi.Location = New System.Drawing.Point(29, 92)
        Me.lblDivisi.Name = "lblDivisi"
        Me.lblDivisi.Size = New System.Drawing.Size(38, 13)
        Me.lblDivisi.TabIndex = 11
        Me.lblDivisi.Text = "DIVISI"
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(408, 415)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(107, 49)
        Me.BtnClose.TabIndex = 15
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'txtJamLembur
        '
        Me.txtJamLembur.Location = New System.Drawing.Point(147, 203)
        Me.txtJamLembur.Name = "txtJamLembur"
        Me.txtJamLembur.Size = New System.Drawing.Size(159, 20)
        Me.txtJamLembur.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "JAM LEMBUR"
        '
        'FrmAddNewData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 501)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddNewData"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Data Pegawai"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNik As System.Windows.Forms.TextBox
    Friend WithEvents lblNik As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblJabatan As System.Windows.Forms.Label
    Friend WithEvents lblGajiPokok As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cmbJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents txtGajiPokok As System.Windows.Forms.TextBox
    Friend WithEvents RdSingle As System.Windows.Forms.RadioButton
    Friend WithEvents RdMarried As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents cmbDivisi As System.Windows.Forms.ComboBox
    Friend WithEvents lblDivisi As System.Windows.Forms.Label
    Friend WithEvents txtJmlhAnak As System.Windows.Forms.TextBox
    Friend WithEvents lblJmlhAnak As System.Windows.Forms.Label
    Friend WithEvents txtJamLembur As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
