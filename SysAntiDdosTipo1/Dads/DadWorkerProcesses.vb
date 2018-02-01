Public Class DadWorkerProcesses

    Public LocalEndPoint_Address As String
    Public LocalEndPoint_Port As String
    Public RemoteEndPoint_Address As String
    Public RemoteEndPoint_Port As String
    Public State As String

    Sub New(ByVal LocalEndPoint_Address As String, ByVal LocalEndPoint_Port As String, ByVal RemoteEndPoint_Address As String, ByVal RemoteEndPoint_Port As String, ByVal State As String)

        Me.LocalEndPoint_Address = LocalEndPoint_Address
        Me.LocalEndPoint_Port = LocalEndPoint_Port
        Me.RemoteEndPoint_Address = RemoteEndPoint_Address
        Me.RemoteEndPoint_Port = RemoteEndPoint_Port
        Me.State = State

    End Sub

End Class
