Public Class DataKembali

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataKembali()
    End Sub

    Private Sub ReloadDataKembali()
        DGVTakeOut.DataSource = Menu_Admin.Penyewaan.GetDataKembaliDatabase
    End Sub

    Private Sub DataKembali_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataKembali()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim kembali = New DataSewa()
        kembali.Show()
        Me.Close()
    End Sub

End Class