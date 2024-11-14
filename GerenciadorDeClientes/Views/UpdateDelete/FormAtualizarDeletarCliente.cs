using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes.Views
{
    public partial class FormAtualizarDeletarCliente : Form
    {

        public FormAtualizarDeletarCliente()
        {
            InitializeComponent();

            ServidorRepository servidorRepository = new ServidorRepository();
            var servidores = servidorRepository.GetAll().ToList();
            List<string> nomeServidores = new List<string>();

            foreach (var item in servidores)
            {
                nomeServidores.Add(item.Nome);
            }

            PlanoRepository planoRepository = new PlanoRepository();
            var planos = planoRepository.GetAll().ToList();

            List<string> nomePlanos = new List<string>();

            foreach (var item in planos)
            {
                nomePlanos.Add(item.Descricao);
            }

            comboBoxPlanoClienteAtualizado.DataSource = nomePlanos;
                        
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
                        PlanoRepository planoRepository = new PlanoRepository();

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
                cliente.Telefone = maskedTextBoxTelefoneClienteAtualizado.Text;
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
                    textBoxAtualizarClienteId.Text = "";
                    textBoxNomeClienteAtualizado.Text = "";
                    textBoxEmailClienteAtualizado.Text = "";
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
            comboBoxPlanoClienteAtualizado.Text = "";
            
        }
    }
}
