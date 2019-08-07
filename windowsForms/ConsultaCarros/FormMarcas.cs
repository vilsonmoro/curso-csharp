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
    public partial class FormMarcas : Form
    {
        public FormMarcas()
        {
            InitializeComponent();
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'queryInnerJoinDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.queryInnerJoinDataSet.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcaSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                ConsultaCarros.queryInnerJoinDataSet.MarcasRow;

            this.marcasTableAdapter.DeleteQuery(marcaSelect.Id);
            this.marcasTableAdapter.Fill(this.queryInnerJoinDataSet.Marcas);
        }
    }
}
