
using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes.Views.Update;

public partial class FormAtualizarServidor : Form
{
    public FormAtualizarServidor()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        label1 = new Label();
        textBoxIdServidorAtual = new TextBox();
        label2 = new Label();
        label3 = new Label();
        textBoxNomeServidorAtual = new TextBox();
        buttonLimparCadAtuaServ = new Button();
        buttonSalvarServAtualizado = new Button();
        buttonBuscarServIdAtua = new Button();
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
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(12, 101);
        label2.Name = "label2";
        label2.Size = new Size(243, 21);
        label2.TabIndex = 2;
        label2.Text = "Altere as informações do servidor";
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
        buttonLimparCadAtuaServ.Location = new Point(12, 212);
        buttonLimparCadAtuaServ.Name = "buttonLimparCadAtuaServ";
        buttonLimparCadAtuaServ.Size = new Size(108, 49);
        buttonLimparCadAtuaServ.TabIndex = 5;
        buttonLimparCadAtuaServ.Text = "Limpar";
        buttonLimparCadAtuaServ.UseVisualStyleBackColor = true;
        // 
        // buttonSalvarRevAtualizado
        // 
        buttonSalvarServAtualizado.BackColor = Color.FromArgb(0, 192, 0);
        buttonSalvarServAtualizado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonSalvarServAtualizado.ForeColor = SystemColors.ButtonFace;
        buttonSalvarServAtualizado.Location = new Point(181, 212);
        buttonSalvarServAtualizado.Name = "buttonSalvarRevAtualizado";
        buttonSalvarServAtualizado.Size = new Size(108, 49);
        buttonSalvarServAtualizado.TabIndex = 6;
        buttonSalvarServAtualizado.Text = "Salvar";
        buttonSalvarServAtualizado.UseVisualStyleBackColor = false;
        buttonSalvarServAtualizado.Click += this.buttonSalvarServAtualizado_Click;
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
        // FormAtualizarServidor
        // 
        ClientSize = new Size(306, 273);
        Controls.Add(buttonBuscarServIdAtua);
        Controls.Add(buttonSalvarServAtualizado);
        Controls.Add(buttonLimparCadAtuaServ);
        Controls.Add(textBoxNomeServidorAtual);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(textBoxIdServidorAtual);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(322, 312);
        MinimizeBox = false;
        MinimumSize = new Size(322, 312);
        Name = "FormAtualizarServidor";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Atualização de Servidor";
        ResumeLayout(false);
        PerformLayout();
    }
    
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBoxNomeServidorAtual;
    private Button buttonLimparCadAtuaServ;
    private Button buttonSalvarServAtualizado;
    private Button buttonBuscarServIdAtua;
    private TextBox textBoxIdServidorAtual;

    private void buttonBuscarServIdAtua_Click(object? sender, EventArgs e)
    {
        try
        {
            int idServidor = int.Parse(textBoxIdServidorAtual.Text);

            if(idServidor > 0)
            {
                ServidorRepository servidorRepository = new ServidorRepository();
                var servidor = servidorRepository.GetById(idServidor);

                if(servidor == null)
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
            MessageBox.Show("Ocorreu um erro, verifique os campos!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    servidorRepository.Update(servidor, idServidor);
                }
            }
            else
            {
                MessageBox.Show("Id inválido !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Ocorreu um erro verifique os campos !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        
    }
}
