using Dapper;
using GerenciadorDeClientes.Models;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorDeClientes.Repositories;

public class ClienteRepository : IRepository<Cliente>
{
    private readonly IDbConnection _connection;
    private FormCadastraCliente _formCadastraCliente;

    public ClienteRepository()
    {
      _connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GerenciamentoClientes;Integrated Security=True;Connect Timeout=30;");

      _formCadastraCliente = new FormCadastraCliente();
    }

    public ICollection<Cliente> GetAll()
    {
        var clientes = _connection.Query<Cliente>("SELECT * FROM Clientes").ToList();
        return clientes;
    }

    public ICollection<Cliente> GetByName(string nome)
    {
        var query = $"SELECT * FROM Clientes WHERE Nome LIKE '{nome}%';";
        var clientes = _connection.Query<Cliente>(query).ToList();
        return clientes;
    }

    public void Insert(Cliente cliente)
    {
        try
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

            DialogResult result = MessageBox.Show("Cliente salvo com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message,"Ocorreu um erro ao inserir o cliente!",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        

    }

    public void Update(Cliente t)
    {
        throw new NotImplementedException();
    }

    public void Delete(Cliente t)
    {
        throw new NotImplementedException();
    }
}
