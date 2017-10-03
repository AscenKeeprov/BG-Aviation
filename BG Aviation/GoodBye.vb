Public Class GoodBye
    Dim Clix As Integer
    Private Sub Kacane_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kacane.Click
        Me.Close()
    End Sub

    Private Sub Proceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proceed.Click
        Clix = Clix + 1
        If Clix > 20 Then
            DIABLO.Activate()
            DIABLO.Show()
        End If
    End Sub
End Class