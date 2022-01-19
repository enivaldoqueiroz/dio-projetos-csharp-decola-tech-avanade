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


select * from Clientes

select * from Produtos

insert Produtos values(1, 'Caneca', 'Caneca Azul', 1.5)
insert Produtos values(2, 'Caderno', 'Caneca 10 Materia', 20.99)

select * from Pedido

insert Pedido values(1, GETDATE(), 0, 3, 7)
insert Pedido values(2, GETDATE(), 0, 22.49, 1)

select * from Pedido
select * from PedidoItem

insert PedidoItem values(1, 1, 1.5, 2)
insert PedidoItem values(2, 1, 1.5, 1)
insert PedidoItem values(2, 2, 20.99, 1)

select *,
		case 
			when TipoPessoa = 'J' then 'Juridica'
			when TipoPessoa = 'F' then 'Fisica'
			else 'Pessoa indefinidada'
		end
from Clientes

select *, CONVERT(varchar, DataSolicitacao, 103)
from Pedido

select * from Clientes

alter table Clientes add constraint pk_cliente primary key (Codigo)

insert Cliente values(1, 'Julio', getdate())

select * from Produtos
select * from PedidoItem

alter table PedidoItem add constraint fk_pedido foreign key (CodigoPedido) references Pedido (Codigo)


select * from Clientes

select * from Telefones

Id CodigoCliente DDD Telefone

update Pedito set codigostatus = 1, descstatus = 'Em andamento'


inner join
left join
right join

select *
from Clientes cli
inner join Pedido ped
on cli.Codigo = ped.CodigoCliente

select *
from Clientes cli
left join Pedido ped
on cli.Codigo = ped.CodigoCliente

select *
from Clientes cli
right join Pedido ped
on cli.Codigo = ped.CodigoCliente

select *
from PedidoItem tl
inner join PedidoItemLog t2
on t1.CodigoPedido = t2.CodigoPedido
and t1.CodigoProduto = t2.CodigoProduto
inner join StatusPedido t3
on t3.Codigo = t2CodigoStatusPedido