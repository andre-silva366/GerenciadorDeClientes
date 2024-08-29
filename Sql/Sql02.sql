INSERT INTO Servidor (Nome) VALUES ('TV BEM');

USE GerenciamentoClientes;

SELECT * FROM Servidor;

INSERT INTO Aplicativo(Nome) VALUES ('XTV PLUS');

SELECT * FROM Aplicativo;

SELECT * FROM Clientes;	

INSERT INTO Clientes (Nome,Telefone,Email,IdPlano) VALUES ('Andre','(11) 5677-9338','andre@email.com',2);

--INSERT INTO Plano (Descricao,Valor,ValidadeEmMeses,DataProximoPagamento,)

ALTER TABLE Plano DROP CONSTRAINT FK_Plano_Clientes;

ALTER TABLE Plano DROP COlumn IdCliente;

SELECT * FROM Plano;

INSERT INTO Plano (Descricao,Valor,ValidadeEmMeses,DataProximoPagamento,IdAplicativo,IdServidor,
MacOuEmail,DeviceKeyOuSenha) VALUES ('Mensal sem adultos',30,1,'2024-09-24',1,1,0,0);

SELECT * FROM Plano;

ALTER TABLE Clientes DROP COlumn IdPlano;

ALTER TABLE Plano DROP COlumn ValidadeEmMeses;

ALTER TABLE Plano DROP COlumn DeviceKeyOuSenha;

DELETE  fROM Plano;

DELETE FROM Clientes;

ALTER TABLE Plano
DROP CONSTRAINT FK_Plano_Servidor;

ALTER TABLE Clientes ADD  DeviceKeyOuSenha VARCHAR (100);
ALTER TABLE Clientes ADD  MacOuEmail VARCHAR (100);

ALTER TABLE Clientes ADD  IdAplicativo INT FOREIGN KEY REFERENCES Aplicativo(Id);
ALTER TABLE Clientes ADD  IdServidor INT FOREIGN KEY REFERENCES Servidor(Id);

ALTER TABLE Clientes ADD  DataUltimoPagamento DATETIME NOT NULL;

ALTER TABLE Clientes ADD  DataProximoPagamento DATETIME NOT NULL;

INSERT INTO Plano (Descricao,Valor) VALUES ('Completo',300);

SELECT * FROM Servidor;

SELECT Id FROM Servidor WHERE Nome = 'TV BEM';

USE GerenciamentoClientes;

DROP TABLE Revendedor;

CREATE TABLE [dbo].[Revendedor] (
    [Id]               INT PRIMARY KEY IDENTITY(1,1)  NOT NULL,
    [Nome]             VARCHAR (100)   NOT NULL,
    [Telefone]         VARCHAR (25)    NOT NULL,
    [Email]            VARCHAR (100)   NULL,
    [IdServidor]       INT             NULL,
    [DataUltimaCompra] DATETIME        NOT NULL,
    [Quantidade]       INT             NULL,
    [Valor]            DECIMAL (10, 2) NULL
);

