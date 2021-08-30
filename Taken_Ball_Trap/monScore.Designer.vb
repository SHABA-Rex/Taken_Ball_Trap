<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
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
        Me.label2MonScore = New System.Windows.Forms.Label()
        Me.labelMonScore = New System.Windows.Forms.Label()
        Me.bouttonFermer = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'label2MonScore
        '
        Me.label2MonScore.AutoSize = True
        Me.label2MonScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2MonScore.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.label2MonScore.Location = New System.Drawing.Point(87, 35)
        Me.label2MonScore.Name = "label2MonScore"
        Me.label2MonScore.Size = New System.Drawing.Size(138, 29)
        Me.label2MonScore.TabIndex = 0
        Me.label2MonScore.Text = "Mon score :"
        Me.label2MonScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelMonScore
        '
        Me.labelMonScore.BackColor = System.Drawing.Color.Lime
        Me.labelMonScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMonScore.ForeColor = System.Drawing.Color.White
        Me.labelMonScore.Location = New System.Drawing.Point(-3, 71)
        Me.labelMonScore.Name = "labelMonScore"
        Me.labelMonScore.Size = New System.Drawing.Size(314, 242)
        Me.labelMonScore.TabIndex = 1
        Me.labelMonScore.Text = "10"
        Me.labelMonScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.bouttonFermer.Location = New System.Drawing.Point(279, -2)
        Me.bouttonFermer.Name = "bouttonFermer"
        Me.bouttonFermer.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bouttonFermer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bouttonFermer.OnHoverForeColor = System.Drawing.Color.White
        Me.bouttonFermer.OnHoverImage = Nothing
        Me.bouttonFermer.OnPressedColor = System.Drawing.Color.Black
        Me.bouttonFermer.Size = New System.Drawing.Size(32, 28)
        Me.bouttonFermer.TabIndex = 5
        Me.bouttonFermer.Text = "X"
        Me.bouttonFermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(309, 360)
        Me.Controls.Add(Me.bouttonFermer)
        Me.Controls.Add(Me.labelMonScore)
        Me.Controls.Add(Me.label2MonScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Scores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "monScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label2MonScore As Label
    Friend WithEvents labelMonScore As Label
    Friend WithEvents bouttonFermer As Guna.UI.WinForms.GunaButton
End Class
