### Busca Cep e guarda pesquisas em Histórico

##### Para rodar o projeto só é necesário abrir a solução no Visual Studio e marcar a camada "App" como projeto de inicialização

A UI foi desenvolvida com Web Phormes, a integração com serviço de Cep foi feito utilizando ClientHttp do NetFramework, para deserializar o Json fiz uso do newtonSoft via Nuget e para guardar histórico de pesquisas foi usado um bando de dados.

- para que o histórico funcione é necesário criar um banco de dados com a seguinte estrutura:
 
CREATE TABLE [dbo].[enderecos] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Cep]      NCHAR (10)    NULL,
    [Endereco] VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


- Você pode substituir a string de conexão que eu usei, alterando-a no arquivo web.config



![Example](https://github.com/Lipe1994/BuscaCepComWebPhorms/blob/master/example1.png)


![Example](https://github.com/Lipe1994/BuscaCepComWebPhorms/blob/master/example2.PNG)


![Example](https://github.com/Lipe1994/BuscaCepComWebPhorms/blob/master/example-3.PNG)

