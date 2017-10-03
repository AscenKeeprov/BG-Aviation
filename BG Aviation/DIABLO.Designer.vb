<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DIABLO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DIABLO))
        Me.Hadriel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Hadriel
        '
        Me.Hadriel.AutoSize = True
        Me.Hadriel.BackColor = System.Drawing.Color.Maroon
        Me.Hadriel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Hadriel.Font = New System.Drawing.Font("Lucida Blackletter", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hadriel.ForeColor = System.Drawing.Color.OrangeRed
        Me.Hadriel.Location = New System.Drawing.Point(140, 25)
        Me.Hadriel.Name = "Hadriel"
        Me.Hadriel.Size = New System.Drawing.Size(379, 60)
        Me.Hadriel.TabIndex = 0
        Me.Hadriel.Text = resources.GetString("Hadriel.Text")
        '
        'DIABLO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(632, 451)
        Me.Controls.Add(Me.Hadriel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DIABLO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hadriel As System.Windows.Forms.Label
End Class
