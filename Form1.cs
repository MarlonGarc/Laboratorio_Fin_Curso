using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaboratioFinal.DataClass.Model;

namespace LaboratioFinal
{
    public partial class Form1 : Form
    {
        private ConeccionMySQL catalogo;
        public Form1()
        {
            InitializeComponent();
            catalogo = new ConeccionMySQL();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewRegistro.DataSource = catalogo.LeerCatalogo();
        }
    }
}
