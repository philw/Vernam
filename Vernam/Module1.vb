Module Module1

    Sub Main()

        Dim Key As String
        Dim PlainText As String
        Dim CipherText As String


        Key = CreateOneTimePad(30)
        Console.WriteLine("Key is: " & Key)
        Console.WriteLine

        Console.Write("Enter plaintext message: ")
        PlainText = Console.ReadLine
        CipherText = VernamEncode(PlainText, Key)
        Console.WriteLine("Cipher text is: " & CipherText)
        Console.WriteLine()

        Console.Write("Enter ciphertext: ")
        CipherText = Console.ReadLine
        PlainText = VernamEncode(CipherText, Key)
        Console.WriteLine("Plaintext message is: " & PlainText)




        Console.ReadLine()

    End Sub

    Function CreateOneTimePad(Length As Integer) As String

        Dim Key As String = ""
        Dim C As Char
        Dim Rnd As New Random

        For N = 1 To Length
            C = Chr(Asc("A") + Rnd.Next(0, 26))
            Key = Key & C
        Next

        Return Key

    End Function

    Function VernamEncode(InputText As String, Key As String) As String
        Dim OutputText As String = ""
        Dim C As Char

        For N = 0 To InputText.Length - 1
            C = Chr(Asc(InputText(N)) Xor Asc(Key(N)))
            OutputText = OutputText & C

        Next



        Return OutputText

    End Function

End Module
