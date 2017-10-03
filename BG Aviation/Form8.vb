Public Class Qst7

    Private Sub ZnachkiButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZnachkiButton.Click
        Znachki.Activate()
        Znachki.Show()
    End Sub

    Private Sub OrdeniButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdeniButton.Click
        Ordeni.Activate()
        Ordeni.Show()
    End Sub

    Private Sub Snijavane_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Snijavane.Click
        GoodBye.Activate()
        GoodBye.Show()
        Me.Close()
    End Sub
End Class