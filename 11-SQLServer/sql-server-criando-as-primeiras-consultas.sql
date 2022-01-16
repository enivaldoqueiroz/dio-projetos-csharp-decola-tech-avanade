-- SQL SERVER - Criando as primeiras consultas

--select * from sys.tables

------------------------------------------------------------------------
--Conceitos iniciais de criação de tabelas

use Ecommerce
create table Teste
(
	Descricao varchar(50) null,
	Complemento char(30) not null
)

/* Orientações
int
bigint
varchar
*/

--insert Teste values('a', 'a')

--insert Teste values(null, 'a')

--select * from Teste

--drop table Teste
------------------------------------------------------------------------
--Criando as tabelas para o curso

use Ecommerce
create table Produtos
(
	Codigo int,
	Nome varchar(100),
	Descricao varchar(200),
	Preco float
)

select * from Produtos


-- Criação da tabela cliente com Management Studio
-- Path => Ecommerce -> Tabelas -> Nova -> Tabale... "Salvar para criar a tabela"

-- Script de criação da tabela cliente
-- Path => Ecommerce -> Tabelas -> dbo.Clientes -> Script de Tabela como -> CREATE Para

USE [Ecommerce]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 16/01/2022 19:18:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[Codigo] [int] NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[TipoPessoa] [char](1) NOT NULL
) ON [PRIMARY]
GO

Create table Pedido
(
	Codigo int not null,
	DataSolicitacao datetime not null,
	FlagPago bit not null,
	TotalPedido float not null,
	CodigoCliente int
)

Create table PedidoItem
(
	CodigoPedido int not null,
	CodigoProduto int not null,
	Preco float not null,
	Quantidade int not null
)

------------------------------------------------------------------------
--Comando Insert, Select, Update, Delete

select * from Clientes

insert into Clientes(codigo, nome, tipoPessoa) values (1, 'Mila', 'F');
insert Clientes(codigo, nome, tipoPessoa) values (2, 'Lana', 'F');
insert Clientes(tipoPessoa, codigo, nome) values ('F', 3, 'Enivaldo');
insert Clientes values (4, 'Bernardo', 'F');
insert Clientes values (5, 'Rivia', 'F'), (6,'Maia','J');

-- Selecionar
select *
from Clientes
where TipoPessoa = 'J'

--Editar
update Clientes
set Codigo = 7,
    Nome = 'Jose'
where TipoPessoa = 'J'

--Deletar
delete 
from Clientes
where Codigo in (5,4,3)

/*

AND

V AND V = V
V AND F = F
F AND V = F
F AND F = F

OR

V OR V = V
V OR F = V
F OR V = V
F OR F = F
*/
--Exemplo: 

select *
from Clientes
where Codigo = 1 
OR TipoPessoa = 'J'
