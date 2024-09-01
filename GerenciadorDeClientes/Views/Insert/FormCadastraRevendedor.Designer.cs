namespace GerenciadorDeClientes
{
    partial class FormCadastraRevendedor
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
            buttonLimparCadastroRevendedor = new Button();
            buttonSalvarCliente = new Button();
            dateTimePickerUltimaCompraRev = new DateTimePicker();
            label1 = new Label();
            label9 = new Label();
            label8 = new Label();
            labelServidor = new Label();
            comboBoxServidorRev = new ComboBox();
            labelTelefone = new Label();
            textBoxEmailRev = new TextBox();
            labelEmail = new Label();
            textBoxNomeRev = new TextBox();
            labelNome = new Label();
            labelDadosClientes = new Label();
            numericUpDownQtdeCredRev = new NumericUpDown();
            textBoxValorCompraRev = new TextBox();
            maskedTextBoxTelefoneRev = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQtdeCredRev).BeginInit();
            SuspendLayout();
            // 
            // buttonLimparCadastroRevendedor
            // 
            buttonLimparCadastroRevendedor.BackColor = Color.White;
            buttonLimparCadastroRevendedor.Cursor = Cursors.Hand;
            buttonLimparCadastroRevendedor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCadastroRevendedor.ForeColor = Color.Black;
            buttonLimparCadastroRevendedor.Location = new Point(13, 402);
            buttonLimparCadastroRevendedor.Name = "buttonLimparCadastroRevendedor";
            buttonLimparCadastroRevendedor.Size = new Size(201, 61);
            buttonLimparCadastroRevendedor.TabIndex = 8;
            buttonLimparCadastroRevendedor.Text = "Limpar";
            buttonLimparCadastroRevendedor.UseVisualStyleBackColor = false;
            buttonLimparCadastroRevendedor.Click += buttonLimparCadastroRevendedor_Click;
            // 
            // buttonSalvarCliente
            // 
            buttonSalvarCliente.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarCliente.Cursor = Cursors.Hand;
            buttonSalvarCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvarCliente.ForeColor = SystemColors.ButtonHighlight;
            buttonSalvarCliente.Location = new Point(263, 402);
            buttonSalvarCliente.Name = "buttonSalvarCliente";
            buttonSalvarCliente.Size = new Size(201, 61);
            buttonSalvarCliente.TabIndex = 7;
            buttonSalvarCliente.Text = "Salvar ";
            buttonSalvarCliente.UseVisualStyleBackColor = false;
            buttonSalvarCliente.Click += buttonSalvarCliente_Click;
            // 
            // dateTimePickerUltimaCompraRev
            // 
            dateTimePickerUltimaCompraRev.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerUltimaCompraRev.Location = new Point(172, 254);
            dateTimePickerUltimaCompraRev.MaxDate = new DateTime(2100, 8, 27, 0, 0, 0, 0);
            dateTimePickerUltimaCompraRev.MinDate = new DateTime(1960, 8, 27, 0, 0, 0, 0);
            dateTimePickerUltimaCompraRev.Name = "dateTimePickerUltimaCompraRev";
            dateTimePickerUltimaCompraRev.Size = new Size(245, 23);
            dateTimePickerUltimaCompraRev.TabIndex = 4;
            dateTimePickerUltimaCompraRev.Value = new DateTime(2024, 8, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 254);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 72;
            label1.Text = "Data (ultima compra):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 354);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 69;
            label9.Text = "Valor: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 302);
            label8.Name = "label8";
            label8.Size = new Size(103, 21);
            label8.TabIndex = 68;
            label8.Text = "Quantidade: ";
            // 
            // labelServidor
            // 
            labelServidor.AutoSize = true;
            labelServidor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelServidor.Location = new Point(13, 206);
            labelServidor.Name = "labelServidor";
            labelServidor.Size = new Size(82, 21);
            labelServidor.TabIndex = 63;
            labelServidor.Text = "Servidor: ";
            // 
            // comboBoxServidorRev
            // 
            comboBoxServidorRev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxServidorRev.FormattingEnabled = true;
            comboBoxServidorRev.Location = new Point(108, 203);
            comboBoxServidorRev.Name = "comboBoxServidorRev";
            comboBoxServidorRev.Size = new Size(308, 29);
            comboBoxServidorRev.TabIndex = 3;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefone.Location = new Point(13, 110);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(89, 21);
            labelTelefone.TabIndex = 60;
            labelTelefone.Text = "Telefone:   ";
            // 
            // textBoxEmailRev
            // 
            textBoxEmailRev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmailRev.Location = new Point(108, 156);
            textBoxEmailRev.Name = "textBoxEmailRev";
            textBoxEmailRev.Size = new Size(308, 29);
            textBoxEmailRev.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(12, 159);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(60, 21);
            labelEmail.TabIndex = 58;
            labelEmail.Text = "Email:  ";
            // 
            // textBoxNomeRev
            // 
            textBoxNomeRev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomeRev.Location = new Point(108, 56);
            textBoxNomeRev.Name = "textBoxNomeRev";
            textBoxNomeRev.Size = new Size(308, 29);
            textBoxNomeRev.TabIndex = 0;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(13, 56);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(63, 21);
            labelNome.TabIndex = 56;
            labelNome.Text = "Nome: ";
            // 
            // labelDadosClientes
            // 
            labelDadosClientes.AutoSize = true;
            labelDadosClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDadosClientes.Location = new Point(12, 11);
            labelDadosClientes.Name = "labelDadosClientes";
            labelDadosClientes.Size = new Size(303, 25);
            labelDadosClientes.TabIndex = 55;
            labelDadosClientes.Text = "Preencha os dados do Revendedor";
            // 
            // numericUpDownQtdeCredRev
            // 
            numericUpDownQtdeCredRev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownQtdeCredRev.Location = new Point(172, 300);
            numericUpDownQtdeCredRev.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownQtdeCredRev.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQtdeCredRev.Name = "numericUpDownQtdeCredRev";
            numericUpDownQtdeCredRev.Size = new Size(244, 29);
            numericUpDownQtdeCredRev.TabIndex = 5;
            numericUpDownQtdeCredRev.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxValorCompraRev
            // 
            textBoxValorCompraRev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxValorCompraRev.Location = new Point(172, 346);
            textBoxValorCompraRev.Name = "textBoxValorCompraRev";
            textBoxValorCompraRev.Size = new Size(245, 29);
            textBoxValorCompraRev.TabIndex = 6;
            // 
            // maskedTextBoxTelefoneRev
            // 
            maskedTextBoxTelefoneRev.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxTelefoneRev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxTelefoneRev.Location = new Point(108, 108);
            maskedTextBoxTelefoneRev.Mask = "(00) 90000 - 0000";
            maskedTextBoxTelefoneRev.Name = "maskedTextBoxTelefoneRev";
            maskedTextBoxTelefoneRev.Size = new Size(308, 29);
            maskedTextBoxTelefoneRev.TabIndex = 1;
            // 
            // FormCadastraRevendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 486);
            Controls.Add(maskedTextBoxTelefoneRev);
            Controls.Add(textBoxValorCompraRev);
            Controls.Add(numericUpDownQtdeCredRev);
            Controls.Add(buttonLimparCadastroRevendedor);
            Controls.Add(buttonSalvarCliente);
            Controls.Add(dateTimePickerUltimaCompraRev);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(labelServidor);
            Controls.Add(comboBoxServidorRev);
            Controls.Add(labelTelefone);
            Controls.Add(textBoxEmailRev);
            Controls.Add(labelEmail);
            Controls.Add(textBoxNomeRev);
            Controls.Add(labelNome);
            Controls.Add(labelDadosClientes);
            MaximizeBox = false;
            MaximumSize = new Size(492, 525);
            MinimizeBox = false;
            MinimumSize = new Size(492, 525);
            Name = "FormCadastraRevendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Revendedor";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQtdeCredRev).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLimparCadastroRevendedor;
        private Button buttonSalvarCliente;
        public DateTimePicker dateTimePickerUltimaCompraRev;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label labelServidor;
        public ComboBox comboBoxServidorRev;
        private Label labelTelefone;
        public TextBox textBoxEmailRev;
        private Label labelEmail;
        public TextBox textBoxNomeRev;
        private Label labelNome;
        private Label labelDadosClientes;
        private NumericUpDown numericUpDownQtdeCredRev;
        public TextBox textBoxValorCompraRev;
        public MaskedTextBox maskedTextBoxTelefoneRev;
    }
}