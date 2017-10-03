<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Znachki
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Znachki))
        Me.LetecPilot1 = New System.Windows.Forms.PictureBox
        Me.Znachka1 = New System.Windows.Forms.Label
        Me.LetecNablyudatel = New System.Windows.Forms.PictureBox
        Me.Znachka2 = New System.Windows.Forms.Label
        Me.LetecPilot2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.LetecPilot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LetecNablyudatel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LetecPilot2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LetecPilot1
        '
        Me.LetecPilot1.Image = CType(resources.GetObject("LetecPilot1.Image"), System.Drawing.Image)
        Me.LetecPilot1.Location = New System.Drawing.Point(20, 20)
        Me.LetecPilot1.Name = "LetecPilot1"
        Me.LetecPilot1.Size = New System.Drawing.Size(160, 260)
        Me.LetecPilot1.TabIndex = 0
        Me.LetecPilot1.TabStop = False
        '
        'Znachka1
        '
        Me.Znachka1.AutoSize = True
        Me.Znachka1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Znachka1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Znachka1.Location = New System.Drawing.Point(60, 300)
        Me.Znachka1.Name = "Znachka1"
        Me.Znachka1.Size = New System.Drawing.Size(76, 15)
        Me.Znachka1.TabIndex = 1
        Me.Znachka1.Text = "Летец-пилот"
        '
        'LetecNablyudatel
        '
        Me.LetecNablyudatel.Image = CType(resources.GetObject("LetecNablyudatel.Image"), System.Drawing.Image)
        Me.LetecNablyudatel.Location = New System.Drawing.Point(200, 30)
        Me.LetecNablyudatel.Name = "LetecNablyudatel"
        Me.LetecNablyudatel.Size = New System.Drawing.Size(170, 235)
        Me.LetecNablyudatel.TabIndex = 2
        Me.LetecNablyudatel.TabStop = False
        '
        'Znachka2
        '
        Me.Znachka2.AutoSize = True
        Me.Znachka2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Znachka2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Znachka2.Location = New System.Drawing.Point(250, 285)
        Me.Znachka2.Name = "Znachka2"
        Me.Znachka2.Size = New System.Drawing.Size(72, 30)
        Me.Znachka2.TabIndex = 3
        Me.Znachka2.Text = "    Летец-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "наблюдател"
        '
        'LetecPilot2
        '
        Me.LetecPilot2.Image = CType(resources.GetObject("LetecPilot2.Image"), System.Drawing.Image)
        Me.LetecPilot2.Location = New System.Drawing.Point(390, 25)
        Me.LetecPilot2.Name = "LetecPilot2"
        Me.LetecPilot2.Size = New System.Drawing.Size(160, 250)
        Me.LetecPilot2.TabIndex = 4
        Me.LetecPilot2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(430, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Летец-пилот"
        '
        'Znachki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(592, 331)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LetecPilot2)
        Me.Controls.Add(Me.Znachka2)
        Me.Controls.Add(Me.LetecNablyudatel)
        Me.Controls.Add(Me.Znachka1)
        Me.Controls.Add(Me.LetecPilot1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Znachki"
        Me.Text = "Българско авиационно дело"
        CType(Me.LetecPilot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LetecNablyudatel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LetecPilot2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LetecPilot1 As System.Windows.Forms.PictureBox
    Friend WithEvents Znachka1 As System.Windows.Forms.Label
    Friend WithEvents LetecNablyudatel As System.Windows.Forms.PictureBox
    Friend WithEvents Znachka2 As System.Windows.Forms.Label
    Friend WithEvents LetecPilot2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
