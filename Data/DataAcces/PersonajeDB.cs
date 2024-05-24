using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_1.data.data_acces
{

    internal class PersonajeDB
    {
        private string connectionString = "Server=localhost;Database=db_alumno_universidad;Uid=root;Pwd=DMBDAD";
        public bool ProbarConexion()
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try { connection.Open();
                    return true;
                }
                catch (Exception)
                { return false; }
            }
        }

        // Método para leer todos los personajes
        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball ";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }

        public int CrearPersonaje(string nombre, string raza, int nivelPoder, string historia, DateTime fechaCreacion)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();



                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder, historia, fecha_creacion) VALUES (@nombre, @raza, @nivelPoder, @historia, @fechaCreacion)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@historia", historia);
                    command.Parameters.AddWithValue("@fechaCreacion", fechaCreacion);
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
