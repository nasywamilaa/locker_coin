Public Class Delete_Locker
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LbLockerNama.Text = Edit_Locker.SelectedTableUpdateLocker
    End Sub

    Private Sub BtnRemoveLocker_Click(sender As Object, e As EventArgs) Handles BtnRemoveLocker.Click
        Menu_Admin.Locker.DeleteDataLockerByIDDatabase(Edit_Locker.SelectedTableUpdate)
        Me.Close()
    End Sub

    Private Sub BtnCancelRemove_Click(sender As Object, e As EventArgs) Handles BtnCancelRemove.Click
        Me.Close()
    End Sub
End Class