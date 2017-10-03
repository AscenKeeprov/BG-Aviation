<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordeni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ordeni))
        Me.Orden1 = New System.Windows.Forms.PictureBox
        Me.Orden2 = New System.Windows.Forms.PictureBox
        Me.Orden3 = New System.Windows.Forms.PictureBox
        Me.Orden4 = New System.Windows.Forms.PictureBox
        CType(Me.Orden1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Orden2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Orden3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Orden4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Orden1
        '
        Me.Orden1.Image = CType(resources.GetObject("Orden1.Image"), System.Drawing.Image)
        Me.Orden1.Location = New System.Drawing.Point(20, 65)
        Me.Orden1.Name = "Orden1"
        Me.Orden1.Size = New System.Drawing.Size(145, 135)
        Me.Orden1.TabIndex = 0
        Me.Orden1.TabStop = False
        '
        'Orden2
        '
        Me.Orden2.Image = CType(resources.GetObject("Orden2.Image"), System.Drawing.Image)
        Me.Orden2.Location = New System.Drawing.Point(350, 29)
        Me.Orden2.Name = "Orden2"
        Me.Orden2.Size = New System.Drawing.Size(145, 205)
        Me.Orden2.TabIndex = 1
        Me.Orden2.TabStop = False
        '
        'Orden3
        '
        Me.Orden3.Image = CType(resources.GetObject("Orden3.Image"), System.Drawing.Image)
        Me.Orden3.Location = New System.Drawing.Point(185, 31)
        Me.Orden3.Name = "Orden3"
        Me.Orden3.Size = New System.Drawing.Size(140, 200)
        Me.Orden3.TabIndex = 2
        Me.Orden3.TabStop = False
        '
        'Orden4
        '
        Me.Orden4.Image = CType(resources.GetObject("Orden4.Image"), System.Drawing.Image)
        Me.Orden4.Location = New System.Drawing.Point(520, 20)
        Me.Orden4.Name = "Orden4"
        Me.Orden4.Size = New System.Drawing.Size(120, 225)
        Me.Orden4.TabIndex = 3
        Me.Orden4.TabStop = False
        '
        'Ordeni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(662, 266)
        Me.Controls.Add(Me.Orden4)
        Me.Controls.Add(Me.Orden3)
        Me.Controls.Add(Me.Orden2)
        Me.Controls.Add(Me.Orden1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ordeni"
        Me.Text = "Българско авиационно дело"
        CType(Me.Orden1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Orden2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Orden3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Orden4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Orden1 As System.Windows.Forms.PictureBox
    Friend WithEvents Orden2 As System.Windows.Forms.PictureBox
    Friend WithEvents Orden3 As System.Windows.Forms.PictureBox
    Friend WithEvents Orden4 As System.Windows.Forms.PictureBox
End Class
