Public Class Sewa

    Public Shared selectedLocker
    Public Shared SelectedHarga As Integer
    Public Shared SelectedJenisLocker
    Public Shared TotalHarga

    Public Shared Penyewaan As Penyewaan
    Public Shared Locker As Locker

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Locker = New Locker()
        Penyewaan = New Penyewaan()
        ReloadDataLocker()
    End Sub

    Private Sub ReloadDataLocker()
        DGVLocker.DataSource = Locker.GetDataLockerDatabase()
    End Sub

    Private Sub Sewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataLocker()
    End Sub
    Private Sub DGVLocker_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLocker.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGVLocker.Rows(index)

        selectedLocker = selectedRow.Cells(0).Value
        SelectedJenisLocker = selectedRow.Cells(1).Value
        SelectedHarga = selectedRow.Cells(3).Value

        LblHarga.Text = SelectedHarga

    End Sub

    Private Sub BtnFinishRent_Click(sender As Object, e As EventArgs) Handles BtnFinishRent.Click
        Dim Finish = New TakeOut_Form()
        Finish.Show()
        Me.Close()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub TBDuration_TextChanged(sender As Object, e As EventArgs) Handles TBDuration.TextChanged
        If TBDuration.Text <> "" Then
            TotalHarga = Integer.Parse(SelectedHarga) * Integer.Parse(TBDuration.Text)
            lbtotalbiaya.Text = TotalHarga
        End If
    End Sub

    Private Sub BtnRent_Click(sender As Object, e As EventArgs) Handles BtnRent.Click
        Penyewaan.waktu_sewaproperty = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'MessageBox.Show(Penyewaan.waktu_sewaproperty)
        Penyewaan.bayar_sebelum_pinjamProperty = TotalHarga.ToString()
        Penyewaan.rencana_pinjamProperty = TBDuration.Text()

        Penyewaan.addDataSewaDatabase(selectedLocker,
                                      Penyewaan.waktu_sewaproperty,
                                      Penyewaan.bayar_sebelum_pinjamProperty,
                                      Penyewaan.rencana_pinjamProperty)
    End Sub
End Class