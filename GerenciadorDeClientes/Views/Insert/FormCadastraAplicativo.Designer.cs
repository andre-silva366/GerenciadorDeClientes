namespace GerenciadorDeClientes
{
    partial class FormCadastraAplicativo
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
            buttonLimparCadastroAplicativo = new Button();
            buttonSalvarAplicativo = new Button();
            textBoxNomeAplicativo = new TextBox();
            label1 = new Label();
            labelDadosServ = new Label();
            textBoxCadastraSiteApp = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonLimparCadastroAplicativo
            // 
            buttonLimparCadastroAplicativo.BackColor = Color.White;
            buttonLimparCadastroAplicativo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCadastroAplicativo.ForeColor = SystemColors.ActiveCaptionText;
            buttonLimparCadastroAplicativo.Location = new Point(20, 169);
            buttonLimparCadastroAplicativo.Name = "buttonLimparCadastroAplicativo";
            buttonLimparCadastroAplicativo.Size = new Size(110, 54);
            buttonLimparCadastroAplicativo.TabIndex = 2;
            buttonLimparCadastroAplicativo.Text = "Limpar";
            buttonLimparCadastroAplicativo.UseVisualStyleBackColor = false;
            buttonLimparCadastroAplicativo.Click += buttonLimparCadastroAplicativo_Click;
            // 
            // buttonSalvarAplicativo
            // 
            buttonSalvarAplicativo.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarAplicativo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvarAplicativo.ForeColor = SystemColors.ButtonFace;
            buttonSalvarAplicativo.Location = new Point(215, 169);
            buttonSalvarAplicativo.Name = "buttonSalvarAplicativo";
            buttonSalvarAplicativo.Size = new Size(109, 54);
            buttonSalvarAplicativo.TabIndex = 1;
            buttonSalvarAplicativo.Text = "Salvar";
            buttonSalvarAplicativo.UseVisualStyleBackColor = false;
            buttonSalvarAplicativo.Click += buttonSalvarAplicativo_Click;
            // 
            // textBoxNomeAplicativo
            // 
            textBoxNomeAplicativo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomeAplicativo.Location = new Point(89, 64);
            textBoxNomeAplicativo.Name = "textBoxNomeAplicativo";
            textBoxNomeAplicativo.Size = new Size(235, 29);
            textBoxNomeAplicativo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 66);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 62;
            label1.Text = "Nome: ";
            // 
            // labelDadosServ
            // 
            labelDadosServ.AutoSize = true;
            labelDadosServ.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDadosServ.Location = new Point(20, 19);
            labelDadosServ.Name = "labelDadosServ";
            labelDadosServ.Size = new Size(286, 25);
            labelDadosServ.TabIndex = 61;
            labelDadosServ.Text = "Preencha os dados do Aplicativo";
            // 
            // textBoxCadastraSiteApp
            // 
            textBoxCadastraSiteApp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCadastraSiteApp.Location = new Point(89, 113);
            textBoxCadastraSiteApp.Name = "textBoxCadastraSiteApp";
            textBoxCadastraSiteApp.Size = new Size(235, 29);
            textBoxCadastraSiteApp.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 115);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 64;
            label2.Text = "Site: ";
            // 
            // FormCadastraAplicativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 255);
            Controls.Add(textBoxCadastraSiteApp);
            Controls.Add(label2);
            Controls.Add(buttonLimparCadastroAplicativo);
            Controls.Add(buttonSalvarAplicativo);
            Controls.Add(textBoxNomeAplicativo);
            Controls.Add(label1);
            Controls.Add(labelDadosServ);
            MaximizeBox = false;
            MaximumSize = new Size(362, 294);
            MinimizeBox = false;
            MinimumSize = new Size(362, 294);
            Name = "FormCadastraAplicativo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Aplicativo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLimparCadastroAplicativo;
        private Button buttonSalvarAplicativo;
        private TextBox textBoxNomeAplicativo;
        private Label label1;
        private Label labelDadosServ;
        private TextBox textBoxCadastraSiteApp;
        private Label label2;
    }
}