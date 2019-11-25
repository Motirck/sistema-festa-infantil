using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestaInfantil.Models;
using System.Data.SqlClient;
using System.Data;

namespace FestaInfantil.Dal
{
    public class UsuarioDal
    {
        public void Incluir(Usuario usuario)

        {

            //conexao

            SqlConnection cn = new SqlConnection();

            try

            {
                cn.ConnectionString = Dados.StringDeConexao;

                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into TbUsuario(TbPrivilegio_idPrivilegio, nomeUsuario,cpf,telefone,endereco, login, senha) " +
                    "values (@privilegio, @nomeUsuario,@cpf,@telefone,@endereco, @login, @senha); select @@IDENTITY;";

                cmd.Parameters.AddWithValue("@privilegio", usuario.Privilegio);
                cmd.Parameters.AddWithValue("@nomeUsuario", usuario.Nome);
                cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                cmd.Parameters.AddWithValue("@endereco", usuario.Endereco);
                cmd.Parameters.AddWithValue("@login", usuario.Login);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);

                cn.Open();

                usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Usuario usuario)
        {
            // conexao
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update TbUsuario set TbPrivilegio_idPrivilegio = @idPrivilegio, nomeUsuario = @nomeUsuario, cpf = @cpf, " +
               "telefone = @telefone, endereco = @endereco, login = @login, senha = @senha where idUsuario = @idUsuario;";

                cmd.Parameters.AddWithValue("@idPrivilegio", usuario.Privilegio);
                cmd.Parameters.AddWithValue("@nomeUsuario", usuario.Nome);
                cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                cmd.Parameters.AddWithValue("@endereco", usuario.Endereco);
                cmd.Parameters.AddWithValue("@login", usuario.Login);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@idUsuario", usuario.Id);

                cn.Open();

                cmd.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int id)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try

            {
                cn.ConnectionString = Dados.StringDeConexao;

                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                //talvez alinha 117 ficasse melhor assim: 

                //cmd.CommandText = "delete from TbUsuario where idUsuario = @id;";
                //cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandText = "delete from TbUsuario where idUsuario = " + id;

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o usuario " + id);
                }
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable ListagemUsuarios()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TbUsuario", Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable ListaDePrivilegios
        {
            get
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from TbPrivilegio", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }

    }
}
