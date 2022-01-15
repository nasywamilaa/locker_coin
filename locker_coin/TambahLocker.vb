Public Class TambahLocker

    Public Shared SelectedJenis
    Public Shared SelectedNamaJenis
    Public Shared NamaLocker
    Public Shared LokasiLocker

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ReloadDataJenis()
    End Sub

    Private Sub ReloadDataJenis()
        DataGridViewLocker.DataSource = Menu_Admin.Jenis_Ukuran.GetDataJenisUkuranDatabase()
    End Sub

    Private Sub TambahLocker_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataJenis()
    End Sub

    Private Sub DataGridViewLocker_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLocker.CellContentClick

    End Sub

    Private Sub DataGridViewLocker_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLocker.CellClick

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
    End Sub

    'Private Sub lbLockerTypeName_TextChanged(sender As Object, e As EventArgs) Handles lbLockerTypeName.TextChanged

    'End Sub
End Class