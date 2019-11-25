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
    public class ItensTemaBll
    {
        //Este é um campo privado para armazenar uma instância da classe DAL.
        private ItensTemaDal objDAL;

        //Esse é o construtor da classe UsusarioBll
        public ItensTemaBll()
        {
            objDAL = new ItensTemaDal();
        }

        //Incluir
        public void Incluir(ItensTema item)
        {
            //O nome do usuario é obrigatório
            //trim retira espaços a esquerda e a direita
            if (item.IdTema.ToString().Length == 0)
            {
                throw new Exception("O Codigo do Tema é obrigatório");
            }
            if (item.IdItensTema.ToString().Length == 0)
            {
                throw new Exception("O codigo do tema obrigatório");
            }
            if (item.Nomeitem.Trim().Length == 0)
            {
                throw new Exception("O nome do item é obrigatório");
            }
            if (item.ValorItem.ToString().Length == 0)
            {
                throw new Exception("O valor do item é obrigatório");
            }

            //Se tudo está Ok, chama a rotina de inserção.
            ItensTemaDal obj = new ItensTemaDal();

            obj.Incluir(item);
        }

        //Alterar
        public void Alterar(ItensTema item)
        {
            ItensTemaDal obj = new ItensTemaDal();
            obj.Alterar(item);
        }

        //Excluir
        public void Excluir(int id)
        {
            if (id < 1)
            {
                throw new Exception("Selecione um item antes de excluí-lo.");
            }
            ItensTemaDal obj = new ItensTemaDal();
            obj.Excluir(id);
        }

        //Lista os itens do tema
        public DataTable Listagem()
        {
            ItensTemaDal obj = new ItensTemaDal();
            return obj.Listagem();
        }
        //Lista os temas no ComboBox
        public DataTable ListagemTema()
        {
            ItensTemaDal obj = new ItensTemaDal();
            return obj.ListagemTema();
        }
    }
}

