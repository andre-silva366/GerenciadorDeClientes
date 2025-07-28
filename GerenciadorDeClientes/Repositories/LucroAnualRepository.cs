using Dapper;
using GerenciadorDeClientes.Models;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorDeClientes.Repositories;

public class LucroAnualRepository
{
    private TabelaSomaRepository _tabelaSomaRepository;
    private readonly IDbConnection _connection;
    public LucroAnualRepository()
    {
        _tabelaSomaRepository = new TabelaSomaRepository();
        //Sql
        //_connection = new SqlConnection("Data Source=ANDRE-SILVA366\\SQLExpress;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");

        //MySQL
        _connection = new MySql.Data.MySqlClient.MySqlConnection("Server=192.168.15.14;Database=GerenciamentoClientes;Uid=andre;Pwd=3210;SslMode=None;AllowPublicKeyRetrieval=True;AllowPublicKeyRetrieval=True;");
    }
    public ICollection<LucroAnual> GetAll()
    {
        try
        {
            return _connection.Query<LucroAnual>("SELECT Id, Ano, Lucro FROM LucroAnual;").ToList();
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
    public void AtualizarLucroAnual()
    {
        try
        {
            var ano = DateTime.Now.Year;
            var lucroTotal = _tabelaSomaRepository.SomaValorPorAno(ano);

            string query = "";

            var valorExiste = _connection.ExecuteScalar<bool>("SELECT COUNT(1) FROM LucroAnual WHERE Ano = @Ano", new { Ano = ano});

            if (valorExiste)
            {
                query = "UPDATE LucroAnual SET Ano = @Ano, Lucro = @Lucro;";
            }
            else
            {
                query = "INSERT INTO LucroAnual (Ano, Lucro) VALUES (@Ano, @Lucro);";
            }

            var parameters = new
            {
                Ano = ano,                
                Lucro = lucroTotal
            };

            _connection.Execute(query, parameters);
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
}
