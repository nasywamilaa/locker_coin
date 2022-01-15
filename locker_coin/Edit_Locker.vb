Public Class Edit_Locker
    Public Shared Loker

    Public Shared Nama
    Public Shared Lokasi

    Public Shared SelectedTableUpdate
    Public Shared SelectedTableUpdateLocker
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataLocker()
    End Sub

    Private Sub ReloadDataLocker()
        DataGridViewUpdateLoker.DataSource = Menu_Admin.Locker.GetDataLockerDatabase()
    End Sub
    Private Sub Edit_Locker_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataLocker()
    End Sub

    Private Sub DataGridViewUpdateLoker_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUpdateLoker.CellContentClick
        SelectedTableUpdate = DataGridViewUpdateLoker.CurrentRow.Index
    End Sub

    Private Sub DataGridViewUpdateLoker_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUpdateLoker.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRowLocker As DataGridViewRow
        selectedRowLocker = DataGridViewUpdateLoker.Rows(index)

        SelectedTableUpdate = selectedRowLocker.Cells(0).Value
        SelectedTableUpdateLocker = selectedRowLocker.Cells(1).Value

    End Sub
    Private Sub BtnUpdateLocker_Click(sender As Object, e As EventArgs) Handles BtnUpdateLocker.Click
        If SelectedTableUpdate IsNot Nothing Then
            Dim selectedUpdate As List(Of String) = Menu_Admin.Locker.GetDataLockerByIDDatabase(SelectedTableUpdate)

            Menu_Admin.Locker.nama_lockerProperty = selectedUpdate(1)
            Menu_Admin.Locker.lokasiproperty = selectedUpdate(2)

            Dim UpdateJenis = New Update_Locker()
            UpdateJenis.Show()
            'MessageBox.Show(selectedtablekoleksi)
        End If
    End Sub

    Private Sub BtnHilang_Click(sender As Object, e As EventArgs) Handles BtnHilang.Click
        If SelectedTableUpdate IsNot Nothing Then
            Dim FormDelete = New Delete_Locker()
            FormDelete.Show()
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub
End Class