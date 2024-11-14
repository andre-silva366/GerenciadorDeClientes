using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;
using System.Globalization;

namespace GerenciadorDeClientes;

public partial class FormCadastraPlano : Form
{
    public FormCadastraPlano()
    {
        InitializeComponent();
        
    }

    private void buttonSalvarPlano_Click(object sender, EventArgs e)
    {
        string descricao = textBoxDescricaoPlano.Text;

        AplicativoRepository aplicativoRepository = new AplicativoRepository();
        var aplicativos = aplicativoRepository.GetAll();
        List<string> nomesAplicativo = null;
        if (aplicativos!= null && aplicativos.Count() > 0)
        {
            foreach (var app in aplicativos)
            {
                nomesAplicativo.Add(app.Nome);
            }
            comboBoxPlanoAplicativo.DataSource = nomesAplicativo;
        }
        else
        {
            comboBoxPlanoAplicativo.Text = "";
        }
        
        ClienteRepository clienteRepository = new ClienteRepository();
        var clientes = clienteRepository.GetAll();
        List<string> nomesClientes = null;
        if (clientes != null && clientes.Count() > 0)
        {
            foreach (var cliente in clientes)
            {
                nomesClientes.Add(cliente.Nome);
            }
            comboBoxPlanoCliente.DataSource = nomesClientes;
        }
        else
        {
            comboBoxPlanoCliente.Text = "";
        }

        Plano plano = new Plano();
        PlanoRepository planoRepository = new PlanoRepository();

        try
        {
            if (descricao.Length < 6)
            {
                throw new Exception("Preencha a descrição do plano!");
            }            
            else
            {
                plano.Descricao = descricao;
                var appEscolhido = aplicativoRepository.GetByName(comboBoxPlanoAplicativo.Text).Single();
                plano.IdAplicativo = appEscolhido.Id;
                var cliente =  clienteRepository.GetByName(comboBoxPlanoCliente.Text).Single();
                plano.IdCliente = cliente.Id;
                plano.MacOuEmail = textBoxCadPlanoMacEmail.Text;
                plano.DeviceKeyOuSenha = textBoxCadPlanoKeySenha.Text;
                planoRepository.Insert(plano);

                textBoxDescricaoPlano.Text = "";
                comboBoxPlanoAplicativo.Text = "";
                comboBoxPlanoCliente.Text = "";
                textBoxCadPlanoMacEmail.Text = "";
                textBoxCadPlanoKeySenha.Text = "";
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }

    private void buttonLimparPlano_Click(object sender, EventArgs e)
    {
        textBoxDescricaoPlano.Text = "";
        comboBoxPlanoAplicativo.Text = "";
        comboBoxPlanoCliente.Text = "";
        textBoxCadPlanoMacEmail.Text = "";
        textBoxCadPlanoKeySenha.Text = "";
    }
}
