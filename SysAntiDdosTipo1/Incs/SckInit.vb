Public Class SckInit

    ' Declara o Form de Origem
    Private Principal As Principal

    ' Ação ao Iniciar a Class
    Sub New(ByVal LPrincipal As Principal)

        Principal = LPrincipal

    End Sub

    ' Acoes em Tempo - Ativar
    Public Sub AcTmReal_Ativar()

        Principal.TimerSckWorkerProcesses.Enabled = True
        Principal.TimerFrmWorkerProcesses.Enabled = True
        Principal.TimerClnWorkerProcesses.Enabled = True

        Principal.BtnPlay.Enabled = False
        Principal.BtnStop.Enabled = True

    End Sub

    ' Acoes em Tempo - Desativar
    Public Sub AcTmReal_Desativar()

        Principal.TimerSckWorkerProcesses.Enabled = False
        Principal.TimerFrmWorkerProcesses.Enabled = False
        Principal.TimerClnWorkerProcesses.Enabled = False

        Principal.BtnPlay.Enabled = True
        Principal.BtnStop.Enabled = False

    End Sub

End Class
