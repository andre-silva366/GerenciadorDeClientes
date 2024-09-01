using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes.Views
{
    public partial class FormAtualizarCliente : Form
    {        

        public FormAtualizarCliente()
        {
            InitializeComponent();

            ServidorRepository servidorRepository = new ServidorRepository();
            var servidores = servidorRepository.GetAll().ToList();
            List<string> nomeServidores = new List<string>();

            foreach (var item in servidores)
            {
                nomeServidores.Add(item.Nome);
            }

            comboBoxServidorRevendaAtualizado.DataSource = nomeServidores;

            PlanoRepository planoRepository = new PlanoRepository();
            var planos = planoRepository.GetAll().ToList();

            List<string> nomePlanos = new List<string>();

            foreach (var item in planos)
            {
                nomePlanos.Add(item.Descricao);
            }

            comboBoxPlanoClienteAtualizado.DataSource = nomePlanos;

            AplicativoRepository aplicativoRepository = new AplicativoRepository();
            var aplicativos = aplicativoRepository.GetAll().ToList();

            List<string> nomeAplicativos = new List<string>();

            foreach (var item in aplicativos)
            {
                nomeAplicativos.Add(item.Nome);
            }

            comboBoxAplicativoClienteAtualizado.DataSource = nomeAplicativos;
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

                        var aplicativo = aplicativoRepository.GetById(cliente.IdAplicativo);
                        comboBoxAplicativoClienteAtualizado.Text = aplicativo.Nome;

                        var servidor = servidorRepository.GetById(cliente.IdServidor);
                        comboBoxServidorRevendaAtualizado.Text = servidor.Nome;

                        var plano = planoRepository.GetById(cliente.IdPlano);
                        comboBoxPlanoClienteAtualizado.Text = plano.Descricao;

                        textBoxMacEmailClienteAtualizado.Text = cliente.MacOuEmail;
                        textBoxDeviceKeySenhaClienteAtualizado.Text = cliente.DeviceKeyOuSenha;
                        dateTimePickerUltimoPagamentoCliAtual.Value = cliente.DataUltimoPagamento;
                        dateTimePickerProximoPagamentoCliAtual.Value = cliente.DataProximoPagamento;
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
            Cliente cliente = new Cliente();
            ClienteRepository clienteRepository = new ClienteRepository();

            int idCliente = int.Parse(textBoxAtualizarClienteId.Text);
            cliente = clienteRepository.GetById(idCliente);
            cliente.Nome = textBoxNomeClienteAtualizado.Text;
            cliente.Telefone = maskedTextBoxTelefoneClienteAtualizado.Text;
            cliente.Email = textBoxEmailClienteAtualizado.Text;
            cliente.DeviceKeyOuSenha = textBoxDeviceKeySenhaClienteAtualizado.Text;
            cliente.MacOuEmail = textBoxMacEmailClienteAtualizado.Text;
            cliente.DataUltimoPagamento = dateTimePickerUltimoPagamentoCliAtual.Value;
            cliente.DataProximoPagamento = dateTimePickerProximoPagamentoCliAtual.Value;

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
                
                clienteRepository.Update(cliente,idCliente);
            }
        }

        

       
    }
}
