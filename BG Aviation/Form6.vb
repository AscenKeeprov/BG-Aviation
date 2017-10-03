Public Class Qst5

    Private Sub Nagore5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nagore5.Click
        Qst6.Activate()
        Qst6.Show()
        Me.Close()
    End Sub

    Private Sub NextPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextPic.Click
        If Jordanoff16.Visible = True Then
            Jordanoff16.Visible = False
            Jordanoff21.Visible = True
        ElseIf Jordanoff21.Visible = True Then
            Jordanoff21.Visible = False
            AssenJordanoff.Visible = True
        ElseIf AssenJordanoff.Visible = True Then
            AssenJordanoff.Visible = False
            Jordanoff16.Visible = True
        End If
    End Sub
End Class