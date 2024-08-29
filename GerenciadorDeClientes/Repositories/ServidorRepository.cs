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
        return _connection.Query<Servidor>("SELECT * FROM Servidor;").ToList();
    }

    public ICollection<Servidor> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public void Insert(Servidor t)
    {
        throw new NotImplementedException();
    }

    public void Update(Servidor t)
    {
        throw new NotImplementedException();
    }

    public void Delete(Servidor t)
    {
        throw new NotImplementedException();
    }


}
