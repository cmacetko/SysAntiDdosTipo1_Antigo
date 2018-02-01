Module Geral

    Sub ShowMsgError(ByVal ex As Exception)

        Log("ERRO", "Message: " & ex.Message & " / HelpLink: " & ex.HelpLink & " / Source: " & ex.Source & " / StackTrace: " & ex.StackTrace & " / TargetSite: " & ex.TargetSite.ToString())

        If My.Settings.IsDebug = True Then

            MsgBox("Message: " & ex.Message & " / HelpLink: " & ex.HelpLink & " / Source: " & ex.Source & " / StackTrace: " & ex.StackTrace & " / TargetSite: " & ex.TargetSite.ToString())

        End If
      
    End Sub

    Sub Log(ByVal Tipo As String, ByVal Mensagem As String)

        Try

            Dim file As System.IO.StreamWriter

            file = My.Computer.FileSystem.OpenTextFileWriter(System.AppDomain.CurrentDomain.BaseDirectory & My.Settings.ArqLog, True)
            file.WriteLine(Date.Now.ToString & ": " & Tipo & " - " & Mensagem)
            file.Close()

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    Sub LogDet(ByVal Mensagem As String)

        Try

            Dim file As System.IO.StreamWriter

            file = My.Computer.FileSystem.OpenTextFileWriter(System.AppDomain.CurrentDomain.BaseDirectory & My.Settings.ArqLogDet, True)
            file.WriteLine(Date.Now.ToString & ": " & Mensagem)
            file.Close()

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    Function RemoveBreakLine(ByVal ex As String)

        RemoveBreakLine = ex.Replace(vbCr, "").Replace(vbLf, "")

    End Function

End Module
