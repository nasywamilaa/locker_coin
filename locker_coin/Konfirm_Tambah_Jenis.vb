Public Class Konfirm_Tambah_Jenis

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LbLockerName.Text = TambahLocker.NamaLocker
        LbLockerLocation.Text = TambahLocker.LokasiLocker
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Me.Close()
    End Sub
End Class