using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;
using System.Globalization;

namespace GerenciadorDeClientes;

public partial class FormCadastraPlano : Form
{
    private PlanoRepository _planoRepository;
    private Plano _plano;

    public FormCadastraPlano()
    {
        InitializeComponent();
        _planoRepository = new PlanoRepository();
        _plano = new Plano();
    }

    private void buttonSalvarPlano_Click(object sender, EventArgs e)
    {
        string descricao = textBoxDescricaoPlano.Text;
        decimal valor = decimal.Parse(textBoxValorPlano.Text, CultureInfo.InvariantCulture);

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
                _plano.Descricao = descricao;
                _plano.Valor = valor;
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        _planoRepository.Insert(_plano);
    }

    private void buttonLimparPlano_Click(object sender, EventArgs e)
    {
        textBoxDescricaoPlano.Text = "";
        textBoxValorPlano.Text = "";
    }
}
