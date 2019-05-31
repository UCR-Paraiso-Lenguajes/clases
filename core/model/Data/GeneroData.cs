using core.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace core.Data
{
    public class GeneroData
    {
        public IEnumerable<Genero> List()
        {
            List<Genero> generos = new List<Genero>();
            using (SqlConnection connection = new SqlConnection("data source=" +
                "163.178.173.148;initial " +
                "catalog=Len12019;user id=estudiantesrp;password=estudiantesrp;" +
                "multipleactiveresultsets=True"))
            {
                connection.Open();
                string sql = "select cod_genero, nombre_genero from Genero";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);

                            generos.Add( new Genero(id, nombre));
                        }
                        reader.Close();
                    };
                }
                connection.Close();
            }

            return generos;
        }
    }
}
