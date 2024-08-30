namespace GerenciadorDeClientes
{
    partial class FormCadastraServidor
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
            labelDadosServ = new Label();
            label1 = new Label();
            textBoxNomeServidor = new TextBox();
            buttonSalvarServidor = new Button();
            buttonLimparCadastroServidor = new Button();
            SuspendLayout();
            // 
            // labelDadosServ
            // 
            labelDadosServ.AutoSize = true;
            labelDadosServ.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDadosServ.Location = new Point(12, 19);
            labelDadosServ.Name = "labelDadosServ";
            labelDadosServ.Size = new Size(273, 25);
            labelDadosServ.TabIndex = 56;
            labelDadosServ.Text = "Preencha os dados do Servidor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 57;
            label1.Text = "Nome: ";
            // 
            // textBoxNomeServidor
            // 
            textBoxNomeServidor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomeServidor.Location = new Point(81, 64);
            textBoxNomeServidor.Name = "textBoxNomeServidor";
            textBoxNomeServidor.Size = new Size(204, 29);
            textBoxNomeServidor.TabIndex = 0;
            // 
            // buttonSalvarServidor
            // 
            buttonSalvarServidor.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarServidor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvarServidor.ForeColor = SystemColors.ButtonFace;
            buttonSalvarServidor.Location = new Point(176, 139);
            buttonSalvarServidor.Name = "buttonSalvarServidor";
            buttonSalvarServidor.Size = new Size(109, 54);
            buttonSalvarServidor.TabIndex = 1;
            buttonSalvarServidor.Text = "Salvar";
            buttonSalvarServidor.UseVisualStyleBackColor = false;
            buttonSalvarServidor.Click += buttonSalvarServidor_Click;
            // 
            // buttonLimparCadastroServidor
            // 
            buttonLimparCadastroServidor.BackColor = Color.White;
            buttonLimparCadastroServidor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCadastroServidor.ForeColor = SystemColors.ActiveCaptionText;
            buttonLimparCadastroServidor.Location = new Point(12, 139);
            buttonLimparCadastroServidor.Name = "buttonLimparCadastroServidor";
            buttonLimparCadastroServidor.Size = new Size(110, 54);
            buttonLimparCadastroServidor.TabIndex = 2;
            buttonLimparCadastroServidor.Text = "Limpar";
            buttonLimparCadastroServidor.UseVisualStyleBackColor = false;
            buttonLimparCadastroServidor.Click += buttonLimparCadastroServidor_Click;
            // 
            // FormCadastraServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 213);
            Controls.Add(buttonLimparCadastroServidor);
            Controls.Add(buttonSalvarServidor);
            Controls.Add(textBoxNomeServidor);
            Controls.Add(label1);
            Controls.Add(labelDadosServ);
            MaximizeBox = false;
            MaximumSize = new Size(329, 252);
            MinimizeBox = false;
            MinimumSize = new Size(329, 252);
            Name = "FormCadastraServidor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Servidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDadosServ;
        private Label label1;
        private TextBox textBoxNomeServidor;
        private Button buttonSalvarServidor;
        private Button buttonLimparCadastroServidor;
    }
}