using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratioFinal.DataClass
{
    internal class consolas
    {
        private string connectionString = "Server=localhost; Database=db_universidad;Uid=root;Pwd = Casttle32057881 ";
        public int ID { get; set; }
        public string Nombre_consola { get; set; }
        public string Compania { get; set; }
        public int Anio_lanzamiento { get; set; }
        public int Generacion { get; set; }

        public consolas() { }

        public consolas(int id, string nombre_consola, string compania, int anio_lanzamiento, int generacion)
        {
            ID = id;
            Nombre_consola = nombre_consola;
            Compania = compania;
            Anio_lanzamiento = anio_lanzamiento;
            Generacion = generacion;
        }
    }
}
