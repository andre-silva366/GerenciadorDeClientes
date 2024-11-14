namespace GerenciadorDeClientes
{
    partial class FormCadastraPlano
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
            buttonLimparPlano = new Button();
            buttonSalvarPlano = new Button();
            textBoxDescricaoPlano = new TextBox();
            label1 = new Label();
            labelDadosServ = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxCadPlanoMacEmail = new TextBox();
            textBoxCadPlanoKeySenha = new TextBox();
            comboBoxPlanoAplicativo = new ComboBox();
            comboBoxPlanoCliente = new ComboBox();
            SuspendLayout();
            // 
            // buttonLimparPlano
            // 
            buttonLimparPlano.BackColor = Color.White;
            buttonLimparPlano.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparPlano.ForeColor = SystemColors.ActiveCaptionText;
            buttonLimparPlano.Location = new Point(20, 341);
            buttonLimparPlano.Name = "buttonLimparPlano";
            buttonLimparPlano.Size = new Size(110, 54);
            buttonLimparPlano.TabIndex = 3;
            buttonLimparPlano.Text = "Limpar";
            buttonLimparPlano.UseVisualStyleBackColor = false;
            buttonLimparPlano.Click += buttonLimparPlano_Click;
            // 
            // buttonSalvarPlano
            // 
            buttonSalvarPlano.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarPlano.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvarPlano.ForeColor = SystemColors.ButtonFace;
            buttonSalvarPlano.Location = new Point(276, 341);
            buttonSalvarPlano.Name = "buttonSalvarPlano";
            buttonSalvarPlano.Size = new Size(109, 54);
            buttonSalvarPlano.TabIndex = 2;
            buttonSalvarPlano.Text = "Salvar";
            buttonSalvarPlano.UseVisualStyleBackColor = false;
            buttonSalvarPlano.Click += buttonSalvarPlano_Click;
            // 
            // textBoxDescricaoPlano
            // 
            textBoxDescricaoPlano.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescricaoPlano.Location = new Point(109, 63);
            textBoxDescricaoPlano.Name = "textBoxDescricaoPlano";
            textBoxDescricaoPlano.Size = new Size(276, 29);
            textBoxDescricaoPlano.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 66);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 62;
            label1.Text = "Descrição: ";
            // 
            // labelDadosServ
            // 
            labelDadosServ.AutoSize = true;
            labelDadosServ.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDadosServ.Location = new Point(20, 19);
            labelDadosServ.Name = "labelDadosServ";
            labelDadosServ.Size = new Size(251, 25);
            labelDadosServ.TabIndex = 61;
            labelDadosServ.Text = "Preencha os dados do Plano";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 122);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 70;
            label6.Text = "Aplicativo: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 172);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 71;
            label7.Text = "Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 229);
            label8.Name = "label8";
            label8.Size = new Size(114, 21);
            label8.TabIndex = 72;
            label8.Text = "Mac ou Email: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 280);
            label9.Name = "label9";
            label9.Size = new Size(167, 21);
            label9.TabIndex = 73;
            label9.Text = "Device Key ou senha: ";
            // 
            // textBoxCadPlanoMacEmail
            // 
            textBoxCadPlanoMacEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCadPlanoMacEmail.Location = new Point(140, 226);
            textBoxCadPlanoMacEmail.Name = "textBoxCadPlanoMacEmail";
            textBoxCadPlanoMacEmail.Size = new Size(245, 29);
            textBoxCadPlanoMacEmail.TabIndex = 76;
            // 
            // textBoxCadPlanoKeySenha
            // 
            textBoxCadPlanoKeySenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCadPlanoKeySenha.Location = new Point(184, 277);
            textBoxCadPlanoKeySenha.Name = "textBoxCadPlanoKeySenha";
            textBoxCadPlanoKeySenha.Size = new Size(201, 29);
            textBoxCadPlanoKeySenha.TabIndex = 77;
            // 
            // comboBoxPlanoAplicativo
            // 
            comboBoxPlanoAplicativo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPlanoAplicativo.FormattingEnabled = true;
            comboBoxPlanoAplicativo.Location = new Point(117, 119);
            comboBoxPlanoAplicativo.Name = "comboBoxPlanoAplicativo";
            comboBoxPlanoAplicativo.Size = new Size(268, 29);
            comboBoxPlanoAplicativo.TabIndex = 78;
            // 
            // comboBoxPlanoCliente
            // 
            comboBoxPlanoCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPlanoCliente.FormattingEnabled = true;
            comboBoxPlanoCliente.Location = new Point(117, 169);
            comboBoxPlanoCliente.Name = "comboBoxPlanoCliente";
            comboBoxPlanoCliente.Size = new Size(268, 29);
            comboBoxPlanoCliente.TabIndex = 79;
            // 
            // FormCadastraPlano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 419);
            Controls.Add(comboBoxPlanoCliente);
            Controls.Add(comboBoxPlanoAplicativo);
            Controls.Add(textBoxCadPlanoKeySenha);
            Controls.Add(textBoxCadPlanoMacEmail);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(buttonLimparPlano);
            Controls.Add(buttonSalvarPlano);
            Controls.Add(textBoxDescricaoPlano);
            Controls.Add(label1);
            Controls.Add(labelDadosServ);
            MaximizeBox = false;
            MaximumSize = new Size(426, 458);
            MinimizeBox = false;
            MinimumSize = new Size(426, 458);
            Name = "FormCadastraPlano";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastra Plano";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLimparPlano;
        private Button buttonSalvarPlano;
        private TextBox textBoxDescricaoPlano;
        private Label label1;
        private Label labelDadosServ;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxCadPlanoMacEmail;
        private TextBox textBoxCadPlanoKeySenha;
        private ComboBox comboBoxPlanoAplicativo;
        private ComboBox comboBoxPlanoCliente;
    }
}