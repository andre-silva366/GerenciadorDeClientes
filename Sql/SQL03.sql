﻿USE GerenciamentoClientes;

ALTER TABLE Revendedor
ADD CONSTRAINT IdServidor FOREIGN KEY (IdServidor) REFERENCES Servidor(Id);

ALTER TABLE Revendedor
ALTER COLUMN IdServidor INT NOT NULL;

ALTER TABLE Clientes
ALTER COLUMN IdPlano INT NOT NULL;

ALTER TABLE Clientes
ALTER COLUMN IdServidor INT NOT NULL;

ALTER TABLE Clientes
ALTER COLUMN IdAplicativo INT NOT NULL;