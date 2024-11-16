using Dapper;
using GerenciadorDeClientes.Models;
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
            var queryRegistroPagCli = _connection.Query<RegistroPagamentoCliente>("SELECT Id, IdCliente , IdAplicativo, IdPlano, QtdeTelas, Valor, DataPagamento, QtdeMeses, DataProximoPagamento, IdServidor FROM RegistroPagamentoCliente").ToList();

            foreach (var item in queryRegistroPagCli)
            {
                item.NomeCliente = _connection.QuerySingleOrDefault<string>($"SELECT Nome FROM Clientes WHERE {item.IdCliente} = Id;")?? "";
                item.NomeAplicativo = _connection.QuerySingleOrDefault<string>($"SELECT Nome FROM Aplicativo WHERE {item.IdAplicativo} = Id;") ?? "";
                item.DescricaoPlano = _connection.QuerySingleOrDefault<string>($"SELECT Descricao FROM Plano WHERE {item.IdPlano} = Id;") ?? "";
                item.NomeServidor = _connection.QuerySingleOrDefault<string>($"SELECT Nome FROM Servidor WHERE {item.IdServidor} = Id;") ?? "";
            }

            return queryRegistroPagCli;
        }
        catch(Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            return null;
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
            var queryCliente = "SELECT Id FROM Clientes WHERE Nome = @Nome;";
            var idCliente = _connection.QuerySingleOrDefault<int>(queryCliente, new { Nome = rpc.NomeCliente });

            var queryAplicativo = "SELECT Id FROM Aplicativo WHERE Nome = @Nome;";
            var idAplicativo = _connection.QuerySingleOrDefault<int>(queryAplicativo, new { Nome = rpc.NomeAplicativo });

            var queryPlano = "SELECT Id FROM Plano WHERE Descricao = @Descricao";
            var idPlano = _connection.QuerySingleOrDefault<int>(queryPlano, new { Descricao = rpc.DescricaoPlano });

            var queryServidor = "SELECT Id FROM Servidor WHERE Nome = @Nome";
            var idServidor = _connection.QuerySingleOrDefault<int>(queryServidor, new { Nome = rpc.NomeServidor });

            var qteTelas = rpc.QtdeTelas;
            var valor = rpc.Valor;
            var qteMeses = rpc.QtdeMeses;
            var dataPagamento = rpc.DataPagamento;
            var dataProxPag = rpc.DataProximoPagamento;

            var queryInsertRegPagClie = "INSERT INTO RegistroPagamentoCliente (IdCliente, IdAplicativo, IdPlano, IdServidor, QtdeTelas,Valor, QtdeMeses, DataPagamento, DataProximoPagamento) VALUES (@IdCliente, @IdAplicativo, @IdPlano, @IdServidor, @QtdeTelas,@Valor, @QtdeMeses, @DataPagamento, @DataProximoPagamento)";

            var parameters = new
            {
                IdCliente = idCliente,
                IdAplicativo = idAplicativo,
                IdPlano = idPlano,
                IdServidor = idServidor,
                QtdeTelas = qteTelas,
                Valor = valor,
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
