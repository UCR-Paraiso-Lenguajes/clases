using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Domain
{
    public class Pelicula
    {
        private Genero genero;
        private string titulo;
        private bool subtitulada;
        private bool estreno;
        private Actores actores;
     
        private int totalPelicula;


        public Pelicula(int codPelicula, string titulo, Genero genero, int totalPelicula, bool sub, bool estreno)
        {
            CodPelicula = codPelicula;
            this.titulo = titulo;
            this.genero = genero;
            this.totalPelicula = totalPelicula;
            this.subtitulada = sub;
            this.estreno = estreno;
        }
        private int codPelicula;

        public int CodPelicula
        {
            get { return codPelicula; }
            set { codPelicula = value; }
        }


    }
}
