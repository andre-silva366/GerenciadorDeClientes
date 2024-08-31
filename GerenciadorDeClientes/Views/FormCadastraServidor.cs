using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes;

public partial class FormCadastraServidor : Form
{
    public FormCadastraServidor()
    {
        InitializeComponent();
    }

    private void buttonSalvarServidor_Click(object sender, EventArgs e)
    {
        if (textBoxNomeServidor.Text.Length >= 3)
        {
            Servidor servidor = new Servidor();
            ServidorRepository servidorRepository = new ServidorRepository();
            servidor.Nome = textBoxNomeServidor.Text;
            servidorRepository.Insert(servidor);

        }
        else
        {
            MessageBox.Show("Preencha o nome!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }    

    private void buttonLimparCadastroServidor_Click(object sender, EventArgs e)
    {
        textBoxNomeServidor.Text = "";
    }
}
