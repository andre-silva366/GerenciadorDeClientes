using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes;

public partial class FormCadastraCliente : Form
{
    public FormCadastraCliente()
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

        comboBoxPlano.DataSource = nomePlanos;
              
        
    }

    public void buttonSalvarCliente_Click(object sender, EventArgs e)
    {
        try
        {
            Cliente cliente = new Cliente();
            cliente.Nome = textBoxNome.Text;
            cliente.Telefone = maskedTextBoxTelefoneCliente.Text;
            cliente.Email = textBoxEmail.Text;

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
    }


}


