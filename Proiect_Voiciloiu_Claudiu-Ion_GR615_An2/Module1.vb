Module Module1
    Sub CheckButton(ByRef Butt1 As Button, ByRef Butt2 As Button)
        If Butt2.Text = "" Then
            Butt2.Text = Butt1.Text
            Butt1.Text = ""
        End If
    End Sub

    Sub CheckSolved()
        If Shuffle.Button3.Text = "1" And Shuffle.Button4.Text = "2" And Shuffle.Button5.Text = "3" And Shuffle.Button6.Text = "4" And Shuffle.Button7.Text = "5" And
           Shuffle.Button8.Text = "6" And Shuffle.Button9.Text = "7" And Shuffle.Button10.Text = "8" And Shuffle.Button11.Text = "9" And Shuffle.Button12.Text = "10" And
           Shuffle.Button13.Text = "11" And Shuffle.Button14.Text = "12" And Shuffle.Button15.Text = "13" And Shuffle.Button16.Text = "14" And Shuffle.Button17.Text = "15" Then
            MsgBox("Wow, You did it in " & Shuffle.Count & " Clicks", vbInformation, "Shuffle")
        End If
        Shuffle.Count = Shuffle.Count + 1
        Shuffle.Text = "Shuffle : " & Shuffle.Count & " Clicks"
    End Sub

    Sub ShuffleV()
        Dim a(15), i, j, RN As Integer
        Dim flag As Boolean

        flag = False
        i = 1
        a(j) = 1
        Do While i <= 15
            Randomize()
            RN = CInt(Int((15 * Rnd()) + 1))

            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next
            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i = i + 1
            End If
        Loop
        Shuffle.Button3.Text = a(1)
        Shuffle.Button4.Text = a(2)
        Shuffle.Button5.Text = a(3)
        Shuffle.Button6.Text = a(4)
        Shuffle.Button7.Text = a(5)
        Shuffle.Button8.Text = a(6)
        Shuffle.Button9.Text = a(7)
        Shuffle.Button10.Text = a(8)
        Shuffle.Button11.Text = a(9)
        Shuffle.Button12.Text = a(10)
        Shuffle.Button13.Text = a(11)
        Shuffle.Button14.Text = a(12)
        Shuffle.Button15.Text = a(13)
        Shuffle.Button16.Text = a(14)
        Shuffle.Button17.Text = a(15)
        Shuffle.Button18.Text = ""
    End Sub
End Module
