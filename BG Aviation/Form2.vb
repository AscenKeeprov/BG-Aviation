Public Class Qst1
    Private Sub Qst1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Otg1_1.Checked = False
        Otg1_2.Checked = False
        Otg1_3.Checked = False
    End Sub

    Private Sub Otg1_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg1_1.CheckedChanged
        If Otg1_1.Checked = True Then
            Otg1_2.Checked = False
            Otg1_3.Checked = False
            FstFlght.Show()
            Otgovor1.Show()
        End If
    End Sub

    Private Sub Otg1_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg1_2.CheckedChanged
        If Otg1_2.Checked = True Then
            Otg1_1.Checked = False
            Otg1_3.Checked = False
            FstFlght.Show()
            Otgovor1.Show()
        End If
    End Sub

    Private Sub Otg1_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg1_3.CheckedChanged
        If Otg1_3.Checked = True Then
            Otg1_1.Checked = False
            Otg1_2.Checked = False
            FstFlght.Show()
            Otgovor1.Show()
        End If
    End Sub

    Private Sub Nagore1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nagore1.Click
        Qst2.Activate()
        Qst2.Show()
        Me.Close()
    End Sub
End Class