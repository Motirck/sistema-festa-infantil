using FestaInfantil.Dal;
using FestaInfantil.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Bll
{
    public class AluguelBll
    {
        //Este é um campo privado para armazenar uma instância da classe DAL.
        private AluguelDal objDAL;

        //Esse é o construtor da classe UsusarioBll
        public AluguelBll()
        {
            objDAL = new AluguelDal();
        }

        //Incluir
        public void Incluir(Aluguel aluguel)
        {
            //O nome do usuario é obrigatório
            //trim retira espaços a esquerda e a direita
            if (aluguel.IdAluguel.ToString().Length == 0)
            {
                throw new Exception("O Codigo do aluguel é obrigatório");
            }
            if (aluguel.IdUsuario.ToString().Length == 0)
            {
                throw new Exception("O Codigo do usuario é obrigatório");
            }
            if (aluguel.IdTema.ToString().Length == 0)
            {
                throw new Exception("O Codigo do Tema é obrigatório");
            }
            if (aluguel.EnderecoUsuario.Trim().Length == 0)
            {
                throw new Exception("O endereço é obrigatório");
            }
            if (aluguel.DataFesta.ToString().Length == 0)
            {
                throw new Exception("A data da festa é obrigatório");
            }
            if (aluguel.HoraInicio.Trim().Length == 0)
            {
                throw new Exception("A hora de inicio é obrigatório");
            }
            if (aluguel.HoraFim.Trim().Length == 0)
            {
                throw new Exception("A hora do fim é obrigatório");
            }
            if (aluguel.NumeroPessoas.ToString().Length == 0)
            {
                throw new Exception("O numero de pessoas     é obrigatório");
            }
            if (aluguel.ValorAluguel.ToString().Length == 0)
            {
                throw new Exception("O valor do aluguel é obrigatório");
            }

            //Se tudo está Ok, chama a rotina de inserção.
            AluguelDal obj = new AluguelDal();

            obj.Incluir(aluguel);
        }

        //Alterar
        public void Alterar(Aluguel aluguel)
        {
            AluguelDal obj = new AluguelDal();
            obj.Alterar(aluguel);
        }

        //Excluir
        public void Excluir(int id)
        {
            if (id < 1)
            {
                throw new Exception("Selecione um aluguel antes de excluí-lo.");
            }
            AluguelDal obj = new AluguelDal();
            obj.Excluir(id);
        }

        //Lista os alugueis
        public DataTable Listagem()
        {
            AluguelDal obj = new AluguelDal();
            return obj.Listagem();
        }

        public DataTable ListagemCliente()
        {
            AluguelDal obj = new AluguelDal();
            return obj.ListagemCliente();
        }

        public DataTable ListagemTema()
        {
            AluguelDal obj = new AluguelDal();
            return obj.ListagemTema();
        }
    }
}

