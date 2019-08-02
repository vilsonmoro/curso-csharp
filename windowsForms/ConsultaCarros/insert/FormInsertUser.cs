using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCarros.insert
{
    public partial class FormInsertUser : Form
    {
        //public ConsultaCarros.queryInnerJoinDataSet.UsuariosRow RowUsuario;
        public String Nome { get; set; }
        public Boolean Ativo { get; set; }

        public int UserCad { get; set; }
        public FormInsertUser()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // RowUsuario = new queryInnerJoinDataSet.UsuariosRow(new DataRowBuilder());

            this.Nome = txNome.Text;
            this.Ativo = chAtivo.Checked ? true : false;
            this.UserCad = (int)comboBox1.SelectedValue;

            this.Close();
        }

        private void FormInsertUser_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'queryInnerJoinDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.queryInnerJoinDataSet.Usuarios);

        }

        
    }
}
