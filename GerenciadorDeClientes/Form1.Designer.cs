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
            comboBoxSelectTable = new ComboBox();
            textBoxSelectNome = new TextBox();
            dataGridViewClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.RoyalBlue;
            buttonCadastrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.ForeColor = SystemColors.ButtonFace;
            buttonCadastrar.Location = new Point(450, 43);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(142, 53);
            buttonCadastrar.TabIndex = 3;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.BackColor = Color.Goldenrod;
            buttonAtualizar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAtualizar.ForeColor = SystemColors.ButtonFace;
            buttonAtualizar.Location = new Point(607, 43);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(142, 53);
            buttonAtualizar.TabIndex = 4;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = false;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.Green;
            buttonBuscar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscar.ForeColor = SystemColors.ButtonFace;
            buttonBuscar.Location = new Point(289, 43);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(142, 53);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscarCliente_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcluir.ForeColor = SystemColors.ButtonFace;
            buttonExcluir.Location = new Point(762, 43);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(142, 53);
            buttonExcluir.TabIndex = 5;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // comboBoxSelectTable
            // 
            comboBoxSelectTable.Cursor = Cursors.Hand;
            comboBoxSelectTable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSelectTable.FormattingEnabled = true;
            comboBoxSelectTable.Items.AddRange(new object[] { "Aplicativo", "Cliente", "Revendedor", "Servidor" });
            comboBoxSelectTable.Location = new Point(12, 12);
            comboBoxSelectTable.Name = "comboBoxSelectTable";
            comboBoxSelectTable.Size = new Size(255, 29);
            comboBoxSelectTable.Sorted = true;
            comboBoxSelectTable.TabIndex = 0;
            comboBoxSelectTable.TabStop = false;
            comboBoxSelectTable.Text = "Selecione";
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
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(12, 117);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(892, 568);
            dataGridViewClientes.TabIndex = 6;
            dataGridViewClientes.Visible = false;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 710);
            Controls.Add(dataGridViewClientes);
            Controls.Add(textBoxSelectNome);
            Controls.Add(comboBoxSelectTable);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonAtualizar);
            Controls.Add(buttonCadastrar);
            Name = "FormTelaPrincipal";
            Text = "Tela Principal";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button buttonCadastrar;
        public Button buttonAtualizar;
        public Button buttonBuscar;
        private Button buttonExcluir;
        public ComboBox comboBoxSelectTable;
        private TextBox textBoxSelectNome;
        public DataGridView dataGridViewClientes;
    }
}
