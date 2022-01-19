--SQL Server: Boas práticas em bancos relacionais
-------------------------------------------------------------
-------------------------------------------------------------

--O funcionamento de um banco de dados - Parte 1
--O funcionamento de um banco de dados - Parte 2

CREATE TABLE PRODUTOS 
(
	CODIGO			INT			NOT NULL,
	DESCRICAO		VARCHAR(50) NOT NULL,
	DATA_VALIDADE	DATETIME,
	EAN				VARCHAR(15) NOT NULL,
	IND_INATIVO		INT			NOT NULL DEFAULT 0
)
;

ALTER TABLE PROSUTOS
	ADD CONSTRAINT PK_PRODUTOS
		PRIMARY KEY (CODIGO)
;

--Como criar índices e realizar inserts
CREATE INDEX IDX01_PRODUTOS
			ON PRODUTOS(EAN)
;

INSERT INTO PRODUTOS VALUES (1, 'Nome do Produto', GETDATE(), '9780201379', 0);

--Realizando inserts em campos específicos

INSERT INTO PRODUTOS (CODIGO, DESCRICAO, EAN) VALUES (2, 'Nome do Produto 2', '1234567890');

SELECT * FROM PRODUTOS;

SELECT * 
  FROM PRODUTOS
 WHERE CODIGO = 2;

---- Consulta não indexada
SELECT * 
  FROM PRODUTOS
 WHERE DESCRICAO LIKE '%Produto'; --Trazer qualquer coisa que termine com Produto

 SELECT * 
  FROM PRODUTOS
 WHERE DESCRICAO LIKE '%Produto%'; --Trazer Produto em qualquer parte do texto


--Implementando funcionalidades

 SELECT COUNT(*) AS TOTAL
   FROM PRODUTOS


--Criando a tabela ESTOQUE
CREATE TABLE LOJA
(
	CODIGO			INT			NOT NULL,
	NOME			VARCHAR(50)	NOT NULL,
	IND_INATIVO		INT			NOT NULL DEFAULT 0,
	CONSTRAINT LOJA_PK PRIMARY KEY (CODIGO)
);

INSERT INTO LOJA (CODIGO, NOME) VALUES (1000, 'Filial Nova Ceara');

CREATE TABLE ESTOQUE
(
	
);

-------------------------------------------------------------
-------------------------------------------------------------