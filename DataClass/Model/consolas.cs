using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratioFinal.DataClass
{
    internal class consolas    
    {
        public int id_consola { get; set; }
        public string nombre_consola { get; set; }
        public string compania { get; set; }
        public int anio_lanzamiento { get; set; }
        public int generacion { get; set; }

        public consolas (int ID, string Nombre, string Compania, int Anio_Lanzamiento, int Generacion)
        {
            id_consola = ID;
            nombre_consola = Nombre;
            compania = Compania;
            anio_lanzamiento = Anio_Lanzamiento;
            generacion = Generacion;
        }
    }
}
