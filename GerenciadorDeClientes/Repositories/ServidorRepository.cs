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

    public void Update(Servidor servidor, int id)
    {
        try
        {
            var query = $"UPDATE Servidor SET Nome = @Nome WHERE Id = @Id;";
            var parameters = new { Id = id ,servidor.Nome};
            _connection.Execute(query, parameters);

            MessageBox.Show("Sucesso ao atualizar servidor", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch
        {
            MessageBox.Show("Erro ao atualizar servidor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    }

    public void Delete(int id)
    {
        try
        {
            var query = "DELETE FROM Servidor WHERE Id = @Id";
            _connection.Execute(query, new { Id = id });
            MessageBox.Show("Servidor deletado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch
        {
            MessageBox.Show("Erro ao deletar servidor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    }


}
