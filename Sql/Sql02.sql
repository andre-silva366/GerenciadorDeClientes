INSERT INTO Servidor (Nome) VALUES ('TV BEM');

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