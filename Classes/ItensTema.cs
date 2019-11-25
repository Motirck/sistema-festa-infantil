using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Models
{
    public class ItensTema
    {
        private int idTema; // idTeama é estrangeiro em ItensTema mas precisa estar aqui no model
        private int idItensTema;
        private string nomeItem;
        private float valorItem;

        //construtores
        

        public ItensTema()
        {
        }

        public ItensTema(int idTema, int idItensTema, string nomeItem, float valorItem)
        {
            this.idTema = idTema;
            this.idItensTema = idItensTema;
            this.nomeItem = nomeItem;
            this.valorItem = valorItem;
        }

        //gets e sets
        public int IdTema
        {
            get { return idTema; }
            set { idTema = value; }
        }

        public int IdItensTema
        {
            get { return idItensTema; }
            set { idItensTema = value; }
        }

        public float ValorItem
        {
            get { return valorItem; }
            set { valorItem = value; }
        }


        public string Nomeitem
        {
            get { return nomeItem; }
            set { nomeItem = value; }
        }

    }
}
