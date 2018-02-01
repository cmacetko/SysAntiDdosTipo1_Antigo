<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblQtdWorkerProcess = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LblQtdIPs = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblUltimaAtualizacao = New System.Windows.Forms.Label()
        Me.TimerSckWorkerProcesses = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFrmWorkerProcesses = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DGridIPs = New System.Windows.Forms.DataGridView()
        Me.DGridIPs_IP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridIPs_QtdOcorrencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DGridWorkerProcesses = New System.Windows.Forms.DataGridView()
        Me.DGridWorkerProcesses_LocalEndPoint_Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_LocalEndPoint_Port = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_RemoteEndPoint_Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_RemoteEndPoint_Port = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGridIPsBloqueados = New System.Windows.Forms.DataGridView()
        Me.DGridIPsBloqueados_IP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimerClnWorkerProcesses = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGridIPs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGridWorkerProcesses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGridIPsBloqueados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(495, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SysAntiDDOS - Tipo1 (Conexões por IPs)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblQtdWorkerProcess)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 55)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Qtd. Conexões"
        '
        'LblQtdWorkerProcess
        '
        Me.LblQtdWorkerProcess.AutoSize = True
        Me.LblQtdWorkerProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQtdWorkerProcess.ForeColor = System.Drawing.Color.DarkRed
        Me.LblQtdWorkerProcess.Location = New System.Drawing.Point(7, 20)
        Me.LblQtdWorkerProcess.Name = "LblQtdWorkerProcess"
        Me.LblQtdWorkerProcess.Size = New System.Drawing.Size(25, 25)
        Me.LblQtdWorkerProcess.TabIndex = 0
        Me.LblQtdWorkerProcess.Text = "0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblQtdIPs)
        Me.GroupBox4.Location = New System.Drawing.Point(187, 57)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(164, 55)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Qtd. IPs "
        '
        'LblQtdIPs
        '
        Me.LblQtdIPs.AutoSize = True
        Me.LblQtdIPs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQtdIPs.ForeColor = System.Drawing.Color.DarkRed
        Me.LblQtdIPs.Location = New System.Drawing.Point(7, 20)
        Me.LblQtdIPs.Name = "LblQtdIPs"
        Me.LblQtdIPs.Size = New System.Drawing.Size(25, 25)
        Me.LblQtdIPs.TabIndex = 0
        Me.LblQtdIPs.Text = "0"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LblUltimaAtualizacao)
        Me.GroupBox5.Location = New System.Drawing.Point(357, 57)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(599, 55)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Última Checagem"
        '
        'LblUltimaAtualizacao
        '
        Me.LblUltimaAtualizacao.AutoSize = True
        Me.LblUltimaAtualizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUltimaAtualizacao.ForeColor = System.Drawing.Color.DarkRed
        Me.LblUltimaAtualizacao.Location = New System.Drawing.Point(7, 20)
        Me.LblUltimaAtualizacao.Name = "LblUltimaAtualizacao"
        Me.LblUltimaAtualizacao.Size = New System.Drawing.Size(20, 25)
        Me.LblUltimaAtualizacao.TabIndex = 0
        Me.LblUltimaAtualizacao.Text = "-"
        '
        'TimerSckWorkerProcesses
        '
        Me.TimerSckWorkerProcesses.Interval = 120000
        '
        'TimerFrmWorkerProcesses
        '
        Me.TimerFrmWorkerProcesses.Interval = 60000
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DGridIPs)
        Me.GroupBox6.Location = New System.Drawing.Point(970, 57)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(296, 498)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "IPs Ativos"
        '
        'DGridIPs
        '
        Me.DGridIPs.AllowUserToAddRows = False
        Me.DGridIPs.AllowUserToDeleteRows = False
        Me.DGridIPs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridIPs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGridIPs_IP, Me.DGridIPs_QtdOcorrencias})
        Me.DGridIPs.Location = New System.Drawing.Point(7, 20)
        Me.DGridIPs.Name = "DGridIPs"
        Me.DGridIPs.ReadOnly = True
        Me.DGridIPs.Size = New System.Drawing.Size(283, 472)
        Me.DGridIPs.TabIndex = 0
        '
        'DGridIPs_IP
        '
        Me.DGridIPs_IP.HeaderText = "IP"
        Me.DGridIPs_IP.Name = "DGridIPs_IP"
        Me.DGridIPs_IP.ReadOnly = True
        Me.DGridIPs_IP.Width = 140
        '
        'DGridIPs_QtdOcorrencias
        '
        Me.DGridIPs_QtdOcorrencias.HeaderText = "Ocorrências"
        Me.DGridIPs_QtdOcorrencias.Name = "DGridIPs_QtdOcorrencias"
        Me.DGridIPs_QtdOcorrencias.ReadOnly = True
        '
        'BtnPlay
        '
        Me.BtnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlay.Location = New System.Drawing.Point(977, 9)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(77, 42)
        Me.BtnPlay.TabIndex = 7
        Me.BtnPlay.Text = "Play"
        Me.BtnPlay.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Enabled = False
        Me.BtnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStop.Location = New System.Drawing.Point(1060, 9)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(77, 42)
        Me.BtnStop.TabIndex = 8
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DGridWorkerProcesses)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(939, 411)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "WorkerProcesses"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DGridWorkerProcesses
        '
        Me.DGridWorkerProcesses.AllowUserToAddRows = False
        Me.DGridWorkerProcesses.AllowUserToDeleteRows = False
        Me.DGridWorkerProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridWorkerProcesses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGridWorkerProcesses_LocalEndPoint_Address, Me.DGridWorkerProcesses_LocalEndPoint_Port, Me.DGridWorkerProcesses_RemoteEndPoint_Address, Me.DGridWorkerProcesses_RemoteEndPoint_Port, Me.DGridWorkerProcesses_State})
        Me.DGridWorkerProcesses.Location = New System.Drawing.Point(3, 3)
        Me.DGridWorkerProcesses.Name = "DGridWorkerProcesses"
        Me.DGridWorkerProcesses.ReadOnly = True
        Me.DGridWorkerProcesses.Size = New System.Drawing.Size(932, 404)
        Me.DGridWorkerProcesses.TabIndex = 2
        '
        'DGridWorkerProcesses_LocalEndPoint_Address
        '
        Me.DGridWorkerProcesses_LocalEndPoint_Address.Frozen = True
        Me.DGridWorkerProcesses_LocalEndPoint_Address.HeaderText = "LocalEndPoint / Address"
        Me.DGridWorkerProcesses_LocalEndPoint_Address.Name = "DGridWorkerProcesses_LocalEndPoint_Address"
        Me.DGridWorkerProcesses_LocalEndPoint_Address.ReadOnly = True
        Me.DGridWorkerProcesses_LocalEndPoint_Address.Width = 200
        '
        'DGridWorkerProcesses_LocalEndPoint_Port
        '
        Me.DGridWorkerProcesses_LocalEndPoint_Port.Frozen = True
        Me.DGridWorkerProcesses_LocalEndPoint_Port.HeaderText = "LocalEndPoint / Port"
        Me.DGridWorkerProcesses_LocalEndPoint_Port.Name = "DGridWorkerProcesses_LocalEndPoint_Port"
        Me.DGridWorkerProcesses_LocalEndPoint_Port.ReadOnly = True
        Me.DGridWorkerProcesses_LocalEndPoint_Port.Width = 150
        '
        'DGridWorkerProcesses_RemoteEndPoint_Address
        '
        Me.DGridWorkerProcesses_RemoteEndPoint_Address.Frozen = True
        Me.DGridWorkerProcesses_RemoteEndPoint_Address.HeaderText = "RemoteEndPoint / Address"
        Me.DGridWorkerProcesses_RemoteEndPoint_Address.Name = "DGridWorkerProcesses_RemoteEndPoint_Address"
        Me.DGridWorkerProcesses_RemoteEndPoint_Address.ReadOnly = True
        Me.DGridWorkerProcesses_RemoteEndPoint_Address.Width = 200
        '
        'DGridWorkerProcesses_RemoteEndPoint_Port
        '
        Me.DGridWorkerProcesses_RemoteEndPoint_Port.Frozen = True
        Me.DGridWorkerProcesses_RemoteEndPoint_Port.HeaderText = "RemoteEndPoint / Port"
        Me.DGridWorkerProcesses_RemoteEndPoint_Port.Name = "DGridWorkerProcesses_RemoteEndPoint_Port"
        Me.DGridWorkerProcesses_RemoteEndPoint_Port.ReadOnly = True
        Me.DGridWorkerProcesses_RemoteEndPoint_Port.Width = 150
        '
        'DGridWorkerProcesses_State
        '
        Me.DGridWorkerProcesses_State.HeaderText = "State"
        Me.DGridWorkerProcesses_State.Name = "DGridWorkerProcesses_State"
        Me.DGridWorkerProcesses_State.ReadOnly = True
        Me.DGridWorkerProcesses_State.Width = 150
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(17, 118)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(947, 437)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGridIPsBloqueados)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(939, 411)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "IPs Bloqueados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGridIPsBloqueados
        '
        Me.DGridIPsBloqueados.AllowUserToAddRows = False
        Me.DGridIPsBloqueados.AllowUserToDeleteRows = False
        Me.DGridIPsBloqueados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridIPsBloqueados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGridIPsBloqueados_IP})
        Me.DGridIPsBloqueados.Location = New System.Drawing.Point(8, 6)
        Me.DGridIPsBloqueados.Name = "DGridIPsBloqueados"
        Me.DGridIPsBloqueados.ReadOnly = True
        Me.DGridIPsBloqueados.Size = New System.Drawing.Size(925, 399)
        Me.DGridIPsBloqueados.TabIndex = 1
        '
        'DGridIPsBloqueados_IP
        '
        Me.DGridIPsBloqueados_IP.HeaderText = "IP"
        Me.DGridIPsBloqueados_IP.Name = "DGridIPsBloqueados_IP"
        Me.DGridIPsBloqueados_IP.ReadOnly = True
        Me.DGridIPsBloqueados_IP.Width = 140
        '
        'TimerClnWorkerProcesses
        '
        Me.TimerClnWorkerProcesses.Interval = 60000
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.SysAntiDdosTipo1.My.Resources.Resources.About
        Me.Button1.Location = New System.Drawing.Point(1218, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 565)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.Text = "SysAntiDDOS - Tipo1 (Conexões por IPs)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DGridIPs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DGridWorkerProcesses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DGridIPsBloqueados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblQtdWorkerProcess As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LblQtdIPs As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LblUltimaAtualizacao As System.Windows.Forms.Label
    Friend WithEvents TimerSckWorkerProcesses As System.Windows.Forms.Timer
    Friend WithEvents TimerFrmWorkerProcesses As System.Windows.Forms.Timer
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DGridIPs As System.Windows.Forms.DataGridView
    Friend WithEvents DGridIPs_IP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridIPs_QtdOcorrencias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnPlay As System.Windows.Forms.Button
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DGridWorkerProcesses As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DGridIPsBloqueados As System.Windows.Forms.DataGridView
    Friend WithEvents DGridIPsBloqueados_IP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimerClnWorkerProcesses As System.Windows.Forms.Timer
    Friend WithEvents DGridWorkerProcesses_LocalEndPoint_Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_LocalEndPoint_Port As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_RemoteEndPoint_Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_RemoteEndPoint_Port As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
