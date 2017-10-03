<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPics))
        Me.Article = New System.Windows.Forms.PictureBox
        Me.ArticleInfo = New System.Windows.Forms.Label
        Me.Bombadjii2 = New System.Windows.Forms.PictureBox
        Me.Bombadjii2Info = New System.Windows.Forms.Label
        Me.Bombardment = New System.Windows.Forms.PictureBox
        Me.BombardmentInfo = New System.Windows.Forms.Label
        Me.Pikirane = New System.Windows.Forms.Button
        Me.Luping = New System.Windows.Forms.Button
        Me.FirstBomber = New System.Windows.Forms.PictureBox
        Me.FirstBomberInfo = New System.Windows.Forms.Label
        Me.AirDefense = New System.Windows.Forms.PictureBox
        Me.AirDefenseInfo = New System.Windows.Forms.Label
        Me.Aviomehanici = New System.Windows.Forms.PictureBox
        Me.AviomehaniciInfo = New System.Windows.Forms.Label
        CType(Me.Article, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bombadjii2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bombardment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstBomber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirDefense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aviomehanici, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Article
        '
        Me.Article.Image = CType(resources.GetObject("Article.Image"), System.Drawing.Image)
        Me.Article.Location = New System.Drawing.Point(10, 10)
        Me.Article.Name = "Article"
        Me.Article.Size = New System.Drawing.Size(337, 477)
        Me.Article.TabIndex = 0
        Me.Article.TabStop = False
        '
        'ArticleInfo
        '
        Me.ArticleInfo.AutoSize = True
        Me.ArticleInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ArticleInfo.Location = New System.Drawing.Point(40, 500)
        Me.ArticleInfo.Name = "ArticleInfo"
        Me.ArticleInfo.Size = New System.Drawing.Size(275, 60)
        Me.ArticleInfo.TabIndex = 1
        Me.ArticleInfo.Text = "Статия от в-к ""Illustrated London News"" посветена на" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "българсното участие в Балка" & _
            "нската война. Ясно се " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "чете заглавието: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The aeroplane in the Balkan war: Bulg" & _
            "arian air-scouting."
        '
        'Bombadjii2
        '
        Me.Bombadjii2.Image = CType(resources.GetObject("Bombadjii2.Image"), System.Drawing.Image)
        Me.Bombadjii2.Location = New System.Drawing.Point(375, 10)
        Me.Bombadjii2.Name = "Bombadjii2"
        Me.Bombadjii2.Size = New System.Drawing.Size(390, 220)
        Me.Bombadjii2.TabIndex = 2
        Me.Bombadjii2.TabStop = False
        '
        'Bombadjii2Info
        '
        Me.Bombadjii2Info.AutoSize = True
        Me.Bombadjii2Info.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Bombadjii2Info.Location = New System.Drawing.Point(430, 245)
        Me.Bombadjii2Info.Name = "Bombadjii2Info"
        Me.Bombadjii2Info.Size = New System.Drawing.Size(273, 15)
        Me.Bombadjii2Info.TabIndex = 3
        Me.Bombadjii2Info.Text = "Пилотите щателно проверяват бомбите преди полет."
        '
        'Bombardment
        '
        Me.Bombardment.Image = CType(resources.GetObject("Bombardment.Image"), System.Drawing.Image)
        Me.Bombardment.Location = New System.Drawing.Point(410, 275)
        Me.Bombardment.Name = "Bombardment"
        Me.Bombardment.Size = New System.Drawing.Size(320, 160)
        Me.Bombardment.TabIndex = 4
        Me.Bombardment.TabStop = False
        '
        'BombardmentInfo
        '
        Me.BombardmentInfo.AutoSize = True
        Me.BombardmentInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BombardmentInfo.Location = New System.Drawing.Point(450, 450)
        Me.BombardmentInfo.Name = "BombardmentInfo"
        Me.BombardmentInfo.Size = New System.Drawing.Size(244, 15)
        Me.BombardmentInfo.TabIndex = 5
        Me.BombardmentInfo.Text = "По този начин са се пускали бомбите отначало."
        '
        'Pikirane
        '
        Me.Pikirane.ForeColor = System.Drawing.Color.DarkGreen
        Me.Pikirane.Image = CType(resources.GetObject("Pikirane.Image"), System.Drawing.Image)
        Me.Pikirane.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Pikirane.Location = New System.Drawing.Point(485, 510)
        Me.Pikirane.Name = "Pikirane"
        Me.Pikirane.Size = New System.Drawing.Size(80, 23)
        Me.Pikirane.TabIndex = 6
        Me.Pikirane.Text = "Пикиране"
        Me.Pikirane.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Pikirane.UseVisualStyleBackColor = True
        '
        'Luping
        '
        Me.Luping.ForeColor = System.Drawing.Color.DarkGreen
        Me.Luping.Image = CType(resources.GetObject("Luping.Image"), System.Drawing.Image)
        Me.Luping.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Luping.Location = New System.Drawing.Point(600, 510)
        Me.Luping.Name = "Luping"
        Me.Luping.Size = New System.Drawing.Size(80, 23)
        Me.Luping.TabIndex = 7
        Me.Luping.Text = "  Лупинг"
        Me.Luping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Luping.UseVisualStyleBackColor = True
        '
        'FirstBomber
        '
        Me.FirstBomber.Image = CType(resources.GetObject("FirstBomber.Image"), System.Drawing.Image)
        Me.FirstBomber.Location = New System.Drawing.Point(10, 10)
        Me.FirstBomber.Name = "FirstBomber"
        Me.FirstBomber.Size = New System.Drawing.Size(315, 190)
        Me.FirstBomber.TabIndex = 8
        Me.FirstBomber.TabStop = False
        Me.FirstBomber.Visible = False
        '
        'FirstBomberInfo
        '
        Me.FirstBomberInfo.AutoSize = True
        Me.FirstBomberInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FirstBomberInfo.Location = New System.Drawing.Point(15, 215)
        Me.FirstBomberInfo.Name = "FirstBomberInfo"
        Me.FirstBomberInfo.Size = New System.Drawing.Size(305, 15)
        Me.FirstBomberInfo.TabIndex = 9
        Me.FirstBomberInfo.Text = "Снимка на първия бомбардировач - самолет ""Albatros F-2"""
        Me.FirstBomberInfo.Visible = False
        '
        'AirDefense
        '
        Me.AirDefense.Image = CType(resources.GetObject("AirDefense.Image"), System.Drawing.Image)
        Me.AirDefense.Location = New System.Drawing.Point(10, 250)
        Me.AirDefense.Name = "AirDefense"
        Me.AirDefense.Size = New System.Drawing.Size(119, 310)
        Me.AirDefense.TabIndex = 10
        Me.AirDefense.TabStop = False
        Me.AirDefense.Visible = False
        '
        'AirDefenseInfo
        '
        Me.AirDefenseInfo.AutoSize = True
        Me.AirDefenseInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AirDefenseInfo.Location = New System.Drawing.Point(160, 350)
        Me.AirDefenseInfo.Name = "AirDefenseInfo"
        Me.AirDefenseInfo.Size = New System.Drawing.Size(174, 75)
        Me.AirDefenseInfo.TabIndex = 11
        Me.AirDefenseInfo.Text = "Противобалонно оръдие ""Krup""." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "С такива е разполагала Одрин-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ската крепост. С та" & _
            "кова оръдие" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "турците са стреляли по първия" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "самолет за бомбардировки."
        Me.AirDefenseInfo.Visible = False
        '
        'Aviomehanici
        '
        Me.Aviomehanici.Image = CType(resources.GetObject("Aviomehanici.Image"), System.Drawing.Image)
        Me.Aviomehanici.Location = New System.Drawing.Point(360, 110)
        Me.Aviomehanici.Name = "Aviomehanici"
        Me.Aviomehanici.Size = New System.Drawing.Size(420, 255)
        Me.Aviomehanici.TabIndex = 12
        Me.Aviomehanici.TabStop = False
        Me.Aviomehanici.Visible = False
        '
        'AviomehaniciInfo
        '
        Me.AviomehaniciInfo.AutoSize = True
        Me.AviomehaniciInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AviomehaniciInfo.Location = New System.Drawing.Point(375, 375)
        Me.AviomehaniciInfo.Name = "AviomehaniciInfo"
        Me.AviomehaniciInfo.Size = New System.Drawing.Size(388, 30)
        Me.AviomehaniciInfo.TabIndex = 13
        Me.AviomehaniciInfo.Text = "Български авиомеханици. Благодарение на такива храбри и сръчни момчета" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         " & _
            "                 родните самолети преживяват много воини. "
        Me.AviomehaniciInfo.Visible = False
        '
        'AddPics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(792, 571)
        Me.Controls.Add(Me.AviomehaniciInfo)
        Me.Controls.Add(Me.Aviomehanici)
        Me.Controls.Add(Me.AirDefenseInfo)
        Me.Controls.Add(Me.AirDefense)
        Me.Controls.Add(Me.FirstBomberInfo)
        Me.Controls.Add(Me.FirstBomber)
        Me.Controls.Add(Me.Luping)
        Me.Controls.Add(Me.Pikirane)
        Me.Controls.Add(Me.Article)
        Me.Controls.Add(Me.Bombadjii2)
        Me.Controls.Add(Me.Bombardment)
        Me.Controls.Add(Me.Bombadjii2Info)
        Me.Controls.Add(Me.BombardmentInfo)
        Me.Controls.Add(Me.ArticleInfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddPics"
        Me.Text = "Българско авиационно дело"
        CType(Me.Article, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bombadjii2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bombardment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstBomber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirDefense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aviomehanici, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Article As System.Windows.Forms.PictureBox
    Friend WithEvents ArticleInfo As System.Windows.Forms.Label
    Friend WithEvents Bombadjii2 As System.Windows.Forms.PictureBox
    Friend WithEvents Bombadjii2Info As System.Windows.Forms.Label
    Friend WithEvents Bombardment As System.Windows.Forms.PictureBox
    Friend WithEvents BombardmentInfo As System.Windows.Forms.Label
    Friend WithEvents Pikirane As System.Windows.Forms.Button
    Friend WithEvents Luping As System.Windows.Forms.Button
    Friend WithEvents FirstBomber As System.Windows.Forms.PictureBox
    Friend WithEvents FirstBomberInfo As System.Windows.Forms.Label
    Friend WithEvents AirDefense As System.Windows.Forms.PictureBox
    Friend WithEvents AirDefenseInfo As System.Windows.Forms.Label
    Friend WithEvents Aviomehanici As System.Windows.Forms.PictureBox
    Friend WithEvents AviomehaniciInfo As System.Windows.Forms.Label
End Class
