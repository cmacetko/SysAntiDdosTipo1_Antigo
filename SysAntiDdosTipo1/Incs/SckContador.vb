Public Class SckFormUtil

    ' Declara o Form de Origem
    Private Principal As Principal

    ' Ação ao Iniciar a Class
    Sub New(ByVal LPrincipal As Principal)

        Principal = LPrincipal

    End Sub

    ' Contagem de WorkerProcesses
    Public Sub ContadorWorkerProcesses()

        Try

            Principal.LblQtdWorkerProcess.Text = Principal.SckSites.ListWorkerProcesses.Count.ToString()

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Contagem de IPs
    Public Sub ContadorIPs()

        Try

            Principal.LblQtdIPs.Text = Principal.SckSites.ListIps.Count.ToString()

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

End Class
