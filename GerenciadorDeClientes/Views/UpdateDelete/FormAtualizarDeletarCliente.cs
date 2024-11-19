using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;
using System.Text.RegularExpressions;

namespace GerenciadorDeClientes.Views
{
    public partial class FormAtualizarDeletarCliente : Form
    {

        public FormAtualizarDeletarCliente()
        {
            InitializeComponent();                        
        }

        private void buttonAtualizacaoBuscaClienteId_Click(object sender, EventArgs e)
        {
            try
            {
                var clienteRepository = new ClienteRepository();
                int idCliente = int.Parse(textBoxAtualizarClienteId.Text);
                var cliente = clienteRepository.GetById(idCliente);
                {
                    if (cliente == null)
                    {
                        MessageBox.Show($"Não encontrado cliente com id = {idCliente}");
                    }
                    else
                    {
                        AplicativoRepository aplicativoRepository = new AplicativoRepository();
                        ServidorRepository servidorRepository = new ServidorRepository();

                        textBoxNomeClienteAtualizado.Text = cliente.Nome;
                        maskedTextBoxTelefoneClienteAtualizado.Text = cliente.Telefone;
                        textBoxEmailClienteAtualizado.Text = cliente.Email;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Preencha o campo Id com um número !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAtualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                ClienteRepository clienteRepository = new ClienteRepository();

                int idCliente = int.Parse(textBoxAtualizarClienteId.Text);
                cliente = clienteRepository.GetById(idCliente);
                cliente.Nome = textBoxNomeClienteAtualizado.Text;
                cliente.Telefone = FormataTelefone(maskedTextBoxTelefoneClienteAtualizado.Text);
                cliente.Email = textBoxEmailClienteAtualizado.Text;                

                if (cliente.Nome.Length < 3)
                {
                    MessageBox.Show("Preencha o Nome", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (cliente.Telefone.Length < 11)
                {
                    MessageBox.Show("Preencha o Telefone", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    buttonLimparCadastroAtualizaCliente.PerformClick();
                    clienteRepository.Update(cliente, idCliente);
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o cliente\nVerifique os campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDeletarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = int.Parse(textBoxAtualizarClienteId.Text);
                if (idCliente > 0)
                {
                    ClienteRepository clienteRepository = new ClienteRepository();
                    var cliente = clienteRepository.GetById(idCliente);

                    if (cliente == null)
                    {
                        MessageBox.Show($"Não encontrado cliente com id: {idCliente}");
                    }
                    else
                    {
                        buttonLimparCadastroAtualizaCliente.PerformClick();
                        clienteRepository.Delete(idCliente);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o cliente\nVerifique os campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimparCadastroAtualizaCliente_Click(object sender, EventArgs e)
        {
            textBoxAtualizarClienteId.Text = "";
            textBoxNomeClienteAtualizado.Text = "";
            maskedTextBoxTelefoneClienteAtualizado.Text = "";
            textBoxEmailClienteAtualizado.Text = "";
            
        }
        private string FormataTelefone(string telefone)
        {
            telefone = Regex.Replace(telefone, @"\D", "");

            if (telefone.Length == 11)
            {
                return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)} - {telefone.Substring(7)}";
            }
            else if (telefone.Length == 10)
            {
                return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 4)} - {telefone.Substring(6)}";
            }
            else
            {
                return telefone;
            }
        }
    }
}
