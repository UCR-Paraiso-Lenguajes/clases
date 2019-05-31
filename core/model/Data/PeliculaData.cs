using core.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace core.Data
{
    public class PeliculaData
    {
        public IEnumerable<Pelicula> List()
        {
            List<Pelicula> generos = new List<Pelicula>();
            using (SqlConnection connection = new SqlConnection("data source=" +
                "163.178.173.148;initial " +
                "catalog=Len12019;user id=estudiantesrp;password=estudiantesrp;" +
                "multipleactiveresultsets=True"))
            {
                connection.Open();
                string sql = "select cod_pelicula, titulo, p.cod_genero, total_peliculas, subtitulada, estreno, nombre_genero " +
                    "from Pelicula p inner Join Genero g on p.cod_genero = g.cod_genero";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string titulo = reader.GetString(1);
                            int codGenero = reader.GetInt32(2);
                            int totalPelicula = reader.GetInt32(3);
                            bool sub = reader.GetInt16(4)==1;
                            bool estreno = reader.GetInt16(5)==1;
                            string nombre_genero = reader.GetString(6);


                            generos.Add(new Pelicula(id, titulo, new Genero(codGenero, nombre_genero), totalPelicula, sub, estreno));
                        }
                        reader.Close();
                    };
                }
                connection.Close();
            }

            return generos;
        }

        public void Insert(Pelicula pelicula)
        {
            using (var conn = new SqlConnection("data source=163.178.173.148;initial catalog=Len12019;user id=estudiantesrp;password=estudiantesrp; multipleactiveresultsets=True"))
            {
                var cmd = new SqlCommand("insert into Pelicula(titulo, cod_genero, total_peliculas, " +
                    "subtitulada, estreno) values (@titulo, @codGenero, @totalPeliculas, " +
                    "@subtitulada, @estreno);SELECT SCOPE_IDENTITY()", conn);
                cmd.Parameters.AddWithValue("@titulo", pelicula.Titulo);
                cmd.Parameters.AddWithValue("@codGenero", pelicula.Genero.CodGenero);
                cmd.Parameters.AddWithValue("@totalPeliculas", pelicula.TotalPeliculas);
                cmd.Parameters.AddWithValue("@subtitulada", pelicula.Subtitulada);
                cmd.Parameters.AddWithValue("@estreno", pelicula.Estreno);

                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction("InsertPeliTransaction");

                try
                {
                    cmd.Transaction = transaction;

                    Decimal newId = (Decimal)cmd.ExecuteScalar();
                    pelicula.CodPelicula = Decimal.ToInt32( newId);


                    foreach (Actor actor in pelicula.Actores.Listar())
                    {
                        cmd = new SqlCommand("insert into Pelicula_Actor(cod_actor, cod_pelicula) " +
                        "values (@codActor, @codPelicula)", conn);

                        cmd.Transaction = transaction;

                        cmd.Parameters.AddWithValue("@codActor", actor.Codigo);
                        cmd.Parameters.AddWithValue("@codPelicula", pelicula.CodPelicula);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }   
            }
        }
    }
}
