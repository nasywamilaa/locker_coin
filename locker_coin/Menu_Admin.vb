Public Class Menu_Admin

    Public Shared Jenis_Ukuran As Jenis_Ukuran
    Public Shared Locker As Locker
    Public Shared Penyewaan As Penyewaan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Jenis_Ukuran = New Jenis_Ukuran()
        Locker = New Locker()
        Penyewaan = New Penyewaan()
    End Sub
    Private Sub ButtonAddLocker_Click(sender As Object, e As EventArgs) Handles ButtonAddLocker.Click
        Dim AddLocker = New TambahLocker()
        AddLocker.Show()

    End Sub

    Private Sub ButtonDataSewa_Click(sender As Object, e As EventArgs) Handles ButtonDataSewa.Click
        Dim RentData = New DataSewa()
        RentData.Show()

    End Sub

    Private Sub ButtonTambahJenisLocker_Click(sender As Object, e As EventArgs) Handles ButtonTambahJenisLocker.Click
        Dim AddJenis = New JenisLocker()
        AddJenis.Show()

    End Sub

    Private Sub LbClose_Click(sender As Object, e As EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonUpdateLocker_Click(sender As Object, e As EventArgs) Handles ButtonUpdateLocker.Click
        Dim UpdateLocker = New Edit_Locker()
        UpdateLocker.Show()
    End Sub
End Class