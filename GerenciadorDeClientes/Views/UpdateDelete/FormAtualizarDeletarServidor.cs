
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes.Views.Update;

public partial class FormAtualizarDeletarServidor : Form
{
    public FormAtualizarDeletarServidor()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        label1 = new Label();
        textBoxIdServidorAtual = new TextBox();
        labelServidor = new Label();
        label3 = new Label();
        textBoxNomeServidorAtual = new TextBox();
        buttonLimparCadAtuaServ = new Button();
        buttonSalvarServAtualizado = new Button();
        buttonBuscarServIdAtua = new Button();
        buttonExcluirServidor = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(12, 19);
        label1.Name = "label1";
        label1.Size = new Size(171, 21);
        label1.TabIndex = 0;
        label1.Text = "Digite o id do servidor: ";
        // 
        // textBoxIdServidorAtual
        // 
        textBoxIdServidorAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBoxIdServidorAtual.Location = new Point(189, 11);
        textBoxIdServidorAtual.Name = "textBoxIdServidorAtual";
        textBoxIdServidorAtual.Size = new Size(100, 29);
        textBoxIdServidorAtual.TabIndex = 1;
        // 
        // labelServidor
        // 
        labelServidor.AutoSize = true;
        labelServidor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelServidor.Location = new Point(12, 101);
        labelServidor.Name = "labelServidor";
        labelServidor.Size = new Size(137, 21);
        labelServidor.TabIndex = 2;
        labelServidor.Text = "Dados do servidor";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(12, 148);
        label3.Name = "label3";
        label3.Size = new Size(60, 21);
        label3.TabIndex = 3;
        label3.Text = "Nome: ";
        // 
        // textBoxNomeServidorAtual
        // 
        textBoxNomeServidorAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBoxNomeServidorAtual.Location = new Point(78, 145);
        textBoxNomeServidorAtual.Name = "textBoxNomeServidorAtual";
        textBoxNomeServidorAtual.Size = new Size(211, 29);
        textBoxNomeServidorAtual.TabIndex = 4;
        // 
        // buttonLimparCadAtuaServ
        // 
        buttonLimparCadAtuaServ.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonLimparCadAtuaServ.Location = new Point(12, 201);
        buttonLimparCadAtuaServ.Name = "buttonLimparCadAtuaServ";
        buttonLimparCadAtuaServ.Size = new Size(95, 49);
        buttonLimparCadAtuaServ.TabIndex = 5;
        buttonLimparCadAtuaServ.Text = "Limpar";
        buttonLimparCadAtuaServ.UseVisualStyleBackColor = true;
        buttonLimparCadAtuaServ.Click += buttonLimparCadAtuaServ_Click;
        // 
        // buttonSalvarServAtualizado
        // 
        buttonSalvarServAtualizado.BackColor = Color.FromArgb(0, 192, 0);
        buttonSalvarServAtualizado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonSalvarServAtualizado.ForeColor = SystemColors.ButtonFace;
        buttonSalvarServAtualizado.Location = new Point(194, 201);
        buttonSalvarServAtualizado.Name = "buttonSalvarServAtualizado";
        buttonSalvarServAtualizado.Size = new Size(95, 49);
        buttonSalvarServAtualizado.TabIndex = 6;
        buttonSalvarServAtualizado.Text = "Salvar";
        buttonSalvarServAtualizado.UseVisualStyleBackColor = false;
        buttonSalvarServAtualizado.Click += buttonSalvarServAtualizado_Click;
        // 
        // buttonBuscarServIdAtua
        // 
        buttonBuscarServIdAtua.BackColor = Color.FromArgb(0, 192, 0);
        buttonBuscarServIdAtua.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonBuscarServIdAtua.ForeColor = SystemColors.ButtonFace;
        buttonBuscarServIdAtua.Location = new Point(189, 46);
        buttonBuscarServIdAtua.Name = "buttonBuscarServIdAtua";
        buttonBuscarServIdAtua.Size = new Size(100, 31);
        buttonBuscarServIdAtua.TabIndex = 7;
        buttonBuscarServIdAtua.Text = "Buscar";
        buttonBuscarServIdAtua.UseVisualStyleBackColor = false;
        buttonBuscarServIdAtua.Click += buttonBuscarServIdAtua_Click;
        // 
        // buttonExcluirServidor
        // 
        buttonExcluirServidor.BackColor = Color.Red;
        buttonExcluirServidor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonExcluirServidor.ForeColor = SystemColors.ButtonFace;
        buttonExcluirServidor.Location = new Point(194, 201);
        buttonExcluirServidor.Name = "buttonExcluirServidor";
        buttonExcluirServidor.Size = new Size(95, 49);
        buttonExcluirServidor.TabIndex = 8;
        buttonExcluirServidor.Text = "Excluir";
        buttonExcluirServidor.UseVisualStyleBackColor = false;
        buttonExcluirServidor.Visible = false;
        buttonExcluirServidor.Click += buttonExcluirServidor_Click;
        // 
        // FormAtualizarDeletarServidor
        // 
        ClientSize = new Size(304, 270);
        Controls.Add(buttonExcluirServidor);
        Controls.Add(buttonBuscarServIdAtua);
        Controls.Add(buttonSalvarServAtualizado);
        Controls.Add(buttonLimparCadAtuaServ);
        Controls.Add(textBoxNomeServidorAtual);
        Controls.Add(label3);
        Controls.Add(labelServidor);
        Controls.Add(textBoxIdServidorAtual);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(375, 312);
        MinimizeBox = false;
        Name = "FormAtualizarDeletarServidor";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Atualizar servidor";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    public Label labelServidor;
    private Label label3;
    private TextBox textBoxNomeServidorAtual;
    private Button buttonLimparCadAtuaServ;
    public Button buttonSalvarServAtualizado;
    private Button buttonBuscarServIdAtua;
    public Button buttonExcluirServidor;
    private TextBox textBoxIdServidorAtual;

