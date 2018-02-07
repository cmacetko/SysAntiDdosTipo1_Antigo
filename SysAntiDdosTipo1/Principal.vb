Imports System
Imports System.Text
Imports System.Globalization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Web.Script.Serialization
Imports System.Net
Imports System.IO
Imports System.Web

Public Class Principal

    Public IPsIgnorar As String()

    Public SckInit As SckInit = New SckInit(Me)
    Public SckSites As SckSites = New SckSites(Me)
    Public FrmGrids As FrmGrids = New FrmGrids(Me)
    Public SckFormUtil As SckFormUtil = New SckFormUtil(Me)

    Public SkcFirewall As SkcFirewall = New SkcFirewall(Me)
    Public SkcSlack As SkcSlack = New SkcSlack(Me)

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Carrega os IPs a Ignorar
        IPsIgnorar = Split(My.Settings.IPsIgnorar, ",")
       
        ' Delay de Controle
        TimerSckWorkerProcesses.Interval = My.Settings.DelayChecagem * 1000
        TimerFrmWorkerProcesses.Interval = My.Settings.DelayChecagem * 1000

        ' Carrega os dados inicias
        SckSites.Acao_CarregarWorkerProcesses()

        ' Monta o Grid
        FrmGrids.Acao_CarregarWorkerProcesses()
        FrmGrids.Acao_CarregarIPs()
        FrmGrids.Acao_CarregarIPsBloqueados()

        ' Inicia o sistema
        SckInit.AcTmReal_Ativar()

    End Sub

    Private Sub TimerSckWorkerProcesses_Tick(sender As Object, e As EventArgs) Handles TimerSckWorkerProcesses.Tick

        SckSites.Acao_CarregarWorkerProcesses()

    End Sub

    Private Sub TimerFrmWorkerProcesses_Tick(sender As Object, e As EventArgs) Handles TimerFrmWorkerProcesses.Tick

        FrmGrids.Acao_CarregarWorkerProcesses()
        FrmGrids.Acao_CarregarIPs()
        FrmGrids.Acao_CarregarIPsBloqueados()

    End Sub


    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click

        SckInit.AcTmReal_Ativar()

    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click

        SckInit.AcTmReal_Desativar()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Sobre.ShowDialog()

    End Sub

End Class
