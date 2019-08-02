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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'queryInnerJoinDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Fill(this.queryInnerJoinDataSet.Carros);

        }

        private void CheckBox1_Click(object sender, EventArgs e)
        {
            txmarca.Enabled = ckmarca.Checked;
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            if (ckmarca.Checked)
                carrosTableAdapter.FillByMarca(queryInnerJoinDataSet.Carros, int.Parse(txmarca.Text));
            else
                carrosTableAdapter.Fill(queryInnerJoinDataSet.Carros);
        }
    

         private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                ConsultaCarros.queryInnerJoinDataSet.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0: {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                        this.carrosTableAdapter.Fill(this.queryInnerJoinDataSet.Carros);
                    } break;
                case 1: {
                        frmEditaCarro tela = new frmEditaCarro();
                        tela.CarrosRow = carSelect;
                        tela.ShowDialog();
                        this.carrosTableAdapter.Update(carSelect);
                        //this.carrosTableAdapter.UpdateQuery(carSelect.Ano, carSelect.Marca, DateTime.Now, carSelect.Id) ;

                    } break;
            }

           
        }

        private void BtUser_Click(object sender, EventArgs e)
        {
            FormUsuario tela = new FormUsuario();
            tela.Show();
        }

        private void BtVenda_Click(object sender, EventArgs e)
        {
            FromVendas tela = new FromVendas();
            tela.Show();
        }
    }

}

