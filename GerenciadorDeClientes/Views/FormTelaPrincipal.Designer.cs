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
            buttonCadastrar = new Button();
            buttonAtualizar = new Button();
            buttonBuscar = new Button();
            buttonExcluir = new Button();
            textBoxSelectNome = new TextBox();
            dataGridView = new DataGridView();
            buttonLimpar = new Button();
            radioButtonAplicativo = new RadioButton();
            radioButtonServidor = new RadioButton();
            radioButtonPlano = new RadioButton();
            radioButtonRevendedor = new RadioButton();
            radioButtonCliente = new RadioButton();
            checkBoxBuscaPorNome = new CheckBox();
            buttonBuscarPorNome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.RoyalBlue;
            buttonCadastrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.ForeColor = SystemColors.ButtonFace;
            buttonCadastrar.Location = new Point(159, 61);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(142, 53);
            buttonCadastrar.TabIndex = 8;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.BackColor = Color.Goldenrod;
            buttonAtualizar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAtualizar.ForeColor = SystemColors.ButtonFace;
            buttonAtualizar.Location = new Point(307, 61);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(142, 53);
            buttonAtualizar.TabIndex = 9;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = false;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.Green;
            buttonBuscar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscar.ForeColor = SystemColors.ButtonFace;
            buttonBuscar.Location = new Point(11, 61);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(142, 53);
            buttonBuscar.TabIndex = 7;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcluir.ForeColor = SystemColors.ButtonFace;
            buttonExcluir.Location = new Point(455, 61);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(142, 53);
            buttonExcluir.TabIndex = 10;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // textBoxSelectNome
            // 
            textBoxSelectNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSelectNome.Location = new Point(805, 17);
            textBoxSelectNome.Name = "textBoxSelectNome";
            textBoxSelectNome.PlaceholderText = "Digite aqui!";
            textBoxSelectNome.Size = new Size(235, 29);
            textBoxSelectNome.TabIndex = 6;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 135);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(1028, 531);
            dataGridView.TabIndex = 11;
            dataGridView.Visible = false;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.SeaShell;
            buttonLimpar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpar.ForeColor = SystemColors.ActiveCaptionText;
            buttonLimpar.Location = new Point(603, 61);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(142, 53);
            buttonLimpar.TabIndex = 11;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // radioButtonAplicativo
            // 
            radioButtonAplicativo.AutoSize = true;
            radioButtonAplicativo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonAplicativo.Location = new Point(369, 18);
            radioButtonAplicativo.Name = "radioButtonAplicativo";
            radioButtonAplicativo.Size = new Size(101, 25);
            radioButtonAplicativo.TabIndex = 3;
            radioButtonAplicativo.TabStop = true;
            radioButtonAplicativo.Text = "Aplicativo";
            radioButtonAplicativo.UseVisualStyleBackColor = true;
            // 
            // radioButtonServidor
            // 
            radioButtonServidor.AutoSize = true;
            radioButtonServidor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonServidor.Location = new Point(244, 19);
            radioButtonServidor.Name = "radioButtonServidor";
            radioButtonServidor.Size = new Size(91, 25);
            radioButtonServidor.TabIndex = 2;
            radioButtonServidor.TabStop = true;
            radioButtonServidor.Text = "Servidor";
            radioButtonServidor.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlano
            // 
            radioButtonPlano.AutoSize = true;
            radioButtonPlano.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonPlano.Location = new Point(511, 18);
            radioButtonPlano.Name = "radioButtonPlano";
            radioButtonPlano.Size = new Size(68, 25);
            radioButtonPlano.TabIndex = 4;
            radioButtonPlano.TabStop = true;
            radioButtonPlano.Text = "Plano";
            radioButtonPlano.UseVisualStyleBackColor = true;
            // 
            // radioButtonRevendedor
            // 
            radioButtonRevendedor.AutoSize = true;
            radioButtonRevendedor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonRevendedor.Location = new Point(107, 18);
            radioButtonRevendedor.Name = "radioButtonRevendedor";
            radioButtonRevendedor.Size = new Size(118, 25);
            radioButtonRevendedor.TabIndex = 1;
            radioButtonRevendedor.TabStop = true;
            radioButtonRevendedor.Text = "Revendedor";
            radioButtonRevendedor.UseVisualStyleBackColor = true;
            // 
            // radioButtonCliente
            // 
            radioButtonCliente.AutoSize = true;
            radioButtonCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonCliente.Location = new Point(12, 19);
            radioButtonCliente.Name = "radioButtonCliente";
            radioButtonCliente.Size = new Size(79, 25);
            radioButtonCliente.TabIndex = 0;
            radioButtonCliente.TabStop = true;
            radioButtonCliente.Text = "Cliente";
            radioButtonCliente.UseVisualStyleBackColor = true;
            // 
            // checkBoxBuscaPorNome
            // 
            checkBoxBuscaPorNome.AutoSize = true;
            checkBoxBuscaPorNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxBuscaPorNome.Location = new Point(629, 19);
            checkBoxBuscaPorNome.Name = "checkBoxBuscaPorNome";
            checkBoxBuscaPorNome.Size = new Size(147, 25);
            checkBoxBuscaPorNome.TabIndex = 5;
            checkBoxBuscaPorNome.Text = "Busca por nome";
            checkBoxBuscaPorNome.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarPorNome
            // 
            buttonBuscarPorNome.BackColor = Color.DarkGreen;
            buttonBuscarPorNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarPorNome.ForeColor = SystemColors.ButtonFace;
            buttonBuscarPorNome.Location = new Point(898, 62);
            buttonBuscarPorNome.Name = "buttonBuscarPorNome";
            buttonBuscarPorNome.Size = new Size(142, 53);
            buttonBuscarPorNome.TabIndex = 12;
            buttonBuscarPorNome.Text = "Buscar por nome";
            buttonBuscarPorNome.UseVisualStyleBackColor = false;
            buttonBuscarPorNome.Click += buttonBuscarPorNome_Click;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 678);
            Controls.Add(buttonBuscarPorNome);
            Controls.Add(checkBoxBuscaPorNome);
            Controls.Add(radioButtonPlano);
            Controls.Add(radioButtonRevendedor);
            Controls.Add(radioButtonAplicativo);
            Controls.Add(radioButtonServidor);
            Controls.Add(radioButtonCliente);
            Controls.Add(buttonLimpar);
            Controls.Add(dataGridView);
            Controls.Add(textBoxSelectNome);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonAtualizar);
            Controls.Add(buttonCadastrar);
            MaximumSize = new Size(1070, 717);
            MinimumSize = new Size(1070, 717);
            Name = "FormTelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button buttonCadastrar;
        public Button buttonAtualizar;
        public Button buttonBuscar;
        private TextBox textBoxSelectNome;
        public DataGridView dataGridView;
        private RadioButton radioButtonAplicativo;
        private RadioButton radioButtonServidor;
        private RadioButton radioButtonPlano;
        private RadioButton radioButtonRevendedor;
        private RadioButton radioButtonCliente;
        public CheckBox checkBoxBuscaPorNome;
        public Button buttonBuscarPorNome;
        public Button buttonExcluir;
        public Button buttonLimpar;
    }
}
