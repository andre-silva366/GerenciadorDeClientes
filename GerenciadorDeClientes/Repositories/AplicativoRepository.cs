using GerenciadorDeClientes.Models;
using System.Data;
using Dapper;

namespace GerenciadorDeClientes.Repositories;

public class AplicativoRepository : IRepository<Aplicativo>
{
    private readonly IDbConnection _connection;

    public AplicativoRepository()
    {
        //Sql
        //_connection = new SqlConnection("Data Source=ANDRE-SILVA366\\SQLExpress;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");

        //MySQL
        _connection = new MySql.Data.MySqlClient.MySqlConnection("Server=192.168.15.14;Database=GerenciamentoClientes;Uid=andre;Pwd=3210;SslMode=None;AllowPublicKeyRetrieval=True;AllowPublicKeyRetrieval=True;");
    }

    public ICollection<Aplicativo> GetAll()
    {
        try
        {
            return  _connection.Query<Aplicativo>("SELECT * FROM Aplicativo;").ToList(); 
        }
        finally
        {
            _connection.Close();
        }
                
    }

    public ICollection<Aplicativo> GetByName(string nome)
    {
        try
        {
            return _connection.Query<Aplicativo>($"SELECT * FROM Aplicativo WHERE Nome LIKE '{nome}%'").ToList();
        }
        finally
        {
            _connection.Close();
        }
    }

    public Aplicativo GetById(int id)
    {
        try
        {
            return _connection.QuerySingleOrDefault<Aplicativo>("SELECT * FROM Aplicativo WHERE Id = @Id", new { Id = id });
        }
        finally
        {
            _connection.Close ();
        }
    }

    public void Insert(Aplicativo app)
    {
        try
        {
            _connection.Execute("INSERT INTO Aplicativo (Nome,Site) VALUES (@Nome,@Site);", new {app.Nome,app.Site});
            MessageBox.Show("Aplicativo cadastrado com sucesso!","SUCESSO",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch(Exception)
        {
            MessageBox.Show("Erro ao cadastrar aplicativo!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    }

    public void Update(Aplicativo app,int id)
    {
        try
        {
            var query = "UPDATE Aplicativo SET Nome = @Nome, Site=@Site WHERE Id = @Id;";
            _connection.Execute(query, new {app.Nome,app.Site,id});

            MessageBox.Show("Aplicativo atualizado com sucesso !","SUCESSO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        catch
        {
            MessageBox.Show("Erro ao atualizar o aplicativo !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var query = "DELETE FROM Aplicativo WHERE Id = @Id";
            _connection.Execute(query, new { Id = id });
            MessageBox.Show("Aplicativo deletado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch
        {
            MessageBox.Show("Erro ao deletar aplicativo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }
    }


}
