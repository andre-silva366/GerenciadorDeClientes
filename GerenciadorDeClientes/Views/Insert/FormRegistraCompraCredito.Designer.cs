namespace GerenciadorDeClientes.Views.Insert
{
    partial class FormRegistraCompraCredito
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
            dateTimePickerCompCred = new DateTimePicker();
            label8 = new Label();
            textBoxValorCompCred = new TextBox();
            label7 = new Label();
            numericUpDownPagQtdeCred = new NumericUpDown();
            label6 = new Label();
            label2 = new Label();
            comboBoxCompCredServ = new ComboBox();
            label1 = new Label();
            buttonLimparCompCred = new Button();
            buttonRegCompcred = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPagQtdeCred).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerCompCred
            // 
            dateTimePickerCompCred.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerCompCred.Format = DateTimePickerFormat.Short;
            dateTimePickerCompCred.Location = new Point(124, 250);
            dateTimePickerCompCred.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dateTimePickerCompCred.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePickerCompCred.Name = "dateTimePickerCompCred";
            dateTimePickerCompCred.Size = new Size(273, 29);
            dateTimePickerCompCred.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 250);
            label8.Name = "label8";
            label8.Size = new Size(51, 21);
            label8.TabIndex = 22;
            label8.Text = "Data: ";
            // 
            // textBoxValorCompCred
            // 
            textBoxValorCompCred.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxValorCompCred.Location = new Point(124, 195);
            textBoxValorCompCred.Name = "textBoxValorCompCred";
            textBoxValorCompCred.Size = new Size(96, 29);
            textBoxValorCompCred.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 198);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 20;
            label7.Text = "Valor: ";
            // 
            // numericUpDownPagQtdeCred
            // 
            numericUpDownPagQtdeCred.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDownPagQtdeCred.Location = new Point(124, 150);
            numericUpDownPagQtdeCred.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPagQtdeCred.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownPagQtdeCred.Name = "numericUpDownPagQtdeCred";
            numericUpDownPagQtdeCred.Size = new Size(93, 29);
            numericUpDownPagQtdeCred.TabIndex = 19;
            numericUpDownPagQtdeCred.TextAlign = HorizontalAlignment.Center;
            numericUpDownPagQtdeCred.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 150);
            label6.Name = "label6";
            label6.Size = new Size(121, 21);
            label6.TabIndex = 18;
            label6.Text = "Qtde Créditos: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 17;
            label2.Text = "Servidor: ";
            // 
            // comboBoxCompCredServ
            // 
            comboBoxCompCredServ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCompCredServ.FormattingEnabled = true;
            comboBoxCompCredServ.Location = new Point(124, 99);
            comboBoxCompCredServ.Name = "comboBoxCompCredServ";
            comboBoxCompCredServ.Size = new Size(273, 29);
            comboBoxCompCredServ.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 15;
            label1.Text = "Informe os dados da compra";
            // 
            // buttonLimparCompCred
            // 
            buttonLimparCompCred.BackColor = Color.Ivory;
            buttonLimparCompCred.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCompCred.ForeColor = SystemColors.ActiveCaptionText;
            buttonLimparCompCred.Location = new Point(12, 333);
            buttonLimparCompCred.Name = "buttonLimparCompCred";
            buttonLimparCompCred.Size = new Size(147, 47);
            buttonLimparCompCred.TabIndex = 18;
            buttonLimparCompCred.Text = "Limpar";
            buttonLimparCompCred.UseVisualStyleBackColor = false;
            // 
            // buttonRegCompcred
            // 
            buttonRegCompcred.BackColor = Color.SeaGreen;
            buttonRegCompcred.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegCompcred.ForeColor = SystemColors.Control;
            buttonRegCompcred.Location = new Point(250, 333);
            buttonRegCompcred.Name = "buttonRegCompcred";
            buttonRegCompcred.Size = new Size(147, 47);
            buttonRegCompcred.TabIndex = 17;
            buttonRegCompcred.Text = "Registrar";
            buttonRegCompcred.UseVisualStyleBackColor = false;
            buttonRegCompcred.Click += buttonRegCompcred_Click;
            // 
            // FormRegistraCompraCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 416);
            Controls.Add(buttonLimparCompCred);
            Controls.Add(buttonRegCompcred);
            Controls.Add(dateTimePickerCompCred);
            Controls.Add(label8);
            Controls.Add(textBoxValorCompCred);
            Controls.Add(label7);
            Controls.Add(numericUpDownPagQtdeCred);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(comboBoxCompCredServ);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(437, 455);
            MinimizeBox = false;
            MinimumSize = new Size(437, 455);
            Name = "FormRegistraCompraCredito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Compra de Crédito";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPagQtdeCred).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DateTimePicker dateTimePickerCompCred;
        private Label label8;
        public TextBox textBoxValorCompCred;
        private Label label7;
        public NumericUpDown numericUpDownPagQtdeCred;
        private Label label6;
        private Label label2;
        public ComboBox comboBoxCompCredServ;
        private Label label1;
        private Button buttonLimparCompCred;
        private Button buttonRegCompcred;
    }
}