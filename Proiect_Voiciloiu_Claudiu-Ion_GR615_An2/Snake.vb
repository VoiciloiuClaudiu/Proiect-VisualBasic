Public Class Snake

#Region "Snake Stuff"
    Dim snake(1000) As PictureBox
    Dim lenghtOfSnake As Integer = -1
    Dim leftRightMover As Integer = 0
    Dim upDownMover As Integer = 0
    Dim r As New Random

    Private Sub createHead()
        lenghtOfSnake += 1
        snake(lenghtOfSnake) = New PictureBox
        With (snake(lenghtOfSnake))
            .Height = 10
            .Width = 10
            .BackColor = Color.White
            .Top = (pb_Field.Top + pb_Field.Bottom) / 2
            .Left = (pb_Field.Left + pb_Field.Right) / 2
        End With
        Me.Controls.Add(snake(lenghtOfSnake))
        snake(lenghtOfSnake).BringToFront()
    End Sub
    Private Sub lengthenSnake()
        lenghtOfSnake += 1
        snake(lenghtOfSnake) = New PictureBox
        With snake(lenghtOfSnake)
            .Height = 10
            .Width = 10
            .BackColor = Color.White
            .Top = snake(lenghtOfSnake - 1).Top
            .Left = snake(lenghtOfSnake - 1).Left + 10
        End With
        Me.Controls.Add(snake(lenghtOfSnake))
        snake(lenghtOfSnake).BringToFront()
        lengthenSnake()
        lengthenSnake()
    End Sub

    Private Sub Snake_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        tm_SnakeMover.Start()
        Select Case e.KeyChar
            Case "a"
                leftRightMover = -10
                upDownMover = 0
            Case "d"
                leftRightMover = 10
                upDownMover = 0
            Case "w"
                upDownMover = -10
                leftRightMover = 0
            Case "s"
                upDownMover = 10
                leftRightMover = 0
        End Select
    End Sub

    Private Sub tm_SnaKeMover_Tick(sender As Object, e As EventArgs) Handles tm_SnakeMover.Tick
        For i = lenghtOfSnake To 1 Step -1
            snake(i).Top = snake(i - 1).Top
            snake(i).Left = snake(i - 1).Left
        Next

        snake(0).Top += upDownMover
        snake(0).Left += leftRightMover
        collideWithWalls()
        collideWithMouse()
        collideWithSelf()
    End Sub
#End Region

#Region "Collission"
    Private Sub collideWithWalls()
        If snake(0).Left < pb_Field.Left Then
            tm_SnakeMover.Stop()
            MsgBox("You Lose left!")
        End If

        If snake(0).Right > pb_Field.Right Then
            tm_SnakeMover.Stop()
            MsgBox("You Lose right!")
        End If

        If snake(0).Top < pb_Field.Top Then
            tm_SnakeMover.Stop()
            MsgBox("You Lose top!")
        End If

        If snake(0).Bottom > pb_Field.Bottom Then
            tm_SnakeMover.Stop()
            MsgBox("You Lose bottom!")
        End If
    End Sub

    Private Sub collideWithMouse()
        If snake(0).Bounds.IntersectsWith(mouse.Bounds) Then
            lengthenSnake()
            mouse.Top = r.Next(pb_Field.Top, pb_Field.Bottom - 10)
            mouse.Left = r.Next(pb_Field.Left, pb_Field.Right - 10)
        End If
    End Sub

    Private Sub collideWithSelf()
        For i = 1 To lenghtOfSnake
            If snake(0).Bounds.IntersectsWith(snake(i).Bounds) Then
                tm_SnakeMover.Stop()
                MsgBox("You Lose self!")
            End If
        Next
    End Sub
#End Region

#Region "Mouse Stuff"
    Dim mouse As PictureBox
    Private Sub createMouse()
        mouse = New PictureBox
        With mouse
            .Width = 10
            .Height = 10
            .BackColor = Color.Red
            .Top = r.Next(pb_Field.Top, pb_Field.Bottom - 10)
            .Left = r.Next(pb_Field.Left, pb_Field.Right - 10)
        End With
        Me.Controls.Add(mouse)
        mouse.BringToFront()
    End Sub
#End Region
    Private Sub Snake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createHead()
        createMouse()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main.Show()
    End Sub
End Class