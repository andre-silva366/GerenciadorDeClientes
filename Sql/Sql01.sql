--CREATE DATABASE GerenciamentoClientes;

USE GerenciamentoClientes;

CREATE TABLE Plano(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Descricao VARCHAR (100) NOT NULL,
Valor DECIMAL(5,2) DEFAULT 0.00,
ValidadeEmMeses INT DEFAULT 1,
DataProximoPagamento DATETIME DEFAULT DATEADD(MONTH, 1,GETDATE())
);

-- Adicionando novo item na tabela
ALTER TABLE Plano ADD 
IdAplicativo INT NOT NULL,
IdServidor INT NOT NULL

ALTER TABLE Plano ADD
IdCliente INT NOT NULL

CREATE TABLE Servidor(
Id INTEGER PRIMARY KEY IDENTITY NOT NULL,
Nome VARCHAR(50)
)

CREATE TABLE Aplicativo(
Id INTEGER PRIMARY KEY IDENTITY NOT NULL,
Nome VARCHAR(50)
)

CREATE TABLE Clientes (
Id INT PRIMARY KEY IDENTITY NOT NULL,
Nome VARCHAR(100) NOT NULL,
Telefone VARCHAR(25) NOT NULL,
Email VARCHAR(100) 

)

ALTER TABLE Plano 
ADD CONSTRAINT FK_Plano_Aplicativo 
FOREIGN KEY (IdAplicativo) REFERENCES Aplicativo(Id);

ALTER TABLE Plano 
ADD CONSTRAINT FK_Plano_Servidor 
FOREIGN KEY (IdServidor) REFERENCES Servidor(Id);

ALTER TABLE Plano 
ADD CONSTRAINT FK_Plano_Clientes 
FOREIGN KEY (IdCliente) REFERENCES Clientes(Id);

CREATE TABLE Revendedor(
Id INTEGER PRIMARY KEY NOT NULL,
Nome VARCHAR(100) NOT NULL,
Telefone VARCHAR(25) NOT NULL,
Email VARCHAR(100) 

)

ALTER TABLE Plano
ADD MacOuEmail VARCHAR (100),
DeviceKeyOuSenha VARCHAR (100)

SELECT * FROM Servidor;

SELECT * FROM Revendedor;

INSERT INTO Revendedor (Id,Nome,Telefone,Email,IdServidor,DataUltimaCompra,Quantidade,Valor)
VALUES (1,'Francisco Almeida','11 5656-5656','fra@gmail.com',1,'2024-08-26',100,1000);

ALTER TABLE Revendedor ALTER COLUMN Valor DECIMAL (10,2);

SELECT * FROM Clientes;

INSERT INTO Clientes(Nome,Telefone,Email,IdPlano) VALUES ('Carlos Lacerda','55 92323-2323','car@gmail.com',2);

