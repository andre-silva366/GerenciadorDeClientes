using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes;

public partial class FormCadastraRevendedor : Form
{
    public FormCadastraRevendedor()
    {
        InitializeComponent();        
    }

    private void buttonSalvarCliente_Click(object sender, EventArgs e)
    {
        try
        {
            RevendedorRepository revendedorRepository = new RevendedorRepository();

            if (textBoxNomeRev.Text.Length < 3)
            {
                MessageBox.Show("Digite o nome do Revendedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (maskedTextBoxTelefoneRev.Text.Length < 11)
            {
                MessageBox.Show("Digite o telefone do Revendedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Revendedor revendedor = new Revendedor();
                revendedor.Nome = textBoxNomeRev.Text;
                revendedor.Telefone = maskedTextBoxTelefoneRev.Text;
                revendedor.Email = textBoxEmailRev.Text;

                revendedorRepository.Insert(revendedor);

                textBoxNomeRev.Text = "";
                maskedTextBoxTelefoneRev.Text = "";
                textBoxEmailRev.Text = "";
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Preencha os campos corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void buttonLimparCadastroRevendedor_Click(object sender, EventArgs e)
    {
        textBoxNomeRev.Text = "";
        maskedTextBoxTelefoneRev.Text = "";
        textBoxEmailRev.Text = "";
    }

}
