<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoodBye
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GoodBye))
        Me.Outro = New System.Windows.Forms.Label
        Me.SeeYa = New System.Windows.Forms.Label
        Me.Kacane = New System.Windows.Forms.Button
        Me.Proceed = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Outro
        '
        Me.Outro.AutoSize = True
        Me.Outro.Location = New System.Drawing.Point(50, 50)
        Me.Outro.Name = "Outro"
        Me.Outro.Size = New System.Drawing.Size(383, 39)
        Me.Outro.TabIndex = 0
        Me.Outro.Text = resources.GetString("Outro.Text")
        '
        'SeeYa
        '
        Me.SeeYa.AutoSize = True
        Me.SeeYa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SeeYa.ForeColor = System.Drawing.Color.DarkGreen
        Me.SeeYa.Location = New System.Drawing.Point(175, 125)
        Me.SeeYa.Name = "SeeYa"
        Me.SeeYa.Size = New System.Drawing.Size(102, 13)
        Me.SeeYa.TabIndex = 1
        Me.SeeYa.Text = "До нови срещи!"
        '
        'Kacane
        '
        Me.Kacane.BackColor = System.Drawing.Color.FloralWhite
        Me.Kacane.ForeColor = System.Drawing.Color.DarkGreen
        Me.Kacane.Image = CType(resources.GetObject("Kacane.Image"), System.Drawing.Image)
        Me.Kacane.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Kacane.Location = New System.Drawing.Point(190, 200)
        Me.Kacane.Name = "Kacane"
        Me.Kacane.Size = New System.Drawing.Size(70, 23)
        Me.Kacane.TabIndex = 2
        Me.Kacane.Text = "Кацане"
        Me.Kacane.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Kacane.UseVisualStyleBackColor = False
        '
        'Proceed
        '
        Me.Proceed.BackColor = System.Drawing.Color.LightSlateGray
        Me.Proceed.BackgroundImage = CType(resources.GetObject("Proceed.BackgroundImage"), System.Drawing.Image)
        Me.Proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Proceed.Location = New System.Drawing.Point(482, 0)
        Me.Proceed.Name = "Proceed"
        Me.Proceed.Size = New System.Drawing.Size(10, 10)
        Me.Proceed.TabIndex = 3
        Me.Proceed.UseVisualStyleBackColor = False
        '
        'GoodBye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(492, 371)
        Me.Controls.Add(Me.Proceed)
        Me.Controls.Add(Me.Kacane)
        Me.Controls.Add(Me.SeeYa)
        Me.Controls.Add(Me.Outro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GoodBye"
        Me.Text = "Българско авиационно дело"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Outro As System.Windows.Forms.Label
    Friend WithEvents SeeYa As System.Windows.Forms.Label
    Friend WithEvents Kacane As System.Windows.Forms.Button
    Friend WithEvents Proceed As System.Windows.Forms.Button
End Class
