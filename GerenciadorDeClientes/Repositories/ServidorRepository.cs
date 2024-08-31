using GerenciadorDeClientes.Models;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace GerenciadorDeClientes.Repositories;

public class ServidorRepository : IRepository<Servidor>
{
    private readonly IDbConnection _connection;

    public ServidorRepository()
    {
        _connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");
    }

    public ICollection<Servidor> GetAll()
    {
        try
        {
            return _connection.Query<Servidor>("SELECT * FROM Servidor;").ToList();
        }
        finally
        {
            _connection.Close();
        }
    }

    public ICollection<Servidor> GetByName(string nome)
    {
        try
        {
            return _connection.Query<Servidor>($"SELECT * FROM Servidor WHERE Nome LIKE '{nome}%';").ToList();
        }
        finally
        {
            _connection.Close();
        }
    }

    public Servidor GetById(int id)
    {
        try
        {
            return _connection.QuerySingleOrDefault<Servidor>("SELECT * FROM Servidor WHERE Id = @Id", new { Id = id });
        }
        finally
        {
            _connection.Close();
        }
    }

    public void Insert(Servidor servidor)
    {
        try
        {
            _connection.Execute("INSERT INTO Servidor (Nome) VALUES (@Nome);", new { servidor.Nome });
            MessageBox.Show("Servidor cadastrado com sucesso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
        
    }

    public void Update(Servidor t, int id)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }


}
