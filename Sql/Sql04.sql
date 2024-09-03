USE GerenciamentoClientes;

SELECT c.Id, c.Telefone, c.Email,p.Descricao AS Plano,p.Valor,c.DeviceKeyOuSenha,c.MacOuEmail,
a.Nome AS Aplicativo,s.Nome AS Servidor,c.DataUltimoPagamento,c.DataProximoPagamento 
FROM Clientes c LEFT JOIN Plano p ON c.IdPlano = p.Id
LEFT JOIN Servidor s ON s.Id = c.IdServidor
LEFT JOIN Aplicativo a ON a.Id = c.IdAplicativo;