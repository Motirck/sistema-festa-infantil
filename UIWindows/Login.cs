using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FestaInfantil.Dal;
using FestaInfantil.UIWindows;

namespace UIWindows
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void exe()
        {
            string query = "SELECT * FROM TbUsuario WHERE login=@login AND senha=@senha and TbPrivilegio_idPrivilegio != 0";

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.StringDeConexao;

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@login", txtLogin.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Autenticacao.Login(dr["login"].ToString(), dr["senha"].ToString());

                if (txtLogin.Text != null || txtSenha.Text != null)
                {
                    if (txtLogin.Text != "" || txtSenha.Text != "")
                    {
                        Form1 obj = new Form1();
                        obj.ShowDialog();
                        this.Visible = false;
                    }

                    else
                    {
                        MessageBox.Show("ERRO! USUARIO OU SENHA NÃO PODEM ESTAR EM BRANCO");
                    }
                }
                else
                {
                   MessageBox.Show("ERRO! USUARIO OU SENHA NÃO PODEM ESTAR EM BRANCO");
                }

            }
            else
            {
                MessageBox.Show("ERRO USUARIO OU SENHA INVALIDOS");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            exe();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
