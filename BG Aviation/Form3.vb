Public Class Qst2

    Private Sub Qst2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Otg2_1.Checked = False
        Otg2_2.Checked = False
        Otg2_3.Checked = False
    End Sub

    Private Sub Otg2_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg2_1.CheckedChanged
        If Otg2_1.Checked = True Then
            Otg2_2.Checked = False
            Otg2_3.Checked = False
            Baloons.Show()
            Otgovor2.Show()
            PhotoTxt1.Show()
        End If
    End Sub

    Private Sub Otg2_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg2_2.CheckedChanged
        If Otg2_2.Checked = True Then
            Otg2_1.Checked = False
            Otg2_3.Checked = False
            Baloons.Show()
            Otgovor2.Show()
            PhotoTxt1.Show()
        End If
    End Sub

    Private Sub Otg2_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otg2_3.CheckedChanged
        If Otg2_3.Checked = True Then
            Otg2_1.Checked = False
            Otg2_2.Checked = False
            Baloons.Show()
            Otgovor2.Show()
            PhotoTxt1.Show()
        End If
    End Sub

    Private Sub Nagore2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nagore2.Click
        Qst3.Activate()
        Qst3.Show()
        Me.Close()
    End Sub
End Class