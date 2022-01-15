Public Class DataSewa

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataSewa()
    End Sub

    Private Sub DataSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataSewa()
    End Sub
    Private Sub ReloadDataSewa()
        DataGridViewSewa.DataSource = Menu_Admin.Penyewaan.GetDataRentDatabase

    End Sub

    Private Sub TambahToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Sewa = New Sewa()
        Sewa.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim takeout = New DataKembali()
        takeout.Show()
        Me.Close()

    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
    End Sub
End Class