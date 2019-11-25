using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Models
{
    public class Aluguel
    {
        private int idAluguel;
        private int idUsuario;
        private int idTema;
        private string enderecoUsuario;
        private string dataFesta;
        private string horaInicio;
        private string horaFim;
        private int numeroPessoas;
        ////private string temaFesta;
        private float valorAluguel;

        //construtores
        public Aluguel()
        {
        }

        public Aluguel(int idAluguel, int idUsuario, int idTema, string enderecoUsuario, string dataFesta, string horaInicio, string horaFim, int numeroPessoas, float valorAluguel)
        {
            this.idAluguel = idAluguel;
            this.idUsuario = idUsuario;
            this.idTema = idTema;
            this.enderecoUsuario = enderecoUsuario;
            this.dataFesta = dataFesta;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            this.numeroPessoas = numeroPessoas;
            //this.temaFesta = temaFesta;
            this.valorAluguel = valorAluguel;
        }

        //gets e sets

        public int IdAluguel
        {
            get { return idAluguel; }
            set { idAluguel = value; }
        } 

        public int IdTema
        {
            get { return idTema; }
            set { idTema = value; }
        }


        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        //public string TemaFesta
        //{
        //    get { return temaFesta; }
        //    set { temaFesta = value; }
        //}

        public int NumeroPessoas
        {
            get { return numeroPessoas; }
            set { numeroPessoas = value; }
        }


        public string HoraFim
        {
            get { return horaFim; }
            set { horaFim = value; }
        }

        public string HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        public string DataFesta
        {
            get { return dataFesta; }
            set { dataFesta = value; }
        }


        public float ValorAluguel
        {
            get { return valorAluguel; }
            set { valorAluguel = value; }
        }


        public string EnderecoUsuario
        {
            get { return enderecoUsuario; }
            set { enderecoUsuario = value; }
        }
    }
}
