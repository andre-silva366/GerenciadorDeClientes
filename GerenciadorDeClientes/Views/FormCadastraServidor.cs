using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes;

public partial class FormCadastraServidor : Form
{
    private ServidorRepository _servidorRepository;
    private Servidor _servidor;

    public FormCadastraServidor()
    {
        InitializeComponent();

        _servidorRepository = new ServidorRepository();
        _servidor = new Servidor();
    }

    private void buttonSalvarServidor_Click(object sender, EventArgs e)
    {
        if (textBoxNomeServidor.Text.Length >= 3)
        {
            _servidor.Nome = textBoxNomeServidor.Text;
            _servidorRepository.Insert(_servidor);

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
