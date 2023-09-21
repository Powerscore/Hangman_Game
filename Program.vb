Module Module1

    Sub Main()
        Dim PlayAgain As String = "yes"

        While LCase(PlayAgain) = "yes"

            'Declarations
            Const Hangman As String = "Hangman"
            Dim State As String = ""
            Dim Word As String
            Dim EndGame As Boolean = False
            Dim Correct As Boolean = False
            Dim Chance As Integer = 0
            Word = RandomWord()
            Dim Attempt As Char
            Dim Space As String = ""
            Dim Position As Integer


            'Initialize number of spaces
            For i = 1 To Len(Word)
                Space += "-"
            Next i



            Console.WriteLine("The Word is : " & Space)
            While EndGame = False

                Console.WriteLine("Guess the Word! (Enter one letter)")
                Attempt = Console.ReadLine()

                'Search for entered letter
                For i = 1 To Len(Word)
                    If LCase(Attempt) = LCase(Mid(Word, i, 1)) Then
                        Mid(Space, i, 1) = Attempt
                        Correct = True
                        Position = i
                    End If
                Next i

                'Suitable measures if attempt correct or wrong 

                If Correct = False Then
                    Chance += 1
                    State = Mid(Hangman, 1, Chance)
                    Console.WriteLine("Wrong attempt!")
                    Console.WriteLine("The Word is : " & Space)
                    Console.WriteLine("Current state: " & State)
                    If State = Hangman Then
                        EndGame = True

                    End If
                Else
                    Console.WriteLine("WELL DONE!")
                    Console.WriteLine("The Word is : " & Space)
                End If
                If Space = Word Then
                    EndGame = True
                End If
                Correct = False
            End While

            'Final message

            If State = Hangman Then
                Console.WriteLine("You lost!")
                Console.WriteLine("The Word is " & Word)
            Else
                Console.WriteLine("You won!")
                Console.WriteLine("The Word is " & Word)
            End If


            Console.WriteLine("Game Over")
            Console.WriteLine()
            Console.WriteLine("Do you want to play again?")
            PlayAgain = Console.ReadLine()
        End While

        Console.ReadLine()
    End Sub

    'Random word generator
    Function RandomWord() As String
        Dim Word(21) As String
        Dim i As Integer


        Word(0) = "abruptly"
        Word(1) = "foxglove"
        Word(3) = "lengths"
        Word(5) = "subway"
        Word(8) = "absurd"
        Word(9) = "frazzled"
        Word(10) = "lucky"
        Word(11) = "swivel"
        Word(12) = "abyss"
        Word(13) = "frizzled"
        Word(14) = "luxury"
        Word(15) = "syndrome"
        Word(16) = "affix"
        Word(17) = "fuchsia"
        Word(18) = "lymph"
        Word(19) = "thriftless"
        Word(20) = "askew"

        Dim rd As New Random
        i = rd.Next(0, 20)


        Return Word(i)
    End Function
End Module
