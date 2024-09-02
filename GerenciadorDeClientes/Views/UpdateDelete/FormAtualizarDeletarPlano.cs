using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes.Views.Update;

public partial class FormAtualizarDeletarPlano : Form
{
    public FormAtualizarDeletarPlano()
    {
        InitializeComponent();
    }

    private void buttonBuscarPlanoIdAtua_Click(object sender, EventArgs e)
    {
        try
        {
            int idPlano = int.Parse(textBoxIdPlanoAtual.Text);
            if (idPlano > 0)
            {
                PlanoRepository planoRepository = new PlanoRepository();
                var plano = planoRepository.GetById(idPlano);

                if (plano != null)
                {
                    textBoxDescrPlanoAtual.Text = plano.Descricao;
                    textBoxValorPlanoAtua.Text = plano.Valor.ToString();
                }
                else
                {
                    textBoxDescrPlanoAtual.Text = "";
                    textBoxValorPlanoAtua.Text = "";
                    MessageBox.Show($"Não encontrado plano de id: {idPlano}", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Id inválido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch
        {
            MessageBox.Show("Ocorreu um erro, verifque os campos !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonSalvarPlanoAtualizado_Click(object sender, EventArgs e)
    {
        try
        {
            int idPlano = int.Parse(textBoxIdPlanoAtual.Text);
            if (idPlano > 0)
            {
                PlanoRepository planoRepository = new PlanoRepository();
                var plano = planoRepository.GetById(idPlano);

                if (plano != null)
                {
                    plano.Descricao = textBoxDescrPlanoAtual.Text;
                    plano.Valor = decimal.Parse(textBoxValorPlanoAtua.Text);
                    planoRepository.Update(plano, idPlano);
                }
                else
                {
                    textBoxDescrPlanoAtual.Text = "";
                    MessageBox.Show($"Não encontrado plano de id: {idPlano}", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Id inválido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch
        {
            MessageBox.Show("Ocorreu um erro, verifque os campos !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonExcluirPlano_Click(object sender, EventArgs e)
    {
        try
        {
            int idPlano = int.Parse(textBoxIdPlanoAtual.Text);
            if (idPlano > 0)
            {
                PlanoRepository planoRepository = new ();
                var plano = planoRepository.GetById(idPlano);

                if (plano == null)
                {
                    MessageBox.Show($"Não encontrado plano com id: {idPlano}");
                }
                else
                {
                    planoRepository.Delete(idPlano);
                }
            }
        }
        catch
        {
            MessageBox.Show("Ocorreu um erro ao deletar o plano", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
