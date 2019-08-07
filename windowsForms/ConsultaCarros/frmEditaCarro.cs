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
    public partial class frmEditaCarro : Form
    {
        public ConsultaCarros.queryInnerJoinDataSet.CarrosRow CarrosRow;

        public frmEditaCarro()
        {
            InitializeComponent();
        }

        private void FrmEditaCarro_Load(object sender, EventArgs e)
        {       
            this.marcasTableAdapter.queryMarcas(this.queryInnerJoinDataSet.Marcas);
            txModelo.Text = CarrosRow.Modelo;
            dataFab.Value = CarrosRow.DatAlt;
            cbMarcas.SelectedValue = CarrosRow.Marca;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CarrosRow.Modelo = txModelo.Text;
            CarrosRow.DatAlt = dataFab.Value;
            CarrosRow.Marca = (int)cbMarcas.SelectedValue;
            this.Close();

            
        }
    }
}
