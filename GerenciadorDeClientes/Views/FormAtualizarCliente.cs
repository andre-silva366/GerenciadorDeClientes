using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes.Views
{
    public partial class FormAtualizarCliente : Form
    {
        private Cliente _cliente;
        private ClienteRepository _clienteRepository;
        private Aplicativo _aplicativo;
        private AplicativoRepository _appRepository;
        private Servidor _servidor;
        private ServidorRepository _servidorRepository;
        private Plano _plano;
        private PlanoRepository _planoRepository;

        public FormAtualizarCliente()
        {
            InitializeComponent();
            _cliente = new Cliente();
            _clienteRepository = new ClienteRepository();
            _aplicativo = new Aplicativo();
            _appRepository = new AplicativoRepository();
            _servidor = new Servidor();
            _servidorRepository = new ServidorRepository();
            _plano = new Plano();
            _planoRepository = new PlanoRepository();
        }

        private void buttonAtualizacaoBuscaClienteId_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(textBoxAtualizarClienteId.Text);
            var cliente = _clienteRepository.GetById(idCliente);
            if (cliente == null)
            {
                MessageBox.Show($"Não encontrado cliente com id = {idCliente}");
            }
            else
            {
                textBoxNomeClienteAtualizado.Text = cliente.Nome;
                maskedTextBoxTelefoneClienteAtualizado.Text = cliente.Telefone;
                textBoxEmailClienteAtualizado.Text = cliente.Email;

                var aplicativo = _appRepository.GetById(cliente.IdAplicativo);
                comboBoxAplicativoClienteAtualizado.Text = aplicativo.Nome;

                var servidor = _servidorRepository.GetById(cliente.IdServidor);
                comboBoxServidorClienteAtualizado.Text = servidor.Nome;

                var plano = _planoRepository.GetById(cliente.IdPlano);
                comboBoxPlanoClienteAtualizado.Text = plano.Descricao;

                textBoxMacEmailClienteAtualizado.Text = cliente.MacOuEmail;
                textBoxDeviceKeySenhaClienteAtualizado.Text = cliente.DeviceKeyOuSenha;
                dateTimePickerUltimoPagamentoCliAtual.Value = cliente.DataUltimoPagamento;
                dateTimePickerProximoPagamentoCliAtual.Value = cliente.DataProximoPagamento;
            }
        }
    }
}
