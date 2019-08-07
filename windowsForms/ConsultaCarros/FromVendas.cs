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
    public partial class FromVendas : Form
    {
        public FromVendas()
        {
            InitializeComponent();
        }

        private void FromVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'queryInnerJoinDataSet.Vendas'. Você pode movê-la ou removê-la conforme necessário.
           // this.vendasTableAdapter.Fill(this.queryInnerJoinDataSet.Vendas);
            this.vendasTableAdapter.fillGetByAtivos(this.queryInnerJoinDataSet.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendaSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
               ConsultaCarros.queryInnerJoinDataSet.VendasRow;

            this.vendasTableAdapter.DeleteQuery(vendaSelect.Id);
          //  this.vendasTableAdapter.GetDataByAtivos();
        }
    }
}
