using Dapper;
using GerenciadorDeClientes.Models;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace GerenciadorDeClientes.Repositories;

public class TabelaSomaRepository 
{
    private readonly IDbConnection _connection;
    private RegistroCompraCreditoRepository _compraCreditoRepository;
    private RegistroPagamentoClienteRepository _pagamentoClienteRepository;
    private RegistroPagamentoRevendedorRepository _pagamentoRevendedorRepository;
    public TabelaSomaRepository()
    {
        _connection = new SqlConnection("Data Source=ANDRE-SILVA366\\SQLExpress;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");
        _compraCreditoRepository = new RegistroCompraCreditoRepository();
        _pagamentoClienteRepository = new RegistroPagamentoClienteRepository();
        _pagamentoRevendedorRepository = new RegistroPagamentoRevendedorRepository();
    }
    public ICollection<TabelaSoma> GetAll()
    {
        try
        {
            return _connection.Query<TabelaSoma>("SELECT Id, Ano, Mes, TotalCompraCredito, TotalPagamentoCliente, TotalPagamentoRevendedor, Lucro FROM TabelaSoma;").ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            var ano = DateTime.Now.Year;
            var mes = DateTime.Now.Month;
            var totalCompraCredito = _compraCreditoRepository.SomaValorPorMes(ano,mes);
            var totalPagamentoCliente = _pagamentoClienteRepository.SomaValorPorMes(ano, mes);
            var totalPagamentoRevendedor = _pagamentoRevendedorRepository.SomaValorPorMes(ano, mes);
            var lucro = (totalPagamentoCliente + totalPagamentoRevendedor) - totalCompraCredito;

            string query = "";

            var valorExiste = _connection.ExecuteScalar<bool>("SELECT COUNT(1) FROM TabelaSoma WHERE Ano = @Ano AND Mes = @Mes", new { Ano = ano, Mes = mes });

            if(valorExiste)
            {
                query = "UPDATE TabelaSoma SET Ano = @Ano, Mes = @Mes, TotalCompraCredito = @TotalCompraCredito, TotalPagamentoCliente = @TotalPagamentoCliente, TotalPagamentoRevendedor = @TotalPagamentoRevendedor, Lucro = @Lucro;";
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
        catch(Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    }

}
