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
    public class AluguelDal
    {
        public void Incluir(Aluguel aluguel)

        {

            //conexao

            SqlConnection cn = new SqlConnection();

            try

            {
                cn.ConnectionString = Dados.StringDeConexao;

                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into TbAluguel(TbUsuario_idUsuario, TbTema_idTema,enderecoUsuario,dataFesta,horaInicio, horaFim, numeroPessoas, valorAluguel)" +
                " values (@idUsuario, @idTema, @enderecoUsuario, @dataFesta, @horaInicio, @horaFim, @numeroPessoas, @valorAlguel); select @@IDENTITY;";

                cmd.Parameters.AddWithValue("@idUsuario", aluguel.IdUsuario);
                cmd.Parameters.AddWithValue("@idTema", aluguel.IdTema);
                cmd.Parameters.AddWithValue("@enderecoUsuario", aluguel.EnderecoUsuario);
                cmd.Parameters.AddWithValue("@dataFesta", aluguel.DataFesta);
                cmd.Parameters.AddWithValue("@horaInicio", aluguel.HoraInicio);
                cmd.Parameters.AddWithValue("@horaFim", aluguel.HoraFim);
                cmd.Parameters.AddWithValue("@numeroPessoas", aluguel.NumeroPessoas);
                cmd.Parameters.AddWithValue("@valorAlguel", aluguel.ValorAluguel);

                cn.Open();

                aluguel.IdAluguel = Convert.ToInt32(cmd.ExecuteScalar());
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
        public void Alterar(Aluguel aluguel)
        {
            // conexao
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;

                //DÚVIDA, TENHO QUE PASSAR NO UPDATE AS CHAVES ESTRANGEIRAS IDALUGUEL E IDTEMA OU NÃO?

                cmd.CommandText = "update TbAluguel set TbUsuario_idUsuario = @idUsuario, TbTema_idTema = @idTema, enderecoUsuario = @enderecoUsuario, " +
                "dataFesta = @dataFesta, horaInicio = @horaInicio, horaFim = @horaFim, numeroPessoas = @numeroPessoas, valorAluguel = @valorAlguel where idAluguel = @idAluguel;";

                cmd.Parameters.AddWithValue("@idUsuario", aluguel.IdUsuario);
                cmd.Parameters.AddWithValue("@idTema", aluguel.IdTema);
                cmd.Parameters.AddWithValue("@enderecoUsuario", aluguel.EnderecoUsuario);
                cmd.Parameters.AddWithValue("@dataFesta", aluguel.DataFesta);
                cmd.Parameters.AddWithValue("@horaInicio", aluguel.HoraInicio);
                cmd.Parameters.AddWithValue("@horaFim", aluguel.HoraFim);
                cmd.Parameters.AddWithValue("@numeroPessoas", aluguel.NumeroPessoas);
                cmd.Parameters.AddWithValue("@valorAlguel", aluguel.ValorAluguel);
                cmd.Parameters.AddWithValue("@idAluguel", aluguel.IdAluguel);

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

        public void Excluir(int idAluguel)
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

                //cmd.CommandText = "delete from TbAluguel where idUsuario = @id;";
                //cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandText = "delete from TbAluguel where idAluguel = " + idAluguel;

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o aluguel " + idAluguel);
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
            SqlDataAdapter da = new SqlDataAdapter("select * from TbAluguel", Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable ListagemCliente()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TbUsuario", Dados.StringDeConexao);
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
