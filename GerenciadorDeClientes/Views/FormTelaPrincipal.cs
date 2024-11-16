using GerenciadorDeClientes.Repositories;
using GerenciadorDeClientes.Views.Update;
using GerenciadorDeClientes.Views;
using GerenciadorDeClientes.Views.Insert;
using GerenciadorDeClientes.Models;

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
        if (radioButtonCliente.Checked)
        {
            ClienteRepository cliente = new ClienteRepository();
            var clientes = cliente.GetAll().ToList();
            if (clientes.Count == 0 || clientes == null)
            {
                dataGridView.Visible = false;
                MessageBox.Show("Não existe nenhum cliente cadastrado!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView.Visible = true;
                dataGridView.DataSource = clientes;
                dataGridView.Columns["IdPlano"].Visible = false;
            }

        }
        else if (radioButtonPlano.Checked)
        {
            PlanoRepository plano = new PlanoRepository();
            var planos = plano.GetAll().ToList();
            if (planos.Count == 0 || planos == null)
            {
                dataGridView.Visible = false;
                MessageBox.Show("Não existe nenhum plano cadastrado!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                dataGridView.Visible = false;
                MessageBox.Show("Não existe nenhum revendedor cadastrado!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                dataGridView.Visible = false;
                MessageBox.Show("Não existe nenhum servidor cadastrado!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                dataGridView.Visible = false;
                MessageBox.Show("Não existe nenhum aplicativo cadastrado!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                        dataGridView.Visible = false;
                        MessageBox.Show($"Não encontrado nenhum Cliente que comece com {nome} !", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        dataGridView.Visible = false;
                        MessageBox.Show($"Não encontrado nenhum Plano que comece com {nome} !", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        dataGridView.Visible = false;
                        MessageBox.Show($"Não encontrado nenhum Revendedor que comece com {nome} !", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        dataGridView.Visible = false;
                        MessageBox.Show($"Não encontrado nenhum Servidor que comece com {nome} !", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        dataGridView.Visible = false;
                        MessageBox.Show($"Não encontrado nenhum Aplicativo que comece com {nome}!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            formCadastraCliente.ShowDialog();
        }
        if (radioButtonRevendedor.Checked)
        {
            FormCadastraRevendedor formCadastraRevendedor = new FormCadastraRevendedor();
            formCadastraRevendedor.ShowDialog();
        }
        if (radioButtonServidor.Checked)
        {
            FormCadastraServidor formCadastraServidor = new FormCadastraServidor();
            formCadastraServidor.ShowDialog();
        }
        if (radioButtonAplicativo.Checked)
        {
            FormCadastraAplicativo formCadastraAplicativo = new FormCadastraAplicativo();
            formCadastraAplicativo.ShowDialog();
        }
        if (radioButtonPlano.Checked)
        {
            FormCadastraPlano formCadastraPlano = new FormCadastraPlano();
            formCadastraPlano.ShowDialog();
        }
    }

    private void buttonAtualizar_Click(object sender, EventArgs e)
    {
        if (radioButtonCliente.Checked)
        {
            FormAtualizarDeletarCliente formAtualizaCliente = new FormAtualizarDeletarCliente();
            formAtualizaCliente.ShowDialog();
        }

        if (radioButtonRevendedor.Checked)
        {
            FormAtualizarDeletarRevendedor formAtualizarRevendedor = new();
            formAtualizarRevendedor.ShowDialog();
        }
        if (radioButtonServidor.Checked)
        {
            FormAtualizarDeletarServidor formAtualizarServidor = new FormAtualizarDeletarServidor();
            formAtualizarServidor.ShowDialog();
        }
        if (radioButtonAplicativo.Checked)
        {
            FormAtualizarDeletarAplicativo formAtualizarAplicativo = new FormAtualizarDeletarAplicativo();
            formAtualizarAplicativo.ShowDialog();
        }
        if (radioButtonPlano.Checked)
        {
            FormAtualizarDeletarPlano formAtualizarPlano = new FormAtualizarDeletarPlano();
            formAtualizarPlano.ShowDialog();
        }
    }

    private void buttonExcluir_Click(object sender, EventArgs e)
    {
        if (radioButtonCliente.Checked)
        {
            FormAtualizarDeletarCliente formAtualizarDeletarCliente = new();
            formAtualizarDeletarCliente.Text = "Excluir cliente";
            formAtualizarDeletarCliente.buttonAtualizarCliente.Visible = false;
            formAtualizarDeletarCliente.buttonDeletarCliente.Visible = true;
            formAtualizarDeletarCliente.ShowDialog();
        }

        if (radioButtonRevendedor.Checked)
        {
            FormAtualizarDeletarRevendedor formAtualizarDeletarRevendedor = new();
            formAtualizarDeletarRevendedor.Text = "Excluir revendedor";
            formAtualizarDeletarRevendedor.buttonSalvarRevAtual.Visible = false;
            formAtualizarDeletarRevendedor.buttonDeletarRevendedor.Visible = true;
            formAtualizarDeletarRevendedor.ShowDialog();
        }
        if (radioButtonServidor.Checked)
        {
            FormAtualizarDeletarServidor formAtualizarDeletarServidor = new();
            formAtualizarDeletarServidor.Text = "Excuir servidor";
            formAtualizarDeletarServidor.buttonSalvarServAtualizado.Visible = false;
            formAtualizarDeletarServidor.buttonExcluirServidor.Visible = true;
            formAtualizarDeletarServidor.ShowDialog();
        }
        if (radioButtonAplicativo.Checked)
        {
            FormAtualizarDeletarAplicativo formAtualizarDeletarAplicativo = new();
            formAtualizarDeletarAplicativo.Text = "Excluir aplicativo";
            formAtualizarDeletarAplicativo.buttonSalvarAppAtualizado.Visible = false;
            formAtualizarDeletarAplicativo.buttonExcluirApp.Visible = true;
            formAtualizarDeletarAplicativo.ShowDialog();
        }
        if (radioButtonPlano.Checked)
        {
            FormAtualizarDeletarPlano formAtualizarDeletarPlano = new();
            formAtualizarDeletarPlano.Text = "Excluir plano";
            formAtualizarDeletarPlano.buttonSalvarPlanoAtualizado.Visible = false;
            formAtualizarDeletarPlano.buttonExcluirPlano.Visible = true;
            formAtualizarDeletarPlano.ShowDialog();
        }
    }

    private void buttonRegistroPagamentoCompra_Click(object sender, EventArgs e)
    {
        if (radioButtonCliente.Checked)//Cliente pagando
        {
            dataGridView.Visible = false;
            FormRegistraPagamentoCliente formRegistraPagamentoCliente = new();
            formRegistraPagamentoCliente.ShowDialog();
            
        }
        else if (radioButtonRevendedor.Checked)// Revendedor pagando
        {
            dataGridView.Visible = false;
            FormRegistroPagamentoRevendedor formRegistroPagamentoRevendedor = new();
            formRegistroPagamentoRevendedor.ShowDialog();
            
        }
        else if (radioButtonServidor.Checked) // Compra de crédito
        {
            dataGridView.Visible = false;
            FormRegistraCompraCredito formRegistraCompraCredito = new();
            formRegistraCompraCredito.ShowDialog();
        }
    }

    private void buttonExibirRegistro_Click(object sender, EventArgs e)
    {
        if (radioButtonCliente.Checked)//Busca todos registros Cliente
        {
            RegistroPagamentoClienteRepository rpcc = new();
            var registroPagClientes = rpcc.GetAll().ToList();

            if (registroPagClientes.Count == 0 || registroPagClientes == null)
            {
                dataGridView.Visible = false;
                MessageBox.Show("Não existe nenhum registro cadastrado!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView.Visible = true;
                dataGridView.DataSource = registroPagClientes;
                dataGridView.Columns["IdCliente"].Visible = false;
                dataGridView.Columns["IdAplicativo"].Visible = false;
                dataGridView.Columns["IdPlano"].Visible = false;
                dataGridView.Columns["IdServidor"].Visible = false;
                dataGridView.Columns["NomeCliente"].HeaderText = "Cliente";
                dataGridView.Columns["NomeAplicativo"].HeaderText = "Aplicativo";
                dataGridView.Columns["DescricaoPlano"].HeaderText = "Plano";
                dataGridView.Columns["NomeServidor"].HeaderText = "Servidor";
                dataGridView.Columns["QtdeTelas"].HeaderText = "Telas";
                dataGridView.Columns["QtdeMeses"].HeaderText = "Meses";
            }
        }
        else if (radioButtonCliente.Checked && checkBoxBuscaPorNome.Checked)//Busca todos registros Cliente por nome
        {

        }
        else if (radioButtonRevendedor.Checked && checkBoxBuscaPorNome.Checked)// Busca todos registros Revendedor por nome
        {

        }
        else if (radioButtonServidor.Checked && checkBoxBuscaPorNome.Checked) // Busca todos registros Servidor por nome
        {

        }
    }
}
