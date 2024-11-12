namespace GerenciadorDeClientes.Views.Update
{
    partial class FormAtualizarDeletarAplicativo
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
            textBoxIdAplicativoAtual = new TextBox();
            buttonBuscarAppIdAtua = new Button();
            buttonSalvarAppAtualizado = new Button();
            buttonLimparCadAtuaApp = new Button();
            textBoxNomeAppAtual = new TextBox();
            label3 = new Label();
            labelAplicativo = new Label();
            buttonExcluirApp = new Button();
            textBoxAtuaDelSiteApp = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 21);
            label1.TabIndex = 1;
            label1.Text = "Digite o id do aplicativo: ";
            // 
            // textBoxIdAplicativoAtual
            // 
            textBoxIdAplicativoAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIdAplicativoAtual.Location = new Point(189, 6);
            textBoxIdAplicativoAtual.Name = "textBoxIdAplicativoAtual";
            textBoxIdAplicativoAtual.Size = new Size(100, 29);
            textBoxIdAplicativoAtual.TabIndex = 2;
            // 
            // buttonBuscarAppIdAtua
            // 
            buttonBuscarAppIdAtua.BackColor = Color.FromArgb(0, 192, 0);
            buttonBuscarAppIdAtua.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarAppIdAtua.ForeColor = SystemColors.ButtonFace;
            buttonBuscarAppIdAtua.Location = new Point(189, 41);
            buttonBuscarAppIdAtua.Name = "buttonBuscarAppIdAtua";
            buttonBuscarAppIdAtua.Size = new Size(100, 31);
            buttonBuscarAppIdAtua.TabIndex = 8;
            buttonBuscarAppIdAtua.Text = "Buscar";
            buttonBuscarAppIdAtua.UseVisualStyleBackColor = false;
            buttonBuscarAppIdAtua.Click += buttonBuscarAppIdAtua_Click;
            // 
            // buttonSalvarAppAtualizado
            // 
            buttonSalvarAppAtualizado.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarAppAtualizado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvarAppAtualizado.ForeColor = SystemColors.ButtonFace;
            buttonSalvarAppAtualizado.Location = new Point(181, 234);
            buttonSalvarAppAtualizado.Name = "buttonSalvarAppAtualizado";
            buttonSalvarAppAtualizado.Size = new Size(108, 36);
            buttonSalvarAppAtualizado.TabIndex = 13;
            buttonSalvarAppAtualizado.Text = "Salvar";
            buttonSalvarAppAtualizado.UseVisualStyleBackColor = false;
            buttonSalvarAppAtualizado.Click += buttonSalvarAppAtualizado_Click;
            // 
            // buttonLimparCadAtuaApp
            // 
            buttonLimparCadAtuaApp.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCadAtuaApp.Location = new Point(12, 234);
            buttonLimparCadAtuaApp.Name = "buttonLimparCadAtuaApp";
            buttonLimparCadAtuaApp.Size = new Size(108, 36);
            buttonLimparCadAtuaApp.TabIndex = 12;
            buttonLimparCadAtuaApp.Text = "Limpar";
            buttonLimparCadAtuaApp.UseVisualStyleBackColor = true;
            buttonLimparCadAtuaApp.Click += buttonLimparCadAtuaApp_Click;
            // 
            // textBoxNomeAppAtual
            // 
            textBoxNomeAppAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomeAppAtual.Location = new Point(78, 139);
            textBoxNomeAppAtual.Name = "textBoxNomeAppAtual";
            textBoxNomeAppAtual.Size = new Size(211, 29);
            textBoxNomeAppAtual.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 10;
            label3.Text = "Nome: ";
            // 
            // labelAplicativo
            // 
            labelAplicativo.AutoSize = true;
            labelAplicativo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAplicativo.Location = new Point(12, 95);
            labelAplicativo.Name = "labelAplicativo";
            labelAplicativo.Size = new Size(146, 21);
            labelAplicativo.TabIndex = 9;
            labelAplicativo.Text = "Dados do aplicativo";
            // 
            // buttonExcluirApp
            // 
            buttonExcluirApp.BackColor = Color.Red;
            buttonExcluirApp.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcluirApp.ForeColor = SystemColors.ButtonFace;
            buttonExcluirApp.Location = new Point(181, 291);
            buttonExcluirApp.Name = "buttonExcluirApp";
            buttonExcluirApp.Size = new Size(108, 36);
            buttonExcluirApp.TabIndex = 14;
            buttonExcluirApp.Text = "Excluir";
            buttonExcluirApp.UseVisualStyleBackColor = false;
            buttonExcluirApp.Visible = false;
            buttonExcluirApp.Click += buttonExcluirApp_Click;
            // 
            // textBoxAtuaDelSiteApp
            // 
            textBoxAtuaDelSiteApp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAtuaDelSiteApp.Location = new Point(78, 184);
            textBoxAtuaDelSiteApp.Name = "textBoxAtuaDelSiteApp";
            textBoxAtuaDelSiteApp.Size = new Size(211, 29);
            textBoxAtuaDelSiteApp.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 187);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 15;
            label2.Text = "Site: ";
            // 
            // FormAtualizarDeletarAplicativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 339);
            Controls.Add(textBoxAtuaDelSiteApp);
            Controls.Add(label2);
            Controls.Add(buttonExcluirApp);
            Controls.Add(buttonSalvarAppAtualizado);
            Controls.Add(buttonLimparCadAtuaApp);
            Controls.Add(textBoxNomeAppAtual);
            Controls.Add(label3);
            Controls.Add(labelAplicativo);
            Controls.Add(buttonBuscarAppIdAtua);
            Controls.Add(textBoxIdAplicativoAtual);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAtualizarDeletarAplicativo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar aplicativo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxIdAplicativoAtual;
        private Button buttonBuscarAppIdAtua;
        private Button buttonLimparCadAtuaApp;
        private TextBox textBoxNomeAppAtual;
        private Label label3;
        public Button buttonExcluirApp;
        public Button buttonSalvarAppAtualizado;
        public Label labelAplicativo;
        private TextBox textBoxAtuaDelSiteApp;
        private Label label2;
    }
}