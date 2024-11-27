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
        _connection = new SqlConnection("Data Source=ANDRE-SILVA366\\SQLExpress;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");
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

    public ICollection<Plano> GetByName(string descricao)
    {
        try
        {
            return _connection.Query<Plano>($"SELECT * FROM Plano WHERE Descricao LIKE '{descricao}%'").ToList();
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
            _connection.Execute("INSERT INTO Plano (Descricao) VALUES (@Descricao)", new { plano.Descricao  });

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

    public void Update(Plano plano,int id)
    {
        try
        {
            var query = "UPDATE Plano SET Descricao = @Descricao WHERE Id = @Id;";

            var parameters = new
            {
                id,
                plano.Descricao
            };

            _connection.Execute(query,parameters);

            MessageBox.Show("Plano atualizado com sucesso !", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch
        {
            MessageBox.Show("Erro ao atualizar o plano !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var query = "DELETE FROM Plano WHERE Id = @Id";
            _connection.Execute(query, new { Id = id });
            MessageBox.Show("Plano deletado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch
        {
            MessageBox.Show("Erro ao deletar plano", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    }


}
