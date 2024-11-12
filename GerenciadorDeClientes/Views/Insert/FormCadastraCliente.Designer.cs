namespace GerenciadorDeClientes
{
    partial class FormCadastraCliente
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
            comboBoxPlano = new ComboBox();
            labelPlano = new Label();
            labelTelefone = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            labelDadosClientes = new Label();
            buttonSalvarCliente = new Button();
            buttonLimparCadastroCliente = new Button();
            maskedTextBoxTelefoneCliente = new MaskedTextBox();
            SuspendLayout();
            // 
            // comboBoxPlano
            // 
            comboBoxPlano.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPlano.FormattingEnabled = true;
            comboBoxPlano.Location = new Point(107, 202);
            comboBoxPlano.Name = "comboBoxPlano";
            comboBoxPlano.Size = new Size(308, 29);
            comboBoxPlano.TabIndex = 4;
            // 
            // labelPlano
            // 
            labelPlano.AutoSize = true;
            labelPlano.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlano.Location = new Point(11, 205);
            labelPlano.Name = "labelPlano";
            labelPlano.Size = new Size(62, 21);
            labelPlano.TabIndex = 41;
            labelPlano.Text = "Plano:  ";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefone.Location = new Point(12, 108);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(89, 21);
            labelTelefone.TabIndex = 37;
            labelTelefone.Text = "Telefone:   ";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(107, 154);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(308, 29);
            textBoxEmail.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(11, 157);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(60, 21);
            labelEmail.TabIndex = 35;
            labelEmail.Text = "Email:  ";
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNome.Location = new Point(107, 54);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(308, 29);
            textBoxNome.TabIndex = 0;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(12, 54);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(63, 21);
            labelNome.TabIndex = 33;
            labelNome.Text = "Nome: ";
            // 
            // labelDadosClientes
            // 
            labelDadosClientes.AutoSize = true;
            labelDadosClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDadosClientes.Location = new Point(11, 9);
            labelDadosClientes.Name = "labelDadosClientes";
            labelDadosClientes.Size = new Size(262, 25);
            labelDadosClientes.TabIndex = 32;
            labelDadosClientes.Text = "Preencha os dados do Cliente";
            // 
            // buttonSalvarCliente
            // 
            buttonSalvarCliente.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarCliente.Cursor = Cursors.Hand;
            buttonSalvarCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvarCliente.ForeColor = SystemColors.ButtonHighlight;
            buttonSalvarCliente.Location = new Point(251, 266);
            buttonSalvarCliente.Name = "buttonSalvarCliente";
            buttonSalvarCliente.Size = new Size(164, 61);
            buttonSalvarCliente.TabIndex = 10;
            buttonSalvarCliente.Text = "Salvar ";
            buttonSalvarCliente.UseVisualStyleBackColor = false;
            buttonSalvarCliente.Click += buttonSalvarCliente_Click;
            // 
            // buttonLimparCadastroCliente
            // 
            buttonLimparCadastroCliente.BackColor = Color.White;
            buttonLimparCadastroCliente.Cursor = Cursors.Hand;
            buttonLimparCadastroCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCadastroCliente.ForeColor = Color.Black;
            buttonLimparCadastroCliente.Location = new Point(11, 266);
            buttonLimparCadastroCliente.Name = "buttonLimparCadastroCliente";
            buttonLimparCadastroCliente.Size = new Size(164, 61);
            buttonLimparCadastroCliente.TabIndex = 11;
            buttonLimparCadastroCliente.Text = "Limpar";
            buttonLimparCadastroCliente.UseVisualStyleBackColor = false;
            buttonLimparCadastroCliente.Click += buttonLimparCadastroCliente_Click;
            // 
            // maskedTextBoxTelefoneCliente
            // 
            maskedTextBoxTelefoneCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxTelefoneCliente.Location = new Point(107, 107);
            maskedTextBoxTelefoneCliente.Mask = "(00) 00000 - 0000";
            maskedTextBoxTelefoneCliente.Name = "maskedTextBoxTelefoneCliente";
            maskedTextBoxTelefoneCliente.Size = new Size(308, 29);
            maskedTextBoxTelefoneCliente.TabIndex = 1;
            maskedTextBoxTelefoneCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // FormCadastraCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 352);
            Controls.Add(maskedTextBoxTelefoneCliente);
            Controls.Add(buttonLimparCadastroCliente);
            Controls.Add(buttonSalvarCliente);
            Controls.Add(comboBoxPlano);
            Controls.Add(labelPlano);
            Controls.Add(labelTelefone);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(labelDadosClientes);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(447, 391);
            MinimizeBox = false;
            MinimumSize = new Size(447, 391);
            Name = "FormCadastraCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelPlano;
        private Label labelTelefone;
        private Label labelEmail;
        private Label labelNome;
        private Label labelDadosClientes;
        private Button buttonSalvarCliente;
        public ComboBox comboBoxPlano;
        public TextBox textBoxNome;
        public TextBox textBoxEmail;
        private MaskedTextBox maskedTextBoxTelefoneCliente;
        public Button buttonLimparCadastroCliente;
    }
}