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
        /// <summary>
        /// Ejecuta una consulta SQL con un delegado para realizar acciones específicas.
        /// </summary>
        /// <typeparam name="T">Tipo de retorno del delegado.</typeparam>
        /// <param name="query">Consulta SQL a ejecutar.</param>
        /// <param name="action">Delegado que realiza acciones específicas con el comando SQL.</param>
        public T EjecutarQuery<T>(string query, Func<SqlCommand, T> action)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        return action(command);
                    }
                }
                catch (Exception ex)
                {
                    throw new BaseDeDatosException("Error al ejecutar la consulta", ex);
                }
            }
        }

        /// <summary>
        /// Obtiene el ID del dueño asociado a un ID de persona.
        /// </summary>
        /// <param name="id">ID de persona.</param>
        /// <returns>ID del dueño.</returns>
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
                                //caso contrario me devuelve 0
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
        /// <summary>
        /// Obtiene una lista de mascotas asociadas a un ID de persona.
        /// </summary>
        /// <param name="id">ID de persona.</param>
        /// <returns>Lista de mascotas.</returns>
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
                                    altaMedica = Convert.IsDBNull(reader["AltaMedica"]) ? false : Convert.ToBoolean(reader["AltaMedica"]),
                                    estadoCalendario = Convert.IsDBNull(reader["VacunasAplicadas"]) ? false : Convert.ToBoolean(reader["VacunasAplicadas"]),
                                    estadoEnfermo = Convert.IsDBNull(reader["EstadoEnfermo"]) ? false : Convert.ToBoolean(reader["EstadoEnfermo"]),
                                    idVeterinario = Convert.ToInt32(reader["IdVeterinario"])

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
        /// <summary>
        /// Verifica la existencia de un usuario por su correo electrónico y contraseña.
        /// </summary>
        /// <param name="correoElectronico">Correo electrónico del usuario.</param>
        /// <param name="contra">Contraseña del usuario.</param>
        /// <returns>ID del usuario si existe, de lo contrario, 0.</returns>
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
        /// <summary>
        /// Obtiene el nombre de un usuario por su ID.
        /// </summary>
        /// <param name="idUsuario">ID del usuario.</param>
        /// <returns>Nombre del usuario.</returns>
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
