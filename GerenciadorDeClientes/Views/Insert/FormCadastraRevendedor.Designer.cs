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
            buttonSalvarRevendedor = new Button();
            labelTelefone = new Label();
            textBoxEmailRev = new TextBox();
            labelEmail = new Label();
            textBoxNomeRev = new TextBox();
            labelNome = new Label();
            labelDadosClientes = new Label();
            maskedTextBoxTelefoneRev = new MaskedTextBox();
            SuspendLayout();
            // 
            // buttonLimparCadastroRevendedor
            // 
            buttonLimparCadastroRevendedor.Anchor = AnchorStyles.None;
            buttonLimparCadastroRevendedor.BackColor = Color.White;
            buttonLimparCadastroRevendedor.Cursor = Cursors.Hand;
            buttonLimparCadastroRevendedor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCadastroRevendedor.ForeColor = Color.Black;
            buttonLimparCadastroRevendedor.Location = new Point(13, 232);
            buttonLimparCadastroRevendedor.Name = "buttonLimparCadastroRevendedor";
            buttonLimparCadastroRevendedor.Size = new Size(153, 68);
            buttonLimparCadastroRevendedor.TabIndex = 8;
            buttonLimparCadastroRevendedor.Text = "Limpar";
            buttonLimparCadastroRevendedor.UseVisualStyleBackColor = false;
            buttonLimparCadastroRevendedor.Click += buttonLimparCadastroRevendedor_Click;
            // 
            // buttonSalvarRevendedor
            // 
            buttonSalvarRevendedor.Anchor = AnchorStyles.None;
            buttonSalvarRevendedor.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarRevendedor.Cursor = Cursors.Hand;
            buttonSalvarRevendedor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvarRevendedor.ForeColor = SystemColors.ButtonHighlight;
            buttonSalvarRevendedor.Location = new Point(263, 232);
            buttonSalvarRevendedor.Name = "buttonSalvarRevendedor";
            buttonSalvarRevendedor.Size = new Size(153, 68);
            buttonSalvarRevendedor.TabIndex = 7;
            buttonSalvarRevendedor.Text = "Salvar ";
            buttonSalvarRevendedor.UseVisualStyleBackColor = false;
            buttonSalvarRevendedor.Click += buttonSalvarRevendedor_Click;
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
            ClientSize = new Size(451, 330);
            Controls.Add(maskedTextBoxTelefoneRev);
            Controls.Add(buttonLimparCadastroRevendedor);
            Controls.Add(buttonSalvarRevendedor);
            Controls.Add(labelTelefone);
            Controls.Add(textBoxEmailRev);
            Controls.Add(labelEmail);
            Controls.Add(textBoxNomeRev);
            Controls.Add(labelNome);
            Controls.Add(labelDadosClientes);
            MaximizeBox = false;
            MaximumSize = new Size(467, 369);
            MinimizeBox = false;
            MinimumSize = new Size(467, 369);
            Name = "FormCadastraRevendedor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Revendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLimparCadastroRevendedor;
        private Button buttonSalvarRevendedor;
        private Label labelTelefone;
        public TextBox textBoxEmailRev;
        private Label labelEmail;
        public TextBox textBoxNomeRev;
        private Label labelNome;
        private Label labelDadosClientes;
        public MaskedTextBox maskedTextBoxTelefoneRev;
    }
}