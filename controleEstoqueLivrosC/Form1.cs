using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleEstoqueLivrosC
{
    public partial class Form1 : Form
    {

        DataTable dt = new DataTable();
     

        public Form1()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()        //Metodo//
        {
            dt = Livro.GetLivros();
            dgvLivros.DataSource = dt;
            ConfigurarGradeLivros();
       

        }

        private void ConfigurarGradeLivros()
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Conectar())
                MessageBox.Show("Conexão bem sucedida");
        }

        private bool Conectar()
        {
            var result = false;
            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                
                    result = false;
                    MessageBox.Show("Falha: " + ex.Message);
                }

                return result;
            }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvLivros.CurrentRow != null && dgvLivros.CurrentRow.Cells["id"].Value != null)
            {
                try
                {
                    var id = Convert.ToInt32(dgvLivros.Rows[dgvLivros.CurrentCell.RowIndex].Cells
                        ["id"].Value);

                    using (var frm = new FrmLivrosCadastro(id))
                    {
                        frm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter o ID do livro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada ou ID inválido.");
            }
        }





        private void btnAdicionar_Click(object sender, EventArgs e)
        {        

            using (var frm = new FrmLivrosCadastro(0))
            {
                frm.ShowDialog();
                dgvLivros.DataSource = Livro.GetLivros();
                dgvLivros.Refresh(); // Força o refresh da grade
                ConfigurarGradeLivros();
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dt = Livro.GetLivros(txtProcurar.Text);
            dgvLivros.DataSource = dt;
            ConfigurarGradeLivros();
            dgvLivros.Refresh();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvLivros.Rows[dgvLivros.CurrentCell.RowIndex].Cells
               ["Id"].Value);

            using (var frm = new FrmLivrosCadastro(id, true))
            {
                frm.ShowDialog();
                dgvLivros.DataSource = Livro.GetLivros();
                ConfigurarGradeLivros();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
        }

        private void btnImprimir_Click(object sender, EventArgs e)


        {
            var dt = GerarDadosRelatorio(); 
            using (var frm = new FrmLivrosRelatorio(dt, txtProcurar.Text) )
            {
                frm.ShowDialog();
            }
        }

        private DataTable GerarDadosRelatorio()
        {

            var dt = new DataTable();
            dt.Columns.Add("isbn");
            dt.Columns.Add("titulo");
            dt.Columns.Add("autores");
            dt.Columns.Add("unitario", typeof(decimal));
            
            foreach (DataGridViewRow item in dgvLivros.Rows)
            {
                dt.Rows.Add( item.Cells["isbn"].Value.ToString(),item.Cells
                ["titulo"].Value.ToString(),item.Cells["autores"].Value.ToString(),
                Convert.ToDecimal(item.Cells["unitario"].Value));
            }
            return dt;

            throw new NotImplementedException();
        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }


