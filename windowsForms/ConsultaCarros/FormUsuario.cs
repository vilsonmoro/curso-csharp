using ConsultaCarros.insert;
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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'queryInnerJoinDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.queryInnerJoinDataSet.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                ConsultaCarros.queryInnerJoinDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    { this.usuariosTableAdapter.DeleteQuery(userSelect.Id); }
                    break;
                case 1:
                    {
                        EditaUser tela = new EditaUser();
                        tela.RowUser = userSelect;
                        tela.ShowDialog();
                        this.usuariosTableAdapter.UpdateQuery(userSelect.Usuario, 
                                                              userSelect.Ativo, 
                                                              userSelect.UsuAlt,
                                                              userSelect.DatAlt,
                                                              userSelect.Id);
                    } break;
                case 2:
                    {
                        FormInsertUser tela = new FormInsertUser();
                        tela.ShowDialog();
                        this.usuariosTableAdapter.Insert(tela.Nome, tela.Ativo, tela.UserCad, tela.UserCad, DateTime.Now, DateTime.Now);
                        
                    } break;
                    
            }
            this.usuariosTableAdapter.Fill(this.queryInnerJoinDataSet.Usuarios);
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((chIntivos.Checked) && (!chativos.Checked))
            {
                //mostra somente inativos
                this.usuariosTableAdapter.getInativos(this.queryInnerJoinDataSet.Usuarios);
            }

            if ((!chIntivos.Checked) && (chativos.Checked))
            {
                //mostra somente ativos
                this.usuariosTableAdapter.getAtivos(this.queryInnerJoinDataSet.Usuarios);
            }

            if ((chIntivos.Checked) && (chativos.Checked))
            {
                //mostra todos
                this.usuariosTableAdapter.Fill(this.queryInnerJoinDataSet.Usuarios);
            }

        }
    }
}
