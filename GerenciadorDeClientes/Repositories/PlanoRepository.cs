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
        return _connection.Query<Plano>("SELECT * FROM Plano;").ToList();        
    }

    public ICollection<Plano> GetByName(string nome)
    {
        return _connection.Query<Plano>($"SELECT * FROM Plano WHERE Descricao LIKE '{nome}%'").ToList();        
    }

    public Plano GetById(int id)
    {
        return _connection.QuerySingleOrDefault<Plano>("SELECT * FROM Plano WHERE Id = @Id", new { Id = id });
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
    }

    public void Update(Plano t)
    {
        throw new NotImplementedException();
    }

    public void Delete(Plano t)
    {
        throw new NotImplementedException();
    }


}
