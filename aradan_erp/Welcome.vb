Public Class Welcome

    Private Sub realestateicon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles realestateicon.Click

    End Sub

    Private Sub posicon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles posicon.Click
        Dim posLayoutForm As New aradan_erp.PosLayoutForm()
        posLayoutForm.Show()
        Me.Hide()
    End Sub
End Class
