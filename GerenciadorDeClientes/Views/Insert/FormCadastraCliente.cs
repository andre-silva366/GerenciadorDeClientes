using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes;

public partial class FormCadastraCliente : Form
{
    public FormCadastraCliente()
    {
        InitializeComponent();
        dateTimePickerUltimoPagamento.Value = DateTime.Now;
        dateTimePickerProximoPagamento.Value = DateTime.Now.AddMonths(1);

        ServidorRepository servidorRepository = new ServidorRepository();
        var servidores = servidorRepository.GetAll().ToList();
        List<string> nomeServidores = new List<string>();

        foreach (var item in servidores)
        {
            nomeServidores.Add(item.Nome);
        }

        comboBoxServidor.DataSource = nomeServidores;

        PlanoRepository planoRepository = new PlanoRepository();
        var planos = planoRepository.GetAll().ToList();

        List<string> nomePlanos = new List<string>();

        foreach (var item in planos)
        {
            nomePlanos.Add(item.Descricao);
        }

        comboBoxPlano.DataSource = nomePlanos;
        
        AplicativoRepository aplicativoRepository = new AplicativoRepository();
        var aplicativos = aplicativoRepository.GetAll().ToList();

        List<string> nomeAplicativos = new List<string>();

        foreach (var item in aplicativos)
        {
            nomeAplicativos.Add(item.Nome);
        }

        comboBoxAplicativo.DataSource = nomeAplicativos;
        
    }

    public void buttonSalvarCliente_Click(object sender, EventArgs e)
    {
        try
        {
            Cliente cliente = new Cliente();
            cliente.Nome = textBoxNome.Text;
            cliente.Telefone = maskedTextBoxTelefoneCliente.Text;
            cliente.Email = textBoxEmail.Text;
            cliente.DeviceKeyOuSenha = textBoxDeviceKeySenha.Text;
            cliente.MacOuEmail = textBoxMacEmail.Text;
            cliente.DataUltimoPagamento = dateTimePickerUltimoPagamento.Value;
            cliente.DataProximoPagamento = dateTimePickerProximoPagamento.Value;

            if (cliente.Nome.Length < 3)
            {
                throw new Exception("Preencha o Nome com no mínimo 3 caracteres!");             
            }
            if (cliente.Telefone.Length < 11)
            {
                throw new Exception("Preencha o Telefone com no mínimo 11 digitos!");           
            }
            else
            {
                ClienteRepository clienteRepository = new ClienteRepository();
                clienteRepository.Insert(cliente);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void buttonLimparCadastroCliente_Click(object sender, EventArgs e)
    {
        textBoxNome.Text = "";
        maskedTextBoxTelefoneCliente.Text = "";
        textBoxEmail.Text = "";
        textBoxMacEmail.Text = "";
        textBoxDeviceKeySenha.Text = "";
    }


}


