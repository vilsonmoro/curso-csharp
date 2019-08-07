namespace ConsultaCarros.insert
{
    partial class FormInsertUser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chAtivo = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queryInnerJoinDataSet = new ConsultaCarros.queryInnerJoinDataSet();
            this.usuariosTableAdapter = new ConsultaCarros.queryInnerJoinDataSetTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryInnerJoinDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
           // this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(104, 26);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(260, 22);
            this.txNome.TabIndex = 1;
          //  this.txNome.TextChanged += new System.EventHandler(this.TxNome_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // chAtivo
            // 
            this.chAtivo.AutoSize = true;
            this.chAtivo.Location = new System.Drawing.Point(104, 71);
            this.chAtivo.Name = "chAtivo";
            this.chAtivo.Size = new System.Drawing.Size(61, 21);
            this.chAtivo.TabIndex = 3;
            this.chAtivo.Text = "Ativo";
            this.chAtivo.UseVisualStyleBackColor = true;
           // this.chAtivo.CheckedChanged += new System.EventHandler(this.ChAtivo_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usuariosBindingSource;
            this.comboBox1.DisplayMember = "Usuario";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Id";
          //  this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.queryInnerJoinDataSet;
            // 
            // queryInnerJoinDataSet
            // 
            this.queryInnerJoinDataSet.DataSetName = "queryInnerJoinDataSet";
            this.queryInnerJoinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FormInsertUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 316);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chAtivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label1);
            this.Name = "FormInsertUser";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FormInsertUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryInnerJoinDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chAtivo;
        private System.Windows.Forms.ComboBox comboBox1;
        private queryInnerJoinDataSet queryInnerJoinDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private queryInnerJoinDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}