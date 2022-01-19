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

INSERT INTO PRODUTOS VALUES (1, 'Nome do Produto', GETDATE(), '9780201379', 0)


-------------------------------------------------------------
-------------------------------------------------------------