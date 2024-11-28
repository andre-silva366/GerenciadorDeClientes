using Dapper;
using GerenciadorDeClientes.Models;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorDeClientes.Repositories;

public class RegistroPagamentoRevendedorRepository : IRegistroRepository<RegistroPagamentoRevendedor>
{
    private readonly IDbConnection _connection;
    public RegistroPagamentoRevendedorRepository()
    {
        _connection = new SqlConnection("Data Source=ANDRE-SILVA366\\SQLExpress;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");
    }
    public ICollection<RegistroPagamentoRevendedor> GetAll()
    {
        try
        {
            var queryRegPagRev = "SELECT Id, IdRevendedor,IdServidor, QtdeCreditos, Valor, DataPagamento FROM RegistroPagamentoRevendedor ORDER BY DataPagamento DESC;";
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

    public ICollection<RegistroPagamentoRevendedor> GetByName(string nome)
    {
        try
        {
            var queryRegPagRev = "SELECT Id, IdRevendedor, IdServidor, QtdeCreditos, Valor, DataPagamento FROM RegistroPagamentoRevendedor ORDER BY DataPagamento DESC;";
            var regPagRev = _connection.Query<RegistroPagamentoRevendedor>(queryRegPagRev).ToList();
            foreach (var reg in regPagRev)
            {
                reg.NomeRevendedor = _connection.QuerySingle<string>("SELECT Nome FROM Revendedor WHERE Id = @Id;", new {Id = reg.IdRevendedor});
                reg.NomeServidor = _connection.QuerySingle<string>("SELECT Nome FROM Servidor WHERE Id = @Id;", new { Id = reg.IdServidor });
            }

            var rprPorNome = regPagRev.FindAll(r => r.NomeRevendedor.ToUpper().StartsWith(nome.ToUpper()));
            return rprPorNome;
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

    public decimal SomaValorPorMes(int ano, int mes)
    {
        try
        {
            return _connection.QuerySingle<decimal>("SELECT COALESCE(SUM(Valor), 0) AS TotalPagamentoRevendedor FROM RegistroPagamentoRevendedor WHERE DATEPART(MONTH, DataPagamento) = @Mes AND DATEPART(YEAR, DataPagamento) = @Ano;", new { Mes = mes, Ano = ano });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return default;
        }
        finally
        {
            _connection.Close();
        }
    }

}
