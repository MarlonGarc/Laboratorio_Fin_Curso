using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaboratioFinal.DataClass;
using LaboratioFinal.DataClass.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaboratioFinal
{
    public partial class Form1 : Form
    {
        private consolas Cargar;
        ConeccionMySQL CLS = new ConeccionMySQL();
        consolas cnsls = new consolas();
        List<consolas> todas = new List<consolas>();
        ClsCursor cursor1 = new ClsCursor();
        public Form1()
        {
            InitializeComponent();
            Cargar = new consolas();
            LlenarComboBox();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            todas = CLS.ObtenerTodasConsolas();
            dataGridViewRegistro.DataSource = todas;

            if (todas.Count > 0)
            {
                cursor1.totalRegistros = todas.Count;
                MessageBox.Show("Total De Registros:" + cursor1.totalRegistros);

            }
            else
            {
                MessageBox.Show("No hay registros");

            }
        }
        private void MostrarRegistroConsolas()
        {
            if (cursor1.current >= 0 && cursor1.current < cursor1.totalRegistros)
            {
                consolas c = todas[cursor1.current];
                textBoxID.Text = c.ID.ToString();
                textBoxNombre.Text = c.Nombre_consola;
                textBoxCompania.Text = c.Compania;
                textBoxAnio.Text = c.Anio_lanzamiento.ToString();
                textBoxGeneracion.Text = c.Generacion.ToString();

                //incrementar el cursor y validar que no se pase del total de registros
                cursor1.current++;
                if (cursor1.current >= cursor1.totalRegistros)
                {
                    cursor1.current = 0;
                    MessageBox.Show("Fin de los registros");
                }
            }
        }
        private void LlenarComboBox()
        {
            comboBox1.Items.AddRange(new string[] { "Atari", "Coleco", "Mattel", "Microsoft", "Nintendo", "Ouya Inc.", "Sega", "Sony" });
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            MostrarRegistroConsolas();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consolaSeleccionada = comboBox1.SelectedItem.ToString();
            List<consolas> consolasFiltradas = todas.Where(c => c.Compania == consolaSeleccionada).ToList();
            dataGridViewRegistro.DataSource = consolasFiltradas;
        }

    }
}
