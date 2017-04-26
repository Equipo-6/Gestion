using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Escolar
{
   
    public partial class Control_Escolar : Form
    {
        public Control_Escolar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bajas_Alumnos Alumnos_Bajas = new Bajas_Alumnos();
            Alumnos_Bajas.Show();
        }

        private void reinscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos_Inscripciones formularioAlumnos = new Alumnos_Inscripciones();
            formularioAlumnos.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cambios_Alumnos Alumnos_Cambios = new Cambios_Alumnos();
            Alumnos_Cambios.Show();
        }

        private void busquedaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            Busqueda_Alumnos Alumnos_Busqueda = new Busqueda_Alumnos();
            Alumnos_Busqueda.Show();
        }

        private void busquedaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Busqueda_Profesores Profesores_Busqueda = new Busqueda_Profesores();
            Profesores_Busqueda.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Altas_Profesores Profesores_Altas = new Altas_Profesores();
            Profesores_Altas.Show();

        }

        private void bjasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bajas_Profesores Profesores_Bajas = new Bajas_Profesores();
            Profesores_Bajas.Show();
        }

        private void cambiosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cambios_Profesores Profesores_Cambios = new Cambios_Profesores();
            Profesores_Cambios.Show();
        }
    }
}
