using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;
namespace GerenciadorDeClientes.Views.Insert
{
    public partial class FormRegistraPagamentoCliente : Form
    {
        public FormRegistraPagamentoCliente()
        {            
            InitializeComponent();

            ClienteRepository cliRepository = new();
            List<string> listaClientes = new();
            var clientes = cliRepository.GetAll().ToList();
            if (clientes.Count > 0)
            {
                foreach (var cli in clientes)
                {
                    listaClientes.Add(cli.Nome);
                }

                comboBoxPagCliente.DataSource = listaClientes;
            }
            else
            {
                MessageBox.Show("Não existem clientes cadastrados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AplicativoRepository appRepository = new();
            List<string> apps = new();
            var aplicativos = appRepository.GetAll().ToList();
            if (aplicativos.Count > 0)
            {
                foreach (var app in aplicativos)
                {
                    apps.Add(app.Nome);
                }
                comboBoxPagClienAplicatico.DataSource = apps;
            }
            else
            {
                MessageBox.Show("Não existem aplicativos cadastrados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ServidorRepository servRepository = new();
            List<string> servs = new();
            var servidores = servRepository.GetAll().ToList();
            if (servidores.Count > 0)
            {
                foreach (var serv in servidores)
                {
                    servs.Add(serv.Nome);
                }
                comboBoxPagServidor.DataSource = servs;

            }
            else
            {
                MessageBox.Show("Não existem servidores cadastrados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PlanoRepository planRepository = new();
            List<string> planos = new();
            var listaPlanos = planRepository.GetAll().ToList();
            if (listaPlanos.Count > 0)
            {
                foreach (var plano in listaPlanos)
                {
                    planos.Add(plano.Descricao);
                }
                comboBoxPagPlano.DataSource = planos;

            }
            else
            {
                MessageBox.Show("Não existem planos cadastrados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegistrarPagCliente_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroPagamentoCliente rpc = new RegistroPagamentoCliente();              

                rpc.NomeCliente = comboBoxPagCliente.Text;
                rpc.NomeAplicativo = comboBoxPagClienAplicatico.Text;
                rpc.NomeServidor = comboBoxPagServidor.Text;
                rpc.DescricaoPlano = comboBoxPagPlano.Text;
                rpc.QtdeTelas = (int)numericUpDownPagQtdeTelas.Value;
                rpc.Valor = Decimal.Parse(textBoxValorPagCli.Text);
                rpc.DataPagamento = dateTimePickerPagClie.Value;
                rpc.QtdeMeses = (int)numericUpDownQtdeMeses.Value;
                rpc.DataProximoPagamento = rpc.DataPagamento.AddMonths(rpc.QtdeMeses);

                RegistroPagamentoClienteRepository rpcRepo = new RegistroPagamentoClienteRepository();
                rpcRepo.Insert(rpc);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
