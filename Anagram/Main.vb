Public Class Main
    Private anagram As Anagram = New Anagram

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim list = anagram.GetAnagrams(txtWord.Text)
        If list.Count <> 0 Then
            txtAnagram.Text = list.Aggregate(Function(s1, s2) s1 & vbNewLine & s2)
        Else
            txtAnagram.Text = "<none>"
        End If
    End Sub
End Class
