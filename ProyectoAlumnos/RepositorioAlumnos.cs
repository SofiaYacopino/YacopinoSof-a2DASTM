using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoAlumnos
{
    public class RepositorioAlumnos
    {
        private List<Alumno> listaAlumnos;
        private string cadena = "Data Source=MARTU\\SQLEXPRESS;Initial Catalog=Facultad;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;";
        public RepositorioAlumnos()
        {
            listaAlumnos = new List<Alumno>();
        }

        public List<Alumno> Listar()
        {
            string query = "select * from Alumnos";
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    SqlCommand comando = new SqlCommand(query, conexion);
                    conexion.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Alumno a = new Alumno();
                        a.Id = int.Parse(reader["id"].ToString());
                        a.Nombre = reader["nombre"].ToString();
                        a.Nota = int.Parse(reader["nota"].ToString());

                        listaAlumnos.Add(a);
                    }
                    conexion.Close();

                    return listaAlumnos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Otro error inesperado:" + ex);
            }
        }
        public string Agregar(Alumno alumno)
        {
            string query = "INSERT INTO Alumnos(nombre, nota) values" + "(@nombre, @nota)";
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", alumno.Nombre);
                comando.Parameters.AddWithValue("@nota", alumno.Nota);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    return "Alumno agregado correctamente";
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error inesperado en algo relacionado con la BD"+ ex);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inesperado");
                }
            }
        }
    }
}
