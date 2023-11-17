using LibreriaClases.Excepciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.DataBase
{
    public class GestorSQL
    {
        private static string stringConnection;

        static GestorSQL()
        {
            GestorSQL.stringConnection = "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;";
        }

        /// <summary>
        /// Obtiene un elemento de la base de datos por su ID.
        /// </summary>
        /// <typeparam name="T">Tipo de entidad a recuperar.</typeparam>
        /// <param name="id">ID del elemento que se desea recuperar.</param>
        /// <returns>
        /// Una instancia de la entidad T si se encuentra en la base de datos; de lo contrario, devuelve null.
        /// </returns>
        /// <exception cref="BaseDeDatosException">
        /// Se lanza en caso de error al interactuar con la base de datos.
        /// </exception>
        //public static T ObtenerElementoPorId<T>(int id)
        //    where T : class, new()
        public static string ObtenerElementoPorId<T>(int id)
        {
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
            //    {
            //        connection.Open(); 

            //        string query = $"SELECT * FROM mascotas WHERE id_mascota = {id}";

            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            using (SqlDataReader reader = command.ExecuteReader())
            //            {
            //                if (reader.Read())
            //                {
            //                    T elemento = new T();

            //                    // Lógica de mapeo de datos desde el SqlDataReader al objeto T

            //                    return elemento;
            //                }
            //            }
            //        }

            //    }
            //    return null;
            //}
            SqlConnection connection = new SqlConnection(GestorSQL.stringConnection);
            string query = $"SELECT * FROM mascotas WHERE id_mascota = {id}";
            try 
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return reader[0].ToString();
                }
                return "no se encontro nada";

            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("error al obtener elemento por id", ex);
            }
        }
    }
}
