Imports System.IO
Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Module VyhledavacARES
    Const ARES_API_URL As String = "https://ares.gov.cz/ekonomicke-subjekty-v-be/rest/ekonomicke-subjekty/"
    Const BEARER_TOKEN As String = "604208743"

    Public Async Function VyhledejIcoAsync(ico As String) As Task(Of String)
        Try
            ' Volání funkce pro získání informací o subjektu
            Dim result As String = Await GetARESInfoAsync(ico).ConfigureAwait(False)

            ' Zpracování výsledku
            Dim formattedResult As String = FormatARESInfo(result)

            ' Uložení do txt souboru
            ' File.WriteAllText("ICO_output.txt", formattedResult)

            ' Vrátí string
            Return formattedResult
        Catch ex As Exception
            ' Ošetření chyby a zobrazení odpovídající zprávy
            ' MessageBox.Show($"Chyba při vyhledávání IČO: {ex.Message}")
        End Try
    End Function

    Async Function GetARESInfoAsync(ico As String) As Task(Of String)
        Using httpClient As New HttpClient()
            ' Sestavení URL dotazu
            Dim queryUrl As String = $"{ARES_API_URL}{ico}"

            ' Přidání hlaviček pro autentizaci
            httpClient.DefaultRequestHeaders.Add("accept", "application/json")
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {BEARER_TOKEN}")

            ' Odeslání GET dotazu na ARES API
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(queryUrl)

            ' Zpracování odpovědi
            If response.IsSuccessStatusCode Then
                Dim result As String = Await response.Content.ReadAsStringAsync()
                Return result
            Else
                Return $"Chyba při komunikaci s ARES API. Kód chyby: {response.StatusCode}"
            End If
        End Using
    End Function

    Function FormatARESInfo(result As String) As String
        ' Zpracování JSON odpovědi
        Dim jsonObject As JObject = JObject.Parse(result)

        ' Extrahování požadovaných informací
        Dim obchodniJmeno As String = jsonObject("obchodniJmeno").ToString()
        Dim nazevCastiObce As String = jsonObject("sidlo")("nazevCastiObce").ToString()
        Dim cisloDomovni As Integer = jsonObject("sidlo")("cisloDomovni").ToObject(Of Integer)()
        Dim psc As Integer = jsonObject("sidlo")("psc").ToObject(Of Integer)()
        Dim nazevObce As String = jsonObject("sidlo")("nazevObce").ToString()
        Dim dic As String = jsonObject("dic").ToString()

        ' Vytvoření formátovaného řetězce
        Dim formattedResult As String = $"{obchodniJmeno};{nazevCastiObce} {cisloDomovni};{psc};{nazevObce};{dic}"

        Return formattedResult
    End Function

End Module