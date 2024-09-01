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
        decimal valor = decimal.Parse(textBoxValorPlano.Text, CultureInfo.InvariantCulture);

        Plano plano = new Plano();
        PlanoRepository planoRepository = new PlanoRepository();

        try
        {
            if (descricao.Length < 6)
            {
                throw new Exception("Preencha a descrição do plano!");
            }
            else if (valor == 0)
            {
                throw new Exception("Preencha o valor!");
            }
            else
            {
                plano.Descricao = descricao;
                plano.Valor = valor;
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        planoRepository.Insert(plano);
    }

    private void buttonLimparPlano_Click(object sender, EventArgs e)
    {
        textBoxDescricaoPlano.Text = "";
        textBoxValorPlano.Text = "";
    }
}
