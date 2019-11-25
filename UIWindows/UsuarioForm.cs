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
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            UsuarioBll obj = new UsuarioBll();
            cmbPrivilegio.DataSource = obj.ListaDePrivilegios;
            cmbPrivilegio.DisplayMember = "descricao";
            cmbPrivilegio.ValueMember = "idPrivilegio";

           // UsuarioBll obj = new UsuarioBll();
           // cmbPrivilegio.DataSource = obj.ListaDePrivilegios;

            AtualizaGrid();
            NomeTextBox.Focus();
        }

        public void AtualizaGrid()
        {
            // Comunicação com a Camada BLL
            UsuarioBll obj = new UsuarioBll();
            usuariosDataGridView.DataSource = obj.ListagemUsuarios();

            // Atualizando os objetos TextBox

            UsuarioTextBox.Text = usuariosDataGridView[0, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            NomeTextBox.Text = usuariosDataGridView[2, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            CPFTextBox.Text = usuariosDataGridView[3, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            TelefoneTextBox.Text = usuariosDataGridView[4, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            EnderecoTextBox.Text = usuariosDataGridView[5, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            LoginTextBox.Text = usuariosDataGridView[6, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            SenhaTextBox.Text = usuariosDataGridView[7, usuariosDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = "";

            NomeTextBox.Text = "";

            CPFTextBox.Text = "";

            TelefoneTextBox.Text = "";

            EnderecoTextBox.Text = "";

            LoginTextBox.Text = "";

            SenhaTextBox.Text = "";
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                usuario.Nome = NomeTextBox.Text;
                usuario.Cpf = CPFTextBox.Text;
                usuario.Telefone = TelefoneTextBox.Text;
                usuario.Privilegio = (int)cmbPrivilegio.SelectedValue;
                usuario.Endereco = EnderecoTextBox.Text;
                usuario.Login = LoginTextBox.Text;
                usuario.Senha = SenhaTextBox.Text;


                UsuarioBll obj = new UsuarioBll();
                obj.Incluir(usuario);

                MessageBox.Show("O usuario foi incluído com sucesso!");

                UsuarioTextBox.Text = Convert.ToString(usuario.Id);
                AtualizaGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um usuario deve ser selecionado para alteração.");
            }
            else

                try

                {

                    Usuario usuario = new Usuario();

                    usuario.Id = int.Parse(UsuarioTextBox.Text);

                    usuario.Nome = NomeTextBox.Text;
                    usuario.Cpf = CPFTextBox.Text;
                    usuario.Telefone = TelefoneTextBox.Text;
                    usuario.Privilegio = (int)cmbPrivilegio.SelectedValue;
                    usuario.Endereco = EnderecoTextBox.Text;
                    usuario.Login = LoginTextBox.Text;
                    usuario.Senha = SenhaTextBox.Text;

                    UsuarioBll obj = new UsuarioBll();

                    obj.Alterar(usuario);

                    MessageBox.Show("O usuario foi alterado com sucesso!");

                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

        private void usuariosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Atualizando os objetos TextBox

            UsuarioTextBox.Text = usuariosDataGridView[0, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            NomeTextBox.Text = usuariosDataGridView[2, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            CPFTextBox.Text = usuariosDataGridView[3, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            TelefoneTextBox.Text = usuariosDataGridView[4, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            EnderecoTextBox.Text = usuariosDataGridView[5, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            LoginTextBox.Text = usuariosDataGridView[6, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            SenhaTextBox.Text = usuariosDataGridView[7, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            //######################################################################################################################

            //Quero que ao clicar na celula do grid tbm troque o combobox falando se o usuario selecionado é ADM ou Cliente
            //Porém não é prioridade agora.

            //#######################################################################################################################

            //cmbPrivilegio.Items.Add(dgvQuartos[0, dgvQuartos.CurrentRow.Index].Value.ToString());

            //Usuario usuario = new Usuario();
            //cmbPrivilegio.Text = usuario.Privilegio=;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um usuario deve ser selecionado antes da exclusão.");
            }

            else
                try
                {
                    int codigo = Convert.ToInt32(UsuarioTextBox.Text);

                    UsuarioBll obj = new UsuarioBll();

                    obj.Excluir(codigo);

                    MessageBox.Show("O usuario foi excluído com sucesso!");

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

