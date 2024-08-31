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
        _connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");

    }

    public ICollection<Cliente> GetAll()
    {
        try
        {
            return _connection.Query<Cliente>("SELECT * FROM Clientes").ToList();
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
            return _connection.QuerySingleOrDefault<Cliente>("SELECT * FROM Clientes WHERE Id = @Id;", new { Id = id });
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
                var descricaoPlano = _formCadastraCliente.comboBoxPlano.Text;
                var queryPlano = "SELECT Id FROM Plano WHERE Descricao = @Descricao;";

                string nome = cliente.Nome;
                string telefone = cliente.Telefone;
                string email = cliente.Email;
                string deviceKeySenha = cliente.DeviceKeyOuSenha;
                string macEmail = cliente.MacOuEmail;
                var dataUltimo = cliente.DataUltimoPagamento.ToString("yyyy-MM-dd HH:mm:ss");
                var dataProximo = cliente.DataProximoPagamento.ToString("yyyy-MM-dd HH:mm:ss");

                var idPlano = _connection.QuerySingleOrDefault<int>(queryPlano, new { Descricao = descricaoPlano });

                var nomeAplicativo = _formCadastraCliente.comboBoxAplicativo.Text;
                var queryAplicativo = "SELECT Id FROM Aplicativo WHERE Nome = @Nome;";
                var idAplicativo = _connection.QuerySingleOrDefault<int>(queryAplicativo, new { Nome = nomeAplicativo });

                var nomeServidor = _formCadastraCliente.comboBoxServidor.Text;
                var queryServidor = "SELECT Id FROM Servidor WHERE Nome = @NomeServidor;";
                var idServidor = _connection.QuerySingleOrDefault<int>(queryServidor, new { NomeServidor = nomeServidor });

                var queryInsertCliente = "INSERT INTO Clientes (Nome, Telefone, Email, IdPlano, DeviceKeyOuSenha, MacOuEmail, IdAplicativo, IdServidor, DataUltimoPagamento, DataProximoPagamento) VALUES (@Nome, @Telefone, @Email, @IdPlano, @DeviceKeyOuSenha, @MacOuEmail, @IdAplicativo, @IdServidor, @DataUltimoPagamento, @DataProximoPagamento);";

                var parameters = new
                {
                    
                    Nome = nome,
                    Telefone = telefone,
                    Email = email,
                    IdPlano = idPlano,
                    DeviceKeyOuSenha = deviceKeySenha,
                    MacOuEmail = macEmail,
                    IdAplicativo = idAplicativo,
                    IdServidor = idServidor,
                    DataUltimoPagamento = dataUltimo,
                    DataProximoPagamento = dataProximo,

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
            using (var _formAtualizaCliente = new FormAtualizarCliente())
            {
                var query = $"UPDATE Clientes SET Nome = @Nome, Telefone = @Telefone, Email = @Email, IdPlano = @IdPlano, DeviceKeyOuSenha = @DeviceKeyOuSenha, MacOuEmail = @MacOuEmail, IdAplicativo = @IdAplicativo, IdServidor = @IdServidor, DataUltimoPagamento = @DataUltimoPagamento, DataProximoPagamento = @DataProximoPagamento WHERE Id = {id};";

                string nomeAplicativo = _formAtualizaCliente.comboBoxAplicativoClienteAtualizado.Text;
                string nomeServidor = _formAtualizaCliente.comboBoxServidorClienteAtualizado.Text;
                string descricaoPlano = _formAtualizaCliente.comboBoxPlanoClienteAtualizado.Text;

                var queryIdAplicativo = "SELECT Id FROM Aplicativo WHERE Nome = @NomeAplicativo;";
                var idAplicativo = _connection.QuerySingleOrDefault<int>(queryIdAplicativo, new { NomeAplicativo = nomeAplicativo });

                var queryIdServidor = "SELECT Id FROM Servidor WHERE Nome = @NomeServidor;";
                var idServidor = _connection.QuerySingleOrDefault<int>(queryIdServidor, new { NomeServidor = nomeServidor });

                var queryIdPlano = "SELECT Id FROM Plano WHERE Descricao = @DescricaoPlano;";
                var idPlano = _connection.QuerySingleOrDefault<int>(queryIdPlano, new { DescricaoPlano = descricaoPlano });

                var parameters = new
                {
                    
                    cliente.Nome,
                    cliente.Telefone,
                    cliente.Email,
                    IdPlano = idPlano,
                    cliente.DeviceKeyOuSenha,
                    cliente.MacOuEmail,
                    IdAplicativo = idAplicativo,
                    IdServidor = idServidor,
                    cliente.DataUltimoPagamento,
                    cliente.DataProximoPagamento

                };

                _connection.Execute(query, parameters);
            }
            MessageBox.Show("Cliente atualizado com sucesso !", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro ao atualizar o cliente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }


}
