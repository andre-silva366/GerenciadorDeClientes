using GerenciadorDeClientes.Repositories;
using GerenciadorDeClientes.Views.Update;
using GerenciadorDeClientes.Views;
using GerenciadorDeClientes.Views.Insert;
using GerenciadorDeClientes.Models;
using System.Data;

namespace GerenciadorDeClientes;

public partial class FormTelaPrincipal : Form
{
    public FormTelaPrincipal()
    {
        InitializeComponent();
        TabelaSomaRepository tbsr = new();
        var tabelaSoma = tbsr.GetAll().ToList();
        if(tabelaSoma.Count > 0)
        {
            tbsr.AtualizarTabelaSoma();
        }        
        LucroAnualRepository lucroAnualRepository = new();
        var tabelaLucroAnual = lucroAnualRepository.GetAll().ToList();
        if(tabelaLucroAnual.Count > 0)
        {
            lucroAnualRepository.AtualizarLucroAnual();
        }
        
    }

    // Bot�o buscar (Get All)
    public void buttonBuscar_Click(object sender, EventArgs e)
    {
        if (radioButtonCliente.Checked)
        {
            ClienteRepository cliente = new ClienteRepository();
            var clientes = cliente.GetAll().ToList();
            if (clientes.Count == 0 || clientes == null)
            {
                dataGridView.Visible = false;
                MessageBox.Show("N�o existe nenhum cliente cadastrado!", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                dataGridView.Visible = false;
                MessageBox.Show("N�o existe nenhum plano cadastrado!", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("N�o existe nenhum revendedor cadastrado!", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("N�o existe nenhum servidor cadastrado!", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("N�o existe nenhum aplicativo cadastrado!", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView.Visible = true;
                dataGridView.DataSource = aplicativos;
            }

        }

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
                        MessageBox.Show($"N�o encontrado nenhum Cliente que comece com {nome} !", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show($"N�o encontrado nenhum Plano que comece com {nome} !", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show($"N�o encontrado nenhum Revendedor que comece com {nome} !", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show($"N�o encontrado nenhum Servidor que comece com {nome} !", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show($"N�o encontrado nenhum Aplicativo que comece com {nome}!", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        else if (radioButtonServidor.Checked) // Compra de cr�dito
        {
            dataGridView.Visible = false;
            FormRegistraCompraCredito formRegistraCompraCredito = new();
            formRegistraCompraCredito.ShowDialog();
        }
    }
    private void buttonExibirRegistro_Click(object sender, EventArgs e)
    {
        try
        {
            if (radioButtonCliente.Checked && checkBoxBuscaPorNome.Checked)//Busca todos registros Cliente por nome
            {
                RegistroPagamentoClienteRepository rpcc = new();
                var textboxNome = textBoxSelectNome.Text;
                var registroPagClientes = new List<RegistroPagamentoCliente>();

                if (textboxNome.Length > 0)
                {
                    registroPagClientes = rpcc.GetByName(textboxNome).ToList();
                    if (registroPagClientes.Count == 0 || registroPagClientes == null)
                    {
                        dataGridView.Visible = false;
                        MessageBox.Show($"N�o existe nenhum registro de cliente que comece com {textboxNome} !", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                else
                {
                    MessageBox.Show("Preencha o campo nome!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonCliente.Checked)//Busca todos registros Cliente
            {
                RegistroPagamentoClienteRepository rpcc = new();
                var registroPagClientes = rpcc.GetAll().ToList();

                if (registroPagClientes.Count == 0 || registroPagClientes == null)
                {
                    dataGridView.Visible = false;
                    MessageBox.Show("N�o existe nenhum registro cadastrado!", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    dataGridView.Columns["DataPagamento"].HeaderText = "Pagamento";
                    dataGridView.Columns["DataProximoPagamento"].HeaderText = "Vencimento";
                }
            }
            if (radioButtonRevendedor.Checked && checkBoxBuscaPorNome.Checked)// Busca todos registros Revendedor por nome
            {
                RegistroPagamentoRevendedorRepository rprr = new();
                var regPagPorNome = rprr.GetByName(textBoxSelectNome.Text).ToList();
                if (regPagPorNome.Count > 0 && regPagPorNome != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Visible = true;
                    dataGridView.DataSource = regPagPorNome;
                    dataGridView.Columns["IdRevendedor"].Visible = false;
                    dataGridView.Columns["IdServidor"].Visible = false;
                    dataGridView.Columns["NomeRevendedor"].HeaderText = "Revendedor";
                    dataGridView.Columns["NomeServidor"].HeaderText = "Servidor";
                    dataGridView.Columns["QtdeCreditos"].HeaderText = "Cr�ditos";
                    dataGridView.Columns["DataPagamento"].HeaderText = "Pagamento";
                }
                else
                {
                    MessageBox.Show($"N�o encontrado nenhum registro cujo revendedor comece com {textBoxSelectNome.Text}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonRevendedor.Checked) // Busca todos registros Revendedor
            {
                RegistroPagamentoRevendedorRepository rprr = new();
                var registroPagRevRep = rprr.GetAll().ToList();
                if (registroPagRevRep.Count > 0)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Visible = true;
                    dataGridView.DataSource = registroPagRevRep;
                    dataGridView.Columns["IdRevendedor"].Visible = false;
                    dataGridView.Columns["IdServidor"].Visible = false;
                    dataGridView.Columns["NomeRevendedor"].HeaderText = "Revendedor";
                    dataGridView.Columns["NomeServidor"].HeaderText = "Servidor";
                    dataGridView.Columns["QtdeCreditos"].HeaderText = "Cr�ditos";
                    dataGridView.Columns["DataPagamento"].HeaderText = "Pagamento";
                }
                else
                {
                    dataGridView.Visible = false;
                    MessageBox.Show("N�o existe nenhum registro cadastrado!", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (radioButtonServidor.Checked && checkBoxBuscaPorNome.Checked)// Busca todos registros Servidor  por nome
            {
                RegistroCompraCreditoRepository rccr = new();
                var rcc = rccr.GetByName(textBoxSelectNome.Text).ToList();
                if (rcc.Count > 0 && rcc != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Visible = true;
                    dataGridView.DataSource = rcc;
                    dataGridView.Columns["IdServidor"].Visible = false;
                    dataGridView.Columns["NomeServidor"].HeaderText = "Servidor";
                    dataGridView.Columns["QtdeCredito"].HeaderText = "Cr�ditos";
                    dataGridView.Columns["DataCompra"].HeaderText = "Compra";
                }
                else
                {
                    dataGridView.Visible = false;
                    MessageBox.Show($"N�o encontrado nenhum registro cujo servidor comece com {textBoxSelectNome.Text}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonServidor.Checked) // Busca todos registros Servidor
            {
                RegistroCompraCreditoRepository rccr = new();
                var rcc = rccr.GetAll().ToList();
                if (rcc.Count > 0 && rcc != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Visible = true;
                    dataGridView.DataSource = rcc;
                    dataGridView.Columns["IdServidor"].Visible = false;
                    dataGridView.Columns["NomeServidor"].HeaderText = "Servidor";
                    dataGridView.Columns["QtdeCredito"].HeaderText = "Cr�ditos";
                    dataGridView.Columns["DataCompra"].HeaderText = "Compra";
                }
                else
                {
                    dataGridView.Visible = false;
                    MessageBox.Show("N�o existe nenhum registro cadastrado!", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
    private void buttonLimpar_Click(object sender, EventArgs e)
    {
        dataGridView.Visible = false;
        textBoxSelectNome.Text = null;
        checkBoxBuscaPorNome.Checked = false;
    }

    private void buttonExibirTabelaSoma_Click(object sender, EventArgs e)
    {
        try
        {
            TabelaSomaRepository tbsr = new();
            tbsr.AtualizarTabelaSoma();

            var tabela = tbsr.GetAll().ToList();
            if (tabela.Count > 0)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView.Visible = true;
                dataGridView.DataSource = tabela;
            }
            else
            {
                dataGridView.Visible = false;
                MessageBox.Show($"N�o existe nenhum registro na tabela!", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonLucroAnual_Click(object sender, EventArgs e)
    {
        try
        {
            LucroAnualRepository lucroAnualRepository = new ();
            lucroAnualRepository.AtualizarLucroAnual();
            var tbLucroAnual = lucroAnualRepository.GetAll().ToList();

            if (tbLucroAnual.Count > 0)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView.Visible = true;
                dataGridView.DataSource = tbLucroAnual;
            }
            else
            {
                dataGridView.Visible = false;
                MessageBox.Show($"N�o existe nenhum registro na tabela!", "N�O ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}
