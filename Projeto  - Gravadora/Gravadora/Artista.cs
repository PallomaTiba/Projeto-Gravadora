using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravadora
{
    class Artista
    {
        public int id;
        public string nomeVerdadeiro;
        public string nomeArtistico;
        public DateTime dtNasc;
        public bool banda;
        public string bandaName;
        public string email;
        public string telefone;
        public string nomeEmpresario;
        public string emailEmpresario;
        public string tipo;
        public int albuns;
        public int composicoes;
        public double valorCache;

        public Artista(int aid, string anomeVerdadeiro,string anomeArtistico,DateTime adtNasc,bool abanda,string abandaName,string aemail,string atelefone,string anomeEmpresario,string aemailEmpresario,string atipo,int aalbum, int acomposicoes,double avalorCache)
        {
            this.id = aid;
            this.nomeVerdadeiro = anomeVerdadeiro;
            this.nomeArtistico = anomeArtistico;
            this.dtNasc = adtNasc;
            this.banda = abanda;
            this.bandaName = abandaName;
            this.email = aemail;
            this.telefone = atelefone;
            this.nomeEmpresario = anomeEmpresario;
            this.emailEmpresario = aemailEmpresario;
            this.tipo = atipo;
            this.albuns = aalbum;
            this.composicoes = acomposicoes;
            this.valorCache = avalorCache;
        }
    }
}
