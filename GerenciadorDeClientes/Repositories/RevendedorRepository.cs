using GerenciadorDeClientes.Models;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using GerenciadorDeClientes.Views;

namespace GerenciadorDeClientes.Repositories;

public class RevendedorRepository : IRepository<Revendedor>
{
    private readonly IDbConnection _connection;

    public RevendedorRepository()
    {
        _connection = new SqlConnection("Data Source=ANDRE-SILVA366\\SQLExpress;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");

    }

    public ICollection<Revendedor> GetAll()
    {
        try
        {
            return _connection.Query<Revendedor>("SELECT Id,Nome,Telefone,Email FROM Revendedor").ToList();
        }
        finally
        {
            _connection.Close();
        }
    }

    public ICollection<Revendedor> GetByName(string nome)
    {
        try
        {
            return _connection.Query<Revendedor>($"SELECT * FROM Revendedor WHERE Nome LIKE '{nome}%';").ToList();
        }
        finally
        {
            _connection.Close();
        }
    }

    public Revendedor GetById(int id)
    {
        try
        {
            return _connection.QuerySingleOrDefault<Revendedor>("SELECT * FROM Revendedor WHERE Id = @Id;", new { Id = id });
        }
        finally
        {
            _connection.Close();
        }
    }

    public void Insert(Revendedor revendedor)
    {
        try
        {
            using(var _cadastraRevendedor = new FormCadastraRevendedor())
            {
                string nome = revendedor.Nome;
                string telefone = revendedor.Telefone;
                string email = revendedor.Email;

                var queryInsertRevendedor = "INSERT INTO Revendedor (Nome, Telefone, Email) VALUES (@Nome, @Telefone, @Email);";

                var parameters = new
                {
                    Nome = nome,
                    Telefone = telefone,
                    Email = email
                };

                _connection.Execute(queryInsertRevendedor, parameters);
            }
            MessageBox.Show("Revendedor cadastrado com sucesso!","SUCESSO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    }

    public void Update(Revendedor revendedor,int id)
    {
        try
        {
            using (var _formAtualizarRevendedor = new FormAtualizarDeletarCliente())
            {
                var query = $"UPDATE Revendedor SET Nome = @Nome, Telefone = @Telefone, Email = @Email WHERE Id = {id};";                               

                var parameters = new
                {
                    revendedor.Nome,
                    revendedor.Telefone,
                    revendedor.Email
                };

                _connection.Execute(query, parameters);
            }
            MessageBox.Show("Revendedor atualizado com sucesso !", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro ao atualizar o revendedor!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void Delete(int id)
    {
        try
        {
            var query = "DELETE FROM Revendedor WHERE Id = @Id";
            _connection.Execute(query, new { Id = id });
            MessageBox.Show("Revendedor deletado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch
        {
            MessageBox.Show("Erro ao deletar revendedor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    }
    

}
