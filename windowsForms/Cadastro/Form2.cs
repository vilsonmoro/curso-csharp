using Cadastro.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FCadContato : Form
    {
        public Contato ct = new Contato();
        public FCadContato()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ct.Nome = txnome.Text;
            ct.Fone = txfone.Text;

            this.Close();
        }
    }
}
