Option Strict On

Module Module1

    Sub Main()
        Dim num As Integer = 1

        Do While (num <= 7)

            If (num > 5) Then
                Exit Do
            End If
            Console.WriteLine("" & num)
            num = num + 1
        Loop

    End Sub
    Sub Main()
        Dim password As String = "SHAZAM"

        Do
            password = InputBox("What is the password?")
            password = password.ToUpper
        Loop

    End Sub

End Module
