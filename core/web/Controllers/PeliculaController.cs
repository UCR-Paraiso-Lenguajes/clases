using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using model.Business;

namespace web.Controllers
{

    public class PeliculaController : Controller
    {
        readonly IConfiguration configuration;

        public PeliculaController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            string sql = configuration.GetConnectionString("sql");

            IEnumerable<Pelicula>  peliculas =  new PeliculaBussines(sql).List();

            return View(peliculas);
        }
    }
}