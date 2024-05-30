using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LaboratioFinal.DataClass.Model
{
    internal class ConeccionMySQL
    {
        private string connectionString = "Server=localhost; Database=db_universidad;Uid=root;Pwd = Casttle32057881 ";
        MySqlConnection connection;

        public ConeccionMySQL()
        {
            connection = new MySqlConnection(connectionString);
        }

        public List<consolas> ObtenerTodasConsolas()
        {
            List<consolas> consolas = new List<consolas>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM catalogo_consolas";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        consolas consola = new consolas
                        (
                            id: reader.GetInt32("id_consola"),
                            nombre_consola: reader.GetString("nombre_consola"),
                            compania: reader.GetString("Compania"),
                            anio_lanzamiento: reader.GetInt32("anio_lanzamiento"),
                            generacion: reader.GetInt32("generacion")

                            );


                        consolas.Add(consola);
                        count++;

                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                return consolas;
            }
        }
    }
}
