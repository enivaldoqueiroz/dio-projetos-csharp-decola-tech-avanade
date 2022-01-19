-- Modelando um banco de dados Star Wars na prática com SQL SERVER

--API
https://swapi.dev/api
https://swapi.dev/

--Comando Create Table e criação da primeira tabela Planetas

CREATE TABLE Planetas
(
	IdPlaneta	INT			NOT NULL,
	Nome		VARCHAR(50) NOT NULL,
	Rotacao		FLOAT		NOT NULL,
	Orbita		FLOAT		NOT NULL,
	Diametro	FLOAT		NOT NULL,
	Clima		VARCHAR(50) NOT NULL,
	Populacao	INT			NOT NULL
)

GO
ALTER TABLE Planetas 
	ADD CONSTRAINT PK_Planetas 
	PRIMARY KEY (IdPlaneta);


