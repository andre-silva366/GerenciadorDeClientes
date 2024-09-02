using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes.Views.Update;

public partial class FormAtualizarAplicativo : Form
{
    public FormAtualizarAplicativo()
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
                    appRepository.Update(app,idApp);
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
}
