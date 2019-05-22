using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Domain
{
    public class Genero
    {
        //public int CodGenero { get; private set; }
        //public string NombreGenero { get; private set; }

        private int codGenero;
        public int CodGenero
        {
            get
            {
                return codGenero;
            }
            set
            {
                if (value <= 0) throw new Exception("El código debe ser positivo.");
                codGenero = value;  
            }
        }

        private string nombreGenero;
        public string NombreGenero
        {
            get
            {
                return nombreGenero;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Nombre es requerido.");
                nombreGenero = value;
            }
        }

        public Genero(int codGenero, string nombreGenero)
        {
            CodGenero = codGenero;
            NombreGenero = nombreGenero;
        }


    }
}
