using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes.Views.Update;

public partial class FormAtualizarDeletarRevendedor : Form
{
    public FormAtualizarDeletarRevendedor()
    {
        InitializeComponent();
    }

    private void buttonAtualizacaoBuscaRevendedorId_Click(object sender, EventArgs e)
    {
        try
        {
            Revendedor revendedor = new();
            RevendedorRepository revendedorRepository = new();

            int idRevendedor = int.Parse(textBoxAtualizarRevendedorId.Text);

            if (idRevendedor > 0)
            {
                revendedor = revendedorRepository.GetById(idRevendedor);

                if (revendedor != null)
                {
                    textBoxNomeRevendaAtualizado.Text = revendedor.Nome;
                    maskedTextBoxTelefoneRevendaAtualizado.Text = revendedor.Telefone;
                    textBoxEmailRevendaAtualizado.Text = revendedor.Email;

                }
                else
                {
                    MessageBox.Show($"Não encontrado revendedor com id: {idRevendedor}", "NÃO ENCONTRADO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Digite um id válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro: \n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonSalvarRevAtual_Click(object sender, EventArgs e)
    {
        try
        {
            Revendedor revendedor = new Revendedor();
            RevendedorRepository revendedorRepository = new RevendedorRepository();

            int idRevendedor = int.Parse(textBoxAtualizarRevendedorId.Text);
            revendedor = revendedorRepository.GetById(idRevendedor);
            revendedor.Nome = textBoxNomeRevendaAtualizado.Text;
            revendedor.Telefone = maskedTextBoxTelefoneRevendaAtualizado.Text;
            revendedor.Email = textBoxEmailRevendaAtualizado.Text;

            if (revendedor.Nome.Length < 3)
            {
                MessageBox.Show("Preencha o Nome", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (revendedor.Telefone.Length < 11)
            {
                MessageBox.Show("Preencha o Telefone", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxAtualizarRevendedorId.Text = "";
                textBoxNomeRevendaAtualizado.Text = "";
                maskedTextBoxTelefoneRevendaAtualizado.Text = "";
                textBoxEmailRevendaAtualizado.Text = "";
                revendedorRepository.Update(revendedor, revendedor.Id);
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Ocorreu um erro verifique os campos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }

    private void buttonDeletarRevendedor_Click(object sender, EventArgs e)
    {
        try
        {
            int idRev = int.Parse(textBoxAtualizarRevendedorId.Text);
            if (idRev > 0)
            {
                RevendedorRepository revendedorRepository = new();
                var revendedor = revendedorRepository.GetById(idRev);

                if (revendedor == null)
                {
                    MessageBox.Show($"Não encontrado revendedor com id: {idRev}");
                }
                else
                {
                    textBoxAtualizarRevendedorId.Text = "";
                    textBoxNomeRevendaAtualizado.Text = "";
                    maskedTextBoxTelefoneRevendaAtualizado.Text = "";
                    textBoxEmailRevendaAtualizado.Text = "";
                    revendedorRepository.Delete(idRev);
                }
            }
        }
        catch
        {
            MessageBox.Show("Ocorreu um erro verifique os campos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonLimparCadastroAtualizaRev_Click(object sender, EventArgs e)
    {
        textBoxAtualizarRevendedorId.Text = "";
        textBoxNomeRevendaAtualizado.Text = "";
        maskedTextBoxTelefoneRevendaAtualizado.Text = "";
        textBoxEmailRevendaAtualizado.Text = "";
    }
}
