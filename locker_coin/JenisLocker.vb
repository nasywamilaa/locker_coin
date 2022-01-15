Public Class JenisLocker
    Public Shared Ukuran As String
    Public Shared Biaya As Integer

    Public Shared NamaJenis
    Public Shared HargaJenis
    Public Shared SelectedTableJenis
    Public Shared SelectedTableNamaJenis

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewJenisLocker.DataSource = Menu_Admin.Jenis_Ukuran.GetDataJenisUkuranDatabase()
    End Sub

    Private Sub JenisLocker_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnAddJenis_Click(sender As Object, e As EventArgs) Handles BtnAddJenis.Click
        Menu_Admin.Jenis_Ukuran.ukuranProperty = TBNamaJenis.Text.ToString()
        Menu_Admin.Jenis_Ukuran.biayaProperty = TBHarga.Text.ToString()

        Menu_Admin.Jenis_Ukuran.addDataJenisUkuranDatabase(Menu_Admin.Jenis_Ukuran.ukuranProperty,
                                                           Menu_Admin.Jenis_Ukuran.biayaProperty)
        NamaJenis = TBNamaJenis.Text
        HargaJenis = TBHarga.Text

        Dim Konfirm_Tambah = New Konfirm_Tambah_Jenis()
        Konfirm_Tambah.Show()

    End Sub

    Private Sub DataGridViewJenisLocker_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJenisLocker.CellContentClick
        SelectedTableJenis = DataGridViewJenisLocker.CurrentRow.Index
    End Sub

    Private Sub DataGridViewJenisLocker_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJenisLocker.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJenisLocker.Rows(index)

        SelectedTableJenis = selectedRow.Cells(0).Value
        SelectedTableNamaJenis = selectedRow.Cells(1).Value

    End Sub

    Private Sub BtnUpdateJenis_Click(sender As Object, e As EventArgs) Handles BtnUpdateJenis.Click
        If SelectedTableJenis IsNot Nothing Then
            Dim selectedJenis As List(Of String) = Menu_Admin.Jenis_Ukuran.GetDataJenisUkuranByIDDatabase(SelectedTableJenis)

            Menu_Admin.Jenis_Ukuran.ukuranProperty = selectedJenis(1)
            Menu_Admin.Jenis_Ukuran.biayaProperty = selectedJenis(2)

            Dim UpdateJenis = New Update_Jenis_Locker()
            UpdateJenis.Show()
            'MessageBox.Show(selectedtablekoleksi)
        End If
    End Sub
    Public Sub updateDataJenisUkuranarraylist()
        DataGridViewJenisLocker.Rows.Clear()
        For Each rowjenis_ukuran In Menu_Admin.Jenis_Ukuran.getDataJenisUkuran()
            Dim datatable As String() = {rowjenis_ukuran(1),
                                         rowjenis_ukuran(2)}
            DataGridViewJenisLocker.Rows.Add(datatable)
        Next
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If SelectedTableJenis IsNot Nothing Then
            Dim FormRemove = New Remove()
            FormRemove.Show()
        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub
End Class