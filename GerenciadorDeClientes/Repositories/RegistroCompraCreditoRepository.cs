using Dapper;
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
        throw new NotImplementedException();
    }   

    public ICollection<RegistroCompraCredito> GetByName(string name)
    {
        throw new NotImplementedException();
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
