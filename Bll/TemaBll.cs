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
    public class TemaBll
    {
        //Este é um campo privado para armazenar uma instância da classe DAL.
        private TemaDal objDAL;

        //Esse é o construtor da classe UsusarioBll
        public TemaBll()
        {
            objDAL = new TemaDal();
        }

        //Incluir
        public void Incluir(Tema tema)
        {
            //O nome do usuario é obrigatório
            //trim retira espaços a esquerda e a direita
            if (tema.TemaFesta.Trim().Length == 0)
            {
                throw new Exception("A descrição do tema é obrigatório");
            }
            if (tema.CorToalhaMesa.Trim().Length == 0)
            {
                throw new Exception("A cor da toalha de mesa é obrigatório");
            }

            //Se tudo está Ok, chama a rotina de inserção.
            TemaDal obj = new TemaDal();

            obj.Incluir(tema);
        }

        //Alterar
        public void Alterar(Tema tema)
        {
            TemaDal obj = new TemaDal();
            obj.Alterar(tema);
        }

        //Excluir
        public void Excluir(int id)
        {
            if (id < 1)
            {
                throw new Exception("Selecione um tema antes de excluí-lo.");
            }
            TemaDal obj = new TemaDal();
            obj.Excluir(id);
        }

        //Lista os Temas
        public DataTable Listagem()
        {
            TemaDal obj = new TemaDal();
            return obj.Listagem();
        }
    }
}
