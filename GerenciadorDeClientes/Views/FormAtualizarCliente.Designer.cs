namespace GerenciadorDeClientes.Views
{
    partial class FormAtualizarCliente
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
            dateTimePickerProximoPagamentoCliAtual = new DateTimePicker();
            label2 = new Label();
            dateTimePickerUltimoPagamentoCliAtual = new DateTimePicker();
            label3 = new Label();
            textBoxDeviceKeySenhaClienteAtualizado = new TextBox();
            textBoxMacEmailClienteAtualizado = new TextBox();
            label9 = new Label();
            label8 = new Label();
            comboBoxAplicativoClienteAtualizado = new ComboBox();
            label7 = new Label();
            comboBoxPlanoClienteAtualizado = new ComboBox();
            labelPlano = new Label();
            labelServidor = new Label();
            comboBoxServidorClienteAtualizado = new ComboBox();
            labelTelefone = new Label();
            textBoxEmailClienteAtualizado = new TextBox();
            labelEmail = new Label();
            textBoxNomeClienteAtualizado = new TextBox();
            labelNome = new Label();
            labelDadosClientes = new Label();
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
            buttonLimparCadastroAtualizaCliente.Location = new Point(22, 667);
            buttonLimparCadastroAtualizaCliente.Name = "buttonLimparCadastroAtualizaCliente";
            buttonLimparCadastroAtualizaCliente.Size = new Size(201, 61);
            buttonLimparCadastroAtualizaCliente.TabIndex = 63;
            buttonLimparCadastroAtualizaCliente.Text = "Limpar";
            buttonLimparCadastroAtualizaCliente.UseVisualStyleBackColor = false;
            // 
            // buttonAtualizarCliente
            // 
            buttonAtualizarCliente.BackColor = Color.FromArgb(0, 192, 0);
            buttonAtualizarCliente.Cursor = Cursors.Hand;
            buttonAtualizarCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAtualizarCliente.ForeColor = SystemColors.ButtonHighlight;
            buttonAtualizarCliente.Location = new Point(272, 667);
            buttonAtualizarCliente.Name = "buttonAtualizarCliente";
            buttonAtualizarCliente.Size = new Size(201, 61);
            buttonAtualizarCliente.TabIndex = 62;
            buttonAtualizarCliente.Text = "Salvar ";
            buttonAtualizarCliente.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerProximoPagamentoCliAtual
            // 
            dateTimePickerProximoPagamentoCliAtual.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerProximoPagamentoCliAtual.Location = new Point(228, 585);
            dateTimePickerProximoPagamentoCliAtual.MaxDate = new DateTime(2100, 8, 27, 0, 0, 0, 0);
            dateTimePickerProximoPagamentoCliAtual.MinDate = new DateTime(1900, 8, 27, 0, 0, 0, 0);
            dateTimePickerProximoPagamentoCliAtual.Name = "dateTimePickerProximoPagamentoCliAtual";
            dateTimePickerProximoPagamentoCliAtual.Size = new Size(245, 23);
            dateTimePickerProximoPagamentoCliAtual.TabIndex = 61;
            dateTimePickerProximoPagamentoCliAtual.Value = new DateTime(2024, 8, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 586);
            label2.Name = "label2";
            label2.Size = new Size(213, 28);
            label2.TabIndex = 74;
            label2.Text = "Data (próximo pagamento)";
            // 
            // dateTimePickerUltimoPagamentoCliAtual
            // 
            dateTimePickerUltimoPagamentoCliAtual.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerUltimoPagamentoCliAtual.Location = new Point(228, 537);
            dateTimePickerUltimoPagamentoCliAtual.MaxDate = new DateTime(2100, 8, 27, 0, 0, 0, 0);
            dateTimePickerUltimoPagamentoCliAtual.MinDate = new DateTime(1960, 8, 27, 0, 0, 0, 0);
            dateTimePickerUltimoPagamentoCliAtual.Name = "dateTimePickerUltimoPagamentoCliAtual";
            dateTimePickerUltimoPagamentoCliAtual.Size = new Size(245, 23);
            dateTimePickerUltimoPagamentoCliAtual.TabIndex = 60;
            dateTimePickerUltimoPagamentoCliAtual.Value = new DateTime(2024, 8, 27, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 532);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 73;
            label3.Text = "Data (ultimo pagamento)";
            // 
            // textBoxDeviceKeySenhaClienteAtualizado
            // 
            textBoxDeviceKeySenhaClienteAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDeviceKeySenhaClienteAtualizado.Location = new Point(181, 481);
            textBoxDeviceKeySenhaClienteAtualizado.Name = "textBoxDeviceKeySenhaClienteAtualizado";
            textBoxDeviceKeySenhaClienteAtualizado.Size = new Size(292, 29);
            textBoxDeviceKeySenhaClienteAtualizado.TabIndex = 59;
            // 
            // textBoxMacEmailClienteAtualizado
            // 
            textBoxMacEmailClienteAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMacEmailClienteAtualizado.Location = new Point(117, 426);
            textBoxMacEmailClienteAtualizado.Name = "textBoxMacEmailClienteAtualizado";
            textBoxMacEmailClienteAtualizado.Size = new Size(308, 29);
            textBoxMacEmailClienteAtualizado.TabIndex = 58;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 484);
            label9.Name = "label9";
            label9.Size = new Size(153, 21);
            label9.TabIndex = 72;
            label9.Text = "Device Key/Senha:  ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 429);
            label8.Name = "label8";
            label8.Size = new Size(98, 21);
            label8.TabIndex = 71;
            label8.Text = "Mac/Email:  ";
            // 
            // comboBoxAplicativoClienteAtualizado
            // 
            comboBoxAplicativoClienteAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAplicativoClienteAtualizado.FormattingEnabled = true;
            comboBoxAplicativoClienteAtualizado.Location = new Point(117, 374);
            comboBoxAplicativoClienteAtualizado.Name = "comboBoxAplicativoClienteAtualizado";
            comboBoxAplicativoClienteAtualizado.Size = new Size(308, 29);
            comboBoxAplicativoClienteAtualizado.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 382);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 70;
            label7.Text = "Aplicativo:  ";
            // 
            // comboBoxPlanoClienteAtualizado
            // 
            comboBoxPlanoClienteAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPlanoClienteAtualizado.FormattingEnabled = true;
            comboBoxPlanoClienteAtualizado.Location = new Point(117, 324);
            comboBoxPlanoClienteAtualizado.Name = "comboBoxPlanoClienteAtualizado";
            comboBoxPlanoClienteAtualizado.Size = new Size(308, 29);
            comboBoxPlanoClienteAtualizado.TabIndex = 56;
            // 
            // labelPlano
            // 
            labelPlano.AutoSize = true;
            labelPlano.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlano.Location = new Point(22, 332);
            labelPlano.Name = "labelPlano";
            labelPlano.Size = new Size(62, 21);
            labelPlano.TabIndex = 69;
            labelPlano.Text = "Plano:  ";
            // 
            // labelServidor
            // 
            labelServidor.AutoSize = true;
            labelServidor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelServidor.Location = new Point(22, 278);
            labelServidor.Name = "labelServidor";
            labelServidor.Size = new Size(82, 21);
            labelServidor.TabIndex = 68;
            labelServidor.Text = "Servidor: ";
            // 
            // comboBoxServidorClienteAtualizado
            // 
            comboBoxServidorClienteAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxServidorClienteAtualizado.FormattingEnabled = true;
            comboBoxServidorClienteAtualizado.Location = new Point(117, 275);
            comboBoxServidorClienteAtualizado.Name = "comboBoxServidorClienteAtualizado";
            comboBoxServidorClienteAtualizado.Size = new Size(308, 29);
            comboBoxServidorClienteAtualizado.TabIndex = 55;
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
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(22, 128);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(63, 21);
            labelNome.TabIndex = 65;
            labelNome.Text = "Nome: ";
            // 
            // labelDadosClientes
            // 
            labelDadosClientes.AutoSize = true;
            labelDadosClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDadosClientes.Location = new Point(21, 83);
            labelDadosClientes.Name = "labelDadosClientes";
            labelDadosClientes.Size = new Size(233, 25);
            labelDadosClientes.TabIndex = 64;
            labelDadosClientes.Text = "Altere os dados do Cliente";
            // 
            // FormAtualizarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 754);
            Controls.Add(maskedTextBoxTelefoneClienteAtualizado);
            Controls.Add(buttonLimparCadastroAtualizaCliente);
            Controls.Add(buttonAtualizarCliente);
            Controls.Add(dateTimePickerProximoPagamentoCliAtual);
            Controls.Add(label2);
            Controls.Add(dateTimePickerUltimoPagamentoCliAtual);
            Controls.Add(label3);
            Controls.Add(textBoxDeviceKeySenhaClienteAtualizado);
            Controls.Add(textBoxMacEmailClienteAtualizado);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBoxAplicativoClienteAtualizado);
            Controls.Add(label7);
            Controls.Add(comboBoxPlanoClienteAtualizado);
            Controls.Add(labelPlano);
            Controls.Add(labelServidor);
            Controls.Add(comboBoxServidorClienteAtualizado);
            Controls.Add(labelTelefone);
            Controls.Add(textBoxEmailClienteAtualizado);
            Controls.Add(labelEmail);
            Controls.Add(textBoxNomeClienteAtualizado);
            Controls.Add(labelNome);
            Controls.Add(labelDadosClientes);
            Controls.Add(buttonAtualizacaoBuscaClienteId);
            Controls.Add(textBoxAtualizarClienteId);
            Controls.Add(label1);
            Name = "FormAtualizarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualização de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAtualizarClienteId;
        private Button buttonAtualizacaoBuscaClienteId;
        private MaskedTextBox maskedTextBoxTelefoneClienteAtualizado;
        public Button buttonLimparCadastroAtualizaCliente;
        private Button buttonAtualizarCliente;
        public DateTimePicker dateTimePickerProximoPagamentoCliAtual;
        private Label label2;
        public DateTimePicker dateTimePickerUltimoPagamentoCliAtual;
        private Label label3;
        public TextBox textBoxDeviceKeySenhaClienteAtualizado;
        public TextBox textBoxMacEmailClienteAtualizado;
        private Label label9;
        private Label label8;
        public ComboBox comboBoxAplicativoClienteAtualizado;
        private Label label7;
        public ComboBox comboBoxPlanoClienteAtualizado;
        private Label labelPlano;
        private Label labelServidor;
        public ComboBox comboBoxServidorClienteAtualizado;
        private Label labelTelefone;
        public TextBox textBoxEmailClienteAtualizado;
        private Label labelEmail;
        public TextBox textBoxNomeClienteAtualizado;
        private Label labelNome;
        private Label labelDadosClientes;
    }
}