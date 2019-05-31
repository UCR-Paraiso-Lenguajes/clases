using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Domain
{
    public class Pelicula
    {
 
        public Pelicula(int codPelicula, string titulo, Genero genero, int totalPelicula, bool sub, bool estreno)
        {
            CodPelicula = codPelicula;
            Titulo = titulo;
            Genero = genero;
            TotalPeliculas = totalPelicula;
            Subtitulada = sub;
            Estreno = estreno;
            Actores = new Actores();
        }
        private int codPelicula;

        public int CodPelicula
        {
            get { return codPelicula; }
            set { codPelicula = value; }
        }

        public string Titulo { get; internal set; }
        public Genero Genero { get; internal set; }
        public int TotalPeliculas { get; internal set; }
        public bool Subtitulada { get; internal set; }
        public bool Estreno { get; internal set; }
        public Actores Actores { get; internal set; }
    }
}
