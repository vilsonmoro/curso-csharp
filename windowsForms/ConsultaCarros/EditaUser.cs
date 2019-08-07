using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCarros
{
    public partial class EditaUser : Form
    {
        public ConsultaCarros.queryInnerJoinDataSet.UsuariosRow RowUser;
        public EditaUser()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RowUser.Usuario = txNome.Text;
            RowUser.Ativo = chAtivo.Checked ? true : false;
            RowUser.UsuAlt = (int)comboBox1.SelectedValue;
            this.Close();
        }

        private void EditaUser_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'queryInnerJoinDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.queryInnerJoinDataSet.Usuarios);
            txNome.Text = RowUser.Usuario;
            chAtivo.Checked = RowUser.Ativo;
            comboBox1.SelectedValue = RowUser.UsuInc;
           
        }
    }
}
