Public Class Update_Jenis_Locker

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TBNamaJenis.Text = Menu_Admin.Jenis_Ukuran.ukuranProperty
        TBHarga.Text = Menu_Admin.Jenis_Ukuran.biayaProperty

    End Sub
    Private Sub BtnUpdateJenis_Click(sender As Object, e As EventArgs) Handles BtnUpdateJenis.Click
        Menu_Admin.Jenis_Ukuran.ukuranProperty = TBNamaJenis.Text.ToString()
        Menu_Admin.Jenis_Ukuran.biayaProperty = TBHarga.Text.ToString()

        Menu_Admin.Jenis_Ukuran.AddJenis(TBNamaJenis.Text.ToString())

        Menu_Admin.Jenis_Ukuran.UpdateDataJenisUkuranByIDDatabase(JenisLocker.SelectedTableJenis,
                                                                  Menu_Admin.Jenis_Ukuran.ukuranProperty,
                                                                  Menu_Admin.Jenis_Ukuran.biayaProperty)
        Dim jenis_locker = New JenisLocker()
        jenis_locker.Show()

        Me.Close()
    End Sub

End Class