using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes;

public partial class FormCadastraAplicativo : Form
{
    public FormCadastraAplicativo()
    {
        InitializeComponent();        
    }

    private void buttonSalvarAplicativo_Click(object sender, EventArgs e)
    {
        if (textBoxNomeAplicativo.Text.Length >= 3)
        {
            Aplicativo aplicativo = new Aplicativo();
            AplicativoRepository appRepository = new AplicativoRepository();
            aplicativo.Nome = textBoxNomeAplicativo.Text;
            aplicativo.Site = textBoxCadastraSiteApp.Text;
            appRepository.Insert(aplicativo);
        }
        else
        {
            MessageBox.Show("Preencha o nome!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void buttonLimparCadastroAplicativo_Click(object sender, EventArgs e)
    {
        textBoxNomeAplicativo.Text = "";
        textBoxCadastraSiteApp.Text = "";        
    }
}
