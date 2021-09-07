# Teste automatizados utilizando Selenium

O projeto é feito em Selenium com Cucumber.

## Pré-requisitos

Inicie o Selenium Server.

> `$ webdriver-manager update` <br/>
> `$ webdriver-manager start`

Você pode executar no Test Explorer da sua IDE escolhida ou via command line.

## Command Line

Build.

> `$ dotnet build`

Executar todos os testes.

> `$ dotnet test`

Executar apenas um teste.

> `$ dotnet test --filter "FullyQualifiedName~(ParteUnicaDoNomeDoCenario)"`

## Referências

* Site a ser testado: [Sauce Demo](https://www.saucedemo.com/)
