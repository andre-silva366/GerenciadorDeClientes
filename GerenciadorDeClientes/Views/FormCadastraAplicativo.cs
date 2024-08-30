using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes;

public partial class FormCadastraAplicativo : Form
{
    private AplicativoRepository _appRepository;
    private Aplicativo _aplicativo;

    public FormCadastraAplicativo()
    {
        InitializeComponent();
        _appRepository = new AplicativoRepository();
        _aplicativo = new Aplicativo();
    }

    private void buttonSalvarAplicativo_Click(object sender, EventArgs e)
    {
        if (textBoxNomeAplicativo.Text.Length >= 3)
        {
            _aplicativo.Nome = textBoxNomeAplicativo.Text;
            _appRepository.Insert(_aplicativo);
        }
        else
        {
            MessageBox.Show("Preencha o nome!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void buttonLimparCadastroAplicativo_Click(object sender, EventArgs e)
    {
        textBoxNomeAplicativo.Text = "";
    }
}
