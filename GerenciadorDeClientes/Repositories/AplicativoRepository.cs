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
        return _connection.Query<Aplicativo>("SELECT * FROM Aplicativo;").ToList();
    }

    public ICollection<Aplicativo> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public void Insert(Aplicativo t)
    {
        throw new NotImplementedException();
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
