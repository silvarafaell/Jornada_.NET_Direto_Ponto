### Jornada .NET Direto ao Ponto com o LuisDev
# Aula 1: O mercado de programação com .NET e suas oportunidades (nacionais e internacionais)

![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula1/aula1.png?raw=true "Aula 1")

# Aula 2: Fundamentos de C# e Programação Orientada a Objetos
Comandos utilizados: 
- dotnet new console -o DevTrackR.Console
- dotnet run
- dotnet new gitignore

![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula2/o%20que%20%C3%A9%20c%23%20net.png?raw=true "C#")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula2/tiposDados.png?raw=true "TipoDados")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula2/estruturas%20de%20controle%20de%20fluxo.png?raw=true "controlefluxo")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula2/Listas%20e%20LINQ.png?raw=true "LINQ")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula2/Lista%20e%20LINQ1.png?raw=true "LINQ")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula2/Encapsulamento.png?raw=true "Encapsulamento")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula2/heranca.png?raw=true "Heranca")

# Aula 3: REST API, HTTP e Injeção de Dependência com .NET 6
Comandos utilizados: 
- dotnet new webapi
- dotnet build
- dotnet new gitignore
- dotnet run

![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula3/AspNet%20Core.png?raw=true "AspNetCore")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula3/Controllers%20e%20Actions.png?raw=true "ControllerActions")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula3/HTTP%20e%20REst%20APIs1.png?raw=true "HTTP REST APIs1")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula3/HTTP%20e%20Rest%20APIs.png?raw=true "HTTP REST APIs")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula3/Injecao%20de%20Dependencia.png?raw=true "InjecaoDependencia")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula3/Injecao%20de%20Dependencia1.png?raw=true "InjecaoDependencia1")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula3/Swagger.png?raw=true "Swagger")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula3/API%20Rodando.png?raw=true "API Rodando")

# Aula 4: Acesso a banco de dados SQL Server com Entity Framework Core e Padrão Repository
Pacotes Instalados
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.InMemory

Comandos
- dotnet tool install --global dotnet-ef
- dotnet user-secrets init (gerou = f325f19d-b66d-40ec-a89c-9d54a639d3e6)
- Mesmo comando  > dotnet user-secrets set "ConnectionStrings:DevTrackRCs" "Server=DESKTOP-EGDDQI4\SQLEXPRESS; Database=Delivery; User Id=sa; Password=1234"(tiando necessidade de colocar ConnctionStrings no appSettings)
- dotnet ef migrations add InitialMigration -o Persistence/Migrations
- dotnet ef database update

![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula4/Porque%20C%23%20e%20.NET.png?raw=true "Porque C#")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula4/Entity%20Framwwork%20Core.png?raw=true "EntityFrameworkcore")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula4/Entity%20Framwwork%20Core1.png?raw=true "EntityFrameworkcore1")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula4/Entity%20Framwwork%20Core2.png?raw=true "EntityFrameworkcore2")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula4/Entity%20Framwwork%20Core3.png?raw=true "EntityFrameworkcore3")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula4/Entity%20Framwwork%20Core4.png?raw=true "EntityFrameworkcore4")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula4/Entity%20Framwwork%20Core5.png?raw=true "EntityFrameworkcore5")
![Alt text](https://github.com/silvarafaell/Jornada_.NET_Direto_Ponto/blob/main/images/aula4/Padrao%20Repository.png?raw=true "Padrao Repository")

# Aula 5: Swagger, Envio de E-mails e Publicação na Azure
Pacotes Instalados
- SendGrid
- SendGrid.Extensions.DependencyInjection
