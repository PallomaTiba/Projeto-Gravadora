using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravadora
{
    class Musics
    {
        public int id;
        public string titulo;
        public string letra;
        public int codPartitura;
        public int codArtistaCompositor;
        public int codArtista;

        public Musics(int aid, string atitulo, string aletra, int acodPartitura, int acodArtistaCompositor, int acodArtista)
        {
            this.id = aid;
            this.titulo = atitulo;
            this.letra = aletra;
            this.codPartitura = acodPartitura;
            this.codArtistaCompositor = acodArtistaCompositor;
            this.codArtista = acodArtista;

        }
    }
}
