using Dapper;
using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Views;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorDeClientes.Repositories;

public class ClienteRepository : IRepository<Cliente>
{
    private readonly IDbConnection _connection;

    public ClienteRepository()
    {
        _connection = new SqlConnection("Data Source=ANDRE-SILVA366\\SQLExpress;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");

    }

    public ICollection<Cliente> GetAll()
    {
        try
        {
            return _connection.Query<Cliente>("SELECT Id, Nome, Telefone, Email FROM Clientes ORDER BY Nome").ToList();
            
        }
        finally
        {
            _connection.Close();
        }
        
    }

    public ICollection<Cliente> GetByName(string nome)
    {
        try
        {
            return _connection.Query<Cliente>($"SELECT * FROM Clientes WHERE Nome LIKE '{nome}%';").ToList();
        }
        finally
        {
            _connection.Close();
        }
        
    }

    public Cliente GetById(int id)
    {
        try
        {
            return _connection.QuerySingle<Cliente>("SELECT * FROM Clientes WHERE Id = @Id;", new { Id = id });
        }
        finally
        {
            _connection.Close();
        }

    }

    public void Insert(Cliente cliente)
    {
        try
        {
            using (var _formCadastraCliente = new FormCadastraCliente())
            {
                string nome = cliente.Nome;
                string telefone = cliente.Telefone;
                string email = cliente.Email;

                var queryInsertCliente = "INSERT INTO Clientes (Nome, Telefone, Email, IdPlano) VALUES (@Nome, @Telefone, @Email);";

                var parameters = new
                {                    
                    Nome = nome,
                    Telefone = telefone,
                    Email = email
                };

                _connection.Execute(queryInsertCliente, parameters);
            }
            MessageBox.Show("Cliente salvo com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.StackTrace, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void Update(Cliente cliente,int id)
    {
        try
        {
            using (var _formAtualizaCliente = new FormAtualizarDeletarCliente())
            {
                var query = $"UPDATE Clientes SET Nome = @Nome, Telefone = @Telefone, Email = @Email WHERE Id = {id};";

                var parameters = new
                {                    
                    cliente.Nome,
                    cliente.Telefone,
                    cliente.Email
                };

                _connection.Execute(query, parameters);
            }
            MessageBox.Show("Cliente atualizado com sucesso !", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro ao atualizar o cliente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void Delete(int id)
    {
        try
        {
            var query = "DELETE FROM Clientes WHERE Id = @Id";
            _connection.Execute(query, new {Id=id});
            MessageBox.Show("Cliente deletado com sucesso!","SUCESSO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        catch
        {
            MessageBox.Show("Erro ao deletar cliente","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    }


}
