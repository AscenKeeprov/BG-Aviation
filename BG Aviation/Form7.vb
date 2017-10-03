Public Class Qst6

    Private Sub MorePics2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MorePics2.Click
        If JordanoffDC3.Visible = True And JordanoffDC3Info.Visible = True And JordanoffCo.Visible = True And JordanoffCoInfo.Visible = True Then
            JordanoffDC3.Visible = False
            JordanoffDC3Info.Visible = False
            JordanoffCo.Visible = False
            JordanoffCoInfo.Visible = False
            Jordanoff13D.Visible = True
            Jordanoff13DInfo.Visible = True
            Jordanoff1Side.Visible = True
            Jordanoff1SideInfo.Visible = True
        ElseIf Jordanoff13D.Visible = True And Jordanoff13DInfo.Visible = True And Jordanoff1Side.Visible = True And Jordanoff1SideInfo.Visible = True Then
            Jordanoff13D.Visible = False
            Jordanoff13DInfo.Visible = False
            Jordanoff1Side.Visible = False
            Jordanoff1SideInfo.Visible = False
            JordanoffDC3.Visible = True
            JordanoffDC3Info.Visible = True
            JordanoffCo.Visible = True
            JordanoffCoInfo.Visible = True
        End If
    End Sub

    Private Sub Nagore6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nagore6.Click
        Qst7.Activate()
        Qst7.Show()
        Me.Close()
    End Sub
End Class