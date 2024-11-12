namespace GerenciadorDeClientes.Views
{
    partial class FormAtualizarDeletarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxAtualizarClienteId = new TextBox();
            buttonAtualizacaoBuscaClienteId = new Button();
            maskedTextBoxTelefoneClienteAtualizado = new MaskedTextBox();
            buttonLimparCadastroAtualizaCliente = new Button();
            buttonAtualizarCliente = new Button();
            comboBoxPlanoClienteAtualizado = new ComboBox();
            labelPlano = new Label();
            labelTelefone = new Label();
            textBoxEmailClienteAtualizado = new TextBox();
            labelEmail = new Label();
            textBoxNomeClienteAtualizado = new TextBox();
            labelCliente = new Label();
            label4 = new Label();
            buttonDeletarCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(211, 31);
            label1.TabIndex = 0;
            label1.Text = "Digite o Id do cliente:";
            // 
            // textBoxAtualizarClienteId
            // 
            textBoxAtualizarClienteId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAtualizarClienteId.Location = new Point(228, 17);
            textBoxAtualizarClienteId.Name = "textBoxAtualizarClienteId";
            textBoxAtualizarClienteId.Size = new Size(116, 29);
            textBoxAtualizarClienteId.TabIndex = 1;
            // 
            // buttonAtualizacaoBuscaClienteId
            // 
            buttonAtualizacaoBuscaClienteId.BackColor = Color.FromArgb(0, 192, 0);
            buttonAtualizacaoBuscaClienteId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAtualizacaoBuscaClienteId.ForeColor = SystemColors.ButtonFace;
            buttonAtualizacaoBuscaClienteId.Location = new Point(357, 17);
            buttonAtualizacaoBuscaClienteId.Name = "buttonAtualizacaoBuscaClienteId";
            buttonAtualizacaoBuscaClienteId.Size = new Size(116, 32);
            buttonAtualizacaoBuscaClienteId.TabIndex = 2;
            buttonAtualizacaoBuscaClienteId.Text = "Buscar";
            buttonAtualizacaoBuscaClienteId.UseVisualStyleBackColor = false;
            buttonAtualizacaoBuscaClienteId.Click += buttonAtualizacaoBuscaClienteId_Click;
            // 
            // maskedTextBoxTelefoneClienteAtualizado
            // 
            maskedTextBoxTelefoneClienteAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxTelefoneClienteAtualizado.Location = new Point(117, 181);
            maskedTextBoxTelefoneClienteAtualizado.Mask = "(00) 00000 - 0000";
            maskedTextBoxTelefoneClienteAtualizado.Name = "maskedTextBoxTelefoneClienteAtualizado";
            maskedTextBoxTelefoneClienteAtualizado.Size = new Size(308, 29);
            maskedTextBoxTelefoneClienteAtualizado.TabIndex = 53;
            maskedTextBoxTelefoneClienteAtualizado.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonLimparCadastroAtualizaCliente
            // 
            buttonLimparCadastroAtualizaCliente.BackColor = Color.White;
            buttonLimparCadastroAtualizaCliente.Cursor = Cursors.Hand;
            buttonLimparCadastroAtualizaCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCadastroAtualizaCliente.ForeColor = Color.Black;
            buttonLimparCadastroAtualizaCliente.Location = new Point(22, 324);
            buttonLimparCadastroAtualizaCliente.Name = "buttonLimparCadastroAtualizaCliente";
            buttonLimparCadastroAtualizaCliente.Size = new Size(163, 49);
            buttonLimparCadastroAtualizaCliente.TabIndex = 63;
            buttonLimparCadastroAtualizaCliente.Text = "Limpar";
            buttonLimparCadastroAtualizaCliente.UseVisualStyleBackColor = false;
            buttonLimparCadastroAtualizaCliente.Click += buttonLimparCadastroAtualizaCliente_Click;
            // 
            // buttonAtualizarCliente
            // 
            buttonAtualizarCliente.BackColor = Color.FromArgb(0, 192, 0);
            buttonAtualizarCliente.Cursor = Cursors.Hand;
            buttonAtualizarCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAtualizarCliente.ForeColor = SystemColors.ButtonHighlight;
            buttonAtualizarCliente.Location = new Point(262, 324);
            buttonAtualizarCliente.Name = "buttonAtualizarCliente";
            buttonAtualizarCliente.Size = new Size(163, 49);
            buttonAtualizarCliente.TabIndex = 62;
            buttonAtualizarCliente.Text = "Salvar ";
            buttonAtualizarCliente.UseVisualStyleBackColor = false;
            buttonAtualizarCliente.Click += buttonAtualizarCliente_Click;
            // 
            // comboBoxPlanoClienteAtualizado
            // 
            comboBoxPlanoClienteAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPlanoClienteAtualizado.FormattingEnabled = true;
            comboBoxPlanoClienteAtualizado.Location = new Point(117, 276);
            comboBoxPlanoClienteAtualizado.Name = "comboBoxPlanoClienteAtualizado";
            comboBoxPlanoClienteAtualizado.Size = new Size(308, 29);
            comboBoxPlanoClienteAtualizado.TabIndex = 56;
            // 
            // labelPlano
            // 
            labelPlano.AutoSize = true;
            labelPlano.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlano.Location = new Point(22, 284);
            labelPlano.Name = "labelPlano";
            labelPlano.Size = new Size(62, 21);
            labelPlano.TabIndex = 69;
            labelPlano.Text = "Plano:  ";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefone.Location = new Point(22, 182);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(89, 21);
            labelTelefone.TabIndex = 67;
            labelTelefone.Text = "Telefone:   ";
            // 
            // textBoxEmailClienteAtualizado
            // 
            textBoxEmailClienteAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmailClienteAtualizado.Location = new Point(117, 228);
            textBoxEmailClienteAtualizado.Name = "textBoxEmailClienteAtualizado";
            textBoxEmailClienteAtualizado.Size = new Size(308, 29);
            textBoxEmailClienteAtualizado.TabIndex = 54;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(21, 231);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(60, 21);
            labelEmail.TabIndex = 66;
            labelEmail.Text = "Email:  ";
            // 
            // textBoxNomeClienteAtualizado
            // 
            textBoxNomeClienteAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomeClienteAtualizado.Location = new Point(117, 128);
            textBoxNomeClienteAtualizado.Name = "textBoxNomeClienteAtualizado";
            textBoxNomeClienteAtualizado.Size = new Size(308, 29);
            textBoxNomeClienteAtualizado.TabIndex = 52;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCliente.Location = new Point(21, 83);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(153, 25);
            labelCliente.TabIndex = 64;
            labelCliente.Text = "Dados do cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 131);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 75;
            label4.Text = "Nome:   ";
            // 
            // buttonDeletarCliente
            // 
            buttonDeletarCliente.BackColor = Color.Red;
            buttonDeletarCliente.Cursor = Cursors.Hand;
            buttonDeletarCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletarCliente.ForeColor = SystemColors.ButtonHighlight;
            buttonDeletarCliente.Location = new Point(262, 388);
            buttonDeletarCliente.Name = "buttonDeletarCliente";
            buttonDeletarCliente.Size = new Size(163, 49);
            buttonDeletarCliente.TabIndex = 76;
            buttonDeletarCliente.Text = "Excluir";
            buttonDeletarCliente.UseVisualStyleBackColor = false;
            buttonDeletarCliente.Visible = false;
            buttonDeletarCliente.Click += buttonDeletarCliente_Click;
            // 
            // FormAtualizarDeletarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 464);
            Controls.Add(buttonDeletarCliente);
            Controls.Add(label4);
            Controls.Add(maskedTextBoxTelefoneClienteAtualizado);
            Controls.Add(buttonLimparCadastroAtualizaCliente);
            Controls.Add(buttonAtualizarCliente);
            Controls.Add(comboBoxPlanoClienteAtualizado);
            Controls.Add(labelPlano);
            Controls.Add(labelTelefone);
            Controls.Add(textBoxEmailClienteAtualizado);
            Controls.Add(labelEmail);
            Controls.Add(textBoxNomeClienteAtualizado);
            Controls.Add(labelCliente);
            Controls.Add(buttonAtualizacaoBuscaClienteId);
            Controls.Add(textBoxAtualizarClienteId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(502, 503);
            MinimizeBox = false;
            MinimumSize = new Size(502, 503);
            Name = "FormAtualizarDeletarCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar/Deletar cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAtualizarClienteId;
        private Button buttonAtualizacaoBuscaClienteId;
        private MaskedTextBox maskedTextBoxTelefoneClienteAtualizado;
        public Button buttonLimparCadastroAtualizaCliente;
        public ComboBox comboBoxPlanoClienteAtualizado;
        private Label labelPlano;
        private Label labelTelefone;
        public TextBox textBoxEmailClienteAtualizado;
        private Label labelEmail;
        public TextBox textBoxNomeClienteAtualizado;
        private Label label4;
        public Button buttonDeletarCliente;
        public Button buttonAtualizarCliente;
        public Label labelCliente;
    }
}