Imports System.IO
Imports System.Text
Imports System.Net

Public Class SckSites

    ' Declara o Form de Origem
    Private Principal As Principal

    ' Declara o Objeto que ira armazenar a listagem de WorkerProcesses
    Public ListWorkerProcesses As New Hashtable()

    ' Declara o Objeto que ira armazenar os ips e suas ocorrencias
    Public ListIps As New Dictionary(Of String, Integer)

    ' Declara o Objeto que ira armazenar os ips bloqueados
    Public ListIpsBloqueados As New Dictionary(Of String, Integer)

    ' Carregao Objeto controlador da placa de rede
    Dim ipProps As System.Net.NetworkInformation.IPGlobalProperties = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties()

    ' Ação ao Iniciar a Class
    Sub New(ByVal LPrincipal As Principal)

        Principal = LPrincipal

    End Sub

    '*************************************
    '* Ações
    '*************************************

    ' Mantem um Hashtable atualizado com os dados dos Processos em Atividade
    Public Sub Acao_CarregarWorkerProcesses()

        Try

            ' Log
            Log("INFO", "Iniciado Checagem")

            ' Limpa o Hashtable de WorkerProcesses
            ListWorkerProcesses.Clear()

            ' Limpa o Dictionary de IPs
            ListIps.Clear()

            ' Variavel temporaria para o ID da Hah
            Dim IDHash As String = ""

            ' Loop nas conexões TCP
            For Each connection As System.Net.NetworkInformation.TcpConnectionInformation In ipProps.GetActiveTcpConnections

                ' Prepara o ID da Hash
                IDHash = connection.RemoteEndPoint.Address.ToString & "_" & connection.RemoteEndPoint.Port

                ' Checar se o item ja foi adicionado
                If Not ListWorkerProcesses.ContainsKey(IDHash) Then

                    ' Adiciona o e-mail ao Hashtable
                    ListWorkerProcesses.Add(IDHash, New DadWorkerProcesses(connection.LocalEndPoint.Address.ToString, connection.LocalEndPoint.Port, connection.RemoteEndPoint.Address.ToString, connection.RemoteEndPoint.Port, connection.State.ToString))

                    ' Checa se o IP esta bloqueado
                    If Not Principal.IPsIgnorar.Contains(connection.RemoteEndPoint.Address.ToString) Then

                        ' Adiciona o IP ao contador
                        Acao_AdicionaIP(connection.RemoteEndPoint.Address.ToString)

                    End If

                End If

            Next

            ' Atualizaa data da última atualização
            Principal.LblUltimaAtualizacao.Text = Date.Now.ToString

            ' Atualiza Contador de WorkerProcesses
            Principal.SckFormUtil.ContadorWorkerProcesses()

            ' Atualiza Contador de IPs
            Principal.SckFormUtil.ContadorIPs()

            ' Controla Bloqueio de IPs
            Acao_CtrlIPsBloqueios()

            ' Log
            Log("INFO", "Finalizado Checagem")

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Cria um contador com a quantidade de ocorrencias de um IP
    Public Sub Acao_AdicionaIP(ByVal IP As String)

        Try

            ' Adiciona o IP no contador
            If ListIps.ContainsKey(IP) Then

                Dim TmpCount As Integer = ListIps.Item(IP) + 1

                ListIps.Item(IP) = TmpCount

            Else

                ListIps.Add(IP, 1)

            End If

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Controla IPs a serem bloqueados
    Public Sub Acao_CtrlIPsBloqueios()

        Try

            ' While na Tabela 
            For Each EleIP As KeyValuePair(Of String, Integer) In Principal.SckSites.ListIps

                Try

                    ' Checa se tem mais ocorrencias neste IP
                    If EleIP.Value >= My.Settings.LimitePorIP Then

                        ' Relatorio de Bloqueios
                        Acao_CtrlIPsBloquear(EleIP.Key, EleIP.Value)

                    End If

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            Next

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Bloqueia IP no Firewall
    Public Sub Acao_CtrlIPsBloquear(ByVal IP As String, ByVal Ocorrencias As Integer)

        ' IP
        Dim IPAddress As IPAddress

        Try

            ' Adiciona o IP no contador
            If Not ListIpsBloqueados.ContainsKey(IP) Then

                ' Adiciona ao Array
                ListIpsBloqueados.Add(IP, 1)

                ' Checa se esta ativo os bloqueios
                If My.Settings.BloqueioIs = True Then

                    ' Log
                    Log("INFO", "Bloqueio de IP: " & IP & " / Ocorrencias: " & Ocorrencias)

                    LogDet("# ##########################")
                    LogDet("# IP: " & IP & " / Ocorrencias: " & Ocorrencias)

                    ' While na Tabela 
                    For Each EleProcesses As DictionaryEntry In Principal.SckSites.ListWorkerProcesses

                        ' Carrega os Dados do Elemento
                        Dim DadProcesses As DadWorkerProcesses = CType(EleProcesses.Value, DadWorkerProcesses)

                        ' Checa se o IP esta sendo bloqueado
                        If DadProcesses.RemoteEndPoint_Address = IP Then

                            ' Log
                            LogDet("| LocalEndPoint / Address: " & DadProcesses.LocalEndPoint_Address)
                            LogDet("| LocalEndPoint / Port: " & DadProcesses.LocalEndPoint_Port)
                            LogDet("| RemoteEndPoint / Address: " & DadProcesses.RemoteEndPoint_Address)
                            LogDet("| RemoteEndPoint / Port: " & DadProcesses.RemoteEndPoint_Port)
                            LogDet("| State: " & DadProcesses.State)
                            LogDet("----------")

                        End If

                    Next

                    ' Bloqueia IP
                    IPAddress = IPAddress.Parse(IP)

                    Principal.SkcFirewall.Add(IPAddress, My.Settings.FirewallRule)

                    ' Envia aviso ao Slack
                    Principal.SkcSlack.Acao_ChatPostMessage("#servidores", "*Anti DDos (Tipo 1)* `IP " & IP & " Bloqueado por " & Ocorrencias & " ocorrencias`", My.Settings.ServerNome)

                End If

            End If

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

End Class
