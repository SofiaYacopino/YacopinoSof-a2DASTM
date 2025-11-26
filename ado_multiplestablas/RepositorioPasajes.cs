using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado_multiplestablas
{
    public class RepositorioPasajes
    {
        private string cadenaConexion = "";
        private List<Avion> listaAviones;
        private List<Pasaje> listaPasajes;
        private List<Pasajero> listaPasajeros;

        public RepositorioPasajes()
        {
            listaAviones = new List<Avion>();
            listaPasajeros = new List<Pasajero>();
            listaPasajes = new List<Pasaje>();
        }
        public void AgregarAvion(Avion avion)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "INSERT INTO Aviones (Matricula, Modelo, Capacidad) VALUES (@Matricula, @Modelo, @Capacidad)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Matricula", avion.Matricula);
                    cmd.Parameters.AddWithValue("@Modelo", avion.Modelo);
                    cmd.Parameters.AddWithValue("@Capacidad", avion.Capacidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public IReadOnlyCollection<Avion> ListarAviones()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "SELECT IdAvion, Matricula, Modelo, Capacidad FROM Aviones";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaAviones.Add(new Avion
                        {
                            IdAvion = (int)reader["IdAvion"],
                            Matricula = reader["Matricula"].ToString(),
                            Modelo = reader["Modelo"].ToString(),
                            Capacidad = (int)reader["Capacidad"]
                        });
                    }
                }
            }
            return listaAviones;
        }
        public void ModificarAvion(Avion avion)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "UPDATE Aviones SET Matricula=@Matricula, Modelo=@Modelo, Capacidad=@Capacidad " +
                             "WHERE IdAvion=@IdAvion";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Matricula", avion.Matricula);
                    cmd.Parameters.AddWithValue("@Modelo", avion.Modelo);
                    cmd.Parameters.AddWithValue("@Capacidad", avion.Capacidad);
                    cmd.Parameters.AddWithValue("@IdAvion", avion.IdAvion);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarAvion(int idAvion)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "DELETE FROM Aviones WHERE IdAvion=@IdAvion";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdAvion", idAvion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AgregarPasajero(Pasajero pasajero)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "INSERT INTO Pasajeros (Pasaporte, NombreApellido, Nacionalidad, FechaNacimiento) " +
                             "VALUES (@Pasaporte, @NombreApellido, @Nacionalidad, @FechaNacimiento)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Pasaporte", pasajero.Pasaporte);
                    cmd.Parameters.AddWithValue("@NombreApellido", pasajero.NombreApellido);
                    cmd.Parameters.AddWithValue("@Nacionalidad", pasajero.Nacionalidad);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", pasajero.FechaNacimiento);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Pasajero> ListarPasajeros()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "SELECT IdPasajero, Pasaporte, NombreApellido, Nacionalidad, FechaNacimiento FROM Pasajeros";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaPasajeros.Add(new Pasajero
                        {
                            IdPasajero = (int)reader["IdPasajero"],
                            Pasaporte = reader["Pasaporte"].ToString(),
                            NombreApellido = reader["NombreApellido"].ToString(),
                            Nacionalidad = reader["Nacionalidad"].ToString(),
                            FechaNacimiento = (DateTime)reader["FechaNacimiento"]
                        });
                    }
                }
            }
            return listaPasajeros;
        }
        public void ModificarPasajero(Pasajero pasajero)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "UPDATE Pasajeros SET Pasaporte=@Pasaporte, NombreApellido=@NombreApellido, " +
                             "Nacionalidad=@Nacionalidad, FechaNacimiento=@FechaNacimiento " +
                             "WHERE IdPasajero=@IdPasajero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Pasaporte", pasajero.Pasaporte);
                    cmd.Parameters.AddWithValue("@NombreApellido", pasajero.NombreApellido);
                    cmd.Parameters.AddWithValue("@Nacionalidad", pasajero.Nacionalidad);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", pasajero.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@IdPasajero", pasajero.IdPasajero);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPasajero(int idPasajero)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "DELETE FROM Pasajeros WHERE IdPasajero=@IdPasajero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdPasajero", idPasajero);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void AgregarPasaje(Pasaje pasaje)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "INSERT INTO Pasajes (NumeroAsiento, FechaVuelo, IdAvion, IdPasajero) " +
                             "VALUES (@NumeroAsiento, @FechaVuelo, @IdAvion, @IdPasajero)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NumeroAsiento", pasaje.NumeroAsiento);
                    cmd.Parameters.AddWithValue("@FechaVuelo", pasaje.FechaVuelo);
                    cmd.Parameters.AddWithValue("@IdAvion", pasaje.Avion.IdAvion);
                    cmd.Parameters.AddWithValue("@IdPasajero", pasaje.Pasajero.IdPasajero);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Pasaje> ListarPasajes()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "SELECT IdPasaje, NumeroAsiento, FechaVuelo, IdAvion, IdPasajero FROM Pasajes";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaPasajes.Add(new Pasaje
                        {
                            IdPasaje = (int)reader["IdPasaje"],
                            NumeroAsiento = reader["NumeroAsiento"].ToString(),
                            FechaVuelo = (DateTime)reader["FechaVuelo"],

                            Avion = new Avion
                            {
                                IdAvion = (int)reader["IdAvion"]
                            },

                            Pasajero = new Pasajero
                            {
                                IdPasajero = (int)reader["IdPasajero"]
                            }
                        });
                    }
                }
            }
            return listaPasajes;
        }

        public void ModificarPasaje(Pasaje pasaje)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "UPDATE Pasajes SET NumeroAsiento=@NumeroAsiento, FechaVuelo=@FechaVuelo, " +
                             "IdAvion=@IdAvion, IdPasajero=@IdPasajero WHERE IdPasaje=@IdPasaje";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NumeroAsiento", pasaje.NumeroAsiento);
                    cmd.Parameters.AddWithValue("@FechaVuelo", pasaje.FechaVuelo);
                    cmd.Parameters.AddWithValue("@IdAvion", pasaje.Avion.IdAvion);
                    cmd.Parameters.AddWithValue("@IdPasajero", pasaje.Pasajero.IdPasajero);
                    cmd.Parameters.AddWithValue("@IdPasaje", pasaje.IdPasaje);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPasaje(int idPasaje)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "DELETE FROM Pasajes WHERE IdPasaje=@IdPasaje";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdPasaje", idPasaje);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
