Imports System
Imports System.Text

Namespace Base64convert.Example
    Public Class Base64Sample
        Public Shared Sub Main()
            Dim strB64Encoded As String = "SXQncyBsdW5jaCB0aW1l"
            Dim data As Byte() = Convert.FromBase64String(strB64Encoded)
            Dim strB64Decoded As String = UTF8Encoding.GetString(data)
            Console.WriteLine(strB64Decoded)

            Dim strB64Decoded As String = "It's lunch time"
            Dim data As Byte() = UTF8Encoding.GetBytes(strB64Decoded)
            ' convert the byte array to a Base64 string
            Dim strB64Encoded As String = Convert.ToBase64String(data)
            Console.WriteLine(strB64Encoded)
        End Sub
    End Class
End Namespace