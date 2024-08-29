using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes
{
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();
            
        }

        // Botão buscar (Get All)
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = true;

            if (radioButtonCliente.Checked)
            {
                ClienteRepository cliente = new ClienteRepository();
                var clientes = cliente.GetAll().ToList();
                dataGridView.DataSource = clientes;
            }
            else if (radioButtonPlano.Checked)
            {
                PlanoRepository plano = new PlanoRepository();
                var planos = plano.GetAll().ToList();
                dataGridView.DataSource = planos;
            }
            else if (radioButtonRevendedor.Checked)
            {
                RevendedorRepository revendedor = new RevendedorRepository();
                var revendedores = revendedor.GetAll().ToList();
                dataGridView.DataSource = revendedores;
            }
            else if (radioButtonServidor.Checked)
            {
                ServidorRepository servidor = new ServidorRepository();
                var servidores = servidor.GetAll().ToList();
                dataGridView.DataSource = servidores;
            }
            else if (radioButtonAplicativo.Checked)
            {
                AplicativoRepository aplicativo = new AplicativoRepository();
                var aplicativos = aplicativo.GetAll().ToList();
                dataGridView.DataSource = aplicativos;
            }


        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = false;
            textBoxSelectNome.Text = null;
        }

        private string VerificaComboBox()
        {
            string tabela = null;
            return tabela ?? "";

        }

        private string VerificaTextBox()
        {
            string texto = textBoxSelectNome.Text;
            return texto ?? "";
        }

        // Em processo
        private void buttonBuscarPorNome_Click(object sender, EventArgs e)
        {
            var nome = textBoxSelectNome.Text.Trim();

            if (checkBoxBuscaPorNome.Checked)
            {
                if (nome.Length > 2)
                {
                    if (radioButtonCliente.Checked)
                    {
                        dataGridView.Visible = true;

                        ClienteRepository cliente = new ClienteRepository();
                        var clientes = cliente.GetByName(nome).ToList();
                        dataGridView.DataSource = clientes;
                    }
                    else if (radioButtonPlano.Checked)
                    {
                        PlanoRepository plano = new PlanoRepository();
                        var planos = plano.GetByName(nome).ToList();
                        dataGridView.DataSource = planos;
                    }
                    else if (radioButtonRevendedor.Checked)
                    {
                        RevendedorRepository revendedor = new RevendedorRepository();
                        var revendedores = revendedor.GetByName(nome).ToList();
                        dataGridView.DataSource = revendedores;
                    }
                    else if (radioButtonServidor.Checked)
                    {
                        ServidorRepository servidor = new ServidorRepository();
                        var servidores = servidor.GetByName(nome).ToList();
                        dataGridView.DataSource = servidores;
                    }
                    else if (radioButtonAplicativo.Checked)
                    {
                        AplicativoRepository aplicativo = new AplicativoRepository();
                        var aplicativos = aplicativo.GetByName(nome).ToList();
                        dataGridView.DataSource = aplicativos;
                    }
                }
                else
                {
                    MessageBox.Show("Digite no minimo 3 caracteres !!!");

                }

            }
            else
            {
                MessageBox.Show("Selecione o check box !!!");

            }


        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if(radioButtonCliente.Checked)
            {
                FormCadastraCliente formCadastraCliente = new FormCadastraCliente();
                formCadastraCliente.Show();
            }
            if (radioButtonRevendedor.Checked)
            {
                FormCadastraRevendedor formCadastraRevendedor = new FormCadastraRevendedor();
                formCadastraRevendedor.Show();
            }
            
            
        }
    }
}
