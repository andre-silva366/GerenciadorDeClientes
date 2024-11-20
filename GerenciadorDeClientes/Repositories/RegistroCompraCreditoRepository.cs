﻿using Dapper;
using GerenciadorDeClientes.Models;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorDeClientes.Repositories;

public class RegistroCompraCreditoRepository : IRepository<RegistroCompraCredito>
{
    private readonly IDbConnection _connection;
    public RegistroCompraCreditoRepository()
    {
        _connection = new SqlConnection("Data Source=ANDRE-SILVA366\\SQLExpress;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");
    }
    public ICollection<RegistroCompraCredito> GetAll()
    {
        try
        {
            var queryRCC = "SELECT Id, IdServidor, QtdeCredito, Valor, DataCompra FROM RegistroCompraCredito ORDER BY DataCompra DESC;";
            var rcc = _connection.Query<RegistroCompraCredito>(queryRCC).ToList();
            foreach (var item in rcc)
            {
                item.NomeServidor = _connection.QuerySingle<string>("SELECT Nome FROM Servidor WHERE Id = @Id", new { Id = item.IdServidor });
            }
            return rcc;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}","ERRO",MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        finally
        {
            _connection.Close();
        }
    }   

    public ICollection<RegistroCompraCredito> GetByName(string nome)
    {
        try
        {
            var queryRCC = "SELECT Id, IdServidor, QtdeCredito, Valor, DataCompra FROM RegistroCompraCredito ORDER BY DataCompra DESC;";
            var rcc = _connection.Query<RegistroCompraCredito>(queryRCC).ToList();
            foreach (var item in rcc)
            {
                item.NomeServidor = _connection.QuerySingle<string>("SELECT Nome FROM Servidor WHERE Id = @Id", new { Id = item.IdServidor });
            }
            return rcc.FindAll(c => c.NomeServidor.ToUpper().StartsWith(nome.ToUpper()));
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        finally
        {
            _connection.Close();
        }
    }
    public RegistroCompraCredito GetById(int id)
    {
        throw new NotImplementedException();
    }
    public void Insert(RegistroCompraCredito rcc)
    {
        try
        {
            var queryServidor = "SELECT Id FROM Servidor WHERE Nome = @Nome;";
            var idServidor = _connection.QuerySingleOrDefault<int>(queryServidor, new {Nome = rcc.NomeServidor});
            var qtdeCredito = rcc.QtdeCredito;
            var valor = rcc.Valor;
            var dataCompra = rcc.DataCompra;

            var queryInsertServidor = "INSERT INTO RegistroCompraCredito (IdServidor, QtdeCredito, Valor, DataCompra) VALUES (@IdServidor, @QtdeCredito, @Valor, @DataCompra);";
            var parameters = new
            {
                IdServidor = idServidor,
                QtdeCredito = qtdeCredito,
                Valor = valor,
                DataCompra = dataCompra
            };

            _connection.Execute(queryInsertServidor, parameters);
            MessageBox.Show("Registro realizado com sucesso!","SUCESSO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Falha ao registrar: {ex.Message}", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        finally
        {
            _connection.Close();
        }
    }
    public void Update(RegistroCompraCredito t, int id)
    {
        throw new NotImplementedException();
    }
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }


}
