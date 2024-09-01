using GerenciadorDeClientes.Repositories;
using GerenciadorDeClientes.Views.Update;
using GerenciadorDeClientes.Views;


namespace GerenciadorDeClientes;

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
            if (clientes.Count == 0 || clientes == null)
            {
                MessageBox.Show("Não existe nenhum cliente cadastrado!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.Visible = true;
                dataGridView.DataSource = clientes;
            }

        }
        else if (radioButtonPlano.Checked)
        {
            PlanoRepository plano = new PlanoRepository();
            var planos = plano.GetAll().ToList();
            if (planos.Count == 0 || planos == null)
            {
                MessageBox.Show("Não existe nenhum plano cadastrado!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.Visible = true;
                dataGridView.DataSource = planos;
            }

        }
        else if (radioButtonRevendedor.Checked)
        {
            RevendedorRepository revendedor = new RevendedorRepository();
            var revendedores = revendedor.GetAll().ToList();
            if (revendedores.Count == 0 || revendedores == null)
            {
                MessageBox.Show("Não existe nenhum revendedor cadastrado!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.Visible = true;
                dataGridView.DataSource = revendedores;
            }

        }
        else if (radioButtonServidor.Checked)
        {
            ServidorRepository servidor = new ServidorRepository();
            var servidores = servidor.GetAll().ToList();
            if (servidores.Count == 0 || servidores == null)
            {
                MessageBox.Show("Não existe nenhum servidor cadastrado!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.Visible = true;
                dataGridView.DataSource = servidores;
            }

        }
        else if (radioButtonAplicativo.Checked)
        {
            AplicativoRepository aplicativo = new AplicativoRepository();
            var aplicativos = aplicativo.GetAll().ToList();
            if (aplicativos.Count == 0 || aplicativos == null)
            {
                MessageBox.Show("Não existe nenhum aplicativo cadastrado!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.Visible = true;
                dataGridView.DataSource = aplicativos;
            }

        }

    }

    private void buttonLimpar_Click(object sender, EventArgs e)
    {
        dataGridView.Visible = false;
        textBoxSelectNome.Text = null;
    }

    private void buttonBuscarPorNome_Click(object sender, EventArgs e)
    {
        var nome = textBoxSelectNome.Text.Trim();

        if (checkBoxBuscaPorNome.Checked)
        {
            if (nome.Length > 0)
            {
                if (radioButtonCliente.Checked)
                {
                    ClienteRepository cliente = new ClienteRepository();
                    var clientes = cliente.GetByName(nome).ToList();
                    if (clientes.Count == 0 || clientes == null)
                    {
                        MessageBox.Show($"Não encontrado nenhum aplicativo que comece com {nome} !", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dataGridView.Visible = true;
                        dataGridView.DataSource = clientes;
                    }
                }
                else if (radioButtonPlano.Checked)
                {
                    PlanoRepository plano = new PlanoRepository();
                    var planos = plano.GetByName(nome).ToList();
                    if (planos.Count == 0 || planos == null)
                    {
                        MessageBox.Show($"Não encontrado nenhum plano que comece com {nome} !", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dataGridView.Visible = true;
                        dataGridView.DataSource = planos;
                    }
                }
                else if (radioButtonRevendedor.Checked)
                {
                    RevendedorRepository revendedor = new RevendedorRepository();
                    var revendedores = revendedor.GetByName(nome).ToList();
                    if (revendedores.Count == 0 || revendedores == null)
                    {
                        MessageBox.Show($"Não encontrado nenhum revendedor que comece com {nome} !", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dataGridView.Visible = true;
                        dataGridView.DataSource = revendedores;
                    }
                }
                else if (radioButtonServidor.Checked)
                {
                    ServidorRepository servidor = new ServidorRepository();
                    var servidores = servidor.GetByName(nome).ToList();
                    if (servidores.Count == 0 || servidores == null)
                    {
                        MessageBox.Show($"Não encontrado nenhum servidor que comece com {nome} !", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dataGridView.Visible = true;
                        dataGridView.DataSource = servidores;
                    }
                }
                else if (radioButtonAplicativo.Checked)
                {
                    AplicativoRepository aplicativo = new AplicativoRepository();
                    var aplicativos = aplicativo.GetByName(nome).ToList();
                    if (aplicativos.Count == 0 || aplicativos == null)
                    {
                        MessageBox.Show($"Não encontrado nenhum aplicativo que comece com {nome}!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dataGridView.Visible = true;
                        dataGridView.DataSource = aplicativos;
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite no minimo 1 caractere !!!");
            }
        }
        else
        {
            MessageBox.Show("Selecione o check box !!!");
        }

    }

    private void buttonCadastrar_Click(object sender, EventArgs e)
    {
        if (radioButtonCliente.Checked)
        {
            FormCadastraCliente formCadastraCliente = new FormCadastraCliente();
            formCadastraCliente.Show();
        }
        if (radioButtonRevendedor.Checked)
        {
            FormCadastraRevendedor formCadastraRevendedor = new FormCadastraRevendedor();
            formCadastraRevendedor.Show();
        }
        if (radioButtonServidor.Checked)
        {
            FormCadastraServidor formCadastraServidor = new FormCadastraServidor();
            formCadastraServidor.Show();
        }
        if (radioButtonAplicativo.Checked)
        {
            FormCadastraAplicativo formCadastraAplicativo = new FormCadastraAplicativo();
            formCadastraAplicativo.Show();
        }
        if (radioButtonPlano.Checked)
        {
            FormCadastraPlano formCadastraPlano = new FormCadastraPlano();
            formCadastraPlano.Show();
        }
    }

    private void buttonAtualizar_Click(object sender, EventArgs e)
    {
        if (radioButtonCliente.Checked)
        {
            FormAtualizarCliente formAtualizaCliente = new FormAtualizarCliente();
            formAtualizaCliente.Show();            
            
        }

        if (radioButtonRevendedor.Checked)
        {
            FormAtualizarRevendedor formAtualizarRevendedor = new();
            formAtualizarRevendedor.Show();
        }
        if (radioButtonServidor.Checked)
        {
            FormAtualizarServidor formAtualizarServidor = new FormAtualizarServidor();
            formAtualizarServidor.Show();
        }
        //if (radioButtonAplicativo.Checked)
        //{
        //    FormCadastraAplicativo formCadastraAplicativo = new FormCadastraAplicativo();
        //    formCadastraAplicativo.Show();
        //}
        //if (radioButtonPlano.Checked)
        //{
        //    FormCadastraPlano formCadastraPlano = new FormCadastraPlano();
        //    formCadastraPlano.Show();
        //}
    }
}
