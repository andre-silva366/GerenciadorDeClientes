using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes.Views.Update;

public partial class FormAtualizarDeletarAplicativo : Form
{
    public FormAtualizarDeletarAplicativo()
    {
        InitializeComponent();
    }

    private void buttonBuscarAppIdAtua_Click(object sender, EventArgs e)
    {
        try
        {
            int idApp = int.Parse(textBoxIdAplicativoAtual.Text);
            if (idApp > 0)
            {
                AplicativoRepository appRepository = new AplicativoRepository();
                var app = appRepository.GetById(idApp);

                if (app != null)
                {
                    textBoxNomeAppAtual.Text = app.Nome;
                    textBoxAtuaDelSiteApp.Text = app.Site;
                }
                else
                {
                    textBoxNomeAppAtual.Text = "";
                    MessageBox.Show($"Não encontrado aplicativo de id: {idApp}", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void buttonSalvarAppAtualizado_Click(object sender, EventArgs e)
    {
        try
        {
            int idApp = int.Parse(textBoxIdAplicativoAtual.Text);
            if (idApp > 0)
            {
                AplicativoRepository appRepository = new AplicativoRepository();
                var app = appRepository.GetById(idApp);

                if (app != null)
                {
                    app.Nome = textBoxNomeAppAtual.Text;
                    app.Site = textBoxAtuaDelSiteApp.Text;
                    appRepository.Update(app, idApp);
                }
                else
                {
                    textBoxNomeAppAtual.Text = "";
                    MessageBox.Show($"Não encontrado aplicativo de id: {idApp}", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void buttonExcluirApp_Click(object sender, EventArgs e)
    {
        try
        {
            int idApp = int.Parse(textBoxIdAplicativoAtual.Text);
            if (idApp > 0)
            {
                AplicativoRepository aplicativoRepository = new AplicativoRepository();
                var aplicativo = aplicativoRepository.GetById(idApp);

                if (aplicativo == null)
                {
                    MessageBox.Show($"Não encontrado aplicativo com id: {idApp}");
                }
                else
                {
                    aplicativoRepository.Delete(idApp);
                }
            }
        }
        catch
        {
            MessageBox.Show("Ocorreu um erro ao deletar o aplicativo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonLimparCadAtuaApp_Click(object sender, EventArgs e)
    {
        textBoxIdAplicativoAtual.Text = "";
    }
}
