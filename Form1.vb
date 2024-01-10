Public Class Form1
    Private ico As String = ""
    Private vysledek As String = ""

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        ' Ošetření délky IČO na 8 číslic
        ico = TextBox1.Text.PadLeft(8, "0"c)
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Zkontrolovat, zda je TextBox prázdný nebo obsahuje neplatné číslo
        If Not String.IsNullOrEmpty(ico) AndAlso Integer.TryParse(ico, Nothing) Then
            vysledek = Await VyhledavacARES.VyhledejIcoAsync(ico)

            ' Zobrazit výsledek pro kontrolu
            ' MessageBox.Show(vysledek)
        Else
            ' Zobrazit chybové hlášení
            ' MessageBox.Show("Prosím zadejte platné číslo IČO.")
        End If
    End Sub
End Class
