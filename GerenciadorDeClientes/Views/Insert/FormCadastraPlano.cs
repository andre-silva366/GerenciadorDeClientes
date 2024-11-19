using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;
using System.Globalization;

namespace GerenciadorDeClientes;

public partial class FormCadastraPlano : Form
{
    public FormCadastraPlano()
    {
        InitializeComponent();
    }

    private void buttonSalvarPlano_Click(object sender, EventArgs e)
    {
        string descricao = textBoxDescricaoPlano.Text;
        Plano plano = new Plano();
        PlanoRepository planoRepository = new PlanoRepository();

        try
        {
            if (descricao.Length < 6)
            {
                throw new Exception("Preencha a descrição do plano!");
            }            
            else
            {
                plano.Descricao = descricao;
                planoRepository.Insert(plano);
                buttonLimparPlano.PerformClick();
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }

    private void buttonLimparPlano_Click(object sender, EventArgs e)
    {
        textBoxDescricaoPlano.Text = "";
    }
}
