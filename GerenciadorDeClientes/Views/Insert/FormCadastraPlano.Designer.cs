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
            label2 = new Label();
            textBoxValorPlano = new TextBox();
            SuspendLayout();
            // 
            // buttonLimparPlano
            // 
            buttonLimparPlano.BackColor = Color.White;
            buttonLimparPlano.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparPlano.ForeColor = SystemColors.ActiveCaptionText;
            buttonLimparPlano.Location = new Point(109, 167);
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
            buttonSalvarPlano.Location = new Point(276, 167);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 114);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 63;
            label2.Text = "Valor: ";
            // 
            // textBoxValorPlano
            // 
            textBoxValorPlano.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxValorPlano.Location = new Point(109, 111);
            textBoxValorPlano.Name = "textBoxValorPlano";
            textBoxValorPlano.Size = new Size(110, 29);
            textBoxValorPlano.TabIndex = 1;
            // 
            // FormCadastraPlano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 239);
            Controls.Add(textBoxValorPlano);
            Controls.Add(label2);
            Controls.Add(buttonLimparPlano);
            Controls.Add(buttonSalvarPlano);
            Controls.Add(textBoxDescricaoPlano);
            Controls.Add(label1);
            Controls.Add(labelDadosServ);
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Label label2;
        private TextBox textBoxValorPlano;
    }
}