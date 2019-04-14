Public Class SlideShow

    Dim images(10) As Bitmap
    Dim pos As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub SlideShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Hide()
        images(0) = Proiect_Voiciloiu_Claudiu_Ion_GR615_An2.My.Resources.img27
        images(1) = Proiect_Voiciloiu_Claudiu_Ion_GR615_An2.My.Resources.IMG_5096
        images(3) = Proiect_Voiciloiu_Claudiu_Ion_GR615_An2.My.Resources.romano_americana
        images(4) = Proiect_Voiciloiu_Claudiu_Ion_GR615_An2.My.Resources.uraPriv
        images(5) = Proiect_Voiciloiu_Claudiu_Ion_GR615_An2.My.Resources.uraH

        PictureBox1.Image = images(0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pos = pos + 1
        If pos < images.Length - 1 Then
            PictureBox1.Image = images(pos)
        Else
            pos = images.Length - 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pos = pos - 1
        If pos >= 0 Then
            PictureBox1.Image = images(pos)
        Else
            pos = 0
        End If
    End Sub
End Class