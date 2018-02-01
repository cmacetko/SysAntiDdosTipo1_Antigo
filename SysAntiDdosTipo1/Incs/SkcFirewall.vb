Imports NetFwTypeLib
Imports System.Net

Public Class SkcFirewall

    Private _policy As INetFwPolicy2 = Nothing

    ' Declara o Form de Origem
    Private Principal As Principal

    ' Ação ao Iniciar a Class
    Sub New(ByVal LPrincipal As Principal)

        Principal = LPrincipal

    End Sub

    Private ReadOnly Property Policy As INetFwPolicy2

        Get

            If _policy Is Nothing Then
                _policy = DirectCast(Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2")), INetFwPolicy2)
            End If

            Return _policy

        End Get

    End Property

    Public Sub Add(ipAddress As IPAddress, ruleName As String)

        Dim firewallRule As NetFwTypeLib.INetFwRule = Policy.Rules.Item(ruleName)
        Dim NewAddress As String = ipAddress.ToString & "/255.255.255.255"

        If Not firewallRule.RemoteAddresses.Contains(NewAddress) Then
            firewallRule.RemoteAddresses += "," & NewAddress
        End If

    End Sub

    Public Sub Remove(ipAddress As IPAddress, ruleName As String)
        Dim firewallRule As NetFwTypeLib.INetFwRule = Policy.Rules.Item(ruleName)
        Dim NewAddress As String = ipAddress.ToString & "/255.255.255.255"
        If firewallRule.RemoteAddresses.Contains(NewAddress) Then
            Dim ipList As String = firewallRule.RemoteAddresses
            ipList = ipList.Replace(NewAddress, "")
            ipList = ipList.Replace(",,", ",")
            firewallRule.RemoteAddresses = ipList
        End If
    End Sub

    Public Function Exists(ipAddress As IPAddress, ruleName As String) As Boolean

        Dim firewallRule As NetFwTypeLib.INetFwRule = Policy.Rules.Item(ruleName)
        Dim NewAddress As String = ipAddress.ToString & "/255.255.255.255"

        If firewallRule.RemoteAddresses.Contains(NewAddress) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function IsAddressValid(ByVal addrString As String) As Boolean

        Dim address As IPAddress = Nothing

        Return IPAddress.TryParse(addrString, address)

    End Function

    Public Function IsValidIPAddress(ByVal strIPAddress As String) As Boolean

        On Error GoTo Handler

        Dim varAddress As Object, n As Long, lCount As Long

        varAddress = Split(strIPAddress, ".", , vbTextCompare)

        If IsArray(varAddress) Then

            For n = LBound(varAddress) To UBound(varAddress)
                lCount = lCount + 1
                varAddress(n) = CByte(varAddress(n))
            Next

            IsValidIPAddress = (lCount = 4)

        End If

Handler:

    End Function

End Class
