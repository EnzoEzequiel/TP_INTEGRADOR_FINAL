using LibreriaClases.Excepciones;
using LibreriaClases.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace LibreriaClases.DataBase
{
    public class GestorSQL
    {
        private static readonly string stringConnection = "Server=DESKTOP-FBL3OPJ\\SQLEXPRESS;Database=veterinaria;Trusted_Connection=True;TrustServerCertificate=Yes;";

        public void EjecutarQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new BaseDeDatosException("Error al ejecutar la consulta", ex);
                }
            }
        }

        public T ObtenerElementoPorId<T>(string nombreTabla, int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {

                string query = $"SELECT * FROM {nombreTabla} WHERE Id{nombreTabla} = {id}";

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lógica de mapeo de datos desde el SqlDataReader al objeto T
                                // Debes implementar esta lógica según tus necesidades

                                return default; // Devuelve el objeto mapeado
                            }
                            reader.Close();
                        }

                    }
                }
                catch (Exception ex)
                {
                    throw new BaseDeDatosException("Error al obtener elemento por id", ex);
                }
            }
            return default;
        }
        
        public int ObtenerDueñoByIdPersona(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string query = $"SELECT IdDueño FROM Dueños WHERE IdPersona = {id}";

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                reader.Close();
                                object result = command.ExecuteScalar();
                                
                                return result != null ? Convert.ToInt32(result) : 0;

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new BaseDeDatosException("Error al obtener todas las mascotas", ex);
                }
                finally
                {
                    connection.Close();
                }

                return 0;
            }
        }

        public IEnumerable<Mascota> ObtenerMascotasByIdPersona(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string query = $"SELECT * FROM Mascotas WHERE IdDueño = {id}";
                List<Mascota> listaMascotas = new List<Mascota>();

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Mascota mascota = new Mascota
                                {
                                    IdMascota = Convert.ToInt32(reader["IdMascota"]),
                                    nombreMascota = reader["Nombre"].ToString(),
                                    fechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                    altaMedica = Convert.ToBoolean(reader["AltaMedica"])
                                };

                                listaMascotas.Add(mascota);
                            }

                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new BaseDeDatosException("Error al obtener todas las mascotas", ex);
                }
                finally
                {
                    connection.Close();
                }
                return listaMascotas;
            }
        }


        public IEnumerable<T> ObtenerTodos<T>()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string nombreTabla = typeof(T).Name;

                string query = $"SELECT * FROM {nombreTabla}";

                List<T> listaElementos = new List<T>();

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Lógica de mapeo de datos desde el SqlDataReader al objeto T
                                // Debes implementar esta lógica según tus necesidades
                                T elemento = default;
                                listaElementos.Add(elemento);
                            }
                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new BaseDeDatosException("Error al obtener todos los elementos", ex);
                }

                return listaElementos;
            }
        }

        public bool ExisteMascotaPorNombreYNacimiento(string nombre, string fNacimiento)
        {

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string query = $"SELECT IdPersona FROM Personas WHERE Nombre = '{nombre}' AND FechaNacimiento = '{fNacimiento}'";

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new BaseDeDatosException("Error al verificar usuario por correo", ex);
                }
                finally { connection.Close(); }
            }
        }

        public int ExisteUsuarioPorCorreo(string correoElectronico, string contra)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string query = $"SELECT IdPersona FROM Personas WHERE Email = '{correoElectronico}' AND Contraseña = '{contra}'";

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new BaseDeDatosException("Error al verificar usuario por correo", ex);
                }
                finally { connection.Close(); }
            }
        }

        public string ObtenerNombrePorId(int idUsuario)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string query = $"SELECT Nombre FROM Personas WHERE IdPersona = {idUsuario}";

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        return result != null ? Convert.ToString(result) : "";
                    }
                }
                catch (Exception ex)
                {
                    throw new BaseDeDatosException("Error al verificar usuario por correo", ex);
                }
                finally { connection.Close(); }
            }
        }
    }
}
