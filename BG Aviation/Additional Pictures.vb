Public Class AddPics

    Private Sub Luping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Luping.Click
        Article.Visible = False
        ArticleInfo.Visible = False
        Bombadjii2.Visible = False
        Bombadjii2Info.Visible = False
        Bombardment.Visible = False
        BombardmentInfo.Visible = False
        FirstBomber.Visible = True
        FirstBomberInfo.Visible = True
        AirDefense.Visible = True
        AirDefenseInfo.Visible = True
        Aviomehanici.Visible = True
        AviomehaniciInfo.Visible = True
    End Sub

    Private Sub Pikirane_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pikirane.Click
        FirstBomber.Visible = False
        FirstBomberInfo.Visible = False
        AirDefense.Visible = False
        AirDefenseInfo.Visible = False
        Aviomehanici.Visible = False
        AviomehaniciInfo.Visible = False
        Article.Visible = True
        ArticleInfo.Visible = True
        Bombadjii2.Visible = True
        Bombadjii2Info.Visible = True
        Bombardment.Visible = True
        BombardmentInfo.Visible = True
    End Sub
End Class