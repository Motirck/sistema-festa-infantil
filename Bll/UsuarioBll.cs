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
    public class UsuarioBll
    {
            //Este é um campo privado para armazenar uma instância da classe DAL.
            private UsuarioDal objDAL;

            //Esse é o construtor da classe UsusarioBll
            public UsuarioBll()
            {
                objDAL = new UsuarioDal();
            }

            //Listagem do combobox de privilegios
            public DataTable ListaDePrivilegios
            {
                get
                {
                    return objDAL.ListaDePrivilegios;
                }
            }
            //Incluir
            public void Incluir(Usuario usuario)
            {
                //O nome do usuario é obrigatório
                //trim retira espaços a esquerda e a direita
                if (usuario.Nome.Trim().Length == 0)
                {
                    throw new Exception("O nome do usuario é obrigatório");
                }
                if (usuario.Endereco.Trim().Length == 0)
                {
                    throw new Exception("O endereço do usuario é obrigatório");
                }
                if (usuario.Privilegio != 3 && usuario.Login.Trim().Length == 0)
                {
                    throw new Exception("O login do usuario é obrigatório");
                }
                if (usuario.Privilegio != 3 && usuario.Senha.Trim().Length == 0)
                {
                    throw new Exception("A senha do usuario é obrigatória");
                }
                if (usuario.Telefone.Trim().Length == 0)
                {
                    throw new Exception("O telefone do usuario é obrigatório");
                }
                if (usuario.Cpf.Trim().Length == 0)
                {
                    throw new Exception("O CPF do usuario é obrigatório");
                }

            //E-mail é sempre em letras minúsculas
            //ToLower - coloca tudo em minusculo
            //usuario.Email = usuario.Email.ToLower();


                //Se tudo está Ok, chama a rotina de inserção.
                UsuarioDal obj = new UsuarioDal();

                obj.Incluir(usuario);
            }

            //Alterar
            public void Alterar(Usuario usuario)
            {
                UsuarioDal obj = new UsuarioDal();
                obj.Alterar(usuario);
            }

            //Excluir
            public void Excluir(int id)
            {
                if (id < 1)
                {
                    throw new Exception("Selecione um usuario antes de excluí-lo.");
                }
                UsuarioDal obj = new UsuarioDal();
                obj.Excluir(id);
            }

            public DataTable ListagemUsuarios()
            {
                UsuarioDal obj = new UsuarioDal();
                return obj.ListagemUsuarios();
            }
    }
}



       