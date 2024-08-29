using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes;

public partial class FormCadastraRevendedor : Form
{
    public FormCadastraRevendedor()
    {
        InitializeComponent();

        ServidorRepository servidorRepository = new ServidorRepository();

        var servidoresRepo = servidorRepository.GetAll().ToList();
        List<string> servidores = [];

        foreach (var item in servidoresRepo)
        {
            servidores.Add(item.Nome);
        }

        comboBoxServidorRev.DataSource = servidores;
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
                revendedor.DataUltimaCompra = dateTimePickerUltimaCompraRev.Value;
                revendedor.Quantidade = (int)numericUpDownQtdeCredRev.Value;
                revendedor.Valor = decimal.Parse(textBoxValorCompraRev.Text);

                revendedorRepository.Insert(revendedor);
            }
        }
        catch(Exception)
        {
            MessageBox.Show("Preencha os campos corretamente!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        
    }
}
