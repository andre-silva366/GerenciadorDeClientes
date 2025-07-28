using Dapper;
using GerenciadorDeClientes.Models;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorDeClientes.Repositories;

public class TabelaSomaRepository
{
    private readonly IDbConnection _connection;
    private RegistroCompraCreditoRepository _compraCreditoRepository;
    private RegistroPagamentoClienteRepository _pagamentoClienteRepository;
    private RegistroPagamentoRevendedorRepository _pagamentoRevendedorRepository;
    public TabelaSomaRepository()
    {
        //_connection = new SqlConnection("Data Source=ANDRE-SILVA366\\SQLExpress;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");
        _connection = new MySql.Data.MySqlClient.MySqlConnection("Server=192.168.15.14;Database=GerenciamentoClientes;Uid=andre;Pwd=3210;SslMode=None;AllowPublicKeyRetrieval=True;");
        _compraCreditoRepository = new RegistroCompraCreditoRepository();
        _pagamentoClienteRepository = new RegistroPagamentoClienteRepository();
        _pagamentoRevendedorRepository = new RegistroPagamentoRevendedorRepository();
    }
    public ICollection<TabelaSoma> GetAll()
    {
        try
        {
            return _connection.Query<TabelaSoma>("SELECT Id, Ano, Mes, TotalCompraCredito, TotalPagamentoCliente, TotalPagamentoRevendedor, Lucro FROM TabelaSoma ORDER BY Mes, Ano;").ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return [];
        }
        finally
        {
            _connection.Close();
        }
    }
    public void AtualizarTabelaSoma()
    {
        try
        {
            int anoAtual = DateTime.Now.Year;
            int anoMinimo = 2025;
            int mesAtual = DateTime.Now.Month;
            int mesMinimo = 1;

            for (int i = 2025; i <= anoAtual; i++)
            {
                var ano = i;

                for (int j = 1; j <= mesAtual; j++)
                {
                    var mes = j;
                    var totalCompraCredito = _compraCreditoRepository.SomaValorPorMes(ano, mes);
                    var totalPagamentoCliente = _pagamentoClienteRepository.SomaValorPorMes(ano, mes);
                    var totalPagamentoRevendedor = _pagamentoRevendedorRepository.SomaValorPorMes(ano, mes);
                    var lucro = (totalPagamentoCliente + totalPagamentoRevendedor) - totalCompraCredito;
                    string query = "";

                    var valorExiste = _connection.ExecuteScalar<bool>("SELECT COUNT(1) FROM TabelaSoma WHERE Ano = @Ano AND Mes = @Mes", new { Ano = ano, Mes = mes });

                    if (valorExiste)
                    {
                        query = "UPDATE TabelaSoma SET Ano = @Ano, Mes = @Mes, TotalCompraCredito = @TotalCompraCredito, TotalPagamentoCliente = @TotalPagamentoCliente, TotalPagamentoRevendedor = @TotalPagamentoRevendedor, Lucro = @Lucro WHERE Mes = @Mes;";
                    }
                    else
                    {
                        query = "INSERT INTO TabelaSoma (Ano, Mes, TotalCompraCredito, TotalPagamentoCliente, TotalPagamentoRevendedor, Lucro) VALUES (@Ano, @Mes, @TotalCompraCredito, @TotalPagamentoCliente, @TotalPagamentoRevendedor, @Lucro);";
                    }

                    var parameters = new
                    {
                        Ano = ano,
                        Mes = mes,
                        TotalCompraCredito = totalCompraCredito,
                        TotalPagamentoCliente = totalPagamentoCliente,
                        TotalPagamentoRevendedor = totalPagamentoRevendedor,
                        Lucro = lucro
                    };

                    _connection.Execute(query, parameters);
                }

            }            

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    }

    public decimal SomaValorPorAno(int ano)
    {
        try
        {
            return _connection.QuerySingle<decimal>("SELECT COALESCE(SUM(Lucro),0) AS 'Lucro total' FROM TabelaSoma WHERE Ano = @Ano;", new { Ano = ano });
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
