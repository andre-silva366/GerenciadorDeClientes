﻿using Dapper;
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
                //string deviceKeySenha = cliente.DeviceKeyOuSenha;
                //string macEmail = cliente.MacOuEmail;
                //var dataUltimo = cliente.DataUltimoPagamento.ToString("yyyy-MM-dd HH:mm:ss");
                //var dataProximo = cliente.DataProximoPagamento.ToString("yyyy-MM-dd HH:mm:ss");

                var idPlano = _connection.QuerySingleOrDefault<int>(queryPlano, new { Descricao = descricaoPlano });

                var queryInsertCliente = "INSERT INTO Clientes (Nome, Telefone, Email, IdPlano) VALUES (@Nome, @Telefone, @Email, @IdPlano);";

                var parameters = new
                {
                    
                    Nome = nome,
                    Telefone = telefone,
                    Email = email,
                    IdPlano = idPlano

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
                var query = $"UPDATE Clientes SET Nome = @Nome, Telefone = @Telefone, Email = @Email, IdPlano = @IdPlano, DeviceKeyOuSenha = @DeviceKeyOuSenha, MacOuEmail = @MacOuEmail, IdAplicativo = @IdAplicativo, IdServidor = @IdServidor, DataUltimoPagamento = @DataUltimoPagamento, DataProximoPagamento = @DataProximoPagamento WHERE Id = {id};";

                string descricaoPlano = _formAtualizaCliente.comboBoxPlanoClienteAtualizado.Text;

                var queryIdPlano = "SELECT Id FROM Plano WHERE Descricao = @DescricaoPlano;";
                var idPlano = _connection.QuerySingleOrDefault<int>(queryIdPlano, new { DescricaoPlano = descricaoPlano });

                var parameters = new
                {
                    
                    cliente.Nome,
                    cliente.Telefone,
                    cliente.Email,
                    IdPlano = idPlano
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
