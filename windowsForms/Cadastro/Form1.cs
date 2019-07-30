using Cadastro.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        List<Contato> listaContatos = new List<Contato>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            FCadContato formcad = new FCadContato();
            formcad.ShowDialog();

            listaContatos.Add(formcad.ct);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaContatos;
        }
    }
}
