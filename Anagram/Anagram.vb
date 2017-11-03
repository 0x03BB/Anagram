Imports System.Numerics

Public Class Anagram
    Private Shared primes As Integer() = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101}
    Private Shared words As Dictionary(Of BigInteger, List(Of String)) = New Dictionary(Of BigInteger, List(Of String))

    Public Sub New()
        If words.Count = 0 Then
            Dim path = My.Computer.FileSystem.CurrentDirectory & "\words.txt"
            Using stream = My.Computer.FileSystem.OpenTextFileReader(path)
                While Not stream.EndOfStream
                    Dim word = stream.ReadLine
                    Dim key = WordToKey(word)
                    Dim list As List(Of String) = Nothing
                    If words.TryGetValue(key, list) Then
                        list.Add(word)
                    Else
                        words.Add(key, New List(Of String) From {word})
                    End If
                End While
            End Using
        End If
    End Sub

    Public Function GetAnagrams(word As String) As IReadOnlyList(Of String)
        Dim list As List(Of String) = Nothing
        If words.TryGetValue(WordToKey(word), list) Then
            Return list.AsReadOnly
        Else
            Return (New List(Of String)).AsReadOnly
        End If
    End Function

    Private Shared Function WordToKey(word As String) As BigInteger
        Dim wordPrimes = word.ToLower().Select(Function(c As Char) primes(Asc(c) - 97))

        Dim total As BigInteger = 1
        For Each prime In wordPrimes
            total *= prime
        Next

        Return total
    End Function
End Class
