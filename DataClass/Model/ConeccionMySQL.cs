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

        public DataTable LeerCatalogo()
        {
            DataTable Catalogo = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "Select * from catalogo_consolas";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(Catalogo);
                    }
                }
            }
            return Catalogo;
        }
        
    }
}
