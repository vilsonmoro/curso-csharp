namespace TesteSession
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txUser = new System.Windows.Forms.TextBox();
            this.mksenha = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contatosTableAdapter1 = new TesteSession.AgendaDataSetTableAdapters.contatosTableAdapter();
            this.contatosTableAdapter2 = new TesteSession.AgendaDataSetTableAdapters.contatosTableAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(141, 34);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(266, 22);
            this.txUser.TabIndex = 2;
            // 
            // mksenha
            // 
            this.mksenha.Location = new System.Drawing.Point(141, 92);
            this.mksenha.Name = "mksenha";
            this.mksenha.PasswordChar = '*';
            this.mksenha.Size = new System.Drawing.Size(266, 22);
            this.mksenha.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // contatosTableAdapter1
            // 
            this.contatosTableAdapter1.ClearBeforeFill = true;
            // 
            // contatosTableAdapter2
            // 
            this.contatosTableAdapter2.ClearBeforeFill = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mksenha);
            this.Controls.Add(this.txUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "Login do usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.MaskedTextBox mksenha;
        private System.Windows.Forms.Button button1;
        private AgendaDataSetTableAdapters.contatosTableAdapter contatosTableAdapter1;
        private AgendaDataSetTableAdapters.contatosTableAdapter contatosTableAdapter2;
    }
}

