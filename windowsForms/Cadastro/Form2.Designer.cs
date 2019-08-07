namespace Cadastro
{
    partial class FCadContato
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
            this.label1 = new System.Windows.Forms.Label();
            this.txnome = new System.Windows.Forms.TextBox();
            this.txfone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txnome
            // 
            this.txnome.Location = new System.Drawing.Point(86, 26);
            this.txnome.Name = "txnome";
            this.txnome.Size = new System.Drawing.Size(290, 22);
            this.txnome.TabIndex = 1;
            // 
            // txfone
            // 
            this.txfone.Location = new System.Drawing.Point(86, 66);
            this.txfone.Name = "txfone";
            this.txfone.Size = new System.Drawing.Size(290, 22);
            this.txfone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FCadContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 176);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txfone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txnome);
            this.Controls.Add(this.label1);
            this.Name = "FCadContato";
            this.Text = "Cadastro de Contatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txnome;
        private System.Windows.Forms.TextBox txfone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}