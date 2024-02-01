# 🌐 SalesWebMvc - Desenvolvimento de Aplicações Web com ASP.NET Core MVC e Entity Framework 🌐 

<br>
<br>

![GitHub repo size](https://img.shields.io/github/repo-size/Daviafonso88/SalesWebMvc)
![GitHub language count](https://img.shields.io/github/languages/count/Daviafonso88/SalesWebMvc)
![GitHub forks](https://img.shields.io/github/forks/Daviafonso88/SalesWebMvc)
![Bitbucket open issues](https://img.shields.io/bitbucket/issues/Daviafonso88/SalesWebMvc)
![Bitbucket open pull requests](https://img.shields.io/bitbucket/pr-raw/Daviafonso88/SalesWebMvc)





## 🧠 Visão Geral

> Bem-vindo ao repositório do projeto SalesWebMvc! Este projeto é uma aplicação web desenvolvida utilizando o ASP.NET Core MVC e o Entity Framework. Aqui, você encontrará informações detalhadas sobre o projeto, seus fundamentos e instruções para começar a explorar e contribuir.

<div>
 <details>
    <summary>Visão Geral Completa:</summary>

> Esse projeto em ASP.NET Core MVC segue um padrão de rota "Controller / Ação / Id" e utiliza templates naturais, blocos C# em páginas Razor, dicionário ViewData e Tag Helpers. Ele emprega IActionResult, um tipo de construtor de método que inclui diferentes resultados, como ViewResult, PartialViewResult, ContentResult, RedirectResult, RedirectToRouteResult, JsonResult, FileResult, HttpNotFoundResult e EmptyResult.

> O projeto começa com a criação de um modelo, controle e visualização para a entidade "Department", seguindo os passos de criação de pastas, classes e controllers. O scaffolding é utilizado para gerar operações CRUD básicas usando Entity Framework Core e MySQL, incluindo a adaptação do banco de dados com a criação de migrações.

> A mudança de tema é realizada utilizando o Bootswatch para personalização do layout com diferentes estilos Bootstrap. Outras entidades são adicionadas ao modelo de domínio, e uma segunda migração é criada.

> Um serviço de seeding é implementado para popular o banco de dados com dados iniciais. Em seguida, um controlador para a entidade "Seller" é criado, juntamente com a implementação de um serviço e uma view.

> Formulários de criação e edição são desenvolvidos, incluindo a manipulação de chaves estrangeiras. Um ViewModel é introduzido para lidar com a seleção de departamentos.

> A exclusão de vendedores, detalhes de vendedores e carregamento antecipado de dados são implementados. A atualização de vendedores e exceções personalizadas também são tratadas, incluindo uma página de erro personalizada.

> A localização, formatação de números e datas, e validações são aplicadas no projeto. Operações assíncronas usando Tasks (async, await) são introduzidas, e o tratamento de exceções para exclusão com integridade referencial é implementado.

> Por fim, são preparadas as visualizações de navegação para pesquisa de vendas, com implementações de pesquisa simples e agrupamento.

> Este resumo abrange desde a criação inicial do projeto até a implementação de recursos avançados, seguindo boas práticas de desenvolvimento em ASP.NET Core MVC.

</div>


<br>

## 💻 Sobre o Projeto

O SalesWebMvc é uma aplicação web construída para fornecer uma experiência prática de desenvolvimento com ASP.NET Core MVC e o Entity Framework. Abaixo estão os principais pontos do projeto:

**ASP.NET Core MVC e Entity Framework**:

- Desenvolvido com base no ASP.NET Core MVC para facilitar a construção de aplicações web modernas.
- Utilização do Entity Framework para operações de banco de dados, proporcionando um mapeamento objeto-relacional eficiente.
  
**Fundamentos do Framework**:

- Foco na introdução e prática dos fundamentos do ASP.NET Core MVC, permitindo que desenvolvedores aprendam e aprimorem suas habilidades.
  
**Open Source e Suporte da Comunidade**:

- Criado pela Microsoft e mantido pela comunidade de desenvolvedores.
- Licença de código aberto, possibilitando flexibilidade e colaboração.
  
**Compatibilidade**:

- Funciona tanto no ambiente .NET Framework quanto no .NET Core, oferecendo versatilidade na escolha da plataforma.
  
**Estrutura Bem Definida**:

- Organizado com Controllers, Views, Models e View Models para uma estrutura clara e fácil manutenção.
  
**Banco de Dados MySQL**:

- Utilização do banco de dados MySQL para armazenamento de dados, garantindo robustez e escalabilidade.

<br>

 ## 📝 Estrutura do Projeto

A estrutura do projeto segue as melhores práticas de desenvolvimento, proporcionando uma organização clara e eficiente. Principais pastas e arquivos:

**Controllers**:

- Contém os controladores responsáveis por orquestrar o fluxo da aplicação e manipular requisições HTTP.
  
**Views**:

- Armazena as views, responsáveis pela apresentação de dados aos usuários.

**Models**:

- Representa a camada de dados da aplicação, definindo as entidades do banco de dados.

**View Models**:

- Contém modelos específicos para as views, promovendo uma separação eficiente de responsabilidades.
<br>

## 🔎 Início Rápido

 **1**. Requisitos:
- Instale o .NET SDK em sua máquina. Instruções disponíveis em `dotnet.microsoft.com`.
- Configure um servidor MySQL ou utilize um serviço de banco de dados MySQL.
  
 **2**. Configuração do Banco de Dados:
- Configure as informações de conexão com o MySQL no arquivo de configuração do projeto.
  
 **3**. Executando o Projeto:
- Abra um terminal na raiz do projeto e execute **dotnet run**.
  
 **4**. Acesso à Aplicação:
- Abra um navegador e acesse **http://localhost:5000** para interagir com a aplicação.

<br>

## 🙏 Contribuindo

Contribuições são bem-vindas! Se deseja contribuir para o projeto, siga as práticas recomendadas de desenvolvimento e teste suas alterações de forma adequada.

**1**. Fork o repositório e clone-o para sua máquina local.

**2**. Crie uma branch para suas alterações: `git checkout -b feature/nova-feature`.

**3**. Faça as alterações desejadas e teste-as localmente.

**4**. Certifique-se de seguir as diretrizes de estilo de código.

**5**. Envie um pull request para revisão.

<br>

## 🤝 Colaborador

<table>
  <tr>
    <td align="center">
      <a href="#">
         <img src="https://avatars.githubusercontent.com/u/89953265?v=4" width="100px;" alt="Foto de Davi Afonso no GitHub"/><br>
        <sub>
          <b>Davi Afonso</b>
        </sub>
      </a>
    </td>
</table>

<br>

 ```Divirta-se desenvolvendo!``` 
