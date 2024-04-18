Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim PlayerTurn As Integer = 1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Console.WriteLine("Daddy is annoying B")
        If Len(TextBox1.Text) = 2 And Char.IsLetter(Mid(TextBox1.Text, 1)) And IsNumeric(Mid(TextBox1.Text, 2)) Then

            Dim CoordLetter As Char = Mid(TextBox1.Text, 1)
            Dim CoordNumber As String = Mid(TextBox1.Text, 2)
            Dim Coordinate As String = CoordLetter + CoordNumber

            If CoordNumber = 5 Or CoordNumber = 4 Or CoordNumber = 3 Or CoordNumber = 2 Or CoordNumber = 1 Then
                If CoordLetter = "A" And CoordNumber = 5 And (PictureBoxA6.BackColor = Color.Red Or PictureBoxA6.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "A" And CoordNumber = 4 And (PictureBoxA6.BackColor = Color.Red Or PictureBoxA6.BackColor = Color.Blue) And (PictureBoxA5.BackColor = Color.Red Or PictureBoxA5.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "A" And CoordNumber = 3 And (PictureBoxA6.BackColor = Color.Red Or PictureBoxA6.BackColor = Color.Blue) And (PictureBoxA5.BackColor = Color.Red Or PictureBoxA5.BackColor = Color.Blue) And (PictureBoxA4.BackColor = Color.Red Or PictureBoxA4.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "A" And CoordNumber = 2 And (PictureBoxA6.BackColor = Color.Red Or PictureBoxA6.BackColor = Color.Blue) And (PictureBoxA5.BackColor = Color.Red Or PictureBoxA5.BackColor = Color.Blue) And (PictureBoxA4.BackColor = Color.Red Or PictureBoxA4.BackColor = Color.Blue) And (PictureBoxA3.BackColor = Color.Red Or PictureBoxA3.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "A" And CoordNumber = 1 And (PictureBoxA6.BackColor = Color.Red Or PictureBoxA6.BackColor = Color.Blue) And (PictureBoxA5.BackColor = Color.Red Or PictureBoxA5.BackColor = Color.Blue) And (PictureBoxA4.BackColor = Color.Red Or PictureBoxA4.BackColor = Color.Blue) And (PictureBoxA3.BackColor = Color.Red Or PictureBoxA3.BackColor = Color.Blue) And (PictureBoxA2.BackColor = Color.Red Or PictureBoxA2.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "B" And CoordNumber = 5 And (PictureBoxB6.BackColor = Color.Red Or PictureBoxB6.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "B" And CoordNumber = 4 And (PictureBoxB6.BackColor = Color.Red Or PictureBoxB6.BackColor = Color.Blue) And (PictureBoxB5.BackColor = Color.Red Or PictureBoxB5.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "B" And CoordNumber = 3 And (PictureBoxB6.BackColor = Color.Red Or PictureBoxB6.BackColor = Color.Blue) And (PictureBoxB5.BackColor = Color.Red Or PictureBoxB5.BackColor = Color.Blue) And (PictureBoxB4.BackColor = Color.Red Or PictureBoxB4.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "B" And CoordNumber = 2 And (PictureBoxB6.BackColor = Color.Red Or PictureBoxB6.BackColor = Color.Blue) And (PictureBoxB5.BackColor = Color.Red Or PictureBoxB5.BackColor = Color.Blue) And (PictureBoxB4.BackColor = Color.Red Or PictureBoxB4.BackColor = Color.Blue) And (PictureBoxB3.BackColor = Color.Red Or PictureBoxB3.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "B" And CoordNumber = 1 And (PictureBoxB6.BackColor = Color.Red Or PictureBoxB6.BackColor = Color.Blue) And (PictureBoxB5.BackColor = Color.Red Or PictureBoxB5.BackColor = Color.Blue) And (PictureBoxB4.BackColor = Color.Red Or PictureBoxB4.BackColor = Color.Blue) And (PictureBoxB3.BackColor = Color.Red Or PictureBoxB3.BackColor = Color.Blue) And (PictureBoxB2.BackColor = Color.Red Or PictureBoxB2.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "C" And CoordNumber = 5 And (PictureBoxC6.BackColor = Color.Red Or PictureBoxC6.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "C" And CoordNumber = 4 And (PictureBoxC6.BackColor = Color.Red Or PictureBoxC6.BackColor = Color.Blue) And (PictureBoxC5.BackColor = Color.Red Or PictureBoxC5.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "C" And CoordNumber = 3 And (PictureBoxC6.BackColor = Color.Red Or PictureBoxC6.BackColor = Color.Blue) And (PictureBoxC5.BackColor = Color.Red Or PictureBoxC5.BackColor = Color.Blue) And (PictureBoxC4.BackColor = Color.Red Or PictureBoxC4.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "C" And CoordNumber = 2 And (PictureBoxC6.BackColor = Color.Red Or PictureBoxC6.BackColor = Color.Blue) And (PictureBoxC5.BackColor = Color.Red Or PictureBoxC5.BackColor = Color.Blue) And (PictureBoxC4.BackColor = Color.Red Or PictureBoxC4.BackColor = Color.Blue) And (PictureBoxC3.BackColor = Color.Red Or PictureBoxC3.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "C" And CoordNumber = 1 And (PictureBoxC6.BackColor = Color.Red Or PictureBoxC6.BackColor = Color.Blue) And (PictureBoxC5.BackColor = Color.Red Or PictureBoxC5.BackColor = Color.Blue) And (PictureBoxC4.BackColor = Color.Red Or PictureBoxC4.BackColor = Color.Blue) And (PictureBoxC3.BackColor = Color.Red Or PictureBoxC3.BackColor = Color.Blue) And (PictureBoxC2.BackColor = Color.Red Or PictureBoxC2.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "D" And CoordNumber = 5 And (PictureBoxD6.BackColor = Color.Red Or PictureBoxD6.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "D" And CoordNumber = 4 And (PictureBoxD6.BackColor = Color.Red Or PictureBoxD6.BackColor = Color.Blue) And (PictureBoxD5.BackColor = Color.Red Or PictureBoxD5.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "D" And CoordNumber = 3 And (PictureBoxD6.BackColor = Color.Red Or PictureBoxD6.BackColor = Color.Blue) And (PictureBoxD5.BackColor = Color.Red Or PictureBoxD5.BackColor = Color.Blue) And (PictureBoxD4.BackColor = Color.Red Or PictureBoxD4.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "D" And CoordNumber = 2 And (PictureBoxD6.BackColor = Color.Red Or PictureBoxD6.BackColor = Color.Blue) And (PictureBoxD5.BackColor = Color.Red Or PictureBoxD5.BackColor = Color.Blue) And (PictureBoxD4.BackColor = Color.Red Or PictureBoxD4.BackColor = Color.Blue) And (PictureBoxD3.BackColor = Color.Red Or PictureBoxD3.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "D" And CoordNumber = 1 And (PictureBoxD6.BackColor = Color.Red Or PictureBoxD6.BackColor = Color.Blue) And (PictureBoxD5.BackColor = Color.Red Or PictureBoxD5.BackColor = Color.Blue) And (PictureBoxD4.BackColor = Color.Red Or PictureBoxD4.BackColor = Color.Blue) And (PictureBoxD3.BackColor = Color.Red Or PictureBoxD3.BackColor = Color.Blue) And (PictureBoxD2.BackColor = Color.Red Or PictureBoxD2.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "E" And CoordNumber = 5 And (PictureBoxE6.BackColor = Color.Red Or PictureBoxE6.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "E" And CoordNumber = 4 And (PictureBoxE6.BackColor = Color.Red Or PictureBoxE6.BackColor = Color.Blue) And (PictureBoxE5.BackColor = Color.Red Or PictureBoxE5.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "E" And CoordNumber = 3 And (PictureBoxE6.BackColor = Color.Red Or PictureBoxE6.BackColor = Color.Blue) And (PictureBoxE5.BackColor = Color.Red Or PictureBoxE5.BackColor = Color.Blue) And (PictureBoxE4.BackColor = Color.Red Or PictureBoxE4.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "E" And CoordNumber = 2 And (PictureBoxE6.BackColor = Color.Red Or PictureBoxE6.BackColor = Color.Blue) And (PictureBoxE5.BackColor = Color.Red Or PictureBoxE5.BackColor = Color.Blue) And (PictureBoxE4.BackColor = Color.Red Or PictureBoxE4.BackColor = Color.Blue) And (PictureBoxE3.BackColor = Color.Red Or PictureBoxE3.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "E" And CoordNumber = 1 And (PictureBoxE6.BackColor = Color.Red Or PictureBoxE6.BackColor = Color.Blue) And (PictureBoxE5.BackColor = Color.Red Or PictureBoxE5.BackColor = Color.Blue) And (PictureBoxE4.BackColor = Color.Red Or PictureBoxE4.BackColor = Color.Blue) And (PictureBoxE3.BackColor = Color.Red Or PictureBoxE3.BackColor = Color.Blue) And (PictureBoxE2.BackColor = Color.Red Or PictureBoxE2.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "F" And CoordNumber = 5 And (PictureBoxF6.BackColor = Color.Red Or PictureBoxF6.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "F" And CoordNumber = 4 And (PictureBoxF6.BackColor = Color.Red Or PictureBoxF6.BackColor = Color.Blue) And (PictureBoxF5.BackColor = Color.Red Or PictureBoxF5.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "F" And CoordNumber = 3 And (PictureBoxF6.BackColor = Color.Red Or PictureBoxF6.BackColor = Color.Blue) And (PictureBoxF5.BackColor = Color.Red Or PictureBoxF5.BackColor = Color.Blue) And (PictureBoxF4.BackColor = Color.Red Or PictureBoxF4.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "F" And CoordNumber = 2 And (PictureBoxF6.BackColor = Color.Red Or PictureBoxF6.BackColor = Color.Blue) And (PictureBoxF5.BackColor = Color.Red Or PictureBoxF5.BackColor = Color.Blue) And (PictureBoxF4.BackColor = Color.Red Or PictureBoxF4.BackColor = Color.Blue) And (PictureBoxF3.BackColor = Color.Red Or PictureBoxF3.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "F" And CoordNumber = 1 And (PictureBoxF6.BackColor = Color.Red Or PictureBoxF6.BackColor = Color.Blue) And (PictureBoxF5.BackColor = Color.Red Or PictureBoxF5.BackColor = Color.Blue) And (PictureBoxF4.BackColor = Color.Red Or PictureBoxF4.BackColor = Color.Blue) And (PictureBoxF3.BackColor = Color.Red Or PictureBoxF3.BackColor = Color.Blue) And (PictureBoxF2.BackColor = Color.Red Or PictureBoxF2.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "G" And CoordNumber = 5 And (PictureBoxG6.BackColor = Color.Red Or PictureBoxG6.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "G" And CoordNumber = 4 And (PictureBoxG6.BackColor = Color.Red Or PictureBoxG6.BackColor = Color.Blue) And (PictureBoxG5.BackColor = Color.Red Or PictureBoxG5.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "G" And CoordNumber = 3 And (PictureBoxG6.BackColor = Color.Red Or PictureBoxG6.BackColor = Color.Blue) And (PictureBoxG5.BackColor = Color.Red Or PictureBoxG5.BackColor = Color.Blue) And (PictureBoxG4.BackColor = Color.Red Or PictureBoxG4.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "G" And CoordNumber = 2 And (PictureBoxG6.BackColor = Color.Red Or PictureBoxG6.BackColor = Color.Blue) And (PictureBoxG5.BackColor = Color.Red Or PictureBoxG5.BackColor = Color.Blue) And (PictureBoxG4.BackColor = Color.Red Or PictureBoxG4.BackColor = Color.Blue) And (PictureBoxG3.BackColor = Color.Red Or PictureBoxG3.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

                ElseIf CoordLetter = "G" And CoordNumber = 1 And (PictureBoxG6.BackColor = Color.Red Or PictureBoxG6.BackColor = Color.Blue) And (PictureBoxG5.BackColor = Color.Red Or PictureBoxG5.BackColor = Color.Blue) And (PictureBoxG4.BackColor = Color.Red Or PictureBoxG4.BackColor = Color.Blue) And (PictureBoxG3.BackColor = Color.Red Or PictureBoxG3.BackColor = Color.Blue) And (PictureBoxG2.BackColor = Color.Red Or PictureBoxG2.BackColor = Color.Blue) Then
                    PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)


                End If

            ElseIf CoordLetter = "A" And PictureBoxA6.BackColor = Color.White Then
                PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

            ElseIf CoordLetter = "B" And PictureBoxB6.BackColor = Color.White Then
                PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

            ElseIf CoordLetter = "C" And PictureBoxC6.BackColor = Color.White Then
                PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

            ElseIf CoordLetter = "D" And PictureBoxD6.BackColor = Color.White Then
                PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

            ElseIf CoordLetter = "E" And PictureBoxE6.BackColor = Color.White Then
                PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

            ElseIf CoordLetter = "F" And PictureBoxF6.BackColor = Color.White Then
                PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

            ElseIf CoordLetter = "G" And PictureBoxG6.BackColor = Color.White Then
                PlaceCounter(CoordNumber, CoordLetter, PlayerTurn)

            End If
        End If
        WinCondition()
    End Sub

    Function PlaceCounter(ByRef CoordNumber As String, ByRef CoordLetter As String, ByRef PlayerTurn As Integer)

        If CoordLetter = "A" And PlayerTurn = 1 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxA1.Name, 12) Then
                        PictureBoxA1.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxA2.Name, 12) Then
                        PictureBoxA2.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxA3.Name, 12) Then
                        PictureBoxA3.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxA4.Name, 12) Then
                        PictureBoxA4.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxA5.Name, 12) Then
                        PictureBoxA5.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxA6.Name, 12) Then
                        PictureBoxA6.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                End If
            Next

        ElseIf CoordLetter = "A" And PlayerTurn = 2 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxA1.Name, 12) Then
                        PictureBoxA1.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxA2.Name, 12) Then
                        PictureBoxA2.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxA3.Name, 12) Then
                        PictureBoxA3.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxA4.Name, 12) Then
                        PictureBoxA4.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxA5.Name, 12) Then
                        PictureBoxA5.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxA6.Name, 12) Then
                        PictureBoxA6.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                End If
            Next

        End If

        If CoordLetter = "B" And PlayerTurn = 1 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxB1.Name, 12) Then
                        PictureBoxB1.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxB2.Name, 12) Then
                        PictureBoxB2.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxB3.Name, 12) Then
                        PictureBoxB3.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxB4.Name, 12) Then
                        PictureBoxB4.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxB5.Name, 12) Then
                        PictureBoxB5.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxB6.Name, 12) Then
                        PictureBoxB6.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                End If
            Next

        ElseIf CoordLetter = "B" And PlayerTurn = 2 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxB1.Name, 12) Then
                        PictureBoxB1.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxB2.Name, 12) Then
                        PictureBoxB2.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxB3.Name, 12) Then
                        PictureBoxB3.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxB4.Name, 12) Then
                        PictureBoxB4.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxB5.Name, 12) Then
                        PictureBoxB5.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxB6.Name, 12) Then
                        PictureBoxB6.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                End If
            Next

        End If

        If CoordLetter = "C" And PlayerTurn = 1 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxC1.Name, 12) Then
                        PictureBoxC1.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxC2.Name, 12) Then
                        PictureBoxC2.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxC3.Name, 12) Then
                        PictureBoxC3.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxC4.Name, 12) Then
                        PictureBoxC4.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxC5.Name, 12) Then
                        PictureBoxC5.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxC6.Name, 12) Then
                        PictureBoxC6.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                End If
            Next

        ElseIf CoordLetter = "C" And PlayerTurn = 2 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxC1.Name, 12) Then
                        PictureBoxC1.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxC2.Name, 12) Then
                        PictureBoxC2.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxC3.Name, 12) Then
                        PictureBoxC3.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxC4.Name, 12) Then
                        PictureBoxC4.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxC5.Name, 12) Then
                        PictureBoxC5.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxC6.Name, 12) Then
                        PictureBoxC6.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                End If
            Next

        End If

        If CoordLetter = "D" And PlayerTurn = 1 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxD1.Name, 12) Then
                        PictureBoxD1.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxD2.Name, 12) Then
                        PictureBoxD2.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxD3.Name, 12) Then
                        PictureBoxD3.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxD4.Name, 12) Then
                        PictureBoxD4.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxD5.Name, 12) Then
                        PictureBoxD5.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxD6.Name, 12) Then
                        PictureBoxD6.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                End If
            Next

        ElseIf CoordLetter = "D" And PlayerTurn = 2 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxD1.Name, 12) Then
                        PictureBoxD1.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxD2.Name, 12) Then
                        PictureBoxD2.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxD3.Name, 12) Then
                        PictureBoxD3.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxD4.Name, 12) Then
                        PictureBoxD4.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxD5.Name, 12) Then
                        PictureBoxD5.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxD6.Name, 12) Then
                        PictureBoxD6.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                End If
            Next

        End If

        If CoordLetter = "E" And PlayerTurn = 1 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxE1.Name, 12) Then
                        PictureBoxE1.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxE2.Name, 12) Then
                        PictureBoxE2.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxE3.Name, 12) Then
                        PictureBoxE3.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxE4.Name, 12) Then
                        PictureBoxE4.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxE5.Name, 12) Then
                        PictureBoxE5.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxE6.Name, 12) Then
                        PictureBoxE6.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                End If
            Next

        ElseIf CoordLetter = "E" And PlayerTurn = 2 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxE1.Name, 12) Then
                        PictureBoxE1.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxE2.Name, 12) Then
                        PictureBoxE2.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxE3.Name, 12) Then
                        PictureBoxE3.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxE4.Name, 12) Then
                        PictureBoxE4.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxE5.Name, 12) Then
                        PictureBoxE5.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxE6.Name, 12) Then
                        PictureBoxE6.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                End If
            Next

        End If

        If CoordLetter = "F" And PlayerTurn = 1 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxF1.Name, 12) Then
                        PictureBoxF1.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxF2.Name, 12) Then
                        PictureBoxF2.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxF3.Name, 12) Then
                        PictureBoxF3.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxF4.Name, 12) Then
                        PictureBoxF4.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxF5.Name, 12) Then
                        PictureBoxF5.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxF6.Name, 12) Then
                        PictureBoxF6.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                End If
            Next

        ElseIf CoordLetter = "F" And PlayerTurn = 2 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxF1.Name, 12) Then
                        PictureBoxF1.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxF2.Name, 12) Then
                        PictureBoxF2.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxF3.Name, 12) Then
                        PictureBoxF3.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxF4.Name, 12) Then
                        PictureBoxF4.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxF5.Name, 12) Then
                        PictureBoxF5.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxF6.Name, 12) Then
                        PictureBoxF6.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                End If
            Next

        End If

        If CoordLetter = "G" And PlayerTurn = 1 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxG1.Name, 12) Then
                        PictureBoxG1.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxG2.Name, 12) Then
                        PictureBoxG2.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxG3.Name, 12) Then
                        PictureBoxG3.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxG4.Name, 12) Then
                        PictureBoxG4.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxG5.Name, 12) Then
                        PictureBoxG5.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                    If i = Mid(PictureBoxG6.Name, 12) Then
                        PictureBoxG6.BackColor = Color.Blue
                        PlayerTurn = 2
                    End If
                End If
            Next

        ElseIf CoordLetter = "G" And PlayerTurn = 2 Then

            For i = 1 To 9
                If CoordNumber = i Then
                    If i = Mid(PictureBoxG1.Name, 12) Then
                        PictureBoxG1.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxG2.Name, 12) Then
                        PictureBoxG2.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxG3.Name, 12) Then
                        PictureBoxG3.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxG4.Name, 12) Then
                        PictureBoxG4.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxG5.Name, 12) Then
                        PictureBoxG5.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                    If i = Mid(PictureBoxG6.Name, 12) Then
                        PictureBoxG6.BackColor = Color.Red
                        PlayerTurn = 1
                    End If
                End If
            Next

        End If

    End Function

    Function WinCondition()
        If PictureBoxA6.BackColor = Color.Red And PictureBoxB6.BackColor = Color.Red And PictureBoxC6.BackColor = Color.Red And PictureBoxD6.BackColor = Color.Red Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxA6.BackColor = Color.Blue And PictureBoxB6.BackColor = Color.Blue And PictureBoxC6.BackColor = Color.Blue And PictureBoxD6.BackColor = Color.Blue Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxA6.BackColor = Color.Red And PictureBoxA5.BackColor = Color.Red And PictureBoxA4.BackColor = Color.Red And PictureBoxA3.BackColor = Color.Red Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxA6.BackColor = Color.Blue And PictureBoxA5.BackColor = Color.Blue And PictureBoxA4.BackColor = Color.Blue And PictureBoxA3.BackColor = Color.Blue Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxA6.BackColor = Color.Red And PictureBoxB5.BackColor = Color.Red And PictureBoxC4.BackColor = Color.Red And PictureBoxD3.BackColor = Color.Red Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxA6.BackColor = Color.Blue And PictureBoxB5.BackColor = Color.Blue And PictureBoxC4.BackColor = Color.Blue And PictureBoxD3.BackColor = Color.Blue Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxB6.BackColor = Color.Red And PictureBoxC6.BackColor = Color.Red And PictureBoxD6.BackColor = Color.Red And PictureBoxE6.BackColor = Color.Red Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxB6.BackColor = Color.Blue And PictureBoxC6.BackColor = Color.Blue And PictureBoxD6.BackColor = Color.Blue And PictureBoxE6.BackColor = Color.Blue Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxC6.BackColor = Color.Red And PictureBoxD6.BackColor = Color.Red And PictureBoxE6.BackColor = Color.Red And PictureBoxF6.BackColor = Color.Red Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxC6.BackColor = Color.Blue And PictureBoxD6.BackColor = Color.Blue And PictureBoxE6.BackColor = Color.Blue And PictureBoxF6.BackColor = Color.Blue Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxD6.BackColor = Color.Red And PictureBoxE6.BackColor = Color.Red And PictureBoxF6.BackColor = Color.Red And PictureBoxG6.BackColor = Color.Red Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxD6.BackColor = Color.Blue And PictureBoxE6.BackColor = Color.Blue And PictureBoxF6.BackColor = Color.Blue And PictureBoxG6.BackColor = Color.Blue Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxA5.BackColor = Color.Red And PictureBoxB5.BackColor = Color.Red And PictureBoxC5.BackColor = Color.Red And PictureBoxD5.BackColor = Color.Red Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxA5.BackColor = Color.Blue And PictureBoxB5.BackColor = Color.Blue And PictureBoxC5.BackColor = Color.Blue And PictureBoxD5.BackColor = Color.Blue Then
            WinCondition = True
            MessageBox.Show("We have a winner!")

        ElseIf PictureBoxB5.BackColor = Color.Red And PictureBoxC5.BackColor = Color.Red And PictureBoxD5.BackColor = Color.Red And PictureBoxE5.BackColor = Color.Red Then
            WinCondition = True
            MessageBox.Show("We have a winner!")
        Else

            WinCondition = False

        End If

    End Function

End Class
