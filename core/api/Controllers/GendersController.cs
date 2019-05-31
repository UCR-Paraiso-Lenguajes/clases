
using System.Collections.Generic;
using core.Data;
using core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace core.Controllers
{
    //[Route("api")]
    public class GeneroController : Controller
    {
        private GeneroData generos = new GeneroData();
        [HttpGet("api/genero")]
        public IEnumerable<Genero> Generos() { 
            //Genero g1 = new Genero(1, "Terror");
            //Genero g2 = new Genero(2, "Acción");
            //Genero g3 = new Genero(3, "Suspenso");

            //List<Genero> generos = new List<Genero>();
            //generos.Add(g1);
            //generos.Add(g2);
            //generos.Add(g3);

            //return generos;

            return generos.List();
        }

        PeliculaData peliculaData = new PeliculaData();
        [HttpGet("api/peliculas")]
        public IEnumerable<Pelicula> peliculas()
        {
            //Genero g1 = new Genero(1, "Terror");
            //Genero g2 = new Genero(2, "Acción");
            //Genero g3 = new Genero(3, "Suspenso");

            //List<Genero> generos = new List<Genero>();
            //generos.Add(g1);
            //generos.Add(g2);
            //generos.Add(g3);

            //return generos;

            return peliculaData.List();
        }
    }
}