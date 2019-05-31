using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Domain
{
    public class Actores
    {
        private List<Actor> actores = new List<Actor>();

        internal IEnumerable<Actor> Listar()
        {
            return actores;
        }

        public void Add(Actor actor)
        {
            if (actor == null) throw new Exception("El actor es requerido.");
            actores.Add(actor);
        }
    }

    public class Actor
    {
        private string nombre;
        private string apellidos;

        public Actor(int codigo, string nombre)
        {
            Codigo = codigo;
            this.nombre = nombre;
        }

        public object Codigo { get; internal set; }
    }
}
