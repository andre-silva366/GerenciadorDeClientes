namespace GerenciadorDeClientes.Views.Update
{
    partial class FormAtualizarDeletarRevendedor
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
            textBoxAtualizarRevendedorId = new TextBox();
            buttonAtualizacaoBuscaRevendedorId = new Button();
            labelRevendedor = new Label();
            label4rev = new Label();
            textBoxNomeRevendaAtualizado = new TextBox();
            labelTelefonerev = new Label();
            maskedTextBoxTelefoneRevendaAtualizado = new MaskedTextBox();
            labelemailrev = new Label();
            textBoxEmailRevendaAtualizado = new TextBox();
            labelServidorAtualRev = new Label();
            comboBoxServidorRevendaAtualizado = new ComboBox();
            labelQtderev = new Label();
            numericUpDownQtdeRevAtual = new NumericUpDown();
            label2 = new Label();
            textBoxValorAtualRev = new TextBox();
            label3 = new Label();
            dateTimePickerUltimaCompraRevAtual = new DateTimePicker();
            buttonLimparCadastroAtualizaRev = new Button();
            buttonSalvarRevAtual = new Button();
            buttonDeletarRevendedor = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQtdeRevAtual).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(237, 31);
            label1.TabIndex = 1;
            label1.Text = "Digite o Id do revendedor:";
            // 
            // textBoxAtualizarRevendedorId
            // 
            textBoxAtualizarRevendedorId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAtualizarRevendedorId.Location = new Point(254, 20);
            textBoxAtualizarRevendedorId.Name = "textBoxAtualizarRevendedorId";
            textBoxAtualizarRevendedorId.Size = new Size(116, 29);
            textBoxAtualizarRevendedorId.TabIndex = 2;
            // 
            // buttonAtualizacaoBuscaRevendedorId
            // 
            buttonAtualizacaoBuscaRevendedorId.BackColor = Color.FromArgb(0, 192, 0);
            buttonAtualizacaoBuscaRevendedorId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAtualizacaoBuscaRevendedorId.ForeColor = SystemColors.ButtonFace;
            buttonAtualizacaoBuscaRevendedorId.Location = new Point(254, 55);
            buttonAtualizacaoBuscaRevendedorId.Name = "buttonAtualizacaoBuscaRevendedorId";
            buttonAtualizacaoBuscaRevendedorId.Size = new Size(116, 32);
            buttonAtualizacaoBuscaRevendedorId.TabIndex = 3;
            buttonAtualizacaoBuscaRevendedorId.Text = "Buscar";
            buttonAtualizacaoBuscaRevendedorId.UseVisualStyleBackColor = false;
            buttonAtualizacaoBuscaRevendedorId.Click += buttonAtualizacaoBuscaRevendedorId_Click;
            // 
            // labelRevendedor
            // 
            labelRevendedor.AutoSize = true;
            labelRevendedor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRevendedor.Location = new Point(11, 107);
            labelRevendedor.Name = "labelRevendedor";
            labelRevendedor.Size = new Size(194, 25);
            labelRevendedor.TabIndex = 65;
            labelRevendedor.Text = "Dados do revendedor";
            // 
            // label4rev
            // 
            label4rev.AutoSize = true;
            label4rev.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4rev.Location = new Point(12, 164);
            label4rev.Name = "label4rev";
            label4rev.Size = new Size(71, 21);
            label4rev.TabIndex = 76;
            label4rev.Text = "Nome:   ";
            // 
            // textBoxNomeRevendaAtualizado
            // 
            textBoxNomeRevendaAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomeRevendaAtualizado.Location = new Point(89, 161);
            textBoxNomeRevendaAtualizado.Name = "textBoxNomeRevendaAtualizado";
            textBoxNomeRevendaAtualizado.Size = new Size(282, 29);
            textBoxNomeRevendaAtualizado.TabIndex = 77;
            // 
            // labelTelefonerev
            // 
            labelTelefonerev.AutoSize = true;
            labelTelefonerev.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefonerev.Location = new Point(12, 215);
            labelTelefonerev.Name = "labelTelefonerev";
            labelTelefonerev.Size = new Size(89, 21);
            labelTelefonerev.TabIndex = 78;
            labelTelefonerev.Text = "Telefone:   ";
            // 
            // maskedTextBoxTelefoneRevendaAtualizado
            // 
            maskedTextBoxTelefoneRevendaAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxTelefoneRevendaAtualizado.Location = new Point(89, 212);
            maskedTextBoxTelefoneRevendaAtualizado.Mask = "(00) 00000 - 0000";
            maskedTextBoxTelefoneRevendaAtualizado.Name = "maskedTextBoxTelefoneRevendaAtualizado";
            maskedTextBoxTelefoneRevendaAtualizado.Size = new Size(282, 29);
            maskedTextBoxTelefoneRevendaAtualizado.TabIndex = 79;
            maskedTextBoxTelefoneRevendaAtualizado.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelemailrev
            // 
            labelemailrev.AutoSize = true;
            labelemailrev.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelemailrev.Location = new Point(12, 269);
            labelemailrev.Name = "labelemailrev";
            labelemailrev.Size = new Size(64, 21);
            labelemailrev.TabIndex = 80;
            labelemailrev.Text = "Email:   ";
            // 
            // textBoxEmailRevendaAtualizado
            // 
            textBoxEmailRevendaAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmailRevendaAtualizado.Location = new Point(89, 266);
            textBoxEmailRevendaAtualizado.Name = "textBoxEmailRevendaAtualizado";
            textBoxEmailRevendaAtualizado.Size = new Size(282, 29);
            textBoxEmailRevendaAtualizado.TabIndex = 81;
            // 
            // labelServidorAtualRev
            // 
            labelServidorAtualRev.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelServidorAtualRev.Location = new Point(11, 319);
            labelServidorAtualRev.Name = "labelServidorAtualRev";
            labelServidorAtualRev.Size = new Size(90, 21);
            labelServidorAtualRev.TabIndex = 82;
            labelServidorAtualRev.Text = "Servidor:   ";
            // 
            // comboBoxServidorRevendaAtualizado
            // 
            comboBoxServidorRevendaAtualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxServidorRevendaAtualizado.FormattingEnabled = true;
            comboBoxServidorRevendaAtualizado.Location = new Point(89, 316);
            comboBoxServidorRevendaAtualizado.Name = "comboBoxServidorRevendaAtualizado";
            comboBoxServidorRevendaAtualizado.Size = new Size(282, 29);
            comboBoxServidorRevendaAtualizado.TabIndex = 83;
            // 
            // labelQtderev
            // 
            labelQtderev.AutoSize = true;
            labelQtderev.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQtderev.Location = new Point(11, 434);
            labelQtderev.Name = "labelQtderev";
            labelQtderev.Size = new Size(111, 21);
            labelQtderev.TabIndex = 84;
            labelQtderev.Text = "Quantidade:   ";
            // 
            // numericUpDownQtdeRevAtual
            // 
            numericUpDownQtdeRevAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownQtdeRevAtual.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownQtdeRevAtual.Location = new Point(128, 432);
            numericUpDownQtdeRevAtual.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownQtdeRevAtual.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownQtdeRevAtual.Name = "numericUpDownQtdeRevAtual";
            numericUpDownQtdeRevAtual.Size = new Size(242, 29);
            numericUpDownQtdeRevAtual.TabIndex = 85;
            numericUpDownQtdeRevAtual.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 493);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 86;
            label2.Text = "Valor:   ";
            // 
            // textBoxValorAtualRev
            // 
            textBoxValorAtualRev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxValorAtualRev.Location = new Point(128, 485);
            textBoxValorAtualRev.Name = "textBoxValorAtualRev";
            textBoxValorAtualRev.Size = new Size(242, 29);
            textBoxValorAtualRev.TabIndex = 87;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 378);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 88;
            label3.Text = "Ultima compra:   ";
            // 
            // dateTimePickerUltimaCompraRevAtual
            // 
            dateTimePickerUltimaCompraRevAtual.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerUltimaCompraRevAtual.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerUltimaCompraRevAtual.Location = new Point(128, 378);
            dateTimePickerUltimaCompraRevAtual.MaxDate = new DateTime(2100, 8, 27, 0, 0, 0, 0);
            dateTimePickerUltimaCompraRevAtual.MinDate = new DateTime(1960, 8, 27, 0, 0, 0, 0);
            dateTimePickerUltimaCompraRevAtual.Name = "dateTimePickerUltimaCompraRevAtual";
            dateTimePickerUltimaCompraRevAtual.Size = new Size(243, 23);
            dateTimePickerUltimaCompraRevAtual.TabIndex = 89;
            dateTimePickerUltimaCompraRevAtual.Value = new DateTime(2024, 8, 27, 0, 0, 0, 0);
            // 
            // buttonLimparCadastroAtualizaRev
            // 
            buttonLimparCadastroAtualizaRev.BackColor = Color.White;
            buttonLimparCadastroAtualizaRev.Cursor = Cursors.Hand;
            buttonLimparCadastroAtualizaRev.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCadastroAtualizaRev.ForeColor = Color.Black;
            buttonLimparCadastroAtualizaRev.Location = new Point(13, 550);
            buttonLimparCadastroAtualizaRev.Name = "buttonLimparCadastroAtualizaRev";
            buttonLimparCadastroAtualizaRev.Size = new Size(150, 48);
            buttonLimparCadastroAtualizaRev.TabIndex = 90;
            buttonLimparCadastroAtualizaRev.Text = "Limpar";
            buttonLimparCadastroAtualizaRev.UseVisualStyleBackColor = false;
            buttonLimparCadastroAtualizaRev.Click += buttonLimparCadastroAtualizaRev_Click;
            // 
            // buttonSalvarRevAtual
            // 
            buttonSalvarRevAtual.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarRevAtual.Cursor = Cursors.Hand;
            buttonSalvarRevAtual.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvarRevAtual.ForeColor = Color.Transparent;
            buttonSalvarRevAtual.Location = new Point(220, 550);
            buttonSalvarRevAtual.Name = "buttonSalvarRevAtual";
            buttonSalvarRevAtual.Size = new Size(151, 48);
            buttonSalvarRevAtual.TabIndex = 91;
            buttonSalvarRevAtual.Text = "Salvar";
            buttonSalvarRevAtual.UseVisualStyleBackColor = false;
            buttonSalvarRevAtual.Click += buttonSalvarRevAtual_Click;
            // 
            // buttonDeletarRevendedor
            // 
            buttonDeletarRevendedor.BackColor = Color.Red;
            buttonDeletarRevendedor.Cursor = Cursors.Hand;
            buttonDeletarRevendedor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletarRevendedor.ForeColor = Color.Transparent;
            buttonDeletarRevendedor.Location = new Point(221, 550);
            buttonDeletarRevendedor.Name = "buttonDeletarRevendedor";
            buttonDeletarRevendedor.Size = new Size(150, 48);
            buttonDeletarRevendedor.TabIndex = 92;
            buttonDeletarRevendedor.Text = "Excluir";
            buttonDeletarRevendedor.UseVisualStyleBackColor = false;
            buttonDeletarRevendedor.Visible = false;
            buttonDeletarRevendedor.Click += buttonDeletarRevendedor_Click;
            // 
            // FormAtualizarDeletarRevendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 628);
            Controls.Add(buttonDeletarRevendedor);
            Controls.Add(buttonSalvarRevAtual);
            Controls.Add(buttonLimparCadastroAtualizaRev);
            Controls.Add(dateTimePickerUltimaCompraRevAtual);
            Controls.Add(label3);
            Controls.Add(textBoxValorAtualRev);
            Controls.Add(label2);
            Controls.Add(numericUpDownQtdeRevAtual);
            Controls.Add(labelQtderev);
            Controls.Add(comboBoxServidorRevendaAtualizado);
            Controls.Add(labelServidorAtualRev);
            Controls.Add(textBoxEmailRevendaAtualizado);
            Controls.Add(labelemailrev);
            Controls.Add(maskedTextBoxTelefoneRevendaAtualizado);
            Controls.Add(labelTelefonerev);
            Controls.Add(textBoxNomeRevendaAtualizado);
            Controls.Add(label4rev);
            Controls.Add(labelRevendedor);
            Controls.Add(buttonAtualizacaoBuscaRevendedorId);
            Controls.Add(textBoxAtualizarRevendedorId);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(445, 667);
            MinimizeBox = false;
            MinimumSize = new Size(411, 667);
            Name = "FormAtualizarDeletarRevendedor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar revendedor";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQtdeRevAtual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAtualizarRevendedorId;
        private Button buttonAtualizacaoBuscaRevendedorId;
        private Label label4rev;
        public TextBox textBoxNomeRevendaAtualizado;
        private Label labelTelefonerev;
        private MaskedTextBox maskedTextBoxTelefoneRevendaAtualizado;
        private Label labelemailrev;
        public TextBox textBoxEmailRevendaAtualizado;
        private Label labelServidorAtualRev;
        public ComboBox comboBoxServidorRevendaAtualizado;
        private Label labelQtderev;
        private NumericUpDown numericUpDownQtdeRevAtual;
        private Label label2;
        public TextBox textBoxValorAtualRev;
        private Label label3;
        public DateTimePicker dateTimePickerUltimaCompraRevAtual;
        public Button buttonLimparCadastroAtualizaRev;
        public Button buttonSalvarRevAtual;
        public Button buttonDeletarRevendedor;
        public Label labelRevendedor;
    }
}