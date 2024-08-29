using GerenciadorDeClientes.Models;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace GerenciadorDeClientes.Repositories;

public class RevendedorRepository : IRepository<Revendedor>
{
    private readonly IDbConnection _connection;
    private FormCadastraRevendedor _cadastraRevendedor;

    public RevendedorRepository()
    {
        _connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");

        _cadastraRevendedor = new FormCadastraRevendedor();
    }

    public ICollection<Revendedor> GetAll()
    {
        return _connection.Query<Revendedor>("SELECT * FROM Revendedor").ToList();
    }

    public ICollection<Revendedor> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public void Insert(Revendedor revendedor)
    {
        try
        {
            var nomeServidor = _cadastraRevendedor.comboBoxServidorRev.Text;
            var queryIdServidor = "SELECT Id FROM Servidor WHERE Nome = @NomeServidor;";
            var idServidor = _connection.QuerySingleOrDefault<int>(queryIdServidor,new {NomeServidor = nomeServidor});

            string nome = revendedor.Nome;
            string telefone = revendedor.Telefone;
            string email = revendedor.Email;
            var dataUltimaCompra = revendedor.DataUltimaCompra;
            int quantidade = revendedor.Quantidade;
            var valor = revendedor.Valor;

            var queryInsertRevendedor = "INSERT INTO Revendedor (Nome, Telefone, Email, IdServidor, DataUltimaCompra, Quantidade, Valor) VALUES (@Nome, @Telefone, @Email, @IdServidor, @DataUltimaCompra, @Quantidade, @Valor);";

            var parameters = new
            {
                Nome = nome,
                Telefone = telefone,
                Email = email,
                IdServidor = idServidor,
                DataUltimaCompra = dataUltimaCompra,
                Quantidade = quantidade,
                Valor = valor
            };

            _connection.Execute(queryInsertRevendedor, parameters);
            MessageBox.Show("Revendedor cadastrado com sucesso!","SUCESSO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void Update(Revendedor t)
    {
        throw new NotImplementedException();
    }

    public void Delete(Revendedor t)
    {
        throw new NotImplementedException();
    }


}
