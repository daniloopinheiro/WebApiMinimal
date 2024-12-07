# WebApiMinimal

Este projeto consiste em uma API simples, desenvolvida utilizando **.NET 6**, com uma estrutura baseada em **Domain-Driven Design (DDD)**. Ele visa demonstrar boas práticas de organização de código e arquitetura de sistemas, com foco na separação de responsabilidades e modularidade. A aplicação foi criada para fornecer um modelo base para a construção de APIs escaláveis e de fácil manutenção.

Ao longo do projeto, são aplicados conceitos de DDD, como a organização do código em camadas, o uso de entidades, agregados e repositórios, além de exemplos práticos de como gerenciar dados e realizar operações de CRUD. Com essa estrutura, é possível adicionar facilmente novas funcionalidades, respeitando os princípios de coesão e baixo acoplamento.

---

## Índice

- Visão Geral
- Tecnologias Utilizadas
- Instalação
- Como Usar
- Estrutura de Diretórios
- Configuração
- Contribuições
- Licença
- Contato

---

## Visão Geral

Este projeto oferece uma API simples para demonstrar a aplicação de **Domain-Driven Design (DDD)** com **.NET 6**. Ele foi desenvolvido com foco na separação de responsabilidades e modularidade, facilitando a manutenção e escalabilidade da aplicação. As funcionalidades principais incluem:

- **Cadastro de Entidades**: Funcionalidade para criação e gerenciamento de recursos.
- **Consulta de Dados**: Endpoints para obter informações de entidades.
- **Autenticação e autorização**: Proteção de rotas por meio de autenticação de usuários.

---

## Tecnologias Utilizadas

Este projeto foi desenvolvido com as seguintes tecnologias:

- **.NET 6**: Framework para criação de APIs robustas e performáticas.
- **Entity Framework Core**: ORM para acesso a banco de dados.
- **AutoMapper**: Pacote adicionado na camada **Application** para mapeamento de objetos entre camadas, facilitando a conversão entre modelos de dados e DTOs.
- **Swashbuckle.AspNetCore**: Pacote para gerar automaticamente a documentação Swagger da API, facilitando o entendimento e os testes interativos da API.
- **Swagger**: Para documentação e testes interativos da API.
- **Docker** (opcional): Para facilitar a containerização e o deploy da aplicação.

---

## Instalação

### Pré-requisitos

Certifique-se de que você tem as seguintes ferramentas instaladas em seu ambiente de desenvolvimento:

- **.NET 6 SDK**: [Baixe o .NET 6](https://dotnet.microsoft.com/download/dotnet/6.0)
- **Docker** (opcional): [Baixe o Docker](https://www.docker.com/get-started)

### Passos para Instalar

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/WebApiMinimal.git
   cd WebApiMinimal
   ```

2. Instale as dependências do projeto:

   Se estiver utilizando o Visual Studio ou VS Code, abra a solução e restaure os pacotes.

   Ou, se estiver utilizando a linha de comando, execute:

   ```bash
   dotnet restore
   ```

3. Instale os pacotes adicionais **AutoMapper** e **Swashbuckle.AspNetCore**:

   - Para **AutoMapper**, execute o comando:

     ```bash
     dotnet add package AutoMapper
     ```

   - Para **Swashbuckle.AspNetCore**, execute o comando:

     ```bash
     dotnet add package Swashbuckle.AspNetCore
     ```

4. Configure as variáveis de ambiente ou edite o arquivo `appsettings.json` conforme necessário.

5. Para rodar o projeto localmente, use o seguinte comando:

   ```bash
   dotnet run
   ```

   Ou, se estiver usando containers Docker, execute:

   ```bash
   docker-compose up
   ```

---

## Como Usar

Este projeto pode ser utilizado para interagir com a API de forma simples. Abaixo estão alguns exemplos de uso com **cURL** ou **Postman**:

1. **Cadastro de Entidade**:
   - **Método HTTP**: POST
   - **URL**: /api/entidade
   - **Descrição**: Cria uma nova entidade no sistema.

2. **Consulta de Entidade**:
   - **Método HTTP**: GET
   - **URL**: /api/entidade/{id}
   - **Descrição**: Retorna os detalhes de uma entidade específica.

### Exemplos de uso com cURL ou Postman

**Requisição para cadastrar uma entidade**:

```bash
curl -X POST http://localhost:5000/api/entidade -H "Content-Type: application/json" -d '{"nome": "Entidade Exemplo"}'
```

**Requisição para consultar uma entidade**:

```bash
curl -X GET http://localhost:5000/api/entidade/1 -H "Content-Type: application/json"
```

---

## Estrutura de Diretórios

Este projeto segue a arquitetura **Domain-Driven Design (DDD)** com uma estrutura simples e modular:

```
src/
├── API/                # Camada de apresentação (controladores e endpoints da API)
├── Application/        # Camada de lógica de negócios (serviços, casos de uso)
├── Domain/             # Camada de domínio (entidades, agregados, repositórios)
├── Infrastructure/     # Camada de infraestrutura (implementações concretas, banco de dados)
└── Shared/             # Camada compartilhada (DTOs, helpers, interfaces)

```

### Detalhamento das Camadas:

- **API**: Contém os controladores que expõem os endpoints da API.
- **Application**: Contém os serviços de aplicação, responsáveis pela lógica de negócios.
- **Domain**: Contém as entidades, agregados e interfaces de repositório.
- **Infrastructure**: Implementações concretas como acesso a banco de dados e outros serviços externos.
- **Shared**: Contém classes compartilhadas, como DTOs e utilitários.

---

## Configuração

Este projeto exige algumas configurações adicionais, como variáveis de ambiente ou arquivos de configuração. Abaixo estão as instruções de configuração:

### Configuração do Banco de Dados

1. No arquivo `appsettings.json`, adicione suas configurações de banco de dados, por exemplo:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=webapi_db;Trusted_Connection=True;"
  }
}
```

2. Para configuração de variáveis de ambiente, adicione as seguintes variáveis ao seu ambiente de execução:

```bash
DATABASE_URL=Server=localhost;Database=webapi_db;Trusted_Connection=True;
```

---

## Contribuições

Contribuições são bem-vindas! Para contribuir com o projeto, siga estas etapas:

1. Faça um **fork** do repositório.
2. Crie uma nova branch para sua feature (ex: `git checkout -b feature/nova-feature`).
3. Faça as alterações necessárias e commit (ex: `git commit -m 'Adiciona nova-feature'`).
4. Envie as alterações para seu repositório (ex: `git push origin feature/nova-feature`).
5. Crie um **pull request** para a branch principal do repositório original.

---

## Licença

Este projeto está licenciado sob a Licença **MIT**. Consulte o arquivo LICENSE para mais detalhes.

---

## Contato

- **Email**: contato@dopme.io
- **LinkedIn**: https://www.linkedin.com/in/daniloopinheiro
