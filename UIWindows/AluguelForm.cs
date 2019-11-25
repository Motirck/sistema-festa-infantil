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
    public partial class AluguelForm : Form
    {
        public AluguelForm()
        {
            InitializeComponent();
        }

        public void CarregaCombo()
        {
            AluguelBll obj = new AluguelBll();
            cmbCliente.DataSource = obj.ListagemCliente();
            cmbCliente.DisplayMember = "nomeUsuario";
            cmbCliente.ValueMember = "idUsuario";

            cmbTema.DataSource = obj.ListagemTema();
            cmbTema.DisplayMember = "temaFesta";
            cmbTema.ValueMember = "idTema";
        }

        public void AtualizaGrid()
        {
            // Comunicação com a Camada BLL
            AluguelBll obj = new AluguelBll();
            aluguelDataGridView.DataSource = obj.Listagem();

            // Atualizando os objetos TextBox

            txtCodigo.Text = aluguelDataGridView[0, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            txtEndereco.Text = aluguelDataGridView[3, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            mtxtData.Text = aluguelDataGridView[4, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            mtxtHoraInicio.Text = aluguelDataGridView[5, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            mtxtHoraFim.Text = aluguelDataGridView[6, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            txtNumeroPessoas.Text = aluguelDataGridView[7, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            txtValorAluguel.Text = aluguelDataGridView[8, aluguelDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AluguelForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            CarregaCombo();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Aluguel aluguel = new Aluguel();

                aluguel.IdUsuario = (int)cmbCliente.SelectedValue;
                aluguel.IdTema = (int)cmbTema.SelectedValue;
                aluguel.EnderecoUsuario = txtEndereco.Text;
                aluguel.DataFesta = mtxtData.Text;
                aluguel.HoraInicio = mtxtHoraInicio.Text;
                aluguel.HoraFim = mtxtHoraFim.Text;
                aluguel.NumeroPessoas = int.Parse(txtNumeroPessoas.Text);
                aluguel.ValorAluguel = float.Parse(txtValorAluguel.Text);


                AluguelBll obj = new AluguelBll();
                obj.Incluir(aluguel);

                MessageBox.Show("O aluguel   foi incluído com sucesso!");

                txtCodigo.Text = Convert.ToString(aluguel.IdAluguel                                                                                             );
                AtualizaGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void aluguelDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = aluguelDataGridView[0, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            txtEndereco.Text = aluguelDataGridView[3, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            mtxtData.Text = aluguelDataGridView[4, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            mtxtHoraInicio.Text = aluguelDataGridView[5, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            mtxtHoraFim.Text = aluguelDataGridView[6, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            txtNumeroPessoas.Text = aluguelDataGridView[7, aluguelDataGridView.CurrentRow.Index].Value.ToString();
            txtValorAluguel.Text = aluguelDataGridView[8, aluguelDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um aluguel deve ser selecionado para alteração.");
            }
            else

                try

                {

                    Aluguel aluguel = new Aluguel();

                    aluguel.IdAluguel = int.Parse(txtCodigo.Text);

                    aluguel.IdUsuario = (int)cmbCliente.SelectedValue;
                    aluguel.IdTema = (int)cmbTema.SelectedValue;
                    aluguel.EnderecoUsuario = txtEndereco.Text;
                    aluguel.DataFesta = mtxtData.Text;
                    aluguel.HoraInicio = mtxtHoraInicio.Text;
                    aluguel.HoraFim = mtxtHoraFim.Text;
                    aluguel.NumeroPessoas = int.Parse(txtNumeroPessoas.Text);
                    aluguel.ValorAluguel = float.Parse(txtValorAluguel.Text);


                    AluguelBll obj = new AluguelBll();
                    obj.Alterar(aluguel);

                    MessageBox.Show("O aluguel   foi alterado com sucesso!");

                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um aluguel deve ser selecionado antes da exclusão.");
            }

            else
                try
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);

                    AluguelBll obj = new AluguelBll();

                    obj.Excluir(codigo);

                    MessageBox.Show("O aluguel foi excluído com sucesso!");

                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "Novo";
            txtEndereco.Text = null;
            mtxtData.Text = null;
            mtxtHoraInicio.Text = null;
            mtxtHoraFim.Text = null;
            txtNumeroPessoas.Text = null;
            txtValorAluguel.Text = null;
        }
    }
}
