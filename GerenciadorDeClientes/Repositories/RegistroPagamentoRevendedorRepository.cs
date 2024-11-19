using Dapper;
using GerenciadorDeClientes.Models;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorDeClientes.Repositories;

public class RegistroPagamentoRevendedorRepository : IRepository<RegistroPagamentoRevendedor>
{
    private readonly IDbConnection _connection;
    public RegistroPagamentoRevendedorRepository()
    {
        _connection = new SqlConnection("Data Source=ANDRE-SILVA366\\SQLExpress;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");
    }
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public ICollection<RegistroPagamentoRevendedor> GetAll()
    {
        try
        {
            var queryRegPagRev = "SELECT Id, IdRevendedor,IdServidor, QtdeCreditos, Valor, DataPagamento FROM RegistroPagamentoRevendedor;";
            var regPagRev = _connection.Query<RegistroPagamentoRevendedor>(queryRegPagRev).ToList();
            var queryRevendedor = "SELECT Nome FROM Revendedor WHERE Id = @Id;";
            var queryServidor = "SELECT Nome FROM Servidor WHERE Id = @Id;";

            foreach (var item in regPagRev)
            {
                item.NomeRevendedor = _connection.QuerySingle<string>(queryRevendedor, new {Id = item.IdRevendedor});
                item.NomeServidor = _connection.QuerySingle<string>(queryServidor, new { Id = item.IdServidor });
            }

            return regPagRev;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            return null;
        }
        finally
        {
            _connection.Close();
        }
    }

    public RegistroPagamentoRevendedor GetById(int id)
    {
        throw new NotImplementedException();
    }

    public ICollection<RegistroPagamentoRevendedor> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public void Insert(RegistroPagamentoRevendedor rpr)
    {
        try
        {
            var queryRevendedor = "SELECT Id FROM Revendedor WHERE Nome = @Nome;";
            var idRevendedor = _connection.QuerySingleOrDefault<int>(queryRevendedor, new { Nome = rpr.NomeRevendedor });

            var queryServidor = "SELECT Id FROM Servidor WHERE Nome = @Nome;";
            var idServidor = _connection.QuerySingleOrDefault<int>(queryServidor, new { Nome = rpr.NomeServidor });

            var qtdeCredito = rpr.QtdeCreditos;
            var valor = rpr.Valor;
            var dataPagamento = rpr.DataPagamento;

            var parameters = new
            {
                IdRevendedor = idRevendedor,
                IdServidor = idServidor,
                QtdeCreditos = qtdeCredito,
                Valor = valor,
                DataPagamento = dataPagamento
            };

            var queryInsertRegPagRev = "INSERT INTO RegistroPagamentoRevendedor (IdRevendedor, IdServidor, QtdeCreditos, Valor, DataPagamento) VALUES (@IdRevendedor, @IdServidor, @QtdeCreditos, @Valor, @DataPagamento);";

            _connection.Execute(queryInsertRegPagRev, parameters);

            MessageBox.Show("Registro salvo com sucesso!","SUCESSO",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao salvar Registro: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    
   }

    public void Update(RegistroPagamentoRevendedor t, int id)
    {
        throw new NotImplementedException();
    }
}
