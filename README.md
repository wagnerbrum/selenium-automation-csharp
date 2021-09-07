# Executando Testes
Requerimentos - Inicie o Selenium Server.

> `$ webdriver-manager update`<br/>
> `$ webdriver-manager start`

Você pode executar no Test Explorer da sua IDE escolhida ou via command line.

## Command Line
Build.
> `$ dotnet build`

Executar todos os testes.
> `$ dotnet test`

Executar apenas um teste.
> `$ dotnet test --filter "FullyQualifiedName~(ParteUnicaDoNomeDoCenario)"`