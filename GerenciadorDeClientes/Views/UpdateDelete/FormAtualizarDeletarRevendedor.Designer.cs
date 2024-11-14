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
            buttonLimparCadastroAtualizaRev = new Button();
            buttonSalvarRevAtual = new Button();
            buttonDeletarRevendedor = new Button();
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
            // buttonLimparCadastroAtualizaRev
            // 
            buttonLimparCadastroAtualizaRev.BackColor = Color.White;
            buttonLimparCadastroAtualizaRev.Cursor = Cursors.Hand;
            buttonLimparCadastroAtualizaRev.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCadastroAtualizaRev.ForeColor = Color.Black;
            buttonLimparCadastroAtualizaRev.Location = new Point(11, 334);
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
            buttonSalvarRevAtual.Location = new Point(221, 407);
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
            buttonDeletarRevendedor.Location = new Point(221, 334);
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
            ClientSize = new Size(395, 483);
            Controls.Add(buttonDeletarRevendedor);
            Controls.Add(buttonSalvarRevAtual);
            Controls.Add(buttonLimparCadastroAtualizaRev);
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
            MaximumSize = new Size(411, 522);
            MinimizeBox = false;
            MinimumSize = new Size(411, 522);
            Name = "FormAtualizarDeletarRevendedor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar revendedor";
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
        public Button buttonLimparCadastroAtualizaRev;
        public Button buttonSalvarRevAtual;
        public Button buttonDeletarRevendedor;
        public Label labelRevendedor;
    }
}