using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes;

public partial class FormCadastraCliente : Form
{
    public FormCadastraCliente()
    {
        InitializeComponent();

        PlanoRepository planoRepository = new PlanoRepository();
        var planos = planoRepository.GetAll().ToList();
        List<string> nomePlanos = new List<string>();
        if (planos.Count > 0)
        {
            foreach (var item in planos)
            {
                nomePlanos.Add(item.Descricao);
            }
            comboBoxPlano.DataSource = nomePlanos;
        }
        else
        {
            nomePlanos.Add("");
            comboBoxPlano.DataSource = nomePlanos;
        }                    
        
    }

    public void buttonSalvarCliente_Click(object sender, EventArgs e)
    {
        try
        {
            Cliente cliente = new Cliente();
            cliente.Nome = textBoxNome.Text;
            cliente.Telefone = maskedTextBoxTelefoneCliente.Text;
            string email = textBoxEmail.Text ?? "";
            cliente.Email = email;

            PlanoRepository plano = new PlanoRepository();
            Plano planoCliente;
            if(comboBoxPlano.Text != "")
            {
                planoCliente = plano.GetByName(comboBoxPlano.Text).Single();
                cliente.IdPlano = planoCliente.Id;
            }
            else
            {
                cliente.IdPlano = 0;
            }

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
                textBoxNome.Text = "";
                maskedTextBoxTelefoneCliente.Text = "";
                textBoxEmail.Text = "";
                comboBoxPlano.Text = "";
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
        comboBoxPlano.Text = "";
    }


}


