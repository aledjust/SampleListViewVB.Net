Public Class FrmFind

#Region "Designer"
    Private Sub TxtFindKeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFind.KeyPress
        FindData(e)
    End Sub
    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Dispose()
    End Sub
#End Region

#Region "Method"
    Private Sub FindData(e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Return) Then
            Dim result = FrmPenggajian.LvKaryawan.FindItemWithText(txtFind.Text, False, False)
            If result IsNot Nothing Then
                FrmPenggajian.LvKaryawan.Items(result.Index).Selected = True
                FrmPenggajian.LvKaryawan.Items(result.Index).Focused = True
                FrmPenggajian.LvKaryawan.TopItem = FrmPenggajian.LvKaryawan.Items(result.Index)
                'Me.Dispose()
            Else
                MessageBox.Show("Data tidak ditemukan")
            End If

        End If
    End Sub
#End Region

    
End Class