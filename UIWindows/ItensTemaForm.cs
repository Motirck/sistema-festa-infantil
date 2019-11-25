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
using FestaInfantil.Models;

namespace UIWindows
{
    public partial class ItensTemaForm : Form
    {
        public ItensTemaForm()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            // Comunicação com a Camada BLL
            ItensTemaBll obj = new ItensTemaBll();
            itemDataGridView.DataSource = obj.Listagem();

            // Atualizando os objetos TextBox

            txtCodigo.Text = itemDataGridView[0, itemDataGridView.CurrentRow.Index].Value.ToString();
            txtDescricao.Text = itemDataGridView[2, itemDataGridView.CurrentRow.Index].Value.ToString();
            txtValor.Text = itemDataGridView[3, itemDataGridView.CurrentRow.Index].Value.ToString();
        }
        public void CarregaCombo()
        {
            ItensTemaBll obj = new ItensTemaBll();
            cmbTema.DataSource = obj.ListagemTema();
            cmbTema.DisplayMember = "temaFesta";
            cmbTema.ValueMember = "idTema";
        }

        private void ItensTemaForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            CarregaCombo();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                ItensTema itensTema = new ItensTema();

                itensTema.IdTema = (int)cmbTema.SelectedValue;
                itensTema.Nomeitem = txtDescricao.Text;
                itensTema.ValorItem = float.Parse(txtValor.Text);



                ItensTemaBll obj = new ItensTemaBll();
                obj.Incluir(itensTema);

                MessageBox.Show("O item foi incluído com sucesso!");

                txtCodigo.Text = Convert.ToString(itensTema.IdItensTema);
                AtualizaGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um item deve ser selecionado para alteração.");
            }
            else

                try

                {

                    ItensTema itensTema = new ItensTema();

                    itensTema.IdItensTema = int.Parse(txtCodigo.Text);

                    itensTema.IdTema = (int)cmbTema.SelectedValue;
                    itensTema.Nomeitem = txtDescricao.Text;
                    itensTema.ValorItem = float.Parse(txtValor.Text);

                    ItensTemaBll obj = new ItensTemaBll();

                    obj.Alterar(itensTema);

                    MessageBox.Show("O item foi alterado com sucesso!");

                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
        }

        private void itemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = itemDataGridView[0, itemDataGridView.CurrentRow.Index].Value.ToString();
            txtDescricao.Text = itemDataGridView[2, itemDataGridView.CurrentRow.Index].Value.ToString();
            txtValor.Text = itemDataGridView[3, itemDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = null;
            txtDescricao.Text = null;
            txtValor.Text = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um usuario deve ser selecionado antes da exclusão.");
            }

            else
                try
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);

                    ItensTemaBll obj = new ItensTemaBll();

                    obj.Excluir(codigo);

                    MessageBox.Show("O item foi excluído com sucesso!");

                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
    }
}
