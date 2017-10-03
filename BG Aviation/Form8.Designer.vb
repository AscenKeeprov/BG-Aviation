<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Qst7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Qst7))
        Me.ZnaciInfo1 = New System.Windows.Forms.Label
        Me.BoenZnakGerb = New System.Windows.Forms.PictureBox
        Me.BoiniZnaci = New System.Windows.Forms.PictureBox
        Me.BoiniZnaciInfo = New System.Windows.Forms.Label
        Me.ZnachkiInfo = New System.Windows.Forms.Label
        Me.ZnachkiButton = New System.Windows.Forms.Button
        Me.OrdeniInfo = New System.Windows.Forms.Label
        Me.OrdeniButton = New System.Windows.Forms.Button
        Me.Snijavane = New System.Windows.Forms.Button
        CType(Me.BoenZnakGerb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoiniZnaci, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ZnaciInfo1
        '
        Me.ZnaciInfo1.AutoSize = True
        Me.ZnaciInfo1.Location = New System.Drawing.Point(20, 20)
        Me.ZnaciInfo1.Name = "ZnaciInfo1"
        Me.ZnaciInfo1.Size = New System.Drawing.Size(344, 169)
        Me.ZnaciInfo1.TabIndex = 0
        Me.ZnaciInfo1.Text = resources.GetString("ZnaciInfo1.Text")
        '
        'BoenZnakGerb
        '
        Me.BoenZnakGerb.Image = CType(resources.GetObject("BoenZnakGerb.Image"), System.Drawing.Image)
        Me.BoenZnakGerb.Location = New System.Drawing.Point(375, 20)
        Me.BoenZnakGerb.Name = "BoenZnakGerb"
        Me.BoenZnakGerb.Size = New System.Drawing.Size(295, 185)
        Me.BoenZnakGerb.TabIndex = 1
        Me.BoenZnakGerb.TabStop = False
        '
        'BoiniZnaci
        '
        Me.BoiniZnaci.Image = CType(resources.GetObject("BoiniZnaci.Image"), System.Drawing.Image)
        Me.BoiniZnaci.Location = New System.Drawing.Point(20, 215)
        Me.BoiniZnaci.Name = "BoiniZnaci"
        Me.BoiniZnaci.Size = New System.Drawing.Size(205, 69)
        Me.BoiniZnaci.TabIndex = 2
        Me.BoiniZnaci.TabStop = False
        '
        'BoiniZnaciInfo
        '
        Me.BoiniZnaciInfo.AutoSize = True
        Me.BoiniZnaciInfo.Location = New System.Drawing.Point(250, 225)
        Me.BoiniZnaciInfo.Name = "BoiniZnaciInfo"
        Me.BoiniZnaciInfo.Size = New System.Drawing.Size(400, 52)
        Me.BoiniZnaciInfo.TabIndex = 3
        Me.BoiniZnaciInfo.Text = resources.GetString("BoiniZnaciInfo.Text")
        '
        'ZnachkiInfo
        '
        Me.ZnachkiInfo.AutoSize = True
        Me.ZnachkiInfo.Location = New System.Drawing.Point(20, 300)
        Me.ZnachkiInfo.Name = "ZnachkiInfo"
        Me.ZnachkiInfo.Size = New System.Drawing.Size(183, 39)
        Me.ZnachkiInfo.TabIndex = 4
        Me.ZnachkiInfo.Text = "Някой от пилотите също са имали" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "собствени   отличителни   значки," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "показващи чин" & _
            "а им."
        '
        'ZnachkiButton
        '
        Me.ZnachkiButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ZnachkiButton.ForeColor = System.Drawing.Color.DarkGreen
        Me.ZnachkiButton.Location = New System.Drawing.Point(80, 365)
        Me.ZnachkiButton.Name = "ZnachkiButton"
        Me.ZnachkiButton.Size = New System.Drawing.Size(57, 80)
        Me.ZnachkiButton.TabIndex = 5
        Me.ZnachkiButton.Text = "Значки"
        Me.ZnachkiButton.UseVisualStyleBackColor = True
        '
        'OrdeniInfo
        '
        Me.OrdeniInfo.AutoSize = True
        Me.OrdeniInfo.Location = New System.Drawing.Point(250, 300)
        Me.OrdeniInfo.Name = "OrdeniInfo"
        Me.OrdeniInfo.Size = New System.Drawing.Size(196, 26)
        Me.OrdeniInfo.TabIndex = 6
        Me.OrdeniInfo.Text = "За особени заслуги,  разбира се,  са" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "се връчвали и ордени ""За храброст""."
        '
        'OrdeniButton
        '
        Me.OrdeniButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.OrdeniButton.ForeColor = System.Drawing.Color.DarkGreen
        Me.OrdeniButton.Location = New System.Drawing.Point(315, 360)
        Me.OrdeniButton.Name = "OrdeniButton"
        Me.OrdeniButton.Size = New System.Drawing.Size(60, 90)
        Me.OrdeniButton.TabIndex = 7
        Me.OrdeniButton.Text = "Ордени"
        Me.OrdeniButton.UseVisualStyleBackColor = True
        '
        'Snijavane
        '
        Me.Snijavane.ForeColor = System.Drawing.Color.DarkGreen
        Me.Snijavane.Image = CType(resources.GetObject("Snijavane.Image"), System.Drawing.Image)
        Me.Snijavane.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Snijavane.Location = New System.Drawing.Point(590, 435)
        Me.Snijavane.Name = "Snijavane"
        Me.Snijavane.Size = New System.Drawing.Size(90, 23)
        Me.Snijavane.TabIndex = 8
        Me.Snijavane.Text = "Снижаване"
        Me.Snijavane.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Snijavane.UseVisualStyleBackColor = True
        '
        'Qst7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(692, 471)
        Me.Controls.Add(Me.Snijavane)
        Me.Controls.Add(Me.OrdeniButton)
        Me.Controls.Add(Me.OrdeniInfo)
        Me.Controls.Add(Me.ZnachkiButton)
        Me.Controls.Add(Me.ZnachkiInfo)
        Me.Controls.Add(Me.BoiniZnaciInfo)
        Me.Controls.Add(Me.BoiniZnaci)
        Me.Controls.Add(Me.BoenZnakGerb)
        Me.Controls.Add(Me.ZnaciInfo1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Qst7"
        Me.Text = "Българско авиационно дело"
        CType(Me.BoenZnakGerb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoiniZnaci, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZnaciInfo1 As System.Windows.Forms.Label
    Friend WithEvents BoenZnakGerb As System.Windows.Forms.PictureBox
    Friend WithEvents BoiniZnaci As System.Windows.Forms.PictureBox
    Friend WithEvents BoiniZnaciInfo As System.Windows.Forms.Label
    Friend WithEvents ZnachkiInfo As System.Windows.Forms.Label
    Friend WithEvents ZnachkiButton As System.Windows.Forms.Button
    Friend WithEvents OrdeniInfo As System.Windows.Forms.Label
    Friend WithEvents OrdeniButton As System.Windows.Forms.Button
    Friend WithEvents Snijavane As System.Windows.Forms.Button
End Class
