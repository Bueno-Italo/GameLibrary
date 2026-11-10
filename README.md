# 🎮 GameLibrary

**GameLibrary** é uma API REST desenvolvida em C# com ASP.NET Core para gerenciamento de jogos e plataformas de jogos.

O projeto tem como objetivo aplicar conceitos de desenvolvimento backend, arquitetura limpa (Clean Architecture), operações CRUD, persistência de dados e boas práticas de desenvolvimento.

## 🚀 Tecnologias utilizadas

- **C#**
- **.NET 10**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **PostgreSQL**
- **Npgsql**
- **Swagger / OpenAPI**
- **Git e GitHub**

## 📌 Funcionalidades

### Plataformas
- Cadastrar plataformas.
- Listar todas as plataformas.
- Buscar plataforma por ID.
- Atualizar plataformas existentes.
- Excluir plataformas.
- Impedir a exclusão de plataformas que possuem jogos vinculados.

### Jogos
- Cadastrar jogos.
- Listar todos os jogos.
- Buscar jogo por ID.
- Atualizar jogos existentes.
- Excluir jogos.
- Associar jogos às respectivas plataformas.

### Validações e regras de negócio
- Validação dos dados recebidos pela API.
- Verificação de existência de registros antes de determinadas operações.
- Controle de relacionamento entre jogos e plataformas.
- Restrição de exclusão de plataformas com jogos associados.

## 🧱 Arquitetura

O projeto utiliza **Clean Architecture**, organizado em quatro projetos, com responsabilidades separadas:

```text
GameLibrary
│
├── GameLibrary.Domain
│   ├── Entities
│   └── Enums
│
├── GameLibrary.Application
│   ├── Interfaces
│   ├── Services
│   └── Enums
│
├── GameLibrary.Infrastructure
│   ├── Data
│   ├── Configurations
│   └── Repositories
│
└── GameLibrary.API
    ├── Controllers
    └── Program.cs
```

### Responsabilidades das camadas

- **Domain:** contém as entidades e os conceitos centrais do negócio.
- **Application:** concentra os serviços, contratos e regras de aplicação.
- **Infrastructure:** responsável pelo acesso ao banco de dados, Entity Framework Core, configurações de entidades e implementação dos repositórios.
- **API:** responsável por expor os endpoints HTTP e receber as requisições dos clientes.

## 💾 Banco de Dados

O projeto utiliza **PostgreSQL** como banco de dados relacional, com integração realizada através do Entity Framework Core e do provedor Npgsql.

O relacionamento entre as entidades é estruturado da seguinte forma:

- Uma plataforma pode possuir vários jogos.
- Cada jogo está associado a uma plataforma através de `PlatformId`.
- A exclusão de uma plataforma é restringida enquanto existirem jogos vinculados.

As configurações de mapeamento das entidades são centralizadas utilizando `IEntityTypeConfiguration`.

## 🔌 Endpoints

A API disponibiliza operações CRUD para as entidades Games e Platforms.

| Método HTTP | Operação |
|---|---|
| GET | Listar registros |
| GET | Buscar registro por ID |
| POST | Cadastrar registro |
| PUT | Atualizar registro |
| DELETE | Excluir registro |

Os endpoints podem ser consultados e testados através do Swagger.

## 🛠️ Como executar o projeto

### Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Visual Studio](https://visualstudio.microsoft.com/) ou outra IDE compatível com .NET.

### Configuração

1. Clone o repositório:

```bash
git clone https://github.com/Bueno-Italo/GameLibrary.git
```

2. Acesse a pasta do projeto:

```bash
cd GameLibrary
```

3. Configure a string de conexão do PostgreSQL para o ambiente local.

4. Aplique as migrations do Entity Framework Core para criar ou atualizar a estrutura do banco de dados.

5. Execute o projeto `GameLibrary.API`.

6. Acesse o Swagger para visualizar e testar os endpoints disponibilizados pela API.

## 🎯 Objetivos de aprendizado

Este projeto faz parte da minha jornada de desenvolvimento com C# e tem como objetivos:

- Aprofundar os conhecimentos em desenvolvimento backend com .NET.
- Compreender e aplicar os princípios da Clean Architecture.
- Trabalhar com APIs REST e operações CRUD.
- Utilizar Entity Framework Core para persistência de dados.
- Desenvolver relacionamentos entre entidades.
- Aplicar validações e regras de negócio.
- Praticar versionamento, branches e integração de código com Git e GitHub.

## 👨‍💻 Autor

**Italo Bueno**

[GitHub - Bueno-Italo](https://github.com/Bueno-Italo)
