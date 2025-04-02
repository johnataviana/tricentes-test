# Projeto de Testes Automatizados com Selenium e NUnit

Este projeto tem como objetivo automatizar os testes de uma aplicação utilizando Selenium WebDriver e NUnit, em um ambiente .NET 7.0. O projeto é estruturado para realizar testes de automação no contexto de um sistema de simulação de dados de veículos, onde diferentes campos e opções de uma página web são preenchidos e validados.

## Dependências

Este projeto utiliza as seguintes dependências de pacotes NuGet:

- **Microsoft.NET.Test.Sdk** (Versão 17.13.0): Framework de testes utilizado no .NET.
- **NUnit** (Versão 3.13.3): Framework de testes utilizado.
- **NUnit3TestAdapter** (Versão 5.0.0): Adaptador do NUnit para execução de testes.
- **NUnit.Analyzers** (Versão 3.6.1): Ferramenta para analisar o código de testes.
- **coverlet.collector** (Versão 3.2.0): Ferramenta para coleta de cobertura de código durante os testes.
- **Selenium.Support** (Versão 4.30.0): Biblioteca de suporte para facilitar o uso do Selenium WebDriver.
- **Selenium.WebDriver** (Versão 4.30.0): Biblioteca principal do Selenium WebDriver para automação de navegação na web.

### Como instalar as dependências

Para instalar as dependências necessárias, você pode usar o **NuGet** no terminal ou no **Visual Studio**. Veja os comandos para instalação via terminal:

### Como instalar as dependências

Para instalar as dependências necessárias, você pode usar o **NuGet** no terminal ou no **Visual Studio**. Veja os comandos para instalação via terminal:

1. **Instalar Selenium.WebDriver**:
   ```bash
   dotnet add package Selenium.WebDriver --version 4.30.0
   ```
2. **Instalar Selenium.Support**:
   ```bash
   dotnet add package Selenium.WebDriver --version 4.30.0
   ```
3. **Instalar NUnit3TestAdapter**:
   ```bash
   dotnet add package Selenium.WebDriver --version 4.30.0
   ```
3. **Instalar Microsoft.NET.Test.Sdk**:
   ```bash
   dotnet add package Selenium.WebDriver --version 4.30.0
   ```

## Execução dos Testes

Para executar os testes, utilize os seguintes comandos no terminal:

1. **Restaurar pacotes NuGet**:
   ```bash
   dotnet restore
   ```

2. **Executar os testes**:
    ```bash
    dotnet test
    ```