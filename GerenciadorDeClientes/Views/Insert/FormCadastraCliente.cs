using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;
using System.Text.RegularExpressions;

namespace GerenciadorDeClientes;

public partial class FormCadastraCliente : Form
{
    public FormCadastraCliente()
    {
        InitializeComponent();       
    }

    public void buttonSalvarCliente_Click(object sender, EventArgs e)
    {
        try
        {
            Cliente cliente = new Cliente();
            cliente.Nome = textBoxNome.Text;
            cliente.Telefone = FormataTelefone(maskedTextBoxTelefoneCliente.Text);
            string email = textBoxEmail.Text ?? "";
            cliente.Email = email;

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
                buttonLimparCadastroCliente.PerformClick();
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

    private string FormataTelefone(string telefone)
    {
        telefone = Regex.Replace(telefone, @"\D", "");

        if(telefone.Length == 11)
        {
            return $"({telefone.Substring(0,2)}) {telefone.Substring(2,5)} - {telefone.Substring(7)}";
        }
        else if(telefone.Length == 10)
        {
            return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 4)} - {telefone.Substring(6)}";
        }
        else
        {
            return telefone;
        }
    }

}


