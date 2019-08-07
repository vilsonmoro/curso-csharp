using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudCArros
{
    public partial class FrmCruCarro : Form
    {
        public FrmCruCarro()
        {
            InitializeComponent();
        }

        private void FrmCruCarro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'queryInnerJoinDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.queryInnerJoinDataSet.Marcas);

        }

       
    }
}
