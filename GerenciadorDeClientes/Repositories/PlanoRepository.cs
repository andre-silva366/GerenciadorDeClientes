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

    public ICollection<Plano> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public void Insert(Plano t)
    {
        throw new NotImplementedException();
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
