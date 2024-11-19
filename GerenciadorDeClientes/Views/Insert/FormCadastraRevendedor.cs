using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;
using System.Text.RegularExpressions;

namespace GerenciadorDeClientes;

public partial class FormCadastraRevendedor : Form
{
    public FormCadastraRevendedor()
    {
        InitializeComponent();        
    }

    private void buttonSalvarRevendedor_Click(object sender, EventArgs e)
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
                revendedor.Telefone = FormataTelefone(maskedTextBoxTelefoneRev.Text);
                revendedor.Email = textBoxEmailRev.Text;

                revendedorRepository.Insert(revendedor);
                buttonLimparCadastroRevendedor.PerformClick();
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

    private string FormataTelefone(string telefone)
    {
        telefone = Regex.Replace(telefone, @"\D", "");

        if (telefone.Length == 11)
        {
            return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)} - {telefone.Substring(7)}";
        }
        else if (telefone.Length == 10)
        {
            return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 4)} - {telefone.Substring(6)}";
        }
        else
        {
            return telefone;
        }
    }

}
