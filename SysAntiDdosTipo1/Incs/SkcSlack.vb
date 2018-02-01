Imports System
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Web

Public Class SkcSlack

    ' Declara o Form de Origem
    Private Principal As Principal

    ' Ação ao Iniciar a Class
    Sub New(ByVal LPrincipal As Principal)

        Principal = LPrincipal

    End Sub

    ' Enviar Mensagem
    Public Sub Acao_ChatPostMessage(ByVal DadChannel As String, ByVal DadText As String, ByVal DadUsername As String, Optional ByVal DadAttachments As String = "")

        Try

            If My.Settings.SlackIs = True Then

                Dim TmpMensagem As New Dictionary(Of String, String)
                TmpMensagem.Add("token", My.Settings.SlackToken)
                TmpMensagem.Add("channel", DadChannel)
                TmpMensagem.Add("text", DadText)
                TmpMensagem.Add("username", DadUsername)

                If DadAttachments <> "" Then
                    TmpMensagem.Add("attachments", DadAttachments)
                End If

                Dim TmpMensagemStr As String = ""

                For Each TmpMensagemEle As KeyValuePair(Of String, String) In TmpMensagem
                    TmpMensagemStr += TmpMensagemEle.Key + "=" + HttpUtility.UrlEncode(TmpMensagemEle.Value) + "&"
                Next

                TmpMensagemStr = TmpMensagemStr.TrimEnd("&")

                Dim request As WebRequest = WebRequest.Create("https://slack.com/api/chat.postMessage")

                request.Method = "POST"

                Dim byteArray As Byte() = Encoding.UTF8.GetBytes(TmpMensagemStr)

                request.ContentType = "application/x-www-form-urlencoded"

                request.ContentLength = byteArray.Length

                Dim dataStream As Stream = request.GetRequestStream()

                dataStream.Write(byteArray, 0, byteArray.Length)

                dataStream.Close()

                Dim response As WebResponse = request.GetResponse()

                response.Close()

            End If

        Catch ep As Exception

            '-

        End Try

    End Sub

End Class
