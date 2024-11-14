namespace GerenciadorDeClientes.Views.Update
{
    partial class FormAtualizarDeletarPlano
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
            buttonBuscarPlanoIdAtua = new Button();
            buttonSalvarPlanoAtualizado = new Button();
            buttonLimparCadAtuaPlan = new Button();
            textBoxDescrPlanoAtual = new TextBox();
            label3 = new Label();
            labelPlano = new Label();
            textBoxIdPlanoAtual = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBoxValorPlanoAtua = new TextBox();
            buttonExcluirPlano = new Button();
            comboBoxAlterPlanoCliente = new ComboBox();
            comboBoxAlterPlanoAplicativo = new ComboBox();
            textBoxAlterPlanKeySenha = new TextBox();
            textBoxAlterPlanMacEmail = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dateTimePickerDelPlanoProximoPagamento = new DateTimePicker();
            label5 = new Label();
            dateTimePickerDeletaPlanoUltimoPagamento = new DateTimePicker();
            label2 = new Label();
            numericUpDownDeletaPlanoValidadeEmMeses = new NumericUpDown();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeletaPlanoValidadeEmMeses).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscarPlanoIdAtua
            // 
            buttonBuscarPlanoIdAtua.BackColor = Color.FromArgb(0, 192, 0);
            buttonBuscarPlanoIdAtua.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarPlanoIdAtua.ForeColor = SystemColors.ButtonFace;
            buttonBuscarPlanoIdAtua.Location = new Point(277, 7);
            buttonBuscarPlanoIdAtua.Name = "buttonBuscarPlanoIdAtua";
            buttonBuscarPlanoIdAtua.Size = new Size(100, 41);
            buttonBuscarPlanoIdAtua.TabIndex = 15;
            buttonBuscarPlanoIdAtua.Text = "Buscar";
            buttonBuscarPlanoIdAtua.UseVisualStyleBackColor = false;
            buttonBuscarPlanoIdAtua.Click += buttonBuscarPlanoIdAtua_Click;
            // 
            // buttonSalvarPlanoAtualizado
            // 
            buttonSalvarPlanoAtualizado.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarPlanoAtualizado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvarPlanoAtualizado.ForeColor = SystemColors.ButtonFace;
            buttonSalvarPlanoAtualizado.Location = new Point(344, 617);
            buttonSalvarPlanoAtualizado.Name = "buttonSalvarPlanoAtualizado";
            buttonSalvarPlanoAtualizado.Size = new Size(108, 49);
            buttonSalvarPlanoAtualizado.TabIndex = 14;
            buttonSalvarPlanoAtualizado.Text = "Salvar";
            buttonSalvarPlanoAtualizado.UseVisualStyleBackColor = false;
            buttonSalvarPlanoAtualizado.Click += buttonSalvarPlanoAtualizado_Click;
            // 
            // buttonLimparCadAtuaPlan
            // 
            buttonLimparCadAtuaPlan.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCadAtuaPlan.Location = new Point(12, 617);
            buttonLimparCadAtuaPlan.Name = "buttonLimparCadAtuaPlan";
            buttonLimparCadAtuaPlan.Size = new Size(108, 49);
            buttonLimparCadAtuaPlan.TabIndex = 13;
            buttonLimparCadAtuaPlan.Text = "Limpar";
            buttonLimparCadAtuaPlan.UseVisualStyleBackColor = true;
            buttonLimparCadAtuaPlan.Click += buttonLimparCadAtuaPlan_Click;
            // 
            // textBoxDescrPlanoAtual
            // 
            textBoxDescrPlanoAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescrPlanoAtual.Location = new Point(102, 135);
            textBoxDescrPlanoAtual.Name = "textBoxDescrPlanoAtual";
            textBoxDescrPlanoAtual.Size = new Size(275, 29);
            textBoxDescrPlanoAtual.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 11;
            label3.Text = "Descriçao: ";
            // 
            // labelPlano
            // 
            labelPlano.AutoSize = true;
            labelPlano.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlano.Location = new Point(12, 91);
            labelPlano.Name = "labelPlano";
            labelPlano.Size = new Size(119, 21);
            labelPlano.TabIndex = 10;
            labelPlano.Text = "Dados do plano";
            // 
            // textBoxIdPlanoAtual
            // 
            textBoxIdPlanoAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIdPlanoAtual.Location = new Point(171, 15);
            textBoxIdPlanoAtual.Name = "textBoxIdPlanoAtual";
            textBoxIdPlanoAtual.Size = new Size(100, 29);
            textBoxIdPlanoAtual.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 8;
            label1.Text = "Digite o id do plano: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 16;
            label4.Text = "Valor: ";
            // 
            // textBoxValorPlanoAtua
            // 
            textBoxValorPlanoAtua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxValorPlanoAtua.Location = new Point(102, 192);
            textBoxValorPlanoAtua.Name = "textBoxValorPlanoAtua";
            textBoxValorPlanoAtua.Size = new Size(135, 29);
            textBoxValorPlanoAtua.TabIndex = 17;
            // 
            // buttonExcluirPlano
            // 
            buttonExcluirPlano.BackColor = Color.Red;
            buttonExcluirPlano.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcluirPlano.ForeColor = SystemColors.ButtonFace;
            buttonExcluirPlano.Location = new Point(176, 617);
            buttonExcluirPlano.Name = "buttonExcluirPlano";
            buttonExcluirPlano.Size = new Size(108, 49);
            buttonExcluirPlano.TabIndex = 18;
            buttonExcluirPlano.Text = "Excluir";
            buttonExcluirPlano.UseVisualStyleBackColor = false;
            buttonExcluirPlano.Visible = false;
            buttonExcluirPlano.Click += buttonExcluirPlano_Click;
            // 
            // comboBoxAlterPlanoCliente
            // 
            comboBoxAlterPlanoCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxAlterPlanoCliente.FormattingEnabled = true;
            comboBoxAlterPlanoCliente.Location = new Point(109, 450);
            comboBoxAlterPlanoCliente.Name = "comboBoxAlterPlanoCliente";
            comboBoxAlterPlanoCliente.Size = new Size(268, 29);
            comboBoxAlterPlanoCliente.TabIndex = 94;
            // 
            // comboBoxAlterPlanoAplicativo
            // 
            comboBoxAlterPlanoAplicativo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxAlterPlanoAplicativo.FormattingEnabled = true;
            comboBoxAlterPlanoAplicativo.Location = new Point(109, 400);
            comboBoxAlterPlanoAplicativo.Name = "comboBoxAlterPlanoAplicativo";
            comboBoxAlterPlanoAplicativo.Size = new Size(268, 29);
            comboBoxAlterPlanoAplicativo.TabIndex = 93;
            // 
            // textBoxAlterPlanKeySenha
            // 
            textBoxAlterPlanKeySenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAlterPlanKeySenha.Location = new Point(176, 558);
            textBoxAlterPlanKeySenha.Name = "textBoxAlterPlanKeySenha";
            textBoxAlterPlanKeySenha.Size = new Size(276, 29);
            textBoxAlterPlanKeySenha.TabIndex = 92;
            // 
            // textBoxAlterPlanMacEmail
            // 
            textBoxAlterPlanMacEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAlterPlanMacEmail.Location = new Point(176, 507);
            textBoxAlterPlanMacEmail.Name = "textBoxAlterPlanMacEmail";
            textBoxAlterPlanMacEmail.Size = new Size(276, 29);
            textBoxAlterPlanMacEmail.TabIndex = 91;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 561);
            label9.Name = "label9";
            label9.Size = new Size(167, 21);
            label9.TabIndex = 90;
            label9.Text = "Device Key ou senha: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 510);
            label8.Name = "label8";
            label8.Size = new Size(114, 21);
            label8.TabIndex = 89;
            label8.Text = "Mac ou Email: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 453);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 88;
            label7.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 403);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 87;
            label6.Text = "Aplicativo: ";
            // 
            // dateTimePickerDelPlanoProximoPagamento
            // 
            dateTimePickerDelPlanoProximoPagamento.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerDelPlanoProximoPagamento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dateTimePickerDelPlanoProximoPagamento.Format = DateTimePickerFormat.Short;
            dateTimePickerDelPlanoProximoPagamento.Location = new Point(176, 345);
            dateTimePickerDelPlanoProximoPagamento.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dateTimePickerDelPlanoProximoPagamento.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePickerDelPlanoProximoPagamento.Name = "dateTimePickerDelPlanoProximoPagamento";
            dateTimePickerDelPlanoProximoPagamento.Size = new Size(201, 29);
            dateTimePickerDelPlanoProximoPagamento.TabIndex = 86;
            dateTimePickerDelPlanoProximoPagamento.Value = new DateTime(2024, 11, 11, 19, 32, 52, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 351);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 85;
            label5.Text = "Próximo Pagamento: ";
            // 
            // dateTimePickerDeletaPlanoUltimoPagamento
            // 
            dateTimePickerDeletaPlanoUltimoPagamento.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerDeletaPlanoUltimoPagamento.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            dateTimePickerDeletaPlanoUltimoPagamento.Format = DateTimePickerFormat.Short;
            dateTimePickerDeletaPlanoUltimoPagamento.Location = new Point(176, 297);
            dateTimePickerDeletaPlanoUltimoPagamento.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dateTimePickerDeletaPlanoUltimoPagamento.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePickerDeletaPlanoUltimoPagamento.Name = "dateTimePickerDeletaPlanoUltimoPagamento";
            dateTimePickerDeletaPlanoUltimoPagamento.Size = new Size(201, 29);
            dateTimePickerDeletaPlanoUltimoPagamento.TabIndex = 84;
            dateTimePickerDeletaPlanoUltimoPagamento.Value = new DateTime(2024, 11, 11, 19, 32, 52, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 303);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 83;
            label2.Text = "Ultimo Pagamento: ";
            // 
            // numericUpDownDeletaPlanoValidadeEmMeses
            // 
            numericUpDownDeletaPlanoValidadeEmMeses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDownDeletaPlanoValidadeEmMeses.Location = new Point(176, 247);
            numericUpDownDeletaPlanoValidadeEmMeses.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownDeletaPlanoValidadeEmMeses.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDeletaPlanoValidadeEmMeses.Name = "numericUpDownDeletaPlanoValidadeEmMeses";
            numericUpDownDeletaPlanoValidadeEmMeses.Size = new Size(63, 29);
            numericUpDownDeletaPlanoValidadeEmMeses.TabIndex = 82;
            numericUpDownDeletaPlanoValidadeEmMeses.TextAlign = HorizontalAlignment.Center;
            numericUpDownDeletaPlanoValidadeEmMeses.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 249);
            label10.Name = "label10";
            label10.Size = new Size(158, 21);
            label10.TabIndex = 81;
            label10.Text = "Validade em Meses: ";
            // 
            // FormAtualizarDeletarPlano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 694);
            Controls.Add(comboBoxAlterPlanoCliente);
            Controls.Add(comboBoxAlterPlanoAplicativo);
            Controls.Add(textBoxAlterPlanKeySenha);
            Controls.Add(textBoxAlterPlanMacEmail);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePickerDelPlanoProximoPagamento);
            Controls.Add(label5);
            Controls.Add(dateTimePickerDeletaPlanoUltimoPagamento);
            Controls.Add(label2);
            Controls.Add(numericUpDownDeletaPlanoValidadeEmMeses);
            Controls.Add(label10);
            Controls.Add(buttonExcluirPlano);
            Controls.Add(textBoxValorPlanoAtua);
            Controls.Add(label4);
            Controls.Add(buttonBuscarPlanoIdAtua);
            Controls.Add(buttonSalvarPlanoAtualizado);
            Controls.Add(buttonLimparCadAtuaPlan);
            Controls.Add(textBoxDescrPlanoAtual);
            Controls.Add(label3);
            Controls.Add(labelPlano);
            Controls.Add(textBoxIdPlanoAtual);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(408, 307);
            Name = "FormAtualizarDeletarPlano";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar plano";
            Load += FormAtualizarDeletarPlano_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeletaPlanoValidadeEmMeses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscarPlanoIdAtua;
        private Button buttonLimparCadAtuaPlan;
        private TextBox textBoxDescrPlanoAtual;
        private Label label3;
        private TextBox textBoxIdPlanoAtual;
        private Label label1;
        private Label label4;
        private TextBox textBoxValorPlanoAtua;
        public Button buttonExcluirPlano;
        public Button buttonSalvarPlanoAtualizado;
        public Label labelPlano;
        private ComboBox comboBoxAlterPlanoCliente;
        private ComboBox comboBoxAlterPlanoAplicativo;
        private TextBox textBoxAlterPlanKeySenha;
        private TextBox textBoxAlterPlanMacEmail;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        public DateTimePicker dateTimePickerDelPlanoProximoPagamento;
        private Label label5;
        public DateTimePicker dateTimePickerDeletaPlanoUltimoPagamento;
        private Label label2;
        public NumericUpDown numericUpDownDeletaPlanoValidadeEmMeses;
        private Label label10;
    }
}