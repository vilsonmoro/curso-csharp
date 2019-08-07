namespace ConsultaCarros
{
    partial class frmEditaCarro
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
            this.txModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataFab = new System.Windows.Forms.DateTimePicker();
            this.cbMarcas = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queryInnerJoinDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queryInnerJoinDataSet = new ConsultaCarros.queryInnerJoinDataSet();
            this.marcasTableAdapter = new ConsultaCarros.queryInnerJoinDataSetTableAdapters.MarcasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryInnerJoinDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryInnerJoinDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // txModelo
            // 
            this.txModelo.Location = new System.Drawing.Point(100, 33);
            this.txModelo.Name = "txModelo";
            this.txModelo.Size = new System.Drawing.Size(277, 22);
            this.txModelo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca";
            // 
            // dataFab
            // 
            this.dataFab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFab.Location = new System.Drawing.Point(100, 73);
            this.dataFab.Name = "dataFab";
            this.dataFab.Size = new System.Drawing.Size(168, 22);
            this.dataFab.TabIndex = 4;
            // 
            // cbMarcas
            // 
            this.cbMarcas.DataSource = this.marcasBindingSource;
            this.cbMarcas.DisplayMember = "Nome";
            this.cbMarcas.FormattingEnabled = true;
            this.cbMarcas.Location = new System.Drawing.Point(100, 113);
            this.cbMarcas.Name = "cbMarcas";
            this.cbMarcas.Size = new System.Drawing.Size(277, 24);
            this.cbMarcas.TabIndex = 5;
            this.cbMarcas.ValueMember = "Id";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.queryInnerJoinDataSetBindingSource;
            // 
            // queryInnerJoinDataSetBindingSource
            // 
            this.queryInnerJoinDataSetBindingSource.DataSource = this.queryInnerJoinDataSet;
            this.queryInnerJoinDataSetBindingSource.Position = 0;
            // 
            // queryInnerJoinDataSet
            // 
            this.queryInnerJoinDataSet.DataSetName = "queryInnerJoinDataSet";
            this.queryInnerJoinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salavar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmEditaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMarcas);
            this.Controls.Add(this.dataFab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txModelo);
            this.Controls.Add(this.label1);
            this.Name = "frmEditaCarro";
            this.Text = "frmEditaCarro";
            this.Load += new System.EventHandler(this.FrmEditaCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryInnerJoinDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryInnerJoinDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataFab;
        private System.Windows.Forms.ComboBox cbMarcas;
        private System.Windows.Forms.BindingSource queryInnerJoinDataSetBindingSource;
        private queryInnerJoinDataSet queryInnerJoinDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private queryInnerJoinDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}