using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace core.Controllers
{
    //[Route("api")]
    public class GeneroController : Controller
    {
        [HttpGet("api/genero")]
        public List<Genero> Genero()
        {
            Genero g1 = new Genero(1, "Terror");
            Genero g2 = new Genero(2, "Acción");
            Genero g3 = new Genero(3, "Suspenso");

            List<Genero> generos = new List<Genero>();
            generos.Add(g1);
            generos.Add(g2);
            generos.Add(g3);
 
            return generos;
        }
    }
}