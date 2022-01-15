Public Class Update_Locker

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TBNamaLC.Text = Menu_Admin.Locker.nama_lockerProperty
        TBHLocLC.Text = Menu_Admin.Locker.lokasiproperty

    End Sub
    Private Sub BtnUpdateLocker_Click(sender As Object, e As EventArgs) Handles BtnUpdateLocker.Click
        Menu_Admin.Locker.nama_lockerProperty = TBNamaLC.Text.ToString()
        Menu_Admin.Locker.lokasiproperty = TBHLocLC.Text.ToString()

        Menu_Admin.Locker.AddLocker(TBNamaLC.Text.ToString())

        Menu_Admin.Locker.UpdateDataLockerByIDDatabase(Edit_Locker.SelectedTableUpdate,
                                                                  Menu_Admin.Locker.nama_lockerProperty,
                                                                  Menu_Admin.Locker.lokasiproperty)
        Me.Close()

    End Sub
End Class