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
            textBoxDeviceKeySenha = new TextBox();
            textBoxMacEmail = new TextBox();
            label9 = new Label();
            label8 = new Label();
            comboBoxAplicativo = new ComboBox();
            label7 = new Label();
            comboBoxPlano = new ComboBox();
            labelPlano = new Label();
            labelServidor = new Label();
            comboBoxServidor = new ComboBox();
            labelTelefone = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            labelDadosClientes = new Label();
            label1 = new Label();
            dateTimePickerUltimoPagamento = new DateTimePicker();
            label2 = new Label();
            dateTimePickerProximoPagamento = new DateTimePicker();
            buttonSalvarCliente = new Button();
            buttonLimparCadastroCliente = new Button();
            maskedTextBoxTelefoneCliente = new MaskedTextBox();
            SuspendLayout();
            // 
            // textBoxDeviceKeySenha
            // 
            textBoxDeviceKeySenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDeviceKeySenha.Location = new Point(171, 407);
            textBoxDeviceKeySenha.Name = "textBoxDeviceKeySenha";
            textBoxDeviceKeySenha.Size = new Size(292, 29);
            textBoxDeviceKeySenha.TabIndex = 7;
            // 
            // textBoxMacEmail
            // 
            textBoxMacEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMacEmail.Location = new Point(107, 352);
            textBoxMacEmail.Name = "textBoxMacEmail";
            textBoxMacEmail.Size = new Size(308, 29);
            textBoxMacEmail.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(11, 410);
            label9.Name = "label9";
            label9.Size = new Size(153, 21);
            label9.TabIndex = 46;
            label9.Text = "Device Key/Senha:  ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 355);
            label8.Name = "label8";
            label8.Size = new Size(98, 21);
            label8.TabIndex = 45;
            label8.Text = "Mac/Email:  ";
            // 
            // comboBoxAplicativo
            // 
            comboBoxAplicativo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAplicativo.FormattingEnabled = true;
            comboBoxAplicativo.Location = new Point(107, 300);
            comboBoxAplicativo.Name = "comboBoxAplicativo";
            comboBoxAplicativo.Size = new Size(308, 29);
            comboBoxAplicativo.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 308);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 43;
            label7.Text = "Aplicativo:  ";
            // 
            // comboBoxPlano
            // 
            comboBoxPlano.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPlano.FormattingEnabled = true;
            comboBoxPlano.Location = new Point(107, 250);
            comboBoxPlano.Name = "comboBoxPlano";
            comboBoxPlano.Size = new Size(308, 29);
            comboBoxPlano.TabIndex = 4;
            // 
            // labelPlano
            // 
            labelPlano.AutoSize = true;
            labelPlano.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlano.Location = new Point(12, 258);
            labelPlano.Name = "labelPlano";
            labelPlano.Size = new Size(62, 21);
            labelPlano.TabIndex = 41;
            labelPlano.Text = "Plano:  ";
            // 
            // labelServidor
            // 
            labelServidor.AutoSize = true;
            labelServidor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelServidor.Location = new Point(12, 204);
            labelServidor.Name = "labelServidor";
            labelServidor.Size = new Size(82, 21);
            labelServidor.TabIndex = 40;
            labelServidor.Text = "Servidor: ";
            // 
            // comboBoxServidor
            // 
            comboBoxServidor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxServidor.FormattingEnabled = true;
            comboBoxServidor.Location = new Point(107, 201);
            comboBoxServidor.Name = "comboBoxServidor";
            comboBoxServidor.Size = new Size(308, 29);
            comboBoxServidor.TabIndex = 3;
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
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 458);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 49;
            label1.Text = "Data (ultimo pagamento)";
            // 
            // dateTimePickerUltimoPagamento
            // 
            dateTimePickerUltimoPagamento.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerUltimoPagamento.Location = new Point(218, 463);
            dateTimePickerUltimoPagamento.MaxDate = new DateTime(2100, 8, 27, 0, 0, 0, 0);
            dateTimePickerUltimoPagamento.MinDate = new DateTime(1960, 8, 27, 0, 0, 0, 0);
            dateTimePickerUltimoPagamento.Name = "dateTimePickerUltimoPagamento";
            dateTimePickerUltimoPagamento.Size = new Size(245, 23);
            dateTimePickerUltimoPagamento.TabIndex = 8;
            dateTimePickerUltimoPagamento.Value = new DateTime(2024, 8, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 512);
            label2.Name = "label2";
            label2.Size = new Size(213, 28);
            label2.TabIndex = 51;
            label2.Text = "Data (próximo pagamento)";
            // 
            // dateTimePickerProximoPagamento
            // 
            dateTimePickerProximoPagamento.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerProximoPagamento.Location = new Point(218, 511);
            dateTimePickerProximoPagamento.MaxDate = new DateTime(2100, 8, 27, 0, 0, 0, 0);
            dateTimePickerProximoPagamento.MinDate = new DateTime(1900, 8, 27, 0, 0, 0, 0);
            dateTimePickerProximoPagamento.Name = "dateTimePickerProximoPagamento";
            dateTimePickerProximoPagamento.Size = new Size(245, 23);
            dateTimePickerProximoPagamento.TabIndex = 9;
            dateTimePickerProximoPagamento.Value = new DateTime(2024, 8, 27, 0, 0, 0, 0);
            // 
            // buttonSalvarCliente
            // 
            buttonSalvarCliente.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarCliente.Cursor = Cursors.Hand;
            buttonSalvarCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvarCliente.ForeColor = SystemColors.ButtonHighlight;
            buttonSalvarCliente.Location = new Point(262, 593);
            buttonSalvarCliente.Name = "buttonSalvarCliente";
            buttonSalvarCliente.Size = new Size(201, 61);
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
            buttonLimparCadastroCliente.Location = new Point(12, 593);
            buttonLimparCadastroCliente.Name = "buttonLimparCadastroCliente";
            buttonLimparCadastroCliente.Size = new Size(201, 61);
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
            ClientSize = new Size(476, 666);
            Controls.Add(maskedTextBoxTelefoneCliente);
            Controls.Add(buttonLimparCadastroCliente);
            Controls.Add(buttonSalvarCliente);
            Controls.Add(dateTimePickerProximoPagamento);
            Controls.Add(label2);
            Controls.Add(dateTimePickerUltimoPagamento);
            Controls.Add(label1);
            Controls.Add(textBoxDeviceKeySenha);
            Controls.Add(textBoxMacEmail);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBoxAplicativo);
            Controls.Add(label7);
            Controls.Add(comboBoxPlano);
            Controls.Add(labelPlano);
            Controls.Add(labelServidor);
            Controls.Add(comboBoxServidor);
            Controls.Add(labelTelefone);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(labelDadosClientes);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(492, 705);
            MinimizeBox = false;
            MinimumSize = new Size(492, 705);
            Name = "FormCadastraCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label8;
        private Label label7;
        private Label labelPlano;
        private Label labelServidor;
        private Label labelTelefone;
        private Label labelEmail;
        private Label labelNome;
        private Label labelDadosClientes;
        private Label label1;
        public DateTimePicker dateTimePickerUltimoPagamento;
        private Label label2;
        public DateTimePicker dateTimePickerProximoPagamento;
        private Button buttonSalvarCliente;
        public ComboBox comboBoxPlano;
        public TextBox textBoxNome;
        public TextBox textBoxDeviceKeySenha;
        public TextBox textBoxMacEmail;
        public ComboBox comboBoxAplicativo;
        public ComboBox comboBoxServidor;
        public TextBox textBoxEmail;
        private MaskedTextBox maskedTextBoxTelefoneCliente;
        public Button buttonLimparCadastroCliente;
    }
}