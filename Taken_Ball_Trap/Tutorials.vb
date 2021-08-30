Public Class Tutorials
    Public numeroTips As Integer = 1

    Public Sub montrerSuccessivementLeTutoriel()
        Select Case numeroTips
            Case 1
                groupBox1.Show()
                groupBox2.Hide()
                groupBox3.Hide()
                groupBox4.Hide()
                groupBox5.Hide()
                groupBox6.Hide()
                groupBox7.Hide()
                numeroTips = 2
            Case 2
                groupBox1.Hide()
                groupBox2.Show()
                groupBox3.Hide()
                groupBox4.Hide()
                groupBox5.Hide()
                groupBox6.Hide()
                groupBox7.Hide()
                numeroTips = 3
            Case 3
                groupBox1.Hide()
                groupBox2.Hide()
                groupBox3.Show()
                groupBox4.Hide()
                groupBox5.Hide()
                groupBox6.Hide()
                groupBox7.Hide()
                numeroTips = 4
            Case 4
                groupBox1.Hide()
                groupBox2.Hide()
                groupBox3.Hide()
                groupBox4.Show()
                groupBox5.Hide()
                groupBox6.Hide()
                groupBox7.Hide()
                numeroTips = 5
            Case 5
                groupBox1.Hide()
                groupBox2.Hide()
                groupBox3.Hide()
                groupBox4.Hide()
                groupBox5.Show()
                groupBox6.Hide()
                groupBox7.Hide()
                numeroTips = 6
            Case 6
                groupBox1.Hide()
                groupBox2.Hide()
                groupBox3.Hide()
                groupBox4.Hide()
                groupBox5.Hide()
                groupBox6.Show()
                groupBox7.Hide()
                numeroTips = 7
            Case 7
                groupBox1.Hide()
                groupBox2.Hide()
                groupBox3.Hide()
                groupBox4.Hide()
                groupBox5.Hide()
                groupBox6.Hide()
                groupBox7.Show()
                numeroTips = 1
        End Select
    End Sub

    Private Sub Tutorials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim largeurDeTips1 As Integer = groupBox1.Width
        Dim hauteurTips1 As Integer = groupBox1.Height
        Dim posTips1 As New Point(groupBox1.Location.X, groupBox1.Location.Y)

        groupBox2.Location = posTips1
        groupBox3.Location = posTips1
        groupBox4.Location = posTips1
        groupBox5.Location = posTips1
        groupBox6.Location = posTips1
        groupBox7.Location = posTips1

        groupBox2.Width = largeurDeTips1
        groupBox2.Height = hauteurTips1
        groupBox3.Width = largeurDeTips1
        groupBox3.Height = hauteurTips1
        groupBox4.Width = largeurDeTips1
        groupBox4.Height = hauteurTips1
        groupBox5.Width = largeurDeTips1
        groupBox5.Height = hauteurTips1
        groupBox6.Width = largeurDeTips1
        groupBox6.Height = hauteurTips1
        groupBox7.Width = largeurDeTips1
        groupBox7.Height = hauteurTips1

        groupBox2.Hide()
        groupBox3.Hide()
        groupBox4.Hide()
        groupBox5.Hide()
        groupBox6.Hide()
        groupBox7.Hide()

    End Sub

    Private Sub suivant_Click(sender As Object, e As EventArgs) Handles suivant.Click
        montrerSuccessivementLeTutoriel()
    End Sub

    Private Sub bouttonFermer_Click(sender As Object, e As EventArgs) Handles bouttonFermer.Click
        Me.Close()
        Reglages.Show()
    End Sub
End Class