    private void buttonBuscarServIdAtua_Click(object? sender, EventArgs e)
    {
        try
        {
            int idServidor = int.Parse(textBoxIdServidorAtual.Text);

            if (idServidor > 0)
            {
                ServidorRepository servidorRepository = new ServidorRepository();
                var servidor = servidorRepository.GetById(idServidor);

                if (servidor == null)
                {
                    textBoxNomeServidorAtual.Text = "";
                    MessageBox.Show($"Não encontrado servidor com id: {idServidor}!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBoxNomeServidorAtual.Text = servidor.Nome;
                }
            }
            else
            {
                MessageBox.Show("Id inválido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        catch (Exception)
        {
            MessageBox.Show("Ocorreu um erro, verifique os campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void buttonSalvarServAtualizado_Click(object? sender, EventArgs e)
    {
        try
        {
            int idServidor = int.Parse(textBoxIdServidorAtual.Text);

            if (idServidor > 0)
            {
                ServidorRepository servidorRepository = new ServidorRepository();
                var servidor = servidorRepository.GetById(idServidor);

                if (servidor == null)
                {
                    MessageBox.Show($"Não encontrado servidor com Id: {idServidor}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    servidor.Nome = textBoxNomeServidorAtual.Text;
                    textBoxIdServidorAtual.Text = "";
                    textBoxNomeServidorAtual.Text = "";
                    servidorRepository.Update(servidor, idServidor);
                }
            }
            else
            {
                MessageBox.Show("Id inválido !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro verifique os campos !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }

    private void buttonExcluirServidor_Click(object sender, EventArgs e)
    {
        try
        {
            int idServ = int.Parse(textBoxIdServidorAtual.Text);
            if (idServ > 0)
            {
                ServidorRepository servidorRepository = new();
                var servidor = servidorRepository.GetById(idServ);

                if (servidor == null)
                {
                    MessageBox.Show($"Não encontrado servidor com id: {idServ}");
                }
                else
                {
                    textBoxIdServidorAtual.Text = "";
                    textBoxNomeServidorAtual.Text = "";
                    servidorRepository.Delete(idServ);
                }
            }
        }
        catch
        {
            MessageBox.Show("Ocorreu um erro verifique os campos !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonLimparCadAtuaServ_Click(object sender, EventArgs e)
    {
        textBoxIdServidorAtual.Text = "";
        textBoxNomeServidorAtual.Text = "";
    }
}
