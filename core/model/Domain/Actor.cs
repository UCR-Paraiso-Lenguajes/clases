using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Domain
{
    public class Actores
    {
        private List<Actor> actores = new List<Actor>();
    }

    public class Actor
    {
        private int codActor;
        private string nombre;
        private string apellidos;
    }
}
