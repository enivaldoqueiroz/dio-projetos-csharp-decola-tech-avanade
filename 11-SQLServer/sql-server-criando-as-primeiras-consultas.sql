-- SQL SERVER - Criando as primeiras consultas

--select * from sys.tables

use Ecommerce
create table Teste
(
	Descricao varchar(50) null,
	Complemento char(30) not null
)

/* Orienta��es
int
bigint
varchar
*/

insert Teste values('a', 'a')
select * from Teste

