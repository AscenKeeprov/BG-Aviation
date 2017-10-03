<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Qst5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Qst5))
        Me.AssJordanInfo = New System.Windows.Forms.Label
        Me.AssenJordanoff = New System.Windows.Forms.PictureBox
        Me.Nagore5 = New System.Windows.Forms.Button
        Me.Jordanoff16 = New System.Windows.Forms.PictureBox
        Me.Jordanoff21 = New System.Windows.Forms.PictureBox
        Me.NextPic = New System.Windows.Forms.Button
        CType(Me.AssenJordanoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jordanoff16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jordanoff21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssJordanInfo
        '
        Me.AssJordanInfo.AutoSize = True
        Me.AssJordanInfo.Location = New System.Drawing.Point(255, 12)
        Me.AssJordanInfo.Name = "AssJordanInfo"
        Me.AssJordanInfo.Size = New System.Drawing.Size(334, 312)
        Me.AssJordanInfo.TabIndex = 0
        Me.AssJordanInfo.Text = resources.GetString("AssJordanInfo.Text")
        '
        'AssenJordanoff
        '
        Me.AssenJordanoff.Image = CType(resources.GetObject("AssenJordanoff.Image"), System.Drawing.Image)
        Me.AssenJordanoff.Location = New System.Drawing.Point(12, 12)
        Me.AssenJordanoff.Name = "AssenJordanoff"
        Me.AssenJordanoff.Size = New System.Drawing.Size(225, 355)
        Me.AssenJordanoff.TabIndex = 1
        Me.AssenJordanoff.TabStop = False
        Me.AssenJordanoff.Visible = False
        '
        'Nagore5
        '
        Me.Nagore5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Nagore5.Image = CType(resources.GetObject("Nagore5.Image"), System.Drawing.Image)
        Me.Nagore5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Nagore5.Location = New System.Drawing.Point(505, 345)
        Me.Nagore5.Name = "Nagore5"
        Me.Nagore5.Size = New System.Drawing.Size(75, 23)
        Me.Nagore5.TabIndex = 2
        Me.Nagore5.Text = "Нагоре"
        Me.Nagore5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Nagore5.UseVisualStyleBackColor = True
        '
        'Jordanoff16
        '
        Me.Jordanoff16.Image = CType(resources.GetObject("Jordanoff16.Image"), System.Drawing.Image)
        Me.Jordanoff16.Location = New System.Drawing.Point(12, 12)
        Me.Jordanoff16.Name = "Jordanoff16"
        Me.Jordanoff16.Size = New System.Drawing.Size(224, 354)
        Me.Jordanoff16.TabIndex = 3
        Me.Jordanoff16.TabStop = False
        '
        'Jordanoff21
        '
        Me.Jordanoff21.Image = CType(resources.GetObject("Jordanoff21.Image"), System.Drawing.Image)
        Me.Jordanoff21.Location = New System.Drawing.Point(12, 12)
        Me.Jordanoff21.Name = "Jordanoff21"
        Me.Jordanoff21.Size = New System.Drawing.Size(224, 352)
        Me.Jordanoff21.TabIndex = 4
        Me.Jordanoff21.TabStop = False
        Me.Jordanoff21.Visible = False
        '
        'NextPic
        '
        Me.NextPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NextPic.ForeColor = System.Drawing.Color.DarkGreen
        Me.NextPic.Location = New System.Drawing.Point(260, 335)
        Me.NextPic.Name = "NextPic"
        Me.NextPic.Size = New System.Drawing.Size(75, 35)
        Me.NextPic.TabIndex = 5
        Me.NextPic.Text = "Следваща" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  снимка"
        Me.NextPic.UseVisualStyleBackColor = True
        '
        'Qst5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(592, 381)
        Me.Controls.Add(Me.NextPic)
        Me.Controls.Add(Me.Nagore5)
        Me.Controls.Add(Me.AssJordanInfo)
        Me.Controls.Add(Me.Jordanoff16)
        Me.Controls.Add(Me.Jordanoff21)
        Me.Controls.Add(Me.AssenJordanoff)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Qst5"
        Me.Text = "Българско авиационно дело"
        CType(Me.AssenJordanoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jordanoff16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jordanoff21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AssJordanInfo As System.Windows.Forms.Label
    Friend WithEvents AssenJordanoff As System.Windows.Forms.PictureBox
    Friend WithEvents Nagore5 As System.Windows.Forms.Button
    Friend WithEvents Jordanoff16 As System.Windows.Forms.PictureBox
    Friend WithEvents Jordanoff21 As System.Windows.Forms.PictureBox
    Friend WithEvents NextPic As System.Windows.Forms.Button
End Class
