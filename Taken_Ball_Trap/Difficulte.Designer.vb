<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class windowDifficulte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(windowDifficulte))
        Me.bouttonFermer = New Guna.UI.WinForms.GunaButton()
        Me.niveauMoyen = New Guna.UI.WinForms.GunaButton()
        Me.niveauNormal = New Guna.UI.WinForms.GunaButton()
        Me.niveauEleve = New Guna.UI.WinForms.GunaButton()
        Me.niveauImpossible = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'bouttonFermer
        '
        Me.bouttonFermer.AnimationHoverSpeed = 0.07!
        Me.bouttonFermer.AnimationSpeed = 0.03!
        Me.bouttonFermer.BaseColor = System.Drawing.Color.GreenYellow
        Me.bouttonFermer.BorderColor = System.Drawing.Color.Black
        Me.bouttonFermer.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bouttonFermer.FocusedColor = System.Drawing.Color.Empty
        Me.bouttonFermer.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bouttonFermer.ForeColor = System.Drawing.Color.Red
        Me.bouttonFermer.Image = Nothing
        Me.bouttonFermer.ImageSize = New System.Drawing.Size(20, 20)
        Me.bouttonFermer.Location = New System.Drawing.Point(262, -2)
        Me.bouttonFermer.Name = "bouttonFermer"
        Me.bouttonFermer.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bouttonFermer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bouttonFermer.OnHoverForeColor = System.Drawing.Color.White
        Me.bouttonFermer.OnHoverImage = Nothing
        Me.bouttonFermer.OnPressedColor = System.Drawing.Color.Black
        Me.bouttonFermer.Size = New System.Drawing.Size(32, 28)
        Me.bouttonFermer.TabIndex = 6
        Me.bouttonFermer.Text = "X"
        Me.bouttonFermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'niveauMoyen
        '
        Me.niveauMoyen.AnimationHoverSpeed = 0.07!
        Me.niveauMoyen.AnimationSpeed = 0.03!
        Me.niveauMoyen.BaseColor = System.Drawing.Color.Green
        Me.niveauMoyen.BorderColor = System.Drawing.Color.Black
        Me.niveauMoyen.DialogResult = System.Windows.Forms.DialogResult.None
        Me.niveauMoyen.FocusedColor = System.Drawing.Color.Empty
        Me.niveauMoyen.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.niveauMoyen.ForeColor = System.Drawing.Color.White
        Me.niveauMoyen.Image = CType(resources.GetObject("niveauMoyen.Image"), System.Drawing.Image)
        Me.niveauMoyen.ImageSize = New System.Drawing.Size(20, 20)
        Me.niveauMoyen.Location = New System.Drawing.Point(29, 107)
        Me.niveauMoyen.Name = "niveauMoyen"
        Me.niveauMoyen.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.niveauMoyen.OnHoverBorderColor = System.Drawing.Color.Black
        Me.niveauMoyen.OnHoverForeColor = System.Drawing.Color.White
        Me.niveauMoyen.OnHoverImage = Nothing
        Me.niveauMoyen.OnPressedColor = System.Drawing.Color.Black
        Me.niveauMoyen.Size = New System.Drawing.Size(237, 42)
        Me.niveauMoyen.TabIndex = 8
        Me.niveauMoyen.Text = "MOYEN"
        Me.niveauMoyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'niveauNormal
        '
        Me.niveauNormal.AnimationHoverSpeed = 0.07!
        Me.niveauNormal.AnimationSpeed = 0.03!
        Me.niveauNormal.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.niveauNormal.BorderColor = System.Drawing.Color.Black
        Me.niveauNormal.DialogResult = System.Windows.Forms.DialogResult.None
        Me.niveauNormal.FocusedColor = System.Drawing.Color.Empty
        Me.niveauNormal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.niveauNormal.ForeColor = System.Drawing.Color.White
        Me.niveauNormal.Image = CType(resources.GetObject("niveauNormal.Image"), System.Drawing.Image)
        Me.niveauNormal.ImageSize = New System.Drawing.Size(20, 20)
        Me.niveauNormal.Location = New System.Drawing.Point(29, 43)
        Me.niveauNormal.Name = "niveauNormal"
        Me.niveauNormal.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.niveauNormal.OnHoverBorderColor = System.Drawing.Color.Black
        Me.niveauNormal.OnHoverForeColor = System.Drawing.Color.White
        Me.niveauNormal.OnHoverImage = Nothing
        Me.niveauNormal.OnPressedColor = System.Drawing.Color.Black
        Me.niveauNormal.Size = New System.Drawing.Size(237, 42)
        Me.niveauNormal.TabIndex = 7
        Me.niveauNormal.Text = "NORMAL"
        Me.niveauNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'niveauEleve
        '
        Me.niveauEleve.AnimationHoverSpeed = 0.07!
        Me.niveauEleve.AnimationSpeed = 0.03!
        Me.niveauEleve.BaseColor = System.Drawing.Color.Red
        Me.niveauEleve.BorderColor = System.Drawing.Color.Black
        Me.niveauEleve.DialogResult = System.Windows.Forms.DialogResult.None
        Me.niveauEleve.FocusedColor = System.Drawing.Color.Empty
        Me.niveauEleve.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.niveauEleve.ForeColor = System.Drawing.Color.White
        Me.niveauEleve.Image = CType(resources.GetObject("niveauEleve.Image"), System.Drawing.Image)
        Me.niveauEleve.ImageSize = New System.Drawing.Size(20, 20)
        Me.niveauEleve.Location = New System.Drawing.Point(29, 172)
        Me.niveauEleve.Name = "niveauEleve"
        Me.niveauEleve.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.niveauEleve.OnHoverBorderColor = System.Drawing.Color.Black
        Me.niveauEleve.OnHoverForeColor = System.Drawing.Color.White
        Me.niveauEleve.OnHoverImage = Nothing
        Me.niveauEleve.OnPressedColor = System.Drawing.Color.Black
        Me.niveauEleve.Size = New System.Drawing.Size(237, 42)
        Me.niveauEleve.TabIndex = 9
        Me.niveauEleve.Text = "ÉLEVÉ"
        Me.niveauEleve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'niveauImpossible
        '
        Me.niveauImpossible.AnimationHoverSpeed = 0.07!
        Me.niveauImpossible.AnimationSpeed = 0.03!
        Me.niveauImpossible.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.niveauImpossible.BorderColor = System.Drawing.Color.Black
        Me.niveauImpossible.DialogResult = System.Windows.Forms.DialogResult.None
        Me.niveauImpossible.FocusedColor = System.Drawing.Color.Empty
        Me.niveauImpossible.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.niveauImpossible.ForeColor = System.Drawing.Color.White
        Me.niveauImpossible.Image = CType(resources.GetObject("niveauImpossible.Image"), System.Drawing.Image)
        Me.niveauImpossible.ImageSize = New System.Drawing.Size(20, 20)
        Me.niveauImpossible.Location = New System.Drawing.Point(29, 239)
        Me.niveauImpossible.Name = "niveauImpossible"
        Me.niveauImpossible.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.niveauImpossible.OnHoverBorderColor = System.Drawing.Color.Black
        Me.niveauImpossible.OnHoverForeColor = System.Drawing.Color.White
        Me.niveauImpossible.OnHoverImage = Nothing
        Me.niveauImpossible.OnPressedColor = System.Drawing.Color.Black
        Me.niveauImpossible.Size = New System.Drawing.Size(237, 42)
        Me.niveauImpossible.TabIndex = 10
        Me.niveauImpossible.Text = "IMPOSSIBLE"
        Me.niveauImpossible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'windowDifficulte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(293, 321)
        Me.Controls.Add(Me.niveauImpossible)
        Me.Controls.Add(Me.niveauEleve)
        Me.Controls.Add(Me.niveauMoyen)
        Me.Controls.Add(Me.niveauNormal)
        Me.Controls.Add(Me.bouttonFermer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "windowDifficulte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Difficulte"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bouttonFermer As Guna.UI.WinForms.GunaButton
    Friend WithEvents niveauNormal As Guna.UI.WinForms.GunaButton
    Friend WithEvents niveauMoyen As Guna.UI.WinForms.GunaButton
    Friend WithEvents niveauEleve As Guna.UI.WinForms.GunaButton
    Friend WithEvents niveauImpossible As Guna.UI.WinForms.GunaButton
End Class
