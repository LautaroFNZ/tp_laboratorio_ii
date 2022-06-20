CREATE DATABASE [FernandezLautarotp4]
GO
USE [FernandezLautarotp4]
GO
CREATE TABLE [FernandezLautarotp4].dbo.Clientes
(
	NumeroCliente INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(30) NOT NULL,
	Apellido VARCHAR(30) NOT NULL,
	Documento INT NOT NULL,
	TipoPlan INT NOT NULL,
)
GO

INSERT INTO Clientes VALUES ('Lionel','Scaloni',29900139,1004)
INSERT INTO Clientes VALUES ('Julian','Alvarez',39872123,1000)
INSERT INTO Clientes VALUES ('Marcelo','Gallardo',20180912,1004)
INSERT INTO Clientes VALUES ('Lionel','Messi',25645823,1003)
INSERT INTO Clientes VALUES ('Gonzalo','Montiel',35912018,1002)
INSERT INTO Clientes VALUES ('Emiliano','Martinez',28909010,1002)
INSERT INTO Clientes VALUES ('Walter','Erviti',28091872,1001)
INSERT INTO Clientes VALUES ('Javier','Zanetti',26762435,1002)
INSERT INTO Clientes VALUES ('Claudio','Caniggia',19972134,1003)
INSERT INTO Clientes VALUES ('Gabriela','Sabattini',21983472,1003)
INSERT INTO Clientes VALUES ('Marcela','Morelo',18765423,1002)
INSERT INTO Clientes VALUES ('Emilia','Mernes',38945602,1002)
INSERT INTO Clientes VALUES ('Gloria','Estefan',16919999,1002)
INSERT INTO Clientes VALUES ('Carmen','Barbieri',12345678,1002)
INSERT INTO Clientes VALUES ('Mariana','Esposito',35098156,1001)

