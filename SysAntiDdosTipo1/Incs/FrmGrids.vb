Public Class FrmGrids

    ' Declara o Form de Origem
    Private Principal As Principal

    ' Ação ao Iniciar a Class
    Sub New(ByVal LPrincipal As Principal)

        Principal = LPrincipal

    End Sub

    '*************************************
    '* Ações
    '*************************************

    ' Monta o Grid com o Hashtable de WorkerProcesses
    Public Sub Acao_CarregarWorkerProcesses()

        Try

            ' Limpa o Grid
            Principal.DGridWorkerProcesses.Rows.Clear()

            ' While na Tabela 
            For Each EleProcesses As DictionaryEntry In Principal.SckSites.ListWorkerProcesses

                Try

                    ' Carrega os Dados do Elemento
                    Dim DadProcesses As DadWorkerProcesses = CType(EleProcesses.Value, DadWorkerProcesses)

                    ' Adiciona os Dados no Grids
                    Principal.DGridWorkerProcesses.Rows.Add(
                                                            DadProcesses.LocalEndPoint_Address,
                                                            DadProcesses.LocalEndPoint_Port,
                                                            DadProcesses.RemoteEndPoint_Address,
                                                            DadProcesses.RemoteEndPoint_Port,
                                                            DadProcesses.State
                                                            )

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            Next

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Monta o Grid com a Listagem de IPs que estão com processos no momento
    Public Sub Acao_CarregarIPs()

        Try

            ' Limpa o Grid
            Principal.DGridIPs.Rows.Clear()

            ' While na Tabela 
            For Each EleIP As KeyValuePair(Of String, Integer) In Principal.SckSites.ListIps

                Try

                    ' Adiciona os Dados no Grids
                    Principal.DGridIPs.Rows.Add(
                                                EleIP.Key,
                                                EleIP.Value
                                                )

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            Next

            ' Ordena Grid
            Principal.DGridIPs.Sort(Principal.DGridIPs.Columns("DGridIPs_QtdOcorrencias"), System.ComponentModel.ListSortDirection.Descending)

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Monta o Grid com a Listagem de IPs Bloqueados
    Public Sub Acao_CarregarIPsBloqueados()

        Try

            ' Limpa o Grid
            Principal.DGridIPsBloqueados.Rows.Clear()

            ' While na Tabela 
            For Each EleIP As KeyValuePair(Of String, Integer) In Principal.SckSites.ListIpsBloqueados

                Try

                    ' Adiciona os Dados no Grids
                    Principal.DGridIPsBloqueados.Rows.Add(
                                                        EleIP.Key
                                                        )

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            Next

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

End Class
