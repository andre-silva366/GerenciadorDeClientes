using GerenciadorDeClientes.Models;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace GerenciadorDeClientes.Repositories;

public class PlanoRepository : IRepository<Plano>
{
    private readonly IDbConnection _connection;

    public PlanoRepository()
    {
        _connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");
    }

    public ICollection<Plano> GetAll()
    {
        try
        {
            return _connection.Query<Plano>("SELECT * FROM Plano;").ToList();
        }
        finally
        {
            _connection.Close();
        }
    }

    public ICollection<Plano> GetByName(string nome)
    {
        try
        {
            return _connection.Query<Plano>($"SELECT * FROM Plano WHERE Descricao LIKE '{nome}%'").ToList();
        }
        finally
        {
            _connection.Close();
        }
    }

    public Plano GetById(int id)
    {
        try
        {
            return _connection.QuerySingleOrDefault<Plano>("SELECT * FROM Plano WHERE Id = @Id", new { Id = id });
        }
        finally
        {
            _connection.Close();
        }
    }

    public void Insert(Plano plano)
    {
        try
        {
            _connection.Execute("INSERT INTO Plano (Descricao, Valor) VALUES (@Descricao, @Valor)", new { plano.Descricao, plano.Valor });

            MessageBox.Show("Plano cadastrado com sucesso!","SUCESSO",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show("Erro ao cadastrar plano!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        finally
        {
            _connection.Close();
        }
    }

    public void Update(Plano t,int id)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }


}
