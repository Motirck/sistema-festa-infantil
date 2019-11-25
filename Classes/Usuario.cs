using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Models
{
    public class Usuario
    {
        private int id;
        private string nome;
        private string cpf;
        private string telefone;
        private int privilegio;
        private string endereco;
        private string login;
        private string senha;

        

        //construtores 1
        public Usuario()
        {
        }

        public Usuario(int id, string nome, string cpf, string telefone, int privilegio, string endereco, string login, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.privilegio = privilegio;
            this.endereco = endereco;
            this.login = login;
            this.senha = senha;
        }

        //gets e sets

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }


        public int Privilegio
        {
            get { return privilegio; }
            set { privilegio = value; }
        }


        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}
