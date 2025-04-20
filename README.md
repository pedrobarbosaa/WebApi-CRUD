# 📘 Projeto CRUD Básico - ASP.NET Core (.NET 9) + SQL Server

Este é um projeto simples de uma API REST com operações CRUD (Create, Read, Update, Delete), desenvolvido com **ASP.NET Core (.NET 9)** e **SQL Server**. O Scalar é utilizado para realizar testes nas rotas da API.

## 🔧 Tecnologias Utilizadas

- .NET 9
- ASP.NET Core Web API
- SQL Server
- Entity Framework Core
- Scalar (para testes de rota)
- C#

## 📁 Estrutura do Projeto

- `Controllers/` – Endpoints da API.
- `Models/` – Estruturas de dados.
- `Data/` – Configuração do banco de dados e contexto EF.
- `Migrations/` – Migrações geradas com o EF Core.
- `appsettings.json` – Arquivo de configuração (não incluído no repositório por segurança).

## 🚀 Como Executar o Projeto

1. **Clone o repositório:**

```bash
git clone https://github.com/seu-usuario/seu-projeto.git
cd seu-projeto

Execute as migrações do banco de dados:
dotnet ef database update

Inicie a aplicação:
dotnet run

Verifique no arquivo launchSettings.json em qual porta o projet está rodando:
Ex: https://localhost:7028

Com o projeto em execução, acesse o Scalar no navegador através do endereço abaixo:
Ex: https://localhost:7028/scalar/
