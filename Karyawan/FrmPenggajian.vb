Public Class FrmPenggajian

    Private Property maxresult As Integer = 1
    Private Property from As Integer
    Private Property hal As Integer = 1
    Private Property totalresult As Integer
    Private Property totalpage As Integer

    'New KaryawanEntities List
    Public karyawanListData As New List(Of KaryawanEntities)

#Region "Designer"

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddDataDummy()
        GetTotalPage()
    End Sub

    Private Sub cbo_hal_TextChanged(sender As System.Object, e As System.EventArgs) Handles cbo_hal.TextChanged
        CboHalChanged()
    End Sub
    Private Sub txt_max_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_max.ValueChanged
        TxtChanged()
    End Sub

    Private Sub BtnFirst_Click(sender As System.Object, e As System.EventArgs) Handles BtnFirst.Click
        FirstData()
    End Sub
    Private Sub BtnPrev_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrev.Click
        PrevData()
    End Sub
    Private Sub BtnNext_Click(sender As System.Object, e As System.EventArgs) Handles BtnNext.Click
        NextData()
    End Sub
    Private Sub BtnLast_Click(sender As System.Object, e As System.EventArgs) Handles BtnLast.Click
        LastData()
    End Sub

    Private Sub BtnAddNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddNew.Click
        AddNewData()
    End Sub
    Private Sub BtnFind_Click(sender As System.Object, e As System.EventArgs) Handles BtnFind.Click
        FindDialog()
    End Sub

    Private Sub LvKaryawan_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LvKaryawan.SelectedIndexChanged
        SetImageUrl()
    End Sub
#End Region

#Region "Method"


    Private Sub AddDataDummy()
        karyawanListData.Add(New KaryawanEntities() With {.Nik = "NKP001001", .Nama = "ALED", .Jabatan = "Manager",
                                                          .Status = "Single", .ImgUri = String.Empty, .GajiPokok = 15000000, .TunjanganAnak = 2500000,
                                                          .TunjanganIstri = 3500000, .JamLembur = 2, .Pajak = 3000000, .TotalGaji = 21000000
                                                         })
        karyawanListData.Add(New KaryawanEntities() With {.Nik = "NKP001002", .Nama = "INDAH", .Jabatan = "SPV",
                                                          .Status = "Single", .ImgUri = String.Empty, .GajiPokok = 15000000, .TunjanganAnak = 2500000,
                                                          .TunjanganIstri = 3500000, .JamLembur = 3, .Pajak = 3000000, .TotalGaji = 21000000
                                                         })
    End Sub

    Public Sub RebindListView()
        pagging(LvKaryawan)
    End Sub

    Private Sub GetTotalPage()
        Try
            ' Mendapatkan jumlah data yang ada di listData
            If karyawanListData.Count > 0 Then
                totalresult = karyawanListData.Count
            Else
                totalresult = 1
            End If

            'Menentukan jumlah halaman
            Dim tmp As String = totalresult / maxresult
            If tmp <= 0 Then
                totalpage = 1
                maxresult = totalresult
            Else
                Dim splitdigit As String() = Split(tmp, ".")
                If splitdigit.Length > 1 Then
                    totalpage = splitdigit(0) + 1
                Else
                    totalpage = tmp
                End If
            End If

            lbl_totalpage.Text = totalpage

            ' Mengisi items pada combobox 
            cbo_hal.Items.Clear()
            cbo_hal.Text = hal
            For i As Integer = 1 To totalpage
                cbo_hal.Items.Add(i)
            Next

            'Panngil procedure pagging
            pagging(LvKaryawan)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub pagging(ByVal olistview As ListView)

        'Menentukan batas data yang akan ditampilkan
        from = (maxresult * hal) - maxresult
        cbo_hal.Text = hal

        ' Menampilkan data ke listview
        LvKaryawan.Items.Clear()


        If karyawanListData.Count > 1 Then
            'If maxresult > karyawanListData.Count Then
            '    maxresult = karyawanListData.Count
            'End If

            'If maxresult > 1 Then
            '    maxresult = maxresult - 1
            'ElseIf maxresult = 1 Then
            '    maxresult = 0
            'End If
            For value As Integer = from To maxresult

                Dim lv As New ListViewItem
                lv.Text = karyawanListData(value).Nik.ToString()
                lv.SubItems.Add(karyawanListData(value).Nama.ToString())
                lv.SubItems.Add(karyawanListData(value).Jabatan.ToString())
                lv.SubItems.Add(karyawanListData(value).GajiPokok.ToString())
                lv.SubItems.Add(karyawanListData(value).Status.ToString())
                lv.SubItems.Add(karyawanListData(value).TunjanganIstri.ToString())
                lv.SubItems.Add(karyawanListData(value).TunjanganAnak.ToString())
                lv.SubItems.Add(karyawanListData(value).JamLembur.ToString())
                lv.SubItems.Add(karyawanListData(value).Pajak.ToString())
                lv.SubItems.Add(karyawanListData(value).TotalGaji.ToString())
                lv.SubItems.Add(karyawanListData(value).ImgUri.ToString())
                LvKaryawan.Items.Add(lv)
            Next
        End If


        'Retrieving values from List
        'For Each obj As KaryawanEntities In karyawanListData

        'Next
    End Sub

    Private Sub CboHalChanged()
        hal = cbo_hal.Text
        pagging(LvKaryawan)
    End Sub
    Private Sub TxtChanged()
        hal = 1
        maxresult = txt_max.Value
        GetTotalPage()
    End Sub

    Private Sub AddNewData()
        FrmAddNewData.ShowDialog()
    End Sub

    Private Sub FindDialog()
        FrmFind.ShowDialog()
    End Sub

    Private Sub SetImageUrl()
        Try
            If LvKaryawan.SelectedItems.Count > 0 Then
                Dim result = LvKaryawan.SelectedItems(0).SubItems(10).Text
                PictureBox1.ImageLocation = result
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "Paging"
    Private Sub FirstData()
        hal = 1
        pagging(LvKaryawan)
    End Sub
    Private Sub PrevData()
        Dim halaman As Integer = hal - 1
        If halaman < 1 Then
            hal = 1
        Else
            hal = halaman
        End If
        pagging(LvKaryawan)
    End Sub
    Private Sub NextData()
        Dim halaman As Integer = hal + 1
        If halaman > totalpage Then
            hal = totalpage
        Else
            hal = halaman
        End If
        pagging(LvKaryawan)
    End Sub
    Private Sub LastData()
        hal = totalpage
        pagging(LvKaryawan)
    End Sub
#End Region

#End Region


End Class


