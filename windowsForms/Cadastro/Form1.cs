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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'queryInnerJoinDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Fill(this.queryInnerJoinDataSet.Carros);
            // TODO: esta linha de código carrega dados na tabela 'agendaDataSet.contatos'. Você pode movê-la ou removê-la conforme necessário.
            this.contatosTableAdapter.Fill(this.agendaDataSet.contatos);
            // TODO: esta linha de código carrega dados na tabela 'queryInnerJoinDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Fill(this.queryInnerJoinDataSet.Carros);

        }

        private void Btgravar_Click(object sender, EventArgs e)
        {
            carrosTableAdapter.FillBy(queryInnerJoinDataSet.Carros, 9);

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
