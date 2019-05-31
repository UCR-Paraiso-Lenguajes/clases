using core.Data;
using core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace model.Business
{
    public class PeliculaBussines
    {
        private string connection;
        private PeliculaData peliculaData;
        public PeliculaBussines(string connection)
        {
            if (string.IsNullOrEmpty(connection)) throw new Exception("El string de conexión es requerido.");

            this.connection = connection;
            this.peliculaData = new PeliculaData();
        }

        public IEnumerable<Pelicula> List()
        {
            return this.peliculaData.List();
        }

    }
}
