Public Class Qst4

    Private Sub Qst4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Otg4_1.Checked = False
        Otg4_2.Checked = False
        Otg4_3.Checked = False
    End Sub

    Private Sub Otg4_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg4_1.CheckedChanged
        If Otg4_1.Checked = True Then
            Otg4_2.Checked = False
            Otg4_3.Checked = False
            Otgovor4.Show()
            MorePics.Show()
        End If
    End Sub

    Private Sub Otg4_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg4_2.CheckedChanged
        If Otg4_2.Checked = True Then
            Otg4_1.Checked = False
            Otg4_3.Checked = False
            Otgovor4.Show()
            MorePics.Show()
        End If
    End Sub

    Private Sub Otg4_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg4_3.CheckedChanged
        If Otg4_3.Checked = True Then
            Otg4_1.Checked = False
            Otg4_2.Checked = False
            Otgovor4.Show()
            MorePics.Show()
        End If
    End Sub

    Private Sub MorePics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MorePics.Click
        AddPics.Show()
    End Sub

    Private Sub Nagore4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nagore4.Click
        Qst5.Activate()
        Qst5.Show()
        Me.Close()
    End Sub
End Class