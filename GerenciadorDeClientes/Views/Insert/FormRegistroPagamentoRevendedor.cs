using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes.Views.Insert;

public partial class FormRegistroPagamentoRevendedor : Form
{
    public FormRegistroPagamentoRevendedor()
    {
        InitializeComponent();
        LimparCampos();

        RevendedorRepository revendedorRepository = new RevendedorRepository();
        var revendedores = revendedorRepository.GetAll().ToList();
        List<string> listaRevendedores = new List<string>();

        if (revendedores.Count > 0)
        {
            foreach (var rev in revendedores)
            {
                listaRevendedores.Add(rev.Nome);
            }
        }
        comboBoxPagRevend.DataSource = listaRevendedores;
        comboBoxPagRevend.Text = "";
        ServidorRepository servidorRepository = new();
        var servidores = servidorRepository.GetAll().ToList();
        List<string> listaServidores = [];

        if (servidores.Count > 0)
        {
            foreach (var serv in servidores)
            {
                listaServidores.Add(serv.Nome);
            }
        }
        comboBoxPagServ.DataSource = listaServidores;
        comboBoxPagServ.Text = "";
    }
    private void buttonRegistrarPagRev_Click(object sender, EventArgs e)
    {
        try
        {
            RegistroPagamentoRevendedor regPagRev = new();
            regPagRev.NomeRevendedor = comboBoxPagRevend.Text;
            regPagRev.NomeServidor = comboBoxPagServ.Text;
            regPagRev.QtdeCreditos = (int)numericUpDownPagQtdeCreditos.Value;
            regPagRev.Valor = Decimal.Parse(textBoxValorPagRev.Text);
            regPagRev.DataPagamento = dateTimePickerDataPagRev.Value;

            RegistroPagamentoRevendedorRepository regPagRevRepo = new();
            regPagRevRepo.Insert(regPagRev);
            TabelaSomaRepository tbsr = new();
            tbsr.AtualizarTabelaSoma();
            LimparCampos();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}","ERRO",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LimparCampos()
    {
        comboBoxPagRevend.Text = "";
        comboBoxPagServ.Text = "";
        numericUpDownPagQtdeCreditos.Value = 5;
        textBoxValorPagRev.Text = "";
        dateTimePickerDataPagRev.Value = DateTime.Now;
        comboBoxPagRevend.Text = "";
        comboBoxPagServ.Text = "";
    }

}
