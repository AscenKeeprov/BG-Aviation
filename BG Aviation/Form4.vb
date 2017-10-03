Public Class Qst3

    Private Sub Qst3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Otg3_1.Checked = False
        Otg3_2.Checked = False
        Otg3_3.Checked = False
    End Sub

    Private Sub Otg3_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg3_1.CheckedChanged
        If Otg3_1.Checked = True Then
            Otg3_2.Checked = False
            Otg3_3.Checked = False
            Otgovor3.Show()
            SimoPetrov.Show()
        End If
    End Sub

    Private Sub Otg3_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg3_2.CheckedChanged
        If Otg3_2.Checked = True Then
            Otg3_1.Checked = False
            Otg3_3.Checked = False
            Otgovor3.Show()
            SimoPetrov.Show()
        End If
    End Sub

    Private Sub Otg3_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg3_3.CheckedChanged
        If Otg3_3.Checked = True Then
            Otg3_1.Checked = False
            Otg3_2.Checked = False
            Otgovor3.Show()
            SimoPetrov.Show()
        End If
    End Sub

    Private Sub Nagore3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nagore3.Click
        Qst4.Activate()
        Qst4.Show()
        Me.Close()
    End Sub
End Class