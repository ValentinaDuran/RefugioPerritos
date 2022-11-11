using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugioPerritos
{
    public class AccesoADatos
    {
        private SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=RefugioIefi;Data Source=DESKTOP-1MHAK99");

        public void InsertarPerrito(Perrito perrito) 
        {
            try
            {
                conexion.Open();
                string query = @"
                               Insert Into Perrito ([nombre_perro], [edad_aprox], [color_cuerpo], [color_ojos], [castrado], [fecha_ingreso], [NombreRefugioId])
                               Values (@nombre_perro, @edad_aprox, @color_cuerpo, @color_ojos, @castrado, @fecha_ingreso, @NombreRefugioId);


                            ";
                //SqlParameter extendido
                SqlParameter Nombre_perro = new SqlParameter();
                Nombre_perro.ParameterName = "@nombre_perro";
                Nombre_perro.Value = perrito.nombre_perro;
                Nombre_perro.DbType = System.Data.DbType.String;
                //SqlParameter en corto
                SqlParameter Edad_aprox = new SqlParameter("@edad_aprox", perrito.edad_aprox);
                SqlParameter Color_cuerpo = new SqlParameter("@color_cuerpo", perrito.color_cuerpo);
                SqlParameter Color_ojos = new SqlParameter("@color_ojos", perrito.color_ojos);
                SqlParameter Castrado = new SqlParameter("@castrado", perrito.castrado);
                SqlParameter Fecha_ingreso = new SqlParameter("@fecha_ingreso", perrito.fecha_ingreso.Date);
                SqlParameter NombreRefugioId = new SqlParameter("@NombreRefugioId", perrito.NombreRefugioId);
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.Add(Nombre_perro);
                command.Parameters.Add(Edad_aprox);
                command.Parameters.Add(Color_cuerpo);
                command.Parameters.Add(Color_ojos);
                command.Parameters.Add(Castrado);
                command.Parameters.Add(Fecha_ingreso);
                command.Parameters.Add(NombreRefugioId);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
            
            
              conexion.Close();
            }
        
        }

        public void DeletePerrito(int DNI)
        {
            try
            {
                conexion.Open();
                string query = @"DELETE FROM Perrito WHERE perritoDNI = @DNI";

                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.Add(new SqlParameter("@DNI", DNI));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }
        }
        public List<Perrito> GetPerritos(string buscar = null) 
        {
            List<Perrito> perritos = new List<Perrito>();
            try
            {
                conexion.Open();
                string query = @"  SELECT perritoDNI, nombre_perro, edad_aprox, color_cuerpo, color_ojos, castrado, fecha_ingreso, NombreRefugioId
                                   From Perrito";

                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(buscar))
                {
                    query += @" WHERE nombre_perro LIKE @Buscar OR NombreRefugioId LIKE @Buscar ";
                    command.Parameters.Add(new SqlParameter("@Buscar", $"%{buscar}%"));
                }

                command.CommandText = query;
                command.Connection = conexion;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    perritos.Add(new Perrito
                    {
                        perritoDNI = int.Parse(reader["perritoDNI"].ToString()),
                        nombre_perro = reader["nombre_perro"].ToString(),
                        edad_aprox = int.Parse(reader["edad_aprox"].ToString()),
                        color_cuerpo = reader["color_cuerpo"].ToString(),
                        color_ojos = reader["color_ojos"].ToString(),
                        castrado = Convert.ToBoolean(reader["castrado"]),
                        fecha_ingreso = Convert.ToDateTime(reader["fecha_ingreso"]).Date,
                        NombreRefugioId = reader["NombreRefugioId"].ToString(),
                    });


                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }

            return perritos;
        
        }

        
    }
}
