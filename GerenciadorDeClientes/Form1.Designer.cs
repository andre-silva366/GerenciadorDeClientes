namespace GerenciadorDeClientes
{
    partial class FormTelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCadastrarCliente = new Button();
            buttonAtualizarCliente = new Button();
            buttonBuscarCliente = new Button();
            buttonExcluirUsuario = new Button();
            comboBox1 = new ComboBox();
            textBoxSelectNome = new TextBox();
            SuspendLayout();
            // 
            // buttonCadastrarCliente
            // 
            buttonCadastrarCliente.BackColor = Color.RoyalBlue;
            buttonCadastrarCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrarCliente.ForeColor = SystemColors.ButtonFace;
            buttonCadastrarCliente.Location = new Point(450, 43);
            buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            buttonCadastrarCliente.Size = new Size(142, 53);
            buttonCadastrarCliente.TabIndex = 3;
            buttonCadastrarCliente.Text = "Cadastrar";
            buttonCadastrarCliente.UseVisualStyleBackColor = false;
            // 
            // buttonAtualizarCliente
            // 
            buttonAtualizarCliente.BackColor = Color.Goldenrod;
            buttonAtualizarCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAtualizarCliente.ForeColor = SystemColors.ButtonFace;
            buttonAtualizarCliente.Location = new Point(607, 43);
            buttonAtualizarCliente.Name = "buttonAtualizarCliente";
            buttonAtualizarCliente.Size = new Size(142, 53);
            buttonAtualizarCliente.TabIndex = 4;
            buttonAtualizarCliente.Text = "Atualizar";
            buttonAtualizarCliente.UseVisualStyleBackColor = false;
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.BackColor = Color.Green;
            buttonBuscarCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarCliente.ForeColor = SystemColors.ButtonFace;
            buttonBuscarCliente.Location = new Point(289, 43);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(142, 53);
            buttonBuscarCliente.TabIndex = 2;
            buttonBuscarCliente.Text = "Buscar";
            buttonBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // buttonExcluirUsuario
            // 
            buttonExcluirUsuario.BackColor = Color.Red;
            buttonExcluirUsuario.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcluirUsuario.ForeColor = SystemColors.ButtonFace;
            buttonExcluirUsuario.Location = new Point(762, 43);
            buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            buttonExcluirUsuario.Size = new Size(142, 53);
            buttonExcluirUsuario.TabIndex = 5;
            buttonExcluirUsuario.Text = "Excluir";
            buttonExcluirUsuario.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Aplicativo", "Cliente", "Revendedor", "Servidor" });
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 29);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 0;
            comboBox1.TabStop = false;
            comboBox1.Text = "Selecione";
            // 
            // textBoxSelectNome
            // 
            textBoxSelectNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSelectNome.Location = new Point(12, 67);
            textBoxSelectNome.Name = "textBoxSelectNome";
            textBoxSelectNome.PlaceholderText = "Ex: Andre";
            textBoxSelectNome.Size = new Size(255, 29);
            textBoxSelectNome.TabIndex = 1;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 710);
            Controls.Add(textBoxSelectNome);
            Controls.Add(comboBox1);
            Controls.Add(buttonExcluirUsuario);
            Controls.Add(buttonBuscarCliente);
            Controls.Add(buttonAtualizarCliente);
            Controls.Add(buttonCadastrarCliente);
            Name = "FormTelaPrincipal";
            Text = "Tela Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button buttonCadastrarCliente;
        public Button buttonAtualizarCliente;
        public Button buttonBuscarCliente;
        private Button buttonExcluirUsuario;
        public ComboBox comboBox1;
        private TextBox textBoxSelectNome;
    }
}
