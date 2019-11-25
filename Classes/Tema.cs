using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Models
{
    public class Tema
    {
        private int idTema;
        private string temaFesta;
        private string corToalhaMesa;

        //construtores
        public Tema()
        {
        }

        public Tema(int idTema, string temaFesta, string corToalhaMesa)
        {
            this.idTema = idTema;
            this.temaFesta = temaFesta;
            this.corToalhaMesa = corToalhaMesa;
        }


        //gets e sets
        public int IdTema
        {
            get { return idTema; }
            set { idTema = value; }
        }

        public string CorToalhaMesa
        {
            get { return corToalhaMesa; }
            set { corToalhaMesa = value; }
        }

        public string TemaFesta
        {
            get { return temaFesta; }
            set { temaFesta = value; }
        }
    }
}
