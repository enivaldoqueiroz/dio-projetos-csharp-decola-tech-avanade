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

-- Criação da tabela Naves e a Pilotos

CREATE TABLE Naves
(
	IdNave		INT				NOT NULL,
	Nome		VARCHAR(100)	NOT NULL,
	Passageiros INT				NOT NULL,
	Carga		FLOAT			NOT NULL,
	Classe		VARCHAR(100)	NOT NULL
)
GO
ALTER TABLE Naves 
	ADD CONSTRAINT PK_Naves 
	PRIMARY KEY (IdNave);

CREATE TABLE Pilotos
(
	IdPiloto INT NOT NULL,
	Nome VARCHAR(200) NOT NULL,
	AnoNascimento VARCHAR(20) NOT NULL,
	IdPlaneta INT NOT NULL
)
GO
ALTER TABLE Pilotos ADD CONSTRAINT PK_Pilotos PRIMARY KEY (IdPiloto)
GO
ALTER TABLE Pilotos ADD CONSTRAINT FK_Pilotos_Planetas FOREIGN KEY (IdPlaneta)
REFERENCES Planetas (IdPlaneta)

CREATE PilotosNaves
(
	IdPiloto		INT NOT NULL,
	IdNave			INT NOT NULL,
	FlagAutorizado	BIT NOT NULL
)
GO
ALTER TABLE PilotoNaves ADD CONSTRAINT PK_PilotosNaves PRIMARY KEY (IdPiloto, IdNave)
GO
ALTER TABLE PilotosNaves ADD CONSTRAINT FK_PilotosNaves FOREIGN KEY (IdPiloto)
REFERENCES Pilotos (IdPiloto)
GO
ALTER TABLE PilotosNaves ADD CONSTRAINT FK_PilotosNaves FOREIGN KEY (IdNave)
REFERENCES Naves (IdNave)
GO
ALTER TABLE PilotosNaves ADD CONSTRAINT DF_PilotosNaves_FlagAutorizado DEFAULT (1) FOR FlagAutorizado

CREATE TABLE HistoricoViagens
(
	IdNave		INT			NOT NULL,
	IdPiloto	INT			NOT NULL,
	DataSaida	DATETIME	NOT NULL,
	DataChegada DATETIME	NULL
)
GO
ALTER TABLE HistoiricoViagens ADD CONSTRAINT FK_HistoricoViagens_PilotosNaves FOREIGN KEY (IdPiloto)
REFERENCES PilotosNaves (IdPiloto, IdNave)
GO
ALTER TABLE HistoricoViagens CHECK CONSTRAINT FK_HistoricoViagens_PilotosNaves