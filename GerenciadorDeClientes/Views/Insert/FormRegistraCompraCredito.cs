using GerenciadorDeClientes.Models;
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes.Views.Insert;

public partial class FormRegistraCompraCredito : Form
{
    public FormRegistraCompraCredito()
    {
        InitializeComponent();
        ServidorRepository servidorRepository = new();
        var servidores = servidorRepository.GetAll().ToList();
        List<string> listaServidores = [];
        if (servidores.Count > 0)
        {
            foreach (var servidor in servidores)
            {
                listaServidores.Add(servidor.Nome);
            }
        }
        comboBoxCompCredServ.DataSource = listaServidores;
        comboBoxCompCredServ.Text = "";
    }
    
    private void buttonRegCompcred_Click(object sender, EventArgs e)
    {
        try
        {
            RegistroCompraCredito registroCompraCredito = new();
            registroCompraCredito.NomeServidor = comboBoxCompCredServ.Text;
            registroCompraCredito.QtdeCredito = (int)numericUpDownPagQtdeCred.Value;
            registroCompraCredito.Valor = Decimal.Parse(textBoxValorCompCred.Text);
            registroCompraCredito.DataCompra = dateTimePickerCompCred.Value;

            RegistroCompraCreditoRepository registroCompraCreditoRepository = new();
            registroCompraCreditoRepository.Insert(registroCompraCredito);
            LimpaCampos();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro: {ex.Message}","ERRO",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LimpaCampos()
    {
        comboBoxCompCredServ.Text = "";
        numericUpDownPagQtdeCred.Value = 5;
        textBoxValorCompCred.Text = "";
        dateTimePickerCompCred.Value = DateTime.Now;
    }
}
