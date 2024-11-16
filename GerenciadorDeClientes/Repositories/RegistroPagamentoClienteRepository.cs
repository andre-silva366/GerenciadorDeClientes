using Dapper;
using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Views.Insert;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorDeClientes.Repositories;

public class RegistroPagamentoClienteRepository : IRepository<RegistroPagamentoCliente>
{
    private readonly IDbConnection _connection;

    public RegistroPagamentoClienteRepository()
    {
        _connection = new SqlConnection("Data Source=ANDRE-SILVA366\\SQLExpress;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");
    }

    public ICollection<RegistroPagamentoCliente> GetAll()
    {
        try
        {
            return _connection.Query<RegistroPagamentoCliente>("SELECT r.Id, c.Nome AS Cliente, a.Nome AS Aplicativo, p.Descricao AS Plano, r.QtdeTelas, r.Valor, r.DataPagamento, QtdeMeses, s.Nome AS Servidor FROM RegistroPagamentoCliente r JOIN Clientes c ON r.IdCliente = c.Id JOIN Aplicativo a ON r.IdAplicativo = a.Id JOIN Plano p ON r.IdPlano = p.Id JOIN Servidor s ON r.IdServidor = s.Id").ToList();
        }
        finally
        {
            _connection.Close();
        }


    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }



    public RegistroPagamentoCliente GetById(int id)
    {
        throw new NotImplementedException();
    }

    public ICollection<RegistroPagamentoCliente> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public void Insert(RegistroPagamentoCliente rpc)
    {
        try
        {
            //var nomeCliente = rpc.NomeCliente;
            var queryCliente = "SELECT Id FROM Clientes WHERE Nome = @Nome;";

            var idCliente = _connection.QuerySingleOrDefault<int>(queryCliente, new { Nome = rpc.NomeCliente });

            //var nomeApp = rpc.NomeAplicativo;
            var queryAplicativo = "SELECT Id FROM Aplicativo WHERE Nome = @Nome;";

            var idAplicativo = _connection.QuerySingleOrDefault<int>(queryAplicativo, new { Nome = rpc.NomeAplicativo });

            //var descPlano = rpc.DescricaoPlano;
            var queryPlano = "SELECT Id FROM Plano WHERE Descricao = @Descricao";

            var idPlano = _connection.QuerySingleOrDefault<int>(queryPlano, new { Descricao = rpc.DescricaoPlano });

            //var nomeServidor = rpc.NomeServidor;
            var queryServidor = "SELECT Id FROM Servidor WHERE Nome = @Nome";

            var idServidor = _connection.QuerySingleOrDefault<int>(queryServidor, new { Nome = rpc.NomeServidor });

            var qteTelas = rpc.QtdeTelas;
            var valor = rpc.Valor;
            var qteMeses = rpc.QtdeMeses;

            var dataPagamento = rpc.DataPagamento;
            var dataProxPag = rpc.DataProximoPagamento;

            var queryInsertRegPagClie = "INSERT INTO RegistroPagamentoCliente (IdCliente, IdAplicativo, IdPlano, IdServidor, QtdeTelas, QtdeMeses, DataPagamento, DataProximoPagamento) VALUES (@IdCliente, @IdAplicativo, @IdPlano, @IdServidor, @QtdeTelas, @QtdeMeses, @DataPagamento, @DataProximoPagamento)";

            var parameters = new
            {
                IdCliente = idCliente,
                IdAplicativo = idAplicativo,
                IdPlano = idPlano,
                IdServidor = idServidor,
                QtdeTelas = qteTelas,
                QtdeMeses = qteMeses,
                DataPagamento = dataPagamento,
                DataProximoPagamento = dataProxPag
            };

            _connection.Execute(queryInsertRegPagClie, parameters);


            MessageBox.Show("Registro salvo com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    }

    public void Update(RegistroPagamentoCliente t, int id)
    {
        throw new NotImplementedException();
    }
}
