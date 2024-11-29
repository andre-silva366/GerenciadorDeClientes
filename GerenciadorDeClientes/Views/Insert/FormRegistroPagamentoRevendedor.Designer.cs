namespace GerenciadorDeClientes.Views.Insert
{
    partial class FormRegistroPagamentoRevendedor
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
            buttonLimparPagRev = new Button();
            buttonRegistrarPagRev = new Button();
            dateTimePickerDataPagRev = new DateTimePicker();
            label8 = new Label();
            textBoxValorPagRev = new TextBox();
            label7 = new Label();
            numericUpDownPagQtdeCreditos = new NumericUpDown();
            label6 = new Label();
            label4 = new Label();
            comboBoxPagServ = new ComboBox();
            label2 = new Label();
            comboBoxPagRevend = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPagQtdeCreditos).BeginInit();
            SuspendLayout();
            // 
            // buttonLimparPagRev
            // 
            buttonLimparPagRev.BackColor = Color.Ivory;
            buttonLimparPagRev.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparPagRev.ForeColor = SystemColors.ActiveCaptionText;
            buttonLimparPagRev.Location = new Point(24, 409);
            buttonLimparPagRev.Name = "buttonLimparPagRev";
            buttonLimparPagRev.Size = new Size(147, 47);
            buttonLimparPagRev.TabIndex = 37;
            buttonLimparPagRev.Text = "Limpar";
            buttonLimparPagRev.UseVisualStyleBackColor = false;
            // 
            // buttonRegistrarPagRev
            // 
            buttonRegistrarPagRev.BackColor = Color.SeaGreen;
            buttonRegistrarPagRev.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistrarPagRev.ForeColor = SystemColors.Control;
            buttonRegistrarPagRev.Location = new Point(262, 409);
            buttonRegistrarPagRev.Name = "buttonRegistrarPagRev";
            buttonRegistrarPagRev.Size = new Size(147, 47);
            buttonRegistrarPagRev.TabIndex = 36;
            buttonRegistrarPagRev.Text = "Registrar";
            buttonRegistrarPagRev.UseVisualStyleBackColor = false;
            buttonRegistrarPagRev.Click += buttonRegistrarPagRev_Click;
            // 
            // dateTimePickerDataPagRev
            // 
            dateTimePickerDataPagRev.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerDataPagRev.Format = DateTimePickerFormat.Short;
            dateTimePickerDataPagRev.Location = new Point(136, 337);
            dateTimePickerDataPagRev.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dateTimePickerDataPagRev.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePickerDataPagRev.Name = "dateTimePickerDataPagRev";
            dateTimePickerDataPagRev.Size = new Size(273, 29);
            dateTimePickerDataPagRev.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 343);
            label8.Name = "label8";
            label8.Size = new Size(51, 21);
            label8.TabIndex = 32;
            label8.Text = "Data: ";
            // 
            // textBoxValorPagRev
            // 
            textBoxValorPagRev.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxValorPagRev.Location = new Point(136, 282);
            textBoxValorPagRev.Name = "textBoxValorPagRev";
            textBoxValorPagRev.Size = new Size(96, 29);
            textBoxValorPagRev.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 285);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 30;
            label7.Text = "Valor: ";
            // 
            // numericUpDownPagQtdeCreditos
            // 
            numericUpDownPagQtdeCreditos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDownPagQtdeCreditos.Location = new Point(136, 237);
            numericUpDownPagQtdeCreditos.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPagQtdeCreditos.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownPagQtdeCreditos.Name = "numericUpDownPagQtdeCreditos";
            numericUpDownPagQtdeCreditos.Size = new Size(93, 29);
            numericUpDownPagQtdeCreditos.TabIndex = 29;
            numericUpDownPagQtdeCreditos.TextAlign = HorizontalAlignment.Center;
            numericUpDownPagQtdeCreditos.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 239);
            label6.Name = "label6";
            label6.Size = new Size(121, 21);
            label6.TabIndex = 28;
            label6.Text = "Qtde Creditos: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 179);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 25;
            label4.Text = "Servidor: ";
            // 
            // comboBoxPagServ
            // 
            comboBoxPagServ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPagServ.FormattingEnabled = true;
            comboBoxPagServ.Location = new Point(136, 176);
            comboBoxPagServ.Name = "comboBoxPagServ";
            comboBoxPagServ.Size = new Size(273, 29);
            comboBoxPagServ.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 121);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 21;
            label2.Text = "Revendedor: ";
            // 
            // comboBoxPagRevend
            // 
            comboBoxPagRevend.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPagRevend.FormattingEnabled = true;
            comboBoxPagRevend.Location = new Point(136, 118);
            comboBoxPagRevend.Name = "comboBoxPagRevend";
            comboBoxPagRevend.Size = new Size(273, 29);
            comboBoxPagRevend.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 46);
            label1.Name = "label1";
            label1.Size = new Size(290, 25);
            label1.TabIndex = 19;
            label1.Text = "Informe os dados de pagamento";
            // 
            // FormRegistroPagamentoRevendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 497);
            Controls.Add(buttonLimparPagRev);
            Controls.Add(buttonRegistrarPagRev);
            Controls.Add(dateTimePickerDataPagRev);
            Controls.Add(label8);
            Controls.Add(textBoxValorPagRev);
            Controls.Add(label7);
            Controls.Add(numericUpDownPagQtdeCreditos);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(comboBoxPagServ);
            Controls.Add(label2);
            Controls.Add(comboBoxPagRevend);
            Controls.Add(label1);
            Name = "FormRegistroPagamentoRevendedor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Pagamento de Revendedor";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPagQtdeCreditos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button buttonLimparPagRev;
        private Button buttonRegistrarPagRev;
        public DateTimePicker dateTimePickerDataPagRev;
        private Label label8;
        public TextBox textBoxValorPagRev;
        private Label label7;
        public NumericUpDown numericUpDownPagQtdeCreditos;
        private Label label6;
        private Label label4;
        public ComboBox comboBoxPagServ;
        private Label label2;
        public ComboBox comboBoxPagRevend;
        private Label label1;
    }
}