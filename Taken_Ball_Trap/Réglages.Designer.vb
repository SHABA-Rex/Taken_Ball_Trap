<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reglages
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
        Me.msgDeVictoireOuDeDefaite = New System.Windows.Forms.Label()
        Me.bouttonFermer = New Guna.UI.WinForms.GunaButton()
        Me.help = New Guna.UI.WinForms.GunaButton()
        Me.difficulte = New Guna.UI.WinForms.GunaTileButton()
        Me.accederAuScore = New Guna.UI.WinForms.GunaTileButton()
        Me.continuer = New Guna.UI.WinForms.GunaTileButton()
        Me.helpLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'msgDeVictoireOuDeDefaite
        '
        Me.msgDeVictoireOuDeDefaite.BackColor = System.Drawing.Color.Red
        Me.msgDeVictoireOuDeDefaite.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgDeVictoireOuDeDefaite.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.msgDeVictoireOuDeDefaite.Location = New System.Drawing.Point(70, 30)
        Me.msgDeVictoireOuDeDefaite.Name = "msgDeVictoireOuDeDefaite"
        Me.msgDeVictoireOuDeDefaite.Size = New System.Drawing.Size(325, 49)
        Me.msgDeVictoireOuDeDefaite.TabIndex = 0
        Me.msgDeVictoireOuDeDefaite.Text = "Tu as perdu"
        Me.msgDeVictoireOuDeDefaite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.bouttonFermer.Location = New System.Drawing.Point(434, -4)
        Me.bouttonFermer.Name = "bouttonFermer"
        Me.bouttonFermer.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bouttonFermer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bouttonFermer.OnHoverForeColor = System.Drawing.Color.White
        Me.bouttonFermer.OnHoverImage = Nothing
        Me.bouttonFermer.OnPressedColor = System.Drawing.Color.Black
        Me.bouttonFermer.Size = New System.Drawing.Size(32, 28)
        Me.bouttonFermer.TabIndex = 4
        Me.bouttonFermer.Text = "X"
        Me.bouttonFermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'help
        '
        Me.help.AnimationHoverSpeed = 0.07!
        Me.help.AnimationSpeed = 0.03!
        Me.help.BackColor = System.Drawing.Color.Transparent
        Me.help.BaseColor = System.Drawing.Color.Chartreuse
        Me.help.BorderColor = System.Drawing.Color.Black
        Me.help.DialogResult = System.Windows.Forms.DialogResult.None
        Me.help.FocusedColor = System.Drawing.Color.Empty
        Me.help.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.help.ForeColor = System.Drawing.Color.White
        Me.help.Image = Global.Taken_Ball_Trap.My.Resources.Resources.help_64px
        Me.help.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.help.ImageSize = New System.Drawing.Size(20, 20)
        Me.help.Location = New System.Drawing.Point(400, 41)
        Me.help.Name = "help"
        Me.help.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.help.OnHoverBorderColor = System.Drawing.Color.Black
        Me.help.OnHoverForeColor = System.Drawing.Color.White
        Me.help.OnHoverImage = Nothing
        Me.help.OnPressedColor = System.Drawing.Color.Black
        Me.help.Radius = 12
        Me.help.Size = New System.Drawing.Size(30, 29)
        Me.help.TabIndex = 5
        Me.help.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'difficulte
        '
        Me.difficulte.AnimationHoverSpeed = 0.07!
        Me.difficulte.AnimationSpeed = 0.03!
        Me.difficulte.BackColor = System.Drawing.Color.Transparent
        Me.difficulte.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.difficulte.BorderColor = System.Drawing.Color.Black
        Me.difficulte.DialogResult = System.Windows.Forms.DialogResult.None
        Me.difficulte.FocusedColor = System.Drawing.Color.Empty
        Me.difficulte.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.difficulte.ForeColor = System.Drawing.Color.White
        Me.difficulte.Image = Global.Taken_Ball_Trap.My.Resources.Resources.brick_wall_64px
        Me.difficulte.ImageSize = New System.Drawing.Size(52, 52)
        Me.difficulte.Location = New System.Drawing.Point(306, 104)
        Me.difficulte.Name = "difficulte"
        Me.difficulte.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.difficulte.OnHoverBorderColor = System.Drawing.Color.Black
        Me.difficulte.OnHoverForeColor = System.Drawing.Color.White
        Me.difficulte.OnHoverImage = Nothing
        Me.difficulte.OnPressedColor = System.Drawing.Color.Black
        Me.difficulte.Radius = 10
        Me.difficulte.Size = New System.Drawing.Size(138, 127)
        Me.difficulte.TabIndex = 3
        Me.difficulte.Text = "Difficulté"
        '
        'accederAuScore
        '
        Me.accederAuScore.AnimationHoverSpeed = 0.07!
        Me.accederAuScore.AnimationSpeed = 0.03!
        Me.accederAuScore.BackColor = System.Drawing.Color.Transparent
        Me.accederAuScore.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.accederAuScore.BorderColor = System.Drawing.Color.Black
        Me.accederAuScore.DialogResult = System.Windows.Forms.DialogResult.None
        Me.accederAuScore.FocusedColor = System.Drawing.Color.Empty
        Me.accederAuScore.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.accederAuScore.ForeColor = System.Drawing.Color.White
        Me.accederAuScore.Image = Global.Taken_Ball_Trap.My.Resources.Resources.rating_48px
        Me.accederAuScore.ImageSize = New System.Drawing.Size(52, 52)
        Me.accederAuScore.Location = New System.Drawing.Point(162, 104)
        Me.accederAuScore.Name = "accederAuScore"
        Me.accederAuScore.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.accederAuScore.OnHoverBorderColor = System.Drawing.Color.Black
        Me.accederAuScore.OnHoverForeColor = System.Drawing.Color.White
        Me.accederAuScore.OnHoverImage = Nothing
        Me.accederAuScore.OnPressedColor = System.Drawing.Color.Black
        Me.accederAuScore.Radius = 10
        Me.accederAuScore.Size = New System.Drawing.Size(138, 127)
        Me.accederAuScore.TabIndex = 2
        Me.accederAuScore.Text = "Mon score"
        '
        'continuer
        '
        Me.continuer.AnimationHoverSpeed = 0.07!
        Me.continuer.AnimationSpeed = 0.03!
        Me.continuer.BackColor = System.Drawing.Color.Transparent
        Me.continuer.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.continuer.BorderColor = System.Drawing.Color.Black
        Me.continuer.DialogResult = System.Windows.Forms.DialogResult.None
        Me.continuer.FocusedColor = System.Drawing.Color.Empty
        Me.continuer.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.continuer.ForeColor = System.Drawing.Color.White
        Me.continuer.Image = Global.Taken_Ball_Trap.My.Resources.Resources.quick_mode_on_100px
        Me.continuer.ImageSize = New System.Drawing.Size(52, 52)
        Me.continuer.Location = New System.Drawing.Point(18, 104)
        Me.continuer.Name = "continuer"
        Me.continuer.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.continuer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.continuer.OnHoverForeColor = System.Drawing.Color.White
        Me.continuer.OnHoverImage = Nothing
        Me.continuer.OnPressedColor = System.Drawing.Color.Black
        Me.continuer.Radius = 10
        Me.continuer.Size = New System.Drawing.Size(138, 127)
        Me.continuer.TabIndex = 1
        Me.continuer.Text = "Continuer"
        '
        'helpLabel
        '
        Me.helpLabel.AutoSize = True
        Me.helpLabel.Location = New System.Drawing.Point(401, 74)
        Me.helpLabel.Name = "helpLabel"
        Me.helpLabel.Size = New System.Drawing.Size(35, 13)
        Me.helpLabel.TabIndex = 6
        Me.helpLabel.Text = "Help?"
        Me.helpLabel.Visible = False
        '
        'Reglages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(463, 253)
        Me.Controls.Add(Me.helpLabel)
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.bouttonFermer)
        Me.Controls.Add(Me.difficulte)
        Me.Controls.Add(Me.accederAuScore)
        Me.Controls.Add(Me.continuer)
        Me.Controls.Add(Me.msgDeVictoireOuDeDefaite)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reglages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Réglages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msgDeVictoireOuDeDefaite As Label
    Friend WithEvents continuer As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents accederAuScore As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents difficulte As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents bouttonFermer As Guna.UI.WinForms.GunaButton
    Friend WithEvents help As Guna.UI.WinForms.GunaButton
    Friend WithEvents helpLabel As Label
End Class
