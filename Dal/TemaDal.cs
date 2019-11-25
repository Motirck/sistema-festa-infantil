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
    public class TemaDal
    {
        public void Incluir(Tema tema)

        {

            //conexao

            SqlConnection cn = new SqlConnection();

            try

            {
                cn.ConnectionString = Dados.StringDeConexao;

                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into TbTema(temaFesta, corToalhaMesa) values (@temaFesta, @corToalhaMesa); select @@IDENTITY;";

                cmd.Parameters.AddWithValue("@temafesta", tema.TemaFesta);
                cmd.Parameters.AddWithValue("@corToalhaMesa", tema.CorToalhaMesa);

                cn.Open();

                tema.IdTema = Convert.ToInt32(cmd.ExecuteScalar());
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
        public void Alterar(Tema tema)
        {
            // conexao
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update TbTema set temaFesta = @temafesta, corToalhaMesa = @corToalhaMesa where idTema = @idTema;";

                cmd.Parameters.AddWithValue("@idTema", tema.IdTema);
                cmd.Parameters.AddWithValue("@temafesta", tema.TemaFesta);
                cmd.Parameters.AddWithValue("@corToalhaMesa", tema.CorToalhaMesa);

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

        public void Excluir(int idTema)
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

                //cmd.CommandText = "delete from TbTema where idTema = @id;";
                //cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandText = "delete from TbTema where idTema = " + idTema;

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o tema " + idTema);
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

        public DataTable Listagem()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.StringDeConexao;
            cn.Open();
            

            SqlDataAdapter da = new SqlDataAdapter("select * from TbTema", cn);

            DataTable tabela = new DataTable();
            da.Fill(tabela);
            cn.Close();
            return tabela;
        }
    }
}
