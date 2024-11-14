using GerenciadorDeClientes.Models;
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
                    numericUpDownDeletaPlanoValidadeEmMeses.Value = plano.Valor;
                    dateTimePickerDeletaPlanoUltimoPagamento.Value = plano.DataUltimoPagamento;
                    dateTimePickerDelPlanoProximoPagamento.Value = plano.DataUltimoPagamento.AddMonths((int)numericUpDownDeletaPlanoValidadeEmMeses.Value);

                    AplicativoRepository aplicativoRepository = new AplicativoRepository();
                    Aplicativo aplicativo;
                    aplicativo = aplicativoRepository.GetById(plano.IdAplicativo);
                    comboBoxAlterPlanoAplicativo.Text = aplicativo.Nome;

                    ClienteRepository clienteRepository = new ClienteRepository();
                    Cliente cliente;
                    cliente = clienteRepository.GetById(plano.IdCliente);
                    comboBoxAlterPlanoCliente.Text = cliente.Nome;

                    textBoxAlterPlanMacEmail.Text = plano.MacOuEmail;
                    textBoxAlterPlanKeySenha.Text = plano.DeviceKeyOuSenha;
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
                    plano.ValidadeEmMeses = (int) numericUpDownDeletaPlanoValidadeEmMeses.Value;
                    plano.DataUltimoPagamento = dateTimePickerDeletaPlanoUltimoPagamento.Value;
                    plano.DataProximoPagamento = dateTimePickerDeletaPlanoUltimoPagamento.Value.AddMonths((int)numericUpDownDeletaPlanoValidadeEmMeses.Value);

                    AplicativoRepository aplicativoRepository = new AplicativoRepository();
                    Aplicativo aplicativo;
                    aplicativo = aplicativoRepository.GetByName(comboBoxAlterPlanoAplicativo.Text).Single();
                    plano.IdAplicativo = aplicativo.Id;

                    ClienteRepository clienteRepository = new ClienteRepository();
                    Cliente cliente;
                    cliente = clienteRepository.GetByName(comboBoxAlterPlanoCliente.Text).Single();
                    plano.IdCliente = cliente.Id;

                    plano.MacOuEmail = textBoxAlterPlanMacEmail.Text;
                    plano.DeviceKeyOuSenha = textBoxAlterPlanKeySenha.Text;

                    planoRepository.Update(plano, idPlano);

                    textBoxDescrPlanoAtual.Text = "";
                    textBoxValorPlanoAtua.Text = "";
                    numericUpDownDeletaPlanoValidadeEmMeses.Value = 0;
                    dateTimePickerDeletaPlanoUltimoPagamento.Value = DateTime.Now;
                    dateTimePickerDeletaPlanoUltimoPagamento.Value = DateTime.Now.AddMonths(1);
                    comboBoxAlterPlanoAplicativo.Text = "";
                    comboBoxAlterPlanoCliente.Text = "";
                    textBoxAlterPlanMacEmail.Text = "";
                    textBoxAlterPlanKeySenha.Text = "";
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
                PlanoRepository planoRepository = new();
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
            MessageBox.Show("Ocorreu um erro, verifque os campos !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonLimparCadAtuaPlan_Click(object sender, EventArgs e)
    {
        textBoxIdPlanoAtual.Text = "";
        textBoxDescrPlanoAtual.Text = "";
        textBoxValorPlanoAtua.Text = "";
    }

    private void FormAtualizarDeletarPlano_Load(object sender, EventArgs e)
    {

    }
}
