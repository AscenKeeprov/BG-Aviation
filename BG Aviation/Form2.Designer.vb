<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Qst1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Qst1))
        Me.Info1 = New System.Windows.Forms.Label
        Me.UKnow1 = New System.Windows.Forms.Label
        Me.FstFlght = New System.Windows.Forms.PictureBox
        Me.Otgovor1 = New System.Windows.Forms.Label
        Me.Otg1_1 = New System.Windows.Forms.CheckBox
        Me.Otg1_2 = New System.Windows.Forms.CheckBox
        Me.Otg1_3 = New System.Windows.Forms.CheckBox
        Me.Nagore1 = New System.Windows.Forms.Button
        CType(Me.FstFlght, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Info1
        '
        Me.Info1.AutoSize = True
        Me.Info1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Info1.Location = New System.Drawing.Point(30, 30)
        Me.Info1.Name = "Info1"
        Me.Info1.Size = New System.Drawing.Size(281, 45)
        Me.Info1.TabIndex = 0
        Me.Info1.Text = "Въпреки че възниква едва през двадесети век," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "българското авиационно дело е едно " & _
            "от" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "най-бързо развиващите се в света!"
        '
        'UKnow1
        '
        Me.UKnow1.AutoSize = True
        Me.UKnow1.ForeColor = System.Drawing.Color.DarkBlue
        Me.UKnow1.Location = New System.Drawing.Point(30, 130)
        Me.UKnow1.Name = "UKnow1"
        Me.UKnow1.Size = New System.Drawing.Size(258, 26)
        Me.UKnow1.TabIndex = 1
        Me.UKnow1.Text = "Знаете ли през коя година се е състоял първият" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "полет със самолет в България?"
        '
        'FstFlght
        '
        Me.FstFlght.Image = CType(resources.GetObject("FstFlght.Image"), System.Drawing.Image)
        Me.FstFlght.Location = New System.Drawing.Point(325, 10)
        Me.FstFlght.Name = "FstFlght"
        Me.FstFlght.Size = New System.Drawing.Size(367, 204)
        Me.FstFlght.TabIndex = 2
        Me.FstFlght.TabStop = False
        Me.FstFlght.Visible = False
        '
        'Otgovor1
        '
        Me.Otgovor1.AutoSize = True
        Me.Otgovor1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Otgovor1.Location = New System.Drawing.Point(30, 255)
        Me.Otgovor1.Name = "Otgovor1"
        Me.Otgovor1.Size = New System.Drawing.Size(644, 65)
        Me.Otgovor1.TabIndex = 6
        Me.Otgovor1.Text = resources.GetString("Otgovor1.Text")
        Me.Otgovor1.Visible = False
        '
        'Otg1_1
        '
        Me.Otg1_1.AutoSize = True
        Me.Otg1_1.Location = New System.Drawing.Point(33, 175)
        Me.Otg1_1.Name = "Otg1_1"
        Me.Otg1_1.Size = New System.Drawing.Size(50, 17)
        Me.Otg1_1.TabIndex = 7
        Me.Otg1_1.Text = "1929"
        Me.Otg1_1.UseVisualStyleBackColor = True
        '
        'Otg1_2
        '
        Me.Otg1_2.AutoSize = True
        Me.Otg1_2.Location = New System.Drawing.Point(33, 195)
        Me.Otg1_2.Name = "Otg1_2"
        Me.Otg1_2.Size = New System.Drawing.Size(50, 17)
        Me.Otg1_2.TabIndex = 8
        Me.Otg1_2.Text = "1910"
        Me.Otg1_2.UseVisualStyleBackColor = True
        '
        'Otg1_3
        '
        Me.Otg1_3.AutoSize = True
        Me.Otg1_3.Location = New System.Drawing.Point(33, 215)
        Me.Otg1_3.Name = "Otg1_3"
        Me.Otg1_3.Size = New System.Drawing.Size(50, 17)
        Me.Otg1_3.TabIndex = 9
        Me.Otg1_3.Text = "1914"
        Me.Otg1_3.UseVisualStyleBackColor = True
        '
        'Nagore1
        '
        Me.Nagore1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Nagore1.Image = CType(resources.GetObject("Nagore1.Image"), System.Drawing.Image)
        Me.Nagore1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Nagore1.Location = New System.Drawing.Point(615, 335)
        Me.Nagore1.Name = "Nagore1"
        Me.Nagore1.Size = New System.Drawing.Size(75, 23)
        Me.Nagore1.TabIndex = 10
        Me.Nagore1.Text = "Нагоре"
        Me.Nagore1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Nagore1.UseVisualStyleBackColor = True
        '
        'Qst1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(702, 371)
        Me.Controls.Add(Me.Nagore1)
        Me.Controls.Add(Me.Otg1_3)
        Me.Controls.Add(Me.Otg1_2)
        Me.Controls.Add(Me.Otg1_1)
        Me.Controls.Add(Me.Otgovor1)
        Me.Controls.Add(Me.FstFlght)
        Me.Controls.Add(Me.UKnow1)
        Me.Controls.Add(Me.Info1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Qst1"
        Me.ShowInTaskbar = False
        Me.Text = "Българско авиационно дело"
        CType(Me.FstFlght, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Info1 As System.Windows.Forms.Label
    Friend WithEvents UKnow1 As System.Windows.Forms.Label
    Friend WithEvents FstFlght As System.Windows.Forms.PictureBox
    Friend WithEvents Otgovor1 As System.Windows.Forms.Label
    Friend WithEvents Otg1_1 As System.Windows.Forms.CheckBox
    Friend WithEvents Otg1_2 As System.Windows.Forms.CheckBox
    Friend WithEvents Otg1_3 As System.Windows.Forms.CheckBox
    Friend WithEvents Nagore1 As System.Windows.Forms.Button
End Class
