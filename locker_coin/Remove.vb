Public Class Remove

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LbLockerName.Text = JenisLocker.SelectedTableNamaJenis
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Menu_Admin.Jenis_Ukuran.DeleteDataJenisUkuranByIDDatabase(JenisLocker.SelectedTableJenis)
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LbLockerName.Click

    End Sub
End Class