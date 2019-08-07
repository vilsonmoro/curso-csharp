using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteSession.Classes;

namespace TesteSession
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int idUser = (int)contatosTableAdapter2.LoginQuery(txUser.Text, mksenha.Text);

            if(idUser > 0)
            {
                Session.IdUser = idUser;
                Session.NameUser = this.contatosTableAdapter2.QueryNomeByID(Classes.Session.IdUser).ToString();
                frmUser tela = new frmUser();
                tela.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário inválido");
            }
           
        }
    }
}
