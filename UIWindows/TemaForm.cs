using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FestaInfantil.Bll;
using FestaInfantil.Dal;
using FestaInfantil.Models;


namespace UIWindows
{
    public partial class TemaForm : Form
    {
        public TemaForm()
        {
            InitializeComponent();
            //AtualizaGrid();
        }

        public void AtualizaGrid()
        {
          
                // Comunicação com a Camada BLL
                TemaBll obj = new TemaBll();
                temaDataGridView.DataSource = obj.Listagem();

                // Atualizando os objetos TextBox

                txtCodigo.Text = temaDataGridView[0, temaDataGridView.CurrentRow.Index].Value.ToString();
                txtCorToalha.Text = temaDataGridView[1, temaDataGridView.CurrentRow.Index].Value.ToString();
                txtDescricao.Text = temaDataGridView[2, temaDataGridView.CurrentRow.Index].Value.ToString();


        }

       

        private void btnListar_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void TemaForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = null;
            txtCorToalha.Text = null;
            txtDescricao.Text = null;           
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Tema tema = new Tema();

                tema.TemaFesta = txtDescricao.Text;
                tema.CorToalhaMesa = txtCorToalha.Text;


                TemaBll obj = new TemaBll();
                obj.Incluir(tema);

                MessageBox.Show("O tema foi incluído com sucesso!");

                txtCodigo.Text = Convert.ToString(tema.IdTema);
                AtualizaGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void temaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = temaDataGridView[0, temaDataGridView.CurrentRow.Index].Value.ToString();
            txtDescricao.Text = temaDataGridView[1, temaDataGridView.CurrentRow.Index].Value.ToString();
            txtCorToalha.Text = temaDataGridView[2, temaDataGridView.CurrentRow.Index].Value.ToString();
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um tema deve ser selecionado para alteração.");
            }
            else

                try

                {

                    Tema tema = new Tema();
                    tema.IdTema = int.Parse(txtCodigo.Text);

                    tema.TemaFesta = txtDescricao.Text;
                    tema.CorToalhaMesa = txtCorToalha.Text;

                    TemaBll obj = new TemaBll();
                    
                    obj.Alterar(tema);

                    MessageBox.Show("O tema foi alterado com sucesso!");

                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um tema deve ser selecionado antes da exclusão.");
            }

            else
                try
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);

                    TemaBll obj = new TemaBll();

                    obj.Excluir(codigo);

                    MessageBox.Show("O tema foi excluído com sucesso!");

                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
