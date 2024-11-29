namespace GerenciadorDeClientes.Views.Insert
{
    partial class FormRegistraPagamentoCliente
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
            comboBoxPagCliente = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxPagClienAplicatico = new ComboBox();
            label4 = new Label();
            comboBoxPagServidor = new ComboBox();
            comboBoxPagPlano = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            numericUpDownPagQtdeTelas = new NumericUpDown();
            label7 = new Label();
            textBoxValorPagCli = new TextBox();
            label8 = new Label();
            dateTimePickerPagClie = new DateTimePicker();
            label9 = new Label();
            numericUpDownQtdeMeses = new NumericUpDown();
            buttonRegistrarPagCliente = new Button();
            buttonLimparPagCli = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPagQtdeTelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQtdeMeses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(290, 25);
            label1.TabIndex = 0;
            label1.Text = "Informe os dados de pagamento";
            // 
            // comboBoxPagCliente
            // 
            comboBoxPagCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPagCliente.FormattingEnabled = true;
            comboBoxPagCliente.Location = new Point(124, 106);
            comboBoxPagCliente.Name = "comboBoxPagCliente";
            comboBoxPagCliente.Size = new Size(273, 29);
            comboBoxPagCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 2;
            label2.Text = "Cliente: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 4;
            label3.Text = "Aplicativo: ";
            // 
            // comboBoxPagClienAplicatico
            // 
            comboBoxPagClienAplicatico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPagClienAplicatico.FormattingEnabled = true;
            comboBoxPagClienAplicatico.Location = new Point(124, 158);
            comboBoxPagClienAplicatico.Name = "comboBoxPagClienAplicatico";
            comboBoxPagClienAplicatico.Size = new Size(273, 29);
            comboBoxPagClienAplicatico.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 213);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 6;
            label4.Text = "Servidor: ";
            // 
            // comboBoxPagServidor
            // 
            comboBoxPagServidor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPagServidor.FormattingEnabled = true;
            comboBoxPagServidor.Location = new Point(124, 210);
            comboBoxPagServidor.Name = "comboBoxPagServidor";
            comboBoxPagServidor.Size = new Size(273, 29);
            comboBoxPagServidor.TabIndex = 5;
            // 
            // comboBoxPagPlano
            // 
            comboBoxPagPlano.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPagPlano.FormattingEnabled = true;
            comboBoxPagPlano.Location = new Point(124, 265);
            comboBoxPagPlano.Name = "comboBoxPagPlano";
            comboBoxPagPlano.Size = new Size(273, 29);
            comboBoxPagPlano.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 268);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 8;
            label5.Text = "Plano: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 321);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 9;
            label6.Text = "Qtde Telas: ";
            // 
            // numericUpDownPagQtdeTelas
            // 
            numericUpDownPagQtdeTelas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDownPagQtdeTelas.Location = new Point(124, 321);
            numericUpDownPagQtdeTelas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownPagQtdeTelas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPagQtdeTelas.Name = "numericUpDownPagQtdeTelas";
            numericUpDownPagQtdeTelas.Size = new Size(93, 29);
            numericUpDownPagQtdeTelas.TabIndex = 10;
            numericUpDownPagQtdeTelas.TextAlign = HorizontalAlignment.Center;
            numericUpDownPagQtdeTelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 369);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 11;
            label7.Text = "Valor: ";
            // 
            // textBoxValorPagCli
            // 
            textBoxValorPagCli.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxValorPagCli.Location = new Point(124, 366);
            textBoxValorPagCli.Name = "textBoxValorPagCli";
            textBoxValorPagCli.Size = new Size(96, 29);
            textBoxValorPagCli.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 421);
            label8.Name = "label8";
            label8.Size = new Size(51, 21);
            label8.TabIndex = 13;
            label8.Text = "Data: ";
            // 
            // dateTimePickerPagClie
            // 
            dateTimePickerPagClie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerPagClie.Format = DateTimePickerFormat.Short;
            dateTimePickerPagClie.Location = new Point(124, 421);
            dateTimePickerPagClie.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dateTimePickerPagClie.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePickerPagClie.Name = "dateTimePickerPagClie";
            dateTimePickerPagClie.Size = new Size(273, 29);
            dateTimePickerPagClie.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 483);
            label9.Name = "label9";
            label9.Size = new Size(106, 21);
            label9.TabIndex = 15;
            label9.Text = "Qtde Meses: ";
            // 
            // numericUpDownQtdeMeses
            // 
            numericUpDownQtdeMeses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDownQtdeMeses.Location = new Point(124, 481);
            numericUpDownQtdeMeses.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownQtdeMeses.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQtdeMeses.Name = "numericUpDownQtdeMeses";
            numericUpDownQtdeMeses.Size = new Size(93, 29);
            numericUpDownQtdeMeses.TabIndex = 16;
            numericUpDownQtdeMeses.TextAlign = HorizontalAlignment.Center;
            numericUpDownQtdeMeses.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonRegistrarPagCliente
            // 
            buttonRegistrarPagCliente.BackColor = Color.SeaGreen;
            buttonRegistrarPagCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistrarPagCliente.ForeColor = SystemColors.Control;
            buttonRegistrarPagCliente.Location = new Point(250, 549);
            buttonRegistrarPagCliente.Name = "buttonRegistrarPagCliente";
            buttonRegistrarPagCliente.Size = new Size(147, 47);
            buttonRegistrarPagCliente.TabIndex = 17;
            buttonRegistrarPagCliente.Text = "Registrar";
            buttonRegistrarPagCliente.UseVisualStyleBackColor = false;
            buttonRegistrarPagCliente.Click += buttonRegistrarPagCliente_Click;
            // 
            // buttonLimparPagCli
            // 
            buttonLimparPagCli.BackColor = Color.Ivory;
            buttonLimparPagCli.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparPagCli.ForeColor = SystemColors.ActiveCaptionText;
            buttonLimparPagCli.Location = new Point(12, 549);
            buttonLimparPagCli.Name = "buttonLimparPagCli";
            buttonLimparPagCli.Size = new Size(147, 47);
            buttonLimparPagCli.TabIndex = 18;
            buttonLimparPagCli.Text = "Limpar";
            buttonLimparPagCli.UseVisualStyleBackColor = false;
            buttonLimparPagCli.Click += buttonLimparPagCli_Click;
            // 
            // FormRegistraPagamentoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 608);
            Controls.Add(buttonLimparPagCli);
            Controls.Add(buttonRegistrarPagCliente);
            Controls.Add(numericUpDownQtdeMeses);
            Controls.Add(label9);
            Controls.Add(dateTimePickerPagClie);
            Controls.Add(label8);
            Controls.Add(textBoxValorPagCli);
            Controls.Add(label7);
            Controls.Add(numericUpDownPagQtdeTelas);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxPagPlano);
            Controls.Add(label4);
            Controls.Add(comboBoxPagServidor);
            Controls.Add(label3);
            Controls.Add(comboBoxPagClienAplicatico);
            Controls.Add(label2);
            Controls.Add(comboBoxPagCliente);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(438, 647);
            MinimizeBox = false;
            MinimumSize = new Size(438, 647);
            Name = "FormRegistraPagamentoCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Pagamento de Cliente";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPagQtdeTelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQtdeMeses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public ComboBox comboBoxPagCliente;
        private Label label2;
        private Label label3;
        public ComboBox comboBoxPagClienAplicatico;
        private Label label4;
        public ComboBox comboBoxPagServidor;
        public ComboBox comboBoxPagPlano;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public DateTimePicker dateTimePickerPagClie;
        private Label label9;
        public NumericUpDown numericUpDownPagQtdeTelas;
        public TextBox textBoxValorPagCli;
        public NumericUpDown numericUpDownQtdeMeses;
        private Button buttonRegistrarPagCliente;
        public Button buttonLimparPagCli;
    }
}