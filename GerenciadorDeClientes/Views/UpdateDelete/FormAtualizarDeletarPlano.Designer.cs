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
            buttonExcluirPlano = new Button();
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
            buttonSalvarPlanoAtualizado.Location = new Point(269, 223);
            buttonSalvarPlanoAtualizado.MaximumSize = new Size(108, 49);
            buttonSalvarPlanoAtualizado.MinimumSize = new Size(108, 49);
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
            buttonLimparCadAtuaPlan.Location = new Point(12, 223);
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
            // buttonExcluirPlano
            // 
            buttonExcluirPlano.BackColor = Color.Red;
            buttonExcluirPlano.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcluirPlano.ForeColor = SystemColors.ButtonFace;
            buttonExcluirPlano.Location = new Point(137, 223);
            buttonExcluirPlano.Name = "buttonExcluirPlano";
            buttonExcluirPlano.Size = new Size(108, 49);
            buttonExcluirPlano.TabIndex = 18;
            buttonExcluirPlano.Text = "Excluir";
            buttonExcluirPlano.UseVisualStyleBackColor = false;
            buttonExcluirPlano.Visible = false;
            buttonExcluirPlano.Click += buttonExcluirPlano_Click;
            // 
            // FormAtualizarDeletarPlano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 284);
            Controls.Add(buttonExcluirPlano);
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
        public Button buttonExcluirPlano;
        public Button buttonSalvarPlanoAtualizado;
        public Label labelPlano;
    }
}