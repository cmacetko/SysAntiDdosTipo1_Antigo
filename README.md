# SysAntiDdosTipo1

Aplicação criada para monitorar a quantidade de portas abertas por um IP, permitindo que o IP seja bloqueado no firewall do windows e um alerta seja enviado ao Slack.


# Requisitos


- https://www.microsoft.com/pt-br/download/details.aspx?id=30653
- Regra nomeada de "**FrRule**" no firewall do windows (*Podes alterar o nome da regra através das configurações da aplicação na propriedae "**FirewallRule**"*)
- DLL: **Newtonsoft.Json.dll** (*Disponível em "DLL/Newtonsoft.Json.dll"*)

# Testando

Basta abrir o aplicativo compilado em "**SysAntiDdosTipo1/bin/Release/SysAntiDdosTipo1.exe**"

# Configurações

Através do arquivo "**SysAntiDdosTipo1/bin/Release/SysAntiDdosTipo1.exe.config**"

### FrRule

Indica o nome da regra, do firewall do windows, responsável por receber os IPs que serão bloqueados automátiacment

### ArqLog

Arquivo que ira armazenar um log resumido 

### ArqLogDet

Arquivo que ira armazenar um log detalhado

### DelayChecagem

Tempo, em segundos, para cada checagem de Portas abertas

### IsDebug

Indica que será exibido um alerta em caso de falhas

## LimitePorIP

Quantidade de portas limite por IP

### SlackIs

Indica que deve enviar um alerta ao seu Slack

### SlackToken

Token do Stack para receber os alertas, podem ser gerados em:
https://api.slack.com/custom-integrations/legacy-tokens

### ServerNome

Nome do servidor que será monitorado, será includo nos alertas ao Slack

### IPsIgnorar

Ips que devem ser ignorados do bloqueio automático

### BloqueioIs

Indica que os IPs serão bloqueados automáticamente no firewall do windows

# Imagens da Aplicação

![enter image description here](https://image.ibb.co/mAghDm/2018_02_01_13h30_22.png)

![enter image description here](https://preview.ibb.co/nxW4R6/2018_02_01_13h30_52.png)

