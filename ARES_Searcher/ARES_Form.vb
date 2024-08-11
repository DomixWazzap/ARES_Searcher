Public Class ARES_Form
    Private ico As String = ""
    Private vysledek As String = ""

    Private Sub ICO_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles ICO_TextBox.KeyUp
        ' Ošetření délky IČO na 8 číslic
        ico = ICO_TextBox.Text.PadLeft(8, "0"c)
    End Sub

    Private Sub ICO_TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        ' Kontrola, zda byla stisknuta klávesa Enter
        If e.KeyCode = Keys.Enter Then
            ' Pokud ano, proveď kliknutí na tlačítko Hledej
            Hledej_Button.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Function IsValidICO(ico As String) As Boolean
        ' Kontrola, zda je IČO číslo a má délku 8 číslic
        Return ico.Length = 8 AndAlso Integer.TryParse(ico, Nothing)
    End Function

    Private Async Sub Hledej_Button_Click(sender As Object, e As EventArgs) Handles Hledej_Button.Click
        If Not String.IsNullOrEmpty(ico) AndAlso IsValidICO(ico) Then
            vysledek = Await VyhledejIcoAsync(ico)
            If Not String.IsNullOrEmpty(vysledek) Then
                ' Rozdělit výsledky a zobrazit je ve formuláři
                Dim parts = vysledek.Split(";"c)
                Vysledek_TextBox.Text = $"{parts(0)}{Environment.NewLine}" &
                                        $"{parts(1)}{Environment.NewLine}" &
                                        $"{parts(2)}{Environment.NewLine}" &
                                        $"{parts(3)}{Environment.NewLine}" &
                                        $"{parts(4)}"
            End If
        Else
            MessageBox.Show("Prosím zadejte platné IČO.")
        End If

    End Sub

End Class