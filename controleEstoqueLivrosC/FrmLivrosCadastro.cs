using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleEstoqueLivrosC
{
    public partial class FrmLivrosCadastro : Form
    { 
        int id;
        bool excluir = false;
        Livro livro = new Livro();
    
        public FrmLivrosCadastro(int id, bool excluir = false)  //construtor ooque instancia o objeto/ 
        {
            InitializeComponent();
            this.id = id;
            this.excluir = excluir;

            if(this.id > 0)
            {
                livro.GetLivro(this.id);   //Metodo getLivro/

                lblId.Text = livro.Id.ToString();
                txtIsbn.Text = livro.Isbn;
                txtTitulo.Text = livro.Titulo;
                txtAutor.Text = livro.Autores;
                txtPrecoUnitario.Text = livro.Unitario.ToString("N2");
                txtSaldoInicial.Text = livro.Saldo_Inicial.ToString();
                txtEstoqueMinimo.Text = livro.Estoque_minimo.ToString();
                if (livro.Ativo == 'S')
                     cnkAtivo.Checked = true;
            }

            if( this.excluir)
            {
                TravarControles();
                btnSalvar.Visible = false;
                btnExcluir.Visible = true;
            }
        }

        private void TravarControles()
        {
            txtIsbn.Enabled = false;
            txtTitulo.Enabled = false;
            txtAutor.Enabled = false;
            txtPrecoUnitario.Enabled = false;
            txtPrecoUnitario.Enabled = false;
            txtSaldoInicial.Enabled = false;
            txtEstoqueMinimo.Enabled = false;
            cnkAtivo.Enabled = false;
        }
    

        private void FrmLivrosCadastro_Load(object sender, EventArgs e)
        {


         
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                livro.Isbn = txtIsbn.Text;
                livro.Titulo = txtTitulo.Text;
                livro.Autores = txtAutor.Text;
                livro.Unitario = Convert.ToDecimal("0" + txtPrecoUnitario.Text);
                livro.Saldo_Inicial = Convert.ToInt32("0" + txtSaldoInicial.Text);
                livro.Estoque_minimo = Convert.ToInt32("0" + txtEstoqueMinimo.Text);
                if (cnkAtivo.Checked == true)
                    livro.Ativo = 'S';
                else
                    livro.Ativo = 'N';

                livro.SalvarLivro();
                this.Close();

            }
        }

        private bool ValidarForm()
        {
            if (txtIsbn.Text == "")
            {
                MessageBox.Show("Informe o ISBN do Livro", Program.sistema);
                txtIsbn.Focus();
                return false;
            }
            else if (txtTitulo.Text == "")
            {
                MessageBox.Show("Informe o titulo do Livro", Program.sistema);
                txtTitulo.Focus();
                return false;
            }
            else if (txtAutor.Text == "")
            {
                MessageBox.Show("Informe o Autor do Livro", Program.sistema);
                txtAutor.Focus();
                return false;

            }
            else if (Convert.ToDecimal("0" + txtPrecoUnitario.Text) == 0)
            {
                MessageBox.Show("Informe o preço do Livro", Program.sistema);
                txtPrecoUnitario.Focus();
                return false;
            }
            else
                return true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            livro.Excluir();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
