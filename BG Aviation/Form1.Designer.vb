<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.Welcum = New System.Windows.Forms.Label
        Me.Intro = New System.Windows.Forms.Label
        Me.Ihope = New System.Windows.Forms.Label
        Me.Lets = New System.Windows.Forms.Label
        Me.Izlitane = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Welcum
        '
        resources.ApplyResources(Me.Welcum, "Welcum")
        Me.Welcum.ForeColor = System.Drawing.Color.DarkGreen
        Me.Welcum.Name = "Welcum"
        '
        'Intro
        '
        resources.ApplyResources(Me.Intro, "Intro")
        Me.Intro.ForeColor = System.Drawing.Color.Black
        Me.Intro.Name = "Intro"
        '
        'Ihope
        '
        resources.ApplyResources(Me.Ihope, "Ihope")
        Me.Ihope.ForeColor = System.Drawing.Color.DarkGreen
        Me.Ihope.Name = "Ihope"
        '
        'Lets
        '
        resources.ApplyResources(Me.Lets, "Lets")
        Me.Lets.Name = "Lets"
        '
        'Izlitane
        '
        Me.Izlitane.BackColor = System.Drawing.Color.FloralWhite
        resources.ApplyResources(Me.Izlitane, "Izlitane")
        Me.Izlitane.ForeColor = System.Drawing.Color.DarkGreen
        Me.Izlitane.Name = "Izlitane"
        Me.Izlitane.UseVisualStyleBackColor = False
        '
        'Welcome
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.Controls.Add(Me.Izlitane)
        Me.Controls.Add(Me.Lets)
        Me.Controls.Add(Me.Ihope)
        Me.Controls.Add(Me.Intro)
        Me.Controls.Add(Me.Welcum)
        Me.Name = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Welcum As System.Windows.Forms.Label
    Friend WithEvents Intro As System.Windows.Forms.Label
    Friend WithEvents Ihope As System.Windows.Forms.Label
    Friend WithEvents Lets As System.Windows.Forms.Label
    Friend WithEvents Izlitane As System.Windows.Forms.Button

End Class
