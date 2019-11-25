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
    public class ItensTemaDal
    {
        public void Incluir(ItensTema itensTema)

        {

            //conexao

            SqlConnection cn = new SqlConnection();

            try

            {
                cn.ConnectionString = Dados.StringDeConexao;

                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into TbItensTema(TbTema_idTema, nomeDoItem,valorDoItem) values (@idTema, @nomeDoItem,@valorDoItem); select @@IDENTITY;";

                cmd.Parameters.AddWithValue("@idTema", itensTema.IdTema);
                cmd.Parameters.AddWithValue("@nomeDoItem", itensTema.Nomeitem);
                cmd.Parameters.AddWithValue("@valorDoItem", itensTema.ValorItem);

                cn.Open();

                itensTema.IdItensTema = Convert.ToInt32(cmd.ExecuteScalar());
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
        public void Alterar(ItensTema itensTema)
        {
            // conexao
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update TbItensTema set TbTema_idTema = @idTema, nomeDoItem = @nomeDoItem, valorDoItem = @valorDoItem where idItensTema = @idItensTema;";

                cmd.Parameters.AddWithValue("@idTema", itensTema.IdTema);
                cmd.Parameters.AddWithValue("@nomeDoItem", itensTema.Nomeitem);
                cmd.Parameters.AddWithValue("@valorDoItem", itensTema.ValorItem);
                cmd.Parameters.AddWithValue("@idItensTema", itensTema.IdItensTema);


                cn.Open();

                cmd.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.ToString());
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

        public void Excluir(int idItensTema)
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

                //cmd.CommandText = "delete from TbItensTema where idItensTema = @id;";
                //cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandText = "delete from TbItensTema where idItensTema = " + idItensTema;

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o itensTema " + idItensTema);
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
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TbItensTema", Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable ListagemTema()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TbTema", Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
