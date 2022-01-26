using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravadora
{
    class Albuns
    {
        public int idAlbun;
        public string titulo;
        public List<int> codMusics = new List<int>();
        public string CodigoMusicas;
        public int CodigoArtistas;
        public DateTime dtLanc;
        public int nrCopias;
        public List<int> codArtistas = new List<int>();

        public Albuns(int aidAlbun, string atitulo, DateTime adtLanc, int anrCopias, string codMusicas, int codArtistas)
        {
            this.idAlbun = aidAlbun;
            this.titulo = atitulo;
            this.dtLanc = adtLanc;
            this.nrCopias = anrCopias;
            this.CodigoMusicas = codMusicas;
            this.CodigoArtistas=codArtistas;
        }

        public List<int> getCodigoMusicas()
        {
            return codMusics;
        }
        public void setCodigoMusicas (List<int> codMusics)
        {
           this.codMusics=codMusics;
        }

        public List<int> getCodigoArtistas()
        {
            return codArtistas;
        }
        public void setCodigoArtistas (List<int> codArtistas)
        {
           this.codArtistas=codArtistas;
        }
    }
}
