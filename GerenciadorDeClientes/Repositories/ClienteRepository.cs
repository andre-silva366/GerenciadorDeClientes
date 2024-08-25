using Dapper;
using GerenciadorDeClientes.Models;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorDeClientes.Repositories;

public class ClienteRepository : IRepository<Cliente>
{
    private readonly IDbConnection _connection;

    public ClienteRepository()
    {
      _connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");
    }

    public ICollection<Cliente> GetAll()
    {
        var clientes = _connection.Query<Cliente>("SELECT * FROM Clientes").ToList();
        return clientes;
    }

    public Cliente GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public Cliente Insert(Cliente t)
    {
        throw new NotImplementedException();
    }

    public Cliente Update(Cliente t)
    {
        throw new NotImplementedException();
    }

    public void Delete(Cliente t)
    {
        throw new NotImplementedException();
    }
}
