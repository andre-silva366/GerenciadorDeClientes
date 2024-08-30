using GerenciadorDeClientes.Models;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace GerenciadorDeClientes.Repositories;

public class AplicativoRepository : IRepository<Aplicativo>
{
    private readonly IDbConnection _connection;

    public AplicativoRepository()
    {
        _connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");
    }

    public ICollection<Aplicativo> GetAll()
    {
        return  _connection.Query<Aplicativo>("SELECT * FROM Aplicativo;").ToList();         
    }

    public ICollection<Aplicativo> GetByName(string nome)
    {
        return _connection.Query<Aplicativo>($"SELECT * FROM Aplicativo WHERE Nome LIKE '{nome}%'").ToList();               
    }

    public Aplicativo GetById(int id)
    {
        return _connection.QuerySingleOrDefault<Aplicativo>("SELECT * FROM Aplicativo WHERE Id = @Id", new { Id = id });
    }

    public void Insert(Aplicativo app)
    {
        try
        {
            _connection.Execute("INSERT INTO Aplicativo (Nome) VALUES (@Nome);", new {app.Nome});
            MessageBox.Show("Aplicativo cadastrado com sucesso!","SUCESSO",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch(Exception)
        {
            MessageBox.Show("Erro ao cadastrar aplicativo!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }

    public void Update(Aplicativo t)
    {
        throw new NotImplementedException();
    }

    public void Delete(Aplicativo t)
    {
        throw new NotImplementedException();
    }


}
