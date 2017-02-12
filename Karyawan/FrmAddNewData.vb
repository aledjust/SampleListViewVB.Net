Imports System.IO
Imports System.Linq

Public Class FrmAddNewData

#Region "Designer"
    Private Sub FrmAddNewData_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FrmLoad()
    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Dispose()
    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click
        AddData()
    End Sub

    Private Sub RdSingle_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdSingle.CheckedChanged
        CheckStatus()
    End Sub

    Private Sub TxtJmlhAnakKeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlhAnak.KeyPress
        ValidateNumber(e)
    End Sub

    Private Sub TxtGajiPokokKeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtGajiPokok.KeyPress
        ValidateNumber(e)
    End Sub

    Private Sub TxtJamLemburKeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtJamLembur.KeyPress
        ValidateNumber(e)
        ValidateNumberMinOne()
    End Sub

    Private Sub TxtJmlhAnakTextChanged(sender As System.Object, e As System.EventArgs) Handles txtJmlhAnak.TextChanged
        ValidateMax()
    End Sub

    Private Sub BtnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles BtnBrowse.Click
        BrowseImage()
    End Sub
#End Region

#Region "Method"
    Private Sub FrmLoad()
        InitComboDivisi()
        InitComboJabatan()
        ClearForm()
    End Sub

    Private Sub AddData()
        Try
            'Validasi data sudah diinput dengan benar
            If txtNama.Text = String.Empty Then
                MessageBox.Show("Isi Nama")
                Return
            ElseIf cmbDivisi.SelectedValue = String.Empty Then
                MessageBox.Show("Pilih divisi")
                Return
            ElseIf cmbJabatan.SelectedValue = String.Empty Then
                MessageBox.Show("Pilih jabatan")
                Return
            ElseIf txtGajiPokok.Text = String.Empty Then
                MessageBox.Show("Masukkan Gaji!")
                Return
            End If

            Dim jabatan As String

            If cmbJabatan.SelectedValue = New EMsJabatan().EKabagCode Then
                jabatan = New EMsJabatan().EKabagDsc
            ElseIf cmbJabatan.SelectedValue = New EMsJabatan().EWaKabagCode Then
                jabatan = New EMsJabatan().EWKabagDsc
            Else
                jabatan = New EMsJabatan().EStafDsc
            End If

            Dim img = PictureBox1.ImageLocation
            If img Is Nothing Then
                img = String.Empty
            End If
            FrmPenggajian.karyawanListData.Add(New KaryawanEntities() With {.Nik = GetFormatCode(), .Nama = txtNama.Text, .Jabatan = jabatan,
                                                              .Status = If(RdMarried.Checked, "Merried", "Single"), .ImgUri = img, .GajiPokok = Val(txtGajiPokok.Text),
                                                              .TunjanganAnak = (150000 * (Val(txtJmlhAnak.Text))),
                                                              .TunjanganIstri = 250000, .JamLembur = Val(txtJamLembur.Text),
                                                              .Pajak = (0.1 * (Val(txtGajiPokok.Text))), .TotalGaji = CalCulateTotalGaji()
                                                             })
            FrmPenggajian.RebindListView()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub InitComboDivisi()
        Dim dt As New DataTable
        dt.Columns.Add("DivisiCode")
        dt.Columns.Add("DivisiDsc")

        dt.Rows.Add(New EMsDivision().EAdmCode, New EMsDivision().EAdmDsc)
        dt.Rows.Add(New EMsDivision().EProdCode, New EMsDivision().EProdDsc)
        dt.Rows.Add(New EMsDivision().EFinCode, New EMsDivision().EFinDsc)

        cmbDivisi.DataSource = dt
        cmbDivisi.DisplayMember = "DivisiDsc"
        cmbDivisi.ValueMember = "DivisiCode"
        cmbDivisi.SelectedIndex = -1

    End Sub
    Private Sub InitComboJabatan()
        Dim dt As New DataTable
        dt.Columns.Add("JabatanCode")
        dt.Columns.Add("JabatanDsc")

        dt.Rows.Add(New EMsJabatan().EKabagCode, New EMsJabatan().EKabagDsc)
        dt.Rows.Add(New EMsJabatan().EWaKabagCode, New EMsJabatan().EWKabagDsc)
        dt.Rows.Add(New EMsJabatan().EStafCode, New EMsJabatan().EStafDsc)

        cmbJabatan.DataSource = dt
        cmbJabatan.DisplayMember = "JabatanDsc"
        cmbJabatan.ValueMember = "JabatanCode"
        cmbJabatan.SelectedIndex = -1

    End Sub

    Private Sub CheckStatus()
        If RdSingle.Checked Then
            txtJmlhAnak.Text = String.Empty
            txtJmlhAnak.Enabled = False
        End If

        If RdMarried.Checked Then
            txtJmlhAnak.Text = String.Empty
            txtJmlhAnak.Enabled = True
        End If
    End Sub

    Private Sub ClearForm()
        txtNik.Text = String.Empty
        txtNama.Text = String.Empty
        txtGajiPokok.Text = String.Empty
        txtJmlhAnak.Text = String.Empty
        RdSingle.Checked = True

        txtNik.Enabled = False
        txtNik.Text = GetFormatCode()
        txtNama.Focus()
    End Sub

    Private Sub ValidateNumber(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub ValidateNumberMinOne()
        If txtJmlhAnak.Text = "0" Then
            txtJmlhAnak.Text = "1"
        End If
    End Sub
    Private Sub ValidateMax()
        If Val(txtJmlhAnak.Text) > 3 Then
            MessageBox.Show("Maksimal Anak 3, tolong ikuti Keluarga Berencana :D")
        End If
    End Sub

    Private Sub BrowseImage()
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Choose a Profile Photo"
        fdlg.InitialDirectory = "d:\"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            If File.Exists(fdlg.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                PictureBox1.ImageLocation = fdlg.FileName
            End If

        End If
    End Sub

    Private Function CalCulateTotalGaji()
        Dim totalGaji As Double

        totalGaji = (Val(txtGajiPokok.Text) - (Val(txtGajiPokok.Text) * 0.1))

        'Cek Jabatannya
        If cmbJabatan.SelectedValue = New EMsJabatan().EKabagCode Then

            'cek ada lembur gak
            If (txtJamLembur.Text <> String.Empty) Then
                totalGaji += (30000 * Val(txtJamLembur.Text))
            End If

            'cek udah merried apa belom (klo belom jones :D )
            If RdMarried.Checked() Then
                'tambahin tunjangan istri (Sama untuk semua gol 250.000)
                totalGaji += 250000

                'cek punya anak gak
                totalGaji += (Val(txtJmlhAnak.Text) * 150000)
            End If

        ElseIf cmbJabatan.SelectedValue = New EMsJabatan().EWaKabagCode Then

            'cek ada lembur gak
            If (txtJamLembur.Text <> String.Empty) Then
                totalGaji += (25000 * Val(txtJamLembur.Text))
            End If

            'cek udah merried apa belom (klo belom jones :D )
            If RdMarried.Checked() Then
                'tambahin tunjangan istri (Sama untuk semua gol 250.000)
                totalGaji += 250000

                'cek punya anak gak
                totalGaji += (Val(txtJmlhAnak.Text) * 150000)
            End If

        Else

            'cek ada lembur gak
            If (txtJamLembur.Text <> String.Empty) Then
                totalGaji += (17500 * Val(txtJamLembur.Text))
            End If

            'cek udah merried apa belom (klo belom jones :D )
            If RdMarried.Checked() Then
                'tambahin tunjangan istri (Sama untuk semua gol 250.000)
                totalGaji += 250000

                'cek punya anak gak
                totalGaji += (Val(txtJmlhAnak.Text) * 150000)
            End If


        End If

        Return totalGaji
    End Function

    Private Function GetFormatCode()

        Dim formatCode = String.Empty
        Dim nik = FrmPenggajian.karyawanListData(FrmPenggajian.karyawanListData.Count - 1)

        'Untuk Ambil Format 3 digit didepan xxx001001
        formatCode = Microsoft.VisualBasic.Left(nik.Nik, 3)

        'Untuk Format 3 digit ditengah NKPxxx001
        If (Len((Val(Mid(nik.Nik, 4, 3)) + 1).ToString())) = 1 Then
            formatCode += "00" + (Val(Mid(nik.Nik, 4, 3)) + 1).ToString()
        ElseIf (Len((Val(Mid(nik.Nik, 4, 3)) + 1).ToString())) = 2 Then
            formatCode += "0" + (Val(Mid(nik.Nik, 4, 3)) + 1).ToString()
        Else
            formatCode += (Val(Mid(nik.Nik, 4, 3)) + 1).ToString()
        End If

        'Untuk Format 3 digit dibelakang NKP001xxx
        If (Len((Val(Microsoft.VisualBasic.Right(nik.Nik, 3) + 1).ToString()))) = 1 Then
            formatCode += "00" + (Val(Microsoft.VisualBasic.Right(nik.Nik, 3) + 1)).ToString()
        ElseIf (Len((Val(Microsoft.VisualBasic.Right(nik.Nik, 3) + 1).ToString()))) = 2 Then
            formatCode += "0" + (Val(Microsoft.VisualBasic.Right(nik.Nik, 3) + 1).ToString())
        Else
            formatCode += (Val(Microsoft.VisualBasic.Right(nik.Nik, 3) + 1).ToString())
        End If

        Return formatCode
    End Function
#End Region


End Class