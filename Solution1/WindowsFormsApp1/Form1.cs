using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string estabeleceConexao()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HBSIS\Source\Repos\vilsonmoro\curso-csharp\Solution1\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
        }

        private void BtSelect_Click(object sender, EventArgs e)
        {
            string strcon = estabeleceConexao();
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM contatos", conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ds.Tables[0].TableName;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                //throw;
            }

            finally
            {
                conexao.Close();
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            string strcon = estabeleceConexao();
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("insert into contatos (nome, fone) Values ('" + txNome.Text + "','"+txFone.Text+"')", conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                BtSelect_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txFone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            btnExcluir.Enabled = true;
           
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            string strcon = estabeleceConexao();
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("delete from contatos where id = '" + txId.Text + "'", conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                BtSelect_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
                btnExcluir.Enabled = false;
                MessageBox.Show("Registro excluído com sucesso");
            }
        }
    }
}


