Public Class TakeOuT_Form

    Public Shared SelectedRent
    Public Shared Total_Biaya
    Public Shared SelectedHarga = Sewa.SelectedHarga
    Public Shared Total

    'Public Shared Penyewaan As Penyewaan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataRent()
        'Penyewaan = New Penyewaan()
    End Sub

    Private Sub ReloadDataRent()
        DGVRent.DataSource = Sewa.Penyewaan.GetDataSewaDatabase()
    End Sub

    Private Sub TakeOuT_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataRent()
    End Sub

    Private Sub BtnTakeOut_Click(sender As Object, e As EventArgs) Handles BtnTakeOut.Click
        Total = Sewa.TotalHarga + Integer.Parse(LBMinusPrice.Text)
        Sewa.Penyewaan.waktu_kembaliProperty = Integer.Parse(TBTime.Text)
        'MessageBox.Show(Penyewaan.waktu_sewaproperty)
        Sewa.Penyewaan.kelebihan_pinjamProperty = Integer.Parse(LBMinusPrice.Text)
        Sewa.Penyewaan.total_biayaProperty = Total.ToString()

        Sewa.Penyewaan.UpdateDataKembaliDatabase(SelectedRent,
                                                  Sewa.Penyewaan.waktu_kembaliProperty,
                                                  Sewa.Penyewaan.kelebihan_pinjamProperty,
                                                  Sewa.Penyewaan.total_biayaProperty)
        Dim KembaliKeSewa = New Sewa()
        KembaliKeSewa.Show()
        Me.Close()
    End Sub

    Private Sub DGVRent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRent.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGVRent.Rows(index)

        SelectedRent = selectedRow.Cells(0).Value

    End Sub

    Private Sub TBTime_TextChanged(sender As Object, e As EventArgs) Handles TBTime.TextChanged
        If TBTime.Text <> "" Then
            Total_Biaya = TBTime.Text * Integer.Parse(SelectedHarga)
            LBMinusPrice.Text = Total_Biaya
        End If
    End Sub
End Class